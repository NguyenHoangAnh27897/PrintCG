namespace PrintCG_24062016.congcu
{
    partial class FrmTraHBOnline
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpercent = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.txttong = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.MailerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridview2 = new System.Windows.Forms.DataGridView();
            this.IsCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lblpercent);
            this.GroupBox1.Controls.Add(this.ProgressBar1);
            this.GroupBox1.Controls.Add(this.txttong);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnxoa);
            this.GroupBox1.Controls.Add(this.btnxem);
            this.GroupBox1.Controls.Add(this.DataGridView1);
            this.GroupBox1.Location = new System.Drawing.Point(4, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(810, 490);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin hồi báo";
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(186, 16);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(13, 13);
            this.lblpercent.TabIndex = 12;
            this.lblpercent.Text = "0";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(9, 14);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(171, 20);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.TabIndex = 11;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(345, 13);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(58, 20);
            this.txttong.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(275, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Tổng số CG";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(747, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(55, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(686, 12);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(55, 23);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailerID,
            this.DeliveryTo,
            this.DeliveryDate,
            this.DeliveryTime});
            this.DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridView1.Location = new System.Drawing.Point(6, 39);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(798, 441);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // MailerID
            // 
            this.MailerID.HeaderText = "Số CG";
            this.MailerID.Name = "MailerID";
            this.MailerID.ReadOnly = true;
            // 
            // DeliveryTo
            // 
            this.DeliveryTo.HeaderText = "Người nhận";
            this.DeliveryTo.Name = "DeliveryTo";
            this.DeliveryTo.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Ngày nhận";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // DeliveryTime
            // 
            this.DeliveryTime.HeaderText = "Giờ nhận";
            this.DeliveryTime.Name = "DeliveryTime";
            this.DeliveryTime.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.datagridview2);
            this.GroupBox2.Location = new System.Drawing.Point(814, 11);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(259, 483);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Thiết lập hiển thị";
            // 
            // datagridview2
            // 
            this.datagridview2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsCheck,
            this.Columnname,
            this.ColumnID});
            this.datagridview2.Location = new System.Drawing.Point(6, 19);
            this.datagridview2.Name = "datagridview2";
            this.datagridview2.Size = new System.Drawing.Size(247, 453);
            this.datagridview2.TabIndex = 0;
            this.datagridview2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview2_CellContentClick);
            this.datagridview2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview2_CellValueChanged);
            // 
            // IsCheck
            // 
            this.IsCheck.FalseValue = "0";
            this.IsCheck.HeaderText = "IsCheck";
            this.IsCheck.Name = "IsCheck";
            this.IsCheck.TrueValue = "1";
            this.IsCheck.Width = 50;
            // 
            // Columnname
            // 
            this.Columnname.HeaderText = "Columnname";
            this.Columnname.Name = "Columnname";
            this.Columnname.Width = 150;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ColumnID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // FrmTraHBOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 497);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTraHBOnline";
            this.Text = "FrmTraHBOnline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTraHBOnline_FormClosing);
            this.Load += new System.EventHandler(this.FrmTraHBOnline_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblpercent;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.TextBox txttong;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnxoa;
        internal System.Windows.Forms.Button btnxem;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MailerID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTime;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView datagridview2;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsCheck;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}