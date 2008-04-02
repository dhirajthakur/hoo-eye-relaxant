using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Hoo.Relaxant {
    /// <summary>
    /// Only launch one runtime instantce.
    /// </summary>
    public static class Program {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static RunningForm ManagerForm { get; set; }


        /// <summary>
        /// Check whether there is another runing instance of this application.
        /// </summary>
        /// <remarks>
        /// One runing instance is one process. 
        /// In order to indentify duplicate process, you should check main application execution file version information 
        /// instead of process name, main moudule name, or main application file name.
        /// These names could be changed if user change the application execution file's name or path.
        /// </remarks>
        /// <returns>If found another runing instance return true, else return false</returns>
        static bool ExistRuningInstance() {
            try {
                Process currentProcess = Process.GetCurrentProcess();

                FileVersionInfo version = currentProcess.MainModule.FileVersionInfo;
                log.Debug("Process Name: " + currentProcess.ProcessName);

                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes) {                    
                    if (process.Id != currentProcess.Id) {
                        try {
                            //Some system processes could not provide FileVersionInfo.
                            if (process.MainModule.FileName.StartsWith(@"\?"))
                                continue;

                            FileVersionInfo proVersion = process.MainModule.FileVersionInfo;
                                                        
                            if (proVersion.OriginalFilename == version.OriginalFilename
                                && proVersion.CompanyName == version.CompanyName
                                && proVersion.ProductName == version.ProductName) {
                                return true;
                            }
                        } catch (Exception ex) {
                            log.Error("Could not read process file version information: " + process.ProcessName + ", " + process.MainModule.FileName);
                            log.Error(ex.ToString());
                        }
                    }
                }
            } catch (Exception ex) {
                log.Error(ex.ToString());
            }
            return false;
        }

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            if (ExistRuningInstance()) {
                MessageBox.Show("Another Hoo Relaxnt instance is already runing. You should not launch more than one instances.", "Error", MessageBoxButtons.OK);
                Application.Exit(); 
            } else {
                // Exit() only teminate this application. However, it could not terminate this function. 
                // So "else" is neccessary here.
                CultureInfo culture = Properties.Settings.Default.Language;
                log.Debug(String.Format("Current culture is {0}", culture.Name));
                System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ManagerForm = new RunningForm(new RunningControl());

                Application.Run(ManagerForm);
            }

        }

        internal static void PlaySystemSound(string sound) {
            System.Media.SystemSound s = null;
            switch (sound.ToLower().Trim()) {
                case "hand":
                    s = System.Media.SystemSounds.Hand;
                    break;
                case "exclamation":
                    s = System.Media.SystemSounds.Exclamation;
                    break;
                case "asterisk":
                    s = System.Media.SystemSounds.Asterisk;
                    break;
                case "question":
                    s = System.Media.SystemSounds.Question;
                    break;
            }

            if (s != null) {
                s.Play();
                System.Threading.Thread.Sleep(1000);
                s.Play();
                System.Threading.Thread.Sleep(1000);
                s.Play();
            }
        }
    }

}