namespace PrintCG_24062016
{
    partial class FrmCG8
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
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.txtbuucuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabdanhmuc = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabthaotac = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xuatExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xuatExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabdanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabthaotac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromdate.Location = new System.Drawing.Point(64, 4);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(97, 20);
            this.dtpfromdate.TabIndex = 0;
            // 
            // dtptodate
            // 
            this.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptodate.Location = new System.Drawing.Point(246, 6);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(97, 20);
            this.dtptodate.TabIndex = 1;
            // 
            // txtbuucuc
            // 
            this.txtbuucuc.Location = new System.Drawing.Point(402, 5);
            this.txtbuucuc.Name = "txtbuucuc";
            this.txtbuucuc.Size = new System.Drawing.Size(82, 20);
            this.txtbuucuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã BC";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabdanhmuc);
            this.tabControl1.Controls.Add(this.tabthaotac);
            this.tabControl1.Location = new System.Drawing.Point(5, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 492);
            this.tabControl1.TabIndex = 6;
            // 
            // tabdanhmuc
            // 
            this.tabdanhmuc.Controls.Add(this.dataGridView1);
            this.tabdanhmuc.Location = new System.Drawing.Point(4, 22);
            this.tabdanhmuc.Name = "tabdanhmuc";
            this.tabdanhmuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabdanhmuc.Size = new System.Drawing.Size(966, 466);
            this.tabdanhmuc.TabIndex = 0;
            this.tabdanhmuc.Text = "Tổng hợp";
            this.tabdanhmuc.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(954, 454);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabthaotac
            // 
            this.tabthaotac.Controls.Add(this.dataGridView2);
            this.tabthaotac.Location = new System.Drawing.Point(4, 22);
            this.tabthaotac.Name = "tabthaotac";
            this.tabthaotac.Padding = new System.Windows.Forms.Padding(3);
            this.tabthaotac.Size = new System.Drawing.Size(966, 466);
            this.tabthaotac.TabIndex = 1;
            this.tabthaotac.Text = "Chi tiết";
            this.tabthaotac.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(954, 457);
            this.dataGridView2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuatExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // xuatExcelToolStripMenuItem
            // 
            this.xuatExcelToolStripMenuItem.Name = "xuatExcelToolStripMenuItem";
            this.xuatExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xuatExcelToolStripMenuItem.Text = "Xuat Excel";
            this.xuatExcelToolStripMenuItem.Click += new System.EventHandler(this.xuatExcelToolStripMenuItem_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(501, 4);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 7;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(582, 5);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 8;
            this.btnexcel.Text = "Xuất excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            // 
            // txtfolder
            // 
            this.txtfolder.Location = new System.Drawing.Point(870, 5);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(109, 20);
            this.txtfolder.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuatExcelToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(128, 26);
            // 
            // xuatExcelToolStripMenuItem1
            // 
            this.xuatExcelToolStripMenuItem1.Name = "xuatExcelToolStripMenuItem1";
            this.xuatExcelToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xuatExcelToolStripMenuItem1.Text = "Xuat Excel";
            this.xuatExcelToolStripMenuItem1.Click += new System.EventHandler(this.xuatExcelToolStripMenuItem1_Click);
            // 
            // FrmCG8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 536);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuucuc);
            this.Controls.Add(this.dtptodate);
            this.Controls.Add(this.dtpfromdate);
            this.Name = "FrmCG8";
            this.Text = "FrmCG8";
            this.Load += new System.EventHandler(this.FrmCG8_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCG8_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabdanhmuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabthaotac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.TextBox txtbuucuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabdanhmuc;
        private System.Windows.Forms.TabPage tabthaotac;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuatExcelToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem xuatExcelToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}