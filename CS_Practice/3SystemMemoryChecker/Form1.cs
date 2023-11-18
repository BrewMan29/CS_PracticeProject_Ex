using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace _3SystemMemoryChecker
{
    public partial class Form1 : Form
    {
        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //시스템 성능 카운터
        private PerformanceCounter oMem = new PerformanceCounter("Memory", "% Committed Bytes In Use"); //시스템 Mem 성능 카운터
        private PerformanceCounter pCPU = new PerformanceCounter();

        private delegate void TotalUpdateDelegate(int m, int n); //델리게이트 생성
        private TotalUpdateDelegate OnTotal = null;
        private delegate void UpdateDelegate();
        private UpdateDelegate OnUpdate = null;

        private bool bExit = false; // 종료 여부
        private int iCPU = 0; // CPU 초기 사용률
        private int iMemory = 0; // Memory 초기 사용률
        private Font F = new Font("굴림", 9); //폰트 모양

        Thread checkThread = null; //시스템 정보 쓰레드
        private Thread ProcessThread; //프로세스 쓰레드

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
                //this.Text = "CPU 사용량 : " + iCPU.ToString() + "%";
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
            this.tsslProcess.Text = "Process " + cp.ToString() + " 개";
        }

        private void ProcessUpdate()
        {
            try
            {
                while (!bExit)
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
                br = Brushes.MintCream;
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
            g.FillRectangle(br, 0, 0, plBar.Width * iCPU / 100, plBar.Height);
            g.DrawString(iCPU + "%", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bExit = true;
            if (!(checkThread == null))
            {
                //checkThread.Abort(); // Check Thread 종료
            }
            if (!(ProcessThread == null))
            {
                //ProcessThread.Abort(); //
            }
        }


    }
}