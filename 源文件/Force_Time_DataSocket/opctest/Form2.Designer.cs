namespace opctest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding8 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding9 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding10 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding11 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding12 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding13 = new NationalInstruments.Net.DataSocketBinding();
            NationalInstruments.Net.DataSocketBinding dataSocketBinding14 = new NationalInstruments.Net.DataSocketBinding();
            this.dataSocketSource1 = new NationalInstruments.Net.DataSocketSource(this.components);
            this.numericEdit1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit2 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit3 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit4 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit5 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit6 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSocket1 = new NationalInstruments.Net.DataSocket(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor1 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor2 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor3 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocketSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSocketSource1
            // 
            dataSocketBinding8.Name = "Ramp1";
            dataSocketBinding8.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Data Type Examples.16 Bit De" +
                "vice.R Registers.Boolean2";
            dataSocketBinding9.Name = "Ramp2";
            dataSocketBinding9.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Ramp2";
            dataSocketBinding10.Name = "Ramp3";
            dataSocketBinding10.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Ramp3";
            dataSocketBinding11.Name = "Sin1";
            dataSocketBinding11.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine1";
            dataSocketBinding12.Name = "Sin2";
            dataSocketBinding12.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine2";
            dataSocketBinding13.Name = "Sin3";
            dataSocketBinding13.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Simulation Examples.Function" +
                "s.Sine3";
            dataSocketBinding14.AccessMode = NationalInstruments.Net.AccessMode.ReadWriteAutoUpdate;
            dataSocketBinding14.Name = "bool1";
            dataSocketBinding14.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Data Type Examples.16 Bit De" +
                "vice.R Registers.Boolean1";
            this.dataSocketSource1.Bindings.AddRange(new NationalInstruments.Net.DataSocketBinding[] {
            dataSocketBinding8,
            dataSocketBinding9,
            dataSocketBinding10,
            dataSocketBinding11,
            dataSocketBinding12,
            dataSocketBinding13,
            dataSocketBinding14});
            this.dataSocketSource1.BindingDataUpdated += new NationalInstruments.Net.BindingDataUpdatedEventHandler(this.dataSocketSource1_BindingDataUpdated);
            // 
            // numericEdit1
            // 
            this.numericEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSocketSource1, "Ramp1", true));
            this.numericEdit1.Location = new System.Drawing.Point(55, 106);
            this.numericEdit1.Name = "numericEdit1";
            this.numericEdit1.Size = new System.Drawing.Size(120, 21);
            this.numericEdit1.TabIndex = 1;
            // 
            // numericEdit2
            // 
            this.numericEdit2.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numericEdit2.Location = new System.Drawing.Point(54, 133);
            this.numericEdit2.Name = "numericEdit2";
            this.numericEdit2.Size = new System.Drawing.Size(120, 21);
            this.numericEdit2.TabIndex = 1;
            // 
            // numericEdit3
            // 
            this.numericEdit3.Location = new System.Drawing.Point(54, 160);
            this.numericEdit3.Name = "numericEdit3";
            this.numericEdit3.Size = new System.Drawing.Size(120, 21);
            this.numericEdit3.TabIndex = 1;
            // 
            // numericEdit4
            // 
            this.numericEdit4.Location = new System.Drawing.Point(54, 187);
            this.numericEdit4.Name = "numericEdit4";
            this.numericEdit4.Size = new System.Drawing.Size(120, 21);
            this.numericEdit4.TabIndex = 1;
            // 
            // numericEdit5
            // 
            this.numericEdit5.Location = new System.Drawing.Point(55, 214);
            this.numericEdit5.Name = "numericEdit5";
            this.numericEdit5.Size = new System.Drawing.Size(120, 21);
            this.numericEdit5.TabIndex = 1;
            // 
            // numericEdit6
            // 
            this.numericEdit6.Location = new System.Drawing.Point(55, 241);
            this.numericEdit6.Name = "numericEdit6";
            this.numericEdit6.Size = new System.Drawing.Size(120, 21);
            this.numericEdit6.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 167);
            this.textBox1.TabIndex = 2;
            // 
            // switch1
            // 
            this.switch1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSocketSource1, "bool1", true));
            this.switch1.Location = new System.Drawing.Point(55, 268);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(64, 96);
            this.switch1.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide;
            this.switch1.TabIndex = 3;
            this.switch1.Tag = global::opctest.Properties.Resources.d;
            this.switch1.Value = true;
            this.switch1.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch1_StateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSocket1
            // 
            this.dataSocket1.AccessMode = NationalInstruments.Net.AccessMode.ReadWriteAutoUpdate;
            this.dataSocket1.Url = "opc://localhost/National Instruments.NIOPCServers.V5/Data Type Examples.16 Bit De" +
                "vice.R Registers.Boolean1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.BackColor = System.Drawing.Color.White;
            this.waveformGraph1.Border = NationalInstruments.UI.Border.SolidBlack;
            this.waveformGraph1.CaptionBackColor = System.Drawing.Color.Black;
            this.waveformGraph1.CaptionForeColor = System.Drawing.Color.White;
            this.waveformGraph1.Location = new System.Drawing.Point(193, 202);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.PlotAreaBorder = NationalInstruments.UI.Border.SolidBlack;
            this.waveformGraph1.PlotAreaColor = System.Drawing.Color.White;
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1,
            this.waveformPlot2});
            this.waveformGraph1.Size = new System.Drawing.Size(384, 191);
            this.waveformGraph1.TabIndex = 5;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            this.waveformGraph1.PlotDataChanged += new NationalInstruments.UI.XYPlotDataChangedEventHandler(this.waveformGraph1_PlotDataChanged);
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.DefaultWaveformPlotOptions = new NationalInstruments.UI.AnalogWaveformPlotOptions(NationalInstruments.UI.AnalogWaveformPlotDisplayMode.Time, NationalInstruments.UI.AnalogWaveformPlotScaleMode.Raw, NationalInstruments.UI.AnalogWaveformPlotTimingMode.Auto);
            this.waveformPlot1.LineColor = System.Drawing.Color.Black;
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.AutoMinorDivisionFrequency = 10;
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.DefaultWaveformPlotOptions = new NationalInstruments.UI.AnalogWaveformPlotOptions(NationalInstruments.UI.AnalogWaveformPlotDisplayMode.Time, NationalInstruments.UI.AnalogWaveformPlotScaleMode.Raw, NationalInstruments.UI.AnalogWaveformPlotTimingMode.Auto);
            this.waveformPlot2.XAxis = this.xAxis1;
            this.waveformPlot2.YAxis = this.yAxis1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripPropertyEditor1
            // 
            this.toolStripPropertyEditor1.AutoSize = false;
            this.toolStripPropertyEditor1.Name = "toolStripPropertyEditor1";
            this.toolStripPropertyEditor1.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor1.Size = new System.Drawing.Size(120, 21);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripPropertyEditor2
            // 
            this.toolStripPropertyEditor2.AutoSize = false;
            this.toolStripPropertyEditor2.Name = "toolStripPropertyEditor2";
            this.toolStripPropertyEditor2.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor2.Size = new System.Drawing.Size(120, 21);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripPropertyEditor3
            // 
            this.toolStripPropertyEditor3.AutoSize = false;
            this.toolStripPropertyEditor3.Name = "toolStripPropertyEditor3";
            this.toolStripPropertyEditor3.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor3.Size = new System.Drawing.Size(120, 21);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(23, 23);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 104);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(393, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 45);
            this.textBox3.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 410);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericEdit6);
            this.Controls.Add(this.numericEdit5);
            this.Controls.Add(this.numericEdit4);
            this.Controls.Add(this.numericEdit3);
            this.Controls.Add(this.numericEdit2);
            this.Controls.Add(this.numericEdit1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSocketSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.Net.DataSocketSource dataSocketSource1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit2;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit3;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit4;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit5;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit6;
        private System.Windows.Forms.TextBox textBox1;
        private NationalInstruments.UI.WindowsForms.Switch switch1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private NationalInstruments.Net.DataSocket dataSocket1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}