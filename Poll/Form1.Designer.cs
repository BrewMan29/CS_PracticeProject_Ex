namespace Poll
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
            plQuestion = new Panel();
            btnPoll = new Button();
            gbSports = new GroupBox();
            chb02 = new CheckBox();
            chb01 = new CheckBox();
            gbHobby = new GroupBox();
            rbtn02 = new RadioButton();
            rbtn01 = new RadioButton();
            lbHobby = new Label();
            lbSports = new Label();
            plQuestion.SuspendLayout();
            gbSports.SuspendLayout();
            gbHobby.SuspendLayout();
            SuspendLayout();
            // 
            // plQuestion
            // 
            plQuestion.BackColor = Color.White;
            plQuestion.Controls.Add(btnPoll);
            plQuestion.Controls.Add(gbSports);
            plQuestion.Controls.Add(gbHobby);
            plQuestion.Location = new Point(34, 24);
            plQuestion.Name = "plQuestion";
            plQuestion.Size = new Size(662, 415);
            plQuestion.TabIndex = 0;
            // 
            // btnPoll
            // 
            btnPoll.Location = new Point(476, 325);
            btnPoll.Name = "btnPoll";
            btnPoll.Size = new Size(112, 34);
            btnPoll.TabIndex = 2;
            btnPoll.Text = "제출하기";
            btnPoll.UseVisualStyleBackColor = true;
            btnPoll.Click += btnPoll_Click;
            // 
            // gbSports
            // 
            gbSports.Controls.Add(chb02);
            gbSports.Controls.Add(chb01);
            gbSports.Location = new Point(34, 147);
            gbSports.Name = "gbSports";
            gbSports.Size = new Size(516, 99);
            gbSports.TabIndex = 1;
            gbSports.TabStop = false;
            gbSports.Text = "좋아하는 스포츠 ?";
            // 
            // chb02
            // 
            chb02.AutoSize = true;
            chb02.Location = new Point(193, 47);
            chb02.Name = "chb02";
            chb02.Size = new Size(74, 29);
            chb02.TabIndex = 0;
            chb02.Text = "농구";
            chb02.UseVisualStyleBackColor = true;
            // 
            // chb01
            // 
            chb01.AutoSize = true;
            chb01.Location = new Point(38, 47);
            chb01.Name = "chb01";
            chb01.Size = new Size(74, 29);
            chb01.TabIndex = 0;
            chb01.Text = "축구";
            chb01.UseVisualStyleBackColor = true;
            // 
            // gbHobby
            // 
            gbHobby.Controls.Add(rbtn02);
            gbHobby.Controls.Add(rbtn01);
            gbHobby.Location = new Point(34, 27);
            gbHobby.Name = "gbHobby";
            gbHobby.Size = new Size(516, 89);
            gbHobby.TabIndex = 0;
            gbHobby.TabStop = false;
            gbHobby.Text = "취미는 ?";
            // 
            // rbtn02
            // 
            rbtn02.AutoSize = true;
            rbtn02.Location = new Point(216, 38);
            rbtn02.Name = "rbtn02";
            rbtn02.Size = new Size(109, 29);
            rbtn02.TabIndex = 0;
            rbtn02.TabStop = true;
            rbtn02.Text = "영화보기";
            rbtn02.UseVisualStyleBackColor = true;
            // 
            // rbtn01
            // 
            rbtn01.AutoSize = true;
            rbtn01.Location = new Point(38, 38);
            rbtn01.Name = "rbtn01";
            rbtn01.Size = new Size(109, 29);
            rbtn01.TabIndex = 0;
            rbtn01.TabStop = true;
            rbtn01.Text = "독서하기";
            rbtn01.UseVisualStyleBackColor = true;
            // 
            // lbHobby
            // 
            lbHobby.AutoSize = true;
            lbHobby.Location = new Point(58, 474);
            lbHobby.Name = "lbHobby";
            lbHobby.Size = new Size(76, 25);
            lbHobby.TabIndex = 1;
            lbHobby.Text = "취미는 :";
            // 
            // lbSports
            // 
            lbSports.AutoSize = true;
            lbSports.Location = new Point(58, 537);
            lbSports.Name = "lbSports";
            lbSports.Size = new Size(94, 25);
            lbSports.TabIndex = 1;
            lbSports.Text = "스포츠는 :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 635);
            Controls.Add(lbSports);
            Controls.Add(lbHobby);
            Controls.Add(plQuestion);
            MaximizeBox = false;
            Name = "Form1";
            Text = "설문조사";
            plQuestion.ResumeLayout(false);
            gbSports.ResumeLayout(false);
            gbSports.PerformLayout();
            gbHobby.ResumeLayout(false);
            gbHobby.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plQuestion;
        private GroupBox gbSports;
        private GroupBox gbHobby;
        private Label lbHobby;
        private Button btnPoll;
        private CheckBox chb02;
        private CheckBox chb01;
        private RadioButton rbtn02;
        private RadioButton rbtn01;
        private Label lbSports;
    }
}