﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FormSlidMag
{
    public partial class Form3 : Form
    {

        Point ptMouseCurrentPos; // 마우스 클릭 좌표 지정
        Point ptMouseNewPos; //이동시 마우스 좌표
        Point ptFormCurrentPos; // 폼위치 좌표 지정
        Point ptFormNewPos; //이동 시 폼 위치 좌표
        bool bFormMouseDown = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                bFormMouseDown = true;
                ptMouseCurrentPos = Control.MousePosition; // 마우스 클릭 좌표
                ptFormCurrentPos = this.Location;
            }

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if(bFormMouseDown == true)
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X; // 마우스 이동 시 가로좌표
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y; // 마우스 이동 시 세로좌표

                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }

        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                bFormMouseDown = false;
                if (this.Location.X <= Form1.FormPt.X + 60 && this.Location.X >= Form1.FormPt.X - 60)
                {
                    if (this.Location.Y <= Form1.FormPt.Y + 450 && this.Location.Y >= Form1.FormPt.Y + 200)
                    {
                        this.Location = new Point(Form1.FormPt.X, Form1.FormPt.Y + 310);
                        Form1.flag03 = true;
                    }
                    else
                    {
                        Form1.flag03 = false;
                    }
                } else {
                    Form1.flag03 = false;
                }

            }
        }
    }
}
