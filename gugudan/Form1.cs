namespace gugudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResult.Items.Clear();

            var s = this.cbbSelect.SelectedItem.ToString();
            String token = " ";
            var gustr = s.Split(token);

            this.lbResult.Items.Add(gustr[0] + "단 실행 결과");
            this.lbResult.Items.Add("");
            this.lbResult.Items.Add("");

            for(var i = 1; i < 10;  i++)
            {
                this.lbResult.Items.Add(gustr[0] + "*" + i.ToString() + 
                    "=" + (Convert.ToInt32(gustr[0]) * i).ToString());
            }
        }
    }
}