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


    public partial class RuningForm : Form {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private BreakingForm _breakingForm;
        private SettingForm _settingForm;

        private bool _onDelaying = false;

        public int WorkingSeconds { get; set; }
        public int DelayedSeconds{ get; set; }

      
	

        public RuningForm() {
            InitializeComponent();
            DelayedSeconds = 0;
        }

        /// <summary>
        /// Exit breaking status and return working status.
        /// The breaking form will be closed.
        /// </summary>
        public void StartWorking() {
            _onDelaying = false;
            DelayedSeconds = 0;
            StartWorking(Settings.Default.WorkingMinutes * 60);
        }

        private void StartWorking(int seconds) {
            WorkingSeconds = seconds;
            workingTimer.Start();
        }

        /// <summary>
        /// Exit breaking status and return working status. It will reenter breaking status after specified seconds.
        /// 
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public bool DelayBreaking(int seconds) {
            int maxSeconds =  Settings.Default.MaxDelayMinutes * 60;
            int availableSeconds = maxSeconds - DelayedSeconds;
            if (availableSeconds >= seconds) {
                _onDelaying = true;
                StartWorking(seconds);
                return true;
            } else {
                log.Error("No enough seconds for delaying!");
                throw new Exception(StringUtil.Join("You have delayed over %1 minutes, you could only delay %2 more minutes. ", DelayedSeconds, availableSeconds));
            }
        }

      
        /// <summary>
        /// Pause working status and enter breaking status. Generally, a breaking form will be displayed.
        /// 
        /// </summary>
        private void StartBreaking() {
            workingTimer.Stop();
            ShowBreakingForm();
        }

        private void RuningForm_Load(object sender, EventArgs e) {
            if (Settings.Default.Resctriction4Quit == RestrictionLevels.Forbidden)
                quitToolStripMenuItem.Enabled = false;
            
            this.Hide();
            StartWorking();
        }

        #region Context Menu

        private void previewToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowBreakingForm();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
            StartWorking();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowSettingForm();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            QuitApplication();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox form = new AboutBox();
            form.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Open breaking form when enter breaking status
        /// </summary>
        public void ShowBreakingForm() {
            workingTimer.Stop();            

            if (_breakingForm == null || _breakingForm.IsDisposed) {
                _breakingForm = new BreakingForm();
            }

            _breakingForm.ShowDialog(this);

        }

        /// <summary>
        /// Open setting form to configure runtime settings
        /// </summary>
        public void ShowSettingForm() {
            if (_breakingForm != null) {
                _breakingForm.Close();
            }

            if (_settingForm == null || _settingForm.IsDisposed) {
                _settingForm = new SettingForm();               
            }
            _settingForm.Show(this);
        }

        public void QuitApplication() {
            if (Settings.Default.Resctriction4Quit == RestrictionLevels.Forbidden) return;

            Application.Exit();
        }

        private void workingTimer_Tick(object sender, EventArgs e) {
            WorkingSeconds--;
            if (_onDelaying) DelayedSeconds++;
            TimeSpan span = TimeSpan.FromSeconds(WorkingSeconds);
            eyesNotifyIcon.BalloonTipText = "Next break will start after:\n " + span.ToString();
            if (WorkingSeconds <= 0) {
                StartBreaking();

            }
        }

        private void eyesNotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                eyesNotifyIcon.ShowBalloonTip(500);
            }
        }

        


    }
}
