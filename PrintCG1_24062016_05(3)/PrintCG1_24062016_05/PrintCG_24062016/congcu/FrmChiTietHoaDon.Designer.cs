namespace PrintCG_24062016.congcu
{
    partial class FrmChiTietHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoCT = new System.Windows.Forms.TextBox();
            this.txtSoCG = new System.Windows.Forms.TextBox();
            this.dtpCreate = new System.Windows.Forms.DateTimePicker();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.txtCuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số CT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày tạo";
            // 
            // txtSoCT
            // 
            this.txtSoCT.Location = new System.Drawing.Point(69, 20);
            this.txtSoCT.Name = "txtSoCT";
            this.txtSoCT.Size = new System.Drawing.Size(200, 20);
            this.txtSoCT.TabIndex = 3;
            // 
            // txtSoCG
            // 
            this.txtSoCG.Location = new System.Drawing.Point(69, 90);
            this.txtSoCG.Name = "txtSoCG";
            this.txtSoCG.Size = new System.Drawing.Size(200, 20);
            this.txtSoCG.TabIndex = 4;
            // 
            // dtpCreate
            // 
            this.dtpCreate.Location = new System.Drawing.Point(69, 56);
            this.dtpCreate.Name = "dtpCreate";
            this.dtpCreate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreate.TabIndex = 5;
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 145);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(562, 242);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(500, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(500, 324);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(74, 48);
            this.dgv2.TabIndex = 9;
            this.dgv2.Visible = false;
            // 
            // txtCuoc
            // 
            this.txtCuoc.Location = new System.Drawing.Point(415, 20);
            this.txtCuoc.Name = "txtCuoc";
            this.txtCuoc.Size = new System.Drawing.Size(89, 20);
            this.txtCuoc.TabIndex = 10;
            this.txtCuoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCuoc_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cước DV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "VAT";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(415, 53);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(89, 20);
            this.txtVAT.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên hàng hoá, dịch vụ";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(415, 86);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(89, 20);
            this.txtPackage.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(500, 116);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In bảng kê";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 424);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuoc);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dtpCreate);
            this.Controls.Add(this.txtSoCG);
            this.Controls.Add(this.txtSoCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChiTietHoaDon";
            this.Text = "FrmChiTietHoaDon";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoCT;
        private System.Windows.Forms.TextBox txtSoCG;
        private System.Windows.Forms.DateTimePicker dtpCreate;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TextBox txtCuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Button btnPrint;
    }
}