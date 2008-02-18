using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hoo.MonitorService {

    class MessageListenForm : Form {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MonitorMessageNotifier manager = null;


        #region Declare API for lock notification

        // from wtsapi32.h
        private const int NotifyForThisSession = 0;
        private bool registered = false;
        [DllImport("wtsapi32.dll")]
        private static extern bool WTSRegisterSessionNotification(IntPtr hWnd, int dwFlags);
        [DllImport("wtsapi32.dll")]
        private static extern bool WTSUnRegisterSessionNotification(IntPtr hWnd);

        // from winuser.h for session
        private const int WM_WTSSESSION_CHANGE = 0x02B1;
        private const int WTS_SESSION_LOCK = 0x7;
        private const int WTS_SESSION_UNLOCK = 0x8;

        //for monitor power
        private const uint WM_SYSCOMMAND = 0x0112;
        
        private const int SC_MONITORPOWER = 0xf170;        
        private const int MONITOR_ON_PARAM = -1;
        private const int MONITOR_OFF_PARAM = 2;

        private const int SC_SCREENSAVE = 0xf140;
        private const int SCREENSAVER_ON_PARAM = 0;

        #endregion

        #region Initialize Form

        //Disable construsctor without parameters.
        private MessageListenForm() {
            //
        }

        public MessageListenForm(MonitorMessageNotifier m) {
            manager = m;
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // MessageListenForm
            // 
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1, 1);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageListenForm";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        #region Register/Unregister message notification

        /// <summary>
        /// Register for event notifications
        /// </summary>
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);

            // WtsRegisterSessionNotification requires Windows XP or higher
            bool haveXp = Environment.OSVersion.Platform == PlatformID.Win32NT &&
                                (Environment.OSVersion.Version.Major > 5 ||
                                    (Environment.OSVersion.Version.Major == 5 &&
                                     Environment.OSVersion.Version.Minor >= 1));

            if (haveXp)
                registered = WTSRegisterSessionNotification(Handle, NotifyForThisSession);
            Console.WriteLine("Start HWND: " + Handle.ToString());

            return;
        }

        /// <summary>
        /// Unregister for event notifications
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (registered) {
                IntPtr hwnd = Handle;
                Console.WriteLine("End HWND: " + hwnd.ToString());
                WTSUnRegisterSessionNotification(hwnd);
                registered = false;
            }
            base.Dispose(disposing);
            return;
        }


        #endregion



        /// <summary>
        /// Process windows messages
        /// </summary>
        protected override void WndProc(ref Message m) {
            MonitorEventArgs args = new MonitorEventArgs(Environment.UserName);
            int msg = m.Msg;
            int wparam = m.WParam.ToInt32();
            int lparam = m.LParam.ToInt32();

            // check for session change notifications
            if (msg == WM_WTSSESSION_CHANGE) {
                if (wparam == WTS_SESSION_LOCK)
                    manager.OnMonitorLocked(args);
                else if (wparam == WTS_SESSION_UNLOCK)
                    manager.OnMonitorUnlocked(args);
            } else if (m.Msg == WM_SYSCOMMAND && wparam == SC_MONITORPOWER) {
                if (wparam == SC_MONITORPOWER) {
                    if (m.LParam.ToInt32() == MONITOR_ON_PARAM)
                        manager.OnMonitorOpened(args);
                    else if (m.LParam.ToInt32() == MONITOR_OFF_PARAM)
                        manager.OnMonitorShutdown(args);
                } else if(wparam == SC_SCREENSAVE) {
                    log.Debug("Screen Saver messages: " + m.ToString());
                }
            }

            //log.Debug("messages: " + m.ToString());
            base.WndProc(ref m);
            return;
        }





    }
}
