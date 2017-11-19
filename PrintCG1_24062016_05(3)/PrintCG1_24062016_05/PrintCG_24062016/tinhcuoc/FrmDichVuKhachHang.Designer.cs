namespace PrintCG_24062016.tinhcuoc
{
    partial class FrmDichVuKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbdv = new System.Windows.Forms.ComboBox();
            this.btnthemdv = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbkh = new System.Windows.Forms.ComboBox();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.lblpriceid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbdv);
            this.groupBox1.Controls.Add(this.btnthemdv);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(295, 533);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // cmbdv
            // 
            this.cmbdv.FormattingEnabled = true;
            this.cmbdv.Location = new System.Drawing.Point(68, 48);
            this.cmbdv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbdv.Name = "cmbdv";
            this.cmbdv.Size = new System.Drawing.Size(132, 24);
            this.cmbdv.TabIndex = 11;
            // 
            // btnthemdv
            // 
            this.btnthemdv.Location = new System.Drawing.Point(209, 48);
            this.btnthemdv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemdv.Name = "btnthemdv";
            this.btnthemdv.Size = new System.Drawing.Size(65, 28);
            this.btnthemdv.TabIndex = 14;
            this.btnthemdv.Text = "V";
            this.btnthemdv.UseVisualStyleBackColor = true;
            this.btnthemdv.Click += new System.EventHandler(this.btnthemdv_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Tất cả dịch vụ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTypeID});
            this.dataGridView1.Location = new System.Drawing.Point(8, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 425);
            this.dataGridView1.TabIndex = 5;
            // 
            // ServiceTypeID
            // 
            this.ServiceTypeID.HeaderText = "Mã DV";
            this.ServiceTypeID.Name = "ServiceTypeID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbkh);
            this.groupBox2.Controls.Add(this.btnthemkh);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(319, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(611, 533);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ";
            // 
            // cmbkh
            // 
            this.cmbkh.FormattingEnabled = true;
            this.cmbkh.Location = new System.Drawing.Point(99, 48);
            this.cmbkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbkh.Name = "cmbkh";
            this.cmbkh.Size = new System.Drawing.Size(132, 24);
            this.cmbkh.TabIndex = 11;
            // 
            // btnthemkh
            // 
            this.btnthemkh.Location = new System.Drawing.Point(240, 48);
            this.btnthemkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(65, 28);
            this.btnthemkh.TabIndex = 14;
            this.btnthemkh.Text = "V";
            this.btnthemkh.UseVisualStyleBackColor = true;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(148, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Tất cả khách hàng";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID});
            this.dataGridView2.Location = new System.Drawing.Point(8, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(595, 425);
            this.dataGridView2.TabIndex = 5;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã KH";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khách hàng";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(828, 555);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(93, 28);
            this.btncapnhat.TabIndex = 15;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // lblpriceid
            // 
            this.lblpriceid.AutoSize = true;
            this.lblpriceid.Location = new System.Drawing.Point(25, 555);
            this.lblpriceid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpriceid.Name = "lblpriceid";
            this.lblpriceid.Size = new System.Drawing.Size(20, 17);
            this.lblpriceid.TabIndex = 15;
            this.lblpriceid.Text = "...";
            // 
            // FrmDichVuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 598);
            this.Controls.Add(this.lblpriceid);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDichVuKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDichVuKhachHang";
            this.Load += new System.EventHandler(this.FrmDichVuKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbdv;
        private System.Windows.Forms.Button btnthemdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbkh;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Label lblpriceid;
    }
}