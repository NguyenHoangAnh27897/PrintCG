namespace PrintCG_24062016
{
    partial class FrmBCSLMsYen
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
            this.cbbdate = new System.Windows.Forms.ComboBox();
            this.chkctv = new System.Windows.Forms.CheckBox();
            this.txtdenngay = new System.Windows.Forms.DateTimePicker();
            this.txttungay = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtbc = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbdata = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.bcthang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnxembaocao = new System.Windows.Forms.Button();
            this.txttongcg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttongsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttongtl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttongdt = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcthang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbdate
            // 
            this.cbbdate.FormattingEnabled = true;
            this.cbbdate.Items.AddRange(new object[] {
            "Ngày chứng từ",
            "Ngày phát sinh doanh thu"});
            this.cbbdate.Location = new System.Drawing.Point(413, 15);
            this.cbbdate.Name = "cbbdate";
            this.cbbdate.Size = new System.Drawing.Size(119, 21);
            this.cbbdate.TabIndex = 23;
            // 
            // chkctv
            // 
            this.chkctv.AutoSize = true;
            this.chkctv.Location = new System.Drawing.Point(178, 46);
            this.chkctv.Name = "chkctv";
            this.chkctv.Size = new System.Drawing.Size(47, 17);
            this.chkctv.TabIndex = 21;
            this.chkctv.Text = "CTV";
            this.chkctv.UseVisualStyleBackColor = true;
            // 
            // txtdenngay
            // 
            this.txtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdenngay.Location = new System.Drawing.Point(234, 16);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(103, 20);
            this.txtdenngay.TabIndex = 20;
            // 
            // txttungay
            // 
            this.txttungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txttungay.Location = new System.Drawing.Point(64, 16);
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(103, 20);
            this.txttungay.TabIndex = 19;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 44);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Mã BC";
            // 
            // txtbc
            // 
            this.txtbc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbc.Location = new System.Drawing.Point(64, 42);
            this.txtbc.Name = "txtbc";
            this.txtbc.Size = new System.Drawing.Size(103, 20);
            this.txtbc.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(175, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Đến ngày";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(627, 413);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(189, 20);
            this.txttongtien.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Từ ngày";
            // 
            // cmbdata
            // 
            this.cmbdata.FormattingEnabled = true;
            this.cmbdata.Items.AddRange(new object[] {
            "Dữ liệu chính",
            "Dữ liệu BK"});
            this.cmbdata.Location = new System.Drawing.Point(413, 42);
            this.cmbdata.Name = "cmbdata";
            this.cmbdata.Size = new System.Drawing.Size(119, 21);
            this.cmbdata.TabIndex = 22;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.txttongtien);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.txttongdt);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.txttongtl);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.txttongsl);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Controls.Add(this.txttongcg);
            this.GroupBox2.Controls.Add(this.bcthang);
            this.GroupBox2.Location = new System.Drawing.Point(3, 69);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(822, 447);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Báo cáo tháng";
            // 
            // bcthang
            // 
            this.bcthang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcthang.Location = new System.Drawing.Point(7, 19);
            this.bcthang.Name = "bcthang";
            this.bcthang.Size = new System.Drawing.Size(809, 388);
            this.bcthang.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Theo ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dữ liệu";
            // 
            // btnxembaocao
            // 
            this.btnxembaocao.Location = new System.Drawing.Point(567, 34);
            this.btnxembaocao.Name = "btnxembaocao";
            this.btnxembaocao.Size = new System.Drawing.Size(57, 23);
            this.btnxembaocao.TabIndex = 6;
            this.btnxembaocao.Text = "Xem";
            this.btnxembaocao.UseVisualStyleBackColor = true;
            this.btnxembaocao.Click += new System.EventHandler(this.btnxembaocao_Click);
            // 
            // txttongcg
            // 
            this.txttongcg.Location = new System.Drawing.Point(68, 413);
            this.txttongcg.Name = "txttongcg";
            this.txttongcg.Size = new System.Drawing.Size(78, 20);
            this.txttongcg.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng CG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tổng SL";
            // 
            // txttongsl
            // 
            this.txttongsl.Location = new System.Drawing.Point(211, 413);
            this.txttongsl.Name = "txttongsl";
            this.txttongsl.Size = new System.Drawing.Size(78, 20);
            this.txttongsl.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tổng TL";
            // 
            // txttongtl
            // 
            this.txttongtl.Location = new System.Drawing.Point(349, 413);
            this.txttongtl.Name = "txttongtl";
            this.txttongtl.Size = new System.Drawing.Size(78, 20);
            this.txttongtl.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tổng DT";
            // 
            // txttongdt
            // 
            this.txttongdt.Location = new System.Drawing.Point(498, 413);
            this.txttongdt.Name = "txttongdt";
            this.txttongdt.Size = new System.Drawing.Size(123, 20);
            this.txttongdt.TabIndex = 34;
            // 
            // FrmBCSLMsYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 528);
            this.Controls.Add(this.btnxembaocao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbdate);
            this.Controls.Add(this.chkctv);
            this.Controls.Add(this.txtdenngay);
            this.Controls.Add(this.txttungay);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtbc);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmbdata);
            this.Controls.Add(this.GroupBox2);
            this.Name = "FrmBCSLMsYen";
            this.Text = "BCSLMsYen";
            this.Load += new System.EventHandler(this.FrmBCSLMsYen_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcthang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbbdate;
        internal System.Windows.Forms.CheckBox chkctv;
        internal System.Windows.Forms.DateTimePicker txtdenngay;
        internal System.Windows.Forms.DateTimePicker txttungay;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtbc;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txttongtien;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbdata;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView bcthang;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btnxembaocao;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txttongdt;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txttongtl;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txttongsl;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txttongcg;

    }
}