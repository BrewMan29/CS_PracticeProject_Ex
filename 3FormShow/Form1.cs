namespace _3FormShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.SetText = ("모달 폼 표시");
            frm2.ShowDialog(); // 모달 옵션으로 폼 실행

        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.SetText = (this.btnModaless.Text + " 실행");
            frm3.Show(); //모달리스 옵션으로 폼 실행
        }

        private void btnMsr_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            //frm4.ShowDialog();
            frm4.Show();

        }
    }
}