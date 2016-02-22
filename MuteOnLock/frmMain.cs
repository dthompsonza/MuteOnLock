using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MuteOnLock
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            SoundMuter.UnMute();
        }

        private void btnToggleMute_Click(object sender, EventArgs e)
        {
            SoundMuter.ToggleMute();
        }
    }
}
