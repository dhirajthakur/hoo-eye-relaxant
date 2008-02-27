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
            ((System.ComponentModel.ISupportInitialize)(this.breakingSpanBar.Properties)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AccessibleDescription = null;
            this.closeButton.AccessibleName = null;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.closeButton.BackgroundImage = null;
            this.closeButton.CausesValidation = false;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // breakingSpanLabel
            // 
            this.breakingSpanLabel.AccessibleDescription = null;
            this.breakingSpanLabel.AccessibleName = null;
            resources.ApplyResources(this.breakingSpanLabel, "breakingSpanLabel");
            this.breakingSpanLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.breakingSpanLabel.Name = "breakingSpanLabel";
            // 
            // messageLabel
            // 
            this.messageLabel.AccessibleDescription = null;
            this.messageLabel.AccessibleName = null;
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.messageLabel.Name = "messageLabel";
            // 
            // delayButton
            // 
            this.delayButton.AccessibleDescription = null;
            this.delayButton.AccessibleName = null;
            resources.ApplyResources(this.delayButton, "delayButton");
            this.delayButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.delayButton.BackgroundImage = null;
            this.delayButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.delayButton.ForeColor = System.Drawing.Color.Black;
            this.delayButton.Name = "delayButton";
            this.delayButton.UseVisualStyleBackColor = false;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // breakingSpanBar
            // 
            resources.ApplyResources(this.breakingSpanBar, "breakingSpanBar");
            this.breakingSpanBar.BackgroundImage = null;
            this.breakingSpanBar.CausesValidation = false;
            this.breakingSpanBar.Name = "breakingSpanBar";
            this.breakingSpanBar.Properties.AccessibleDescription = null;
            this.breakingSpanBar.Properties.AccessibleName = null;
            this.breakingSpanBar.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.breakingSpanBar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.breakingSpanBar.Properties.Appearance.Options.UseBackColor = true;
            this.breakingSpanBar.Properties.Appearance.Options.UseForeColor = true;
            this.breakingSpanBar.Properties.AutoHeight = ((bool)(resources.GetObject("breakingSpanBar.Properties.AutoHeight")));
            this.breakingSpanBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.breakingSpanBar.Properties.EndColor = System.Drawing.Color.Firebrick;
            this.breakingSpanBar.Properties.StartColor = System.Drawing.SystemColors.HotTrack;
            this.breakingSpanBar.ShowToolTips = false;
            // 
            // contextMenu
            // 
            this.contextMenu.AccessibleDescription = null;
            this.contextMenu.AccessibleName = null;
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.BackgroundImage = null;
            this.contextMenu.Font = null;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.delayToolStripMenuItem,
            this.turnMonitorToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.AccessibleDescription = null;
            this.closeToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.BackgroundImage = null;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // delayToolStripMenuItem
            // 
            this.delayToolStripMenuItem.AccessibleDescription = null;
            this.delayToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.delayToolStripMenuItem, "delayToolStripMenuItem");
            this.delayToolStripMenuItem.BackgroundImage = null;
            this.delayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delay1ToolStripMenuItem,
            this.delay2ToolStripMenuItem,
            this.delay3ToolStripMenuItem,
            this.delay4ToolStripMenuItem});
            this.delayToolStripMenuItem.Name = "delayToolStripMenuItem";
            this.delayToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // delay1ToolStripMenuItem
            // 
            this.delay1ToolStripMenuItem.AccessibleDescription = null;
            this.delay1ToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.delay1ToolStripMenuItem, "delay1ToolStripMenuItem");
            this.delay1ToolStripMenuItem.BackgroundImage = null;
            this.delay1ToolStripMenuItem.Name = "delay1ToolStripMenuItem";
            this.delay1ToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.delay1ToolStripMenuItem.Click += new System.EventHandler(this.delay1ToolStripMenuItem_Click);
            // 
            // delay2ToolStripMenuItem
            // 
            this.delay2ToolStripMenuItem.AccessibleDescription = null;
            this.delay2ToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.delay2ToolStripMenuItem, "delay2ToolStripMenuItem");
            this.delay2ToolStripMenuItem.BackgroundImage = null;
            this.delay2ToolStripMenuItem.Name = "delay2ToolStripMenuItem";
            this.delay2ToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.delay2ToolStripMenuItem.Click += new System.EventHandler(this.delay2ToolStripMenuItem_Click);
            // 
            // delay3ToolStripMenuItem
            // 
            this.delay3ToolStripMenuItem.AccessibleDescription = null;
            this.delay3ToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.delay3ToolStripMenuItem, "delay3ToolStripMenuItem");
            this.delay3ToolStripMenuItem.BackgroundImage = null;
            this.delay3ToolStripMenuItem.Name = "delay3ToolStripMenuItem";
            this.delay3ToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.delay3ToolStripMenuItem.Click += new System.EventHandler(this.delay3ToolStripMenuItem_Click);
            // 
            // delay4ToolStripMenuItem
            // 
            this.delay4ToolStripMenuItem.AccessibleDescription = null;
            this.delay4ToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.delay4ToolStripMenuItem, "delay4ToolStripMenuItem");
            this.delay4ToolStripMenuItem.BackgroundImage = null;
            this.delay4ToolStripMenuItem.Name = "delay4ToolStripMenuItem";
            this.delay4ToolStripMenuItem.Click += new System.EventHandler(this.delay4ToolStripMenuItem_Click);
            // 
            // turnMonitorToolStripMenuItem
            // 
            this.turnMonitorToolStripMenuItem.AccessibleDescription = null;
            this.turnMonitorToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.turnMonitorToolStripMenuItem, "turnMonitorToolStripMenuItem");
            this.turnMonitorToolStripMenuItem.BackgroundImage = null;
            this.turnMonitorToolStripMenuItem.Name = "turnMonitorToolStripMenuItem";
            this.turnMonitorToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.turnMonitorToolStripMenuItem.Click += new System.EventHandler(this.turnMonitorToolStripMenuItem_Click);
            // 
            // BreakingForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = null;
            this.CausesValidation = false;
            this.ContextMenuStrip = this.contextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.breakingSpanBar);
            this.Controls.Add(this.delayButton);
            this.Controls.Add(this.breakingSpanLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeButton);
            this.Font = null;
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreakingForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BreakingForm_Load);
            this.Shown += new System.EventHandler(this.BreakingForm_Shown);
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
    }
}

