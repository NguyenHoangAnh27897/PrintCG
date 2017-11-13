namespace PrintCG_24062016
{
    partial class FrmFromTo
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
            this.btnchonfile = new System.Windows.Forms.Button();
            this.lblpath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnguoinhan = new System.Windows.Forms.ComboBox();
            this.cmbdiachinhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.cmbsheet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnxemin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(13, 13);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(75, 23);
            this.btnchonfile.TabIndex = 0;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(95, 22);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(124, 13);
            this.lblpath.TabIndex = 1;
            this.lblpath.Text = "Bạn chưa chọn file excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người gửi(From):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người nhận(To):";
            // 
            // txtnguoinhan
            // 
            this.txtnguoinhan.FormattingEnabled = true;
            this.txtnguoinhan.Location = new System.Drawing.Point(98, 109);
            this.txtnguoinhan.Name = "txtnguoinhan";
            this.txtnguoinhan.Size = new System.Drawing.Size(131, 21);
            this.txtnguoinhan.TabIndex = 3;
            this.txtnguoinhan.Enter += new System.EventHandler(this.txtnguoinhan_Enter);
            // 
            // cmbdiachinhan
            // 
            this.cmbdiachinhan.FormattingEnabled = true;
            this.cmbdiachinhan.Location = new System.Drawing.Point(284, 109);
            this.cmbdiachinhan.Name = "cmbdiachinhan";
            this.cmbdiachinhan.Size = new System.Drawing.Size(140, 21);
            this.cmbdiachinhan.TabIndex = 4;
            this.cmbdiachinhan.Enter += new System.EventHandler(this.cmbdiachinhan_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(98, 77);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(326, 20);
            this.txtfrom.TabIndex = 2;
            // 
            // cmbsheet
            // 
            this.cmbsheet.FormattingEnabled = true;
            this.cmbsheet.Location = new System.Drawing.Point(98, 50);
            this.cmbsheet.Name = "cmbsheet";
            this.cmbsheet.Size = new System.Drawing.Size(131, 21);
            this.cmbsheet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn sheet";
            // 
            // btnxemin
            // 
            this.btnxemin.Location = new System.Drawing.Point(204, 152);
            this.btnxemin.Name = "btnxemin";
            this.btnxemin.Size = new System.Drawing.Size(75, 23);
            this.btnxemin.TabIndex = 5;
            this.btnxemin.Text = "Xem in";
            this.btnxemin.UseVisualStyleBackColor = true;
            this.btnxemin.Click += new System.EventHandler(this.btnxemin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmFromTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 202);
            this.Controls.Add(this.btnxemin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbsheet);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbdiachinhan);
            this.Controls.Add(this.txtnguoinhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.btnchonfile);
            this.Name = "FrmFromTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFromTo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtnguoinhan;
        private System.Windows.Forms.ComboBox cmbdiachinhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.ComboBox cmbsheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnxemin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}