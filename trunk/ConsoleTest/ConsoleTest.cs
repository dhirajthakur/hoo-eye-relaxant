using System;
using Hush.MonitorService;
using System.Threading;
using Hush.MonitorService.Test;

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Hush.Relaxant {
    
    public class ConsoleTest {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 

        [STAThread]
        static void Main(string[] args) {
           
            ConsoleTest test = new ConsoleTest();



            TestMessage.Run();

            Console.WriteLine("Please press any key to exit...");
            Console.ReadKey(true);
     
           
        }



        void testEvent() {
            String wql = "SELECT * FROM __InstanceCreationEvent WHERE TargetInstance isa \"Win32_Process\"";
            wql = "SELECT * FROM __InstanceOperationEvent WITHIN 10 WHERE TargetInstance ISA 'Win32_ComputerSystem' ";
            wql += " OR  TargetInstance ISA 'Win32_OperatingSystem' ";
            wql += " OR  TargetInstance ISA 'Win32_Session' ";
            wql += " OR  TargetInstance ISA 'Win32_LogonSession' ";
            //wql += " OR  TargetInstance ISA 'Win32_NTLogEvent' ";
            //wql += " OR  TargetInstance ISA 'CCM_ComputerSystem' ";
            //wql += " OR  TargetInstance ISA 'CIM_ComputerSystem' ";

            wql = "SELECT * FROM __InstanceModificationEvent WITHIN 5 WHERE TargetInstance ISA \"Win32_Session\"";

            EventWatcherAsync watcher = new EventWatcherAsync(wql);
            //EventWatcherPolling.Run();
        }

     

    }
}
