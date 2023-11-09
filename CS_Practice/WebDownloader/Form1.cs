using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace WebDownloader
{
    public partial class Form1 : Form
    {


        Boolean isBusy;     //progressbar 상태를 나타냄
        private string filePath = null; //파일 경로
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if(this.fbdFile.ShowDialog() == DialogResult.OK)
            {
                this.btnDown.Enabled = true;
                filePath = this.fbdFile.SelectedPath;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (isBusy)
            {
                webClient.CancelAsync();
                isBusy = false;
            }
            else
            {
                try
                {
                    var strFileName = this.txtUrl.Text.Split(new Char[] { '/' });
                    System.Array.Reverse(strFileName);
                    Uri uri = new Uri(this.txtUrl.Text);

                    //파일의 유효성 검사
                    var str = webClient.DownloadString(uri);
                    webClient.DownloadFileAsync(uri, filePath + @"\" + strFileName[0]);
                    isBusy = true;
                }
                catch
                {
                    this.btnDown.Enabled=false;
                    MessageBox.Show("다운로드에 실퍠하였습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void webClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            this.pgbDownload.Value = e.ProgressPercentage;

        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            isBusy = false;
            this.btnDown.Enabled = false;
            if(e.Error == null)
            {
                if(this.cbOpen.Checked == false)
                {
                    MessageBox.Show("다운로드가 완료되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Process myprocess = new Process();
                    myprocess.StartInfo.FileName = filePath;
                    myprocess.Start();
                }
            }
            else
            {
                MessageBox.Show("다운로드가 실패하였습니다. : " + e.Error.Message.ToString());
            }

        }
    }
}
