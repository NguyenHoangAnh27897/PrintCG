namespace PrintCG_24062016.baocaodoanhthu
{
    partial class FrmCGChuaChotBangKe
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
            this.txttongso = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttongso
            // 
            this.txttongso.Location = new System.Drawing.Point(564, 17);
            this.txttongso.Name = "txttongso";
            this.txttongso.Size = new System.Drawing.Size(100, 20);
            this.txttongso.TabIndex = 13;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(315, 15);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 12;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến ngày";
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenngay.Location = new System.Drawing.Point(212, 17);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(85, 20);
            this.dtpdenngay.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày";
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(50, 17);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(85, 20);
            this.dtptungay.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 417);
            this.dataGridView1.TabIndex = 7;
            // 
            // FrmCGChuaChotBangKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.txttongso);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpdenngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtptungay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCGChuaChotBangKe";
            this.Text = "CG chưa chốt công nợ";
            this.Load += new System.EventHandler(this.FrmCGChuaChotBangKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttongso;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}