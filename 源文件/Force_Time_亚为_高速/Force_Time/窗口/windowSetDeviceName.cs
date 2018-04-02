using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Force_Time
{
    public partial class windowSetDeviceName : Form
    {
        MainWindow mWindow;
        public windowSetDeviceName(MainWindow mWindow)
        {
            InitializeComponent();
            this.mWindow = mWindow;
            this.textBox1.Text = Properties.Settings.Default.deviceName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.deviceName = this.textBox1.Text;
            Properties.Settings.Default.Save();
            if (mWindow.setDevice()) 
            {
                string strAppFileName = Process.GetCurrentProcess().MainModule.FileName;
                Process myNewProcess = new Process();
                myNewProcess.StartInfo.FileName = strAppFileName;
                Debug.WriteLine(strAppFileName);
                myNewProcess.StartInfo.WorkingDirectory = Application.ExecutablePath;
                myNewProcess.Start();
                Application.Exit();   
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
