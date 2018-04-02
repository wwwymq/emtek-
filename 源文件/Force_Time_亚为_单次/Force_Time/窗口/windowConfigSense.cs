using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using channelControl;

namespace Force_Time
{
    public partial class windowConfigSense : windowBaseTool
    {
        List<ChannelControl> _channelList;
        public List<ChannelControl> channelList { get { return _channelList; } }
        private int changeHeight = 150;
        int senseCount { set; get; }
        public event Action onVisiableSenseChange;


        windowSetVisiableSense visiableWindow = null;
        
        public windowConfigSense(int senseCount)
        {
            InitializeComponent();
            this.senseCount = senseCount;
            _channelList=new List<ChannelControl>();

            for (uint i = 0; i < senseCount; i++)             
            {
                ChannelControl cCtrl = new ChannelControl(){channel=i};
                cCtrl.Width = this.panel1.Width;
                cCtrl.Height = this.panel1.Height;
                cCtrl.Visible = false;
                _channelList.Add(cCtrl);
            }
            this.SizeChanged += new EventHandler(windowConfigSense_SizeChanged);

            _channelList.ForEach((Action<ChannelControl>)(ch => 
            { flowLayoutPanel1.Controls.Add(ch);
            }));


            FormClosed += new FormClosedEventHandler(windowConfigSense_FormClosed);
            DockAreas = DockAreas.DockBottom | DockAreas.DockTop | DockAreas.DockLeft | DockAreas.DockRight;
        }

        void windowConfigSense_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (visiableWindow != null) 
            {
                visiableWindow.Dispose();
            }
        }

        void setVisiable() 
        {
            if (onVisiableSenseChange != null) 
            {
                onVisiableSenseChange();
            }

        }

        void windowConfigSense_SizeChanged(object sender, EventArgs e)
        {
            if (this.Height < changeHeight) 
            {
                this.flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            }
            else
            {
                this.flowLayoutPanel1.FlowDirection =FlowDirection.TopDown;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (visiableWindow == null)
            {
                visiableWindow = new windowSetVisiableSense(this._channelList);
                visiableWindow.onButtonYesClick += new Action(setVisiable);
                visiableWindow.FormClosed += (FormClosedEventHandler)((a, b) => { this.visiableWindow = null; });
                visiableWindow.Show();
            }
            else
            {
                visiableWindow.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var cc in _channelList) 
            {
                cc.Zero();
            }
        }
    }
}
