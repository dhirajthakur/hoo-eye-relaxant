namespace Hush.Relaxant {
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
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.closeButton.CausesValidation = false;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(424, 370);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(159, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // breakingSpanLabel
            // 
            this.breakingSpanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breakingSpanLabel.AutoSize = true;
            this.breakingSpanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakingSpanLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.breakingSpanLabel.Location = new System.Drawing.Point(250, 213);
            this.breakingSpanLabel.Name = "breakingSpanLabel";
            this.breakingSpanLabel.Size = new System.Drawing.Size(164, 42);
            this.breakingSpanLabel.TabIndex = 2;
            this.breakingSpanLabel.Text = "00:00:00";
            this.breakingSpanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.messageLabel.Location = new System.Drawing.Point(16, 118);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(694, 25);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "You are working for long time, please take a break and relax your eyes.";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delayButton
            // 
            this.delayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delayButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.delayButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.delayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayButton.ForeColor = System.Drawing.Color.Black;
            this.delayButton.Location = new System.Drawing.Point(163, 370);
            this.delayButton.Name = "delayButton";
            this.delayButton.Size = new System.Drawing.Size(159, 50);
            this.delayButton.TabIndex = 7;
            this.delayButton.Text = "&Delay";
            this.delayButton.UseVisualStyleBackColor = false;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // breakingSpanBar
            // 
            this.breakingSpanBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.breakingSpanBar.CausesValidation = false;
            this.breakingSpanBar.EditValue = "50";
            this.breakingSpanBar.Location = new System.Drawing.Point(12, 267);
            this.breakingSpanBar.Name = "breakingSpanBar";
            this.breakingSpanBar.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.breakingSpanBar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.breakingSpanBar.Properties.Appearance.Options.UseBackColor = true;
            this.breakingSpanBar.Properties.Appearance.Options.UseForeColor = true;
            this.breakingSpanBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.breakingSpanBar.Properties.EndColor = System.Drawing.Color.Firebrick;
            this.breakingSpanBar.Properties.StartColor = System.Drawing.SystemColors.HotTrack;
            this.breakingSpanBar.ShowToolTips = false;
            this.breakingSpanBar.Size = new System.Drawing.Size(698, 5);
            this.breakingSpanBar.TabIndex = 9;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.delayToolStripMenuItem,
            this.turnMonitorToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(215, 70);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.closeToolStripMenuItem.Text = "&Close";
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
            this.delayToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.delayToolStripMenuItem.Text = "&Delay";
            // 
            // delay1ToolStripMenuItem
            // 
            this.delay1ToolStripMenuItem.Name = "delay1ToolStripMenuItem";
            this.delay1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.delay1ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.delay1ToolStripMenuItem.Text = "Delay 0.5m";
            this.delay1ToolStripMenuItem.Click += new System.EventHandler(this.delay1ToolStripMenuItem_Click);
            // 
            // delay2ToolStripMenuItem
            // 
            this.delay2ToolStripMenuItem.Name = "delay2ToolStripMenuItem";
            this.delay2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.delay2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.delay2ToolStripMenuItem.Text = "Delay 1m";
            this.delay2ToolStripMenuItem.Click += new System.EventHandler(this.delay2ToolStripMenuItem_Click);
            // 
            // delay3ToolStripMenuItem
            // 
            this.delay3ToolStripMenuItem.Name = "delay3ToolStripMenuItem";
            this.delay3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.delay3ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.delay3ToolStripMenuItem.Text = "Delay 2m";
            this.delay3ToolStripMenuItem.Click += new System.EventHandler(this.delay3ToolStripMenuItem_Click);
            // 
            // delay4ToolStripMenuItem
            // 
            this.delay4ToolStripMenuItem.Name = "delay4ToolStripMenuItem";
            this.delay4ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.delay4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.delay4ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.delay4ToolStripMenuItem.Text = "Delay 5m";
            this.delay4ToolStripMenuItem.Click += new System.EventHandler(this.delay4ToolStripMenuItem_Click);
            // 
            // turnMonitorToolStripMenuItem
            // 
            this.turnMonitorToolStripMenuItem.Name = "turnMonitorToolStripMenuItem";
            this.turnMonitorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.turnMonitorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.turnMonitorToolStripMenuItem.Text = "&Turn On/Off Monitor";
            this.turnMonitorToolStripMenuItem.Click += new System.EventHandler(this.turnMonitorToolStripMenuItem_Click);
            // 
            // BreakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(722, 447);
            this.ContextMenuStrip = this.contextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.breakingSpanBar);
            this.Controls.Add(this.delayButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.breakingSpanLabel);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreakingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hush Relax Your Eyes {Project.Version}";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BreakingForm_Load);
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

