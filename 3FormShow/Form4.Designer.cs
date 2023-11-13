namespace _3FormShow
{
    partial class Form4
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
            plBack = new Panel();
            picClose = new PictureBox();
            plBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // plBack
            // 
            plBack.BackColor = Color.LightBlue;
            plBack.Controls.Add(picClose);
            plBack.Location = new Point(18, 21);
            plBack.Name = "plBack";
            plBack.Size = new Size(170, 150);
            plBack.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Cyan;
            picClose.Location = new Point(10, 22);
            picClose.Name = "picClose";
            picClose.Size = new Size(150, 75);
            picClose.TabIndex = 0;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            picClose.MouseDown += picClose_MouseDown;
            picClose.MouseLeave += picClose_MouseLeave;
            picClose.MouseMove += picClose_MouseMove;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(200, 300);
            Controls.Add(plBack);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form4";
            Load += Form4_Load;
            plBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plBack;
        private PictureBox picClose;
    }
}