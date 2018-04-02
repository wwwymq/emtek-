namespace Force_Time
{
    partial class windowCharts
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
            this.panel_config = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.comboBox_symbolType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_titleY = new System.Windows.Forms.TextBox();
            this.textBox_titleX = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_showConfigPanel = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericEdit1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_config.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_config
            // 
            this.panel_config.AutoScroll = true;
            this.panel_config.Controls.Add(this.comboBoxY);
            this.panel_config.Controls.Add(this.comboBoxX);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.groupBox1);
            this.panel_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_config.Location = new System.Drawing.Point(0, 0);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(182, 439);
            this.panel_config.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(33, 259);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(84, 16);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "网格线可见";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(25, 354);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(130, 20);
            this.comboBoxY.TabIndex = 8;
            // 
            // comboBoxX
            // 
            this.comboBoxX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Location = new System.Drawing.Point(25, 316);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(130, 20);
            this.comboBoxX.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y轴数据源";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "X轴数据源";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericEdit1);
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Controls.Add(this.pictureBox_color);
            this.groupBox1.Controls.Add(this.comboBox_symbolType);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_titleY);
            this.groupBox1.Controls.Add(this.textBox_titleX);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 283);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图表属性";
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_color.Location = new System.Drawing.Point(86, 150);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(57, 24);
            this.pictureBox_color.TabIndex = 5;
            this.pictureBox_color.TabStop = false;
            // 
            // comboBox_symbolType
            // 
            this.comboBox_symbolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_symbolType.FormattingEnabled = true;
            this.comboBox_symbolType.Location = new System.Drawing.Point(12, 194);
            this.comboBox_symbolType.Name = "comboBox_symbolType";
            this.comboBox_symbolType.Size = new System.Drawing.Size(130, 20);
            this.comboBox_symbolType.TabIndex = 8;
            this.comboBox_symbolType.SelectedIndexChanged += new System.EventHandler(this.comboBox_symbolType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "设置颜色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_titleY
            // 
            this.textBox_titleY.Location = new System.Drawing.Point(12, 109);
            this.textBox_titleY.Name = "textBox_titleY";
            this.textBox_titleY.Size = new System.Drawing.Size(131, 21);
            this.textBox_titleY.TabIndex = 3;
            this.textBox_titleY.TextChanged += new System.EventHandler(this.textBox_titleY_TextChanged);
            // 
            // textBox_titleX
            // 
            this.textBox_titleX.Location = new System.Drawing.Point(12, 70);
            this.textBox_titleX.Name = "textBox_titleX";
            this.textBox_titleX.Size = new System.Drawing.Size(131, 21);
            this.textBox_titleX.TabIndex = 3;
            this.textBox_titleX.TextChanged += new System.EventHandler(this.textBox_titleX_TextChanged);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(12, 31);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(131, 21);
            this.textBox_title.TabIndex = 3;
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "点样式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "曲线颜色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y轴标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "X轴标题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图表标题";
            // 
            // button_showConfigPanel
            // 
            this.button_showConfigPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_showConfigPanel.Location = new System.Drawing.Point(182, 0);
            this.button_showConfigPanel.Name = "button_showConfigPanel";
            this.button_showConfigPanel.Size = new System.Drawing.Size(14, 439);
            this.button_showConfigPanel.TabIndex = 1;
            this.button_showConfigPanel.Text = "<";
            this.button_showConfigPanel.UseVisualStyleBackColor = true;
            this.button_showConfigPanel.Click += new System.EventHandler(this.button_showConfigPanel_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(196, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(560, 439);
            this.zedGraphControl1.TabIndex = 2;
            // 
            // numericEdit1
            // 
            this.numericEdit1.Location = new System.Drawing.Point(12, 232);
            this.numericEdit1.Name = "numericEdit1";
            this.numericEdit1.Range = new NationalInstruments.UI.Range(1D, 10D);
            this.numericEdit1.Size = new System.Drawing.Size(130, 21);
            this.numericEdit1.TabIndex = 10;
            this.numericEdit1.Value = 2D;
            this.numericEdit1.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.numericEdit1_AfterChangeValue);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "曲线宽度";
            // 
            // windowCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 439);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.button_showConfigPanel);
            this.Controls.Add(this.panel_config);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "windowCharts";
            this.Text = "windowCharts";
            this.Load += new System.EventHandler(this.windowCharts_Load);
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Button button_showConfigPanel;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_titleY;
        private System.Windows.Forms.TextBox textBox_titleX;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_symbolType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit1;
        private System.Windows.Forms.Label label8;
    }
}