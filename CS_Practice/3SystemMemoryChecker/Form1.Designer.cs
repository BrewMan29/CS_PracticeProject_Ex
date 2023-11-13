namespace _3SystemMemoryChecker
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
            progressBar1 = new ProgressBar();
            plBar = new Panel();
            lvView = new ListView();
            statusStrip1 = new StatusStrip();
            tsslProcess = new ToolStripStatusLabel();
            tsslP = new ToolStripStatusLabel();
            Name = new ColumnHeader();
            Col1 = new ColumnHeader();
            Col2 = new ColumnHeader();
            Col3 = new ColumnHeader();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(42, 247);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(658, 48);
            progressBar1.TabIndex = 0;
            // 
            // plBar
            // 
            plBar.Location = new Point(41, 187);
            plBar.Name = "plBar";
            plBar.Size = new Size(659, 54);
            plBar.TabIndex = 1;
            plBar.Paint += plBar_Paint;
            // 
            // lvView
            // 
            lvView.Columns.AddRange(new ColumnHeader[] { Name, Col1, Col2, Col3 });
            lvView.Location = new Point(55, 30);
            lvView.Name = "lvView";
            lvView.Size = new Size(733, 146);
            lvView.TabIndex = 2;
            lvView.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslProcess, tsslP });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            tsslProcess.Name = "tsslProcess";
            tsslProcess.Size = new Size(0, 25);
            // 
            // tsslP
            // 
            tsslP.Name = "tsslP";
            tsslP.Size = new Size(110, 25);
            tsslP.Text = "--------------";
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Col1
            // 
            //Col1.Text = "ColumnHeader";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(lvView);
            Controls.Add(plBar);
            Controls.Add(progressBar1);
            //Name = "Form1";
            Text = "TTTT";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Panel plBar;
        private ListView lvView;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslProcess;
        private ToolStripStatusLabel tsslP;
        private ColumnHeader Name;
        private ColumnHeader Col1;
        private ColumnHeader Col2;
        private ColumnHeader Col3;
    }
}