using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hoo.MonitorService.Test {
    public class TestMessage {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        
        public static void Run() {
            Console.WriteLine("Please press any key to Start Locking...");
            Console.ReadKey(true);

            MonitorMessageNotifier notifier = new MonitorMessageNotifier();
            notifier.MonitorLocked += new EventHandler<MonitorEventArgs>(notifier_MonitorLocked);
            notifier.MonitorUnlocked += new EventHandler<MonitorEventArgs>(notifier_MonitorUnlocked);
            notifier.MonitorShutdown += new EventHandler<MonitorEventArgs>(notifier_MonitorShutdown);
            notifier.MonitorOpened += new EventHandler<MonitorEventArgs>(notifier_MonitorOpened);

            notifier.Start();
            log.Info("Started Listening!");
            Thread.Sleep(1000 * 60);
            log.Debug("************60 seconds");
            //MonitorController.TurnOff();
            //Thread.Sleep(2000);
            //MonitorController.TurnOn();
            Thread.Sleep(1000 * 20);
            notifier.Stop();
            log.Info("Stopped Listening!");

        }

        static void notifier_MonitorOpened(object sender, MonitorEventArgs e) {
            log.Info("**************Opened by " + e.UserName);
        }

        static void notifier_MonitorShutdown(object sender, MonitorEventArgs e) {
            log.Info("**************Shutdown by " + e.UserName);
        }

        static void notifier_MonitorUnlocked(object sender, MonitorEventArgs e) {
            log.Info("**************Locked by " + e.UserName);
        }

        static void notifier_MonitorLocked(object sender, MonitorEventArgs e) {
            log.Info("**************UnLocked by " + e.UserName);
        }



      
    }
}
