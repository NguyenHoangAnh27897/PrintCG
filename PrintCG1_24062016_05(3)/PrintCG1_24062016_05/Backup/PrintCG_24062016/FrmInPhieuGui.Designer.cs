namespace PrintCG_24062016
{
    partial class FrmInPhieuGui
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
            this.cmbsheet = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbsoluong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbdiachi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbnguoinhan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtngaygui = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchonfile = new System.Windows.Forms.Button();
            this.cmbghichu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbthanhpho = new System.Windows.Forms.ComboBox();
            this.cmbtrongluong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbloaihang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbtelnhan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnincg1 = new System.Windows.Forms.Button();
            this.btnina5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtnvnhan = new System.Windows.Forms.TextBox();
            this.txtbcnhan = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsoluongin = new System.Windows.Forms.TextBox();
            this.txtsaochep = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbcod = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbnguoigui = new System.Windows.Forms.ComboBox();
            this.cmbdiachigui = new System.Windows.Forms.ComboBox();
            this.cmbtelgui = new System.Windows.Forms.ComboBox();
            this.cmbsophieu = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbtrongluongkhoi = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbthuho = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbcuocchinh = new System.Windows.Forms.ComboBox();
            this.cmbhengio = new System.Windows.Forms.ComboBox();
            this.cmbcuockhac = new System.Windows.Forms.ComboBox();
            this.cmbtongtien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbsheet
            // 
            this.cmbsheet.FormattingEnabled = true;
            this.cmbsheet.Location = new System.Drawing.Point(159, 12);
            this.cmbsheet.Name = "cmbsheet";
            this.cmbsheet.Size = new System.Drawing.Size(146, 21);
            this.cmbsheet.TabIndex = 21;
            this.cmbsheet.SelectedIndexChanged += new System.EventHandler(this.cmbsheet_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Chọn sheet";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(310, 17);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(96, 13);
            this.lblfile.TabIndex = 38;
            this.lblfile.Text = "Bạn chưa chọn file";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ghi chú";
            // 
            // cmbsoluong
            // 
            this.cmbsoluong.FormattingEnabled = true;
            this.cmbsoluong.Location = new System.Drawing.Point(401, 143);
            this.cmbsoluong.Name = "cmbsoluong";
            this.cmbsoluong.Size = new System.Drawing.Size(75, 21);
            this.cmbsoluong.TabIndex = 34;
            this.cmbsoluong.Text = "1";
            this.cmbsoluong.Enter += new System.EventHandler(this.cmbsoluong_Enter);
            this.cmbsoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbsoluong_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số lượng";
            // 
            // cmbdiachi
            // 
            this.cmbdiachi.FormattingEnabled = true;
            this.cmbdiachi.Location = new System.Drawing.Point(401, 69);
            this.cmbdiachi.Name = "cmbdiachi";
            this.cmbdiachi.Size = new System.Drawing.Size(251, 21);
            this.cmbdiachi.TabIndex = 32;
            this.cmbdiachi.Enter += new System.EventHandler(this.cmbdiachi_Enter);
            this.cmbdiachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbdiachi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Địa chỉ";
            // 
            // cmbnguoinhan
            // 
            this.cmbnguoinhan.FormattingEnabled = true;
            this.cmbnguoinhan.Location = new System.Drawing.Point(401, 45);
            this.cmbnguoinhan.Name = "cmbnguoinhan";
            this.cmbnguoinhan.Size = new System.Drawing.Size(251, 21);
            this.cmbnguoinhan.TabIndex = 31;
            this.cmbnguoinhan.Enter += new System.EventHandler(this.cmbnguoinhan_Enter);
            this.cmbnguoinhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbnguoinhan_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Người nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "NV nhận";
            // 
            // txtngaygui
            // 
            this.txtngaygui.Location = new System.Drawing.Point(71, 135);
            this.txtngaygui.Mask = "00/00/0000";
            this.txtngaygui.Name = "txtngaygui";
            this.txtngaygui.Size = new System.Drawing.Size(256, 20);
            this.txtngaygui.TabIndex = 24;
            this.txtngaygui.ValidatingType = typeof(System.DateTime);
            this.txtngaygui.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtngaygui_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày gửi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Người gửi";
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(12, 12);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(75, 23);
            this.btnchonfile.TabIndex = 20;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // cmbghichu
            // 
            this.cmbghichu.FormattingEnabled = true;
            this.cmbghichu.Location = new System.Drawing.Point(401, 194);
            this.cmbghichu.Name = "cmbghichu";
            this.cmbghichu.Size = new System.Drawing.Size(251, 21);
            this.cmbghichu.TabIndex = 42;
            this.cmbghichu.Enter += new System.EventHandler(this.cmbghichu_Enter);
            this.cmbghichu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbghichu_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Địa chỉ gửi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "TP";
            // 
            // cmbthanhpho
            // 
            this.cmbthanhpho.FormattingEnabled = true;
            this.cmbthanhpho.Location = new System.Drawing.Point(401, 94);
            this.cmbthanhpho.Name = "cmbthanhpho";
            this.cmbthanhpho.Size = new System.Drawing.Size(251, 21);
            this.cmbthanhpho.TabIndex = 46;
            this.cmbthanhpho.Enter += new System.EventHandler(this.cmbthanhpho_Enter);
            this.cmbthanhpho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbthanhpho_KeyDown);
            // 
            // cmbtrongluong
            // 
            this.cmbtrongluong.FormattingEnabled = true;
            this.cmbtrongluong.Location = new System.Drawing.Point(401, 169);
            this.cmbtrongluong.Name = "cmbtrongluong";
            this.cmbtrongluong.Size = new System.Drawing.Size(93, 21);
            this.cmbtrongluong.TabIndex = 47;
            this.cmbtrongluong.Text = "0";
            this.cmbtrongluong.Enter += new System.EventHandler(this.cmbtrongluong_Enter);
            this.cmbtrongluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbtrongluong_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Trọng lượng";
            // 
            // cmbloaihang
            // 
            this.cmbloaihang.FormattingEnabled = true;
            this.cmbloaihang.Items.AddRange(new object[] {
            "HH",
            "TL"});
            this.cmbloaihang.Location = new System.Drawing.Point(587, 119);
            this.cmbloaihang.Name = "cmbloaihang";
            this.cmbloaihang.Size = new System.Drawing.Size(65, 21);
            this.cmbloaihang.TabIndex = 49;
            this.cmbloaihang.Enter += new System.EventHandler(this.cmbloaihang_Enter);
            this.cmbloaihang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbloaihang_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Loại hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Tel gửi";
            // 
            // cmbtelnhan
            // 
            this.cmbtelnhan.FormattingEnabled = true;
            this.cmbtelnhan.Location = new System.Drawing.Point(401, 120);
            this.cmbtelnhan.Name = "cmbtelnhan";
            this.cmbtelnhan.Size = new System.Drawing.Size(122, 21);
            this.cmbtelnhan.TabIndex = 53;
            this.cmbtelnhan.Enter += new System.EventHandler(this.cmbtelnhan_Enter);
            this.cmbtelnhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbtelnhan_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Tel nhận";
            // 
            // btnincg1
            // 
            this.btnincg1.Location = new System.Drawing.Point(418, 366);
            this.btnincg1.Name = "btnincg1";
            this.btnincg1.Size = new System.Drawing.Size(75, 23);
            this.btnincg1.TabIndex = 55;
            this.btnincg1.Text = "In CG1";
            this.btnincg1.UseVisualStyleBackColor = true;
            this.btnincg1.Click += new System.EventHandler(this.btnincg1_Click);
            // 
            // btnina5
            // 
            this.btnina5.Location = new System.Drawing.Point(498, 366);
            this.btnina5.Name = "btnina5";
            this.btnina5.Size = new System.Drawing.Size(75, 23);
            this.btnina5.TabIndex = 56;
            this.btnina5.Text = "In A5";
            this.btnina5.UseVisualStyleBackColor = true;
            this.btnina5.Click += new System.EventHandler(this.btnina5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "BC nhận";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Cước chính";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(346, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Hẹn giờ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(341, 318);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Cước khác";
            // 
            // txtnvnhan
            // 
            this.txtnvnhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnvnhan.Location = new System.Drawing.Point(71, 158);
            this.txtnvnhan.Name = "txtnvnhan";
            this.txtnvnhan.Size = new System.Drawing.Size(255, 20);
            this.txtnvnhan.TabIndex = 67;
            this.txtnvnhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnvnhan_KeyDown_1);
            // 
            // txtbcnhan
            // 
            this.txtbcnhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbcnhan.Location = new System.Drawing.Point(71, 180);
            this.txtbcnhan.Name = "txtbcnhan";
            this.txtbcnhan.Size = new System.Drawing.Size(255, 20);
            this.txtbcnhan.TabIndex = 68;
            this.txtbcnhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbcnhan_KeyDown_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(341, 342);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 69;
            this.label19.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoluongin);
            this.groupBox1.Controls.Add(this.txtsaochep);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(2, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 98);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập in";
            this.groupBox1.Visible = false;
            // 
            // txtsoluongin
            // 
            this.txtsoluongin.Location = new System.Drawing.Point(111, 43);
            this.txtsoluongin.Name = "txtsoluongin";
            this.txtsoluongin.Size = new System.Drawing.Size(116, 20);
            this.txtsoluongin.TabIndex = 74;
            this.txtsoluongin.Text = "1";
            this.txtsoluongin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsoluongin.Enter += new System.EventHandler(this.txtsoluongin_Enter);
            // 
            // txtsaochep
            // 
            this.txtsaochep.Location = new System.Drawing.Point(112, 19);
            this.txtsaochep.Name = "txtsaochep";
            this.txtsaochep.Size = new System.Drawing.Size(116, 20);
            this.txtsaochep.TabIndex = 72;
            this.txtsaochep.Text = "1";
            this.txtsaochep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsaochep.Enter += new System.EventHandler(this.txtsaochep_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 73;
            this.label21.Text = "Số lượng in";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Số lượng sao chép";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(568, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 72;
            this.label22.Text = "CG1 : 24x15.24";
            // 
            // cmbcod
            // 
            this.cmbcod.FormattingEnabled = true;
            this.cmbcod.Location = new System.Drawing.Point(401, 218);
            this.cmbcod.Name = "cmbcod";
            this.cmbcod.Size = new System.Drawing.Size(251, 21);
            this.cmbcod.TabIndex = 74;
            this.cmbcod.Enter += new System.EventHandler(this.cmbcod_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(367, 222);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 73;
            this.label23.Text = "COD";
            // 
            // cmbnguoigui
            // 
            this.cmbnguoigui.FormattingEnabled = true;
            this.cmbnguoigui.Location = new System.Drawing.Point(72, 43);
            this.cmbnguoigui.Name = "cmbnguoigui";
            this.cmbnguoigui.Size = new System.Drawing.Size(255, 21);
            this.cmbnguoigui.TabIndex = 75;
            this.cmbnguoigui.Enter += new System.EventHandler(this.cmbnguoigui_Enter);
            // 
            // cmbdiachigui
            // 
            this.cmbdiachigui.FormattingEnabled = true;
            this.cmbdiachigui.Location = new System.Drawing.Point(72, 65);
            this.cmbdiachigui.Name = "cmbdiachigui";
            this.cmbdiachigui.Size = new System.Drawing.Size(254, 21);
            this.cmbdiachigui.TabIndex = 76;
            this.cmbdiachigui.Enter += new System.EventHandler(this.cmbdiachigui_Enter);
            // 
            // cmbtelgui
            // 
            this.cmbtelgui.FormattingEnabled = true;
            this.cmbtelgui.Location = new System.Drawing.Point(72, 88);
            this.cmbtelgui.Name = "cmbtelgui";
            this.cmbtelgui.Size = new System.Drawing.Size(254, 21);
            this.cmbtelgui.TabIndex = 77;
            this.cmbtelgui.Enter += new System.EventHandler(this.cmbtelgui_Enter);
            // 
            // cmbsophieu
            // 
            this.cmbsophieu.FormattingEnabled = true;
            this.cmbsophieu.Location = new System.Drawing.Point(72, 111);
            this.cmbsophieu.Name = "cmbsophieu";
            this.cmbsophieu.Size = new System.Drawing.Size(254, 21);
            this.cmbsophieu.TabIndex = 79;
            this.cmbsophieu.Enter += new System.EventHandler(this.cmbsophieu_Enter);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 78;
            this.label24.Text = "Số phiếu";
            // 
            // cmbtrongluongkhoi
            // 
            this.cmbtrongluongkhoi.FormattingEnabled = true;
            this.cmbtrongluongkhoi.Location = new System.Drawing.Point(544, 169);
            this.cmbtrongluongkhoi.Name = "cmbtrongluongkhoi";
            this.cmbtrongluongkhoi.Size = new System.Drawing.Size(106, 21);
            this.cmbtrongluongkhoi.TabIndex = 80;
            this.cmbtrongluongkhoi.Text = "0";
            this.cmbtrongluongkhoi.Enter += new System.EventHandler(this.cmbtrongluongkhoi_Enter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(500, 172);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 81;
            this.label25.Text = "TL khối";
            // 
            // cmbthuho
            // 
            this.cmbthuho.FormattingEnabled = true;
            this.cmbthuho.Location = new System.Drawing.Point(401, 242);
            this.cmbthuho.Name = "cmbthuho";
            this.cmbthuho.Size = new System.Drawing.Size(251, 21);
            this.cmbthuho.TabIndex = 83;
            this.cmbthuho.Enter += new System.EventHandler(this.cmbthuho_Enter);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(357, 246);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 82;
            this.label26.Text = "Thu hộ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 84;
            this.button1.Text = "Báo phát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbcuocchinh
            // 
            this.cmbcuocchinh.FormattingEnabled = true;
            this.cmbcuocchinh.Location = new System.Drawing.Point(402, 266);
            this.cmbcuocchinh.Name = "cmbcuocchinh";
            this.cmbcuocchinh.Size = new System.Drawing.Size(251, 21);
            this.cmbcuocchinh.TabIndex = 85;
            this.cmbcuocchinh.Enter += new System.EventHandler(this.cmbcuocchinh_Enter);
            // 
            // cmbhengio
            // 
            this.cmbhengio.FormattingEnabled = true;
            this.cmbhengio.Location = new System.Drawing.Point(402, 289);
            this.cmbhengio.Name = "cmbhengio";
            this.cmbhengio.Size = new System.Drawing.Size(251, 21);
            this.cmbhengio.TabIndex = 86;
            this.cmbhengio.Enter += new System.EventHandler(this.cmbhengio_Enter);
            // 
            // cmbcuockhac
            // 
            this.cmbcuockhac.FormattingEnabled = true;
            this.cmbcuockhac.Location = new System.Drawing.Point(401, 313);
            this.cmbcuockhac.Name = "cmbcuockhac";
            this.cmbcuockhac.Size = new System.Drawing.Size(251, 21);
            this.cmbcuockhac.TabIndex = 87;
            this.cmbcuockhac.Enter += new System.EventHandler(this.cmbcuockhac_Enter);
            // 
            // cmbtongtien
            // 
            this.cmbtongtien.FormattingEnabled = true;
            this.cmbtongtien.Location = new System.Drawing.Point(400, 337);
            this.cmbtongtien.Name = "cmbtongtien";
            this.cmbtongtien.Size = new System.Drawing.Size(251, 21);
            this.cmbtongtien.TabIndex = 88;
            this.cmbtongtien.Enter += new System.EventHandler(this.cmbtongtien_Enter);
            // 
            // FrmInPhieuGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 451);
            this.Controls.Add(this.cmbtongtien);
            this.Controls.Add(this.cmbcuockhac);
            this.Controls.Add(this.cmbhengio);
            this.Controls.Add(this.cmbcuocchinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbthuho);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cmbtrongluongkhoi);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cmbsophieu);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmbtelgui);
            this.Controls.Add(this.cmbdiachigui);
            this.Controls.Add(this.cmbnguoigui);
            this.Controls.Add(this.cmbcod);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtbcnhan);
            this.Controls.Add(this.txtnvnhan);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnina5);
            this.Controls.Add(this.btnincg1);
            this.Controls.Add(this.cmbtelnhan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbloaihang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbtrongluong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbthanhpho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbghichu);
            this.Controls.Add(this.cmbsheet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbsoluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbnguoinhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtngaygui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchonfile);
            this.Name = "FrmInPhieuGui";
            this.Text = "FrmInPhieuGui";
            this.Load += new System.EventHandler(this.FrmInPhieuGui_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInPhieuGui_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsheet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbnguoinhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtngaygui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.ComboBox cmbghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbthanhpho;
        private System.Windows.Forms.ComboBox cmbtrongluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbloaihang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbtelnhan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnincg1;
        private System.Windows.Forms.Button btnina5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtnvnhan;
        private System.Windows.Forms.TextBox txtbcnhan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtsoluongin;
        private System.Windows.Forms.TextBox txtsaochep;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbcod;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbnguoigui;
        private System.Windows.Forms.ComboBox cmbdiachigui;
        private System.Windows.Forms.ComboBox cmbtelgui;
        private System.Windows.Forms.ComboBox cmbsophieu;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbtrongluongkhoi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbthuho;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbcuocchinh;
        private System.Windows.Forms.ComboBox cmbhengio;
        private System.Windows.Forms.ComboBox cmbcuockhac;
        private System.Windows.Forms.ComboBox cmbtongtien;

    }
}