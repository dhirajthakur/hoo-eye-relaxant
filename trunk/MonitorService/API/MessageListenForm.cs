using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hoo.Device.Monitor {

    class MessageListenForm : Form {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MonitorMessageNotifier manager = null;


        private bool registered = false;
        


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

            
            if (haveXp) {
                log.Info("Registering session notification to WindowsXP");
                registered = Win32Helper.WTSRegisterSessionNotification(Handle, Win32Helper.NOTIFY_FOR_THIS_SESSION);
            }
            log.Debug("Start HWND: " + Handle.ToString());

            return;
        }

        /// <summary>
        /// Unregister for event notifications
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (registered) {
                IntPtr hwnd = Handle;
                log.Debug("End HWND: " + hwnd.ToString());
                Win32Helper.WTSUnRegisterSessionNotification(hwnd);
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
            WindowsMessages msg = (WindowsMessages)m.Msg;
            int wparam = m.WParam.ToInt32();
            int lparam = m.LParam.ToInt32();

            // check for session change notifications
            if (msg == WindowsMessages.WM_WTSSESSION_CHANGE) {
                log.Info("Get system message: Monitor session changed: wparam" + m.ToString());
                if (wparam == (int)WTS.WTS_SESSION_LOCK) {
                    manager.OnMonitorLocked(args);
                } else if (wparam == (int)WTS.WTS_SESSION_UNLOCK) {
                    manager.OnMonitorUnlocked(args);
                }
            } else if (msg == WindowsMessages.WM_SYSCOMMAND) {
                if (wparam == (int)SysCommands.SC_MONITORPOWER) {
                    log.Info("Get system message: Monitor Power. Lparam: " + m.ToString());
                    if (m.LParam.ToInt32() == Win32Helper.MONITOR_ON_PARAM)
                        manager.OnMonitorOpened(args);
                    else if (m.LParam.ToInt32() == Win32Helper.MONITOR_OFF_PARAM)
                        manager.OnMonitorShutdown(args);
                } else if (wparam == (int)SysCommands.SC_SCREENSAVE) {
                    log.Info("Get system message: Monitor PowerScreen Saver. " + m.ToString());
                }
            }

            log.Debug("messages: " + m.ToString());
            base.WndProc(ref m);
            return;
        }





    }
}
