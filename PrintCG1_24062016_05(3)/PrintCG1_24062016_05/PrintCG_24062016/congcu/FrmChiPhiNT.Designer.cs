namespace PrintCG_24062016.congcu
{
    partial class FrmChiPhiNT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbloctheo = new System.Windows.Forms.ComboBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtbuucuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.myGrid1 = new PrintCG_24062016.MyGrid(this.components);
            this.MailerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PronviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostOfficeIDAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1496, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txttotal);
            this.tabPage1.Controls.Add(this.btnxuatexcel);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbloctheo);
            this.tabPage1.Controls.Add(this.btnxem);
            this.tabPage1.Controls.Add(this.dtptodate);
            this.tabPage1.Controls.Add(this.dtpfromdate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1488, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Location = new System.Drawing.Point(848, 16);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(75, 23);
            this.btnxuatexcel.TabIndex = 8;
            this.btnxuatexcel.Text = "Xuất excel";
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            this.btnxuatexcel.Click += new System.EventHandler(this.btnxuatexcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1459, 508);
            this.dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lọc theo";
            // 
            // cmbloctheo
            // 
            this.cmbloctheo.FormattingEnabled = true;
            this.cmbloctheo.Items.AddRange(new object[] {
            "Ngày nhập",
            "Ngày nhận"});
            this.cmbloctheo.Location = new System.Drawing.Point(608, 15);
            this.cmbloctheo.Name = "cmbloctheo";
            this.cmbloctheo.Size = new System.Drawing.Size(121, 24);
            this.cmbloctheo.TabIndex = 5;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(754, 15);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 4;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // dtptodate
            // 
            this.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptodate.Location = new System.Drawing.Point(343, 15);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(136, 22);
            this.dtptodate.TabIndex = 3;
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromdate.Location = new System.Drawing.Point(84, 13);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(136, 22);
            this.dtpfromdate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnluu);
            this.tabPage2.Controls.Add(this.txtbuucuc);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpngaynhap);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.myGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1488, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(523, 14);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtbuucuc
            // 
            this.txtbuucuc.Location = new System.Drawing.Point(359, 15);
            this.txtbuucuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuucuc.Name = "txtbuucuc";
            this.txtbuucuc.Size = new System.Drawing.Size(132, 22);
            this.txtbuucuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bưu cục";
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhap.Location = new System.Drawing.Point(96, 15);
            this.dtpngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(132, 22);
            this.dtpngaynhap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày nhập";
            // 
            // myGrid1
            // 
            this.myGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailerID,
            this.SenderName,
            this.PronviceID,
            this.tinh,
            this.DistrictID,
            this.pptt,
            this.ppnt,
            this.Description,
            this.PriceService,
            this.Price,
            this.AcceptDate,
            this.Weight,
            this.PostOfficeIDAccept});
            this.myGrid1.Location = new System.Drawing.Point(8, 48);
            this.myGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.myGrid1.Name = "myGrid1";
            this.myGrid1.Size = new System.Drawing.Size(1465, 508);
            this.myGrid1.TabIndex = 0;
            this.myGrid1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.myGrid1_CellValidating);
            this.myGrid1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.myGrid1_EditingControlShowing);
            // 
            // MailerID
            // 
            this.MailerID.HeaderText = "Số CG";
            this.MailerID.Name = "MailerID";
            // 
            // SenderName
            // 
            this.SenderName.HeaderText = "Khách hàng";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            // 
            // PronviceID
            // 
            this.PronviceID.HeaderText = "NĐ";
            this.PronviceID.Name = "PronviceID";
            this.PronviceID.ReadOnly = true;
            this.PronviceID.Width = 40;
            // 
            // tinh
            // 
            this.tinh.HeaderText = "CTV";
            this.tinh.Name = "tinh";
            this.tinh.Width = 40;
            // 
            // DistrictID
            // 
            this.DistrictID.HeaderText = "Huyện";
            this.DistrictID.Name = "DistrictID";
            this.DistrictID.Width = 70;
            // 
            // pptt
            // 
            this.pptt.HeaderText = "Phụ phí";
            this.pptt.Name = "pptt";
            this.pptt.Width = 80;
            // 
            // ppnt
            // 
            this.ppnt.HeaderText = "CP CTV";
            this.ppnt.Name = "ppnt";
            this.ppnt.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Ghi chú";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 80;
            // 
            // PriceService
            // 
            this.PriceService.HeaderText = "PP (PMS)";
            this.PriceService.Name = "PriceService";
            this.PriceService.ReadOnly = true;
            this.PriceService.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cước";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // AcceptDate
            // 
            this.AcceptDate.HeaderText = "Ngày";
            this.AcceptDate.Name = "AcceptDate";
            this.AcceptDate.ReadOnly = true;
            this.AcceptDate.Width = 90;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "TL";
            this.Weight.Name = "Weight";
            this.Weight.Width = 60;
            // 
            // PostOfficeIDAccept
            // 
            this.PostOfficeIDAccept.HeaderText = "BC Gốc";
            this.PostOfficeIDAccept.Name = "PostOfficeIDAccept";
            this.PostOfficeIDAccept.ReadOnly = true;
            this.PostOfficeIDAccept.Width = 80;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Location = new System.Drawing.Point(1380, 25);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 9;
            // 
            // FrmChiPhiNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 598);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChiPhiNT";
            this.Text = "FrmChiPhiNT";
            this.Load += new System.EventHandler(this.FrmChiPhiNT_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtbuucuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.Label label1;
        private MyGrid myGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PronviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pptt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeIDAccept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbloctheo;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttotal;
    }
}