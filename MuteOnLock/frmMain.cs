using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MuteOnLock
{
    public partial class frmMain : Form
    {
        private bool startupCompleted = false;
        private SoundMuter soundMuter = new SoundMuter();

        public frmMain()
        {
            InitializeComponent();
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            startupCompleted = true;
            SetIconVisible(true);
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            soundMuter.UnMute();
        }

        private void btnToggleMute_Click(object sender, EventArgs e)
        {
            soundMuter.ToggleMute();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (!startupCompleted)
                return;

            if (FormWindowState.Minimized == this.WindowState)
            {
                SetIconVisible(true);
                appNotifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                SetIconVisible(false);
            }
        }

        private void appNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void SetIconVisible(bool isVisible)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate {
                    appNotifyIcon.Visible = isVisible;
                });
            }
            else {
                appNotifyIcon.Visible = isVisible;
            }
        }

        private void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            Debug.Print($"{DateTime.Now.ToLongTimeString()} Event: {e.Reason.ToString()}");

            try
            {
                switch (e.Reason)
                {
                    case SessionSwitchReason.SessionLogon:
                    case SessionSwitchReason.SessionUnlock:
                        soundMuter.UnMute();
                        break;

                    case SessionSwitchReason.SessionLock:
                        soundMuter.Mute();
                        break;

                }
            }
            catch (Exception ex)
            {
                Debug.Print($"Exception in '{nameof(SystemEvents_SessionSwitch)}' - {ex.Message}");
            }

        }
    }
}
