namespace Force_Time
{
    partial class windowInfo
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
            Iocomp.Classes.ScaleDiscreetItem scaleDiscreetItem1 = new Iocomp.Classes.ScaleDiscreetItem();
            Iocomp.Classes.ScaleDiscreetItem scaleDiscreetItem2 = new Iocomp.Classes.ScaleDiscreetItem();
            Iocomp.Classes.ScaleDiscreetItem scaleDiscreetItem3 = new Iocomp.Classes.ScaleDiscreetItem();
            Iocomp.Classes.ScaleDiscreetItem scaleDiscreetItem4 = new Iocomp.Classes.ScaleDiscreetItem();
            this.switchRotary_KongZhi = new Iocomp.Instrumentation.Standard.SwitchRotary();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_XiangMu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CaoZuo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DianWei = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Riqi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ShiJian = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.editInteger_JianGe = new Iocomp.Instrumentation.Standard.EditInteger();
            this.button_qingChu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.switchRotary_jiLu = new Iocomp.Instrumentation.Standard.SwitchRotary();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.displayDouble2 = new Iocomp.Instrumentation.Standard.DisplayDouble();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.displayDouble1 = new Iocomp.Instrumentation.Standard.DisplayDouble();
            this.button_baoCun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // switchRotary_KongZhi
            // 
            this.switchRotary_KongZhi.LoadingBegin();
            this.switchRotary_KongZhi.BackColor = System.Drawing.Color.WhiteSmoke;
            scaleDiscreetItem1.Text = "停止";
            scaleDiscreetItem2.Text = "采集";
            this.switchRotary_KongZhi.Items.Add(scaleDiscreetItem1);
            this.switchRotary_KongZhi.Items.Add(scaleDiscreetItem2);
            this.switchRotary_KongZhi.Location = new System.Drawing.Point(36, 11);
            this.switchRotary_KongZhi.Name = "switchRotary_KongZhi";
            this.switchRotary_KongZhi.Pointer.Color = System.Drawing.Color.IndianRed;
            this.switchRotary_KongZhi.Pointer.Style = Iocomp.Types.PointerStyleSwitchRotary.Pointer;
            this.switchRotary_KongZhi.Size = new System.Drawing.Size(105, 95);
            this.switchRotary_KongZhi.TabIndex = 0;
            this.switchRotary_KongZhi.UIControl.MouseWheelEnabled = false;
            this.switchRotary_KongZhi.ValueChanged += new Iocomp.Delegates.ValueIntegerEventHandler(this.switchRotary_KongZhi_ValueChanged);
            this.switchRotary_KongZhi.LoadingEnd();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "采样间隔";
            // 
            // textBox_XiangMu
            // 
            this.textBox_XiangMu.Location = new System.Drawing.Point(27, 41);
            this.textBox_XiangMu.Name = "textBox_XiangMu";
            this.textBox_XiangMu.Size = new System.Drawing.Size(114, 21);
            this.textBox_XiangMu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作者";
            // 
            // textBox_CaoZuo
            // 
            this.textBox_CaoZuo.Location = new System.Drawing.Point(27, 80);
            this.textBox_CaoZuo.Name = "textBox_CaoZuo";
            this.textBox_CaoZuo.Size = new System.Drawing.Size(114, 21);
            this.textBox_CaoZuo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "点位";
            // 
            // textBox_DianWei
            // 
            this.textBox_DianWei.Location = new System.Drawing.Point(27, 119);
            this.textBox_DianWei.Name = "textBox_DianWei";
            this.textBox_DianWei.Size = new System.Drawing.Size(114, 21);
            this.textBox_DianWei.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "日期";
            // 
            // textBox_Riqi
            // 
            this.textBox_Riqi.Location = new System.Drawing.Point(27, 158);
            this.textBox_Riqi.Name = "textBox_Riqi";
            this.textBox_Riqi.ReadOnly = true;
            this.textBox_Riqi.Size = new System.Drawing.Size(114, 21);
            this.textBox_Riqi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "时间";
            // 
            // textBox_ShiJian
            // 
            this.textBox_ShiJian.Location = new System.Drawing.Point(27, 197);
            this.textBox_ShiJian.Name = "textBox_ShiJian";
            this.textBox_ShiJian.ReadOnly = true;
            this.textBox_ShiJian.Size = new System.Drawing.Size(114, 21);
            this.textBox_ShiJian.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_ShiJian);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Riqi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_DianWei);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_CaoZuo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_XiangMu);
            this.groupBox1.Location = new System.Drawing.Point(19, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "试验项目";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.editInteger_JianGe);
            this.groupBox2.Controls.Add(this.switchRotary_KongZhi);
            this.groupBox2.Location = new System.Drawing.Point(19, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "采样信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "x0.008ms";
            // 
            // editInteger_JianGe
            // 
            this.editInteger_JianGe.LoadingBegin();
            this.editInteger_JianGe.Location = new System.Drawing.Point(27, 118);
            this.editInteger_JianGe.Name = "editInteger_JianGe";
            this.editInteger_JianGe.Size = new System.Drawing.Size(55, 21);
            this.editInteger_JianGe.TabIndex = 1;
            this.editInteger_JianGe.Value.AsString = "4";
            this.editInteger_JianGe.Value.Max = ((long)(32));
            this.editInteger_JianGe.Value.Min = ((long)(1));
            this.editInteger_JianGe.LoadingEnd();
            // 
            // button_qingChu
            // 
            this.button_qingChu.Location = new System.Drawing.Point(23, 196);
            this.button_qingChu.Name = "button_qingChu";
            this.button_qingChu.Size = new System.Drawing.Size(118, 28);
            this.button_qingChu.TabIndex = 4;
            this.button_qingChu.Text = "数据清除";
            this.button_qingChu.UseVisualStyleBackColor = true;
            this.button_qingChu.Click += new System.EventHandler(this.button_qingChu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // switchRotary_jiLu
            // 
            this.switchRotary_jiLu.LoadingBegin();
            this.switchRotary_jiLu.BackColor = System.Drawing.Color.WhiteSmoke;
            scaleDiscreetItem3.Text = "记录停止";
            scaleDiscreetItem4.Text = "记录开始";
            this.switchRotary_jiLu.Items.Add(scaleDiscreetItem3);
            this.switchRotary_jiLu.Items.Add(scaleDiscreetItem4);
            this.switchRotary_jiLu.Location = new System.Drawing.Point(12, 15);
            this.switchRotary_jiLu.Name = "switchRotary_jiLu";
            this.switchRotary_jiLu.Pointer.Color = System.Drawing.Color.IndianRed;
            this.switchRotary_jiLu.Pointer.Style = Iocomp.Types.PointerStyleSwitchRotary.Pointer;
            this.switchRotary_jiLu.Size = new System.Drawing.Size(129, 93);
            this.switchRotary_jiLu.TabIndex = 0;
            this.switchRotary_jiLu.UIControl.MouseWheelEnabled = false;
            this.switchRotary_jiLu.ValueChanged += new Iocomp.Delegates.ValueIntegerEventHandler(this.switchRotary_jiLu_ValueChanged);
            this.switchRotary_jiLu.LoadingEnd();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.displayDouble2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.displayDouble1);
            this.groupBox3.Controls.Add(this.button_baoCun);
            this.groupBox3.Controls.Add(this.button_qingChu);
            this.groupBox3.Controls.Add(this.switchRotary_jiLu);
            this.groupBox3.Location = new System.Drawing.Point(19, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 270);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "记录信息";
            // 
            // displayDouble2
            // 
            this.displayDouble2.LoadingBegin();
            this.displayDouble2.Location = new System.Drawing.Point(23, 166);
            this.displayDouble2.Name = "displayDouble2";
            this.displayDouble2.Size = new System.Drawing.Size(118, 21);
            this.displayDouble2.TextFormatting.Precision = 2;
            this.displayDouble2.TextFormatting.PrecisionStyle = Iocomp.Types.PrecisionStyle.FixedDecimalPoints;
            this.displayDouble2.TextFormatting.UnitsText = "s";
            this.displayDouble2.LoadingEnd();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "记录时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "记录个数";
            // 
            // displayDouble1
            // 
            this.displayDouble1.LoadingBegin();
            this.displayDouble1.Location = new System.Drawing.Point(23, 124);
            this.displayDouble1.Name = "displayDouble1";
            this.displayDouble1.Size = new System.Drawing.Size(118, 21);
            this.displayDouble1.LoadingEnd();
            // 
            // button_baoCun
            // 
            this.button_baoCun.Location = new System.Drawing.Point(23, 230);
            this.button_baoCun.Name = "button_baoCun";
            this.button_baoCun.Size = new System.Drawing.Size(118, 28);
            this.button_baoCun.TabIndex = 4;
            this.button_baoCun.Text = "数据保存";
            this.button_baoCun.UseVisualStyleBackColor = true;
            this.button_baoCun.Click += new System.EventHandler(this.button_baoCun_Click);
            // 
            // windowInfo
            // 
            this.AutoHidePortion = 200D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(209, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HideOnClose = true;
            this.Name = "windowInfo";
            this.Text = "测试信息";
            this.Load += new System.EventHandler(this.windowInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Iocomp.Instrumentation.Standard.SwitchRotary switchRotary_KongZhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_XiangMu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CaoZuo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DianWei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Riqi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ShiJian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private Iocomp.Instrumentation.Standard.EditInteger editInteger_JianGe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_qingChu;
        private Iocomp.Instrumentation.Standard.SwitchRotary switchRotary_jiLu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private Iocomp.Instrumentation.Standard.DisplayDouble displayDouble1;
        private System.Windows.Forms.Button button_baoCun;
        private Iocomp.Instrumentation.Standard.DisplayDouble displayDouble2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
