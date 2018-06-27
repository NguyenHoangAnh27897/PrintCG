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
            this.Button2 = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmbdata = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.bcthang = new System.Windows.Forms.DataGridView();
            this.txtdsgb = new System.Windows.Forms.TextBox();
            this.txtdtgb = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.bcgiaoban = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcthang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcgiaoban)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbdate
            // 
            this.cbbdate.FormattingEnabled = true;
            this.cbbdate.Items.AddRange(new object[] {
            "Ngày chứng từ",
            "Ngày phát sinh doanh thu"});
            this.cbbdate.Location = new System.Drawing.Point(341, 15);
            this.cbbdate.Name = "cbbdate";
            this.cbbdate.Size = new System.Drawing.Size(137, 21);
            this.cbbdate.TabIndex = 23;
            // 
            // chkctv
            // 
            this.chkctv.AutoSize = true;
            this.chkctv.Location = new System.Drawing.Point(635, 19);
            this.chkctv.Name = "chkctv";
            this.chkctv.Size = new System.Drawing.Size(47, 17);
            this.chkctv.TabIndex = 21;
            this.chkctv.Text = "CTV";
            this.chkctv.UseVisualStyleBackColor = true;
            // 
            // txtdenngay
            // 
            this.txtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdenngay.Location = new System.Drawing.Point(232, 16);
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
            this.Label5.Location = new System.Drawing.Point(484, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Mã BC";
            // 
            // txtbc
            // 
            this.txtbc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbc.Location = new System.Drawing.Point(529, 16);
            this.txtbc.Name = "txtbc";
            this.txtbc.Size = new System.Drawing.Size(100, 20);
            this.txtbc.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(173, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Đến ngày";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(307, 414);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(56, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Xem";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(50, 416);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(251, 20);
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
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 418);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Tổng";
            // 
            // cmbdata
            // 
            this.cmbdata.FormattingEnabled = true;
            this.cmbdata.Items.AddRange(new object[] {
            "Dữ liệu chính",
            "Dữ liệu BK"});
            this.cmbdata.Location = new System.Drawing.Point(688, 15);
            this.cmbdata.Name = "cmbdata";
            this.cmbdata.Size = new System.Drawing.Size(121, 21);
            this.cmbdata.TabIndex = 22;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.txttongtien);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.bcthang);
            this.GroupBox2.Location = new System.Drawing.Point(390, 50);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(425, 446);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Báo cáo tháng";
            // 
            // bcthang
            // 
            this.bcthang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcthang.Location = new System.Drawing.Point(7, 29);
            this.bcthang.Name = "bcthang";
            this.bcthang.Size = new System.Drawing.Size(412, 378);
            this.bcthang.TabIndex = 1;
            // 
            // txtdsgb
            // 
            this.txtdsgb.Location = new System.Drawing.Point(61, 416);
            this.txtdsgb.Name = "txtdsgb";
            this.txtdsgb.Size = new System.Drawing.Size(113, 20);
            this.txtdsgb.TabIndex = 5;
            // 
            // txtdtgb
            // 
            this.txtdtgb.Location = new System.Drawing.Point(180, 417);
            this.txtdtgb.Name = "txtdtgb";
            this.txtdtgb.Size = new System.Drawing.Size(113, 20);
            this.txtdtgb.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(4, 419);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Tổng";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(299, 417);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(57, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Xem";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // bcgiaoban
            // 
            this.bcgiaoban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcgiaoban.Location = new System.Drawing.Point(7, 29);
            this.bcgiaoban.Name = "bcgiaoban";
            this.bcgiaoban.Size = new System.Drawing.Size(358, 378);
            this.bcgiaoban.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtdsgb);
            this.GroupBox1.Controls.Add(this.txtdtgb);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.bcgiaoban);
            this.GroupBox1.Location = new System.Drawing.Point(13, 50);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(371, 446);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Báo cáo giao ban";
            // 
            // BCSLMsYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 514);
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
            this.Controls.Add(this.GroupBox1);
            this.Name = "BCSLMsYen";
            this.Text = "BCSLMsYen";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcthang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcgiaoban)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
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
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txttongtien;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cmbdata;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView bcthang;
        internal System.Windows.Forms.TextBox txtdsgb;
        internal System.Windows.Forms.TextBox txtdtgb;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView bcgiaoban;
        internal System.Windows.Forms.GroupBox GroupBox1;

    }
}