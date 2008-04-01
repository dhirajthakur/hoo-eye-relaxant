using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hoo.Relaxant.Properties;

namespace Hoo.Relaxant {


    public partial class RunningForm : Form {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RunningControl Manager { get; private set; }


        #region Form constructors and manager event handlers
        
        private RunningForm() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The only valid constructor
        /// </summary>
        /// <param name="pManager">This is mandantory</param>
        public RunningForm(RunningControl pManager) {
            this.Manager = pManager;
            InitializeComponent();
#if DEBUG
            this.eyesNotifyIcon.Text += " [DEBUG] ";
            this.Text += " [DEBUG] ";

#endif
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            Manager.SecondTick += new EventHandler(Manager_SecondTick);
            Manager.BreakingStarted += new EventHandler(Manager_BreakingStarted);
            Manager.BreakingTerminated += new EventHandler(Manager_BreakingTerminated);
            
            Manager_BreakingTerminated(this, null);
        }

        
        void Manager_BreakingTerminated(object sender, EventArgs e) {
               
            TimeSpan span = TimeSpan.FromSeconds(Manager.PendingSeconds);
            spanLabel.Text = span.ToString();
            spanBar.Properties.Maximum = Manager.PlannedSeconds;
            spanBar.Position = Manager.PendingSeconds;
        }

        void Manager_SecondTick(object sender, EventArgs e) {
            if (Manager.State == RunningControl.RuningStates.Working) {
                TimeSpan span = TimeSpan.FromSeconds(Manager.PendingSeconds);
                spanLabel.Text = span.ToString();
                spanBar.Decrement(1);
            }
        }

        void Manager_BreakingStarted(object sender, EventArgs e) {
            ShowBreakingForm();
        }

        #endregion

        #region Form Process

        private void RuningForm_Load(object sender, EventArgs e) {
            if (Settings.Default.Resctriction4Quit == RestrictionLevels.Forbidden)
                quitToolStripMenuItem.Enabled = false;

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e) {
            Manager.StartBreaking();
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

                //e.X & e.Y cound not work
                //this.Left = e.X - this.Width;
                //this.Top = e.Y - this.Height;
                this.Left = Cursor.Position.X - this.Width;
                this.Top = Cursor.Position.Y - this.Height;
                this.Show();
                this.Activate(); // Precondition of trigger Deactivate event.
            } else if (e.Button == MouseButtons.Right) {
                //this.Hide();
            }
        }

        private void RunningForm_Deactivate(object sender, EventArgs e) {
            this.Hide();
        }









    }
}
