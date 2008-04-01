using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections.Generic;


namespace Hoo.Device.Keyboard {
    public class KeyboardHook : InputDeviceHook {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        #region Singleton pattern code

        private static KeyboardHook _instance = null;
        /// <summary>
        /// Implements Singleton pattern
        /// </summary>
        /// <returns></returns>
        public static KeyboardHook getInstance() {
            if (_instance == null) {
                _instance = new KeyboardHook();
            }

            return _instance;
        }

        #endregion

        public override bool DisableDevice { get; set; }

        public IList<Keys> ExceptKeys { get; set; }

        private KeyboardHook() {
            HookType = HookTypeID.WH_KEYBOARD_LL ;
            Win32Helper.GetKeyboardState(this._keyState);
            DisableDevice = false;
            ExceptKeys = new List<Keys>();

        }

        /// <summary>
        /// 按键状态数组
        /// </summary>
        private readonly byte[] _keyState = new byte[256];



        // 添加        
        private const byte VK_SHIFT = 0x10;
        private const byte VK_CAPITAL = 0x14;
        private const byte VK_NUMLOCK = 0x90;


        /// <summary>
        /// 按键按下事件
        /// </summary>
        public event KeyEventHandler OnKeyDown;

        /// <summary>
        /// 按键按下并释放事件
        /// </summary>
        public event KeyPressEventHandler OnKeyPress;

        /// <summary>
        /// 按键释放事件
        /// </summary>
        public event KeyEventHandler OnKeyUp;





        /// <summary>
        /// 键盘钩子处理函数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        /// <remarks>此版本的键盘事件处理不是很好,还有待修正.</remarks>
        protected override int HookProc(int nCode, Int32 wParam, IntPtr lParam) {


            if (log.IsDebugEnabled) log.Debug(String.Format("Captured key press. code {0}, wparam {1}, lparam {2}.", nCode, wParam, lParam));

            //Disable keyboard.
            if (DisableDevice) {
                bool notExceptKey = true;
                if (nCode >= 0) {
                    KeyboardHookStruct keyStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                    Keys keyData = (Keys)keyStruct.VKCode;
                    foreach(Keys key in ExceptKeys) {
                        if(key.Equals(keyData)) {
                            if (log.IsDebugEnabled) log.Debug(String.Format("Captured hot key '{0}' when disable keyboard press.", keyData));
                            notExceptKey = false;
                            break;
                        }
                    }                    
                }

                if (notExceptKey) return 1;
                
            }

            bool handled = false;
            //it was ok and someone listens to events
            if (nCode >= 0) {
                KeyboardHookStruct keyStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                //raise KeyDown
                if (OnKeyDown != null && (wParam == (int)WM_KEYBOARD.WM_KEYDOWN || wParam == (int)WM_KEYBOARD.WM_SYSKEYDOWN)) {
                    Keys keyData = (Keys)keyStruct.VKCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    this.OnKeyDown(this, e);
                    handled = handled || e.Handled;
                }

                // raise KeyUp
                if (this.OnKeyUp != null && (wParam == (int)WM_KEYBOARD.WM_KEYUP || wParam == (int)WM_KEYBOARD.WM_SYSKEYUP)) {
                    Keys keyData = (Keys)keyStruct.VKCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    this.OnKeyUp(this, e);
                    handled = handled || e.Handled;
                }

     
                // raise KeyPress
                if (this.OnKeyPress != null && wParam == (int)WM_KEYBOARD.WM_KEYUP) {
                    bool isDownShift = false, isDownCapslock = false;
                    try {
                        isDownShift = ((Win32Helper.GetKeyStates(VK_SHIFT) & 0x80) == 0x80 ? true : false);
                        isDownCapslock = (Win32Helper.GetKeyStates(VK_CAPITAL) != 0 ? true : false);
                    } catch {
                        //
                    }

                    byte[] keyState = new byte[256];
                    Win32Helper.GetKeyboardState(keyState);
                    byte[] inBuffer = new byte[2];
                    int result = Win32Helper.ToAscii(keyStruct.VKCode, keyStruct.ScanCode, keyState, inBuffer, keyStruct.Flags);
                    if (log.IsDebugEnabled) log.Debug(String.Format("Key converting result is '{0}'", result));

                    if ( result == 1) {
                        char key = (char)inBuffer[0];

                        if ((isDownCapslock ^ isDownShift) && Char.IsLetter(key)) 
                            key = Char.ToUpper(key);

                        if (log.IsDebugEnabled) log.Debug(String.Format("Captured key press '{0}'", key));

                        KeyPressEventArgs e = new KeyPressEventArgs(key);
                        this.OnKeyPress(this, e);
                        
                        handled = handled || e.Handled;
                    }
                }
                

            }

            //if event handled in application do not handoff to other listeners
            if (handled)
                return 1;
            else
                return Win32Helper.CallNextHookEx(this._hook, nCode, wParam, lParam);
        }


    }
}
