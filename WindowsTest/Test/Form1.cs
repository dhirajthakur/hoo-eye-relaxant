using System;
using System.Threading;
using System.Windows.Forms;


namespace Hoo.Relaxant {
    public partial class Form1 : Form {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1() {
            InitializeComponent();
        }

       

        public override bool PreProcessMessage(ref Message msg) {
            log.Info(msg);
            return base.PreProcessMessage(ref msg);
        }

        protected override void WndProc(ref Message m) {
            log.Info(m);
            base.WndProc(ref m);
        }



        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            log.Info("***********Start turn off");
            DisplayController.TurnOff();
            log.Info("***********End turn off");
            Thread.Sleep(2000);
            log.Info("***********Start turn on");
            DisplayController.TurnOn();
            log.Info("***********End turn on");

        }
    }
}
