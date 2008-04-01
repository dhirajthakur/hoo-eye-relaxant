using System;
using System.Collections.Generic;
using System.Text;
using SensEvents;

namespace Hoo.Device.Monitor.SENS {
    public class SensLogon : IMonitorEvents {

        private static SensLogonInterop eventCatcher;
        private static SensLogon instance;
        private SensLogon() { }

        public static IMonitorEvents GetInstance() {
            if(instance == null) {
                instance = new SensLogon();
            }

            return(instance);
        }

        //...SensLogonInterop goes here
        private class SensLogonInterop : ISensLogon, IDisposable {
            private const string SubscriptionViewerName = "Hoo.SystemEventProvider.SENS.SensLogonInterop";
            private static string SubscriptionViewerID = "{" + typeof(SensLogonInterop).GUID.ToString().ToUpper() + "}"; // generate a subscriptionID 
            private const string SubscriptionViewerDesc = "Hoo.SystemEventProvider.SENS Event Subscriber";

            private bool registered;

            public SensLogonInterop() {
                registered = false;
                EventSystemRegistrar.SubscribeToEvents(SubscriptionViewerDesc, SubscriptionViewerName,
                 SubscriptionViewerID, this, typeof(ISensLogon));
                registered = true;
            }

            #region Cleanup Code

            ~SensLogonInterop() {
                this.Dispose(false);
            }

            public void Dispose() {
                this.Dispose(true);
            }

            protected void Dispose(bool isExplicit) {
                this.Deactivate();
            }

            private void Deactivate() {
                if (registered) {
                    EventSystemRegistrar.UnsubscribeToEvents(SubscriptionViewerID);
                    registered = false;
                }
            }

            #endregion

            #region ISensLogon Members

            public void DisplayLock(string bstrUserName) {
                SensLogon.OnDisplayLock(bstrUserName);
            }
            public void DisplayUnlock(string bstrUserName) {
                SensLogon.OnDisplayUnlock(bstrUserName);
            }

            void ISensLogon.Logoff(string bstrUserName) {
                throw new NotImplementedException();
            }

            void ISensLogon.Logon(string bstrUserName) {
                throw new NotImplementedException();
            }

            void ISensLogon.StartScreenSaver(string bstrUserName) {
                SensLogon.OnStartScreenSaver(bstrUserName);
            }

            void ISensLogon.StartShell(string bstrUserName) {
                throw new NotImplementedException();
            }

            void ISensLogon.StopScreenSaver(string bstrUserName) {
                SensLogon.OnStopScreenSaver(bstrUserName);
            }

            #endregion
        }

        #region Event Registration Code

        private static int registerCount = 0;
        private static bool IsRegistered {
            get {
                return (registerCount > 0);
            }
        }

        private static EventHandler<MonitorEventArgs> RegisterEvent(EventHandler<MonitorEventArgs> original, EventHandler<MonitorEventArgs> newDel) {
            bool shouldRegister = (original == null);
            original = original + newDel;
            if (shouldRegister) {
                if (registerCount <= 0) {
                    if (SensLogon.eventCatcher == null)
                        SensLogon.eventCatcher = new SensLogonInterop();
                    registerCount = 1;
                } else {
                    //Just count them.
                    registerCount++;
                }
            }
            return original;
        }

        private static EventHandler<MonitorEventArgs> UnregisterEvent(EventHandler<MonitorEventArgs> original, EventHandler<MonitorEventArgs> oldDel) {
            original = original - oldDel;
            if (original == null) {
                registerCount--;
                if (registerCount == 0) {
                    //unregister for those events.
                    SensLogon.eventCatcher.Dispose();
                    SensLogon.eventCatcher = null;
                }
            }
            return original;
        }

        #endregion

        #region ISensLogon Event Raising Members

        protected static void OnDisplayLock(string bstrUserName) {
            if (SensLogon.displayLock != null)
                SensLogon.displayLock(typeof(SensLogon) , new MonitorEventArgs(bstrUserName));
        }
        protected static void OnDisplayUnlock(string bstrUserName) {
            if (SensLogon.displayUnlock != null)
                SensLogon.displayUnlock(typeof(SensLogon), new MonitorEventArgs(bstrUserName));
        }

        protected static void OnStartScreenSaver(string bstrUserName) {
            if (SensLogon.startScreenSaver != null)
                SensLogon.startScreenSaver(typeof(SensLogon), new MonitorEventArgs(bstrUserName));
        }

        protected static void OnStopScreenSaver(string bstrUserName) {
            if (SensLogon.stopScreenSaver != null)
                SensLogon.stopScreenSaver(typeof(SensLogon), new MonitorEventArgs(bstrUserName));
        }


        ///...

        #endregion

        #region Event Declarations

        private static EventHandler<MonitorEventArgs> displayLock = null;
        private static EventHandler<MonitorEventArgs> displayUnlock = null;
        private static EventHandler<MonitorEventArgs> startScreenSaver = null;
        private static EventHandler<MonitorEventArgs> stopScreenSaver = null;
        private static EventHandler<MonitorEventArgs> logon = null;
        private static EventHandler<MonitorEventArgs> logoff = null;
        ///...

        public event EventHandler<MonitorEventArgs> MonitorLocked {
            add {
                SensLogon.displayLock = SensLogon.RegisterEvent(SensLogon.displayLock, value);
            }
            remove {
                SensLogon.displayLock = SensLogon.UnregisterEvent(SensLogon.displayLock, value);
            }
        }
        public event EventHandler<MonitorEventArgs> MonitorUnlocked {
            add {
                SensLogon.displayUnlock = SensLogon.RegisterEvent(SensLogon.displayUnlock, value);
            }
            remove {
                SensLogon.displayUnlock = SensLogon.UnregisterEvent(SensLogon.displayUnlock, value);
            }
        }

        public event EventHandler<MonitorEventArgs> ScreenSaverStarted {
            add {
                SensLogon.startScreenSaver = SensLogon.RegisterEvent(SensLogon.startScreenSaver, value);
            }
            remove {
                SensLogon.startScreenSaver = SensLogon.UnregisterEvent(SensLogon.startScreenSaver, value);
            }
        }

        public event EventHandler<MonitorEventArgs> ScreenSaverStopped {
            add {
                SensLogon.stopScreenSaver = SensLogon.RegisterEvent(SensLogon.stopScreenSaver, value);
            }
            remove {
                SensLogon.stopScreenSaver = SensLogon.UnregisterEvent(SensLogon.stopScreenSaver, value);
            }
        }



        public event EventHandler<MonitorEventArgs> MonitorShutdown;

        public event EventHandler<MonitorEventArgs> MonitorOpened;

        #endregion
    }



}
