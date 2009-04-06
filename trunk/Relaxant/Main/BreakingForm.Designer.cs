namespace Hoo.Relaxant {
    partial class BreakingForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakingForm));
			this.closeButton = new System.Windows.Forms.Button();
			this.breakingSpanLabel = new System.Windows.Forms.Label();
			this.messageLabel = new System.Windows.Forms.Label();
			this.delayButton = new System.Windows.Forms.Button();
			this.breakingSpanBar = new DevExpress.XtraEditors.ProgressBarControl();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delay1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delay2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delay3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delay4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turnMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.breakingSpanBar.Properties)).BeginInit();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			resources.ApplyResources(this.closeButton, "closeButton");
			this.closeButton.BackColor = System.Drawing.Color.LimeGreen;
			this.closeButton.CausesValidation = false;
			this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.closeButton.ForeColor = System.Drawing.Color.Black;
			this.closeButton.Name = "closeButton";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// breakingSpanLabel
			// 
			resources.ApplyResources(this.breakingSpanLabel, "breakingSpanLabel");
			this.breakingSpanLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.breakingSpanLabel.Name = "breakingSpanLabel";
			// 
			// messageLabel
			// 
			resources.ApplyResources(this.messageLabel, "messageLabel");
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.messageLabel.Name = "messageLabel";
			// 
			// delayButton
			// 
			resources.ApplyResources(this.delayButton, "delayButton");
			this.delayButton.BackColor = System.Drawing.Color.LimeGreen;
			this.delayButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.delayButton.ForeColor = System.Drawing.Color.Black;
			this.delayButton.Name = "delayButton";
			this.delayButton.UseVisualStyleBackColor = false;
			this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
			// 
			// breakingSpanBar
			// 
			resources.ApplyResources(this.breakingSpanBar, "breakingSpanBar");
			this.breakingSpanBar.CausesValidation = false;
			this.breakingSpanBar.Name = "breakingSpanBar";
			this.breakingSpanBar.Properties.Appearance.BackColor = System.Drawing.Color.LimeGreen;
			this.breakingSpanBar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
			this.breakingSpanBar.Properties.Appearance.Options.UseBackColor = true;
			this.breakingSpanBar.Properties.Appearance.Options.UseForeColor = true;
			this.breakingSpanBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.breakingSpanBar.Properties.EndColor = System.Drawing.Color.Firebrick;
			this.breakingSpanBar.Properties.StartColor = System.Drawing.SystemColors.HotTrack;
			this.breakingSpanBar.ShowToolTips = false;
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.delayToolStripMenuItem,
            this.turnMonitorToolStripMenuItem});
			this.contextMenu.Name = "contextMenu";
			resources.ApplyResources(this.contextMenu, "contextMenu");
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// delayToolStripMenuItem
			// 
			this.delayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delay1ToolStripMenuItem,
            this.delay2ToolStripMenuItem,
            this.delay3ToolStripMenuItem,
            this.delay4ToolStripMenuItem});
			this.delayToolStripMenuItem.Name = "delayToolStripMenuItem";
			resources.ApplyResources(this.delayToolStripMenuItem, "delayToolStripMenuItem");
			// 
			// delay1ToolStripMenuItem
			// 
			this.delay1ToolStripMenuItem.Name = "delay1ToolStripMenuItem";
			resources.ApplyResources(this.delay1ToolStripMenuItem, "delay1ToolStripMenuItem");
			this.delay1ToolStripMenuItem.Click += new System.EventHandler(this.delay1ToolStripMenuItem_Click);
			// 
			// delay2ToolStripMenuItem
			// 
			this.delay2ToolStripMenuItem.Name = "delay2ToolStripMenuItem";
			resources.ApplyResources(this.delay2ToolStripMenuItem, "delay2ToolStripMenuItem");
			this.delay2ToolStripMenuItem.Click += new System.EventHandler(this.delay2ToolStripMenuItem_Click);
			// 
			// delay3ToolStripMenuItem
			// 
			this.delay3ToolStripMenuItem.Name = "delay3ToolStripMenuItem";
			resources.ApplyResources(this.delay3ToolStripMenuItem, "delay3ToolStripMenuItem");
			this.delay3ToolStripMenuItem.Click += new System.EventHandler(this.delay3ToolStripMenuItem_Click);
			// 
			// delay4ToolStripMenuItem
			// 
			this.delay4ToolStripMenuItem.Name = "delay4ToolStripMenuItem";
			resources.ApplyResources(this.delay4ToolStripMenuItem, "delay4ToolStripMenuItem");
			this.delay4ToolStripMenuItem.Click += new System.EventHandler(this.delay4ToolStripMenuItem_Click);
			// 
			// turnMonitorToolStripMenuItem
			// 
			this.turnMonitorToolStripMenuItem.Name = "turnMonitorToolStripMenuItem";
			resources.ApplyResources(this.turnMonitorToolStripMenuItem, "turnMonitorToolStripMenuItem");
			this.turnMonitorToolStripMenuItem.Click += new System.EventHandler(this.turnMonitorToolStripMenuItem_Click);
			// 
			// passwordText
			// 
			resources.ApplyResources(this.passwordText, "passwordText");
			this.passwordText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.passwordText.Name = "passwordText";
			this.passwordText.UseSystemPasswordChar = true;
			this.passwordText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordText_KeyPress);
			// 
			// passwordLabel
			// 
			resources.ApplyResources(this.passwordLabel, "passwordLabel");
			this.passwordLabel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.passwordLabel.Name = "passwordLabel";
			// 
			// BreakingForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.CausesValidation = false;
			this.ContextMenuStrip = this.contextMenu;
			this.ControlBox = false;
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.breakingSpanBar);
			this.Controls.Add(this.delayButton);
			this.Controls.Add(this.breakingSpanLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.messageLabel);
			this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BreakingForm";
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.BreakingForm_Load);
			this.Shown += new System.EventHandler(this.BreakingForm_Shown);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BreakingForm_FormClosed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BreakingForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.breakingSpanBar.Properties)).EndInit();
			this.contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label breakingSpanLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button delayButton;
        
        private DevExpress.XtraEditors.ProgressBarControl breakingSpanBar;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnMonitorToolStripMenuItem;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Label passwordLabel;
    }
}

