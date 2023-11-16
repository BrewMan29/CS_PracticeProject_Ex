using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace _3SystemMemoryChecker
{
    public partial class Form1 : Form
    {
        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //�ý��� ���� ī����
        private PerformanceCounter oMem = new PerformanceCounter("Memory", "% Committed Bytes In Use"); //�ý��� Mem ���� ī����
        private PerformanceCounter pCPU = new PerformanceCounter();

        private delegate void TotalUpdateDelegate(int m, int n); //��������Ʈ ����
        private TotalUpdateDelegate OnTotal = null;
        private delegate void UpdateDelegate();
        private UpdateDelegate OnUpdate = null;

        private bool bExit = false; // ���� ����
        private int iCPU = 0; // CPU �ʱ� ����
        private int iMemory = 0; // Memory �ʱ� ����
        private Font F = new Font("����", 9); //��Ʈ ���

        Thread checkThread = null; //�ý��� ���� ������
        private Thread ProcessThread; //���μ��� ������

        int cp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void getSystem_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                iMemory = (int)oMem.NextValue();
                //this.Text = "CPU ��뷮 : " + iCPU.ToString() + "%";
                Invoke(OnTotal, iCPU, iMemory);
                plBar.Invalidate();
                Thread.Sleep(1000);
            }
        }
        private void totalView(int m, int n)
        {
            this.Text = "ToTal  >> CPU : " + m.ToString() + ", Memory : " + n.ToString();
        }

        private string NumFormat(long num)
        {
            num = num / 1024;
            return String.Format("{0:N}", num) + "KB";
        }

        private void ProcessView()
        {
            try
            {
                this.lvView.Items.Clear();
                cp = 0;

                foreach (var proc in Process.GetProcesses())
                {
                    string[] str;
                    try
                    {
                        //str = proc.TotalProcessorTime.ToString().Split(new Char[] { '.' });
                        str = proc.TotalProcessorTime.ToString().Split(new Char[] { '.' });
                    }
                    catch (Exception ex)
                    {
                        str = new string[] { " ---- " };
                    }

                    var stringArray = new string[] {
                        proc.ProcessName.ToString(),
                        proc.Id.ToString(),
                        str[0],
                        NumFormat(proc.WorkingSet64)
                    };

                    var lvt = new ListViewItem(stringArray);
                    this.lvView.Items.Add(lvt);
                    cp++;
                }
            }
            catch (Exception ex)
            {

            }
            this.tsslProcess.Text = "Process " + cp.ToString() + " ��";
        }

        private void ProcessUpdate()
        {
            try
            {
                while (true)
                {
                    var oldList = new ArrayList();

                    foreach (var oldProc in Process.GetProcesses())
                    {
                        oldList.Add(oldProc.Id.ToString());
                    }
                    Thread.Sleep(1000);
                    var newList = Process.GetProcesses();

                    if (oldList.Count != newList.Length)
                    {
                        Invoke(OnUpdate);
                        continue;
                    }
                    int i = 0;
                    foreach (var rewProc in Process.GetProcesses())
                    {
                        if (oldList[i++].ToString() != rewProc.Id.ToString())
                        {
                            Invoke(OnUpdate);
                            break; ;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessView();
            OnUpdate = new UpdateDelegate(ProcessView);
            OnTotal = new TotalUpdateDelegate(totalView);
            checkThread = new Thread(getSystem_Info);
            checkThread.Start();

            ProcessThread = new Thread(ProcessUpdate);
            ProcessThread.Start();
        }

        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = Brushes.BlanchedAlmond;
            if (iCPU < 30)
            {
                g.FillRectangle(Brushes.BlanchedAlmond, 0, 0, plBar.Width * ( iCPU / 100), plBar.Height);
                br = Brushes.BlanchedAlmond;
            }
            else if (iCPU < 50)
            {
                br = Brushes.Wheat;
            }
            else if (iCPU < 70)
            {
                br = Brushes.NavajoWhite;
            }
            else if (iCPU < 80)
            {
                br = Brushes.Orange;
            }
            else
            {
                br = Brushes.DarkOrange;
            }
            g.FillRectangle(br, 0, 0, plBar.Width * (iCPU / 10), plBar.Height);
            g.DrawString(iCPU + "%", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bExit = true;
            if (!(checkThread == null))
            {
                checkThread.Abort(); // Check Thread ����
            }
            if (!(ProcessThread == null))
            {
                ProcessThread.Abort(); //
            }
        }


    }
}