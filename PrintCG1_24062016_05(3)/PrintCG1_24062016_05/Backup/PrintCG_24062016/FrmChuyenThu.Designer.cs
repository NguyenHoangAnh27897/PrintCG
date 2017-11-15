namespace PrintCG_24062016
{
    partial class FrmChuyenThu
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
            this.tabdanhmuc = new System.Windows.Forms.TabPage();
            this.btnchuyenct = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabthaotac = new System.Windows.Forms.TabPage();
            this.btnmaxid = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmailerid = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotalmailer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumberpackge = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbempoyeeid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuucuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdocumentid = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MailerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieverProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabdanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabthaotac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabdanhmuc);
            this.tabControl1.Controls.Add(this.tabthaotac);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabdanhmuc
            // 
            this.tabdanhmuc.Controls.Add(this.btnchuyenct);
            this.tabdanhmuc.Controls.Add(this.btnxem);
            this.tabdanhmuc.Controls.Add(this.label2);
            this.tabdanhmuc.Controls.Add(this.dtptodate);
            this.tabdanhmuc.Controls.Add(this.label1);
            this.tabdanhmuc.Controls.Add(this.dtpfromdate);
            this.tabdanhmuc.Controls.Add(this.dataGridView1);
            this.tabdanhmuc.Location = new System.Drawing.Point(4, 22);
            this.tabdanhmuc.Name = "tabdanhmuc";
            this.tabdanhmuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabdanhmuc.Size = new System.Drawing.Size(774, 506);
            this.tabdanhmuc.TabIndex = 0;
            this.tabdanhmuc.Text = "Danh muc";
            this.tabdanhmuc.UseVisualStyleBackColor = true;
            // 
            // btnchuyenct
            // 
            this.btnchuyenct.Location = new System.Drawing.Point(388, 9);
            this.btnchuyenct.Name = "btnchuyenct";
            this.btnchuyenct.Size = new System.Drawing.Size(117, 23);
            this.btnchuyenct.TabIndex = 6;
            this.btnchuyenct.Text = "Chuyển chuyến thư";
            this.btnchuyenct.UseVisualStyleBackColor = true;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(309, 9);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 5;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // dtptodate
            // 
            this.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptodate.Location = new System.Drawing.Point(216, 10);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(81, 20);
            this.dtptodate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromdate.Location = new System.Drawing.Point(60, 11);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(81, 20);
            this.dtpfromdate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabthaotac
            // 
            this.tabthaotac.Controls.Add(this.btnmaxid);
            this.tabthaotac.Controls.Add(this.label12);
            this.tabthaotac.Controls.Add(this.txtmailerid);
            this.tabthaotac.Controls.Add(this.btnluu);
            this.tabthaotac.Controls.Add(this.label11);
            this.tabthaotac.Controls.Add(this.txtdescription);
            this.tabthaotac.Controls.Add(this.label10);
            this.tabthaotac.Controls.Add(this.txtweight);
            this.tabthaotac.Controls.Add(this.label9);
            this.tabthaotac.Controls.Add(this.txtquantity);
            this.tabthaotac.Controls.Add(this.label8);
            this.tabthaotac.Controls.Add(this.txttotalmailer);
            this.tabthaotac.Controls.Add(this.label7);
            this.tabthaotac.Controls.Add(this.txtnumberpackge);
            this.tabthaotac.Controls.Add(this.dtpdate);
            this.tabthaotac.Controls.Add(this.label6);
            this.tabthaotac.Controls.Add(this.cmbempoyeeid);
            this.tabthaotac.Controls.Add(this.label5);
            this.tabthaotac.Controls.Add(this.label4);
            this.tabthaotac.Controls.Add(this.txtbuucuc);
            this.tabthaotac.Controls.Add(this.label3);
            this.tabthaotac.Controls.Add(this.txtdocumentid);
            this.tabthaotac.Controls.Add(this.dataGridView2);
            this.tabthaotac.Location = new System.Drawing.Point(4, 22);
            this.tabthaotac.Name = "tabthaotac";
            this.tabthaotac.Padding = new System.Windows.Forms.Padding(3);
            this.tabthaotac.Size = new System.Drawing.Size(774, 506);
            this.tabthaotac.TabIndex = 1;
            this.tabthaotac.Text = "Thao tác";
            this.tabthaotac.UseVisualStyleBackColor = true;
            // 
            // btnmaxid
            // 
            this.btnmaxid.Location = new System.Drawing.Point(196, 6);
            this.btnmaxid.Name = "btnmaxid";
            this.btnmaxid.Size = new System.Drawing.Size(20, 23);
            this.btnmaxid.TabIndex = 23;
            this.btnmaxid.Text = "*";
            this.btnmaxid.UseVisualStyleBackColor = true;
            this.btnmaxid.Click += new System.EventHandler(this.btnmaxid_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số phiếu";
            // 
            // txtmailerid
            // 
            this.txtmailerid.Location = new System.Drawing.Point(63, 80);
            this.txtmailerid.Name = "txtmailerid";
            this.txtmailerid.Size = new System.Drawing.Size(129, 20);
            this.txtmailerid.TabIndex = 21;
            this.txtmailerid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmailerid_KeyDown);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(691, 9);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 20;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ghi chú";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(448, 55);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(316, 20);
            this.txtdescription.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trọng lượng";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(448, 31);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(96, 20);
            this.txtweight.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(448, 7);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(96, 20);
            this.txtquantity.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng CG";
            // 
            // txttotalmailer
            // 
            this.txttotalmailer.Location = new System.Drawing.Point(278, 54);
            this.txttotalmailer.Name = "txttotalmailer";
            this.txttotalmailer.Size = new System.Drawing.Size(96, 20);
            this.txttotalmailer.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số túi";
            // 
            // txtnumberpackge
            // 
            this.txtnumberpackge.Location = new System.Drawing.Point(278, 31);
            this.txtnumberpackge.Name = "txtnumberpackge";
            this.txtnumberpackge.Size = new System.Drawing.Size(96, 20);
            this.txtnumberpackge.TabIndex = 10;
            this.txtnumberpackge.Text = "1";
            // 
            // dtpdate
            // 
            this.dtpdate.Enabled = false;
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(278, 7);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(96, 20);
            this.dtpdate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày giờ";
            // 
            // cmbempoyeeid
            // 
            this.cmbempoyeeid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbempoyeeid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbempoyeeid.FormattingEnabled = true;
            this.cmbempoyeeid.Location = new System.Drawing.Point(63, 53);
            this.cmbempoyeeid.Name = "cmbempoyeeid";
            this.cmbempoyeeid.Size = new System.Drawing.Size(129, 21);
            this.cmbempoyeeid.TabIndex = 7;
            this.cmbempoyeeid.Enter += new System.EventHandler(this.cmbempoyeeid_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bưu cục";
            // 
            // txtbuucuc
            // 
            this.txtbuucuc.Location = new System.Drawing.Point(63, 30);
            this.txtbuucuc.Name = "txtbuucuc";
            this.txtbuucuc.Size = new System.Drawing.Size(129, 20);
            this.txtbuucuc.TabIndex = 3;
            this.txtbuucuc.Text = "KV04";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chứng từ";
            // 
            // txtdocumentid
            // 
            this.txtdocumentid.Enabled = false;
            this.txtdocumentid.Location = new System.Drawing.Point(63, 7);
            this.txtdocumentid.Name = "txtdocumentid";
            this.txtdocumentid.Size = new System.Drawing.Size(129, 20);
            this.txtdocumentid.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailerID,
            this.Quantity,
            this.Weight,
            this.RealWeight,
            this.RecieverProvince,
            this.Description});
            this.dataGridView2.Location = new System.Drawing.Point(8, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(758, 384);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // MailerID
            // 
            this.MailerID.HeaderText = "Số phiếu";
            this.MailerID.Name = "MailerID";
            this.MailerID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Trọng lượng";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // RealWeight
            // 
            this.RealWeight.HeaderText = "TL khối";
            this.RealWeight.Name = "RealWeight";
            this.RealWeight.ReadOnly = true;
            // 
            // RecieverProvince
            // 
            this.RecieverProvince.HeaderText = "Nơi đến";
            this.RecieverProvince.Name = "RecieverProvince";
            this.RecieverProvince.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Ghi chú";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmChuyenThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmChuyenThu";
            this.Text = "FrmChuyenThu";
            this.Load += new System.EventHandler(this.FrmChuyenThu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabdanhmuc.ResumeLayout(false);
            this.tabdanhmuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabthaotac.ResumeLayout(false);
            this.tabthaotac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabdanhmuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabthaotac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.Button btnchuyenct;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuucuc;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumberpackge;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbempoyeeid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalmailer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmailerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieverProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdocumentid;
        private System.Windows.Forms.Button btnmaxid;
        private System.Windows.Forms.Timer timer1;
    }
}