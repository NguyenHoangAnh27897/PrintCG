using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel; 

namespace PrintCG_24062016
{
    public partial class FrmSony : Form
    {
        public FrmSony()
        {
            InitializeComponent();
        }
        string path;
        string[] listsheet;
        string[] listdo;
        string[] listnguoinhan;
        string[] listsoluong;
        string[] listdiachi;
        string[] listparty;
        public static string total = string.Empty;
        public void GetValue(String str1)
        {// khai báo 1 hàm với 2 tham số đầu vào là str1, và str2 nó sẽ đưa dữ liệu vào 2 lable
            txttrongluongtong.Text = str1;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;

            lblfile.Text = path;
            listsheet = GetExcelSheetNames(path);
            cmbsheet.DataSource = listsheet;

            listdo = GetExcelSheetColumns(path);
            listnguoinhan = GetExcelSheetColumns(path);
            listsoluong = GetExcelSheetColumns(path);
            listdiachi = GetExcelSheetColumns(path);
            listparty = GetExcelSheetColumns(path);

        }

        private void FrmSony_Load(object sender, EventArgs e)
        {
            string nam = DateTime.Today.Year.ToString().Substring(2, 2);
            string thang = DateTime.Today.Month.ToString();
            string ngay = DateTime.Today.Day.ToString();
           
            if (thang.Length == 1)
            {
                thang = "0" + thang;
            }
            if (ngay.Length == 1)
            {
                ngay = "0" + ngay;
            }
            load_settings();
            

            //DataSet ds = new DataSet();
            //ds.ReadXml("SelectAllComboBoxProvinces.xml");
            //cmbtp.DataBindings(ds.Tables[0],"ProvinceID");
            //cmbtp.DataSource = ds.Tables[0];

            XmlTextReader xmdatareader = new XmlTextReader("SelectAllComboBoxProvinces.xml");
            DataSet _objdataset = new DataSet();
            _objdataset.ReadXml(xmdatareader);
            //cmbtp.DisplayMember = "ProvinceID";
            //cmbtp.ValueMember = "ProvinceName";
            //cmbtp.DataSource = _objdataset.Tables[0];
            txtngaygui.Text = ngay + "/" + thang + "/" + DateTime.Today.Year.ToString();


        }
        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string Import_FileName = path;
            string fileExtension = Path.GetExtension(Import_FileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            con = new OleDbConnection(conStr);
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }
            return excelSheetNames;
        }
        public string[] GetExcelSheetColumns(string excelFileName)
        {


            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + cmbsheet.Text + "]";
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        String[] excelSheetNames = new String[dt.Columns.Count];
                        //string a = " row " + dt.Rows.Count.ToString() + " Col " + dt.Columns.Count.ToString();

                        int i = 0;
                        try
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                //this.Invoke(new MethodInvoker(delegate()
                                {
                                    if (column.ColumnName.ToString().Substring(0, 1) != "F")
                                    {
                                        excelSheetNames[i] = column.ColumnName.ToString();
                                        i++;
                                    }
                                    else
                                    {
                                        return excelSheetNames;
                                    }

                                };
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        return excelSheetNames;
                    }

                }
            }

        }

        private void cmbdo_Enter(object sender, EventArgs e)
        {
            cmbdo.DataSource = listdo;
        }

        private void cmbnguoinhan_Enter(object sender, EventArgs e)
        {
            cmbnguoinhan.DataSource = listnguoinhan;
        }

        private void cmbdiachi_Enter(object sender, EventArgs e)
        {
            cmbdiachi.DataSource = listdiachi;
        }

        private void cmbsoluong_Enter(object sender, EventArgs e)
        {
            cmbsoluong.DataSource = listsoluong;
        }
      
        private void load_settings()
        {
            cmbdo.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.cmbdoc", String.Empty);
            cmbnguoinhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.cmbnguoinhan", String.Empty);
            cmbdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.cmbdiachi", String.Empty);
            cmbparty.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.cmbparty", String.Empty);
            cmbsoluong.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.cmbsoluong", String.Empty);
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.txtnguoigui", String.Empty);
           // txtngaygui.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.txtngaygui", String.Empty);
            txtnvnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.txtnvnhan", String.Empty);
            txtghichu.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.txtghichu", String.Empty);
            // txtsocg.Text = (String)Application.UserAppDataRegistry.GetValue("frmsony.txtsocg", String.Empty);
          

        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmsony.cmbdoc", cmbdo.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.cmbnguoinhan", cmbnguoinhan.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.cmbdiachi", cmbdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.cmbsoluong", cmbsoluong.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.cmbparty", cmbparty.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.txtnguoigui", txtnguoigui.Text);
           // Application.UserAppDataRegistry.SetValue("frmsony.txtngaygui", txtngaygui.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.txtnvnhan", txtnvnhan.Text);
            Application.UserAppDataRegistry.SetValue("frmsony.txtghichu", txtghichu.Text);
            // Application.UserAppDataRegistry.SetValue("frmsony.txtsocg", txtsocg.Text);
           

        }

        private void FrmSony_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
        private DataTable ReadExcelFile(string sheetName, string path)
        {

            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select [CG],[SL],[TL],[HD],[TP]," + cmbdo.Text + "," + cmbnguoinhan.Text + "," + cmbdiachi.Text + "," + cmbsoluong.Text + "," + cmbparty.Text + "  from [" + sheetName + "] where [" + cmbdo.Text + "] like '%" + txtdo.Text + "%'";
                     //comm.CommandText = "Select * from [" + sheetName + "]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;

                    }

                }
            }
        }
        int soluong;
        string nguoinhan;
        string diachi;
        string thanhpho;
        string party;
        int si_sts = 0;
        string do_num = string.Empty;
        private void txtdo_KeyUp(object sender, KeyEventArgs e)
        {
            si_sts = 0;
            try
            {
                if (lblfile.Text != "Bạn chưa chọn file")
                {
                    DataTable dt = ReadExcelFile(cmbsheet.SelectedItem.ToString(), path);
                    dataGridView1.DataSource = dt;
                    string party = dt.Rows[0][cmbparty.Text].ToString();

                    DataTable dt1 = new DataTable();
                    OleDbConnection conn = new OleDbConnection();

                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    OleDbCommand comm = new OleDbCommand();
                    conn.Open();
                    comm.CommandText = "Select sn.ShipName,sn.ShipStreet,tt.TenTinh,tt.MaTinh,sn.Remark from tb_sonydiachi sn inner join tb_tinhthanh tt on sn.Province = tt.TenTinh where ShipID = '" + party + "'";
                    comm.Connection = conn;
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = comm;
                    da.Fill(dt1);
                    conn.Close();
                    dtg2.DataSource = dt1;

                    foreach (DataRow row in dt.Rows)
                    {
                        soluong = soluong + int.Parse(row[cmbsoluong.Text].ToString());
                        nguoinhan = row[cmbnguoinhan.Text].ToString();
                        diachi = row[cmbdiachi.Text].ToString();
                        party = row[cmbparty.Text].ToString();

                        if (row["CG"].ToString() != "")
                        {
                            txtsocg.Text = row["CG"].ToString();
                        }
                        else
                        {

                        }
                        txthoadon.Text = row["HD"].ToString();
                        txtsoluong.Text = row["SL"].ToString();
                        if (txtsoluong.Text == "")
                        {
                            txtsoluong.Text = "1";
                        }
                        txttrongluongtong.Text = row["TL"].ToString();
                        txtphat.Text = row[cmbparty.Text].ToString();
                        //cmbtp.Text = row["TP"].ToString();
                        txtdiachi.Text = diachi;
                        si_sts += int.Parse(row[cmbsoluong.Text].ToString());
                        do_num = "DO: " + row[cmbdo.Text].ToString();
                        txtmaxcg.Text = row[cmbdo.Text].ToString();

                    }
                }

                else
                {
                    //MessageBox.Show("Chưa chọn file excel");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Chưa chọn file excel");
                MessageBox.Show(ex.ToString());
            }
        }
        int _soluong;
        float _trongluong;
        string sokien;
        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txttrongluongtong.Text = txttrongluong.Text;

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            //neu nhu co tren 5 DO va có DO da co so phieu thi hien thi thong bao truoc khi cap nhat.
           
                if(txtmaxcg.Text !="")
                {

                
                bool flag = false;
                string DO = string.Empty;

                try
                {
                    DO = dataGridView1.Rows[0].Cells[cmbdo.Text].Value.ToString();
                }
                catch (Exception ex)
                {
                    DO = "";
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string sophieu = string.Empty;
                    
                    try
                    {
                        sophieu = row.Cells["CG"].Value.ToString().Trim();
                       // DO = row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim();
                        if (DO == row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim())
                        {
                            flag = false;
                        }
                        else if (DO != row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim())
                        {
                            flag = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        sophieu = "";
                        DO = "";
                    }

                    if (sophieu != "")
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    updateexcel();
                   // MessageBox.Show("khong co trung so DO");
                }
                else
                {
                    MessageBox.Show("Có quá nhiều DO khác nhau trên lưới, hoặc DO đã in trước đó. Vui lòng kiểm tra lại");
                }
                }
            
            // bo ham cap nhat thong tin vao day
        }
        private void updateexcel()
        {
            //truoc khi in cap nhat so phieu, so luong, trong luong, hoa don, noi den vao file excel;
            //sau do load lai danh sach nay len luoi de nguoi dung xem.
            //in ra so kien tren phieu gui neu tong so kien < 10
            //tien hanh in phieu gui
            int numberOfRecords;
            if (txthoadon.Text != "" && txttrongluongtong.Text != "")
            {
                sokien = "";
                using (OleDbConnection conn = new OleDbConnection())
                {
                    DataTable dt = new DataTable();
                    string Import_FileName = path;
                    string fileExtension = Path.GetExtension(Import_FileName);
                    if (fileExtension == ".xls")
                        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                    if (fileExtension == ".xlsx")
                        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                    using (OleDbCommand comm = new OleDbCommand())
                    {
                        comm.CommandText = "Update [" + cmbsheet.Text + "] set CG = '" + txtmaxcg.Text + "',HD = '" + txthoadon.Text + "',SL ='" + txtsoluong.Text + "',TL ='" + txttrongluongtong.Text + "',TP ='" +dtg2.Rows[0].Cells["MaTinh"].Value.ToString()+ "'  where [" + cmbdo.Text + "] like '%" + txtdo.Text + "%'";
                        comm.Connection = conn;
                        conn.Open();
                        comm.ExecuteNonQuery();
                        numberOfRecords = comm.ExecuteNonQuery();
                        conn.Close();

                    }
                }

                dataGridView1.DataSource = ReadExcelFile(cmbsheet.SelectedItem.ToString(), path);
                try
                {
                    if (txtsoluong.Text != "1")
                    {
                        //lay ra danh sach so kien cua cg
                        using (OleDbConnection conn = new OleDbConnection())
                        {
                            DataTable dt = new DataTable();
                            string excelfile = "D:\\InSony\\" + txtmaxcg.Text + ".xls";
                            string Import_FileName = excelfile;

                            string fileExtension = Path.GetExtension(Import_FileName);
                            if (fileExtension == ".xls")
                                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                            if (fileExtension == ".xlsx")
                                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                            using (OleDbCommand comm = new OleDbCommand())
                            {

                                // comm.CommandText = "Select * from [" + sheetName + "] where CG = '"+ socg+ "'";
                                // comm.CommandText = "Select * from [Sheet1$] where CG = " + txtsocg.Text;
                                comm.CommandText = "Select * from [Sheet1$]";
                                comm.Connection = conn;

                                using (OleDbDataAdapter da = new OleDbDataAdapter())
                                {
                                    da.SelectCommand = comm;
                                    dt.Rows.Clear();
                                    da.Fill(dt);
                                    if (dt.Rows.Count <= 10)
                                    {
                                        int sttkien = 1;
                                        foreach (DataRow row in dt.Rows)
                                        {

                                            sokien = sokien + "K" + sttkien + ": " + String.Format("{0:0,0}", float.Parse(row["TL"].ToString())) + "; ";
                                            sttkien = sttkien + 1;
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        //sokien = "Số kiện : 1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check MailerID");
                }
                //de ham in phieu gui o day
                if (numberOfRecords > 0)
                {
                    inphieugui();
                }
                else
                {
                    MessageBox.Show("Cập nhật CG, SL,TL,TP,HD lên plan không thành công. Vui lòng thử lại");
                }
                // MessageBox.Show("Đã in");

                //tang so phieu len 1
                // txtsocg.Text = (int.Parse(txtsocg.Text) + 1).ToString();
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            //in bang ke neu 10 kien


            txtdo.Focus();
        }
        private void inphieugui()
        {
            if (rdblien.Checked == true)
            {
                // in phieu gui
                RptCG1Sony rpt = new RptCG1Sony();
                string papername = string.Empty;
                int i = 0;
                System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();
                //  doctoprint.PrinterSettings.PrinterName = "\\\\RD2\\Epson LX-300+";
                int rawKind = 0;
                for (i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
                {
                    if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "CG1")
                    {
                        rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField("kind", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
                        papername = "CG1";
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
                if (papername == "CG1")
                {
                    TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbc"];
                    _txtbc.Text = "BDUG";
                    TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                    _txtghichu.Text = txtghichu.Text;
                    TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                    _txtnguoigui.Text = txtnguoigui.Text;
                    TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                    _txtnguoinhan.Text = dtg2.Rows[0].Cells["ShipName"].Value.ToString();
                    TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                    _txtdiadiem.Text = dtg2.Rows[0].Cells["Remark"].Value.ToString(); 
                    TextObject _diachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                    _diachi.Text =  dtg2.Rows[0].Cells["ShipStreet"].Value.ToString();
                    TextObject _txttp = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttp"];
                    _txttp.Text = dtg2.Rows[0].Cells["TenTinh"].Value.ToString();
                    TextObject _txthd = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthd"];
                    _txthd.Text = txthoadon.Text; 
                    TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                    _txtnvnhan.Text = txtnvnhan.Text; 
                    TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                    _txtsoluong.Text = txtsoluong.Text; 
                    TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                    _txttrongluong.Text = txttrongluongtong.Text;
                    TextObject _txtngay = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngay"];
                    _txtngay.Text = txtngaygui.Text;
                    TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                    _txtsokien.Text = sokien;


                    rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                    rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);


                }
                else
                {
                    MessageBox.Show("Vui lòng nhận chọn lại máy in mặc định. Kiểm tra khổ giấy đã tạo là CG1(24x15in)");
                }
            }
            else if (rdba5.Checked == true)
            {
                RptSony_A5 rpt = new RptSony_A5();
                TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbc"];
                _txtbc.Text = "BDUG";
                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = txtghichu.Text;
                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = txtnguoigui.Text;
                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = dtg2.Rows[0].Cells["ShipName"].Value.ToString(); 
                TextObject _diachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _diachi.Text =  dtg2.Rows[0].Cells["ShipStreet"].Value.ToString();

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = dtg2.Rows[0].Cells["Remark"].Value.ToString();

                TextObject _txtdiadiem1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem1"];
                _txtdiadiem1.Text = dtg2.Rows[0].Cells["Remark"].Value.ToString(); 

                TextObject _txttp = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txttp.Text = dtg2.Rows[0].Cells["TenTinh"].Value.ToString();
                TextObject _txthd = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthd"];
                _txthd.Text = txthoadon.Text; ;
                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnhanvien"];
                _txtnvnhan.Text = txtnvnhan.Text; ;
                TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsl"];
                _txtsoluong.Text = txtsoluong.Text; ;
                TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                _txttrongluong.Text = String.Format("{0:0,0}", float.Parse(txttrongluongtong.Text));

                TextObject _txttrongluongkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttrongluongkhoi.Text = String.Format("{0:0,0}", float.Parse(txttrongluongtong.Text));

                

                TextObject _txtngay = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngay.Text = txtngaygui.Text;
                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = sokien;

                TextObject _txtphieugui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphieugui"];
                _txtphieugui.Text = "*" + txtmaxcg.Text + "*";

                TextObject _txtphieugui1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphieugui1"];
                _txtphieugui1.Text =  txtmaxcg.Text ;

                TextObject _txtdo = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtdo.Text = do_num;

                TextObject _txtsists = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtsists.Text = si_sts.ToString() + " " + txtghichu.Text;



                // rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);
                if (int.Parse(txtsoluong.Text) > 10)
                {
                    try
                    {

                        if (File.Exists("D:\\InSony\\" + txtmaxcg.Text + ".xls") == true)
                        {
                            FrmSonyPrint.sheet = "Sheet1$";
                            FrmSonyPrint.socg = txtmaxcg.Text;
                            FrmSonyPrint.path = "D:\\InSony\\" + txtmaxcg.Text + ".xls";
                            FrmSonyPrint frmsonyprint = new FrmSonyPrint();
                            frmsonyprint.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                    }
                }
                //sau khi in thanh cong se them so thu tu vao phieu gui
                
                txthoadon.Text = "";
                txtsoluong.Text = "1";
                //cmbtp.Text = "...";
                txttrongluongtong.Text = "";
            }


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
        private void txtdo_Enter(object sender, EventArgs e)
        {
            txtdo.SelectAll();
        }

        private void txtsocg_Enter(object sender, EventArgs e)
        {
            txtsocg.SelectAll();
        }


        private void txthoadon_Enter(object sender, EventArgs e)
        {
            txthoadon.SelectAll();
        }

        private void txttrongluong_Enter(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                txttrongluong.SelectAll();
                if (int.Parse(txtsoluong.Text) > 1)
                {
                    FrmTLCan frmtlcan = new FrmTLCan();
                    FrmTLCan.socg = txtmaxcg.Text;
                    FrmTLCan.soluog = txtsoluong.Text;
                    frmtlcan.send = new FrmTLCan.SendTL(GetValue);
                    frmtlcan.ShowDialog();
                    frmtlcan.send = new FrmTLCan.SendTL(GetValue);
                    //this.txttrongluongtong.Text = total;
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại trọng lượng");
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
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
        private void create_excel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            string excelfile = "D:\\InSony\\Excel\\Sony_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
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

            string _ngaynhan;
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
            string data;
            int i = 0;
            int j = 0;

            DsExcel dsexcel = new DsExcel();
            DataTable dt = new DataTable();
            dt = ReadExcelFile1(cmbsheet.Text, path);

            foreach (DataRow row in dt.Rows)
            {
                try
                {

                    _ngaynhan = txtngaygui.Text;
                }
                catch (Exception ex)
                {
                    _ngaynhan = "";
                }

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
                    _tenduong = row[cmbdiachi.Text].ToString();
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
                    _tinhthanh = row["TP"].ToString();

                }
                catch (Exception ex)
                {
                    _tinhthanh = "";
                }

                _ghichu = row[cmbdo.Text].ToString() + "/" + row["HD"].ToString();
                dsexcel.Excel.AddExcelRow(DateTime.Parse(_ngaynhan).ToString("MM/dd/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong, _tinhthanh, _quanhuyen, _ghichu,"","","","","","","","");

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
            // MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");

        }
        private DataTable ReadExcelFile1(string sheetName, string path)
        {

            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    //comm.CommandText = "Select distinct * from [" + sheetName + "]";
                    comm.CommandText = "select count(CG),CG,SL,TL,TP,HD," + cmbdo.Text + "," + cmbdiachi.Text + " from [" + sheetName + "] group by CG,SL,TL,TP,HD," + cmbdo.Text + "," + cmbdiachi.Text + "  having COUNT(CG) > 0";
                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;

                    }

                }
            }
        }

        private void txtsoluong_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                soluong = 0;
                soluong = int.Parse(txtsoluong.Text);
                lbllancan.Text = "0/" + soluong.ToString();
            }
            catch (Exception ex)
            {
            }

        }

        private void btninbangke_Click(object sender, EventArgs e)
        {
            //danhsachkien();
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // txtsocg.Text = (int.Parse(txtsocg.Text) + 1).ToString();
            string bef = txtsocg.Text.Substring(0, 8);
            int aft = int.Parse(txtsocg.Text.Substring(8, 4)) + 1;
            string new_aft = "";
            if (aft.ToString().Length == 1)
            {
                new_aft = "000" + aft.ToString();
            }
            else if (aft.ToString().Length == 2)
            {
                new_aft = "00" + aft.ToString();
            }
            else if (aft.ToString().Length == 3)
            {
                new_aft = "0" + aft.ToString();
            }
            else if (aft.ToString().Length == 4)
            {
                new_aft = aft.ToString();
            }
            txtsocg.Text = bef + new_aft;
        }

        private void txttrongluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txttrongluong.Text.ToString().Length == 13)
            {
                //txttrongluongtong.Text = int.Parse((txttrongluong.Text.ToString().Substring(7, 5));
                txttrongluongtong.Text =  txttrongluong.Text.ToString().Substring(7,5);
            }
            else if (txttrongluong.Text.ToString().Length != 13)
            {
                txttrongluongtong.Text = txttrongluong.Text;
            }
            

        }

        private void lbllancan_DoubleClick(object sender, EventArgs e)
        {
            if (txtsocg.Enabled == true)
            {
                txtsocg.Enabled = false;
            }
            else if (txtsocg.Enabled == false)
            {
                txtsocg.Enabled = true;
            }
        }

        private void lbllancan_Click(object sender, EventArgs e)
        {
            if (txtmaxcg.Enabled == true)
            {
                txtmaxcg.Enabled = false;
            }
            else if (txtmaxcg.Enabled == false)
            {
                txtmaxcg.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text != "1")
                {
                    //lay ra danh sach so kien cua cg
                    using (OleDbConnection conn = new OleDbConnection())
                    {
                        DataTable dt = new DataTable();
                        string excelfile = "D:\\InSony\\" + txtsocg.Text + ".xls";
                        string Import_FileName = excelfile;

                        string fileExtension = Path.GetExtension(Import_FileName);
                        if (fileExtension == ".xls")
                            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                        if (fileExtension == ".xlsx")
                            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                        using (OleDbCommand comm = new OleDbCommand())
                        {

                            // comm.CommandText = "Select * from [" + sheetName + "] where CG = '"+ socg+ "'";
                            // comm.CommandText = "Select * from [Sheet1$] where CG = " + txtsocg.Text;
                            comm.CommandText = "Select * from [Sheet1$]";
                            comm.Connection = conn;

                            using (OleDbDataAdapter da = new OleDbDataAdapter())
                            {
                                da.SelectCommand = comm;
                                dt.Rows.Clear();
                                da.Fill(dt);
                                if (dt.Rows.Count <= 10)
                                {
                                    int sttkien = 1;
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        sokien = sokien + "K" + sttkien + ": " + row["TL"].ToString() + "; ";
                                        sttkien = sttkien + 1;
                                    }
                                }


                            }

                        }
                    }
                }
                else
                {
                    //sokien = "Số kiện : 1";
                }
                RptSony_A5 rpt = new RptSony_A5();
                TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbc"];
                _txtbc.Text = "BDUG";
                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = txtghichu.Text;
                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = txtnguoigui.Text;
                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = dtg2.Rows[0].Cells["ShipName"].Value.ToString();
                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = dtg2.Rows[0].Cells["Remark"].Value.ToString(); 
                TextObject _diachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _diachi.Text = dtg2.Rows[0].Cells["ShipStreet"].Value.ToString();
                TextObject _txttp = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txttp.Text = dtg2.Rows[0].Cells["TenTinh"].Value.ToString();
                TextObject _txthd = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthd"];
                _txthd.Text = txthoadon.Text; ;
                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnhanvien"];
                _txtnvnhan.Text = txtnvnhan.Text; ;
                TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsl"];
                _txtsoluong.Text = txtsoluong.Text; ;
                TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                _txttrongluong.Text = txttrongluongtong.Text;

                TextObject _txttrongluongkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttrongluongkhoi.Text = txttrongluongtong.Text;

                TextObject _txtngay = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngay.Text = txtngaygui.Text;
                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = sokien;

                TextObject _txtphieugui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphieugui"];
                _txtphieugui.Text = "*" + txtsocg.Text + "*";

                TextObject _txtphieugui1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphieugui1"];
                _txtphieugui1.Text =   txtsocg.Text ;

                TextObject _txtdo = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtdo.Text = do_num;

                TextObject _txtsists = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtsists.Text = si_sts.ToString() + " " + txtghichu.Text;



                // rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);

                if (int.Parse(txtsoluong.Text) > 10)
                {
                    try
                    {
                        FrmSonyPrint.sheet = "Sheet1$";
                        FrmSonyPrint.socg = txtsocg.Text;
                        FrmSonyPrint.path = "D:\\InSony\\" + txtsocg.Text + ".xls";
                        FrmSonyPrint frmsonyprint = new FrmSonyPrint();
                        frmsonyprint.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                    }
                }
               
                txthoadon.Text = "";
                txtsocg.Text = "1";
                //cmbtp.Text = "...";
                txttrongluongtong.Text = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void btndoanhthu_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string path  = openFileDialog2.FileName;
            FrmSonyDT.path = path;
            FrmSonyDT frmsonydt = new FrmSonyDT();
            frmsonydt.ShowDialog();
        }

        private void txthoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnin.Focus();
            }
        }

        private void txtdo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsoluong.Focus();
            }
        }

        private void cmbtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsoluong.Focus();
            }
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttrongluong.Focus();
            }
        }

        private void txttrongluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txthoadon.Focus();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void label21_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void cmbparty_Enter(object sender, EventArgs e)
        {
            cmbparty.DataSource = listparty;
        }

        

        
    }
}
