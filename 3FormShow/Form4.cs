using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _3FormShow
{
    public partial class Form4 : Form
    {
        private static System.Timers.Timer? TimerEvent; //Timer 개체 생성
        private int nHeight = 0;
        public Form4()
        {
            // 스크린의 가로 위치
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            // 스크린의 세로위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            //DesktopLocation = new Point(x, y); // 폼의 위치 결정
            //DesktopLocation = new Point(100, 100); // 폼의 위치 결정

            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 종료
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            // 마우스 누름 이미지 설정
            //this.picClose.Image = Image.FromFile(@"..\..\img\Close_Down.jpg");
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            // 마우스 떠남 이미지 설정
            //this.picClose.Image = Image.FromFile(@"..\..\img\Close_Normal.jpg");

        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 오버 이미지 설정
            //this.picClose.Image = Image.FromFile(@"..\..\img\Close_Over.jpg");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var fullScreen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point((int)fullScreen.Width - 300, (int)fullScreen.Height - 500);
            nHeight = Height;
            this.Text = nHeight.ToString();
            TimerEvent = new System.Timers.Timer(20);
            //TimerEvent.Elapsed += new ElapsedEventHandler(OnPopup);
            TimerEvent.Elapsed += OnPopup;
            TimerEvent.Start();
        }

        private void OnPopup(object sender, ElapsedEventArgs e)
        {
            if (/*this.Height*/ nHeight < 400)
            {
                ++nHeight;
                Size += new Size(0, 1);
                Location = new Point(this.Location.X, this.Location.Y - 1);

                this.Text = nHeight.ToString();
            }
            else
            {
                TimerEvent.Stop();
                //TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopup);
                TimerEvent.Elapsed -= OnPopup;
                //TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimerEvent.Elapsed += OnPopOut;
                TimerEvent.Interval = 100;
                TimerEvent.Start();
            }
        }

        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
            while (this.Height > 2)
            {
                nHeight--;
                Size = new Size(this.Width, nHeight);
                Location = new Point(this.Location.X, this.Location.Y + 1);

                this.Text = nHeight.ToString();
            }
            //TimerEvent.Stop();
            this.Close();
        }
    }
}
