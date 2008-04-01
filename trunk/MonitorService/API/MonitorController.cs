using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
namespace Hoo.Device.Monitor {
    public class MonitorController {

        
        public static void TurnOn() {
            Win32Helper.SendMessage(Win32Helper.HWND_BROADCAST, (uint)WindowsMessages.WM_SYSCOMMAND, (int)SysCommands.SC_MONITORPOWER, Win32Helper.MONITOR_ON_PARAM);
        }

        /// <summary>
        /// Turn off the power of computer monitor.
        /// The power will be automatically turn on when move mouse or click any key.
        /// </summary>
        public static void TurnOff() {
            Thread.Sleep(500); // Waite 0.5 seconds in order to avoid any mouse events.
            Win32Helper.SendMessage(Win32Helper.HWND_BROADCAST, (uint)WindowsMessages.WM_SYSCOMMAND, (int)SysCommands.SC_MONITORPOWER, Win32Helper.MONITOR_OFF_PARAM);
        }
        
    }
}
