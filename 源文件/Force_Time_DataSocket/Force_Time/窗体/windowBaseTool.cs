using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Force_Time
{
    public partial class windowBaseTool : DockContent
    {
        public windowBaseTool()
        {
            InitializeComponent();  
        }
        public windowBaseTool(int autoHidePortion) {
            windowInit(autoHidePortion);
        }
        virtual public  void windowInit(double autoHidePortion)
        {
            this.AutoHidePortion = autoHidePortion;
            HideOnClose = true;
        }

        private void windowBaseTool_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
            windowInit(Properties.Settings.Default.toolLeftPortion);
        }
    }
}
