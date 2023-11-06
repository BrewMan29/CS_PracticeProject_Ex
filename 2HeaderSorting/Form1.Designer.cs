namespace _2HeaderSorting
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
            lvCall = new ListView();
            lbName = new Label();
            lbPhone = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            chName = new ColumnHeader();
            chPhone = new ColumnHeader();
            SuspendLayout();
            // 
            // lvCall
            // 
            lvCall.Columns.AddRange(new ColumnHeader[] { chName, chPhone });
            lvCall.GridLines = true;
            lvCall.Location = new Point(34, 27);
            lvCall.Name = "lvCall";
            lvCall.Size = new Size(613, 214);
            lvCall.TabIndex = 0;
            lvCall.UseCompatibleStateImageBehavior = false;
            lvCall.View = View.Details;
            lvCall.ColumnClick += lvCall_ColumnClick;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(34, 268);
            lbName.Name = "lbName";
            lbName.Size = new Size(48, 25);
            lbName.TabIndex = 1;
            lbName.Text = "이름";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(34, 334);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(84, 25);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "전화번호";
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 263);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(174, 328);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(614, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "입력";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 120;
            // 
            // chPhone
            // 
            chPhone.Text = "전화번호";
            chPhone.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lbPhone);
            Controls.Add(lbName);
            Controls.Add(lvCall);
            Name = "Form1";
            Text = "헤더 정렬";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvCall;
        private Label lbName;
        private Label lbPhone;
        private ColumnHeader chName;
        private ColumnHeader chPhone;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnSave;
    }
}