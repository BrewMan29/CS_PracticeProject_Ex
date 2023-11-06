namespace gugudan
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
            label1 = new Label();
            cbbSelect = new ComboBox();
            lbResult = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 59);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "선택";
            // 
            // cbbSelect
            // 
            cbbSelect.FormattingEnabled = true;
            cbbSelect.Items.AddRange(new object[] { "2 단", "3 단", "4 단", "5 단", "6 단", "7 단", "8 단", "9 단" });
            cbbSelect.Location = new Point(133, 59);
            cbbSelect.Name = "cbbSelect";
            cbbSelect.Size = new Size(182, 33);
            cbbSelect.TabIndex = 1;
            cbbSelect.SelectedIndexChanged += cbbSelect_SelectedIndexChanged;
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.ItemHeight = 25;
            lbResult.Location = new Point(39, 124);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(421, 379);
            lbResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 582);
            Controls.Add(lbResult);
            Controls.Add(cbbSelect);
            Controls.Add(label1);
            Name = "Form1";
            Text = "구구단";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbSelect;
        private ListBox lbResult;
    }
}