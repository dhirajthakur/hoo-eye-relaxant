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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.workingLabel = new System.Windows.Forms.Label();
            this.breakingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.workingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.breakingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.delayNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.delayLable = new System.Windows.Forms.Label();
            this.shutdownCheck = new System.Windows.Forms.CheckBox();
            this.musicFileLabel = new System.Windows.Forms.Label();
            this.musicFileEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraTabs = new DevExpress.XtraTab.XtraTabControl();
            this.generalTab = new DevExpress.XtraTab.XtraTabPage();
            this.languageCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.adminTab = new DevExpress.XtraTab.XtraTabPage();
            this.breakingRestrictionRadioGroup = new System.Windows.Forms.GroupBox();
            this.RestrcitTeminationRadio = new System.Windows.Forms.RadioButton();
            this.forbiddenTerminationRadio = new System.Windows.Forms.RadioButton();
            this.freeTerminationRadio = new System.Windows.Forms.RadioButton();
            this.terminateBreakingLable = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.maxDelayNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.maxWorkingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minBreakingNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.minBreakingPercentNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.breakingTab = new DevExpress.XtraTab.XtraTabPage();
            this.ShutdownHotkeyLabel = new System.Windows.Forms.Label();
            this.shutdownHotkeyCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.breakingCompletingWarnningEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.saveMessage = new System.Windows.Forms.Label();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.workingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFileEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabs)).BeginInit();
            this.xtraTabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageCombo.Properties)).BeginInit();
            this.adminTab.SuspendLayout();
            this.breakingRestrictionRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorkingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBreakingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBreakingPercentNumeric.Properties)).BeginInit();
            this.breakingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownHotkeyCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingCompletingWarnningEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.Tag = "";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // workingLabel
            // 
            resources.ApplyResources(this.workingLabel, "workingLabel");
            this.workingLabel.Name = "workingLabel";
            // 
            // breakingLabel
            // 
            resources.ApplyResources(this.breakingLabel, "breakingLabel");
            this.breakingLabel.Name = "breakingLabel";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileDialog
            // 
            resources.ApplyResources(this.fileDialog, "fileDialog");
            // 
            // workingNumeric
            // 
            resources.ApplyResources(this.workingNumeric, "workingNumeric");
            this.workingNumeric.Name = "workingNumeric";
            this.workingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.workingNumeric.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.workingNumeric.Properties.IsFloatValue = false;
            this.workingNumeric.Properties.Mask.EditMask = resources.GetString("workingNumeric.Properties.Mask.EditMask");
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
            this.workingNumeric.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.integer_Spin);
            // 
            // breakingNumeric
            // 
            resources.ApplyResources(this.breakingNumeric, "breakingNumeric");
            this.breakingNumeric.Name = "breakingNumeric";
            this.breakingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.breakingNumeric.Properties.IsFloatValue = false;
            this.breakingNumeric.Properties.Mask.EditMask = resources.GetString("breakingNumeric.Properties.Mask.EditMask");
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
            // 
            // delayNumeric
            // 
            resources.ApplyResources(this.delayNumeric, "delayNumeric");
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.delayNumeric.Properties.IsFloatValue = false;
            this.delayNumeric.Properties.Mask.EditMask = resources.GetString("delayNumeric.Properties.Mask.EditMask");
            this.delayNumeric.Properties.MaxLength = 2;
            this.delayNumeric.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // delayLable
            // 
            resources.ApplyResources(this.delayLable, "delayLable");
            this.delayLable.Name = "delayLable";
            // 
            // shutdownCheck
            // 
            resources.ApplyResources(this.shutdownCheck, "shutdownCheck");
            this.shutdownCheck.Checked = true;
            this.shutdownCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shutdownCheck.Name = "shutdownCheck";
            this.shutdownCheck.UseVisualStyleBackColor = true;
            // 
            // musicFileLabel
            // 
            resources.ApplyResources(this.musicFileLabel, "musicFileLabel");
            this.musicFileLabel.Name = "musicFileLabel";
            // 
            // musicFileEdit
            // 
            resources.ApplyResources(this.musicFileEdit, "musicFileEdit");
            this.musicFileEdit.Name = "musicFileEdit";
            this.musicFileEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.musicFileEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.musicFileEdit_ButtonClick);
            this.musicFileEdit.Validating += new System.ComponentModel.CancelEventHandler(this.musicFileEdit_Validating);
            // 
            // xtraTabs
            // 
            resources.ApplyResources(this.xtraTabs, "xtraTabs");
            this.xtraTabs.Name = "xtraTabs";
            this.xtraTabs.SelectedTabPage = this.generalTab;
            this.xtraTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalTab,
            this.adminTab,
            this.breakingTab});
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.languageCombo);
            this.generalTab.Controls.Add(this.label2);
            this.generalTab.Controls.Add(this.workingNumeric);
            this.generalTab.Controls.Add(this.workingLabel);
            this.generalTab.Controls.Add(this.breakingLabel);
            this.generalTab.Controls.Add(this.breakingNumeric);
            this.generalTab.Controls.Add(this.delayLable);
            this.generalTab.Controls.Add(this.delayNumeric);
            this.generalTab.Name = "generalTab";
            resources.ApplyResources(this.generalTab, "generalTab");
            // 
            // languageCombo
            // 
            resources.ApplyResources(this.languageCombo, "languageCombo");
            this.languageCombo.Name = "languageCombo";
            this.languageCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.languageCombo.Properties.Items.AddRange(new object[] {
            resources.GetString("languageCombo.Properties.Items"),
            resources.GetString("languageCombo.Properties.Items1"),
            resources.GetString("languageCombo.Properties.Items2")});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.breakingRestrictionRadioGroup);
            this.adminTab.Controls.Add(this.terminateBreakingLable);
            this.adminTab.Controls.Add(this.label7);
            this.adminTab.Controls.Add(this.maxDelayNumeric);
            this.adminTab.Controls.Add(this.maxWorkingNumeric);
            this.adminTab.Controls.Add(this.label3);
            this.adminTab.Controls.Add(this.label4);
            this.adminTab.Controls.Add(this.minBreakingNumeric);
            this.adminTab.Controls.Add(this.label5);
            this.adminTab.Controls.Add(this.minBreakingPercentNumeric);
            this.adminTab.Controls.Add(this.setPasswordButton);
            this.adminTab.Controls.Add(this.passwordText);
            this.adminTab.Controls.Add(this.passwordButton);
            this.adminTab.Controls.Add(this.label6);
            this.adminTab.Name = "adminTab";
            resources.ApplyResources(this.adminTab, "adminTab");
            // 
            // breakingRestrictionRadioGroup
            // 
            this.breakingRestrictionRadioGroup.Controls.Add(this.RestrcitTeminationRadio);
            this.breakingRestrictionRadioGroup.Controls.Add(this.forbiddenTerminationRadio);
            this.breakingRestrictionRadioGroup.Controls.Add(this.freeTerminationRadio);
            resources.ApplyResources(this.breakingRestrictionRadioGroup, "breakingRestrictionRadioGroup");
            this.breakingRestrictionRadioGroup.Name = "breakingRestrictionRadioGroup";
            this.breakingRestrictionRadioGroup.TabStop = false;
            // 
            // RestrcitTeminationRadio
            // 
            resources.ApplyResources(this.RestrcitTeminationRadio, "RestrcitTeminationRadio");
            this.RestrcitTeminationRadio.Name = "RestrcitTeminationRadio";
            this.RestrcitTeminationRadio.TabStop = true;
            this.RestrcitTeminationRadio.UseVisualStyleBackColor = true;
            // 
            // forbiddenTerminationRadio
            // 
            resources.ApplyResources(this.forbiddenTerminationRadio, "forbiddenTerminationRadio");
            this.forbiddenTerminationRadio.Name = "forbiddenTerminationRadio";
            this.forbiddenTerminationRadio.TabStop = true;
            this.forbiddenTerminationRadio.UseVisualStyleBackColor = true;
            // 
            // freeTerminationRadio
            // 
            resources.ApplyResources(this.freeTerminationRadio, "freeTerminationRadio");
            this.freeTerminationRadio.Name = "freeTerminationRadio";
            this.freeTerminationRadio.TabStop = true;
            this.freeTerminationRadio.UseVisualStyleBackColor = true;
            // 
            // terminateBreakingLable
            // 
            resources.ApplyResources(this.terminateBreakingLable, "terminateBreakingLable");
            this.terminateBreakingLable.Name = "terminateBreakingLable";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // maxDelayNumeric
            // 
            resources.ApplyResources(this.maxDelayNumeric, "maxDelayNumeric");
            this.maxDelayNumeric.Name = "maxDelayNumeric";
            this.maxDelayNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maxDelayNumeric.Properties.IsFloatValue = false;
            this.maxDelayNumeric.Properties.Mask.EditMask = resources.GetString("maxDelayNumeric.Properties.Mask.EditMask");
            this.maxDelayNumeric.Properties.MaxLength = 2;
            this.maxDelayNumeric.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // maxWorkingNumeric
            // 
            resources.ApplyResources(this.maxWorkingNumeric, "maxWorkingNumeric");
            this.maxWorkingNumeric.Name = "maxWorkingNumeric";
            this.maxWorkingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maxWorkingNumeric.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxWorkingNumeric.Properties.IsFloatValue = false;
            this.maxWorkingNumeric.Properties.Mask.EditMask = resources.GetString("maxWorkingNumeric.Properties.Mask.EditMask");
            this.maxWorkingNumeric.Properties.MaxLength = 3;
            this.maxWorkingNumeric.Properties.MaxValue = new decimal(new int[] {
            129,
            0,
            0,
            0});
            this.maxWorkingNumeric.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxWorkingNumeric.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.integer_Spin);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // minBreakingNumeric
            // 
            resources.ApplyResources(this.minBreakingNumeric, "minBreakingNumeric");
            this.minBreakingNumeric.Name = "minBreakingNumeric";
            this.minBreakingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.minBreakingNumeric.Properties.IsFloatValue = false;
            this.minBreakingNumeric.Properties.Mask.EditMask = resources.GetString("minBreakingNumeric.Properties.Mask.EditMask");
            this.minBreakingNumeric.Properties.MaxLength = 2;
            this.minBreakingNumeric.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minBreakingNumeric.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // minBreakingPercentNumeric
            // 
            resources.ApplyResources(this.minBreakingPercentNumeric, "minBreakingPercentNumeric");
            this.minBreakingPercentNumeric.Name = "minBreakingPercentNumeric";
            this.minBreakingPercentNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.minBreakingPercentNumeric.Properties.DisplayFormat.FormatString = "P0";
            this.minBreakingPercentNumeric.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.minBreakingPercentNumeric.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.minBreakingPercentNumeric.Properties.Mask.EditMask = resources.GetString("minBreakingPercentNumeric.Properties.Mask.EditMask");
            this.minBreakingPercentNumeric.Properties.MaxLength = 4;
            this.minBreakingPercentNumeric.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.minBreakingPercentNumeric.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.minBreakingPercentNumeric.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.integer_Spin);
            // 
            // setPasswordButton
            // 
            resources.ApplyResources(this.setPasswordButton, "setPasswordButton");
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.UseVisualStyleBackColor = true;
            // 
            // passwordText
            // 
            resources.ApplyResources(this.passwordText, "passwordText");
            this.passwordText.Name = "passwordText";
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordText_KeyUp);
            // 
            // passwordButton
            // 
            resources.ApplyResources(this.passwordButton, "passwordButton");
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // breakingTab
            // 
            this.breakingTab.Controls.Add(this.ShutdownHotkeyLabel);
            this.breakingTab.Controls.Add(this.shutdownHotkeyCombo);
            this.breakingTab.Controls.Add(this.breakingCompletingWarnningEdit);
            this.breakingTab.Controls.Add(this.label1);
            this.breakingTab.Controls.Add(this.musicFileEdit);
            this.breakingTab.Controls.Add(this.musicFileLabel);
            this.breakingTab.Controls.Add(this.shutdownCheck);
            this.breakingTab.Name = "breakingTab";
            resources.ApplyResources(this.breakingTab, "breakingTab");
            // 
            // ShutdownHotkeyLabel
            // 
            resources.ApplyResources(this.ShutdownHotkeyLabel, "ShutdownHotkeyLabel");
            this.ShutdownHotkeyLabel.Name = "ShutdownHotkeyLabel";
            // 
            // shutdownHotkeyCombo
            // 
            resources.ApplyResources(this.shutdownHotkeyCombo, "shutdownHotkeyCombo");
            this.shutdownHotkeyCombo.Name = "shutdownHotkeyCombo";
            this.shutdownHotkeyCombo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.shutdownHotkeyCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shutdownHotkeyCombo.Properties.Items.AddRange(new object[] {
            resources.GetString("shutdownHotkeyCombo.Properties.Items"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items1"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items2"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items3"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items4"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items5"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items6"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items7"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items8"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items9"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items10"),
            resources.GetString("shutdownHotkeyCombo.Properties.Items11")});
            // 
            // breakingCompletingWarnningEdit
            // 
            resources.ApplyResources(this.breakingCompletingWarnningEdit, "breakingCompletingWarnningEdit");
            this.breakingCompletingWarnningEdit.Name = "breakingCompletingWarnningEdit";
            this.breakingCompletingWarnningEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.breakingCompletingWarnningEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.breakingCompletingWarnningEdit_ButtonClick);
            this.breakingCompletingWarnningEdit.Validating += new System.ComponentModel.CancelEventHandler(this.breakingCompletingWarnningEdit_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // saveMessage
            // 
            resources.ApplyResources(this.saveMessage, "saveMessage");
            this.saveMessage.CausesValidation = false;
            this.saveMessage.Name = "saveMessage";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.saveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.saveMessage);
            this.Controls.Add(this.xtraTabs);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFileEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabs)).EndInit();
            this.xtraTabs.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageCombo.Properties)).EndInit();
            this.adminTab.ResumeLayout(false);
            this.adminTab.PerformLayout();
            this.breakingRestrictionRadioGroup.ResumeLayout(false);
            this.breakingRestrictionRadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorkingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBreakingNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBreakingPercentNumeric.Properties)).EndInit();
            this.breakingTab.ResumeLayout(false);
            this.breakingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownHotkeyCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingCompletingWarnningEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label workingLabel;
        private System.Windows.Forms.Label breakingLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private DevExpress.XtraEditors.SpinEdit workingNumeric;
        private DevExpress.XtraEditors.SpinEdit breakingNumeric;
        private DevExpress.XtraEditors.SpinEdit delayNumeric;
        private System.Windows.Forms.Label delayLable;
        private System.Windows.Forms.CheckBox shutdownCheck;
        private System.Windows.Forms.Label musicFileLabel;
        private DevExpress.XtraEditors.ButtonEdit musicFileEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabs;
        private DevExpress.XtraTab.XtraTabPage generalTab;
        private DevExpress.XtraTab.XtraTabPage breakingTab;
        private DevExpress.XtraEditors.ButtonEdit breakingCompletingWarnningEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit languageCombo;
        private System.Windows.Forms.Label saveMessage;
        private DevExpress.XtraTab.XtraTabPage adminTab;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button setPasswordButton;
        private DevExpress.XtraEditors.SpinEdit maxWorkingNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit minBreakingNumeric;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit minBreakingPercentNumeric;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit maxDelayNumeric;
        private DevExpress.XtraEditors.LabelControl terminateBreakingLable;
        private System.Windows.Forms.Label ShutdownHotkeyLabel;
        private DevExpress.XtraEditors.ComboBoxEdit shutdownHotkeyCombo;
        private System.Windows.Forms.GroupBox breakingRestrictionRadioGroup;
        private System.Windows.Forms.RadioButton RestrcitTeminationRadio;
        private System.Windows.Forms.RadioButton forbiddenTerminationRadio;
        private System.Windows.Forms.RadioButton freeTerminationRadio;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}