
using System;
using System.Threading;
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
		private const int SplashInterval = 3; // 3 seconds for splash interval
	    private bool monitorShouldOff = false;
		
		public RunningControl Manager { get; private set; }

		#region Form initialize and manager event handlers

		public BreakingForm(RunningControl pManager) {
			log.Debug("Initialize new BreakingForm.");
			this.Manager = pManager;
			InitializeComponent();

#if DEBUG
			this.FormBorderStyle = FormBorderStyle.Sizable;
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
			log.Debug("Event Raised: BreakingDelaying");
			this.Close();
		}

		void Manager_BreakingTerminating(object sender, EventArgs e) {
			log.Debug("Event Raised: BreakingTerminating");
			//if (!Manager.IsForceTeminate) {
			//    Program.PlaySystemSound(Settings.Default.SystemSound4CompletingBreak);
			//    PlayWarningSound();
			//}
			log.Debug("Call form method to close it.");
			this.Close();
		}


		void Manager_SecondTick(object sender, EventArgs e) {
			TimeSpan breakingSpan = TimeSpan.FromSeconds(Manager.PendingSeconds);
			breakingSpanLabel.Text = breakingSpan.ToString();
			breakingSpanBar.Decrement(1);

			//Start breaking effects serval seconds after show breaking form.
			if (Manager.PlannedSeconds - Manager.PendingSeconds == SplashInterval) {
				StartBreakingEffects();
			}

			//Stop breaking effects serval seconds before close breaking form.
			if (Manager.PendingSeconds == SplashInterval) {
				StopBreakingEffects();
			}

            //Turn off monitor every 30 seconds if monitor automatically turned on.
            if (((Manager.PlannedSeconds - Manager.PendingSeconds) % 30) == SplashInterval) {
                if(monitorShouldOff && MonitorMessageNotifier.IsMonitorShutdown==false) {
                    log.Debug("Turning off monitor every 30 seconds");
                    TurnOffMonitor(0);
                }
            }
			
		}




		#endregion

		#region private methods

		/// <summary>
		/// Start some breaking effects based on configuration.
		/// </summary>
		/// <remarks>
		/// All effects should be started totally after show breaking form.
		/// </remarks>
		private void StartBreakingEffects() {
			log.Debug("Playing Music...");
			PlayMusic();
			if (Settings.Default.ShutdownMonitor) {
				log.Debug("Turning off monitor...");
				TurnOffMonitor(0);
			}

		}

		/// <summary>
		/// Stop all breaking effects.
		/// </summary>
		/// <remarks>
		/// Try best to stop all breaking effects serveral seconds before closing breaking form.
		/// </remarks>
		private void StopBreakingEffects() {
			MonitorController.TurnOn();
			log.Debug("Stop Music");
			StopMusic();
		}
	
		/// <summary>
		/// Turn off display after specified milliseconds.
		/// </summary>
		/// <param name="milliseconds">the time span before turn off display</param>
		private void TurnOffMonitor(int milliseconds) {
			if (milliseconds > 0) {
				Thread.Sleep(milliseconds);
			}
			MonitorController.TurnOff();
		    monitorShouldOff = true;
		}

		private void TurnOnMonitor() {
			MonitorController.TurnOn();
		    monitorShouldOff = false;
		}


		private void PlayMusic() {
			String fileLocation = Properties.Settings.Default.MusicFile;

			if (fileLocation != "") {
				try {
					music = new SoundFile(fileLocation);
				    music.Repeat = true;
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
		

		private void DelayBreaking(int seconds) {
			int availableSeconds = Manager.AvailableDelaySeconds;

			if (availableSeconds <= 0) {
				MessageBox.Show("You could not delay any longer untill a full seconds breaking!", "Invalided Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void TerminateBreaking() {
			bool allowTerminate = true;
			log.Debug("Check permission to close BreakingForm");
			if (Settings.Default.Resctriction4TerminateBreaking == RestrictionLevels.Restricted) {
				if (!Settings.Default.AdminPassword.Equals(passwordText.Text.Trim())) {
					allowTerminate = false;
					MessageBox.Show("Please input correct password to terminate breaking.", "Terminating is Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (allowTerminate) {
				log.Debug("Closing BreakingForm...");
				Close();
				log.Debug("Call Manager to terminate breaking...");

				Manager.TerminateBreaking();
			}
		}

		#endregion

		#region  Form events and Context Menu
		private void BreakingForm_Load(object sender, EventArgs e) {
			log.Debug("Load BreakingForm");
			if (Settings.Default.Resctriction4TerminateBreaking == RestrictionLevels.Forbidden) {
				closeButton.Enabled = false;
				closeToolStripMenuItem.Enabled = false;
				closeButton.ForeColor = System.Drawing.Color.DimGray;
			}
			if (Settings.Default.DelayMinutes * 60 <= Manager.DelayedSeconds) {
				delayButton.Enabled = false;
				delayToolStripMenuItem.Enabled = false;
			}

			

			this.Activate();
			this.Focus();
			this.Select();

		}

		private void BreakingForm_Shown(object sender, EventArgs e) {
			log.Debug("Event Raised: BreakingForm_Shown");
			this.Activate();
			this.Focus();
			this.Select();

		}

		

		private void BreakingForm_FormClosing(object sender, FormClosingEventArgs e) {
			log.Debug("Event Raised: Closing BreakingForm");
			
			StopBreakingEffects(); //The effects perhanps have already been stopped before. This is double confirmation. 
			Manager.SecondTick -= Manager_SecondTick;
			Manager.BreakingTerminating -= new EventHandler(Manager_BreakingTerminating);
			Manager.BreakingDelaying -= new EventHandler(Manager_BreakingDelaying);
		}

		private void BreakingForm_FormClosed(object sender, FormClosedEventArgs e) {
			log.Debug("Closed BreakingForm...");

		}

		private void closeButton_Click(object sender, EventArgs e) {
			TerminateBreaking();	
		}

		


		private void delayButton_Click(object sender, EventArgs e) {
			DelayBreaking(30);

		}


		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutBox f = new AboutBox();
			f.ShowDialog();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
			TerminateBreaking();			
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
			Manager.QuitApplication();
		}

		private void delay1ToolStripMenuItem_Click(object sender, EventArgs e) {
			DelayBreaking(30);
		}

		private void delay2ToolStripMenuItem_Click(object sender, EventArgs e) {
			DelayBreaking(60);
		}

		private void delay3ToolStripMenuItem_Click(object sender, EventArgs e) {
			DelayBreaking(120);
		}

		private void delay4ToolStripMenuItem_Click(object sender, EventArgs e) {
			DelayBreaking(300);
		}

		private void turnMonitorToolStripMenuItem_Click(object sender, EventArgs e) {
			if (MonitorMessageNotifier.IsMonitorShutdown) {
			    log.Debug("Monitor is shutdown, Turn on monitor");
				TurnOnMonitor();
			} else {
				TurnOffMonitor(500); //Wait 0.5 second to ignore key events
			}
		}

		#endregion

		private void passwordText_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Return) {
				TerminateBreaking();
			}
		}








	}
}
