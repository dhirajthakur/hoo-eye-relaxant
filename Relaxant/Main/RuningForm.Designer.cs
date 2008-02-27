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
            resources.ApplyResources(this.eyesNotifyIcon, "eyesNotifyIcon");
            this.eyesNotifyIcon.ContextMenuStrip = this.mainMenu;
            this.eyesNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eyesNotifyIcon_MouseClick);
            // 
            // mainMenu
            // 
            this.mainMenu.AccessibleDescription = null;
            this.mainMenu.AccessibleName = null;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.BackgroundImage = null;
            this.mainMenu.Font = null;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Name = "mainMenu";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.AccessibleDescription = null;
            this.previewToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.previewToolStripMenuItem, "previewToolStripMenuItem");
            this.previewToolStripMenuItem.BackgroundImage = null;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.AccessibleDescription = null;
            this.restartToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.BackgroundImage = null;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.AccessibleDescription = null;
            this.settingToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
            this.settingToolStripMenuItem.BackgroundImage = null;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.AccessibleDescription = null;
            this.quitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.BackgroundImage = null;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // spanBar
            // 
            resources.ApplyResources(this.spanBar, "spanBar");
            this.spanBar.BackgroundImage = null;
            this.spanBar.CausesValidation = false;
            this.spanBar.Name = "spanBar";
            this.spanBar.Properties.AccessibleDescription = null;
            this.spanBar.Properties.AccessibleName = null;
            this.spanBar.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.spanBar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.spanBar.Properties.Appearance.Options.UseBackColor = true;
            this.spanBar.Properties.Appearance.Options.UseForeColor = true;
            this.spanBar.Properties.AutoHeight = ((bool)(resources.GetObject("spanBar.Properties.AutoHeight")));
            this.spanBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spanBar.Properties.EndColor = System.Drawing.Color.Firebrick;
            this.spanBar.Properties.StartColor = System.Drawing.SystemColors.HotTrack;
            this.spanBar.Properties.Step = 1;
            this.spanBar.ShowToolTips = false;
            // 
            // spanLabel
            // 
            this.spanLabel.AccessibleDescription = null;
            this.spanLabel.AccessibleName = null;
            resources.ApplyResources(this.spanLabel, "spanLabel");
            this.spanLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.spanLabel.Name = "spanLabel";
            // 
            // RunningForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.spanBar);
            this.Controls.Add(this.spanLabel);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunningForm";
            this.Opacity = 0.7;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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