using System;
using System.Management;

namespace Hoo.Device.Monitor {

    
    // This example shows synchronous consumption of events. 
    // The client is blocked while waiting for events. 

    public class EventWatcherPolling {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Run() {
            // Create event query to be notified within 1 second of 
            // a new process being created
            WqlEventQuery query =
                new WqlEventQuery("__InstanceCreationEvent",
                new TimeSpan(0, 0, 1),
                "TargetInstance isa \"Win32_Process\"");

            // Initialize an event watcher and subscribe to events 
            // that match this query
            ManagementEventWatcher watcher =
                new ManagementEventWatcher(query);
            // times out watcher.WaitForNextEvent in 5 seconds
            watcher.Options.Timeout = new TimeSpan(0, 0, 5);

            // Block until the next event occurs 
            // Note: this can be done in a loop if waiting for 
            //        more than one occurrence
            Console.WriteLine(
              "Open an application (notepad.exe) to trigger an event.");
            ManagementBaseObject e = watcher.WaitForNextEvent();
            log.Debug(e.GetText(TextFormat.Mof ));
            ManagementBaseObject target = (ManagementBaseObject)e["TargetInstance"];
            Object targetName = target["Name"];
            Object targetPath = target["ExecutablePath"];
            //Display information from the event
            log.Info(
                "Process {0} has been created, path is: " + targetName + ", " + targetPath);

            //Cancel the subscription
            watcher.Stop();
           
        }
    }
}