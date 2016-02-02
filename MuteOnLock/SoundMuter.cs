
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuteOnLock
{
    public static class SoundMuter
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        public static void MuteUnmute() //IntPtr xhandle)
        {
            Process currentProcess = Process.GetCurrentProcess();
            IntPtr handle = currentProcess.MainWindowHandle;

            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

    }
}
