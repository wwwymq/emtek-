namespace opctest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding1 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding2 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding3 = new NationalInstruments.Net.DataSocketBinding();
            this.propertyEditor1 = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.dataSocket1 = new NationalInstruments.Net.DataSocket(this.components);
            this.dataSocketSource1 = new NationalInstruments.Net.DataSocketSource(this.components);
            this.numericEdit1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit2 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            this.button1 = new System.Windows.Forms.Button();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor1 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor2 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor3 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor4 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentControlStrip2 = new NationalInstruments.UI.WindowsForms.InstrumentControlStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor5 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor6 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor7 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor8 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.instrumentControlStrip3 = new NationalInstruments.UI.WindowsForms.InstrumentControlStrip();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor9 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor10 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor11 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor12 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocketSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.instrumentControlStrip2.SuspendLayout();
            this.instrumentControlStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyEditor1
            // 
            this.propertyEditor1.Location = new System.Drawing.Point(12, 12);
            this.propertyEditor1.Name = "propertyEditor1";
            this.propertyEditor1.Size = new System.Drawing.Size(181, 21);
            this.propertyEditor1.TabIndex = 0;
            // 
            // dataSocket1
            // 
            this.dataSocket1.Tag = "";
            this.dataSocket1.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine1";
            // 
            // dataSocketSource1
            // 
            dataSocketBinding1.Name = "Binding1";
            dataSocketBinding1.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine2";
            dataSocketBinding2.Name = "Binding2";
            dataSocketBinding2.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine3";
            dataSocketBinding3.Name = "Binding3";
            dataSocketBinding3.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine4";
            this.dataSocketSource1.Bindings.AddRange(new NationalInstruments.Net.DataSocketBinding[] {
            dataSocketBinding1,
            dataSocketBinding2,
            dataSocketBinding3});
            // 
            // numericEdit1
            // 
            this.numericEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSocketSource1, "Binding1", true));
            this.numericEdit1.Location = new System.Drawing.Point(36, 52);
            this.numericEdit1.Name = "numericEdit1";
            this.numericEdit1.Size = new System.Drawing.Size(120, 21);
            this.numericEdit1.TabIndex = 1;
            this.numericEdit1.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.numericEdit1_AfterChangeValue);
            // 
            // numericEdit2
            // 
            this.numericEdit2.Location = new System.Drawing.Point(35, 79);
            this.numericEdit2.Name = "numericEdit2";
            this.numericEdit2.Size = new System.Drawing.Size(120, 21);
            this.numericEdit2.TabIndex = 2;
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Square;
            this.led1.Location = new System.Drawing.Point(37, 173);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(64, 64);
            this.led1.TabIndex = 4;
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(147, 141);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(64, 96);
            this.switch1.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide;
            this.switch1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(230, 22);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(341, 257);
            this.waveformGraph1.TabIndex = 7;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // xAxis1
            // 
            this.xAxis1.AutoMinorDivisionFrequency = 5;
            this.xAxis1.Caption = "Time";
            this.xAxis1.MajorDivisions.GridVisible = true;
            this.xAxis1.MinorDivisions.GridVisible = true;
            // 
            // yAxis1
            // 
            this.yAxis1.AutoMinorDivisionFrequency = 5;
            this.yAxis1.Caption = "Amplitude";
            this.yAxis1.MajorDivisions.GridVisible = true;
            this.yAxis1.MinorDivisions.GridVisible = true;
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.LineColor = System.Drawing.Color.White;
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 118);
            this.textBox1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(opctest.Form1);
            // 
            // instrumentControlStrip2
            // 
            this.instrumentControlStrip2.AutoSize = false;
            this.instrumentControlStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.instrumentControlStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripPropertyEditor5,
            this.toolStripLabel6,
            this.toolStripPropertyEditor6,
            this.toolStripLabel7,
            this.toolStripPropertyEditor7,
            this.toolStripLabel8,
            this.toolStripPropertyEditor8});
            this.instrumentControlStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.instrumentControlStrip2.Location = new System.Drawing.Point(241, 343);
            this.instrumentControlStrip2.Name = "instrumentControlStrip2";
            this.instrumentControlStrip2.Size = new System.Drawing.Size(341, 25);
            this.instrumentControlStrip2.TabIndex = 10;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.numericEdit2);
            this.Controls.Add(this.numericEdit1);
            this.Controls.Add(this.propertyEditor1);
            this.Controls.Add(this.instrumentControlStrip2);
            this.Controls.Add(this.instrumentControlStrip3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocketSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.instrumentControlStrip2.ResumeLayout(false);
            this.instrumentControlStrip2.PerformLayout();
            this.instrumentControlStrip3.ResumeLayout(false);
            this.instrumentControlStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.PropertyEditor propertyEditor1;
        private NationalInstruments.Net.DataSocket dataSocket1;
        private NationalInstruments.Net.DataSocketSource dataSocketSource1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit2;
        private NationalInstruments.UI.WindowsForms.Led led1;
        private NationalInstruments.UI.WindowsForms.Switch switch1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor2;
        private NationalInstruments.UI.WindowsForms.InstrumentControlStrip instrumentControlStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor8;
        private NationalInstruments.UI.WindowsForms.InstrumentControlStrip instrumentControlStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor12;
    }
}

