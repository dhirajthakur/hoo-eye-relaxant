using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Hoo.InputDevice {
    public abstract class InputDeviceHook {
       
        /// <summary>
        /// Type ID of hook, such as WH_KEYBOARD_LL or WH_MOUSE_LL;
        /// Every concrete class should define it.
        /// </summary> 
        protected HookTypeID _hookType;


        /// <summary>
        /// hook for mouse or keyboard
        /// </summary>
        protected IntPtr _hook = IntPtr.Zero;


        /// <summary>
        /// 键盘钩子委托实例
        /// </summary>
        /// <remarks>
        /// 不要试图省略此变量,否则将会导致
        /// 激活 CallbackOnCollectedDelegate 托管调试助手 (MDA)。 
        /// 详细请参见MSDN中关于 CallbackOnCollectedDelegate 的描述
        /// </remarks>
        protected HookProc _hookHandler;


        public virtual bool DisableDevice { get; set; }
       

        /// <summary>
        /// 键盘钩子处理函数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>      
        protected abstract int HookProc(int nCode, Int32 wParam, IntPtr lParam);


        /// <summary>
        /// 安装钩子
        /// </summary>
        /// <returns></returns>
        public virtual bool InstallHook() {
           
            IntPtr pInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().ManifestModule);

            if (this._hook == IntPtr.Zero) {
                this._hookHandler = new HookProc(HookProc);
                this._hook = Win32API.SetWindowsHookEx(_hookType, this._hookHandler, pInstance, 0);
                if (this._hook == IntPtr.Zero) {
                    this.UnInstallHook();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 卸载钩子
        /// </summary>
        /// <returns></returns>
        public virtual bool UnInstallHook() {
            bool result = true;        
            if (this._hook != IntPtr.Zero) {
                result = (Win32API.UnhookWindowsHookEx(this._hook) && result);
                this._hook = IntPtr.Zero;
            }

            return result;
        }
        
    }
}
