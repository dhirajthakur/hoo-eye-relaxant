using System;
using System.Windows.Forms;

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Hush.Relaxant {
    
    public enum AdminModes  {
        //Administer is free to all users.
        Free, 
        //Admin actions request password.
        Password,
        //Only windows administrators or specified account could administer this program.
        WindowsIntegrated
    }

    public enum RestrictionLevels {
        //Function is available without restriction.
        Free,
        //Function is restricted by password or windows account.
        Restricted,
        //Function is disabled.
        Forbidden
    }

    static class RelaxantManager {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static RuningForm _formManager;
        public static RuningForm FormManager {
            get { return _formManager; }
            set { _formManager = value; }
        }
	

        public const int c_workingSecondsMin = 60; // 1 minutes
        public const int c_workingSecondsMax = 60 * 60 * 2; // 2 hours
        public const int c_breakingSecondsMin = 60; // 1 minutes
        public const int c_breakingSecondsMax = 600; // 10 minutes


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormManager = new RuningForm();
            Application.Run(FormManager);
            
        }

     
       
    }
}