namespace _3FormShow
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
            btnModal = new Button();
            btnModaless = new Button();
            btnMsr = new Button();
            SuspendLayout();
            // 
            // btnModal
            // 
            btnModal.Location = new Point(60, 76);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(112, 34);
            btnModal.TabIndex = 0;
            btnModal.Text = "모달 폼";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(239, 76);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(112, 34);
            btnModaless.TabIndex = 0;
            btnModaless.Text = "모달리스 폼";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnMsr
            // 
            btnMsr.Location = new Point(405, 76);
            btnMsr.Name = "btnMsr";
            btnMsr.Size = new Size(225, 34);
            btnMsr.TabIndex = 0;
            btnMsr.Text = "메신저 알림 폼";
            btnMsr.UseVisualStyleBackColor = true;
            btnMsr.Click += btnMsr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 213);
            Controls.Add(btnMsr);
            Controls.Add(btnModaless);
            Controls.Add(btnModal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "부모";
            ResumeLayout(false);
        }

        #endregion

        private Button btnModal;
        private Button btnModaless;
        private Button btnMsr;
    }
}