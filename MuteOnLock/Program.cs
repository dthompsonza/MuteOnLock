using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Form launchForm = new frmMain();
            Application.Run(launchForm);
        }

        //static void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e, SoundMuter sm)
        //{
        //    Debug.Print($"{DateTime.Now.ToLongTimeString()} Event: {e.Reason.ToString()}");

        //    try
        //    {
        //        switch (e.Reason)
        //        {
        //            case SessionSwitchReason.SessionLogon:
        //            case SessionSwitchReason.SessionUnlock:
        //                soundMuter.UnMute();
        //                break;

        //            case SessionSwitchReason.SessionLock:
        //                soundMuter.Mute();
        //                break;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Print($"Exception in '{nameof(SystemEvents_SessionSwitch)}' - {ex.Message}");
        //    }
            
        //}
    }
}
