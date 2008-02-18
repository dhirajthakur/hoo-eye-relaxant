using System;
using System.Collections.Generic;
using System.Text;
using Hoo.MonitorService.SENS;
namespace Hoo.MonitorService.Test {
    class TestSens {

        internal TestSens() {
            IMonitorEvents notifier = SensLogon.GetInstance();

            notifier.MonitorLocked += new
             EventHandler<MonitorEventArgs>(SensLogon_DisplayLock);
            notifier.MonitorUnlocked += new
             EventHandler<MonitorEventArgs>(SensLogon_DisplayUnlock);
            notifier.ScreenSaverStarted += new EventHandler<MonitorEventArgs>(notifier_StartScreenSaver);
            notifier.ScreenSaverStopped += new EventHandler<MonitorEventArgs>(notifier_StopScreenSaver);
            Console.WriteLine("Registered For SENS Events");
            Console.ReadLine();
        }

        static void notifier_StopScreenSaver(object sender, MonitorEventArgs e) {
            Console.WriteLine("Stop Screen Saver " + e.UserName);
        }

        static void notifier_StartScreenSaver(object sender, MonitorEventArgs e) {
            Console.WriteLine("Start Screen Saver: " + e.UserName);
        }
        private static void SensLogon_DisplayLock(object sender, MonitorEventArgs e) {
            Console.WriteLine("Screen Locked: " + e.UserName);
        }
        private static void SensLogon_DisplayUnlock(object sender, MonitorEventArgs e) {
            Console.WriteLine("Screen Unlocked: " + e.UserName);
        }
    }
}
