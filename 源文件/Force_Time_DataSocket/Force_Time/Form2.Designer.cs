namespace Force_Time
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
            this.legend1 = new NationalInstruments.UI.WindowsForms.Legend();
            this.legendItem1 = new NationalInstruments.UI.LegendItem();
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).BeginInit();
            this.SuspendLayout();
            // 
            // legend1
            // 
            this.legend1.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.legendItem1});
            this.legend1.Location = new System.Drawing.Point(537, 28);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(92, 108);
            this.legend1.TabIndex = 0;
            this.legend1.ItemsChanged += new System.ComponentModel.CollectionChangeEventHandler(this.legend1_ItemsChanged);
            // 
            // legendItem1
            // 
            this.legendItem1.Text = "Item 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 459);
            this.Controls.Add(this.legend1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.Legend legend1;
        private NationalInstruments.UI.LegendItem legendItem1;
    }
}