namespace WinControl1
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
            lblId = new Label();
            lblPwd = new Label();
            lblResult = new Label();
            txtId = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(69, 97);
            lblId.Name = "lblId";
            lblId.Size = new Size(76, 25);
            lblId.TabIndex = 0;
            lblId.Text = "아이디 :";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(69, 142);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(94, 25);
            lblPwd.TabIndex = 0;
            lblPwd.Text = "비밀번호 :";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(69, 362);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 0;
            lblResult.Text = "결과 :";
            // 
            // txtId
            // 
            txtId.Location = new Point(225, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(240, 31);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(225, 139);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(240, 31);
            txtPwd.TabIndex = 1;
            txtPwd.KeyDown += txtPwd_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(348, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 54);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(518, 362);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 54);
            btnClose.TabIndex = 2;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtId);
            Controls.Add(lblResult);
            Controls.Add(lblPwd);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "인로그";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblPwd;
        private Label lblResult;
        private TextBox txtId;
        private TextBox txtPwd;
        private Button btnLogin;
        private Button btnClose;
    }
}