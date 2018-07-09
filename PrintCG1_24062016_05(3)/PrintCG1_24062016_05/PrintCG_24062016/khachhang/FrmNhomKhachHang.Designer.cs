namespace PrintCG_24062016.khachhang
{
    partial class FrmNhomKhachHang
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
            this.xóaDòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txttaxcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgroupid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TaxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xóaDòngToolStripMenuItem
            // 
            this.xóaDòngToolStripMenuItem.Name = "xóaDòngToolStripMenuItem";
            this.xóaDòngToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.xóaDòngToolStripMenuItem.Text = "Xóa dòng";
            this.xóaDòngToolStripMenuItem.Click += new System.EventHandler(this.xóaDòngToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1283, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtpost
            // 
            this.txtpost.Location = new System.Drawing.Point(662, 13);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(176, 22);
            this.txtpost.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã BC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1277, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm mã";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(876, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã khách hàng";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(985, 12);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(268, 24);
            this.cmbcustomer.TabIndex = 11;
            this.cmbcustomer.Enter += new System.EventHandler(this.cmbcustomer_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(602, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 525);
            this.dataGridView1.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDòngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 28);
            // 
            // txttaxcode
            // 
            this.txttaxcode.Location = new System.Drawing.Point(90, 196);
            this.txttaxcode.Name = "txttaxcode";
            this.txttaxcode.Size = new System.Drawing.Size(208, 22);
            this.txttaxcode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "MST";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(90, 168);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(208, 22);
            this.txtphone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điện thoại";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(90, 107);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(417, 55);
            this.txtaddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 46);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(417, 55);
            this.txtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm";
            // 
            // txtgroupid
            // 
            this.txtgroupid.Location = new System.Drawing.Point(90, 18);
            this.txtgroupid.Name = "txtgroupid";
            this.txtgroupid.Size = new System.Drawing.Size(208, 22);
            this.txtgroupid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtpost);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbcustomer);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txttaxcode);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtphone);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtaddress);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtgroupid);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TaxCode
            // 
            this.TaxCode.HeaderText = "Mã số thuế";
            this.TaxCode.Name = "TaxCode";
            this.TaxCode.ReadOnly = true;
            this.TaxCode.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Số ĐT";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 250;
            // 
            // GName
            // 
            this.GName.HeaderText = "Tên khách hàng";
            this.GName.Name = "GName";
            this.GName.ReadOnly = true;
            this.GName.Width = 300;
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "Mã nhóm";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GName,
            this.Address,
            this.Phone,
            this.TaxCode});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1141, 588);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1155, 623);
            this.tabControl1.TabIndex = 1;
            // 
            // FrmNhomKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmNhomKhachHang";
            this.Text = "FrmNhomKhachHang";
            this.Load += new System.EventHandler(this.FrmNhomKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem xóaDòngToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txttaxcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgroupid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}