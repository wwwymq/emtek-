using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.Net;
using System.IO;

namespace opctest
{
    public partial class Form2 : Form
    {
        DataSocketBinding item = new DataSocketBinding();
        public Form2()
        {
            InitializeComponent();
            string path = @"C:\Users\Administrator\Desktop\ff.txt";
            try
            {
                if (File.Exists(path))
                {

                }
                else
                {
                    File.CreateText(path);  
                }

                //using (StreamWriter r = new StreamWriter(path,true))
                //{
                //    r.WriteLine("hello world");
                //    r.WriteLine("hello world");
                //    r.WriteLine("hello world");
                //    r.WriteLine("hello world");
                //}
                using (StreamReader f = new StreamReader(path))
                {
                    string s;
                    textBox3.Text = Application.StartupPath;
                    while ((s = f.ReadLine()) != null)
                    {
                        textBox2.Text += (s + "\r\n");
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }

            item.Name = "user";
            item.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Functions.Random1";
            dataSocketSource1.Bindings.Add(item);
            dataSocketSource1.Connect();
            timer1.Start();
            Properties.Settings.Default.bool1.ToString();
            Properties.Settings.Default.bool1 = "dd";
            Properties.Settings.Default.Save();
        }

        private void dataSocketSource1_BindingDataUpdated(object sender, NationalInstruments.Net.BindingDataUpdatedEventArgs e)
        {


        }

        private void switch1_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            dataSocketSource1.Bindings["bool1"].SyncWrite(switch1.Value, 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSocket1.SyncWrite(true, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSocket1.SyncWrite(false, 1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                foreach (DataSocketBinding item in dataSocketSource1.Bindings)
                {
                    textBox1.Text += String.Format("{0}:", item.Name);
                    textBox1.Text += item.Data.Value;
                    textBox1.Text += "\r\n";
                }
                waveformPlot1.PlotYAppend(Convert.ToDouble(dataSocketSource1.Bindings["Sin2"].Data.Value));
                waveformPlot2.PlotYAppend(Convert.ToDouble(dataSocketSource1.Bindings["Sin1"].Data.Value));
                //waveformGraph1.Update();
            }
            catch (Exception)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void waveformGraph1_PlotDataChanged(object sender, NationalInstruments.UI.XYPlotDataChangedEventArgs e)
        {

        }
    }
}
