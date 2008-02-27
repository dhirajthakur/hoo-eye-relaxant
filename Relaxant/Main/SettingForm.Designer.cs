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
            this.languageCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.breakingTab = new DevExpress.XtraTab.XtraTabPage();
            this.breakingCompletingWarnningEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFileEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminateBreakingRadioes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabs)).BeginInit();
            this.xtraTabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageCombo.Properties)).BeginInit();
            this.breakingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakingCompletingWarnningEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.AccessibleDescription = null;
            this.saveButton.AccessibleName = null;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.BackgroundImage = null;
            this.saveButton.Font = null;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // workingLabel
            // 
            this.workingLabel.AccessibleDescription = null;
            this.workingLabel.AccessibleName = null;
            resources.ApplyResources(this.workingLabel, "workingLabel");
            this.workingLabel.Font = null;
            this.workingLabel.Name = "workingLabel";
            // 
            // breakingLabel
            // 
            this.breakingLabel.AccessibleDescription = null;
            this.breakingLabel.AccessibleName = null;
            resources.ApplyResources(this.breakingLabel, "breakingLabel");
            this.breakingLabel.Font = null;
            this.breakingLabel.Name = "breakingLabel";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleDescription = null;
            this.cancelButton.AccessibleName = null;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.BackgroundImage = null;
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = null;
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
            this.workingNumeric.BackgroundImage = null;
            this.workingNumeric.Name = "workingNumeric";
            this.workingNumeric.Properties.AccessibleDescription = null;
            this.workingNumeric.Properties.AccessibleName = null;
            this.workingNumeric.Properties.AutoHeight = ((bool)(resources.GetObject("workingNumeric.Properties.AutoHeight")));
            this.workingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.workingNumeric.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.workingNumeric.Properties.IsFloatValue = false;
            this.workingNumeric.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("workingNumeric.Properties.Mask.AutoComplete")));
            this.workingNumeric.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("workingNumeric.Properties.Mask.BeepOnError")));
            this.workingNumeric.Properties.Mask.EditMask = resources.GetString("workingNumeric.Properties.Mask.EditMask");
            this.workingNumeric.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("workingNumeric.Properties.Mask.IgnoreMaskBlank")));
            this.workingNumeric.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("workingNumeric.Properties.Mask.MaskType")));
            this.workingNumeric.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("workingNumeric.Properties.Mask.PlaceHolder")));
            this.workingNumeric.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("workingNumeric.Properties.Mask.SaveLiteral")));
            this.workingNumeric.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("workingNumeric.Properties.Mask.ShowPlaceHolders")));
            this.workingNumeric.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("workingNumeric.Properties.Mask.UseMaskAsDisplayFormat")));
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
            this.workingNumeric.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.workingNumeric_Spin);
            // 
            // breakingNumeric
            // 
            resources.ApplyResources(this.breakingNumeric, "breakingNumeric");
            this.breakingNumeric.BackgroundImage = null;
            this.breakingNumeric.Name = "breakingNumeric";
            this.breakingNumeric.Properties.AccessibleDescription = null;
            this.breakingNumeric.Properties.AccessibleName = null;
            this.breakingNumeric.Properties.AutoHeight = ((bool)(resources.GetObject("breakingNumeric.Properties.AutoHeight")));
            this.breakingNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.breakingNumeric.Properties.IsFloatValue = false;
            this.breakingNumeric.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("breakingNumeric.Properties.Mask.AutoComplete")));
            this.breakingNumeric.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("breakingNumeric.Properties.Mask.BeepOnError")));
            this.breakingNumeric.Properties.Mask.EditMask = resources.GetString("breakingNumeric.Properties.Mask.EditMask");
            this.breakingNumeric.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("breakingNumeric.Properties.Mask.IgnoreMaskBlank")));
            this.breakingNumeric.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("breakingNumeric.Properties.Mask.MaskType")));
            this.breakingNumeric.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("breakingNumeric.Properties.Mask.PlaceHolder")));
            this.breakingNumeric.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("breakingNumeric.Properties.Mask.SaveLiteral")));
            this.breakingNumeric.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("breakingNumeric.Properties.Mask.ShowPlaceHolders")));
            this.breakingNumeric.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("breakingNumeric.Properties.Mask.UseMaskAsDisplayFormat")));
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
            // maxDelayNumeric
            // 
            resources.ApplyResources(this.maxDelayNumeric, "maxDelayNumeric");
            this.maxDelayNumeric.BackgroundImage = null;
            this.maxDelayNumeric.Name = "maxDelayNumeric";
            this.maxDelayNumeric.Properties.AccessibleDescription = null;
            this.maxDelayNumeric.Properties.AccessibleName = null;
            this.maxDelayNumeric.Properties.AutoHeight = ((bool)(resources.GetObject("maxDelayNumeric.Properties.AutoHeight")));
            this.maxDelayNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maxDelayNumeric.Properties.IsFloatValue = false;
            this.maxDelayNumeric.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("maxDelayNumeric.Properties.Mask.AutoComplete")));
            this.maxDelayNumeric.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("maxDelayNumeric.Properties.Mask.BeepOnError")));
            this.maxDelayNumeric.Properties.Mask.EditMask = resources.GetString("maxDelayNumeric.Properties.Mask.EditMask");
            this.maxDelayNumeric.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("maxDelayNumeric.Properties.Mask.IgnoreMaskBlank")));
            this.maxDelayNumeric.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("maxDelayNumeric.Properties.Mask.MaskType")));
            this.maxDelayNumeric.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("maxDelayNumeric.Properties.Mask.PlaceHolder")));
            this.maxDelayNumeric.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("maxDelayNumeric.Properties.Mask.SaveLiteral")));
            this.maxDelayNumeric.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("maxDelayNumeric.Properties.Mask.ShowPlaceHolders")));
            this.maxDelayNumeric.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("maxDelayNumeric.Properties.Mask.UseMaskAsDisplayFormat")));
            this.maxDelayNumeric.Properties.MaxLength = 2;
            this.maxDelayNumeric.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // maxDelayLable
            // 
            this.maxDelayLable.AccessibleDescription = null;
            this.maxDelayLable.AccessibleName = null;
            resources.ApplyResources(this.maxDelayLable, "maxDelayLable");
            this.maxDelayLable.Font = null;
            this.maxDelayLable.Name = "maxDelayLable";
            // 
            // shutdownCheck
            // 
            this.shutdownCheck.AccessibleDescription = null;
            this.shutdownCheck.AccessibleName = null;
            resources.ApplyResources(this.shutdownCheck, "shutdownCheck");
            this.shutdownCheck.BackgroundImage = null;
            this.shutdownCheck.Checked = true;
            this.shutdownCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shutdownCheck.Font = null;
            this.shutdownCheck.Name = "shutdownCheck";
            this.shutdownCheck.UseVisualStyleBackColor = true;
            // 
            // musicFileLabel
            // 
            this.musicFileLabel.AccessibleDescription = null;
            this.musicFileLabel.AccessibleName = null;
            resources.ApplyResources(this.musicFileLabel, "musicFileLabel");
            this.musicFileLabel.Font = null;
            this.musicFileLabel.Name = "musicFileLabel";
            // 
            // musicFileEdit
            // 
            resources.ApplyResources(this.musicFileEdit, "musicFileEdit");
            this.musicFileEdit.BackgroundImage = null;
            this.musicFileEdit.EditValue = null;
            this.musicFileEdit.Name = "musicFileEdit";
            this.musicFileEdit.Properties.AccessibleDescription = null;
            this.musicFileEdit.Properties.AccessibleName = null;
            this.musicFileEdit.Properties.AutoHeight = ((bool)(resources.GetObject("musicFileEdit.Properties.AutoHeight")));
            this.musicFileEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.musicFileEdit.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("musicFileEdit.Properties.Mask.AutoComplete")));
            this.musicFileEdit.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("musicFileEdit.Properties.Mask.BeepOnError")));
            this.musicFileEdit.Properties.Mask.EditMask = resources.GetString("musicFileEdit.Properties.Mask.EditMask");
            this.musicFileEdit.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("musicFileEdit.Properties.Mask.IgnoreMaskBlank")));
            this.musicFileEdit.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("musicFileEdit.Properties.Mask.MaskType")));
            this.musicFileEdit.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("musicFileEdit.Properties.Mask.PlaceHolder")));
            this.musicFileEdit.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("musicFileEdit.Properties.Mask.SaveLiteral")));
            this.musicFileEdit.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("musicFileEdit.Properties.Mask.ShowPlaceHolders")));
            this.musicFileEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("musicFileEdit.Properties.Mask.UseMaskAsDisplayFormat")));
            this.musicFileEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.musicFileEdit_ButtonClick);
            this.musicFileEdit.Validating += new System.ComponentModel.CancelEventHandler(this.musicFileEdit_Validating);
            // 
            // terminateBreakingRadioes
            // 
            resources.ApplyResources(this.terminateBreakingRadioes, "terminateBreakingRadioes");
            this.terminateBreakingRadioes.BackgroundImage = null;
            this.terminateBreakingRadioes.Name = "terminateBreakingRadioes";
            this.terminateBreakingRadioes.Properties.AccessibleDescription = null;
            this.terminateBreakingRadioes.Properties.AccessibleName = null;
            this.terminateBreakingRadioes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Free, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Forbidden, "No"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(Hoo.Relaxant.RestrictionLevels.Restricted, "Restricted")});
            // 
            // terminateBreakingLable
            // 
            this.terminateBreakingLable.AccessibleDescription = null;
            this.terminateBreakingLable.AccessibleName = null;
            resources.ApplyResources(this.terminateBreakingLable, "terminateBreakingLable");
            this.terminateBreakingLable.Name = "terminateBreakingLable";
            // 
            // xtraTabs
            // 
            this.xtraTabs.AccessibleDescription = null;
            this.xtraTabs.AccessibleName = null;
            resources.ApplyResources(this.xtraTabs, "xtraTabs");
            this.xtraTabs.BackgroundImage = null;
            this.xtraTabs.Font = null;
            this.xtraTabs.Images = null;
            this.xtraTabs.Name = "xtraTabs";
            this.xtraTabs.SelectedTabPage = this.generalTab;
            this.xtraTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalTab,
            this.breakingTab});
            // 
            // generalTab
            // 
            this.generalTab.AccessibleDescription = null;
            this.generalTab.AccessibleName = null;
            resources.ApplyResources(this.generalTab, "generalTab");
            this.generalTab.BackgroundImage = null;
            this.generalTab.Controls.Add(this.languageCombo);
            this.generalTab.Controls.Add(this.label2);
            this.generalTab.Controls.Add(this.workingNumeric);
            this.generalTab.Controls.Add(this.workingLabel);
            this.generalTab.Controls.Add(this.breakingLabel);
            this.generalTab.Controls.Add(this.breakingNumeric);
            this.generalTab.Controls.Add(this.maxDelayLable);
            this.generalTab.Controls.Add(this.maxDelayNumeric);
            this.generalTab.Font = null;
            this.generalTab.Name = "generalTab";
            // 
            // languageCombo
            // 
            resources.ApplyResources(this.languageCombo, "languageCombo");
            this.languageCombo.BackgroundImage = null;
            this.languageCombo.Name = "languageCombo";
            this.languageCombo.Properties.AccessibleDescription = null;
            this.languageCombo.Properties.AccessibleName = null;
            this.languageCombo.Properties.AutoHeight = ((bool)(resources.GetObject("languageCombo.Properties.AutoHeight")));
            this.languageCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.languageCombo.Properties.Items.AddRange(new object[] {
            resources.GetString("languageCombo.Properties.Items"),
            resources.GetString("languageCombo.Properties.Items1"),
            resources.GetString("languageCombo.Properties.Items2")});
            this.languageCombo.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("languageCombo.Properties.Mask.AutoComplete")));
            this.languageCombo.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("languageCombo.Properties.Mask.BeepOnError")));
            this.languageCombo.Properties.Mask.EditMask = resources.GetString("languageCombo.Properties.Mask.EditMask");
            this.languageCombo.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("languageCombo.Properties.Mask.IgnoreMaskBlank")));
            this.languageCombo.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("languageCombo.Properties.Mask.MaskType")));
            this.languageCombo.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("languageCombo.Properties.Mask.PlaceHolder")));
            this.languageCombo.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("languageCombo.Properties.Mask.SaveLiteral")));
            this.languageCombo.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("languageCombo.Properties.Mask.ShowPlaceHolders")));
            this.languageCombo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("languageCombo.Properties.Mask.UseMaskAsDisplayFormat")));
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // breakingTab
            // 
            this.breakingTab.AccessibleDescription = null;
            this.breakingTab.AccessibleName = null;
            resources.ApplyResources(this.breakingTab, "breakingTab");
            this.breakingTab.BackgroundImage = null;
            this.breakingTab.Controls.Add(this.breakingCompletingWarnningEdit);
            this.breakingTab.Controls.Add(this.label1);
            this.breakingTab.Controls.Add(this.terminateBreakingLable);
            this.breakingTab.Controls.Add(this.musicFileEdit);
            this.breakingTab.Controls.Add(this.terminateBreakingRadioes);
            this.breakingTab.Controls.Add(this.musicFileLabel);
            this.breakingTab.Controls.Add(this.shutdownCheck);
            this.breakingTab.Font = null;
            this.breakingTab.Name = "breakingTab";
            // 
            // breakingCompletingWarnningEdit
            // 
            resources.ApplyResources(this.breakingCompletingWarnningEdit, "breakingCompletingWarnningEdit");
            this.breakingCompletingWarnningEdit.BackgroundImage = null;
            this.breakingCompletingWarnningEdit.EditValue = null;
            this.breakingCompletingWarnningEdit.Name = "breakingCompletingWarnningEdit";
            this.breakingCompletingWarnningEdit.Properties.AccessibleDescription = null;
            this.breakingCompletingWarnningEdit.Properties.AccessibleName = null;
            this.breakingCompletingWarnningEdit.Properties.AutoHeight = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.AutoHeight")));
            this.breakingCompletingWarnningEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.breakingCompletingWarnningEdit.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.AutoComplete")));
            this.breakingCompletingWarnningEdit.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.BeepOnError")));
            this.breakingCompletingWarnningEdit.Properties.Mask.EditMask = resources.GetString("breakingCompletingWarnningEdit.Properties.Mask.EditMask");
            this.breakingCompletingWarnningEdit.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.IgnoreMaskBlank")));
            this.breakingCompletingWarnningEdit.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.MaskType")));
            this.breakingCompletingWarnningEdit.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.PlaceHolder")));
            this.breakingCompletingWarnningEdit.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.SaveLiteral")));
            this.breakingCompletingWarnningEdit.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.ShowPlaceHolders")));
            this.breakingCompletingWarnningEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("breakingCompletingWarnningEdit.Properties.Mask.UseMaskAsDisplayFormat")));
            this.breakingCompletingWarnningEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.breakingCompletingWarnningEdit_ButtonClick);
            this.breakingCompletingWarnningEdit.Validating += new System.ComponentModel.CancelEventHandler(this.breakingCompletingWarnningEdit_Validating);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.saveButton;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabs);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.languageCombo.Properties)).EndInit();
            this.breakingTab.ResumeLayout(false);
            this.breakingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakingCompletingWarnningEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ButtonEdit breakingCompletingWarnningEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit languageCombo;
    }
}