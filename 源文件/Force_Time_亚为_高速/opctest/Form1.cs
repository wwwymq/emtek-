using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace opctest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void networkVariableBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // networkVariableBrowserDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataSocket1.SyncRead(1000);
            textBox1.Text= dataSocket1.Data.Value.ToString();
            dataSocketSource1.ToString();
        }

        private void numericEdit1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

    }
}
