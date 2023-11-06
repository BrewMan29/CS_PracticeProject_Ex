namespace Poll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPoll_Click(object sender, EventArgs e)
        {
            if (this.chb01.Checked != false || this.chb02.Checked != false)
            {
                foreach (RadioButton rb in this.gbHobby.Controls)
                {
                    if (rb.Checked == true)
                    {
                        this.lbHobby.Text = rb.Text;
                    }
                }
                this.lbSports.Text = "";
                foreach (CheckBox chb in this.gbSports.Controls)
                {
                    if (chb.Checked == true)
                    {
                        this.lbSports.Text = chb.Text;
                    }
                }
            }
        }
    }
}