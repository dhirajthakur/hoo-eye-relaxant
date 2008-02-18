namespace Hoo.InputDevice.Test {
    partial class TraceForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceForm));
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.resultinfo = new System.Windows.Forms.TextBox();
            this.stopkeyboard = new System.Windows.Forms.Button();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Location = new System.Drawing.Point(24, 10);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 25);
            this.start.TabIndex = 0;
            this.start.Text = "¿ªÊ¼¼à¿Ø";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(117, 10);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 25);
            this.stop.TabIndex = 1;
            this.stop.Text = "»Ö¸´Õý³£";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // resultinfo
            // 
            this.resultinfo.Location = new System.Drawing.Point(24, 41);
            this.resultinfo.Multiline = true;
            this.resultinfo.Name = "resultinfo";
            this.resultinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultinfo.Size = new System.Drawing.Size(259, 315);
            this.resultinfo.TabIndex = 2;
            this.resultinfo.Text = "¼à¿Ø¼üÅÌºÍÊó±êµÄ²Ù×÷¼ÇÂ¼£º";
            // 
            // stopkeyboard
            // 
            this.stopkeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopkeyboard.Location = new System.Drawing.Point(208, 10);
            this.stopkeyboard.Name = "stopkeyboard";
            this.stopkeyboard.Size = new System.Drawing.Size(75, 25);
            this.stopkeyboard.TabIndex = 3;
            this.stopkeyboard.Text = "ÆÁ±Î¼üÅÌ";
            this.stopkeyboard.UseVisualStyleBackColor = true;
            this.stopkeyboard.Click += new System.EventHandler(this.stopkeyboard_Click);
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMousePosition.Location = new System.Drawing.Point(24, 366);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(37, 15);
            this.labelMousePosition.TabIndex = 4;
            this.labelMousePosition.Text = "label1";
            // 
            // TraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 391);
            this.Controls.Add(this.labelMousePosition);
            this.Controls.Add(this.stopkeyboard);
            this.Controls.Add(this.resultinfo);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraceForm";
            this.Text = "Hk_Form";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TraceForm_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox resultinfo;
        private System.Windows.Forms.Button stopkeyboard;
        private System.Windows.Forms.Label labelMousePosition;

    }
}