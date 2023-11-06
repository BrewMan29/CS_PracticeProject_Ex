namespace _2FormControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                DynamicButton(i * 100, 10, i + 1);
            }
        }

        private void DynamicButton(int x, int y, int k)
        {
            Button btnPer = new Button();
            string btnText = "¹öÆ°" + k.ToString();
            if (k == 3)
            {
                btnText = "Èçµé";
            }
            btnPer.Width = 100;
            btnPer.Height = 50;
            btnPer.Location = new System.Drawing.Point(x + 15, y);
            btnPer.Text = btnText;
            btnPer.Name = "btn" + k.ToString();
            btnPer.Click += new EventHandler(btn_Click);
            Controls.Add(btnPer);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string btnText = sender.ToString().Split(':')[1].ToString().Trim();
            if (btnText == "Èçµé")
            {
                FormShork();
            }
            else
            {
                MessageBox.Show(btnText, "¾Ë¸²", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormShork()
        {
            double x = this.Location.X;
            double y = this.Location.Y;

            for (double i = 10; i > 0; i -= 0.01)
            {
                this.Location = new Point((int)(x - i), (int)y);
                this.Location = new Point((int)(x + i), (int)y);
            }
            //throw new NotImplementedException();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            FormShork();
        }

        private void btnFormShow_Click(object sender, EventArgs e)
        {
            for(int i= 10; i > 0; i --)
            {
                this.Opacity = 0.1 * i;
                System.Threading.Thread.Sleep(100);
            }
            for (int i =0; i <= 10; i++){
                this.Opacity = 0.1 * i;
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}