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
            frm2.SetText = ("��� �� ǥ��");
            frm2.ShowDialog(); // ��� �ɼ����� �� ����

        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.SetText = (this.btnModaless.Text + " ����");
            frm3.Show(); //��޸��� �ɼ����� �� ����
        }

        private void btnMsr_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            //frm4.ShowDialog();
            frm4.Show();

        }
    }
}