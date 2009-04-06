using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Hoo.Relaxant.Properties;
using System.Globalization;
using DevExpress.XtraEditors;
using System.Media;

namespace Hoo.Relaxant {
    public partial class SettingForm : Form {
        private int workingMinutes = Settings.Default.WorkingMinutes;
        private int breakingMinutes = Settings.Default.BreakingMinutes;
        private bool loading = false;

        public SettingForm() {
            InitializeComponent();
            this.Text += AssemblyInfo.Product + " " + AssemblyInfo.Version;
        }




        private void cancelButton_Click(object sender, EventArgs e) {
            musicFileEdit.CausesValidation = false;
            this.Close();
        }


        private void SetTerminateBreakingRadio(RestrictionLevels restriction) {

            switch(restriction) {
                case RestrictionLevels.Free:
                    freeTerminationRadio.Checked = true;
                    break;
                case RestrictionLevels.Forbidden:
                    forbiddenTerminationRadio.Checked = true;
                    break;
                default:
                    RestrcitTeminationRadio.Checked = true;
                    break;
            }
        }

        private RestrictionLevels GetTerminateBreakingRadio() {
            if(freeTerminationRadio.Checked) return RestrictionLevels.Free;
            if(forbiddenTerminationRadio.Checked) return RestrictionLevels.Forbidden;
            return RestrictionLevels.Restricted;

        }

        private void SettingForm_Load(object sender, EventArgs e) {
            loading = true;
            //Administration Settings            
            maxWorkingNumeric.Value = Settings.Default.MaxWorkingMinutes;
            minBreakingNumeric.Value = Settings.Default.MinBreakingMinutes;
            minBreakingPercentNumeric.Value = Settings.Default.MinBreakingPercent;
            maxDelayNumeric.Value = Settings.Default.MaxDelayMinutes;
            SetTerminateBreakingRadio(Settings.Default.Resctriction4TerminateBreaking);

            //General Setting
            workingNumeric.Value = Settings.Default.WorkingMinutes;
            breakingNumeric.Value = Settings.Default.BreakingMinutes;
            delayNumeric.Value = Settings.Default.DelayMinutes;
			adminPassowordText.Text = Settings.Default.AdminPassword;

            languageCombo.Properties.Items.Clear();
            languageCombo.Properties.Items.AddRange(new object[] {
            new MyCultureInfo(""), new MyCultureInfo("en"),new MyCultureInfo("zh-CN")});
            MyCultureInfo current = new MyCultureInfo(Settings.Default.Language);
            languageCombo.EditValue = current;


            //Breaking Settings
            musicFileEdit.Text = Settings.Default.MusicFile;
            breakCompletingWarnningEdit.Text = Settings.Default.Sound4CompletingBreak;
            shutdownCheck.Checked = Settings.Default.ShutdownMonitor;

            shutdownHotkeyCombo.Properties.Items.Clear();
            shutdownHotkeyCombo.Properties.Items.AddRange(
                new Keys[] { Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12 }
                );
            shutdownHotkeyCombo.EditValue = Settings.Default.ShutdownMonitorHotkey;

            //breakCompletingSystemWarningCombo.Properties.Items.Clear();            
            breakCompletingSystemWarningCombo.EditValue = Settings.Default.SystemSound4CompletingBreak ;
            loading = false;
        }




        private void saveButton_Click(object sender, EventArgs e) {
            //Administration Settings
            Settings.Default.MaxWorkingMinutes = (int)maxWorkingNumeric.Value;
            Settings.Default.MinBreakingMinutes = (int)minBreakingNumeric.Value;
            Settings.Default.MinBreakingPercent = (decimal)minBreakingPercentNumeric.Value;
            Settings.Default.MaxDelayMinutes = (int)maxDelayNumeric.Value;
            Settings.Default.Resctriction4TerminateBreaking = GetTerminateBreakingRadio();

            //General Settings
            Settings.Default.WorkingMinutes = (int)workingNumeric.Value;
            Settings.Default.BreakingMinutes = (int)breakingNumeric.Value;
            Settings.Default.DelayMinutes = (int)delayNumeric.Value;
            Settings.Default.Language = ((MyCultureInfo)languageCombo.SelectedItem).Culture;
			Settings.Default.AdminPassword = adminPassowordText.Text.Trim();

			//This is a temporary behavior before implementing comprehensive child care features.
			if (Settings.Default.AdminPassword == "") {
				Settings.Default.Resctriction4TerminateBreaking = RestrictionLevels.Free;
			} else {
				Settings.Default.Resctriction4TerminateBreaking = RestrictionLevels.Restricted;
			}

            //Breaking Settings
            Settings.Default.MusicFile = musicFileEdit.Text;
            Settings.Default.ShutdownMonitor = shutdownCheck.Checked;
            Settings.Default.ShutdownMonitorHotkey = (Keys)shutdownHotkeyCombo.SelectedItem;
            Settings.Default.Sound4CompletingBreak = breakCompletingWarnningEdit.Text;
            Settings.Default.SystemSound4CompletingBreak = (string)breakCompletingSystemWarningCombo.SelectedItem;

            Settings.Default.Save();

            MessageBox.Show(saveMessage.Text, "", MessageBoxButtons.OK);


            this.Close();
        }

        //private void musicFileButton_Click(object sender, EventArgs e) {
        //    fileDialog.InitialDirectory = Application.ExecutablePath;
        //    fileDialog.FileName = musicFileText.Text;            
        //    fileDialog.ShowDialog(this);
        //    musicFileText.Text = fileDialog.FileName;
        //}

        private void musicFileText_Validating(object sender, CancelEventArgs e) {
            ////Check whether the file's full path is correct or not
            //if (musicFileText.Text.Trim() != "" && musicCheck.Checked) {
            //    FileInfo f = new FileInfo(musicFileText.Text.Trim());
            //    if (!f.Exists) {
            //        e.Cancel = true;
            //        return;
            //    }

            //    if (f.Extension != "wav" && f.Extension != "mp3" && f.Extension != "wma") {
            //        e.Cancel = true;
            //        return;
            //    }
            //}
        }

        /// <summary>
        /// Customize SpinEdit up/down behavior based on increment step.
        /// For example, when increment step is 5, and current value is 13:
        /// Click up button will set the value to 15, click down button will set valut to 10.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void integer_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e) {
            SpinEdit spin = sender as SpinEdit;
            int divisor = 5;
            int compliment = 0;
            int percent = 1;
            if(spin.Properties.Increment < 1) {
                //The value of spin is percentage.
                percent = 100;
            }

            divisor = (int)(spin.Properties.Increment * percent);
            compliment = (int)(spin.Value * percent) % divisor;

            if(compliment > 0) {
                if(e.IsSpinUp) {
                    int result = (int)(spin.Value * percent) - compliment;
                    spin.Value = result / percent;
                    //spin.Value -= (compliment / percent);
                    
                } else {
                    //This event is earlier than default spin actions.
                    int result = (int)(spin.Value * percent) + divisor - compliment;
                    spin.Value = result / percent;
                    //spin.Value += ((divisor - compliment) / percent);
                }
            }
        }

        private void musicFileEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            fileDialog.InitialDirectory = Application.ExecutablePath;
            fileDialog.FileName = musicFileEdit.Text;
            fileDialog.ShowDialog(this);
            musicFileEdit.Text = fileDialog.FileName;
        }

        private void breakingCompletingWarnningEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            fileDialog.InitialDirectory = Application.ExecutablePath;
            fileDialog.FileName = breakCompletingWarnningEdit.Text;
            fileDialog.ShowDialog(this);
            breakCompletingWarnningEdit.Text = fileDialog.FileName;
        }

        private void musicFileEdit_Validating(object sender, CancelEventArgs e) {
            //Check whether the file's full path is correct or not
            if(musicFileEdit.Text.Trim() != "") {
                FileInfo f = new FileInfo(musicFileEdit.Text.Trim());
                if(!f.Exists) {
                    e.Cancel = true;
                    return;
                }
                string ext = f.Extension.ToLower();
                if(ext != ".wav" && ext != ".mp3" && ext != ".wma") {

                    e.Cancel = true;
                    return;
                }
            }
        }

        private void breakingCompletingWarnningEdit_Validating(object sender, CancelEventArgs e) {
            //Check whether the file's full path is correct or not
            if(breakCompletingWarnningEdit.Text.Trim() != "") {
                FileInfo f = new FileInfo(breakCompletingWarnningEdit.Text.Trim());
                if(!f.Exists) {
                    e.Cancel = true;
                    return;
                }
                string ext = f.Extension.ToLower();
                if(ext != ".wav" && ext != ".mp3" && ext != ".wma") {

                    e.Cancel = true;
                    return;
                }
            }
        }




        /// <summary>
        /// Rewrite ToString() in order to provide display text for  DevExpress ComboBoxEdit's item.
        /// </summary>
        private class MyCultureInfo {

            public CultureInfo Culture { get; set; }

            public MyCultureInfo(string cultureName) {
                Culture = new CultureInfo(cultureName);
            }

            public MyCultureInfo(CultureInfo culture) {
                Culture = culture;
            }

            public override string ToString() {
                if(Culture.Name == "") return "System Default";
                return Culture.NativeName;
            }


        }

        private void passwordButton_Click(object sender, EventArgs e) {

        }

        private void passwordText_KeyUp(object sender, KeyEventArgs e) {

        }

        private void breakCompletingSystemWarningCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (!loading) {
                string sound = (string)breakCompletingSystemWarningCombo.EditValue;
                Program.PlaySystemSound(sound);
            }
        }

        private void breakCompletingSystemWarningCombo_SelectedValueChanged(object sender, EventArgs e) {

        }

		


    }
}