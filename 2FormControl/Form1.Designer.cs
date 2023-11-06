namespace _2FormControl
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
            btnDynamic = new Button();
            btnForm = new Button();
            btnFormShow = new Button();
            SuspendLayout();
            // 
            // btnDynamic
            // 
            btnDynamic.Location = new Point(61, 291);
            btnDynamic.Name = "btnDynamic";
            btnDynamic.Size = new Size(220, 60);
            btnDynamic.TabIndex = 0;
            btnDynamic.Text = "버튼 생성";
            btnDynamic.UseVisualStyleBackColor = true;
            btnDynamic.Click += btnDynamic_Click;
            // 
            // btnForm
            // 
            btnForm.Location = new Point(305, 291);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(220, 60);
            btnForm.TabIndex = 0;
            btnForm.Text = "폼 흔들기";
            btnForm.UseVisualStyleBackColor = true;
            btnForm.Click += btnForm_Click;
            // 
            // btnFormShow
            // 
            btnFormShow.Location = new Point(548, 291);
            btnFormShow.Name = "btnFormShow";
            btnFormShow.Size = new Size(220, 60);
            btnFormShow.TabIndex = 0;
            btnFormShow.Text = "폼 보이기";
            btnFormShow.UseVisualStyleBackColor = true;
            btnFormShow.Click += btnFormShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFormShow);
            Controls.Add(btnForm);
            Controls.Add(btnDynamic);
            Name = "Form1";
            Text = "폼 제어";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDynamic;
        private Button btnForm;
        private Button btnFormShow;
    }
}