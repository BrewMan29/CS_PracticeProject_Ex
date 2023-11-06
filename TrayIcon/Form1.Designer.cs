namespace TrayIcon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nyiTray = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            mOpen = new ToolStripMenuItem();
            menuOpen1 = new ToolStripMenuItem();
            menuClose1 = new ToolStripMenuItem();
            mExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nyiTray
            // 
            nyiTray.BalloonTipIcon = ToolTipIcon.Info;
            nyiTray.BalloonTipText = "TrayIcon";
            nyiTray.Icon = (Icon)resources.GetObject("nyiTray.Icon");
            nyiTray.Text = "notifyIcon1";
            nyiTray.Visible = true;
            nyiTray.MouseDoubleClick += nyiTray_MouseDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mOpen, mExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mOpen
            // 
            mOpen.DropDownItems.AddRange(new ToolStripItem[] { menuOpen1, menuClose1 });
            mOpen.Name = "mOpen";
            mOpen.Size = new Size(75, 29);
            mOpen.Text = "Menu";
            // 
            // menuOpen1
            // 
            menuOpen1.Name = "menuOpen1";
            menuOpen1.Size = new Size(270, 34);
            menuOpen1.Text = "Open";
            menuOpen1.Click += menuOpen1_Click;
            // 
            // menuClose1
            // 
            menuClose1.Name = "menuClose1";
            menuClose1.Size = new Size(270, 34);
            menuClose1.Text = "종료";
            menuClose1.Click += menuClose1_Click;
            // 
            // mExit
            // 
            mExit.Name = "mExit";
            mExit.Size = new Size(55, 29);
            mExit.Text = "Exit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "트레이아이콘";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            VisibleChanged += Form1_VisibleChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon nyiTray;
        private ContextMenuStrip cmsPopup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mOpen;
        private ToolStripMenuItem mExit;
        private ToolStripMenuItem menuOpen1;
        private ToolStripMenuItem menuClose1;
    }
}