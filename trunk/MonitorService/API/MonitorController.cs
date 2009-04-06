using System;
using System.Diagnostics;
namespace Hoo.Device.Monitor {
    public class MonitorController {
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// Get any existed windows' hwnd for message API, as a alternative of HWND_BROADCAST. 
		/// This method get hwnd from explorer.
		/// </summary>
		/// <returns></returns>
		private static IntPtr GetWindowHandle() {
			IntPtr hwnd = IntPtr.Zero;
			Process[] processes = Process.GetProcessesByName("explorer");

			foreach (Process p in processes) {
				hwnd = p.MainWindowHandle;
				if (hwnd != null && hwnd != IntPtr.Zero) {
					log.Debug("process is: " + p.ToString());
					log.Debug("Windows handle: " + hwnd);
					break;
				}
			}

			if (hwnd == null || hwnd == IntPtr.Zero) {
				log.Debug("Failed to find windows handler");
			}
			return hwnd;
		}
        
		/// <summary>
		/// Turn on computer monitor.
		/// </summary>
		/// <remarks>
		/// In fact this API could never be called. When computer get any input (Keyboard, mouse, network), the monitor will be opned automatically at first.
		/// </remarks>
        public static void TurnOn() {
			Win32Helper.PostMessage(Win32Helper.HWND_BROADCAST, (uint)WindowsMessages.WM_SYSCOMMAND, (int)SysCommands.SC_MONITORPOWER, Win32Helper.MONITOR_ON_PARAM);
        }

		public static void TurnOff(IntPtr hwnd) {
			log.Debug("Hwnd " + hwnd + " Turning off monitor...");
			Win32Helper.SendMessage(hwnd, (uint)WindowsMessages.WM_SYSCOMMAND, (int)SysCommands.SC_MONITORPOWER, Win32Helper.MONITOR_OFF_PARAM);
			log.Debug("Turned off monitor");
		}


        /// <summary>
        /// Turn off the power of computer monitor.
        /// The power will be automatically turn on when move mouse or click any key.
        /// </summary>
		/// <remarks>
		/// Warning: do not send such message to Win32Helper.HWND_BROADCAST. 
		/// There are hunderds of windows accept message send to HWND_BRODCAST. It may caused monitor keep flashing between on and off. 
		/// </remarks>
        public static void TurnOff() {
			IntPtr hwnd = GetWindowHandle();
			TurnOff(hwnd);
        }
        
    }
}
