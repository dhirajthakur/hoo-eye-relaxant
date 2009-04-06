using System;
using System.Threading;
using System.Windows.Forms;
using Hoo.Device.Monitor;
using System.Diagnostics;

namespace Hoo.Relaxant.Test {
	public partial class MonitorServiceForm : Form {
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	    private static MonitorMessageNotifier MonitorNotifier = MonitorMessageNotifier.getInstance();
	    private int i = 0;
        
        public MonitorServiceForm() {
			InitializeComponent();
		}


		private void turnOffButton_Click(object sender, EventArgs e) {
		    log.Info("Turning off monitor...");
		    
			Thread.Sleep(500);
	        MonitorNotifier.MonitorOpened +=new EventHandler<MonitorEventArgs>(MonitorNotifier_MonitorOpened);
            
			MonitorController.TurnOff();
		    
		}

	    private void MonitorNotifier_MonitorOpened(object sender, MonitorEventArgs e) {
	        i++;
            if (i >=10) {
                i = 0;
                MonitorNotifier.MonitorOpened -= MonitorNotifier_MonitorOpened;
                return;
            }
	        log.Info("Turning off " + i);
            MonitorController.TurnOff();
	    }

	    private void turnOnButton_Click(object sender, EventArgs e) {
			MonitorController.TurnOn();
		}

        private void MonitorServiceForm_Load (object sender, EventArgs e) {
            MonitorNotifier.Start();
        }

        private void MonitorServiceForm_FormClosed (object sender, FormClosedEventArgs e) {
            MonitorNotifier.Stop();
        }
	}
}
