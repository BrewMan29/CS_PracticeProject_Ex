using System.Reflection.PortableExecutable;

namespace WinControl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                this.lblResult.Text = "�α��� ����";
            }

        }

        private bool CheckData()
        {
            if (this.txtId.Text == "")
            {
                MessageBox.Show("�α��� ���̵� �Է��ϼ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtId.Focus();
                return false;
            }
            else if (this.txtPwd.Text == "")
            {
                MessageBox.Show("�α��� ��й�ȣ�� �Է��ϼ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPwd.Focus();
                return false;
            }
            else
            {
                if (this.txtId.Text == "test")
                {
                    if (this.txtPwd.Text == "1234")
                    {
                        return true;
                    }
                    else
                    {
                        this.lblResult.Text = "��ġ�ϴ� ��й�ȣ�� �����ϴ�.";
                        this.lblPwd.Focus();
                        return false;
                    }
                }
                else
                {
                    this.lblResult.Text = "��ġ�ϴ� ���̵� �����ϴ�.";
                    this.lblId.Focus();
                    return false;
                }
            }
            //throw new NotImplementedException();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckData() == true)
                {
                    this.lblResult.Text = "�α��� ����";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}