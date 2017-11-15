namespace PrintCG_24062016
{
    partial class FrmBaoPhat
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
            this.cmbnguoinhan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsophieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbdiachi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btninbaophat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblfile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsheet = new System.Windows.Forms.ComboBox();
            this.txtbcgoc = new System.Windows.Forms.TextBox();
            this.txtngaygui = new System.Windows.Forms.MaskedTextBox();
            this.txtkinhgui = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(12, 12);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(70, 23);
            this.btnchonfile.TabIndex = 0;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // cmbnguoinhan
            // 
            this.cmbnguoinhan.FormattingEnabled = true;
            this.cmbnguoinhan.Location = new System.Drawing.Point(77, 126);
            this.cmbnguoinhan.Name = "cmbnguoinhan";
            this.cmbnguoinhan.Size = new System.Drawing.Size(189, 21);
            this.cmbnguoinhan.TabIndex = 4;
            this.cmbnguoinhan.Enter += new System.EventHandler(this.cmbnguoinhan_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số phiếu";
            // 
            // cmbsophieu
            // 
            this.cmbsophieu.FormattingEnabled = true;
            this.cmbsophieu.Location = new System.Drawing.Point(77, 153);
            this.cmbsophieu.Name = "cmbsophieu";
            this.cmbsophieu.Size = new System.Drawing.Size(189, 21);
            this.cmbsophieu.TabIndex = 5;
            this.cmbsophieu.Enter += new System.EventHandler(this.cmbsophieu_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày gửi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // cmbdiachi
            // 
            this.cmbdiachi.FormattingEnabled = true;
            this.cmbdiachi.Location = new System.Drawing.Point(77, 207);
            this.cmbdiachi.Name = "cmbdiachi";
            this.cmbdiachi.Size = new System.Drawing.Size(189, 21);
            this.cmbdiachi.TabIndex = 7;
            this.cmbdiachi.Enter += new System.EventHandler(this.cmbdiachi_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BC gốc";
            // 
            // btninbaophat
            // 
            this.btninbaophat.Location = new System.Drawing.Point(127, 240);
            this.btninbaophat.Name = "btninbaophat";
            this.btninbaophat.Size = new System.Drawing.Size(75, 23);
            this.btninbaophat.TabIndex = 8;
            this.btninbaophat.Text = "In báo phát";
            this.btninbaophat.UseVisualStyleBackColor = true;
            this.btninbaophat.Click += new System.EventHandler(this.btninbaophat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(88, 17);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(96, 13);
            this.lblfile.TabIndex = 12;
            this.lblfile.Text = "Bạn chưa chọn file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chọn sheet";
            // 
            // cmbsheet
            // 
            this.cmbsheet.FormattingEnabled = true;
            this.cmbsheet.Location = new System.Drawing.Point(77, 50);
            this.cmbsheet.Name = "cmbsheet";
            this.cmbsheet.Size = new System.Drawing.Size(189, 21);
            this.cmbsheet.TabIndex = 1;
            // 
            // txtbcgoc
            // 
            this.txtbcgoc.Location = new System.Drawing.Point(77, 78);
            this.txtbcgoc.Name = "txtbcgoc";
            this.txtbcgoc.Size = new System.Drawing.Size(189, 20);
            this.txtbcgoc.TabIndex = 2;
            // 
            // txtngaygui
            // 
            this.txtngaygui.Location = new System.Drawing.Point(77, 181);
            this.txtngaygui.Mask = "00/00/0000";
            this.txtngaygui.Name = "txtngaygui";
            this.txtngaygui.Size = new System.Drawing.Size(189, 20);
            this.txtngaygui.TabIndex = 6;
            this.txtngaygui.ValidatingType = typeof(System.DateTime);
            // 
            // txtkinhgui
            // 
            this.txtkinhgui.Location = new System.Drawing.Point(77, 101);
            this.txtkinhgui.Name = "txtkinhgui";
            this.txtkinhgui.Size = new System.Drawing.Size(189, 20);
            this.txtkinhgui.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kính gửi";
            // 
            // FrmBaoPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.txtkinhgui);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtngaygui);
            this.Controls.Add(this.txtbcgoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbsheet);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.btninbaophat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbdiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbsophieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbnguoinhan);
            this.Controls.Add(this.btnchonfile);
            this.Name = "FrmBaoPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaoPhat";
            this.Load += new System.EventHandler(this.FrmBaoPhat_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaoPhat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.ComboBox cmbnguoinhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsophieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btninbaophat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsheet;
        private System.Windows.Forms.TextBox txtbcgoc;
        private System.Windows.Forms.MaskedTextBox txtngaygui;
        private System.Windows.Forms.TextBox txtkinhgui;
        private System.Windows.Forms.Label label7;
    }
}