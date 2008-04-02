
using System;
using System.Windows.Forms;
using Hoo.Device.Monitor;

using Hoo.Relaxant.Properties;
using Org.Mentalis.Multimedia;


namespace Hoo.Relaxant {
    /// <summary>
    /// When breaking, show this form with full screen model.
    /// </summary>
    partial class BreakingForm : Form {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private MediaFile music = null;

        public RunningControl Manager { get; private set; }
        
        #region Form initialize and manager event handlers

        public BreakingForm(RunningControl pManager) {
            this.Manager = pManager;
            InitializeComponent();

            
#if DEBUG
            WindowState = FormWindowState.Normal;

#endif
            this.Text = AssemblyInfo.Product + " " + AssemblyInfo.Version;

            turnMonitorToolStripMenuItem.ShortcutKeys = Settings.Default.ShutdownMonitorHotkey;

            breakingSpanBar.Properties.Maximum = Manager.PlannedSeconds;
            breakingSpanBar.Position = Manager.PendingSeconds;

            Manager.SecondTick += new EventHandler(Manager_SecondTick);
            Manager.BreakingTerminating += new EventHandler(Manager_BreakingTerminating);
            Manager.BreakingDelaying += new EventHandler(Manager_BreakingDelaying);
            
        }

        void Manager_BreakingDelaying(object sender, EventArgs e) {
            this.Close();
        }

        void Manager_BreakingTerminating(object sender, EventArgs e) {
            if (!Manager.IsForceTeminate) {
                Program.PlaySystemSound(Settings.Default.SystemSound4CompletingBreak);
                PlayWarningSound();
            }
            this.Close();
        }


        void Manager_SecondTick(object sender, EventArgs e) {
            TimeSpan breakingSpan = TimeSpan.FromSeconds(Manager.PendingSeconds);
            breakingSpanLabel.Text = breakingSpan.ToString();
            breakingSpanBar.Decrement(1);
        }

            

        
        #endregion
        
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

        private void PlayWarningSound() {
            String soundFile = Properties.Settings.Default.Sound4CompletingBreak;
            if (soundFile != "") {
                try {
                    SoundFile sound = new SoundFile(soundFile);                    
                    sound.Play();                    
                } catch (Exception ex) {
                    log.Error("Could not play music!", ex);
                }
            }
        }

     

        private void Delay(int seconds) {            
            int availableSeconds = Manager.AvailableDelaySeconds;

            if(availableSeconds <=0) {
                MessageBox.Show("You could not delay any longer untill a full seconds breaking!","Invalided Action",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            } else if (availableSeconds < seconds) {
                string msg = String.Format("You only have {0} seconds to delay before a full seconds breaking. Do you still want to delay?", availableSeconds);
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                    seconds = availableSeconds;
                } else {
                    return;
                }
            }
            Close();
            Manager.DelayBreaking(seconds);
            
        }

        #endregion

        #region  Form events and Context Menu
        private void BreakingForm_Load(object sender, EventArgs e) {
            if (Settings.Default.Resctriction4TerminateBreaking == RestrictionLevels.Forbidden) {
                closeButton.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
                closeButton.ForeColor = System.Drawing.Color.DimGray;
            }
            if (Settings.Default.DelayMinutes * 60 <= Manager.DelayedSeconds) {
                delayButton.Enabled = false;
                delayToolStripMenuItem.Enabled = false;
            }

            PlayMusic();


            if (Settings.Default.ShutdownMonitor) {
                TurnOffMonitor();
            }

            this.Activate();
            this.Focus();
            this.Select();

        }

        private void BreakingForm_Shown(object sender, EventArgs e) {
            this.Activate();
            this.Focus();
            this.Select();

        }

        private void BreakingForm_FormClosing(object sender, FormClosingEventArgs e) {
            
            MonitorController.TurnOn();
            StopMusic();
        }

         private void closeButton_Click(object sender, EventArgs e) {            
            Close();
            Manager.TerminateBreaking();
        }


        private void delayButton_Click(object sender, EventArgs e) {
            Delay(30);

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox f = new AboutBox();
            f.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
            Manager.TerminateBreaking();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Manager.QuitApplication();
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
