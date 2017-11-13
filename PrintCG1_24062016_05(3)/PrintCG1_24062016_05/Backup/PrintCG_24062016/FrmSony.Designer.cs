namespace PrintCG_24062016
{
    partial class FrmSony
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnguoigui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtngaygui = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbdo = new System.Windows.Forms.ComboBox();
            this.txtnvnhan = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbnguoinhan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdiachi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsoluong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdenso = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txttuso = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btndoanhthu = new System.Windows.Forms.Button();
            this.txttrongluongtong = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsoluongin = new System.Windows.Forms.TextBox();
            this.txtmaxcg = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbtp = new System.Windows.Forms.ComboBox();
            this.btnin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txthoadon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbllancan = new System.Windows.Forms.Label();
            this.txttrongluong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsocg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbsheet = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdblien = new System.Windows.Forms.RadioButton();
            this.rdba5 = new System.Windows.Forms.RadioButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người gửi";
            // 
            // txtnguoigui
            // 
            this.txtnguoigui.Location = new System.Drawing.Point(71, 33);
            this.txtnguoigui.Name = "txtnguoigui";
            this.txtnguoigui.Size = new System.Drawing.Size(256, 20);
            this.txtnguoigui.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày gửi";
            // 
            // txtngaygui
            // 
            this.txtngaygui.Location = new System.Drawing.Point(71, 56);
            this.txtngaygui.Mask = "00/00/0000";
            this.txtngaygui.Name = "txtngaygui";
            this.txtngaygui.Size = new System.Drawing.Size(256, 20);
            this.txtngaygui.TabIndex = 3;
            this.txtngaygui.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do";
            // 
            // cmbdo
            // 
            this.cmbdo.FormattingEnabled = true;
            this.cmbdo.Location = new System.Drawing.Point(398, 28);
            this.cmbdo.Name = "cmbdo";
            this.cmbdo.Size = new System.Drawing.Size(180, 21);
            this.cmbdo.TabIndex = 6;
            this.cmbdo.Enter += new System.EventHandler(this.cmbdo_Enter);
            // 
            // txtnvnhan
            // 
            this.txtnvnhan.Location = new System.Drawing.Point(71, 79);
            this.txtnvnhan.Name = "txtnvnhan";
            this.txtnvnhan.Size = new System.Drawing.Size(256, 20);
            this.txtnvnhan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NV nhận";
            // 
            // cmbnguoinhan
            // 
            this.cmbnguoinhan.FormattingEnabled = true;
            this.cmbnguoinhan.Location = new System.Drawing.Point(398, 53);
            this.cmbnguoinhan.Name = "cmbnguoinhan";
            this.cmbnguoinhan.Size = new System.Drawing.Size(180, 21);
            this.cmbnguoinhan.TabIndex = 7;
            this.cmbnguoinhan.Enter += new System.EventHandler(this.cmbnguoinhan_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Người nhận";
            // 
            // cmbdiachi
            // 
            this.cmbdiachi.FormattingEnabled = true;
            this.cmbdiachi.Location = new System.Drawing.Point(398, 78);
            this.cmbdiachi.Name = "cmbdiachi";
            this.cmbdiachi.Size = new System.Drawing.Size(179, 21);
            this.cmbdiachi.TabIndex = 8;
            this.cmbdiachi.Enter += new System.EventHandler(this.cmbdiachi_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // cmbsoluong
            // 
            this.cmbsoluong.FormattingEnabled = true;
            this.cmbsoluong.Location = new System.Drawing.Point(398, 103);
            this.cmbsoluong.Name = "cmbsoluong";
            this.cmbsoluong.Size = new System.Drawing.Size(179, 21);
            this.cmbsoluong.TabIndex = 9;
            this.cmbsoluong.Enter += new System.EventHandler(this.cmbsoluong_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(71, 102);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(256, 20);
            this.txtghichu.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ghi chú";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtdenso);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txttuso);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btndoanhthu);
            this.groupBox1.Controls.Add(this.txttrongluongtong);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.btnexcel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtsoluongin);
            this.groupBox1.Controls.Add(this.txtmaxcg);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbtp);
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txthoadon);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbllancan);
            this.groupBox1.Controls.Add(this.txttrongluong);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsocg);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(7, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 367);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In phiếu gửi";
            // 
            // txtdenso
            // 
            this.txtdenso.Enabled = false;
            this.txtdenso.Location = new System.Drawing.Point(503, 16);
            this.txtdenso.Name = "txtdenso";
            this.txtdenso.Size = new System.Drawing.Size(67, 20);
            this.txtdenso.TabIndex = 40;
            this.txtdenso.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(463, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "đến số";
            // 
            // txttuso
            // 
            this.txttuso.Enabled = false;
            this.txttuso.Location = new System.Drawing.Point(391, 16);
            this.txttuso.Name = "txttuso";
            this.txttuso.Size = new System.Drawing.Size(67, 20);
            this.txttuso.TabIndex = 38;
            this.txttuso.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(341, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Bill từ số";
            this.label21.DoubleClick += new System.EventHandler(this.label21_DoubleClick);
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndoanhthu.Location = new System.Drawing.Point(681, 341);
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.Size = new System.Drawing.Size(78, 23);
            this.btndoanhthu.TabIndex = 35;
            this.btndoanhthu.Text = "Doanh thu";
            this.btndoanhthu.UseVisualStyleBackColor = true;
            this.btndoanhthu.Click += new System.EventHandler(this.btndoanhthu_Click);
            // 
            // txttrongluongtong
            // 
            this.txttrongluongtong.Location = new System.Drawing.Point(176, 64);
            this.txttrongluongtong.Name = "txttrongluongtong";
            this.txttrongluongtong.Size = new System.Drawing.Size(111, 20);
            this.txttrongluongtong.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(230, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "In phiếu gửi cũ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(593, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Mã bill";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(572, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Số lượng in";
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexcel.Location = new System.Drawing.Point(321, 339);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(78, 23);
            this.btnexcel.TabIndex = 29;
            this.btnexcel.Text = "Xuất excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(328, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cần tạo những cột CG,SL,TL,HD,TP trước khi sử dụng chương trình";
            // 
            // txtsoluongin
            // 
            this.txtsoluongin.Location = new System.Drawing.Point(634, 41);
            this.txtsoluongin.Name = "txtsoluongin";
            this.txtsoluongin.Size = new System.Drawing.Size(125, 20);
            this.txtsoluongin.TabIndex = 34;
            this.txtsoluongin.Text = "1";
            // 
            // txtmaxcg
            // 
            this.txtmaxcg.Enabled = false;
            this.txtmaxcg.Location = new System.Drawing.Point(634, 17);
            this.txtmaxcg.Name = "txtmaxcg";
            this.txtmaxcg.Size = new System.Drawing.Size(126, 20);
            this.txtmaxcg.TabIndex = 32;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Location = new System.Drawing.Point(329, 47);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(241, 59);
            this.txtdiachi.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Thành phố";
            // 
            // cmbtp
            // 
            this.cmbtp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbtp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbtp.FormattingEnabled = true;
            this.cmbtp.Location = new System.Drawing.Point(61, 39);
            this.cmbtp.Name = "cmbtp";
            this.cmbtp.Size = new System.Drawing.Size(109, 21);
            this.cmbtp.TabIndex = 11;
            this.cmbtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbtp_KeyDown);
            // 
            // btnin
            // 
            this.btnin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnin.Location = new System.Drawing.Point(596, 70);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(164, 41);
            this.btnin.TabIndex = 15;
            this.btnin.Text = "In mới phiếu gửi";
            this.btnin.UseVisualStyleBackColor = false;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 206);
            this.dataGridView1.TabIndex = 27;
            // 
            // txthoadon
            // 
            this.txthoadon.Location = new System.Drawing.Point(61, 87);
            this.txthoadon.Name = "txthoadon";
            this.txthoadon.Size = new System.Drawing.Size(259, 20);
            this.txthoadon.TabIndex = 13;
            this.txthoadon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthoadon_KeyDown);
            this.txthoadon.Enter += new System.EventHandler(this.txthoadon_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Hóa đơn";
            // 
            // lbllancan
            // 
            this.lbllancan.AutoSize = true;
            this.lbllancan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllancan.Location = new System.Drawing.Point(289, 63);
            this.lbllancan.Name = "lbllancan";
            this.lbllancan.Size = new System.Drawing.Size(34, 20);
            this.lbllancan.TabIndex = 24;
            this.lbllancan.Text = "n/n";
            this.lbllancan.DoubleClick += new System.EventHandler(this.lbllancan_DoubleClick);
            this.lbllancan.Click += new System.EventHandler(this.lbllancan_Click);
            // 
            // txttrongluong
            // 
            this.txttrongluong.Location = new System.Drawing.Point(60, 63);
            this.txttrongluong.MaxLength = 13;
            this.txttrongluong.Name = "txttrongluong";
            this.txttrongluong.Size = new System.Drawing.Size(110, 20);
            this.txttrongluong.TabIndex = 14;
            this.txttrongluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttrongluong_KeyDown);
            this.txttrongluong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttrongluong_KeyUp);
            this.txttrongluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttrongluong_KeyPress);
            this.txttrongluong.Enter += new System.EventHandler(this.txttrongluong_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "TL";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(237, 39);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(83, 20);
            this.txtsoluong.TabIndex = 12;
            this.txtsoluong.Text = "1";
            this.txtsoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsoluong_KeyDown);
            this.txtsoluong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsoluong_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số lượng";
            // 
            // txtdo
            // 
            this.txtdo.Location = new System.Drawing.Point(61, 17);
            this.txtdo.Name = "txtdo";
            this.txtdo.Size = new System.Drawing.Size(259, 20);
            this.txtdo.TabIndex = 10;
            this.txtdo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdo_KeyDown);
            this.txtdo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdo_KeyUp);
            this.txtdo.Enter += new System.EventHandler(this.txtdo_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã DO";
            // 
            // txtsocg
            // 
            this.txtsocg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtsocg.Enabled = false;
            this.txtsocg.Location = new System.Drawing.Point(51, 341);
            this.txtsocg.Name = "txtsocg";
            this.txtsocg.Size = new System.Drawing.Size(174, 20);
            this.txtsocg.TabIndex = 11;
            this.txtsocg.Enter += new System.EventHandler(this.txtsocg_Enter);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Số CG";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(310, 8);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(96, 13);
            this.lblfile.TabIndex = 18;
            this.lblfile.Text = "Bạn chưa chọn file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cmbsheet
            // 
            this.cmbsheet.FormattingEnabled = true;
            this.cmbsheet.Location = new System.Drawing.Point(159, 3);
            this.cmbsheet.Name = "cmbsheet";
            this.cmbsheet.Size = new System.Drawing.Size(146, 21);
            this.cmbsheet.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Chọn sheet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "CG1(24x15in)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "D:\\InSony";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdblien);
            this.groupBox2.Controls.Add(this.rdba5);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(588, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 99);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // rdblien
            // 
            this.rdblien.AutoSize = true;
            this.rdblien.Enabled = false;
            this.rdblien.Location = new System.Drawing.Point(9, 77);
            this.rdblien.Name = "rdblien";
            this.rdblien.Size = new System.Drawing.Size(45, 17);
            this.rdblien.TabIndex = 34;
            this.rdblien.Text = "Liên";
            this.rdblien.UseVisualStyleBackColor = true;
            // 
            // rdba5
            // 
            this.rdba5.AutoSize = true;
            this.rdba5.Checked = true;
            this.rdba5.Location = new System.Drawing.Point(9, 52);
            this.rdba5.Name = "rdba5";
            this.rdba5.Size = new System.Drawing.Size(38, 17);
            this.rdba5.TabIndex = 33;
            this.rdba5.TabStop = true;
            this.rdba5.Text = "A5";
            this.rdba5.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // FrmSony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbsheet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbsoluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbnguoinhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnvnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtngaygui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnguoigui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmSony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmSony_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSony_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnguoigui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtngaygui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbdo;
        private System.Windows.Forms.MaskedTextBox txtnvnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbnguoinhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbllancan;
        private System.Windows.Forms.TextBox txttrongluong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsocg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txthoadon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbsheet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbtp;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdblien;
        private System.Windows.Forms.RadioButton rdba5;
        private System.Windows.Forms.TextBox txtsoluongin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtmaxcg;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttrongluongtong;
        private System.Windows.Forms.Button btndoanhthu;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtdenso;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txttuso;
        private System.Windows.Forms.Label label21;
    }
}