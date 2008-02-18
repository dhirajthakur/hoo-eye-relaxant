namespace Hoo.Relaxant {
    partial class SettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.workingLabel = new System.Windows.Forms.Label();
            this.breakingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.workingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.breakingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.maxDelayNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.maxDelayLable = new System.Windows.Forms.Label();
            this.shutdownCheck = new System.Windows.Forms.CheckBox();
            this.musicFileLabel = new System.Windows.Forms.Label();
            this.musicFileEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.terminateBreakingRadioes = new DevExpress.XtraEditors.RadioGroup();
            this.terminateBreakingLable = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabs = new DevExpress.XtraTab.XtraTabControl();
            this.generalTab = new DevExpress.XtraTab.XtraTabPage();
            this.breakingTab = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.workingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFileEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminateBreakingRadioes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabs)).BeginInit();
            this.xtraTabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.breakingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Location = new System.Drawing.Point(184, 224);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 31);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // workingLabel
            // 
            this.workingLabel.AutoSize = true;
            this.workingLabel.Location = new System.Drawing.Point(9, 19);
            this.workingLabel.Name = "workingLabel";
            this.workingLabel.Size = new System.Drawing.Size(137, 13);
            this.workingLabel.TabIndex = 1;
            this.workingLabel.Text = "Continous Working Minutes";
            // 
            // breakingLabel
            // 
            this.breakingLabel.AutoSize = true;
            this.breakingLabel.Location = new System.Drawing.Point(222, 19);
            this.breakingLabel.Name = "breakingLabel";
            this.breakingLabel.Size = new System.Drawing.Size(89, 13);
            this.breakingLabel.TabIndex = 2;
            this.breakingLabel.Text = "Breaking Minutes";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(304, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 31);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "All sound files(*.wav;*.mp3;*.wma)|*.wav;*.mp3;*.wma|Wave files(*.wav)|*.wav|MP3 " +
                "files(*.mp3)|*.mp3|Windows Media Files(*.wma)|*.wma";
            // 
            // workingNumeric
            // 
            this.workingNumeric.EditValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.workingNumeric.Location = new System.Drawing.Point(154, 15);
            this.workingNumeric.Name = "workingNumeric";
            this.workingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.workingNumeric.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.workingNumeric.Properties.IsFloatValue = false;
            this.workingNumeric.Properties.Mask.EditMask = "N00";
            this.workingNumeric.Properties.MaxLength = 3;
            this.workingNumeric.Properties.MaxValue = new decimal(new int[] {
            129,
            0,
            0,
            0});
            this.workingNumeric.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.workingNumeric.Size = new System.Drawing.Size(47, 20);
            this.workingNumeric.TabIndex = 7;
            this.workingNumeric.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.workingNumeric_Spin);
            // 
            // breakingNumeric
            // 
            this.breakingNumeric.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.breakingNumeric.Location = new System.Drawing.Point(320, 15);
            this.breakingNumeric.Name = "breakingNumeric";
            this.breakingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.breakingNumeric.Properties.IsFloatValue = false;
            this.breakingNumeric.Properties.Mask.EditMask = "N00";
            this.breakingNumeric.Properties.MaxLength = 2;
            this.breakingNumeric.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.breakingNumeric.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.breakingNumeric.Size = new System.Drawing.Size(47, 20);
            this.breakingNumeric.TabIndex = 8;
            // 
            // maxDelayNumeric
            // 
            this.maxDelayNumeric.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.maxDelayNumeric.Location = new System.Drawing.Point(533, 15);
            this.maxDelayNumeric.Name = "maxDelayNumeric";
            this.maxDelayNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maxDelayNumeric.Properties.IsFloatValue = false;
            this.maxDelayNumeric.Properties.Mask.EditMask = "N00";
            this.maxDelayNumeric.Properties.MaxLength = 2;
            this.maxDelayNumeric.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxDelayNumeric.Size = new System.Drawing.Size(47, 20);
            this.maxDelayNumeric.TabIndex = 10;
            // 
            // maxDelayLable
            // 
            this.maxDelayLable.AutoSize = true;
            this.maxDelayLable.Location = new System.Drawing.Point(397, 19);
            this.maxDelayLable.Name = "maxDelayLable";
            this.maxDelayLable.Size = new System.Drawing.Size(121, 13);
            this.maxDelayLable.TabIndex = 9;
            this.maxDelayLable.Text = "Maximum Delay Minutes";
            // 
            // shutdownCheck
            // 
            this.shutdownCheck.AutoSize = true;
            this.shutdownCheck.Checked = true;
            this.shutdownCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shutdownCheck.Location = new System.Drawing.Point(345, 14);
            this.shutdownCheck.Name = "shutdownCheck";
            this.shutdownCheck.Size = new System.Drawing.Size(112, 17);
            this.shutdownCheck.TabIndex = 11;
            this.shutdownCheck.Text = "Shutdown Monitor";
            this.shutdownCheck.UseVisualStyleBackColor = true;
            // 
            // musicFileLabel
            // 
            this.musicFileLabel.AutoSize = true;
            this.musicFileLabel.Location = new System.Drawing.Point(3, 46);
            this.musicFileLabel.Name = "musicFileLabel";
            this.musicFileLabel.Size = new System.Drawing.Size(58, 13);
            this.musicFileLabel.TabIndex = 12;
            this.musicFileLabel.Text = "Play Music";
            // 
            // musicFileEdit
            // 
            this.musicFileEdit.Location = new System.Drawing.Point(80, 43);
            this.musicFileEdit.Name = "musicFileEdit";
            this.musicFileEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.musicFileEdit.Size = new System.Drawing.Size(377, 20);
            this.musicFileEdit.TabIndex = 13;
            this.musicFileEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.musicFileEdit_ButtonClick);
            this.musicFileEdit.Validating += new System.ComponentModel.CancelEventHandler(this.musicFileEdit_Validating);
            // 
            // terminateBreakingRadioes
            // 
            this.terminateBreakingRadioes.EditValue = Hoo.Relaxant.RestrictionLevels.Forbidden;
            this.terminateBreakingRadioes.Location = new System.Drawing.Point(106, 11);
            this.terminateBreakingRadioes.Name = "terminateBreakingRadioes";
            this.terminateBreakingRadioes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Free, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Forbidden, "No"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Restricted, "Restricted")});
            this.terminateBreakingRadioes.Size = new System.Drawing.Size(222, 22);
            this.terminateBreakingRadioes.TabIndex = 14;
            // 
            // terminateBreakingLable
            // 
            this.terminateBreakingLable.Location = new System.Drawing.Point(3, 16);
            this.terminateBreakingLable.Name = "terminateBreakingLable";
            this.terminateBreakingLable.Size = new System.Drawing.Size(81, 13);
            this.terminateBreakingLable.TabIndex = 15;
            this.terminateBreakingLable.Text = "Allow Terminate?";
            // 
            // xtraTabs
            // 
            this.xtraTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabs.Location = new System.Drawing.Point(0, 0);
            this.xtraTabs.Name = "xtraTabs";
            this.xtraTabs.SelectedTabPage = this.generalTab;
            this.xtraTabs.Size = new System.Drawing.Size(630, 200);
            this.xtraTabs.TabIndex = 16;
            this.xtraTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalTab,
            this.breakingTab});
            this.xtraTabs.Text = "xtraTabControl1";
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.workingNumeric);
            this.generalTab.Controls.Add(this.workingLabel);
            this.generalTab.Controls.Add(this.breakingLabel);
            this.generalTab.Controls.Add(this.breakingNumeric);
            this.generalTab.Controls.Add(this.maxDelayLable);
            this.generalTab.Controls.Add(this.maxDelayNumeric);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(621, 169);
            this.generalTab.Text = "General";
            // 
            // breakingTab
            // 
            this.breakingTab.Controls.Add(this.terminateBreakingLable);
            this.breakingTab.Controls.Add(this.musicFileEdit);
            this.breakingTab.Controls.Add(this.terminateBreakingRadioes);
            this.breakingTab.Controls.Add(this.musicFileLabel);
            this.breakingTab.Controls.Add(this.shutdownCheck);
            this.breakingTab.Name = "breakingTab";
            this.breakingTab.Size = new System.Drawing.Size(621, 169);
            this.breakingTab.Text = "Breaking Options";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 271);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabs);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFileEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminateBreakingRadioes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabs)).EndInit();
            this.xtraTabs.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.breakingTab.ResumeLayout(false);
            this.breakingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label workingLabel;
        private System.Windows.Forms.Label breakingLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private DevExpress.XtraEditors.SpinEdit workingNumeric;
        private DevExpress.XtraEditors.SpinEdit breakingNumeric;
        private DevExpress.XtraEditors.SpinEdit maxDelayNumeric;
        private System.Windows.Forms.Label maxDelayLable;
        private System.Windows.Forms.CheckBox shutdownCheck;
        private System.Windows.Forms.Label musicFileLabel;
        private DevExpress.XtraEditors.ButtonEdit musicFileEdit;
        private DevExpress.XtraEditors.RadioGroup terminateBreakingRadioes;
        private DevExpress.XtraEditors.LabelControl terminateBreakingLable;
        private DevExpress.XtraTab.XtraTabControl xtraTabs;
        private DevExpress.XtraTab.XtraTabPage generalTab;
        private DevExpress.XtraTab.XtraTabPage breakingTab;
    }
}