using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
namespace Hoo.MonitorService {
    public class MonitorController {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public static void TurnOn() {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }

        /// <summary>
        /// Turn off the power of computer monitor.
        /// The power will be automatically turn on when move mouse or click any key.
        /// </summary>
        public static void TurnOff() {
            Thread.Sleep(1500); // Waite 1.5 seconds in order to avoid any mouse events.
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        static readonly IntPtr HWND_BROADCAST = new IntPtr(0xffff);
        const uint WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xf170;
    }
}
