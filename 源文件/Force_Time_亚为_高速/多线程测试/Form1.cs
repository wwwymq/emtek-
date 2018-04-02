using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace 多线程测试
{
    public partial class Form1 : Form
    {

        Thread t1,t2;
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = 1000;
            t1 = new Thread(new ParameterizedThreadStart(r1));
            t2 = new Thread(new ParameterizedThreadStart(r1));
            Debug.Print("Start!");
            t1.Start(500);
            t2.Start(1000);
        }
        private void r1(Object o)
        {
            try
            {
                int time = Convert.ToInt16(o);
                while (true)
                {
                    Thread.Sleep(time);
                    Debug.Write(Thread.CurrentThread.ManagedThreadId+":");
                    a = a + 1;
                    Debug.WriteLine(a);
                }
            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Abort();
            t2.Abort();
        }
    }
}
