
using System;
using System.Windows.Forms;
using Hush.MonitorService;
using Hush.Common;
using Hush.Relaxant.Properties;
using Org.Mentalis.Multimedia;

namespace Hush.Relaxant {

    public partial class BreakingForm : Form {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private RuningForm manager;
        private int breakingSeconds;
        private MediaFile music;

        #region Form initialize and events

        public BreakingForm() {
            InitializeComponent();
            manager = RelaxantManager.FormManager;
#if DEBUG
            WindowState = FormWindowState.Normal;

#endif
            this.Text = AboutBox.AssemblyProduct + " " + AboutBox.AssemblyVersion;

            breakingSeconds = Settings.Default.BreakingMinutes * 60;
            breakingSpanBar.Properties.Maximum = breakingSeconds;
            breakingSpanBar.Position = breakingSeconds;

        }

            

        private void BreakingForm_Load(object sender, EventArgs e) {
            if (Settings.Default.Resctriction4TerminateBreaking == RestrictionLevels.Forbidden) {
                closeButton.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
                closeButton.ForeColor = System.Drawing.Color.DimGray;
                this.ResumeLayout();
                this.PerformLayout();
            }
            if (Settings.Default.MaxDelayMinutes * 60 <= manager.DelayedSeconds) {
                delayButton.Enabled = false;
                delayToolStripMenuItem.Enabled = false;
            }


            breakingTimer.Start();
            PlayMusic();

            
            if (Settings.Default.ShutdownMonitor) {
                TurnOffMonitor();
            }
        }

        #endregion


        private void breakingTimer_Tick(object sender, EventArgs e) {
            breakingSeconds--;
            TimeSpan breakingSpan = TimeSpan.FromSeconds(breakingSeconds);
            breakingSpanLabel.Text = breakingSpan.ToString();
            breakingSpanBar.Increment(-1);

            if (breakingSeconds <= 0) {
                CloseEx();

            }
        }

        #region private methods

        private void TurnOffMonitor() {
            MonitorController.TurnOff();
        }

        private void TurnOnMonitor() {
            MonitorController.TurnOn();
        }


        private void PlayMusic() {
            String fileLocation = Properties.Settings.Default.MusicFile;

            if (fileLocation != "") {
                try {
                    music = new SoundFile(fileLocation);

                    music.Play();
                } catch (Exception ex) {
                    log.Error("Could not play music!", ex);
                }
            }
        }

        private void StopMusic() {
            if (music != null) {
                music.Stop();
                music.Dispose();
                music = null;
            }
        }

        private void CloseEx() {
            MonitorController.TurnOn();
            StopMusic();
            breakingTimer.Stop();
            Close();
            manager.StartWorking();
        }

        private void Delay(int delaySeconds) {
            int maxSeconds = Settings.Default.MaxDelayMinutes * 60;
            int availableSeconds = maxSeconds - manager.DelayedSeconds;

            if(availableSeconds <=0) {
                MessageBox.Show("You could not delay any longer untill a full seconds breaking!","Invalided Action",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            } else if (availableSeconds < delaySeconds) {
                string msg = StringUtil.Join("You only have %1 seconds to delay before a full seconds breaking. Do you still want to delay?", availableSeconds);
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                    delaySeconds = availableSeconds;
                } else {
                    return;
                }
            }
            Close();
            manager.DelayBreaking(delaySeconds);
            
        }

        #endregion

        #region Context Menu

         private void closeButton_Click(object sender, EventArgs e) {            
            CloseEx();
        }


        private void delayButton_Click(object sender, EventArgs e) {
            Delay(30);

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox f = new AboutBox();
            f.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            CloseEx();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void delay1ToolStripMenuItem_Click(object sender, EventArgs e) {
            Delay(30);
        }

        private void delay2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Delay(60);
        }

        private void delay3ToolStripMenuItem_Click(object sender, EventArgs e) {
            Delay(120);
        }

        private void delay4ToolStripMenuItem_Click(object sender, EventArgs e) {
            Delay(300);
        }

        private void turnMonitorToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MonitorMessageNotifier.IsMonitorShutdown) {
                TurnOnMonitor();
            } else {
                TurnOffMonitor(); 
            }
        }

        #endregion





    }
}
