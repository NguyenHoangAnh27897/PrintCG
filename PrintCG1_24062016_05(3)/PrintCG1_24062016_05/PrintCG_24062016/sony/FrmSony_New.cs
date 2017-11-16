using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using PrintCG_24062016.Report;
using PrintCG_24062016.dataset; 
namespace PrintCG_24062016
{
    public partial class FrmSony_New : Form
    {
        public FrmSony_New()
        {
            InitializeComponent();
        }

        private void btnnhapplan_Click(object sender, EventArgs e)
        {
            Frm_Sony_Plan_Insert frm = new Frm_Sony_Plan_Insert();
            frm.Show();
        }

        private void FrmSony_New_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_settings()
        {
            txtnvnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtnvnhan", String.Empty);
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtnguoigui", String.Empty);
            txtdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtdiachi", String.Empty);
            txtghichuphat.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtghichuphat", String.Empty);
            txtghichuphat1.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtghichuphat1", String.Empty);
            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtfolder", String.Empty);
            txtlh1.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtlh1", String.Empty);
            txtlh2.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtlh2", String.Empty);
            txtlh3.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony_new.txtlh3", String.Empty);
        }
        private void save_settings()
        {

            Application.UserAppDataRegistry.SetValue("frmsony_new.txtnvnhan", txtnvnhan.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtnguoigui", txtnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtdiachi", txtdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtghichuphat", txtghichuphat.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtghichuphat1", txtghichuphat1.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtfolder", txtfolder.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtlh1", txtlh1.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtlh2", txtlh2.Text);
            Application.UserAppDataRegistry.SetValue("frmsony_new.txtlh3", txtlh3.Text);
        }

        private void FrmSony_New_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void txtdo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string DO = string.Empty;
                string DO1 = string.Empty;
                bool flag = true;
                OleDbConnection conn = new OleDbConnection();
                DataSet ds = new DataSet();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "SELECT CG,DO,DODate,ShipID,ShipName,ShipStreet,d.Province,GrossWeight,Quatity,DeliveryDate,RealWeight,d.Remark,MaTinh FROM (tb_sonydiachi d INNER JOIN tb_sonyplan s ON d.ShipID = s.ShipToParty) INNER JOIN tb_tinhthanh t ON d.Province = t.TenTinh  where DO = '" + txtdo.Text.Trim() + "' and [DODate] = CDate('" + dtppgi.Value.ToString("dd/MM/yyyy 00:00:00") + "')";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds);
                conn.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (chkghep.Checked == true)
                    {
                        txtdo.Focus();
                    }
                    else
                    {
                        txtsoluong.Focus();
                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Clear();
                        }
                    }

                    try
                    {
                        DO = txtdo.Text.Trim();
                    }
                    catch (Exception ex)
                    {
                        DO = "";
                    }
                    foreach (DataGridViewRow rowdo in dataGridView1.Rows)
                    {
                        try
                        {
                            DO1 = rowdo.Cells[1].Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            DO1 = "";
                        }
                        if (DO1 == DO)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        foreach (DataRow rowds in ds.Tables[0].Rows)
                        {
                            string[] row = new string[] { NullValue(rowds["CG"].ToString()), NullValue(rowds["DO"].ToString()), NullValue(rowds["DODate"].ToString()), NullValue(rowds["ShipID"].ToString()), NullValue(rowds["ShipName"].ToString()), NullValue(rowds["ShipStreet"].ToString()), rowds["Province"].ToString(), NullValue(rowds["GrossWeight"].ToString()), rowds["Quatity"].ToString(), NullValue(rowds["DeliveryDate"].ToString()), rowds["RealWeight"].ToString(), rowds["Remark"].ToString(), rowds["MaTinh"].ToString() };
                            dataGridView1.Rows.Add(row);
                        }
                        
                    }

                    txtkhachhang.ForeColor = Color.Black;
                    txtdiachikh.ForeColor = Color.Black;
                    txtmabill.Text = NullValue(ds.Tables[0].Rows[0]["DO"].ToString().Trim());
                    txtkhachhang.Text = NullValue(ds.Tables[0].Rows[0]["ShipName"].ToString());
                    txtdiachikh.Text = NullValue(ds.Tables[0].Rows[0]["ShipStreet"].ToString());
                    lblremark.Text = NullValue(ds.Tables[0].Rows[0]["Remark"].ToString());

                   // dataGridView1.Columns["DO"].Width = 75;


                }
                txtdo.SelectAll();

            }
        }
        static string NullValue(object Value)
        {
            return Value == null ? "" : Value.ToString();
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttrongluong.Focus();
            }
        }

        private void txttrongluong_Enter(object sender, EventArgs e)
        {
            if (int.Parse(txtsoluong.Text) > 1)
            {
                txttrongluong.Text = "";
            }
            if (txtsoluong.Text != "")
            {
                txttrongluong.SelectAll();
                if (int.Parse(txtsoluong.Text) > 1)
                {
                    FrmDHL_Listweight frmtlcan = new FrmDHL_Listweight();
                    FrmDHL_Listweight.socg = txtmabill.Text;
                    FrmDHL_Listweight.soluog = txtsoluong.Text;
                    if (frmtlcan.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //Gán giá trị textValue trong DialogForm cho textbox txtValue trong MainForm
                        txttongtrongluong.Text = frmtlcan.textValue;
                    }
                    // frmtlcan.Show();

                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại trọng lượng");
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            //neu so luong dong > 1 thi cong du lieu vao nhau va lay so DO dau tien lam barcode.
            string sophieu = NullValue(dataGridView1.Rows[0].Cells["CG"].Value.ToString());
            string DO = NullValue(dataGridView1.Rows[0].Cells["DO"].Value.ToString());
            int countmailer = dataGridView1.Rows.Count - 1;
            if (txtkhachhang.Text.Trim() != "" && txtdiachikh.Text.Trim() != "")
            {
                if (countmailer == 1)
                {
                    if (sophieu != "")
                    {
                        DialogResult dialogResult = MessageBox.Show("CG đã được in trước đó! Bạn muốn in lại ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //dong y se in de lai thong tin
                            int total = update_plan(DO, DO);
                            if (total > 0)
                            {
                                get_sokien(DO);
                                inphieugui();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                            }
                        }
                    }
                    else
                    {
                        int total = update_plan(DO, DO);
                        if (total > 0)
                        {
                            get_sokien(DO);
                            inphieugui();
                            dataGridView1.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }
                    }
                }
                else if (countmailer > 1)
                {
                    int total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        try
                        {
                            total = update_plan(NullValue(row.Cells["DO"].Value.ToString()), DO);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    if (total > 0)
                    {
                        get_sokien(DO);
                        inphieugui();
                        dataGridView1.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Thông tin chưa đủ");
            }
            txtdo.Focus();
        }
        private int update_plan(string donumber, string cg)
        {
            string tong = get_sokien(donumber);
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query = string.Empty;
            query = "update tb_sonyplan set CG ='"+ cg +"',  SL = " + txtsoluong.Text + ",TL = " + txttongtrongluong.Text + ",Employee ='" + txtnvnhan.Text.Trim() + "',Contact1='" + txtlh1.Text +"',Contact2 ='"+ txtlh2.Text +"',Contact3 ='"+ txtlh3.Text +"',TongSL ='"+ tong +"',SenderName ='"+ txtnguoigui.Text +"',SenderAddress ='"+ txtdiachi.Text +"' where DO = '" + donumber + "'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            int int_upd = cmd.ExecuteNonQuery();
            conn.Close();
            return int_upd;
        }
        string sokien = string.Empty;
        private string get_sokien(string socg)
        {
            sokien = "";
            DataTable dt = new DataTable();

            try
            {
                OleDbConnection conn = new OleDbConnection();

                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select SL,TL from tb_sltl where CG = '" + socg + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                if (dt.Rows.Count <= 10)
                {
                    int sttkien = 1;
                    foreach (DataRow row in dt.Rows)
                    {

                        sokien = sokien + String.Format("{0:0,0}", float.Parse(row["TL"].ToString())) + "x" + row["SL"].ToString() + "K ; ";
                        sttkien = sttkien + 1;
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return sokien;
        }
        string TongSL = string.Empty;
        private void inphieugui()
        {
            try
            {
                RptDHL_A5 rpt = new RptDHL_A5();
                int quatity = 0;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        quatity += int.Parse(row.Cells["Quatity"].Value.ToString());
                    }

                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Không tìm thấy Quality");
                }
                TongSL = sokien;
                TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                _txtbcnhan.Text = "DHL";

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtDO.Text = "*" + dataGridView1.Rows[0].Cells["DO"].Value.ToString() + "*";

                TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo1"];
                _txtDO1.Text = dataGridView1.Rows[0].Cells["DO"].Value.ToString();

                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = txtnguoigui.Text;

                TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                _txtdiachigui.Text = txtdiachi.Text;

                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                _txtnvnhan.Text = txtnvnhan.Text;

                TextObject _txtghichuphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat"];
                _txtghichuphat.Text = (txtghichuphat.Text).Replace(".", " \n ");

                TextObject _txtghichuphat1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat1"];
                _txtghichuphat1.Text = (txtghichuphat1.Text).Replace(".", " \n ");

                TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
                _txtngayphat.Text = dataGridView1.Rows[0].Cells["DeliveryDate"].Value.ToString();

                TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngaynhan.Text = dataGridView1.Rows[0].Cells["DODate"].Value.ToString();

                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = dataGridView1.Rows[0].Cells["Shiptoname"].Value.ToString();

                TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _txtdiachinhan.Text = dataGridView1.Rows[0].Cells["Shiptostreet"].Value.ToString();

                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = "";

                TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                _txtsl.Text = txtsoluong.Text;

                TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                _txttl.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));


                TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));

                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = sokien;

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = dataGridView1.Rows[0].Cells["Remark"].Value.ToString();
                ;

                TextObject _txtthanhpho = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txtthanhpho.Text = dataGridView1.Rows[0].Cells["Province"].Value.ToString();

                TextObject _txtquality = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtquality"];
                _txtquality.Text = quatity.ToString() + " điện thoại + PK";

                TextObject _txtlh1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh1"];
                _txtlh1.Text = txtlh1.Text;

                TextObject _txtlh2 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh2"];
                _txtlh2.Text = txtlh2.Text;

                TextObject _txtlh3 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh3"];
                _txtlh3.Text = txtlh3.Text;

                TextObject _Text5 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["Text5"];
                _Text5.Text = dataGridView1.Rows[0].Cells["Remark"].Value.ToString();
                ;


                //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);


                //cap nhat so kien.

                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                string query = string.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (int.Parse(txtsoluong.Text) > 1)
                    {
                        query = "update tb_sonyplan set TongSL = '" + TongSL + "',Contact1 = '" + txtlh1.Text.Trim() + "',Contact2 ='" + txtlh2.Text.Trim() + "',Contact3 = '" + txtlh3.Text.Trim() + "',Employee = '" + txtnvnhan.Text.Trim() + "' where [DO] = '" + row.Cells["DO"].Value.ToString() + "'";
                    }
                    else if ((txtsoluong.Text) == "1")
                    {
                        query = "update tb_sonyplan set TongSL = '" + TongSL + "',Contact1 = '" + txtlh1.Text.Trim() + "',Contact2 ='" + txtlh2.Text.Trim() + "',Contact3 = '" + txtlh3.Text.Trim() + "',Employee = '" + txtnvnhan.Text.Trim() + "' where [DO] = '" + row.Cells["DO"].Value.ToString() + "'";
                    }
                }
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txttrongluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnin.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtsocg.Text.Trim() != "")
            {
                //xem in phieu gui cũ.
                FrmDHLPrint.type = "S";
                FrmDHLPrint.sophieu = txtsocg.Text.Trim();
                FrmDHLPrint.ghichuphat = txtghichuphat.Text.Trim();
                FrmDHLPrint.ghichuphat1 = txtghichuphat1.Text.Trim();
                FrmDHLPrint frm = new FrmDHLPrint();
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                create_excel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataSet get_diachi(string tentinh)
        {
            DataSet ds = new DataSet();
            string matinh = string.Empty;
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select MaTinh from tb_tinhthanh where TenTinh = '" + tentinh + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                matinh = "";
            }
            return ds;
        }
        private void create_excel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            string excelfile = txtfolder.Text.Trim() + "\\Excel\\Sony_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



            xlWorkSheet.Cells[1, 1] = "Ngày nhận";
            xlWorkSheet.Cells[1, 2] = "Giờ";
            xlWorkSheet.Cells[1, 3] = "Số phiếu";
            xlWorkSheet.Cells[1, 4] = "LH";
            xlWorkSheet.Cells[1, 5] = "DV";
            xlWorkSheet.Cells[1, 6] = "SL";
            xlWorkSheet.Cells[1, 7] = "TL";
            xlWorkSheet.Cells[1, 8] = "TL Khối";
            xlWorkSheet.Cells[1, 9] = "Tên đường(Nhận)";
            xlWorkSheet.Cells[1, 10] = "T/Thành(NĐ)";
            xlWorkSheet.Cells[1, 11] = "Q/Huyện(Nhận)";
            xlWorkSheet.Cells[1, 12] = "Ghi chú";
            //bo sung them cac cot khac theo yeu cau cua HNI
            xlWorkSheet.Cells[1, 13] = "DO";
            xlWorkSheet.Cells[1, 14] = "Shop";
            xlWorkSheet.Cells[1, 15] = "Số Máy";
            xlWorkSheet.Cells[1, 16] = "Mã Khách Hàng";
            xlWorkSheet.Cells[1, 17] = "Ngày Phát";
            xlWorkSheet.Cells[1, 18] = "Khu Vực";

            xlWorkSheet.Cells.NumberFormat = "@";

            string _ngaynhan = dtppgi.Value.ToString();
            string _gio = "00:00";
            string _sophieu;
            string _loaihang = "HH";
            string _dichvu = "SN";
            string _soluong = "1";
            string _trongluong;
            string _trongluongkhoi;
            string _tenduong;
            string _tinhthanh;
            string _quanhuyen;
            string _ghichu = "";

            // khai bao them thong tin
            string _do;
            string _shop;
            string _somay;
            string _makh;
            string _ngayphat;
            string _khuvuc;
            string _tongsl;

            string data;
            int i = 0;
            int j = 0;

            DsExcel dsexcel = new DsExcel();
            DataTable dt = new DataTable();
            dt = ReadInfo(dtppgi.Value);

            foreach (DataRow row in dt.Rows)
            {

                try
                {
                    _sophieu = row["CG"].ToString();
                }
                catch (Exception ex)
                {
                    _sophieu = "";
                }

                try
                {
                    _soluong = row["SL"].ToString();
                }
                catch (Exception ex)
                {
                    _soluong = "0";
                }

                try
                {
                    _trongluong = row["TL"].ToString();
                }
                catch (Exception ex)
                {
                    _trongluong = "0";
                }

                try
                {
                    _trongluongkhoi = row["TL"].ToString();
                }
                catch (Exception ex)
                {
                    _trongluongkhoi = "0";
                }

                try
                {
                    _tenduong = row["ShipToStreet"].ToString();
                }
                catch (Exception ex)
                {
                    _tenduong = "";
                }

                try
                {
                    _quanhuyen = "";

                }
                catch (Exception ex)
                {
                    _quanhuyen = "";
                }

                try
                {
                    _tinhthanh = row["ProvinceID"].ToString();

                }
                catch (Exception)
                {
                    _tinhthanh = "";
                }

                try
                {
                    _do = row["DO"].ToString();
                }
                catch (Exception)
                {
                    _do = "";
                }

                try
                {
                    _shop = row["ShipToName"].ToString();
                }
                catch (Exception)
                {
                    _shop = "";
                }

                try
                {
                    _somay = row["Quatity"].ToString();
                }
                catch (Exception)
                {
                    _somay = "";
                }

                try
                {
                    _makh = row["ShipToParty"].ToString();
                }
                catch (Exception)
                {
                    _makh = "";
                }

                try
                {
                    _ngayphat = row["DeliveryDate"].ToString();
                }
                catch (Exception)
                {
                    _ngayphat = "";
                }

                try
                {
                    _khuvuc = row["Vung"].ToString();
                }
                catch (Exception)
                {
                    _khuvuc = "";
                }
                try
                {
                    _tongsl = row["TongSL"].ToString();
                }
                catch (Exception)
                {
                    _tongsl = "";
                }

                //_ghichu = row[cmbdo.Text].ToString() + "/" + row["KH"].ToString().ToUpper();
                dsexcel.Excel.AddExcelRow(DateTime.Parse(_ngaynhan).ToString("dd/MM/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong, _tinhthanh, _quanhuyen, _ghichu, _do, _shop, _somay, _makh, _ngayphat, _khuvuc,_tongsl,"");

            }
            for (i = 0; i <= dsexcel.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= dsexcel.Tables[0].Columns.Count - 1; j++)
                {

                    data = dsexcel.Tables[0].Rows[i].ItemArray[j].ToString();
                    i = i + 1;
                    xlWorkSheet.Cells[i + 1, j + 1] = data;

                    i = i - 1;
                    //excelSheet.Cells[i , j ] = data;
                }
            }


            if (File.Exists(excelfile) == true)
            {
                File.Delete(excelfile);
            }

            xlWorkBook.SaveAs(excelfile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);



            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Xuất thành công " + excelfile);
        }
        private DataTable ReadInfo(DateTime PGI)
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select * from tb_sonyplan where [DODate] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            // comm.CommandText = "select * from tb_dhlplan,tb_diachi,tb_tinhthanh where tb_dhlplan.[ToZone] = tb_diachi.[Zone] and tb_diachi.[ZoneDesc] = tb_tinhthanh.[TenTinh] and [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            //comm.CommandText = "Select [tb_dhlplan.CG] from tb_dhlplan inner join tb_diachi on tb_diachi.[Zone] = tb_dhlplan.[ToZone]  where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            return dt;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btndongbo_Click(object sender, EventArgs e)
        {
            int total = 0;
            string DODate;
            string DO;
            string ShipToParty;
            string ShipToName;
            string ShipToStreet;
            string Province;
            double GrossWeight;
            int Quatity;
            string Remark;
            string TongSL;
            string Employee;
            string Contact1;
            string Contact2;
            string Contact3;
            string DeliveryDate;
            string ProvinceID;
            int SL;
            string CG;
            double TL;
            string SenderName;
            string SenderAddress;

            DBLIST.Service1SoapClient list = new PrintCG_24062016.DBLIST.Service1SoapClient();
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select * from tb_sonyplan where Syn is Null and CG IS NOT NULL";
            //comm.CommandText = "Select * from tb_dhlplan";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                DODate = DateTime.Parse(row["DODate"].ToString()).ToString("yyyy-MM-dd");
                DO = row["DO"].ToString();
                ShipToParty = row["ShipToParty"].ToString();
                ShipToName = row["ShipToName"].ToString();
                ShipToStreet = row["ShipToStreet"].ToString();
                Province = row["Province"].ToString();
                GrossWeight = double.Parse( row["GrossWeight"].ToString());
                Quatity = int.Parse(row["Quatity"].ToString());
                Remark = row["Remark"].ToString();
                TongSL = row["TongSL"].ToString();
                Employee = row["Employee"].ToString();
                Contact1 = row["Contact1"].ToString();
                Contact2 = row["Contact2"].ToString();
                Contact3 = row["Contact3"].ToString();
                DeliveryDate = DateTime.Parse(row["DeliveryDate"].ToString()).ToString("yyyy-MM-dd");
                ProvinceID = row["ProvinceID"].ToString();
                SL = int.Parse(row["SL"].ToString());
                CG = row["CG"].ToString();
                TL = double.Parse(row["TL"].ToString());
                SenderName = row["SenderName"].ToString();
                SenderAddress = row["SenderAddress"].ToString();
                string count = list.InsertSonyPlan(DODate, DO, ShipToParty, ShipToName, ShipToStreet, Province, GrossWeight, Quatity, Remark, TongSL, Employee, Contact1, Contact2, Contact3, DeliveryDate, ProvinceID, SL, CG, TL,SenderName,SenderAddress);
                if (count == "0")
                {
                    string query = "update tb_sonyplan set Syn = '1' where [DO] ='" + DO + "'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    total += 1;
                }
            }
            MessageBox.Show("Đã cập nhật [" + total + "] DO");
            conn.Close();
        }

        private void btnxoado_Click(object sender, EventArgs e)
        {
            FrmDHLXoaDO.type = "S";
            FrmDHLXoaDO frm = new FrmDHLXoaDO();
            frm.Show();
        }

        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txttongtrongluong.Text = txttrongluong.Text;
        }

        private void txttrongluong_KeyUp(object sender, KeyEventArgs e)
        {
            txttongtrongluong.Text = txttrongluong.Text;
        }
    }
}
