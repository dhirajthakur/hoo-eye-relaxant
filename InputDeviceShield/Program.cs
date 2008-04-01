using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hoo.Device.Keyboard.Test;
// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Hoo.Device.Keyboard
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TraceForm());
        }
    }
}