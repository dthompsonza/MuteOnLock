
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

        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private static IntPtr Handle
        {
            get
            {
                Process currentProcess = Process.GetCurrentProcess();
                IntPtr handle = currentProcess.MainWindowHandle;
                return handle;
            }
        }

        public static void ToggleMute() //IntPtr xhandle)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        public static void UnMute()
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        public static void Mute()
        {
            UnMute();
            ToggleMute();
        }

    }
}
