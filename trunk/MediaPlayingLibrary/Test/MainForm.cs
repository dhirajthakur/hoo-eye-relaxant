/*
 * Created by SharpDevelop.
 * User: jzxv5m
 * Date: 2008-1-7
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Org.Mentalis.Multimedia;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Runtime.InteropServices;



namespace Voice_Test {
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form {




        //[DllImport("user32.dll", SetLastError = true)]
        //static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        //[DllImport("user32.dll")]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg,
        //              IntPtr wParam, IntPtr lParam);

        //[DllImport("user32.dll")]
        //private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.Dll")]
        public static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        public const int PBM_SETBKCOLOR = 0x2001;
        public const int PBM_SETBARCOLOR = 0x409;


        public MainForm() {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        public void SetProgressBackColor(Color c) {/// set the back color of the bar
            int a = Convert.ToInt32(c.R.ToString());
            int b = Convert.ToInt32(c.G.ToString());
            int d = Convert.ToInt32(c.B.ToString());
            int tot = Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(a, b, d)).ToString());
            int j = progressBar1.Handle.ToInt32();
            SendMessage(j, PBM_SETBKCOLOR, 0, tot);
        }

        public void SetProgressForeColor(Color c) {/// set the forecolor of the bar
            int a = Convert.ToInt32(c.R.ToString());
            int b = Convert.ToInt32(c.G.ToString());
            int d = Convert.ToInt32(c.B.ToString());
            int tot = Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(a, b, d)).ToString());
            int j = this.progressBar1.Handle.ToInt32();
            SendMessage(j, PBM_SETBARCOLOR, 0, c.ToArgb());
        }



        void Button1Click(object sender, EventArgs e) {

            //IntPtr hwndChild = FindWindowEx(hwnd, IntPtr.Zero, "ProgressBar", "progressBar1");

            SetProgressBackColor(Color.Red);
            SetProgressForeColor(System.Drawing.Color.Red);

            //this.Refresh();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"resources\Benchmark.wav";
            player.PlayLooping();
            System.Threading.Thread.Sleep(3000);
            player.Stop();

        }

        void Button2Click(object sender, EventArgs e) {
            System.Media.SystemSounds.Asterisk.Play();
            System.Threading.Thread.Sleep(1000);
            System.Media.SystemSounds.Asterisk.Play();
            System.Threading.Thread.Sleep(1000);
            System.Media.SystemSounds.Asterisk.Play();
        }

        void Button3Click(object sender, EventArgs e) {
            MediaFile mediaFile = new SoundFile("resources\\track.wma");

            mediaFile.Play();
            System.Threading.Thread.Sleep(3000);
            mediaFile.Stop();



        }

        private void MainForm_Load(object sender, EventArgs e) {
            SetProgressBackColor(Color.Red);
            SetProgressForeColor(System.Drawing.Color.Red);
        }

        private void button4_Click(object sender, EventArgs e) {
            
            Audio music = new Audio("resources\\track.wma", true);

            music.Play();
            System.Threading.Thread.Sleep(5000);
            music.Stop();



        }





    }
}
