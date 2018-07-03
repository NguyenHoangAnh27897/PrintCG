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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn sheet";
            // 
            // cbbsheet
            // 
            this.cbbsheet.FormattingEnabled = true;
            this.cbbsheet.Location = new System.Drawing.Point(76, 32);
            this.cbbsheet.Name = "cbbsheet";
            this.cbbsheet.Size = new System.Drawing.Size(121, 21);
            this.cbbsheet.TabIndex = 0;
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
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số dòng";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // FrmExcelToFox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchuyenfox);
            this.Controls.Add(this.btnnoiluu);
            this.Controls.Add(this.btnchonfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbsheet);
            this.Name = "FrmExcelToFox";
            this.Text = "Chuyển dữ liệu từ excel sang fox";
            this.Load += new System.EventHandler(this.FrmExcelToFox_Load);
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
    }
}