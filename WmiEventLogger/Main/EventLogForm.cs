using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hush.WmiEventLogger {
    public partial class EventLogForm : Form {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private EventWatcherAsync[] watcher = new EventWatcherAsync[5];

        public EventLogForm() {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e) {
            string[] wqlArray = new string[] { textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim() };

            try {
                for (int i = 0; i < 5; i++) {
                    if (wqlArray[i].Length > 0) {
                        watcher[i] = new EventWatcherAsync(wqlArray[i]);
                        watcher[i].Start();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Failer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                if (watcher[i] != null) {
                    watcher[i].Stop();
                }
            }
        }

        private void EventLogForm_Load(object sender, EventArgs e) {
        }





    }
}
