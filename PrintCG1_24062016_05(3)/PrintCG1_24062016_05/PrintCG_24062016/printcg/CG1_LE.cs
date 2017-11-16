using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using PrintCG_24062016.dataset;
using PrintCG_24062016.Report;
namespace PrintCG_24062016
{
    public partial class CG1_LE : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public CG1_LE()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }
        static string NullToString(object Value)
        {
            return Value == null ? "" : Value.ToString();
        }
        private void CG1_LE_Load(object sender, EventArgs e)
        {
            txtbuucuc.Text = FrmMain1.postofficeid;
            txtnhanvien.Text = FrmMain1.user;
            load_settings();
            loadsophieu();
            
        }
        private void loadsophieu()
        {
            txtsophieu.Text = sgpservice.getmaxMailerID("SGP");           
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void Nguoigui(AutoCompleteStringCollection col)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select Nguoigui from tb_auto";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                col.Add(row["Nguoigui"].ToString());
            }
        }
        public void Nguoinhan(AutoCompleteStringCollection col)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select Nguoinhan from tb_auto";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                col.Add(row["Nguoinhan"].ToString());
            }
        }
        public void Diachinhan(AutoCompleteStringCollection col)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select Diachinhan from tb_auto";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                col.Add(row["Diachinhan"].ToString());
            }
           
        }
        public void noiden(AutoCompleteStringCollection col)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select Matinh from tb_tinhthanh";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                col.Add(row["Matinh"].ToString());
            }

        }
             public void addlh(AutoCompleteStringCollection col)
             {
                 col.Add("T");
                 col.Add("H");
             }
             public void adddv(AutoCompleteStringCollection col)
             {
                 col.Add("SN");
                 col.Add("ST");
                 col.Add("HG");
             }
             private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
             {
                 
             }

             private void myGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
             {
                 try
                 {
                     string titleText = myGrid1.Columns[myGrid1.CurrentCell.ColumnIndex].HeaderText;
                     string colname = myGrid1.Columns[myGrid1.CurrentCell.ColumnIndex].Name;
                     TextBox autoText = e.Control as TextBox;
                     ComboBox combo = e.Control as ComboBox;
                     if (titleText.Equals("LH"))
                     {
                         autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                         autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                         //autoText.AutoCompleteSource = AutoCompleteSource.ListItems;
                         AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                         addlh(DataCollection);
                         autoText.AutoCompleteCustomSource = DataCollection;
                     }
                     else if (titleText.Equals("DV"))
                     {
                         autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                         autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                         //autoText.AutoCompleteSource = AutoCompleteSource.ListItems;
                         AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                         adddv(DataCollection);
                         autoText.AutoCompleteCustomSource = DataCollection;

                     }
                     else if (colname.Equals("Provinceid"))
                     {
                         autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                         autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                         //autoText.AutoCompleteSource = AutoCompleteSource.ListItems;
                         AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                         noiden(DataCollection);
                         autoText.AutoCompleteCustomSource = DataCollection;

                     }
                     else if (colname.Equals("Districtid"))
                     {


                     }
                     else if (titleText.Equals("TL"))
                     {


                     }
                     else if (titleText.Equals("Người gửi"))
                     {
                         if (autoText != null)
                         {
                             autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                             autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                             AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                             Nguoigui(DataCollection);
                             autoText.AutoCompleteCustomSource = DataCollection;
                         }

                     }
                     else if (titleText.Equals("Người nhận"))
                     {
                         if (autoText != null)
                         {
                             autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                             autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                             AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                             Nguoinhan(DataCollection);
                             autoText.AutoCompleteCustomSource = DataCollection;
                         }

                     }
                     else if (titleText.Equals("Địa chỉ nhận"))
                     {
                         if (autoText != null)
                         {
                             autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                             autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                             AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                             Diachinhan(DataCollection);
                             autoText.AutoCompleteCustomSource = DataCollection;
                         }

                     }
                     else
                     {
                         autoText.AutoCompleteMode = AutoCompleteMode.None;
                     }
                 }
                 catch (Exception ex)
                 {
                 }              
             }
          
             private void myGrid1_RowLeave(object sender, DataGridViewCellEventArgs e)
             {
                 string nguoigui = string.Empty;
                 string diachigui = string.Empty;
                 string sdtgui = string.Empty;
                 string nguoinhan = string.Empty;
                 string diachinhan = string.Empty;
                 string sdtnhan = string.Empty;
                 string thanhpho = string.Empty;
                 string quanhuyen = string.Empty;
                 try
                 {
                     nguoigui = NullToString(myGrid1.CurrentRow.Cells["Sender"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     nguoigui = "";
                 }

                 try
                 {
                     diachigui = NullToString(myGrid1.CurrentRow.Cells["SenderAddress"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     diachigui = "";
                 }

                 try
                 {
                     sdtgui = NullToString(myGrid1.CurrentRow.Cells["SenderPhone"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     sdtgui = "";
                 }

                 try
                 {
                     nguoinhan = NullToString(myGrid1.CurrentRow.Cells["ReciverName"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     nguoinhan = "";
                 }

                 try
                 {
                     diachinhan = NullToString(myGrid1.CurrentRow.Cells["Address"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     diachinhan = "";
                 }

                 try
                 {
                     sdtnhan = NullToString(myGrid1.CurrentRow.Cells["ReciverPhone"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     sdtnhan = "";
                 }

                 try
                 {
                     thanhpho = NullToString(myGrid1.CurrentRow.Cells["ProvinceName"].Value.ToString().ToUpper());
                     DataSet ds = new DataSet();
                     OleDbConnection conn = new OleDbConnection();
                     string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                     conn.ConnectionString = con;
                     OleDbCommand comm = new OleDbCommand();
                     conn.Open();
                     comm.CommandText = "Select Matinh from tb_tinhthanh where TenTinh = '"+ thanhpho +"'";
                     comm.Connection = conn;
                     OleDbDataAdapter da = new OleDbDataAdapter();
                     da.SelectCommand = comm;
                     da.Fill(ds);
                     thanhpho = ds.Tables[0].Rows[0][0].ToString();
                     
                 }
                 catch (Exception ex)
                 {
                     thanhpho = "";
                 }

                 try
                 {
                     quanhuyen = NullToString(myGrid1.CurrentRow.Cells["DistrictName"].Value.ToString().ToUpper());
                 }
                 catch (Exception ex)
                 {
                     quanhuyen = "";
                 }



                 try
                 {
                     DataSet ds = new DataSet();
                     OleDbConnection conn = new OleDbConnection();
                     string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                     conn.ConnectionString = con;
                     OleDbCommand comm = new OleDbCommand();
                     conn.Open();
                     comm.CommandText = "Select * from tb_auto where Nguoigui = '" + myGrid1.CurrentRow.Cells["Sender"].Value.ToString() + "' and Nguoinhan ='" + myGrid1.CurrentRow.Cells["ReciverName"].Value.ToString() + "' and Diachinhan = '" + myGrid1.CurrentRow.Cells["Address"].Value.ToString() + "'";
                     comm.Connection = conn;
                     OleDbDataAdapter da = new OleDbDataAdapter();
                     da.SelectCommand = comm;
                     da.Fill(ds);
                     if (ds.Tables[0].Rows.Count == 0)
                     {
                         string query = "insert into tb_auto(Nguoigui,Diachigui,SDTgui,Nguoinhan,Diachinhan,SDTnhan,Thanhpho,Quanhuyen) values('" + nguoigui + "','" + diachigui + "','" + sdtgui + "','" + nguoinhan + "','" + diachinhan + "','" + sdtnhan + "','" + thanhpho + "','" + quanhuyen + "')  ";
                         OleDbCommand cmd = new OleDbCommand(query, conn);
                         cmd.ExecuteNonQuery();
                     }
                 }
                 catch (Exception ex)
                 {
                 }           
             }

             private void myGrid1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
             {
                 try
                 {
                     string headerText = myGrid1.Columns[e.ColumnIndex].HeaderText;
                     if (headerText.Equals("LH"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || ((e.FormattedValue.ToString().ToUpper()) != "T" && (e.FormattedValue.ToString().ToUpper()) != "H"))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Loại hàng nhập không đúng";
                             myGrid1.CurrentCell.Value = "";
                             e.Cancel = true;
                         }
                         else
                         {
                             e.Cancel = false;
                         }
                     }
                     else if (headerText.Equals("Số phiếu"))
                     {
                         //if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         //{
                         //    myGrid1.Rows[e.RowIndex].ErrorText = "Số phiếu không được bỏ trống";
                         //    myGrid1.CurrentCell.Value = "";
                         //    e.Cancel = true;
                         //}
                         string last = string.Empty;
                         try
                         {
                             last = (int.Parse(txtsophieu.Text.Substring(8, 4)) + 1).ToString();
                         }
                         catch (Exception ex)
                         {
                             last = (int.Parse(txtsophieu.Text.Substring(8, 4)) + 1).ToString();
                         }
                         if (last.Length == 1)
                         {
                             last = "000" + last;
                         }
                         else if (last.Length == 2)
                         {
                             last = "00" + last;
                         }
                         else if (last.Length == 3)
                         {
                             last = "0" + last;
                         }
                         if (string.IsNullOrEmpty(myGrid1.CurrentRow.Cells["MailerID"].Value as string))
                         // if ( myGrid1.CurrentRow.Cells["MailerID"].Value.ToString().Trim() == null)
                         {
                             myGrid1.CurrentRow.Cells["MailerID"].Value = txtsophieu.Text;
                             txtsophieu.Text = txtsophieu.Text.Substring(0, 8) + last;
                         }
                         
                         
                     }
                     else if (headerText.Equals("DV"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || ((e.FormattedValue.ToString().ToUpper()) != "SN" && (e.FormattedValue.ToString().ToUpper() != "ST") && (e.FormattedValue.ToString().ToUpper()) != "HG"))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Dịch vụ không đúng";
                             myGrid1.CurrentCell.Value = "";
                             e.Cancel = true;
                         }
                         else
                         {
                             e.Cancel = false;
                         }
                     }
                     else if (headerText.Equals("SL"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Số lượng không được bỏ trống";
                             myGrid1.CurrentCell.Value = 1;
                             e.Cancel = true;
                         }
                     }
                     else if (headerText.Equals("TL"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Trọng lượng không được bỏ trống";
                             myGrid1.CurrentCell.Value = "";
                             e.Cancel = true;
                         }
                         else
                         {
                             myGrid1.CurrentRow.Cells["RealWeight"].Value = e.FormattedValue.ToString();
                         }
                     }
                     else if (headerText.Equals("TL khối"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Trọng lượng khối không được bỏ trống";
                             myGrid1.CurrentCell.Value = myGrid1.CurrentRow.Cells["Realweight"].Value;
                             e.Cancel = true;
                         }
                         else
                         {
                             myGrid1.CurrentRow.Cells["RealWeight"].Value = e.FormattedValue.ToString();
                         }
                     }
                     else if (headerText.Equals("Người gửi"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Người gửi không được bỏ trống";
                            // myGrid1.CurrentCell.Value = myGrid1.CurrentRow.Cells["Realweight"].Value;
                             e.Cancel = true;
                         }
                         else
                         {
                             DataSet ds = new DataSet();
                             OleDbConnection conn = new OleDbConnection();
                             string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                             conn.ConnectionString = con;
                             OleDbCommand comm = new OleDbCommand();
                             conn.Open();
                             comm.CommandText = "Select * from tb_auto where Nguoigui = '" + e.FormattedValue.ToString() + "'";
                             comm.Connection = conn;
                             OleDbDataAdapter da = new OleDbDataAdapter();
                             da.SelectCommand = comm;
                             da.Fill(ds);
                             if (ds.Tables[0].Rows.Count > 0)
                             {
                                 myGrid1.CurrentRow.Cells["SenderAddress"].Value = ds.Tables[0].Rows[0]["Diachigui"].ToString();
                                 myGrid1.CurrentRow.Cells["SenderPhone"].Value = ds.Tables[0].Rows[0]["SDTgui"].ToString();
                                 myGrid1.CurrentRow.Cells["ReciverName"].Value = ds.Tables[0].Rows[0]["Nguoinhan"].ToString();
                                 myGrid1.CurrentRow.Cells["Address"].Value = ds.Tables[0].Rows[0]["Diachinhan"].ToString();
                                 myGrid1.CurrentRow.Cells["ReciverPhone"].Value = ds.Tables[0].Rows[0]["SDTnhan"].ToString();
                                 //string SelectedText = Convert.ToString((myGrid1.CurrentRow.Cells["Provinceid"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                                 //int SelectedVal = Convert.ToInt32(myGrid1.CurrentRow.Cells["Provinceid"].Value);
                                 myGrid1.CurrentRow.Cells["Districtid"].Value = ds.Tables[0].Rows[0]["Quanhuyen"].ToString();
                                 myGrid1.CurrentRow.Cells["ProvinceID"].Value = ds.Tables[0].Rows[0]["Thanhpho"].ToString();
                             }
                         }

                     }
                     else if (headerText.Equals("Người nhận"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Người gửi không được bỏ trống";
                             //myGrid1.CurrentCell.Value = myGrid1.CurrentRow.Cells["Realweight"].Value;
                             e.Cancel = true;
                         }
                         else
                         {
                             DataSet ds = new DataSet();
                             OleDbConnection conn = new OleDbConnection();
                             string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                             conn.ConnectionString = con;
                             OleDbCommand comm = new OleDbCommand();
                             conn.Open();
                             comm.CommandText = "Select * from tb_auto where Nguoinhan = '" + e.FormattedValue.ToString() + "'";
                             comm.Connection = conn;
                             OleDbDataAdapter da = new OleDbDataAdapter();
                             da.SelectCommand = comm;
                             da.Fill(ds);
                             if (ds.Tables[0].Rows.Count > 0)
                             {
                                 myGrid1.CurrentRow.Cells["Address"].Value = ds.Tables[0].Rows[0]["Diachinhan"].ToString();
                                 myGrid1.CurrentRow.Cells["ReciverPhone"].Value = ds.Tables[0].Rows[0]["SDTnhan"].ToString();
                                 //string SelectedText = Convert.ToString((myGrid1.CurrentRow.Cells["Provinceid"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                                 //int SelectedVal = Convert.ToInt32(myGrid1.CurrentRow.Cells["Provinceid"].Value);
                                 myGrid1.CurrentRow.Cells["Districtid"].Value = ds.Tables[0].Rows[0]["Quanhuyen"].ToString();
                             }
                         }
                     }
                     else if (headerText.Equals("Địa chỉ nhận"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Địa chỉ nhận không được bỏ trống";
                             //myGrid1.CurrentCell.Value = 1;
                             e.Cancel = true;
                         }
                     }
                     else if (headerText.Equals("Thành phố"))
                     {

                         Boolean flag = false;
                         DataSet ds = new DataSet();
                         OleDbConnection conn = new OleDbConnection();
                         string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                         conn.ConnectionString = con;
                         OleDbCommand comm = new OleDbCommand();
                         conn.Open();
                         comm.CommandText = "Select Matinh from tb_tinhthanh";
                         comm.Connection = conn;
                         OleDbDataAdapter da = new OleDbDataAdapter();
                         da.SelectCommand = comm;
                         da.Fill(ds);
                         conn.Close();
                         foreach (DataRow row in ds.Tables[0].Rows)
                         {
                             if (e.FormattedValue.ToString().ToUpper() == row["Matinh"].ToString())
                             {
                                 flag = true;
                                 break;
                             }
                             
                         }
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Nơi đến không được bỏ trống";
                             myGrid1.CurrentCell.Value = "";
                             e.Cancel = true;
                            
                         }
                         else if (flag == false)
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Nơi đến không đúng";
                             e.Cancel = true;                           
                         }
                         else
                         {
                             DataSet ds1 = new DataSet();
                             conn.ConnectionString = con;
                             OleDbCommand comm1 = new OleDbCommand();
                             conn.Open();
                             comm1.CommandText = "Select TenTinh from tb_tinhthanh where MaTinh = '" + e.FormattedValue.ToString() + "'";
                             comm1.Connection = conn;
                             OleDbDataAdapter da1 = new OleDbDataAdapter();
                             da1.SelectCommand = comm1;
                             da1.Fill(ds1);
                             conn.Close();
                             myGrid1.CurrentRow.Cells["ProvinceName"].Value = ds1.Tables[0].Rows[0]["TenTinh"].ToString() ;//
                         }
                         
                     }
                     else if (headerText.Equals("Quận/Huyện"))
                     {

                         myGrid1.CurrentRow.Cells["DistrictName"].Value = e.FormattedValue.ToString();

                     }
                     else if (headerText.Equals("Ngày nhận"))
                     {
                         if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                         {
                             myGrid1.Rows[e.RowIndex].ErrorText = "Ngày nhận không được bỏ trống";
                             myGrid1.CurrentCell.Value = dtppgi.Value.ToShortDateString();
                             e.Cancel = true;
                         }                                                                     
                     }
                 }
                 catch (Exception ex)
                 {
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
                     MessageBox.Show(ex.ToString());
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

                 string excelfile = txtfolder.Text.Trim() + "\\Excel\\" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
                 Excel.Workbook xlWorkBook;
                 Excel.Worksheet xlWorkSheet;
                 object misValue = System.Reflection.Missing.Value;

                 xlWorkBook = xlApp.Workbooks.Add(misValue);
                 xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                 //số phiếu, ngày nhận, lh, sl,tl ,tl khối, dv, thành phố, quận huyện, người nhận, địa chỉ nhận, ghi chú, bp, giờ nhận.

                 xlWorkSheet.Cells[1, 1] = "Ngày nhận";
                 xlWorkSheet.Cells[1, 2] = "Số phiếu";
                 xlWorkSheet.Cells[1, 3] = "LH";
                 xlWorkSheet.Cells[1, 4] = "DV";
                 xlWorkSheet.Cells[1, 5] = "SL";
                 xlWorkSheet.Cells[1, 6] = "TL";
                 xlWorkSheet.Cells[1, 7] = "TL Khối";
                 //thong tin nguoi gui
                 xlWorkSheet.Cells[1, 8] = "Họ Tên(Gửi)";
                 xlWorkSheet.Cells[1, 9] = "Địa chỉ(Gửi)";
                 xlWorkSheet.Cells[1, 10] = "Điện thoại(Gửi)";
                 //thong tin nguoi nhan
                 xlWorkSheet.Cells[1, 11] = "Người nhận";
                 xlWorkSheet.Cells[1, 12] = "Tên đường(Nhận)";
                 xlWorkSheet.Cells[1, 13] = "T/Thành(NĐ)";

                 xlWorkSheet.Cells[1, 14] = "Cước";
                 xlWorkSheet.Cells[1, 15] = "Thu#";
                 xlWorkSheet.Cells[1, 16] = "Hẹn giờ";


                 xlWorkSheet.Cells[1, 17] = "Quận/Huyện(Nhận)";
                 //xlWorkSheet.Cells[1, 14] = "Q/Huyện(Nhận)";
                 xlWorkSheet.Cells[1, 18] = "Điện thoại(Nhận)";

                 xlWorkSheet.Cells[1, 19] = "Ghi chú";
                 xlWorkSheet.Cells[1, 20] = "BP";

                 xlWorkSheet.Cells[1, 21] = "Tên Tỉnh Thành";
                 xlWorkSheet.Cells[1, 22] = "Tên Quận Huyện";

                 xlWorkSheet.Cells[1, 23] = "Giờ";

                 //bo sung them cac cot khac theo yeu cau cua HNI

                 xlWorkSheet.Cells.NumberFormat = "@";

                 string _ngaynhan = dtppgi.Value.ToString();               
                 string data;
                 int i = 0;
                 int j = 0;

                 dataset.DsExcel dsexcel = new dataset.DsExcel();
                 DataTable dt = new DataTable();
                                 
                 for (i = 0; i <= myGrid1.Rows.Count - 1; i++)
                 {
                     for (j = 0; j <= myGrid1.Columns.Count - 1; j++)
                     {
                         try
                         {

                             data = myGrid1.Rows[i].Cells[j].Value.ToString().ToUpper();
                             i = i + 1;
                             if (myGrid1.Columns[j].HeaderText == "LH")
                             {
                                 if (data == "T")
                                 {
                                     data = "TL";
                                 }
                                 else
                                 {
                                     data = "HH";
                                 }
                             }
                             xlWorkSheet.Cells[i + 1, j + 1] = data;
                             i = i - 1;
                         }
                         catch (Exception ex)
                         {

                         }                         
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
             private void releaseObject(object obj)
             {
                 try
                 {
                     System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                     System.Runtime.InteropServices.Marshal.FinalReleaseComObject(obj);
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

             private void btnina5_Click(object sender, EventArgs e)
             {
                string sophieu = string.Empty;
                 RptPhieuGui_A5 rpt = new RptPhieuGui_A5();
                 try
                 {
                     foreach (DataGridViewRow row in myGrid1.Rows)
                     {
                         try
                         {
                             TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbuucuc"];
                             _txtbcnhan.Text = txtbuucuc.Text;

                             TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu"];
                             _txtDO.Text = "*" + row.Cells["MailerID"].Value.ToString() + "*";                       

                             TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu1"];
                             _txtDO1.Text = row.Cells["MailerID"].Value.ToString();
                             sophieu = _txtDO1.Text;

                             TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                             _txtnguoigui.Text = row.Cells["Sender"].Value.ToString();

                             TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                             try
                             {
                                 _txtdiachigui.Text = row.Cells["SenderAddress"].Value.ToString();
                             }
                             catch (Exception ex)
                             {
                                 _txtdiachigui.Text = "";
                             }

                             TextObject _txttelgui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelgui"];
                             try
                             {
                                 _txttelgui.Text = row.Cells["SenderPhone"].Value.ToString();
                             }
                             catch (Exception ex)
                             {
                                 _txttelgui.Text = "";
                             }

                             TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                             _txtnvnhan.Text = txtnhanvien.Text;

                             TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                             _txtngaynhan.Text = row.Cells["AcceptDate"].Value.ToString();

                             TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                             _txtnguoinhan.Text = row.Cells["ReciverName"].Value.ToString();

                             TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                             _txtdiachinhan.Text = row.Cells["Address"].Value.ToString();

                             TextObject _txttelnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelnhan"];
                             try
                             {
                                 _txttelnhan.Text = row.Cells["ReciverPhone"].Value.ToString();
                             }
                             catch (Exception ex)
                             {
                                 _txttelnhan.Text = "";
                             }

                             TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                             try
                             {
                                 _txtghichu.Text = row.Cells["Description"].Value.ToString();
                             }
                             catch (Exception ex)
                             {
                                 _txtghichu.Text = "";
                             }

                             TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                             _txtsl.Text = row.Cells["Quantity"].Value.ToString();

                             TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                             _txttl.Text = String.Format("{0:0,0}", float.Parse(row.Cells["Weight"].Value.ToString()));


                             TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluongkhoi"];
                             _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(row.Cells["RealWeight"].Value.ToString()));

                             TextObject _txtthanhpho = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnoiden"];
                             _txtthanhpho.Text = row.Cells["Provinceid"].Value.ToString();

                             TextObject _txtcuochinh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtcuocchinh"];
                             _txtcuochinh.Text = row.Cells["Price"].Value.ToString();

                             TextObject _txthengio = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthengio"];
                             _txthengio.Text = row.Cells["Timer"].Value.ToString();

                             TextObject _txtphikhac = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphikhac"];
                             _txtphikhac.Text = row.Cells["Priceservice"].Value.ToString();

                             TextObject _txttongcong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttongcong"];
                             _txttongcong.Text = (int.Parse(row.Cells["Price"].Value.ToString()) + int.Parse(row.Cells["Timer"].Value.ToString()) + int.Parse(row.Cells["Priceservice"].Value.ToString())).ToString();

                             TextObject _txttailieu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                             TextObject _txthanghoa = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthh"];
                             if (row.Cells["Mailertypeid"].Value.ToString().ToUpper() == "T")
                             {
                                 _txttailieu.Text = "X";
                                 _txthanghoa.Text = "";
                             }
                             else if (row.Cells["Mailertypeid"].Value.ToString().ToUpper() == "H")
                             {
                                 _txttailieu.Text = "";
                                 _txthanghoa.Text = "X";
                             }
                             rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);
                         }
                         catch (Exception ex)
                         {

                             
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.ToString());
                 }
             }

             private void myGrid1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
             {
                 if (txtsophieu.Text != "")
                 {
                     e.Row.Cells["Acceptdate"].Value = dtppgi.Value.ToShortDateString();                    
                     e.Row.Cells["BP"].Value ="0";
                     e.Row.Cells["Price"].Value = "0";
                     e.Row.Cells["Priceservice"].Value = "0";
                     e.Row.Cells["Timer"].Value = "0";
                     e.Row.Cells["Mailertypeid"].Value = "T";
                     e.Row.Cells["Servicetypeid"].Value = "SN";
                     e.Row.Cells["Mailerid"].Value = txtmacg.Text.Trim() + txtsophieu.Text.Trim();
                 }
                 else
                 {
                     MessageBox.Show("Chưa nhập số phiếu");
                     e.Row.Cells["Acceptdate"].Value = dtppgi.Value.ToShortDateString();


                 }
                 //MessageBox.Show(e.Row.Index.ToString());
             }

             private void load_settings()
             {
                 txtsophieu.Text = (String)Application.UserAppDataRegistry.GetValue("frminle.txtsophieu", String.Empty);
                // txtbuucuc.Text = (String)Application.UserAppDataRegistry.GetValue("frminle.txtbuucuc", String.Empty);
                // txtnhanvien.Text = (String)Application.UserAppDataRegistry.GetValue("frminle.txtnhanvien", String.Empty);
                 txtmacg.Text = (String)Application.UserAppDataRegistry.GetValue("frminle.txtmacg", String.Empty);
                 txtsophieu.Text = (String)Application.UserAppDataRegistry.GetValue("frminle.txtsophieu", String.Empty);  
             }
             private void save_settings()
             {
                 Application.UserAppDataRegistry.SetValue("frminle.txtsophieu", txtsophieu.Text);
                 //Application.UserAppDataRegistry.SetValue("frminle.txtbuucuc", txtbuucuc.Text);
                 //Application.UserAppDataRegistry.SetValue("frminle.txtnhanvien", txtnhanvien.Text);
                 Application.UserAppDataRegistry.SetValue("frminle.txtmacg", txtmacg.Text);
                 Application.UserAppDataRegistry.SetValue("frminle.txtsophieu", txtsophieu.Text);
             }

             private void CG1_LE_FormClosing(object sender, FormClosingEventArgs e)
             {
                 if (myGrid1.Rows.Count == 2)
                 {
                     int stt; ;
                     string bef = string.Empty;
                     string aft = string.Empty;
                     string sophieu = string.Empty;
                     sophieu = myGrid1.Rows[0].Cells[1].Value.ToString();
                     bef = sophieu.Substring(txtmacg.Text.Length, 6);
                     aft = sophieu.Substring(6 + txtmacg.Text.Length, 4);
                     stt = int.Parse(aft);
                     if (stt.ToString().Length == 1)
                     {
                         aft = "000" + (stt + 1).ToString();
                     }
                     else if (stt.ToString().Length == 2)
                     {
                         aft = "00" + (stt + 1).ToString();
                     }
                     else if (stt.ToString().Length == 3)
                     {
                         aft = "0" + (stt + 1).ToString();
                     }
                     else if (stt.ToString().Length == 4)
                     {
                         aft = (stt + 1).ToString();
                     }
                     txtsophieu.Text = bef + aft;
                 }
                 save_settings();
             }

             private void btnbaophat_Click(object sender, EventArgs e)
             {
                 RptBaoPhat rpt = new RptBaoPhat();
                 foreach (DataGridViewRow row in myGrid1.Rows)
                 {
                     if (row.Cells["BP"].Value.ToString() == "1")
                     {
                         TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbuucuc"];
                         _txtbcnhan.Text = txtbuucuc.Text;

                         TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu"];
                         _txtDO.Text = "*" + row.Cells["MailerID"].Value.ToString() + "*";

                         TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu1"];
                         _txtDO1.Text = row.Cells["MailerID"].Value.ToString();

                         TextObject _txtDO2 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu2"];
                         _txtDO2.Text = row.Cells["MailerID"].Value.ToString();

                         TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                         _txtnguoigui.Text = row.Cells["Sender"].Value.ToString();

                         TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                         _txtngaynhan.Text = row.Cells["Acceptdate"].Value.ToString();

                         TextObject _txtdiachiphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachiphat"];
                         _txtdiachiphat.Text = row.Cells["Address"].Value.ToString() + " " + row.Cells["Districtid"].Value.ToString() + " " + row.Cells["Provinceid"].Value.ToString() ;

                         rpt.PrintToPrinter(1, false, 1, 1);
                         
                     }
                 }

             }

             private void myGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
             {
                 if (e.Value != null)
                 {
                     e.Value = e.Value.ToString().ToUpper();
                     e.FormattingApplied = true;
                 }
             }

             private void myGrid1_KeyDown(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.Delete)
                 {
                     //kiem tra neu ton tai thi xoa trong db
                     foreach (DataGridViewRow item in this.myGrid1.SelectedRows)
                     {
                         try
                         {
                             myGrid1.Rows.RemoveAt(item.Index);
                         }
                         catch (Exception ex)
                         {
                         }
                     }
                 }
                 switch (e.KeyData & Keys.KeyCode)
                 {
                     case Keys.Up:
                     case Keys.Right:
                     case Keys.Down:
                     //case Keys.Left:
                         e.Handled = true;
                         e.SuppressKeyPress = true;
                         break;
                 }
             }

             private void myGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
             {
                 return;
             }

             private void txtmacg_KeyUp(object sender, KeyEventArgs e)
             {
                 txtsophieu.Text = txtmacg.Text + txtsophieu.Text;
             }

             private void myGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
             {
                 //dau tien la xac dinh index hien tai - di 1.
                 //xac dinh 4 so cuoi cua phieu gui dua vao index -1
                 int Rindex;
                 string sophieu = string.Empty;
                 string bef = string.Empty;
                 string aft = string.Empty;
                 int stt;
                 string headerText = myGrid1.Columns[e.ColumnIndex].HeaderText;
                 if (headerText.Equals("Số phiếu") && e.RowIndex == 0)
                 {
                     myGrid1.CurrentCell.Value = txtmacg.Text + txtsophieu.Text;
                 }
                 else if (headerText.Equals("Số phiếu") && e.RowIndex > 0)
                 {
                     Rindex = e.RowIndex;
                     sophieu = myGrid1.Rows[Rindex - 1].Cells[1].Value.ToString();
                     bef = sophieu.Substring(txtmacg.Text.Length, 6);
                     aft = sophieu.Substring(6 + txtmacg.Text.Length, 4);
                     stt = int.Parse(aft);
                     if ((stt+ 1).ToString().Length == 1)
                     {
                         aft = "000" + (stt + 1).ToString();
                     }
                     else if ((stt+ 1).ToString().Length == 2)
                     {
                         aft = "00" + (stt + 1).ToString();
                     }
                     else if ((stt+ 1).ToString().Length == 3)
                     {
                         aft = "0" + (stt + 1).ToString();
                     }
                     else if ((stt+ 1).ToString().Length == 4)
                     {
                         aft = (stt + 1).ToString();
                     }
                     myGrid1.CurrentCell.Value = txtmacg.Text + bef + aft;
                     
                 }
                 if (headerText.Equals("Ghi chú") && e.RowIndex > 0)
                 {
                     Rindex = e.RowIndex;
                     sophieu = myGrid1.Rows[Rindex - 1].Cells[1].Value.ToString();
                     bef = sophieu.Substring(txtmacg.Text.Length, 6);
                     aft = sophieu.Substring(6 + txtmacg.Text.Length, 4);
                     stt = int.Parse(aft);
                     if (stt.ToString().Length == 1)
                     {
                         aft = "000" + (stt + 2).ToString();
                     }
                     else if (stt.ToString().Length == 2)
                     {
                         aft = "00" + (stt + 2).ToString();
                     }
                     else if (stt.ToString().Length == 3)
                     {
                         aft = "0" + (stt + 2).ToString();
                     }
                     else if (stt.ToString().Length == 4)
                     {
                         aft = (stt + 2).ToString();
                     }
                     txtsophieu.Text = bef + aft;
                 }
                 
             }

             private void btnbangke_Click(object sender, EventArgs e)
             {
                 DsCGLEBangKe dscg = new DsCGLEBangKe();
                 RptCGLEBangKE rpt = new RptCGLEBangKE();
                 string ngay = string.Empty;
                 string cg = string.Empty;
                 string sl = string.Empty;
                 string tl = string.Empty;
                 string tennhan = string.Empty;
                 string diachinhan = string.Empty;
                 string tp = string.Empty;
                 string ghichu = string.Empty;
                 string nguoigui = string.Empty;
                 string diachigui = string.Empty;
                 string baophat = string.Empty;
                 foreach (DataGridViewRow row in myGrid1.Rows)
                 {
                     try
                     {
                         ngay = row.Cells["Acceptdate"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         cg = row.Cells["Mailerid"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                         cg = "";
                     }

                     try
                     {
                         sl = row.Cells["Quantity"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         tl = row.Cells["Weight"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         tennhan = row.Cells["ReciverName"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         diachinhan = row.Cells["Address"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         tp = row.Cells["Provinceid"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         ghichu = row.Cells["Description"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         nguoigui = row.Cells["Sender"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         diachigui = row.Cells["SenderAddress"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     try
                     {
                         baophat = row.Cells["BP"].Value.ToString();
                     }
                     catch (Exception ex)
                     {
                     }

                     if(cg != "")
                     {
                     dscg.CGLE.AddCGLERow(ngay,cg,sl,tl,tennhan,diachinhan,tp,ghichu,nguoigui,diachigui,baophat);
                     }
                 }
                 rpt.SetDataSource(dscg);
                 rpt.PrintToPrinter(1, false, 0, 0);
             }

             private void txtsophieu_MouseDoubleClick(object sender, MouseEventArgs e)
             {
                 
             }

             private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
             {
                 if (txtsophieu.Enabled == true)
                 {
                     txtsophieu.Enabled = false;
                     txtmacg.Enabled = false;
                 }
                 else
                 {
                     txtsophieu.Enabled = true;
                     txtmacg.Enabled = true;
                 }
             }

        }
       
    }
