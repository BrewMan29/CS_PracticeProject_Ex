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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "", "", "", "" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("");
            lvView = new ListView();
            Col0 = new ColumnHeader();
            Col1 = new ColumnHeader();
            Col2 = new ColumnHeader();
            Col3 = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            tsslProcess = new ToolStripStatusLabel();
            plBar = new Panel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvView
            // 
            lvView.BorderStyle = BorderStyle.FixedSingle;
            lvView.Columns.AddRange(new ColumnHeader[] { Col0, Col1, Col2, Col3 });
            lvView.GridLines = true;
            lvView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.ToolTipText = "asdfafasf";
            lvView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvView.LabelEdit = true;
            lvView.Location = new Point(12, 30);
            lvView.MultiSelect = false;
            lvView.Name = "lvView";
            lvView.ShowGroups = false;
            lvView.Size = new Size(776, 291);
            lvView.TabIndex = 2;
            lvView.UseCompatibleStateImageBehavior = false;
            lvView.View = View.Details;
            // 
            // Col0
            // 
            Col0.Text = "Name";
            Col0.Width = 200;
            // 
            // Col1
            // 
            Col1.Text = "ID";
            Col1.Width = 100;
            // 
            // Col2
            // 
            Col2.Text = "Time";
            Col2.Width = 100;
            // 
            // Col3
            // 
            Col3.Tag = "ColCol3";
            Col3.Text = "Proc";
            Col3.Width = 100;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslProcess });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            tsslProcess.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsslProcess.Name = "tsslProcess";
            tsslProcess.Size = new Size(183, 25);
            tsslProcess.Text = "toolStripStatusLabel1";
            // 
            // plBar
            // 
            plBar.Location = new Point(19, 375);
            plBar.Name = "plBar";
            plBar.Size = new Size(769, 40);
            plBar.TabIndex = 6;
            plBar.Paint += plBar_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(plBar);
            Controls.Add(statusStrip1);
            Controls.Add(lvView);
            Name = "Form1";
            Text = "TTTT";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lvView;
        private ColumnHeader Col0;
        private ColumnHeader Col1;
        private ColumnHeader Col2;
        private ColumnHeader Col3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslProcess;
        private Panel plBar;
    }
}