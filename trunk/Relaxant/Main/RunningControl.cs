using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hoo.Relaxant.Properties;
using Hoo.Common;

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Hoo.Relaxant {

    public enum AdminModes {
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

    /// <summary>
    /// Entry and manager class.
    /// </summary>
    public partial class RunningControl {

        #region Initialize Program

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static RunningForm ManagerForm { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ManagerForm = new RunningForm(new RunningControl());

            Application.Run(ManagerForm);

        }

        #endregion

        #region Public Events

        //TODO complete event list    
        public event EventHandler SecondTick;

        public event EventHandler BreakingTerminating;
        public event EventHandler BreakingTerminated;
        public event EventHandler BreakingStarting;
        public event EventHandler BreakingStarted;        
        public event EventHandler BreakingDelaying;        

        #endregion

        #region Runtime indicators
        public enum RuningStates { Working, Breaking, Sleeping };

        /// <summary>
        /// Current running state.
        /// </summary>
        public RuningStates State { get; set; }

        public bool IsForceTeminate { get; set; }

        public bool UnderDelay { get; private set; }

        /// <summary>
        /// Planned endurance of seconds for current state.
        /// If current state is Working, this property indicates planned working seconds.
        /// Else if current state is Breaking, this property indicates planned breaking seconds.
        /// </summary>
        public int PlannedSeconds { get; set; }

        /// <summary>
        /// To be broken or worked seconds.
        /// this property indicates left endurance seconds of breaking or working.
        /// At the start point, this properties equals PlannedSeconds.
        /// </summary>
        public int PendingSeconds { get; set; }

        /// <summary>
        /// Accumulated actual delayed seconds before one completed breaking.
        /// </summary>
        public int DelayedSeconds { get; set; }
        #endregion


        #region Read configured settings

        public int MaxDelaySeconds { get; private set; }

        public int WorkingSeconds { get; private set; }

        public int BreakingSeconds { get; private set; }

        public void RefreshSettings() {

            MaxDelaySeconds = Settings.Default.MaxDelayMinutes * 60;
            WorkingSeconds = Settings.Default.WorkingMinutes * 60;
            BreakingSeconds = Settings.Default.BreakingMinutes * 60;
        }

        #endregion

        private System.Windows.Forms.Timer RunningTimer;


        public RunningControl() {
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(
                delegate(object sender, PropertyChangedEventArgs e) {
                    RefreshSettings();
                }
                );
            this.RunningTimer = new System.Windows.Forms.Timer();
            this.RunningTimer.Interval = 1000;
            this.RunningTimer.Tick += new System.EventHandler(this.runningTimer_Tick);

            RefreshSettings();

            CompleteBreaking();
        }

        
        /// <summary>
        /// Pause working status and enter breaking status. Generally, a breaking form will be displayed.
        /// 
        /// </summary>
        public void StartBreaking() {
            RunningTimer.Stop();
            State = RuningStates.Breaking;
            PlannedSeconds = BreakingSeconds;
            PendingSeconds = PlannedSeconds;
            RunningTimer.Start();
            if (BreakingStarted != null) BreakingStarted(this, new EventArgs());
        }

        /// <summary>
        /// Exit breaking status and return working status.
        /// The breaking form will be closed.
        /// </summary>
        public void CompleteBreaking() {
            if (BreakingTerminating != null) BreakingTerminating(this, new EventArgs());
            UnderDelay = false;
            IsForceTeminate = false;
            DelayedSeconds = 0;            
            StartWorking(WorkingSeconds);
        }

        /// <summary>
        /// Force exit breaking status and return working status.
        /// </summary>
        public void TerminateBreaking() {
            if (BreakingTerminating != null) BreakingTerminating(this, new EventArgs());
            IsForceTeminate = true;
            StartWorking(WorkingSeconds);
        }

        /// <summary>
        /// Exit breaking status and return working status. It will reenter breaking status after specified seconds.
        /// 
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public void DelayBreaking(int seconds) {            
            if (AllowDelay(seconds)) {
                if (BreakingDelaying != null) BreakingDelaying(this, new EventArgs());
                UnderDelay = true;
                StartWorking(seconds);

            } else {
                log.Error("No enough seconds for delaying!");
                throw new Exception(StringUtil.Join("You have delayed over %1 minutes, you could only delay %2 minutes. ", DelayedSeconds, seconds));
            }
        }

        public bool AllowDelay(int seconds) {
            int availableSeconds = MaxDelaySeconds - DelayedSeconds;
            if (availableSeconds >= seconds) {
                return true;
            } else {
                return false;
            }
        }

        public void QuitApplication() {
            if (Settings.Default.Resctriction4Quit == RestrictionLevels.Forbidden) return;

            Application.Exit();
        }

        private void StartWorking(int seconds) {

            State = RuningStates.Working;
            PlannedSeconds = seconds;
            PendingSeconds = PlannedSeconds;
            RunningTimer.Start();
            if (BreakingTerminated != null) BreakingTerminated(this, new EventArgs());
        }

        private void runningTimer_Tick(object sender, EventArgs e) {
            PendingSeconds--;
            if (UnderDelay) DelayedSeconds++;

            if (PendingSeconds <= 0) {
                switch (this.State) {
                    case RuningStates.Working:
                        StartBreaking();
                        break;
                    case RuningStates.Breaking:
                        CompleteBreaking();
                        break;
                    case RuningStates.Sleeping:
                        break;
                    default:
                        break;
                }

            }

            if (SecondTick != null) this.SecondTick(this, e);
        }

        #region Setting Form

        /// <summary>
        /// Open setting form to configure runtime settings
        /// </summary>
        public void ShowSettingForm() {
            SettingForm frm = new SettingForm();
            if (State == RuningStates.Breaking)
                throw new Exception("Could not open setting form during breaking!");

            if (frm == null || frm.IsDisposed) {
                frm = new SettingForm(); //TODO add manager
            }
            frm.Show();
        }
        #endregion


    }
}
