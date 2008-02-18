namespace Hoo.Relaxant {
    partial class RunningForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunningForm));
            this.eyesNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.spanLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spanBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // eyesNotifyIcon
            // 
            this.eyesNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.eyesNotifyIcon.BalloonTipText = "Welcome!\r\nThis is Hush";
            this.eyesNotifyIcon.BalloonTipTitle = "Hush Relaxant";
            this.eyesNotifyIcon.ContextMenuStrip = this.mainMenu;
            this.eyesNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("eyesNotifyIcon.Icon")));
            this.eyesNotifyIcon.Text = "Relax Eyes";
            this.eyesNotifyIcon.Visible = true;
            this.eyesNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eyesNotifyIcon_MouseClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(150, 114);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.previewToolStripMenuItem.Text = "&Breaking Now";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.restartToolStripMenuItem.Text = "Restart &Work";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.settingToolStripMenuItem.Text = "&Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // spanBar
            // 
            this.spanBar.CausesValidation = false;
            this.spanBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spanBar.EditValue = "50";
            this.spanBar.Location = new System.Drawing.Point(0, 83);
            this.spanBar.Name = "spanBar";
            this.spanBar.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.spanBar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.spanBar.Properties.Appearance.Options.UseBackColor = true;
            this.spanBar.Properties.Appearance.Options.UseForeColor = true;
            this.spanBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spanBar.Properties.EndColor = System.Drawing.Color.Firebrick;
            this.spanBar.Properties.StartColor = System.Drawing.SystemColors.HotTrack;
            this.spanBar.Properties.Step = 1;
            this.spanBar.ShowToolTips = false;
            this.spanBar.Size = new System.Drawing.Size(184, 10);
            this.spanBar.TabIndex = 11;
            // 
            // spanLabel
            // 
            this.spanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spanLabel.AutoSize = true;
            this.spanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.spanLabel.Location = new System.Drawing.Point(2, 20);
            this.spanLabel.Name = "spanLabel";
            this.spanLabel.Size = new System.Drawing.Size(164, 42);
            this.spanLabel.TabIndex = 10;
            this.spanLabel.Text = "00:00:00";
            this.spanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(184, 93);
            this.ControlBox = false;
            this.Controls.Add(this.spanBar);
            this.Controls.Add(this.spanLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunningForm";
            this.Opacity = 0.7;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time to Next Break";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.RunningForm_Deactivate);
            this.Load += new System.EventHandler(this.RuningForm_Load);
            this.mainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spanBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon eyesNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private DevExpress.XtraEditors.ProgressBarControl spanBar;
        private System.Windows.Forms.Label spanLabel;
    }
}