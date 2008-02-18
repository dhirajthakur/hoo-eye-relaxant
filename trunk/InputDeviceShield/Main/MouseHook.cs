using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using Hoo.Common;

namespace Hoo.InputDevice {

    /// <summary>
    /// Hook process for mouse
    /// </summary>
    public class MouseHook : InputDeviceHook {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public bool DisableMove { get; set; }
        public bool DisableButton { get; set; }
        public bool DisableWheel { get; set; }

        public override bool DisableDevice {
            get { return (DisableMove & DisableButton & DisableWheel); }
            set {
                DisableMove = true;
                DisableWheel = true;
                DisableButton = true;
            }
        }

        public MouseHook() {
            _hookType = HookTypeID.WH_MOUSE_LL;
            DisableMove = false;
            DisableWheel = false;
            DisableButton = false;

        }

        
        public event MouseEventHandler OnMouseActivity;

        /// <summary>
        /// 鼠标更新事件
        /// </summary>
        /// <remarks>当鼠标移动或者滚轮滚动时触发</remarks>
        public event MouseUpdateEventHandler OnMouseUpdate;



        /// <summary>
        /// Procedure for mouse hook
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        protected override int HookProc(int nCode, Int32 wParam, IntPtr lParam) {
                  
            if (nCode >= 0) {
                //Try to disable mouse actions.
                if (DisableMove) {
                    return 1;
                } else if (DisableWheel & wParam == (int)WM_MOUSE.WM_MOUSEWHEEL) {
                    return 1;
                } else if (DisableButton) {
                    if (wParam != (int)WM_MOUSE.WM_MOUSEFIRST && wParam != (int)WM_MOUSE.WM_MOUSEMOVE && wParam != (int)WM_MOUSE.WM_MOUSEWHEEL) {
                        return 1;
                    }
                }
            }


            if ((nCode >= 0) && (OnMouseActivity != null)) {
                //Marshall the data from callback.
                MouseHookStruct hookStruct = (MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseHookStruct));

                //detect button clicked
                MouseButtons button = MouseButtons.None;
                short mouseDelta = 0;
                switch (wParam) {
                    case (int)WM_MOUSE.WM_LBUTTONDOWN:
                    case (int)WM_MOUSE.WM_LBUTTONUP:
                    case (int)WM_MOUSE.WM_LBUTTONDBLCLK:
                        button = MouseButtons.Left;
                        break;
                    case (int)WM_MOUSE.WM_RBUTTONDOWN:
                    case (int)WM_MOUSE.WM_RBUTTONUP:
                    case (int)WM_MOUSE.WM_RBUTTONDBLCLK:
                        button = MouseButtons.Right;
                        break;
                    case (int)WM_MOUSE.WM_MOUSEWHEEL:
                        //If the message is WM_MOUSEWHEEL, the high-order word of mouseData member is the wheel delta. 
                        //One wheel click is defined as WHEEL_DELTA, which is 120. 
                        //(value >> 16) & 0xffff; retrieves the high-order word from the given 32-bit value
                        mouseDelta = (short)((hookStruct.MouseData >> 16) & 0xffff);
                        break;
                    //TODO: X BUTTONS (I havent them so was unable to test)
                    //If the message is WM_XBUTTONDOWN, WM_XBUTTONUP, WM_XBUTTONDBLCLK, WM_NCXBUTTONDOWN, WM_NCXBUTTONUP, 
                    //or WM_NCXBUTTONDBLCLK, the high-order word specifies which X button was pressed or released, 
                    //and the low-order word is reserved. This value can be one or more of the following values. 
                    //Otherwise, mouseData is not used. 

                }

                //double clicks
                int clickCount = 0;
                if (button != MouseButtons.None) {
                    if (log.IsDebugEnabled)
                        log.Debug(StringUtil.Join("Captured mouse button. code %1, wparam %2, lparam %3.", nCode, wParam, lParam));

                    if (wParam == (int)WM_MOUSE.WM_LBUTTONDBLCLK || wParam == (int)WM_MOUSE.WM_RBUTTONDBLCLK) clickCount = 2;
                    else clickCount = 1;
                }

                //generate event 
                MouseEventArgs e = new MouseEventArgs(button, clickCount, hookStruct.Point.X, hookStruct.Point.Y, mouseDelta);
                //raise it
                OnMouseActivity(this, e);
            }

            return Win32API.CallNextHookEx(this._hook, nCode, wParam, lParam);
        }


    }
}
