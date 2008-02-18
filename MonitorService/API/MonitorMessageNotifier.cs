using System;
using System.Threading;
using System.Windows.Forms;
namespace Hoo.MonitorService {

    public class MonitorMessageNotifier : IMonitorEvents {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Thread listenThread;
        MessageListenForm listenForm;

        public static bool IsMonitorShutdown { get; set; }

   
        public static bool IsMonitorLocked { get; set; }


        public static bool IsSreenSaverRuning { get; set; }

        #region Throw monitor events


        public event EventHandler<MonitorEventArgs> MonitorLocked;
        internal void OnMonitorLocked(MonitorEventArgs args) {
            log.Info("Notify MonitorLocked: " + args.ToString());
            IsMonitorLocked = true;
            if (MonitorLocked != null) {
                MonitorLocked(this, args);
            }

        }

        public event EventHandler<MonitorEventArgs> MonitorUnlocked;
        internal void OnMonitorUnlocked(MonitorEventArgs args) {
            log.Info("Notify MonitorUnlocked: " + args.ToString());
            IsMonitorLocked = false;
            if (MonitorUnlocked != null) {
                MonitorUnlocked(this, args);
            }
        }

        //TODO Listen ScreenSaver Events
        public event EventHandler<MonitorEventArgs> ScreenSaverStarted;
        internal void OnScreenSaverStarted(MonitorEventArgs args) {
            log.Info("Notify ScreenSaverStarted: " + args.ToString());
            IsSreenSaverRuning = true;
            if (ScreenSaverStarted != null) {
                ScreenSaverStarted(this, args);
            }
        }

        //TODO Listen ScreenSaver Events
        public event EventHandler<MonitorEventArgs> ScreenSaverStopped;
        internal void OnScreenSaverStopped(MonitorEventArgs args) {
            log.Info("Notify ScreenSaverStopped: " + args.ToString());
            IsSreenSaverRuning = false;
            if (ScreenSaverStopped != null) {
                ScreenSaverStopped(this, args);
            }
        }

        public event EventHandler<MonitorEventArgs> MonitorShutdown;
        internal void OnMonitorShutdown(MonitorEventArgs args) {
            log.Info("Notify MonitorShutdown: " + args.ToString());
            IsMonitorShutdown = true;
            if (MonitorShutdown != null) {
                MonitorShutdown(this, args);
            }
        }

        public event EventHandler<MonitorEventArgs> MonitorOpened;
        internal void OnMonitorOpened(MonitorEventArgs args) {
            log.Info("Notify MonitorOpened: " + args.ToString());
            IsMonitorShutdown = false;
            if (MonitorOpened != null) {
                MonitorOpened(this, args);
            }
        }



        #endregion

        #region Start & Stop listening

        /// <summary>
        /// Start Listening to system events
        /// </summary>
        /// <remarks>
        /// Many system message API request a form. So a background model form will be loaded by a sub thread.
        /// </remarks>
        public void Start() {
            log.Debug("Starting listening thread");
            //ThreadStart entry = new ThreadStart(StartEntry);
            listenThread = new Thread(
                delegate() {
                    listenForm = new MessageListenForm(this);
                    listenForm.ShowDialog();
                }
            );
            listenThread.Start();
        }




        /// <summary>
        /// Stopped listening to system events.
        /// </summary>
        /// <remarks>
        /// Listen Form is showed by sub thread, It could not be directly closed by main thread.
        /// </remarks>
        public void Stop() {
            try {
                log.Debug("Stopping listening thread");

                MethodInvoker invoker = new MethodInvoker(
                    delegate() {    //Anonymous method for closing form.
                        listenForm.Close();
                        //Form thread will not automatically execute Dispose after close the form. 
                        //If have not executed Dispose here, main thread will encounter an dispose error when exit application. 
                        listenForm.Dispose();
                        listenForm = null;
                    }
                );

                listenForm.Invoke(invoker);
                log.Debug("Listening form closed");

                if (listenThread != null && listenThread.IsAlive) {
                    listenThread.Join();
                }
                listenThread = null;
            } catch (System.Exception ex) {
                log.Error("There are some errors when stop listening!", ex);
            }
        }

        #endregion




    }
}
