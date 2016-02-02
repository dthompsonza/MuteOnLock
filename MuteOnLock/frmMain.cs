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

        private void btnMute_Click(object sender, EventArgs e)
        {

            SoundMuter.MuteUnmute(); 

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
