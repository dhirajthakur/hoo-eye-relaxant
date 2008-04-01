using System;
using System.ComponentModel;
using System.Windows.Forms;
using Hoo.Relaxant.Properties;

using Hoo.Device.Monitor;
using System.Globalization;
using System.Diagnostics;


namespace Hoo.Relaxant {

    
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
    public class RunningControl {



        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        #region Public Events

        //TODO complete event list    
        public event EventHandler SecondTick;

        public event EventHandler BreakingTerminating;
        public event EventHandler BreakingTerminated;
        //public event EventHandler BreakingStarting;
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

            MaxDelaySeconds = Settings.Default.DelayMinutes * 60;
            WorkingSeconds = Settings.Default.WorkingMinutes * 60;
            BreakingSeconds = Settings.Default.BreakingMinutes * 60;
        }

        #endregion

        private System.Windows.Forms.Timer RunningTimer;
        private MonitorMessageNotifier monitor;

        public RunningControl() {
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(
                delegate(object sender, PropertyChangedEventArgs e) {
                    RefreshSettings();
                }
                );
            this.RunningTimer = new System.Windows.Forms.Timer();
            this.RunningTimer.Interval = 1000;
            this.RunningTimer.Tick += new System.EventHandler(this.runningTimer_Tick);

            monitor = MonitorMessageNotifier.getInstance();
            monitor.MonitorLocked += new EventHandler<MonitorEventArgs>(monitor_MonitorLocked);
            monitor.MonitorUnlocked += new EventHandler<MonitorEventArgs>(monitor_MonitorUnlocked);
            monitor.Start();



            RefreshSettings();
            CompleteBreaking();


        }

        ~RunningControl() {
            monitor.Stop();
            monitor = null;
        }

        void monitor_MonitorUnlocked(object sender, MonitorEventArgs e) {
            log.Debug("Computer unlocked!");
            TimeSpan span = System.DateTime.Now - LockedTime;
            log.Debug("Locked Seconds : " + span.TotalSeconds);
            if (span.TotalSeconds >= BreakingSeconds) {
                CompleteBreaking();
            }
        }

        private DateTime LockedTime { get; set; }
        void monitor_MonitorLocked(object sender, MonitorEventArgs e) {
            log.Debug("Computer locked!");
            LockedTime = System.DateTime.Now;
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
        /// <exception cref="Exception">Available delay seconds is less than reqeust delay seconds</exception>
        /// 
        public void DelayBreaking(int seconds) {
            //In principle, delay seconds should not more than available delay seconds.
            //However, adding five seconds to available delay seconds could avoid potential program clock error.
            if (seconds <= AvailableDelaySeconds + 5) {
                if (BreakingDelaying != null) BreakingDelaying(this, new EventArgs());
                UnderDelay = true;
                StartWorking(seconds);

            } else {
                log.Error("No enough seconds for delaying!");
                throw new Exception(String.Format("There are {0} available delay, you could not delay {0} seconds. ", AvailableDelaySeconds, seconds));
            }
        }

        public int AvailableDelaySeconds {
            get {
                return (MaxDelaySeconds - DelayedSeconds);
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
            if (UnderDelay & State == RuningStates.Working) DelayedSeconds++;

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
