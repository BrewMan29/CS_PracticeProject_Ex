using System.Collections;

namespace _2HeaderSorting
{
    public partial class Form1 : Form
    {
        private bool Isort = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void lvCall_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(Isort == true) {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);
                Isort = false;
            }
            else
            {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);
                Isort = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlCheck() == true)
            {
                var strArray = new String[] { this.txtName.Text, this.txtPhone.Text };

                var lvt = new ListViewItem(strArray);
                this.lvCall.Items.Add(lvt);
                this.txtName.Clear();
                this.txtPhone.Clear();
            }
            else
            {
                return;
            }
        }

        private Boolean ControlCheck()
        {
            if(this.txtName.Text == "")
            {
                MessageBox.Show("�̸��� �Է��ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }else if(this.txtPhone.Text == "")
            {
                MessageBox.Show("��ȭ��ȣ�� �Է��ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPhone.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private bool z;
        public ListViewItemComparer(int column, bool v)
        {
            col = column;
            z = v; 
        }

        public int Compare(object x, object y)
        {
            object a, b;
            if(z == true)
            {
                a = x;
                b = y;
            }
            else
            {
                a=y; b=x;

            }
            return String.Compare(((ListViewItem)a).SubItems[col].Text,
                ((ListViewItem)b).SubItems[col].Text);
        }
    }
}