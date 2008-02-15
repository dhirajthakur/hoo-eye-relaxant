using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hush.Relaxant.Properties;
using Hush.Common;
namespace Hush.Relaxant {


    public partial class RunningControl{

        

        #region Public Events
        
        //TODO complete event list
        //TODO implement event
        public event EventHandler SecondTick;
        public event EventHandler BreakingDelaying;
        public event EventHandler BreakingTerminating;
        public event EventHandler BreakingTerminated;
        public event EventHandler BreakingStarted;
        

        #endregion

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

        
        #region Read configured settings

        public int MaxDelaySeconds { get; private set; }

        public int WorkingSeconds  { get; private set; }

        public int BreakingSeconds { get; private set; }

        #endregion

        private System.Windows.Forms.Timer RunningTimer;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RunningControl() {
            this.RunningTimer = new System.Windows.Forms.Timer();
            this.RunningTimer.Interval = 1000;
            this.RunningTimer.Tick += new System.EventHandler(this.runningTimer_Tick);
            
            MaxDelaySeconds = Settings.Default.MaxDelayMinutes * 60;
            WorkingSeconds = Settings.Default.WorkingMinutes * 60;
            BreakingSeconds = Settings.Default.BreakingMinutes * 60;

            CompleteBreaking();
        }

        private void StartWorking(int seconds) {
            
            State = RuningStates.Working;
            PlannedSeconds = seconds;
            PendingSeconds = PlannedSeconds;            
            RunningTimer.Start();
           
            this.BreakingTerminated(this, null);
        }

        /// <summary>
        /// Pause working status and enter breaking status. Generally, a breaking form will be displayed.
        /// 
        /// </summary>
        private void StartBreaking() {
            RunningTimer.Stop();
            State = RuningStates.Breaking;            
            PendingSeconds = PlannedSeconds;
            RunningTimer.Start();
            this.BreakingStarted(this, null);
        }

        /// <summary>
        /// Exit breaking status and return working status.
        /// The breaking form will be closed.
        /// </summary>
        public void CompleteBreaking() {
            UnderDelay = false;
            IsForceTeminate = false;
            DelayedSeconds = 0;
            this.BreakingTerminating(this, null);
            StartWorking(WorkingSeconds);
        }

        public void TerminateBreaking() {
            IsForceTeminate = true;
            StartWorking(WorkingSeconds);
        }
        
        /// <summary>
        /// Exit breaking status and return working status. It will reenter breaking status after specified seconds.
        /// 
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public void DelayBreaking(int seconds) {;            
            if (AllowDelay( seconds)) {
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



        private void runningTimer_Tick(object sender, EventArgs e) {
            PendingSeconds--;
            if (UnderDelay) DelayedSeconds++;

            if (PendingSeconds <= 0) {
                //TODO switch state
            }

            this.SecondTick(this, e);
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



        internal void Start() {
            throw new NotImplementedException();
        }
    }
}
