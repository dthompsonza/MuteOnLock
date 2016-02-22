using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MuteOnLock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);

            Form launchForm = new frmMain();
            Application.Run(launchForm);
        }

        static void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLogon:
                case SessionSwitchReason.SessionUnlock:
                    SoundMuter.UnMute();
                    break;

                case SessionSwitchReason.SessionLock:
                    SoundMuter.Mute();
                    break;

            }
        }
    }
}
