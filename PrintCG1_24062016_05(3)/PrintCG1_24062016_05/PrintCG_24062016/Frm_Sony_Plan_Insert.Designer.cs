namespace PrintCG_24062016
{
    partial class Frm_Sony_Plan_Insert
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
            this.cmbmaterial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbquatity = new System.Windows.Forms.ComboBox();
            this.cmbweight = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbstreet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbparty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.cmbsheet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.btnchonfile = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtppgi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtppgi);
            this.groupBox1.Controls.Add(this.cmbmaterial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbquatity);
            this.groupBox1.Controls.Add(this.cmbweight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbstreet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbdo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbparty);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnxem);
            this.groupBox1.Controls.Add(this.cmbsheet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblfile);
            this.groupBox1.Controls.Add(this.btnchonfile);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết plan";
            // 
            // cmbmaterial
            // 
            this.cmbmaterial.FormattingEnabled = true;
            this.cmbmaterial.Location = new System.Drawing.Point(856, 71);
            this.cmbmaterial.Name = "cmbmaterial";
            this.cmbmaterial.Size = new System.Drawing.Size(120, 21);
            this.cmbmaterial.TabIndex = 78;
            this.cmbmaterial.Enter += new System.EventHandler(this.cmbmaterial_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Quatity";
            // 
            // cmbquatity
            // 
            this.cmbquatity.FormattingEnabled = true;
            this.cmbquatity.Location = new System.Drawing.Point(370, 98);
            this.cmbquatity.Name = "cmbquatity";
            this.cmbquatity.Size = new System.Drawing.Size(74, 21);
            this.cmbquatity.TabIndex = 74;
            this.cmbquatity.Enter += new System.EventHandler(this.cmbquatity_Enter);
            // 
            // cmbweight
            // 
            this.cmbweight.FormattingEnabled = true;
            this.cmbweight.Location = new System.Drawing.Point(199, 98);
            this.cmbweight.Name = "cmbweight";
            this.cmbweight.Size = new System.Drawing.Size(88, 21);
            this.cmbweight.TabIndex = 68;
            this.cmbweight.Enter += new System.EventHandler(this.cmbweight_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Gross weight";
            // 
            // cmbstreet
            // 
            this.cmbstreet.FormattingEnabled = true;
            this.cmbstreet.Location = new System.Drawing.Point(524, 71);
            this.cmbstreet.Name = "cmbstreet";
            this.cmbstreet.Size = new System.Drawing.Size(80, 21);
            this.cmbstreet.TabIndex = 66;
            this.cmbstreet.Enter += new System.EventHandler(this.cmbstreet_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ship to street";
            // 
            // cmbname
            // 
            this.cmbname.FormattingEnabled = true;
            this.cmbname.Location = new System.Drawing.Point(370, 71);
            this.cmbname.Name = "cmbname";
            this.cmbname.Size = new System.Drawing.Size(74, 21);
            this.cmbname.TabIndex = 64;
            this.cmbname.Enter += new System.EventHandler(this.cmbname_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Ship to Name";
            // 
            // cmbdo
            // 
            this.cmbdo.FormattingEnabled = true;
            this.cmbdo.Location = new System.Drawing.Point(49, 71);
            this.cmbdo.Name = "cmbdo";
            this.cmbdo.Size = new System.Drawing.Size(71, 21);
            this.cmbdo.TabIndex = 49;
            this.cmbdo.Enter += new System.EventHandler(this.cmbdo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "D/0";
            // 
            // cmbparty
            // 
            this.cmbparty.FormattingEnabled = true;
            this.cmbparty.Location = new System.Drawing.Point(199, 71);
            this.cmbparty.Name = "cmbparty";
            this.cmbparty.Size = new System.Drawing.Size(88, 21);
            this.cmbparty.TabIndex = 56;
            this.cmbparty.Enter += new System.EventHandler(this.cmbparty_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Ship to party";
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(333, 44);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(121, 23);
            this.btnxem.TabIndex = 12;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // cmbsheet
            // 
            this.cmbsheet.FormattingEnabled = true;
            this.cmbsheet.Location = new System.Drawing.Point(76, 45);
            this.cmbsheet.Name = "cmbsheet";
            this.cmbsheet.Size = new System.Drawing.Size(251, 21);
            this.cmbsheet.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chọn sheet";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(136, 21);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(96, 13);
            this.lblfile.TabIndex = 9;
            this.lblfile.Text = "Bạn chưa chọn file";
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(9, 16);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(121, 23);
            this.btnchonfile.TabIndex = 8;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(638, 42);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(121, 23);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "Cập nhật plan";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dtppgi
            // 
            this.dtppgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtppgi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtppgi.Location = new System.Drawing.Point(527, 45);
            this.dtppgi.Name = "dtppgi";
            this.dtppgi.Size = new System.Drawing.Size(93, 20);
            this.dtppgi.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Ngày ";
            // 
            // cmbcity
            // 
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(673, 71);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(120, 21);
            this.cmbcity.TabIndex = 82;
            this.cmbcity.Enter += new System.EventHandler(this.cmbcity_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Ship to city";
            // 
            // Frm_Sony_Plan_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Sony_Plan_Insert";
            this.Text = "Frm_Sony_Plan_Insert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Sony_Plan_Insert_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Sony_Plan_Insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbweight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbstreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbparty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ComboBox cmbsheet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbquatity;
        private System.Windows.Forms.ComboBox cmbmaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtppgi;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.Label label9;
    }
}