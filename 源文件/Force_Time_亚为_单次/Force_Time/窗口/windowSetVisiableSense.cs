using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using channelControl;

namespace Force_Time
{
    public partial class windowSetVisiableSense : Form
    {
        public event Action onButtonYesClick;
        List<ChannelControl> _channelList;
        public windowSetVisiableSense(List<ChannelControl> channelList)
        {
            InitializeComponent();
            _channelList = channelList;
            foreach (ChannelControl cc in _channelList)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Checked = cc.Visible;
                cb.Text = "通道" + cc.channel + "：" + cc.channelName;
                this.flowLayoutPanel1.Controls.Add(cb);
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (CheckBox cb in flowLayoutPanel1.Controls)
            {
                _channelList[i++].Visible = cb.Checked;
            }
            onButtonYesClick();
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
                foreach(CheckBox cb in flowLayoutPanel1.Controls)
                {
                    cb.Checked = checkBox_selectAll.Checked;
                }
        }
    }
}
