using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Hoo.InputDevice;

namespace Hoo.InputDevice.Test {
    public partial class TraceForm : Form {
        private MouseHook _mouseHook = null;
        private KeyboardHook _keyboardHook = null;

        public TraceForm() {
            InitializeComponent();

            _mouseHook = new MouseHook();
            _keyboardHook = new KeyboardHook();

            _mouseHook.OnMouseActivity += new MouseEventHandler(hook_MainMouseMove);
            _keyboardHook.OnKeyDown += new KeyEventHandler(hook_MainKeyDown);
            _keyboardHook.OnKeyPress += new KeyPressEventHandler(hook_MainKeyPress);
            _keyboardHook.OnKeyUp += new KeyEventHandler(hook_MainKeyUp);
        }

  

        private void HookMain_OnKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape && Control.ModifierKeys == Keys.Shift) {
                this.Close();
            }
        }

        private void start_Click(object sender, EventArgs e) {
            _mouseHook.InstallHook();
            _keyboardHook.InstallHook();
        }

        private void stop_Click(object sender, EventArgs e) {
            _mouseHook.UnInstallHook();
            _keyboardHook.UnInstallHook();
        }

        private void stopkeyboard_Click(object sender, EventArgs e) {
            _mouseHook.InstallHook();
            _mouseHook.DisableDevice = true;
            _keyboardHook.InstallHook();
            _keyboardHook.DisableDevice = true;
            _keyboardHook.ExceptKeys.Add(Keys.F12);
            _keyboardHook.ExceptKeys.Add(Keys.Enter);
            _keyboardHook.ExceptKeys.Add(Keys.Tab);
            _keyboardHook.ExceptKeys.Add(Keys.Alt);
            
        }

        private void LogWrite(string txt) {

            this.resultinfo.AppendText(txt + Environment.NewLine);
            this.resultinfo.SelectionStart = this.resultinfo.Text.Length;
        }

        private void hook_MainKeyDown(object sender, KeyEventArgs e) {
            LogWrite("KeyDown 	- " + e.KeyData.ToString());
        }

        private void hook_MainKeyPress(object sender, KeyPressEventArgs e) {
            LogWrite("KeyPress 	- " + e.KeyChar);
        }

        private void hook_MainKeyUp(object sender, KeyEventArgs e) {
            LogWrite("KeyUp 		- " + e.KeyData.ToString());
            if (e.KeyCode.Equals(Keys.F12)) {
                _mouseHook.UnInstallHook();
                _keyboardHook.UnInstallHook();
            }
        }

        private void hook_MainMouseMove(object sender, MouseEventArgs e) {
            labelMousePosition.Text = String.Format("x={0}  y={1} wheel={2}", e.X, e.Y, e.Delta);
            if (e.Clicks > 0) LogWrite("MouseButton 	- " + e.Button.ToString());
        }

        private void TraceForm_FormClosing(object sender, FormClosingEventArgs e) {
            _mouseHook.UnInstallHook();
            _keyboardHook.UnInstallHook();
        }

        private void TraceForm_KeyUp(object sender, KeyEventArgs e) {
          
        }


    }
}