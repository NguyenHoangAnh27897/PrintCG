namespace PrintCG_24062016.tinhcuoc
{
    partial class FrmProvinceZone
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
            this.txtsovung = new System.Windows.Forms.TextBox();
            this.btntaovung = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmavung = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnluuvung = new System.Windows.Forms.Button();
            this.Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblvung = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số vùng";
            // 
            // txtsovung
            // 
            this.txtsovung.Location = new System.Drawing.Point(72, 34);
            this.txtsovung.Name = "txtsovung";
            this.txtsovung.Size = new System.Drawing.Size(125, 20);
            this.txtsovung.TabIndex = 3;
            // 
            // btntaovung
            // 
            this.btntaovung.Location = new System.Drawing.Point(203, 34);
            this.btntaovung.Name = "btntaovung";
            this.btntaovung.Size = new System.Drawing.Size(49, 23);
            this.btntaovung.TabIndex = 4;
            this.btntaovung.Text = "Tạo";
            this.btntaovung.UseVisualStyleBackColor = true;
            this.btntaovung.Click += new System.EventHandler(this.btntaovung_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zone,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(207, 408);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã vùng";
            // 
            // txtmavung
            // 
            this.txtmavung.Location = new System.Drawing.Point(72, 8);
            this.txtmavung.Name = "txtmavung";
            this.txtmavung.Size = new System.Drawing.Size(125, 20);
            this.txtmavung.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 433);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết số vùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(229, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 433);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tỉnh chưa xác lập vùng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProvinceID,
            this.ProvinceName});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(278, 408);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblvung);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(586, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 433);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tỉnh đã xác lập vùng";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProvinceID1,
            this.ProvinceName1});
            this.dataGridView3.Location = new System.Drawing.Point(6, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(278, 376);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bạn đang chọn vùng :";
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(525, 249);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(49, 23);
            this.btnright.TabIndex = 12;
            this.btnright.Text = ">";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(525, 278);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(49, 23);
            this.btnleft.TabIndex = 13;
            this.btnleft.Text = "<";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnluuvung
            // 
            this.btnluuvung.Location = new System.Drawing.Point(792, 511);
            this.btnluuvung.Name = "btnluuvung";
            this.btnluuvung.Size = new System.Drawing.Size(78, 23);
            this.btnluuvung.TabIndex = 14;
            this.btnluuvung.Text = "Lưu vùng";
            this.btnluuvung.UseVisualStyleBackColor = true;
            this.btnluuvung.Click += new System.EventHandler(this.btnluuvung_Click);
            // 
            // Zone
            // 
            this.Zone.HeaderText = "Vùng";
            this.Zone.Name = "Zone";
            this.Zone.ReadOnly = true;
            this.Zone.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Số tỉnh";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 70;
            // 
            // ProvinceID
            // 
            this.ProvinceID.HeaderText = "ID";
            this.ProvinceID.Name = "ProvinceID";
            this.ProvinceID.Width = 40;
            // 
            // ProvinceName
            // 
            this.ProvinceName.HeaderText = "Tên";
            this.ProvinceName.Name = "ProvinceName";
            this.ProvinceName.Width = 190;
            // 
            // ProvinceID1
            // 
            this.ProvinceID1.HeaderText = "ID";
            this.ProvinceID1.Name = "ProvinceID1";
            this.ProvinceID1.Width = 40;
            // 
            // ProvinceName1
            // 
            this.ProvinceName1.HeaderText = "Tên";
            this.ProvinceName1.Name = "ProvinceName1";
            this.ProvinceName1.Width = 190;
            // 
            // lblvung
            // 
            this.lblvung.AutoSize = true;
            this.lblvung.ForeColor = System.Drawing.Color.Maroon;
            this.lblvung.Location = new System.Drawing.Point(127, 23);
            this.lblvung.Name = "lblvung";
            this.lblvung.Size = new System.Drawing.Size(0, 13);
            this.lblvung.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(258, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tỉnh đặc biệt được tính như một vùng";
            // 
            // FrmProvinceZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnluuvung);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmavung);
            this.Controls.Add(this.btntaovung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsovung);
            this.Name = "FrmProvinceZone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProvinceZone";
            this.Load += new System.EventHandler(this.FrmProvinceZone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsovung;
        private System.Windows.Forms.Button btntaovung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmavung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnluuvung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceName1;
        private System.Windows.Forms.Label lblvung;
        private System.Windows.Forms.Label label4;
    }
}