using System;
using System.Management;
using System.Windows.Forms;

namespace Hush.MonitorService {

    // This example shows asynchronous consumption of events.
    // In this example you are listening for timer events.
    // The first part of the example sets up the timer.

    // Configure log4net using the .config file
   
    public class EventWatcherAsync {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ManagementEventWatcher watcher;

        public EventWatcherAsync()
            : this("SELECT * FROM __ExtrinsicEvent") {
            //
        }

        public EventWatcherAsync(String wql)
            : this(null, wql) {

        }

        public EventWatcherAsync(String scope, String wql) {
            
            if (scope == null || scope.Trim().Length <= 0) {

                watcher = new ManagementEventWatcher(wql);
            } else {
                watcher = new ManagementEventWatcher(scope, wql);
            }

            
            // Set up a listener for events
            watcher.EventArrived +=   new EventArrivedEventHandler(HandleEvent);

    
            
            
            

        }

        // Start listening
        public void Start() {

            try {
                watcher.Start();
            } catch (Exception ex) {
                log.Error("Could not start listening!", ex);
                
                throw;
            }
        }
        // Stop listening
        public void Stop() {
            watcher.Stop();
        }

        private void HandleEvent(object sender, EventArrivedEventArgs e) {
            ManagementBaseObject info = e.NewEvent;

            
            log.Info("Event arrived ! " + info.ClassPath);
            log.Debug(info.GetText(TextFormat.Mof));
          
        }



    }



}
