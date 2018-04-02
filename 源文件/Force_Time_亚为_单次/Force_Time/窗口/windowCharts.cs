using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using ZedGraph;
using channelControl;

namespace Force_Time
{
    public partial class windowCharts : DockContent
    {
        GraphPane myGraphPane;
        LineItem myLineItem;
        PointPairList myPointPairList;
        public windowConfigSense mySense{get;set;}
        List<ChannelControl> userableSense;
        System.DateTime op, ed;
        double reTime = 50;
        

        double[] xdata;
        double[] ydata;
        string _title = "标题";
        string _xAxisTitle = "X";
        string _yAxisTitle = "Y";
        Color _lineColor = Color.Black;
        public TestData _testData;

        public Color lineColor 
        {
            set 
            {
                _lineColor = value;
                myLineItem.Color = _lineColor;
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
            get { return _lineColor; }
        }

        public string title 
        { 
            set 
            {
                _title = value;
                myChangeTitle();
            }
            get 
            {
                return _title;
            }
        }

        public string xAxisTitle
        {
            set
            {
                _xAxisTitle = value;
                myChangeTitle();
            }
            get 
            {
                return _xAxisTitle;
            }
        }

        public string yAxisTitle 
        {
            set { _yAxisTitle = value; myChangeTitle(); }
            get { return _yAxisTitle; }
        }

        public Image image 
        {
            get 
            {
                return zedGraphControl1.GetImage();
            }
        }

        public TestData testData
        {
            get
            {
                _testData = new TestData();
                _testData.title = title;
                _testData.X.title = xAxisTitle;
                _testData.Y.title = yAxisTitle;
                _testData.X.channelInfo = this.comboBoxX.SelectedItem.ToString();
                _testData.Y.channelInfo = this.comboBoxY.SelectedItem.ToString();
                if(xdata !=null&&ydata !=null)
                _testData.X.data = new List<double>(xdata);
                _testData.Y.data = new List<double>(ydata);
                return _testData;
            }
        }

        public void onJiLu(List<List<double>> Data, List<double> Time)
        {
            ed = System.DateTime.Now;
            var ts = ed.Subtract(op);
            if (ts.TotalMilliseconds >= reTime)
            {
                try
                {
                    if (comboBoxX.SelectedItem.ToString() == "时间")
                    {
                        xdata = Time.ToArray();
                    }
                    else
                    {
                        int index = comboBoxX.SelectedIndex;
                        xdata = Data[(int)userableSense[index]._channel].ToArray();
                    }
                    if (comboBoxY.SelectedItem.ToString() == "时间")
                    {
                        ydata = Time.ToArray();
                    }
                    else
                    {
                        int index = comboBoxY.SelectedIndex;
                        ydata = Data[(int)userableSense[index]._channel].ToArray();
                    }
                    myPointPairList = new PointPairList(xdata, ydata);
                    myLineItem.Points = myPointPairList;
                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();
                }
                catch (Exception)
                {

                }
                finally {
                    op = System.DateTime.Now;
                }

            }

        }

        private void refreshComboBox() 
        {
            List<string> comboItems = new List<string>();
            foreach (var i in userableSense )
            {
                comboItems.Add("通道"+i.channel +":"+i.channelName);
            }
            comboItems.Add("时间");
            comboBoxX.Items.Clear();
            comboBoxY.Items.Clear();
            comboBoxX.Items.AddRange(comboItems.ToArray());
            comboBoxY.Items.AddRange(comboItems.ToArray());
        }

        public void onVisiableSenseChange() 
        {
            userableSense = new List<ChannelControl>();
            foreach(var ch in mySense .channelList)
            {
                if (ch.Visible) 
                {
                    userableSense.Add(ch);
                }   
            }
            refreshComboBox();
        }
        
        public windowCharts():this(null)
        {
            
        }

        public windowCharts(windowConfigSense configSense) 
        {
            mySense = configSense;
            InitializeComponent();
            DockAreas = DockAreas.Document;     
            
        }

        private void windowCharts_Load(object sender, EventArgs e)
        {
            this.panel_config.Visible = false;
            pictureBox_color.BackColor = colorDialog1.Color; 
            myPointPairList = new PointPairList ();
            myGraphPane = this.zedGraphControl1.GraphPane;
            myLineItem = myGraphPane.AddCurve(textBox_title.Text, myPointPairList, colorDialog1.Color);
            myLineItem.Line.Width = Convert.ToSingle(numericEdit1.Value);
            comboBox_symbolType.Items.AddRange(typeof(SymbolType).GetEnumNames());
            comboBox_symbolType.SelectedIndex = comboBox_symbolType.Items.IndexOf("None");
            onVisiableSenseChange();
            checkBox_CheckedChanged(this,null);
            op = System.DateTime.Now;
            ed = System.DateTime.Now;
        }

        private void button_showConfigPanel_Click(object sender, EventArgs e)
        {
            panel_config.Visible = !panel_config.Visible;
            if (panel_config.Visible)
            {
                button_showConfigPanel.Text = ">";

            }
            else
            {
                button_showConfigPanel.Text = "<";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            pictureBox_color.BackColor = colorDialog1.Color;
            lineColor = colorDialog1.Color;
            
        }

        private void comboBox_symbolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            myLineItem.Symbol.Type = (SymbolType)Enum.Parse(typeof(SymbolType), comboBox_symbolType.SelectedItem.ToString ());
            zedGraphControl1.Refresh();
        }

        private void myChangeTitle() 
        {
            this.TabText = myGraphPane.Title.Text = myLineItem.Label.Text = title;
            myGraphPane.XAxis.Title.Text = xAxisTitle;
            myGraphPane.YAxis.Title.Text = yAxisTitle;
            
            
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {
            title = textBox_title.Text;
        }

        private void textBox_titleX_TextChanged(object sender, EventArgs e)
        {
            xAxisTitle = textBox_titleX.Text;
        }

        private void textBox_titleY_TextChanged(object sender, EventArgs e)
        {
            yAxisTitle = textBox_titleY.Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            myGraphPane.XAxis.MajorGrid.IsVisible = checkBox.Checked;
            myGraphPane.YAxis.MajorGrid.IsVisible = checkBox.Checked;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void numericEdit1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (myLineItem != null)
            {
                myLineItem.Line.Width = Convert.ToSingle(numericEdit1.Value);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
            
        }

    }

        public class TestData
    {
        public string title { get; set; }
        public axisData X { get; set; }
        public axisData Y { get; set; }
        public TestData() 
        {
            title = "";
            X = new axisData() { title = "", data = new List<double>() };
            Y = new axisData() { title = "", data = new List<double>() }; 
        }

        public class axisData 
        {
            public string title { get; set; }
            public List<double> data { get; set; }
            public string channelInfo = "";
        }
    }
}
