using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Hoo.Relaxant.Properties;

namespace Hoo.Relaxant {
    public partial class SettingForm : Form {
        private int workingMinutes = Settings.Default.WorkingMinutes;
        private int breakingMinutes = Settings.Default.BreakingMinutes;

        public SettingForm() {
            InitializeComponent();
            this.Text = "Settings of " + AboutBox.AssemblyProduct + " " + AboutBox.AssemblyVersion;
        }






        //private void workingText_Validating(object sender, CancelEventArgs e) {
            
        //    if (!Int32.TryParse(workingText.Text, out workingMinutes)) {
        //        e.Cancel = true;
        //        MessageBox.Show("The inputed working minutes is not a numeric!","Working minutes validation fail", MessageBoxButtons.OK);
        //    } else if (workingMinutes < 1 | workingMinutes > 120) {
        //        e.Cancel = true;
        //        MessageBox.Show("The inputed working minutes should between 1 and 120.", "Working minutes validation fail", MessageBoxButtons.OK);
        //    }
        //}

        //private void breakingText_Validating(object sender, CancelEventArgs e) {

        //    if (!Int32.TryParse(breakingText.Text, out breakingMinutes)) {
        //        e.Cancel = true;
        //        MessageBox.Show("The inputed breaking minutes is not a numeric!", "Breaking minutes validation fail", MessageBoxButtons.OK);
        //    } else if (breakingMinutes < 1 | breakingMinutes > 30) {
        //        e.Cancel = true;
        //        MessageBox.Show("The inputed breaking minutes should between 1 and 30.", "Breaking minutes validation fail", MessageBoxButtons.OK);
        //    }
        //}

        private void cancelButton_Click(object sender, EventArgs e) {
            musicFileEdit.CausesValidation = false;
            //workingText.CausesValidation = false;
            //breakingText.CausesValidation = false;
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e) {
            //General Setting
            workingNumeric.Value = Settings.Default.WorkingMinutes;
            breakingNumeric.Value = Settings.Default.BreakingMinutes;
            maxDelayNumeric.Value = Settings.Default.MaxDelayMinutes;

            //Breaking Settings
            musicFileEdit.Text = Settings.Default.MusicFile;
            shutdownCheck.Checked = Settings.Default.ShutdownMonitor;
            terminateBreakingRadioes.EditValue = Settings.Default.Resctriction4TerminateBreaking;

        }

        private void saveButton_Click(object sender, EventArgs e) {
            
            //General Settings
            Settings.Default.WorkingMinutes = (int)workingNumeric.Value;
            Settings.Default.BreakingMinutes = (int)breakingNumeric.Value;
            Settings.Default.MaxDelayMinutes = (int)maxDelayNumeric.Value;

            //Breaking Settings

            Settings.Default.Resctriction4TerminateBreaking = (RestrictionLevels)terminateBreakingRadioes.EditValue;
            Settings.Default.MusicFile = musicFileEdit.Text;            
            Settings.Default.ShutdownMonitor = shutdownCheck.Checked; 


            Settings.Default.Save();
            
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


        private void workingNumeric_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e) {
            int num = (int)workingNumeric.Value % 5;
            if (num > 0) {
                if (e.IsSpinUp) {
                    workingNumeric.Value -= num;
                } else {
                    //This event is earlier than default spin actions.
                    workingNumeric.Value += (5 - num);
                }
            }
        }

        private void musicFileEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            fileDialog.InitialDirectory = Application.ExecutablePath;
            fileDialog.FileName = musicFileEdit.Text;
            fileDialog.ShowDialog(this);
            musicFileEdit.Text = fileDialog.FileName;
        }

        private void musicFileEdit_Validating(object sender, CancelEventArgs e) {
            //Check whether the file's full path is correct or not
            if (musicFileEdit.Text.Trim() != "") {
                FileInfo f = new FileInfo(musicFileEdit.Text.Trim());
                if (!f.Exists) {
                    e.Cancel = true;
                    return;
                }

                if (f.Extension != "wav" && f.Extension != "mp3" && f.Extension != "wma") {
                    e.Cancel = true;
                    return;
                }
            }
        }

        


        
    }
}