using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Force_Time
{
    public partial class windowInfo : Force_Time.windowBaseTool
    {
        public event Action<bool,int> onKongZhiChange = null;
        public event Action<bool> onJiLuChange = null;
        public event Action onQingChu = null;
        public event Action onBaoCun = null;


        double _NowTime = 0;
        double _JiLuGeShu = 0;
        TestInfo _testInfo = new TestInfo();
        public TestInfo testInfo 
        {
            set 
            {
                 _testInfo = value;
                 textBox_Riqi.Text  = _testInfo.testDate;
                 textBox_CaoZuo.Text  = _testInfo.tester ;
                 textBox_XiangMu.Text  = _testInfo.testName ; 
                 textBox_ShiJian.Text  = _testInfo.testTime  ;
                 textBox_DianWei.Text = _testInfo.testPoint; 

            }
            get 
            {
                _testInfo.testDate = textBox_Riqi.Text;
                _testInfo.tester = textBox_CaoZuo.Text;
                _testInfo.testName = textBox_XiangMu.Text;
                _testInfo.testTime = textBox_ShiJian.Text;
                _testInfo.testPoint = textBox_DianWei.Text;
                return _testInfo;
            }
        }


        public class TestInfo 
        {
            public string testName { get; set; }
            public string tester { set; get; }
            public string testPoint { set; get; }
            public string testDate { set; get; }
            public string testTime { set; get; }
        }

        public double JiLuGeShu
        {
            set 
            {
                this.displayDouble1.Value = value;
            }
            get 
            {
                return _JiLuGeShu;
            }
        }

        public double NowTime
        {
            set 
            {
                this.displayDouble2.Value = value;
            }
            get 
            {
                return _NowTime;
            }
        }

        public windowInfo()
        {
            InitializeComponent();
            timer1.Start();
            this.editInteger_JianGe.Value = 50;
            DockAreas = DockAreas.DockLeft | DockAreas.DockRight;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_ShiJian.Text  = System.DateTime.Now.ToLongTimeString();
            textBox_Riqi.Text  = System.DateTime.Now.ToLongDateString();
        }

        private void switchRotary_KongZhi_ValueChanged(object sender, Iocomp.Classes.ValueIntegerEventArgs e)
        {
            if (onKongZhiChange != null)
            {
                bool cj= e.ValueNew == 0 ? false : true ;
                
                onKongZhiChange(cj, this.editInteger_JianGe.Value);
                editInteger_JianGe.Enabled = !cj;
            }
            
        }


        private void button_qingChu_Click(object sender, EventArgs e)
        {
            if (onQingChu != null)
            {
                onQingChu();
            }
        }

        private void switchRotary_jiLu_ValueChanged(object sender, Iocomp.Classes.ValueIntegerEventArgs e)
        {
            if (onJiLuChange != null)
            {
                bool cj = e.ValueNew == 0 ? false : true;
                onJiLuChange(cj);
            }
        }

        private void button_baoCun_Click(object sender, EventArgs e)
        {
            if (onBaoCun != null) 
            {
                onBaoCun();
            }
        }
    }
}
