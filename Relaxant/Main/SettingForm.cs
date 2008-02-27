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

namespace Hoo.Relaxant {
    public partial class SettingForm : Form {
        private int workingMinutes = Settings.Default.WorkingMinutes;
        private int breakingMinutes = Settings.Default.BreakingMinutes;

        public SettingForm() {
            InitializeComponent();
            this.Text = "Settings of " + AboutBox.AssemblyProduct + " " + AboutBox.AssemblyVersion;
        }




        private void cancelButton_Click(object sender, EventArgs e) {
            musicFileEdit.CausesValidation = false;
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e) {
            //General Setting
            workingNumeric.Value = Settings.Default.WorkingMinutes;
            breakingNumeric.Value = Settings.Default.BreakingMinutes;
            maxDelayNumeric.Value = Settings.Default.MaxDelayMinutes;

            languageCombo.Properties.Items.Clear();
            languageCombo.Properties.Items.AddRange(new object[] {
            new MyCultureInfo(""), new MyCultureInfo("en"),new MyCultureInfo("zh-CN")});
            MyCultureInfo current = new MyCultureInfo(Settings.Default.Language);
            languageCombo.EditValue = current;


            //Breaking Settings
            musicFileEdit.Text = Settings.Default.MusicFile;
            breakingCompletingWarnningEdit.Text = Settings.Default.Sound4CompletingBreaking;
            shutdownCheck.Checked = Settings.Default.ShutdownMonitor;
            terminateBreakingRadioes.EditValue = Settings.Default.Resctriction4TerminateBreaking;
            
    
        }


        

        private void saveButton_Click(object sender, EventArgs e) {
            
            //General Settings
            Settings.Default.WorkingMinutes = (int)workingNumeric.Value;
            Settings.Default.BreakingMinutes = (int)breakingNumeric.Value;
            Settings.Default.MaxDelayMinutes = (int)maxDelayNumeric.Value;
            Settings.Default.Language = ((MyCultureInfo)languageCombo.SelectedItem).Culture;

            //Breaking Settings

            Settings.Default.Resctriction4TerminateBreaking = (RestrictionLevels)terminateBreakingRadioes.EditValue;
            Settings.Default.MusicFile = musicFileEdit.Text;            
            Settings.Default.ShutdownMonitor = shutdownCheck.Checked;
            Settings.Default.Sound4CompletingBreaking = breakingCompletingWarnningEdit.Text;


            Settings.Default.Save();

            MessageBox.Show("Save Sucessfully, Some settings perhaps maybe not work until restart this program.", "", MessageBoxButtons.OK);

            
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

        private void breakingCompletingWarnningEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            fileDialog.InitialDirectory = Application.ExecutablePath;
            fileDialog.FileName = breakingCompletingWarnningEdit.Text;
            fileDialog.ShowDialog(this);
            breakingCompletingWarnningEdit.Text = fileDialog.FileName;
        }

        private void musicFileEdit_Validating(object sender, CancelEventArgs e) {
            //Check whether the file's full path is correct or not
            if (musicFileEdit.Text.Trim() != "") {
                FileInfo f = new FileInfo(musicFileEdit.Text.Trim());
                if (!f.Exists) {
                    e.Cancel = true;
                    return;
                }
                string ext = f.Extension.ToLower();
                if (ext != ".wav" && ext != ".mp3" && ext != ".wma") {       
                    
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void breakingCompletingWarnningEdit_Validating(object sender, CancelEventArgs e) {
            //Check whether the file's full path is correct or not
            if (breakingCompletingWarnningEdit.Text.Trim() != "") {
                FileInfo f = new FileInfo(breakingCompletingWarnningEdit.Text.Trim());
                if (!f.Exists) {
                    e.Cancel = true;
                    return;
                }
                string ext = f.Extension.ToLower();
                if (ext != ".wav" && ext != ".mp3" && ext != ".wma") {

                    e.Cancel = true;
                    return;
                }
            }
        }




        /// <summary>
        /// Rewrite ToString() to fit DevExpress ComboBoxEdit's item display text.
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
                if (Culture.Name == "") return "System Default";
                return Culture.NativeName;
            }


        }

        
    }
}