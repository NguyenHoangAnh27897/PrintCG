using PrintCG_24062016.dataset;
namespace PrintCG_24062016
{
    partial class CG1_LE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtinlien = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsophieu = new System.Windows.Forms.TextBox();
            this.txtmacg = new System.Windows.Forms.TextBox();
            this.rdbthucong = new System.Windows.Forms.RadioButton();
            this.rdbtudong = new System.Windows.Forms.RadioButton();
            this.txtnhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuucuc = new System.Windows.Forms.TextBox();
            this.btnina5 = new System.Windows.Forms.Button();
            this.btnlien = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dsProvinces = new PrintCG_24062016.dataset.DsProvinces();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.dtppgi = new System.Windows.Forms.DateTimePicker();
            this.btnbaophat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluongin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbangke = new System.Windows.Forms.Button();
            this.myGrid1 = new PrintCG_24062016.MyGrid(this.components);
            this.Acceptdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mailertypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicetypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provinceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priceservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Districtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProvinces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbtinlien);
            this.groupBox1.Location = new System.Drawing.Point(162, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 51);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình in";
            this.groupBox1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "In A5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtinlien
            // 
            this.rbtinlien.AutoSize = true;
            this.rbtinlien.Checked = true;
            this.rbtinlien.Location = new System.Drawing.Point(6, 21);
            this.rbtinlien.Name = "rbtinlien";
            this.rbtinlien.Size = new System.Drawing.Size(57, 17);
            this.rbtinlien.TabIndex = 0;
            this.rbtinlien.TabStop = true;
            this.rbtinlien.Text = "In Liên";
            this.rbtinlien.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsophieu);
            this.groupBox2.Controls.Add(this.txtmacg);
            this.groupBox2.Controls.Add(this.rdbthucong);
            this.groupBox2.Controls.Add(this.rdbtudong);
            this.groupBox2.Controls.Add(this.txtnhanvien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbuucuc);
            this.groupBox2.Location = new System.Drawing.Point(301, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 50);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập chung";
            // 
            // txtsophieu
            // 
            this.txtsophieu.Enabled = false;
            this.txtsophieu.Location = new System.Drawing.Point(404, 24);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.Size = new System.Drawing.Size(117, 20);
            this.txtsophieu.TabIndex = 5;
            this.txtsophieu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtsophieu_MouseDoubleClick);
            // 
            // txtmacg
            // 
            this.txtmacg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtmacg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmacg.Enabled = false;
            this.txtmacg.Location = new System.Drawing.Point(330, 24);
            this.txtmacg.Name = "txtmacg";
            this.txtmacg.Size = new System.Drawing.Size(68, 20);
            this.txtmacg.TabIndex = 37;
            this.txtmacg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmacg_KeyUp);
            // 
            // rdbthucong
            // 
            this.rdbthucong.AutoSize = true;
            this.rdbthucong.Location = new System.Drawing.Point(640, 24);
            this.rdbthucong.Name = "rdbthucong";
            this.rdbthucong.Size = new System.Drawing.Size(96, 17);
            this.rdbthucong.TabIndex = 4;
            this.rdbthucong.Text = "Nhập thủ công";
            this.rdbthucong.UseVisualStyleBackColor = true;
            // 
            // rdbtudong
            // 
            this.rdbtudong.AutoSize = true;
            this.rdbtudong.Checked = true;
            this.rdbtudong.Location = new System.Drawing.Point(530, 24);
            this.rdbtudong.Name = "rdbtudong";
            this.rdbtudong.Size = new System.Drawing.Size(107, 17);
            this.rdbtudong.TabIndex = 2;
            this.rdbtudong.TabStop = true;
            this.rdbtudong.Text = "Số phiếu tự động";
            this.rdbtudong.UseVisualStyleBackColor = true;
            // 
            // txtnhanvien
            // 
            this.txtnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnhanvien.Location = new System.Drawing.Point(96, 22);
            this.txtnhanvien.Name = "txtnhanvien";
            this.txtnhanvien.Size = new System.Drawing.Size(100, 20);
            this.txtnhanvien.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhân viên nhập";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bưu cục";
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDoubleClick);
            // 
            // txtbuucuc
            // 
            this.txtbuucuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbuucuc.Location = new System.Drawing.Point(253, 23);
            this.txtbuucuc.Name = "txtbuucuc";
            this.txtbuucuc.Size = new System.Drawing.Size(72, 20);
            this.txtbuucuc.TabIndex = 32;
            // 
            // btnina5
            // 
            this.btnina5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnina5.Location = new System.Drawing.Point(798, 433);
            this.btnina5.Name = "btnina5";
            this.btnina5.Size = new System.Drawing.Size(53, 23);
            this.btnina5.TabIndex = 24;
            this.btnina5.Text = "In A5";
            this.btnina5.UseVisualStyleBackColor = true;
            this.btnina5.Click += new System.EventHandler(this.btnina5_Click);
            // 
            // btnlien
            // 
            this.btnlien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnlien.Location = new System.Drawing.Point(859, 433);
            this.btnlien.Name = "btnlien";
            this.btnlien.Size = new System.Drawing.Size(52, 23);
            this.btnlien.TabIndex = 25;
            this.btnlien.Text = "In Kim";
            this.btnlien.UseVisualStyleBackColor = true;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexcel.Location = new System.Drawing.Point(1000, 433);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(74, 23);
            this.btnexcel.TabIndex = 26;
            this.btnexcel.Text = "Xuất excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dsProvinces
            // 
            this.dsProvinces.DataSetName = "DsProvinces";
            this.dsProvinces.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtfolder
            // 
            this.txtfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtfolder.Location = new System.Drawing.Point(544, 433);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(100, 20);
            this.txtfolder.TabIndex = 27;
            this.txtfolder.Text = "D:\\InCG";
            // 
            // dtppgi
            // 
            this.dtppgi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtppgi.Location = new System.Drawing.Point(75, 24);
            this.dtppgi.Name = "dtppgi";
            this.dtppgi.Size = new System.Drawing.Size(80, 20);
            this.dtppgi.TabIndex = 28;
            // 
            // btnbaophat
            // 
            this.btnbaophat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbaophat.Location = new System.Drawing.Point(917, 433);
            this.btnbaophat.Name = "btnbaophat";
            this.btnbaophat.Size = new System.Drawing.Size(74, 23);
            this.btnbaophat.TabIndex = 29;
            this.btnbaophat.Text = "In báo phát";
            this.btnbaophat.UseVisualStyleBackColor = true;
            this.btnbaophat.Click += new System.EventHandler(this.btnbaophat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày nhập";
            // 
            // txtsoluongin
            // 
            this.txtsoluongin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtsoluongin.Location = new System.Drawing.Point(725, 433);
            this.txtsoluongin.Name = "txtsoluongin";
            this.txtsoluongin.Size = new System.Drawing.Size(67, 20);
            this.txtsoluongin.TabIndex = 35;
            this.txtsoluongin.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số lượng in";
            // 
            // btnbangke
            // 
            this.btnbangke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbangke.Location = new System.Drawing.Point(1080, 433);
            this.btnbangke.Name = "btnbangke";
            this.btnbangke.Size = new System.Drawing.Size(74, 23);
            this.btnbangke.TabIndex = 37;
            this.btnbangke.Text = "In bảng kê";
            this.btnbangke.UseVisualStyleBackColor = true;
            this.btnbangke.Click += new System.EventHandler(this.btnbangke_Click);
            // 
            // myGrid1
            // 
            this.myGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Acceptdate,
            this.MailerID,
            this.Mailertypeid,
            this.Servicetypeid,
            this.Quantity,
            this.Weight,
            this.Realweight,
            this.Sender,
            this.SenderAddress,
            this.SenderPhone,
            this.ReciverName,
            this.Address,
            this.Provinceid,
            this.Price,
            this.Priceservice,
            this.Timer,
            this.Districtid,
            this.ReciverPhone,
            this.Description,
            this.BP,
            this.ProvinceName,
            this.DistrictName});
            this.myGrid1.Location = new System.Drawing.Point(9, 62);
            this.myGrid1.Name = "myGrid1";
            this.myGrid1.Size = new System.Drawing.Size(1164, 365);
            this.myGrid1.TabIndex = 22;
            this.myGrid1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.myGrid1_CellEnter);
            this.myGrid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.myGrid1_CellFormatting);
            this.myGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.myGrid1_CellMouseClick);
            this.myGrid1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.myGrid1_CellValidating);
            this.myGrid1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.myGrid1_DefaultValuesNeeded);
            this.myGrid1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.myGrid1_EditingControlShowing);
            this.myGrid1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.myGrid1_RowLeave);
            this.myGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myGrid1_KeyDown);
            // 
            // Acceptdate
            // 
            this.Acceptdate.HeaderText = "Ngày";
            this.Acceptdate.Name = "Acceptdate";
            this.Acceptdate.Width = 80;
            // 
            // MailerID
            // 
            this.MailerID.HeaderText = "Số phiếu";
            this.MailerID.Name = "MailerID";
            this.MailerID.ReadOnly = true;
            this.MailerID.Width = 90;
            // 
            // Mailertypeid
            // 
            this.Mailertypeid.HeaderText = "LH";
            this.Mailertypeid.Name = "Mailertypeid";
            this.Mailertypeid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mailertypeid.Width = 30;
            // 
            // Servicetypeid
            // 
            this.Servicetypeid.HeaderText = "DV";
            this.Servicetypeid.Name = "Servicetypeid";
            this.Servicetypeid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Servicetypeid.Width = 30;
            // 
            // Quantity
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantity.HeaderText = "SL";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 40;
            // 
            // Weight
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle2;
            this.Weight.HeaderText = "TL";
            this.Weight.Name = "Weight";
            this.Weight.Width = 60;
            // 
            // Realweight
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Realweight.DefaultCellStyle = dataGridViewCellStyle3;
            this.Realweight.HeaderText = "TL khối";
            this.Realweight.Name = "Realweight";
            this.Realweight.Width = 70;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Người gửi";
            this.Sender.Name = "Sender";
            this.Sender.Width = 80;
            // 
            // SenderAddress
            // 
            this.SenderAddress.HeaderText = "Địa chỉ gửi";
            this.SenderAddress.Name = "SenderAddress";
            // 
            // SenderPhone
            // 
            this.SenderPhone.HeaderText = "SĐT gửi";
            this.SenderPhone.Name = "SenderPhone";
            this.SenderPhone.Width = 80;
            // 
            // ReciverName
            // 
            this.ReciverName.HeaderText = "Người nhận";
            this.ReciverName.Name = "ReciverName";
            this.ReciverName.Width = 80;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ nhận";
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // Provinceid
            // 
            this.Provinceid.DataPropertyName = "ProvinceID";
            this.Provinceid.HeaderText = "Thành phố";
            this.Provinceid.Name = "Provinceid";
            this.Provinceid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Provinceid.Width = 85;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cước";
            this.Price.Name = "Price";
            this.Price.Width = 60;
            // 
            // Priceservice
            // 
            this.Priceservice.HeaderText = "Thu #";
            this.Priceservice.Name = "Priceservice";
            this.Priceservice.Width = 60;
            // 
            // Timer
            // 
            this.Timer.HeaderText = "Hẹn giờ";
            this.Timer.Name = "Timer";
            this.Timer.Width = 60;
            // 
            // Districtid
            // 
            this.Districtid.HeaderText = "Quận/Huyện";
            this.Districtid.Name = "Districtid";
            this.Districtid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Districtid.Width = 75;
            // 
            // ReciverPhone
            // 
            this.ReciverPhone.HeaderText = "SĐT nhận";
            this.ReciverPhone.Name = "ReciverPhone";
            this.ReciverPhone.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Ghi chú";
            this.Description.Name = "Description";
            // 
            // BP
            // 
            this.BP.HeaderText = "BP";
            this.BP.Name = "BP";
            this.BP.Width = 30;
            // 
            // ProvinceName
            // 
            this.ProvinceName.HeaderText = "Tên tỉnh thành";
            this.ProvinceName.Name = "ProvinceName";
            this.ProvinceName.Visible = false;
            // 
            // DistrictName
            // 
            this.DistrictName.HeaderText = "Tên quận huyện";
            this.DistrictName.Name = "DistrictName";
            this.DistrictName.Visible = false;
            // 
            // CG1_LE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 459);
            this.Controls.Add(this.btnbangke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoluongin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbaophat);
            this.Controls.Add(this.dtppgi);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnlien);
            this.Controls.Add(this.btnina5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.myGrid1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CG1_LE";
            this.Text = "In phiếu gửi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CG1_LE_FormClosing);
            this.Load += new System.EventHandler(this.CG1_LE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProvinces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtinlien;
        private MyGrid myGrid1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbthucong;
        private System.Windows.Forms.RadioButton rdbtudong;
        private System.Windows.Forms.Button btnina5;
        private System.Windows.Forms.Button btnlien;
        private System.Windows.Forms.Button btnexcel;
        private DsProvinces dsProvinces;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.DateTimePicker dtppgi;
        private System.Windows.Forms.Button btnbaophat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluongin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsophieu;
        private System.Windows.Forms.TextBox txtmacg;
        private System.Windows.Forms.TextBox txtnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuucuc;
        private System.Windows.Forms.Button btnbangke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceptdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mailertypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicetypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provinceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priceservice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Districtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn BP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
    }
}