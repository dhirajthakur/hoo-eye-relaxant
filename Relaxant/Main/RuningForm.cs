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


    public partial class RunningForm : Form {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RunningControl Manager { get; private set; }

        private RunningForm() {
            throw new NotImplementedException();
        }

        private void RuningForm_Load(object sender, EventArgs e) {
            if (Settings.Default.Resctriction4Quit == RestrictionLevels.Forbidden)
                quitToolStripMenuItem.Enabled = false;

            this.Hide();
            
        }


        public RunningForm(RunningControl pManager) {
            this.Manager = pManager;
            InitializeComponent();
            Manager.SecondTick += new EventHandler(Manager_SecondTick);
            Manager.BreakingStarted += new EventHandler(Manager_BreakingStarted);
        }

        void Manager_SecondTick(object sender, EventArgs e) {
            TimeSpan span = TimeSpan.FromSeconds(Manager.PendingSeconds);
            eyesNotifyIcon.BalloonTipText = "Next break will start after:\n " + span.ToString();
        }

        void Manager_BreakingStarted(object sender, EventArgs e) {
            ShowBreakingForm();
        }

        #region Form Process

        private void previewToolStripMenuItem_Click(object sender, EventArgs e) {
            ShowBreakingForm();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
            Manager.CompleteBreaking(); //TODO check
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e) {
            Manager.ShowSettingForm();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Manager.QuitApplication();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox form = new AboutBox();
            form.ShowDialog();
        }

        #endregion

        
        /// <summary>
        /// Open breaking form when enter breaking status
        /// </summary>
        private void ShowBreakingForm() {
            BreakingForm frm = new BreakingForm(this.Manager);

            if (frm == null || frm.IsDisposed) {
                frm = new BreakingForm(this.Manager); //TODO add manager
            }

            frm.ShowDialog(this);

        }
        

        private void eyesNotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                eyesNotifyIcon.ShowBalloonTip(500);
            }
        }






        



    }
}
