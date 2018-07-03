namespace PrintCG_24062016.congcu
{
    partial class FrmLuuChuyenChungTu
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpod = new System.Windows.Forms.TextBox();
            this.rdbtheopod = new System.Windows.Forms.RadioButton();
            this.rdbngay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.POD0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnxem = new System.Windows.Forms.Button();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnxoaluoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbcustomergroup = new System.Windows.Forms.ComboBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.dtpngaygiao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.POD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(647, 354);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupBox2);
            this.xtraTabPage1.Controls.Add(this.rdbngay);
            this.xtraTabPage1.Controls.Add(this.rdbtheopod);
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Controls.Add(this.btnxuatexcel);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.btnxem);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(641, 326);
            this.xtraTabPage1.Text = "Danh sách chứng từ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtpod);
            this.groupBox2.Location = new System.Drawing.Point(317, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 41);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Số POD";
            // 
            // txtpod
            // 
            this.txtpod.Location = new System.Drawing.Point(51, 14);
            this.txtpod.Name = "txtpod";
            this.txtpod.Size = new System.Drawing.Size(134, 21);
            this.txtpod.TabIndex = 41;
            // 
            // rdbtheopod
            // 
            this.rdbtheopod.AutoSize = true;
            this.rdbtheopod.Location = new System.Drawing.Point(317, 2);
            this.rdbtheopod.Name = "rdbtheopod";
            this.rdbtheopod.Size = new System.Drawing.Size(90, 17);
            this.rdbtheopod.TabIndex = 40;
            this.rdbtheopod.TabStop = true;
            this.rdbtheopod.Text = "Tìm theo POD";
            this.rdbtheopod.UseVisualStyleBackColor = true;
            this.rdbtheopod.CheckedChanged += new System.EventHandler(this.rdbtheopod_CheckedChanged);
            // 
            // rdbngay
            // 
            this.rdbngay.AutoSize = true;
            this.rdbngay.Checked = true;
            this.rdbngay.Location = new System.Drawing.Point(9, -2);
            this.rdbngay.Name = "rdbngay";
            this.rdbngay.Size = new System.Drawing.Size(93, 17);
            this.rdbngay.TabIndex = 38;
            this.rdbngay.TabStop = true;
            this.rdbngay.Text = "Tìm theo ngày";
            this.rdbngay.UseVisualStyleBackColor = true;
            this.rdbngay.CheckedChanged += new System.EventHandler(this.rdbngay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtptodate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dtpfromdate);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 43);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // dtptodate
            // 
            this.dtptodate.CustomFormat = "";
            this.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptodate.Location = new System.Drawing.Point(216, 16);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(81, 21);
            this.dtptodate.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Đến ngày";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Từ ngày";
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.CustomFormat = "";
            this.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromdate.Location = new System.Drawing.Point(56, 15);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(86, 21);
            this.dtpfromdate.TabIndex = 31;
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Location = new System.Drawing.Point(567, 32);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(67, 23);
            this.btnxuatexcel.TabIndex = 36;
            this.btnxuatexcel.Text = "Xuất excel";
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            this.btnxuatexcel.Click += new System.EventHandler(this.btnxuatexcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(635, 259);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.POD0,
            this.DocumentDate,
            this.DocumentID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // POD0
            // 
            this.POD0.Caption = "POD";
            this.POD0.FieldName = "POD";
            this.POD0.Name = "POD0";
            this.POD0.OptionsColumn.AllowEdit = false;
            this.POD0.Visible = true;
            this.POD0.VisibleIndex = 0;
            // 
            // DocumentDate
            // 
            this.DocumentDate.Caption = "Ngày trả";
            this.DocumentDate.FieldName = "DocumentDate";
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.OptionsColumn.AllowEdit = false;
            this.DocumentDate.Visible = true;
            this.DocumentDate.VisibleIndex = 1;
            // 
            // DocumentID
            // 
            this.DocumentID.Caption = "DocumentID";
            this.DocumentID.FieldName = "DocumentID";
            this.DocumentID.Name = "DocumentID";
            this.DocumentID.OptionsColumn.AllowEdit = false;
            this.DocumentID.Visible = true;
            this.DocumentID.VisibleIndex = 2;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(514, 32);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(48, 23);
            this.btnxem.TabIndex = 34;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnxoaluoi);
            this.xtraTabPage2.Controls.Add(this.btnxoa);
            this.xtraTabPage2.Controls.Add(this.label8);
            this.xtraTabPage2.Controls.Add(this.cbbcustomergroup);
            this.xtraTabPage2.Controls.Add(this.txttong);
            this.xtraTabPage2.Controls.Add(this.btnluu);
            this.xtraTabPage2.Controls.Add(this.dtpngaygiao);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.dataGridView2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(625, 326);
            this.xtraTabPage2.Text = "Thao tác";
            // 
            // btnxoaluoi
            // 
            this.btnxoaluoi.Location = new System.Drawing.Point(509, 3);
            this.btnxoaluoi.Name = "btnxoaluoi";
            this.btnxoaluoi.Size = new System.Drawing.Size(55, 23);
            this.btnxoaluoi.TabIndex = 44;
            this.btnxoaluoi.Text = "Xóa lưới";
            this.btnxoaluoi.UseVisualStyleBackColor = true;
            this.btnxoaluoi.Click += new System.EventHandler(this.btnxoaluoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(451, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(55, 23);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Khách hàng";
            // 
            // cbbcustomergroup
            // 
            this.cbbcustomergroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbcustomergroup.FormattingEnabled = true;
            this.cbbcustomergroup.Items.AddRange(new object[] {
            "Tất cả",
            "Khu vực nhận",
            "Bưu cục nhận",
            "Khu vực phát",
            "Bưu cục phát"});
            this.cbbcustomergroup.Location = new System.Drawing.Point(230, 4);
            this.cbbcustomergroup.Name = "cbbcustomergroup";
            this.cbbcustomergroup.Size = new System.Drawing.Size(85, 21);
            this.cbbcustomergroup.TabIndex = 41;
            this.cbbcustomergroup.Enter += new System.EventHandler(this.cbbcustomergroup_Enter);
            // 
            // txttong
            // 
            this.txttong.Enabled = false;
            this.txttong.Location = new System.Drawing.Point(568, 3);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(54, 21);
            this.txttong.TabIndex = 40;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(390, 3);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(55, 23);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // dtpngaygiao
            // 
            this.dtpngaygiao.CustomFormat = "";
            this.dtpngaygiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaygiao.Location = new System.Drawing.Point(63, 4);
            this.dtpngaygiao.Name = "dtpngaygiao";
            this.dtpngaygiao.Size = new System.Drawing.Size(86, 21);
            this.dtpngaygiao.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ngày giao";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POD});
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(619, 277);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowValidated);
            // 
            // POD
            // 
            this.POD.HeaderText = "POD";
            this.POD.Name = "POD";
            this.POD.Width = 200;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel |*.xls";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // FrmLuuChuyenChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 354);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmLuuChuyenChungTu";
            this.Text = "Lưu chuyển chứng từ";
            this.Load += new System.EventHandler(this.FrmLuuChuyenChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DateTimePicker dtpngaygiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn POD;
        private System.Windows.Forms.TextBox txttong;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn POD0;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentDate;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbcustomergroup;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnxoaluoi;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpod;
        private System.Windows.Forms.RadioButton rdbtheopod;
        private System.Windows.Forms.RadioButton rdbngay;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}