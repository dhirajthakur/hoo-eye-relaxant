using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace Hush.Relaxant {
    

    class DisplayController {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public static void TurnOn() {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }

        public static void TurnOff() {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        static readonly IntPtr HWND_BROADCAST = new IntPtr(0xffff);
        const uint WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xf170;
    }
}
