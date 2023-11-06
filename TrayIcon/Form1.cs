namespace TrayIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }

        private void menuOpen1_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);

        }

        private void menuClose1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}