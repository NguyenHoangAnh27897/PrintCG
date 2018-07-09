namespace PrintCG_24062016.ChuyenDoiDuLieu
{
    partial class FrmExcelToFox
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbsheet = new System.Windows.Forms.ComboBox();
            this.btnchonfile = new System.Windows.Forms.Button();
            this.btnnoiluu = new System.Windows.Forms.Button();
            this.btnchuyenfox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfilenguon = new System.Windows.Forms.Label();
            this.lblfiledich = new System.Windows.Forms.Label();
            this.lblsodong = new System.Windows.Forms.Label();
            this.txtnhan = new System.Windows.Forms.TextBox();
            this.txtphat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnhan = new System.Windows.Forms.RadioButton();
            this.rdbphat = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn sheet";
            // 
            // cbbsheet
            // 
            this.cbbsheet.FormattingEnabled = true;
            this.cbbsheet.Location = new System.Drawing.Point(76, 33);
            this.cbbsheet.Name = "cbbsheet";
            this.cbbsheet.Size = new System.Drawing.Size(121, 21);
            this.cbbsheet.TabIndex = 0;
            this.cbbsheet.SelectedValueChanged += new System.EventHandler(this.cbbsheet_SelectedValueChanged);
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(76, 6);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(121, 23);
            this.btnchonfile.TabIndex = 2;
            this.btnchonfile.Text = "Chọn file excel";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // btnnoiluu
            // 
            this.btnnoiluu.Location = new System.Drawing.Point(76, 59);
            this.btnnoiluu.Name = "btnnoiluu";
            this.btnnoiluu.Size = new System.Drawing.Size(121, 23);
            this.btnnoiluu.TabIndex = 3;
            this.btnnoiluu.Text = "Chọn nơi lưu";
            this.btnnoiluu.UseVisualStyleBackColor = true;
            this.btnnoiluu.Click += new System.EventHandler(this.btnnoiluu_Click);
            // 
            // btnchuyenfox
            // 
            this.btnchuyenfox.Location = new System.Drawing.Point(203, 6);
            this.btnchuyenfox.Name = "btnchuyenfox";
            this.btnchuyenfox.Size = new System.Drawing.Size(147, 76);
            this.btnchuyenfox.TabIndex = 4;
            this.btnchuyenfox.Text = "Chuyển Excel ==> Foxpro";
            this.btnchuyenfox.UseVisualStyleBackColor = true;
            this.btnchuyenfox.Click += new System.EventHandler(this.btnchuyenfox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File nguồn :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Fox table (*.dbf)|*.dbf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File đích :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số cột / dòng :";
            // 
            // lblfilenguon
            // 
            this.lblfilenguon.AutoSize = true;
            this.lblfilenguon.Location = new System.Drawing.Point(139, 87);
            this.lblfilenguon.Name = "lblfilenguon";
            this.lblfilenguon.Size = new System.Drawing.Size(16, 13);
            this.lblfilenguon.TabIndex = 8;
            this.lblfilenguon.Text = "...";
            // 
            // lblfiledich
            // 
            this.lblfiledich.AutoSize = true;
            this.lblfiledich.Location = new System.Drawing.Point(139, 109);
            this.lblfiledich.Name = "lblfiledich";
            this.lblfiledich.Size = new System.Drawing.Size(16, 13);
            this.lblfiledich.TabIndex = 9;
            this.lblfiledich.Text = "...";
            // 
            // lblsodong
            // 
            this.lblsodong.AutoSize = true;
            this.lblsodong.Location = new System.Drawing.Point(160, 129);
            this.lblsodong.Name = "lblsodong";
            this.lblsodong.Size = new System.Drawing.Size(16, 13);
            this.lblsodong.TabIndex = 10;
            this.lblsodong.Text = "...";
            // 
            // txtnhan
            // 
            this.txtnhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnhan.Location = new System.Drawing.Point(86, 23);
            this.txtnhan.Multiline = true;
            this.txtnhan.Name = "txtnhan";
            this.txtnhan.Size = new System.Drawing.Size(322, 37);
            this.txtnhan.TabIndex = 13;
            // 
            // txtphat
            // 
            this.txtphat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphat.Location = new System.Drawing.Point(85, 66);
            this.txtphat.Multiline = true;
            this.txtphat.Name = "txtphat";
            this.txtphat.Size = new System.Drawing.Size(322, 39);
            this.txtphat.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbphat);
            this.groupBox1.Controls.Add(this.rdbnhan);
            this.groupBox1.Controls.Add(this.txtnhan);
            this.groupBox1.Controls.Add(this.txtphat);
            this.groupBox1.Location = new System.Drawing.Point(11, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 115);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo bảng";
            // 
            // rdbnhan
            // 
            this.rdbnhan.AutoSize = true;
            this.rdbnhan.Checked = true;
            this.rdbnhan.Location = new System.Drawing.Point(3, 33);
            this.rdbnhan.Name = "rdbnhan";
            this.rdbnhan.Size = new System.Drawing.Size(79, 17);
            this.rdbnhan.TabIndex = 17;
            this.rdbnhan.TabStop = true;
            this.rdbnhan.Text = "Table nhận";
            this.rdbnhan.UseVisualStyleBackColor = true;
            // 
            // rdbphat
            // 
            this.rdbphat.AutoSize = true;
            this.rdbphat.Location = new System.Drawing.Point(3, 76);
            this.rdbphat.Name = "rdbphat";
            this.rdbphat.Size = new System.Drawing.Size(76, 17);
            this.rdbphat.TabIndex = 18;
            this.rdbphat.Text = "Table phát";
            this.rdbphat.UseVisualStyleBackColor = true;
            // 
            // FrmExcelToFox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsodong);
            this.Controls.Add(this.lblfiledich);
            this.Controls.Add(this.lblfilenguon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchuyenfox);
            this.Controls.Add(this.btnnoiluu);
            this.Controls.Add(this.btnchonfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbsheet);
            this.Name = "FrmExcelToFox";
            this.Text = "Chuyển dữ liệu từ excel sang fox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExcelToFox_FormClosing);
            this.Load += new System.EventHandler(this.FrmExcelToFox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbsheet;
        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.Button btnnoiluu;
        private System.Windows.Forms.Button btnchuyenfox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfilenguon;
        private System.Windows.Forms.Label lblfiledich;
        private System.Windows.Forms.Label lblsodong;
        private System.Windows.Forms.TextBox txtnhan;
        private System.Windows.Forms.TextBox txtphat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbphat;
        private System.Windows.Forms.RadioButton rdbnhan;
    }
}