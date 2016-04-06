
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MuteOnLock
{
    public class SoundMuter
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;

        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private IntPtr _handle = new IntPtr();

        private IntPtr Handle
        {
            get
            {
                if (_handle.ToInt64() == 0)
                {
                    Process currentProcess = Process.GetCurrentProcess();
                    _handle = currentProcess.MainWindowHandle;
                }
                return _handle;
            }
        }

        public void ToggleMute() //IntPtr xhandle)
        {
            Debug.Print($"Firing {nameof(ToggleMute)} with handle {Handle.ToInt64()}");
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        public void UnMute()
        {
            Debug.Print($"Firing {nameof(UnMute)} with handle {Handle.ToInt64()}");
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        public void Mute()
        {
            UnMute();
            ToggleMute();
        }

        public bool IsMuted()
        {
            return false;
            //SoundLevel soundlevel;
        }

    }
}
