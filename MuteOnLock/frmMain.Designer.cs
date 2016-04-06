namespace MuteOnLock
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnUnmute = new System.Windows.Forms.Button();
            this.btnToggleMute = new System.Windows.Forms.Button();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnUnmute
            // 
            this.btnUnmute.Location = new System.Drawing.Point(142, 96);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(75, 23);
            this.btnUnmute.TabIndex = 1;
            this.btnUnmute.Text = "Unmute";
            this.btnUnmute.UseVisualStyleBackColor = true;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // btnToggleMute
            // 
            this.btnToggleMute.Location = new System.Drawing.Point(142, 125);
            this.btnToggleMute.Name = "btnToggleMute";
            this.btnToggleMute.Size = new System.Drawing.Size(75, 23);
            this.btnToggleMute.TabIndex = 2;
            this.btnToggleMute.Text = "Toggle";
            this.btnToggleMute.UseVisualStyleBackColor = true;
            this.btnToggleMute.Click += new System.EventHandler(this.btnToggleMute_Click);
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotifyIcon.BalloonTipText = "Mute on Lock is running from the system tray. Double-click to open the app.";
            this.appNotifyIcon.BalloonTipTitle = "Mute on Lock";
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "notifyIcon1";
            this.appNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appNotifyIcon_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnToggleMute);
            this.Controls.Add(this.btnUnmute);
            this.Name = "frmMain";
            this.Text = "MuteOnLock";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnmute;
        private System.Windows.Forms.Button btnToggleMute;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
    }
}

