using System;

namespace Hoo.Device.Monitor {
    
    public class MonitorEventArgs : EventArgs {
        public MonitorEventArgs(String pUserName) {
            UserName = pUserName;
        }

        private string _userName;
        public String UserName { 
            get {return _userName;}
            set {_userName = value;}
        }
    }

    public interface IMonitorEvents {
        event EventHandler<MonitorEventArgs> MonitorLocked;
        event EventHandler<MonitorEventArgs> MonitorUnlocked;
        event EventHandler<MonitorEventArgs> ScreenSaverStarted;
        event EventHandler<MonitorEventArgs> ScreenSaverStopped;
        event EventHandler<MonitorEventArgs> MonitorShutdown;
        event EventHandler<MonitorEventArgs> MonitorOpened;
       

    }
}
