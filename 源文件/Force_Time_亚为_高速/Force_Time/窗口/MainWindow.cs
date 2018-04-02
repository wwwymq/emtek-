using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using Force_Time.Properties;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using myLib;
using System.Reflection;
using System.Diagnostics;
//using NationalInstruments.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
namespace Force_Time
{
    public partial class MainWindow : Form
    {
        #region 全局对象
        DateTime op, ed;
        UInt16 buffLen = 256;//采样缓存长度
        Thread daqThread,dispThread;                               //数据采集线程

        Queue<uint[]> dataQueue;
        private int childFormNumber = 0;
        windowConfigSense configSenseWindow;                        //传感器配置窗体
        windowInfo infoWindow;                                      //采集控制窗体
        private DeserializeDockContent m_deserializeDockContent;
        private bool m_bSaveLayout = true;                          //是否保存界面

        List<List<double>> Data;                                    //传感器采集的数据
        List<double> Time;
        double _DAQcount = 0;
        List<windowCharts> myChartList;
        bool JiLu = false;
        public event Action<List<List<double>>, List<double>> onJiLu;
        double DAQcount
        {
            set
            {
                infoWindow.JiLuGeShu = _DAQcount = value;
            }
            get
            {
                return _DAQcount;
            }
        }
        //InstantAiCtrl instantAi;
        string _deviceName;
        string deviceName
        {
            get
            {
                _deviceName = Properties.Settings.Default.deviceName;
                return _deviceName;
            }
            set
            {
                this.deviceName = value;
                Properties.Settings.Default.deviceName = value;
            }
        }

        #endregion

        #region 亚为采集卡API
        [DllImport(@"ADIO16",CallingConvention=CallingConvention.Cdecl)]
        private static extern uint FindDevice();
        [DllImport(@"ADIO16", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint OpenDevice(uint ID);
        [DllImport(@"ADIO16", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint WriteDeviceHIDEX(byte ID, byte CMD, byte DO0, byte DO1, byte DO2, byte DO3);
        [DllImport(@"ADIO16", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint m_ReadDeviceHID2BUF(uint ID, ref uint ADBuf, UInt16 buffLen, ref uint DAbuf, ref uint CNbuf, ref uint DIO);
        [DllImport(@"ADIO16", CallingConvention = CallingConvention.Cdecl)]
        private static extern byte ReadOnce(UInt32 ID, ref UInt32 data);
        #endregion

        #region 构造方法
        public MainWindow()
        {
            InitializeComponent();
            dataQueue = new Queue<uint[]>();
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }
        #endregion

        #region 设备初始化
        public bool setDevice()
        {
            try
            {
                if (FindDevice() != 0)
                {
                    Debug.WriteLine("已找到设备");
                    //打开设备
                    OpenDevice(0);
                    //初始化设备（编号，模式，采样率）设置采样率为1k
                    WriteDeviceHIDEX(0, 0xAA, 7, 0, 0, 0);
                    Debug.WriteLine("设备连接成功");
                }
                else
                {
                    MessageBox.Show("未找到设备");
                }
            }
            catch (Exception)
            {

                Debug.WriteLine("设备初始化异常");
                MessageBox.Show("设备初始化异常");
            }

            Properties.Settings.Default.senseCount = 8;
            Debug.WriteLine("最大端口数：" + Properties.Settings.Default.senseCount);
            Data = new List<List<double>>();
            Time = new List<double>();
            myChartList = new List<windowCharts>();
            for (int i = 0; i < (int)Settings.Default.senseCount; i++)
            {
                Data.Add(new List<double>());
            }

            //     MessageBox.Show("设备初始化成功，" + "最大端口数：" + instantAi.Features.ChannelCountMax);
            return true;
        }
        #endregion

        #region 主窗口加载
        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (System.Configuration.SettingsProperty item in Settings.Default.Properties)
            {
                
            }
            //instantAi = this.instantAiCtrl1;
            setDevice();
            this.configSenseWindow = new windowConfigSense(Properties.Settings.Default.senseCount);
            //窗口对象的初始化
            this.infoWindow = new windowInfo();
            #region dockpanel反序列化
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            Debug.WriteLine(configFile);
            if (File.Exists(configFile))
            {
                this.dockPanel1.LoadFromXml(configFile, m_deserializeDockContent);
            }
            else
            {
                #region 控制窗口初始化
                infoWindow.DockPanel = this.dockPanel1;
                infoWindow.DockState = DockState.DockLeft;
                infoWindow.DockAreas = DockAreas.DockLeft;

                configSenseWindow.DockPanel = this.dockPanel1;
                configSenseWindow.DockTo(infoWindow.Pane, DockStyle.Fill, 0);
                #endregion
            }
            #endregion



            infoWindow.Show();

            //设置浮动窗口和左边停靠窗口的宽度
            dockPanel1.DefaultFloatWindowSize = new Size(190, 600);
            dockPanel1.DockRightPortion = dockPanel1.DockLeftPortion = Settings.Default.toolLeftPortion;
            dockPanel1.DockTopPortion = dockPanel1.DockBottomPortion = Settings.Default.toolTopBottomPortion;
            //FormClosed += new FormClosedEventHandler(MainWindow_FormClosed);

            //添加控制窗口的回调方法
            infoWindow.onKongZhiChange += new Action<bool, int>(infoWindow_onKongZhiChange);
            infoWindow.onQingChu += new Action(infoWindow_onQingChu);
            this.ShowNewForm(this, null);
            infoWindow.onJiLuChange += new Action<bool>(infoWindow_onJiLuChange);
            infoWindow.onBaoCun += new Action(infoWindow_onBaoCunChange);
        }
        #endregion

        #region 开始数据记录
        void infoWindow_onJiLuChange(bool obj)
        {
            this.JiLu = obj;
            if (DAQcount == 0)
            {
                op = System.DateTime.Now;
            }
        }
        #endregion

        #region 保存实验数据
        void infoWindow_onBaoCunChange()
        {
            IWorkbook ibook;
            try
            {
                //Assembly assembly = Assembly.GetAssembly(typeof(windowInfo));
                //using (FileStream fs = new FileStream(@"dataMB.xls", FileMode.Open, FileAccess.ReadWrite))
                using (MemoryStream ms = new MemoryStream(Resources.dataMB))
                {
                    ibook = new HSSFWorkbook(ms);
                }

                ISheet infoSheet = ibook.GetSheet("信息");
                windowInfo.TestInfo info = infoWindow.testInfo;
                infoSheet.GetRow(1).GetCell(0).SetCellValue(info.testName);
                infoSheet.GetRow(1).GetCell(1).SetCellValue(info.tester);
                infoSheet.GetRow(1).GetCell(2).SetCellValue(info.testDate);
                infoSheet.GetRow(1).GetCell(3).SetCellValue(info.testTime);
                infoSheet.GetRow(1).GetCell(4).SetCellValue(info.testPoint);

                foreach (var doc in dockPanel1.Documents)
                {
                    if (doc as windowCharts != null)
                    {
                        windowCharts chart = doc as windowCharts;


                        Image img = chart.image;

                        //add picture data to this workbook.

                        //create sheet
                        ISheet sheet = ibook.CreateSheet(chart.testData.title);

                        sheet.addImage(img, 3, 3, 4, 7, true);

                        IRow rowT = sheet.CreateRow(0);
                        rowT.CreateCell(0).SetCellValue(String.Format("{0}({1})", chart._testData.X.title, chart._testData.X.channelInfo));
                        rowT.CreateCell(1).SetCellValue(String.Format("{0}({1})", chart._testData.Y.title, chart._testData.Y.channelInfo));

                        List<double> X = chart.testData.X.data;
                        List<double> Y = chart.testData.Y.data;
                        int count = 0;

                        Debug.WriteLine("x.count=" + X.Count);
                        Debug.WriteLine("y.count=" + Y.Count);

                        foreach (var va in X)
                        {
                            IRow row = sheet.CreateRow(count + 1);
                            row.CreateCell(0).SetCellValue(va);
                            row.CreateCell(1).SetCellValue(Y[count]);
                            count++;
                            //    Debug.WriteLine(Y[count]);
                        }
                    }
                }



                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream f = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                    {
                        ibook.Write(f);
                    }

                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("某条曲线未设置数据，请设置曲线。");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("曲线的标题重复，请重新设置。");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        #endregion
       
        #region 清除数据方法
        void infoWindow_onQingChu()
        {
            foreach (var item in Data)
            {
                item.Clear();
            }
            Time.Clear();
            DAQcount = Data[0].Count;
            double nowTime = 0;
            infoWindow.NowTime = nowTime;
            op = System.DateTime.Now;
        }
        #endregion

        #region 保存窗口状态
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(windowConfigSense).ToString())
                return configSenseWindow;
            else if (persistString == typeof(windowInfo).ToString())
                return infoWindow;
            else
            {
                return null;
            }
        }
        #endregion

        #region 传感器设置窗口
        private void openSenseWindow(object sender, EventArgs e)
        {
            configSenseWindow.Show();
        }
        #endregion

        #region 窗口关闭
        //窗口关闭回调
        void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        #endregion

        #region 打开控制窗口
        private void openControlWindow(object sender, EventArgs e)
        {
            if (infoWindow != null)
            {
                infoWindow.Show();
            }


        }
        #endregion

        #region 采样计时器到时回调
        private void timer_caiYang_Tick(object sender, EventArgs e)
        {
            if (onJiLu != null)
            {
                onJiLu(Data, Time);
            }
        }

        #endregion

        //采集线程
        void daq(Object o)
        {
            while (true)
            {
                DateTime op;
                try
                {
                    ////多采样模式，采样率1k
                    uint[] adBuf = new uint[buffLen];
                    uint[] daBuf = new uint[4];
                    uint[] cnBuf = new uint[2];
                    uint[] dio = new uint[2];
                    op = System.DateTime.Now;
                    m_ReadDeviceHID2BUF(0, ref adBuf[0], buffLen, ref daBuf[0], ref cnBuf[0], ref dio[0]);
                    Debug.WriteLine(System.DateTime.Now.Subtract(op).TotalMilliseconds);
                    dataQueue.Enqueue(adBuf);
                }
                catch (Exception)
                {
                    //throw; 
                }
            }

        }
        //显示线程
        void display(Object o)
        {
            while (true)
            {
                while (dataQueue.Count > 0)
                {
                    try
                    {
                        double[] data = new double[Settings.Default.senseCount];//获取原始数据
                        uint[] da = dataQueue.Dequeue();
                        if (da.Length > 0)
                        {
                            uint cc = Convert.ToUInt32(buffLen / Settings.Default.senseCount);
                            if (cc > 0)
                            {
                                for (int j = 0; j < Settings.Default.senseCount; j++)
                                {
                                    //data[j] = Convert.ToDouble(adBuf[j]);
                                    data[j] = da.ToList().ConvertAll(a => Convert.ToDouble(a)).Where((a, b) => b % Settings.Default.senseCount == j).Average();
                                }
                            }
                            int i = 0;
                            foreach (var item in data)
                            {
                                if (JiLu)
                                {
                                    Data[i].Add(configSenseWindow.channelList[i].calculateData(item));

                                }
                                else
                                {
                                    configSenseWindow.channelList[i].inData = item;
                                }
                                i++;
                            }
                            if (JiLu)
                            {
                                double nowTime;
                                DAQcount = Data[0].Count - 1;
                                if (DAQcount == 0)
                                {
                                    nowTime = 0;
                                }
                                else
                                {
                                    //nowTime = ed.Subtract(op).TotalMilliseconds / 1000.0;
                                    nowTime = buffLen / Settings.Default.senseCount / 1000.0 * DAQcount;
                                }
                                ed = System.DateTime.Now;
                                infoWindow.NowTime = nowTime;
                                Time.Add(nowTime);
                                if (onJiLu != null)
                                {
                                    onJiLu(Data, Time);
                                }
                            }
                        }

                    }
                    catch (Exception)
                    {
                        //throw; 
                    }
                }

            }

        }
        #region 采样开始
        void infoWindow_onKongZhiChange(bool arg1, int arg2)
        {
            if (arg1)
            {
                buffLen = Convert.ToUInt16(arg2 * 64);
                timer_caiYang.Interval = 5;
                timer_caiYang.Start();
                //////////////////////////////////////////////////////////////////
                dataQueue.Clear();
                daqThread = new Thread(new ParameterizedThreadStart(daq));
                daqThread.Start(arg2);
                dispThread = new Thread(new ParameterizedThreadStart(display));
                dispThread.Start(arg2);
            }
            else
            {
                timer_caiYang.Stop();
                daqThread.Abort();
                dispThread.Abort();
            }
        }
        #endregion
        #region 各种回调



        private void ShowNewForm(object sender, EventArgs e)
        {
            windowCharts childForm = new windowCharts(configSenseWindow);
            configSenseWindow.onVisiableSenseChange += childForm.onVisiableSenseChange;
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show(this.dockPanel1);
            this.onJiLu += childForm.onJiLu;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            windowSetDeviceName sd = new windowSetDeviceName(this);
            sd.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            infoWindow_onBaoCunChange();
        }
 
        private void newChart(object sender, EventArgs e)
        {
            windowCharts childForm = new windowCharts(configSenseWindow);
            configSenseWindow.onVisiableSenseChange += childForm.onVisiableSenseChange;
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show(this.dockPanel1);
            this.onJiLu += childForm.onJiLu;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                daqThread.Abort();
                dispThread.Abort();
            }
            catch (Exception)
            {

                //throw;
            }
            
            string configFile = Path.Combine(Application.StartupPath, "DockPanel.config");
            if (m_bSaveLayout)
                this.dockPanel1.SaveAsXml(configFile);
            else
            {
                if (File.Exists(configFile))
                {
                    File.Delete(configFile);
                }
            }
            Properties.Settings.Default.Save();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            infoWindow_onBaoCunChange();
        }
    }
}
