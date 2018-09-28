using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.IO;
namespace PrintCG_24062016.ChuyenDoiDuLieu
{
    public partial class FrmExcelToFox : Form
    {
        OleDbConnection cnfox = new OleDbConnection();
        string excelfile = string.Empty;
        string dbffile = string.Empty;
        string fulldbffile = string.Empty;
        string tablenhan = string.Empty;
        string tablephat = string.Empty;
        //MailerID C(20),SenderProvinceID C(3),ReceiveProvinceID C(3),ServiceTypeID C(2),MailerTypeID C(2),Quantity I,RealWeight B,Weight B,PostOfficeAcceptID C(4),PaymentMethodID C(2),PostOfficeRecieverMoneyID C(4),MailerDescription C(200),PostOfficeID C(4),ZoneID C(4),DeliveryPostOfficeID C(4),EmployeeID C(10)
        DataSet ds;
        public FrmExcelToFox()
        {
            InitializeComponent();
        }
       
        private void FrmExcelToFox_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_settings()
        {
            txtnhan.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmexceltofox.txtnhan", string.Empty);
            txtphat.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmexceltofox.txtphat", string.Empty);
            txtdt.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmexceltofox.txtdt", string.Empty);
        }

        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("printcg.frmexceltofox.txtnhan", txtnhan.Text);
            Application.UserAppDataRegistry.SetValue("printcg.frmexceltofox.txtphat", txtphat.Text);
            Application.UserAppDataRegistry.SetValue("printcg.frmexceltofox.txtdt", txtdt.Text);
        }
        public bool ConnectFox(string DataPath)
        {

            cnfox = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=" + DataPath + ";" + "Mode=Share Deny None;Extended Properties=\"\";UserID=\"\";" + "Mask Password=False;Cache Authentication=False;EncryptPassword=False;" + "Collating Sequence=MACHINE;Exclusive=ON;DSN=\"\"");

            try
            {
                cnfox.Open();
                return true;
            }
            catch (Exception ex)
            {
                cnfox = null;
                return false;

            }

        }
        private bool createfoxtable(int loai)
        {
            
            //string filename_with_ext = Path.GetFileName(fileName);
            //string filename_without_ext = Path.GetFileNameWithoutExtension(fileName);
            //string ext_only = Path.GetExtension(fileName);           
           // fulldbffile = saveFileDialog1.FileName;
            bool flag = false;
            if(fulldbffile !="")
            {
                dbffile = Path.GetFileNameWithoutExtension(fulldbffile);
                string path = Path.GetDirectoryName(fulldbffile);
                string strsql = string.Empty;
                if(loai == 0)
                {
                    strsql = txtnhan.Text.Trim();
                }else if(loai ==1)
                {
                    strsql = txtphat.Text.Trim();
                }
                else if (loai == 2)
                {
                    strsql = txtdt.Text.Trim();
                }
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=" + path + ";");
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("Create Table " + dbffile + " (" + strsql + ")", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    flag = true;
                }catch
                {
                    flag  = false;
                }
               
            }
            return flag;
        }
        private void inserttofox()
        {
            if (!ConnectFox(fulldbffile)) return;
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    string maso = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //    string ten = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //    string diachi = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //    string reponum = "";
            //    string buucuc = "DNAG";
            //    string lienhe = "";
            //    string dienthoai = "";
            //    string msthue = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //    try
            //    {
            //        string str = "insert into " + "" + openFileDialog1.SafeFileName + " values('" + maso + "','" + ten + "','" + diachi + "','" + dienthoai + "','" + reponum + "','" + buucuc + "','" + lienhe + "','" + msthue + "')";

            //        OleDbCommand cmd1 = new OleDbCommand(str, cnfox);

            //        cmd1.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
        }
        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            excelfile = openFileDialog1.FileName;
            lblfilenguon.Text = excelfile;
           //lay ra sheetname
            using (var package = new ExcelPackage(new FileInfo(excelfile)))
            {
                cbbsheet.DataSource= package.Workbook.Worksheets.Select(x => x.Name).ToList();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[cbbsheet.SelectedValue.ToString()];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                lblsodong.Text = colCount.ToString() + "/" + rowCount.ToString();
            }
        }

        private void btnnoiluu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fulldbffile = saveFileDialog1.FileName;
            lblfiledich.Text = fulldbffile;
        }

        private void btnchuyenfox_Click(object sender, EventArgs e)
        {
            //buoc 1 tao table
            int loai = 0;
            if(rdbnhan.Checked == true)
            {
                loai = 0;
            }else if(rdbphat.Checked == true)
            {
                loai = 1;
            }
            else if (rdbdt.Checked == true)
            {
                loai = 2;
            }
            try
            {
                bool create = createfoxtable(loai);
                if(create == true)
                {
                    GetDBFFromExcel(excelfile, fulldbffile, cbbsheet.SelectedValue.ToString(), loai, true); 
                }else
                {
                    MessageBox.Show("Tên cột quá dài");
                }
                              
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Hoàn tất");
           
        }
        public static DataTable GetDataTableFromExcel(string path,string sheetname, bool hasHeader = true)
        {
            using (var pck = new OfficeOpenXml.ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets[sheetname];
                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                return tbl;
            }
        }
        public void GetDBFFromExcel(string pathexcel,string pathfox,string sheetname, int loai,bool hasHeader = true)
        {
            string strcreate = string.Empty;
            //khai bao tham so cho cac bien nhan
            string MaBc1 = string.Empty;
            string Barcode2 =string.Empty;
            string Makh3 =string.Empty;
            string Ten4 =string.Empty;
            string Noiden5 = string.Empty;
            string Loaihinh6 =string.Empty;
            int Soluong7 = 0;
            double Trluong8 =0;
            double TrLuongBQ9  =0;
            double Vat10 =0;
            double Congcuoc11 =0;
            string ttoan12 =string.Empty;
            string Ghichu13 =string.Empty;
            double HH14 =0;
            double Ck15 = 0;
            string dichvu = string.Empty;
            //khai bao tham so cho cac bien phat
            string MailerID1 = string.Empty;
            string SenderProvinceID2 = string.Empty;
            string ReceiveProvinceID3= string.Empty;
            string ServiceTypeID4 = string.Empty;
            string MailerTypeID5 = string.Empty;
            int    Quantity6 = 0;
            double RealWeight7 = 0;
            double Weight8 = 0;
            string PostOfficeAcceptID9 = string.Empty;
            string PaymentMethodID10 = string.Empty;
            string PostOfficeRecieverMoneyID11 = string.Empty;
            string MailerDescription12 = string.Empty;
            string PostOfficeID13 = string.Empty;
            string ZoneID14 = string.Empty;
            string DeliveryPostOfficeID15 = string.Empty;
            string EmployeeID16 = string.Empty;
            using (var pck = new OfficeOpenXml.ExcelPackage())
            {
                using (var stream = File.OpenRead(pathexcel))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets[sheetname];
                if (!ConnectFox(pathfox)) return;
                var start = ws.Dimension.Start;
                var end = ws.Dimension.End;
                object cellvalue = string.Empty;
                for (int row = start.Row +1 ; row <= end.Row ; row++)
                { // Row by row...
                    if(loai == 0)
                    {
                        MaBc1= ws.Cells[row, 1].Text;
                        Barcode2 = ws.Cells[row, 2].Text;
                        Makh3 = ws.Cells[row, 3].Text;
                        Ten4 = ws.Cells[row, 4].Text;
                        Noiden5 = ws.Cells[row, 5].Text;
                        Loaihinh6 = ws.Cells[row, 6].Text;
                        Soluong7 = int.Parse( ws.Cells[row, 7].Text);
                        Trluong8 =double.Parse( ws.Cells[row, 8].Text);
                        TrLuongBQ9 = double.Parse( ws.Cells[row, 9].Text);
                        Vat10 =double.Parse( ws.Cells[row, 10].Text);
                        Congcuoc11 = double.Parse (ws.Cells[row, 11].Text);
                        ttoan12 = ws.Cells[row, 12].Text;
                        if(ttoan12 == "GN")
                        {
                            ttoan12 = "N";
                        }else if (ttoan12 == "TM")
                        {
                            ttoan12 = "T";
                        }else
                        {
                            ttoan12 = "H";
                        }
                        Ghichu13 = ws.Cells[row, 13].Text;
                        HH14 = double.Parse( ws.Cells[row, 14].Text);
                        Ck15 =double.Parse( ws.Cells[row, 15].Text);
                        string str = "insert into " + "" + Path.GetFileNameWithoutExtension(pathfox) +" values('" + MaBc1 + "','" + Barcode2 + "','" + Makh3 + "','" + Ten4 + "','" + Noiden5 + "','" + Loaihinh6 + "'," + Soluong7 + "," + Trluong8 + "," + TrLuongBQ9 + ", " + Vat10 + "," + Congcuoc11 + ",'" + ttoan12 + "','" + Ghichu13 + "'," + HH14 + "," + Ck15 + ")";
                        OleDbCommand cmd1 = new OleDbCommand(str, cnfox);
                        cmd1.ExecuteNonQuery();
                    }else if (loai ==1)
                    {
                         MailerID1 =  ws.Cells[row, 1].Text;
                         SenderProvinceID2 = ws.Cells[row, 1].Text;
                         ReceiveProvinceID3 = ws.Cells[row, 1].Text;
                         ServiceTypeID4 = ws.Cells[row, 1].Text;
                         MailerTypeID5 = ws.Cells[row, 1].Text;
                         Quantity6 =int.Parse( ws.Cells[row, 1].Text);
                         RealWeight7 =double.Parse( ws.Cells[row, 1].Text);
                         Weight8 =double.Parse( ws.Cells[row, 1].Text);
                         PostOfficeAcceptID9 = ws.Cells[row, 1].Text;
                         PaymentMethodID10 = ws.Cells[row, 1].Text;
                         PostOfficeRecieverMoneyID11 = ws.Cells[row, 1].Text;
                         MailerDescription12 = ws.Cells[row, 1].Text;
                         PostOfficeID13 = ws.Cells[row, 1].Text;
                         ZoneID14 = ws.Cells[row, 1].Text;
                         DeliveryPostOfficeID15 = ws.Cells[row, 1].Text;
                         EmployeeID16 = ws.Cells[row, 1].Text;

                         string str = "insert into " + "" + Path.GetFileNameWithoutExtension(pathfox) + " values('" + MailerID1 + "','" + SenderProvinceID2 + "','" + ReceiveProvinceID3 + "','" + ServiceTypeID4 + "','" + MailerTypeID5 + "'," + Quantity6 + "," + RealWeight7 + "," + Weight8 + ",'" + PostOfficeAcceptID9 + "','" + PaymentMethodID10 + "','" + PostOfficeRecieverMoneyID11 + "','" + MailerDescription12 + "','" + PostOfficeID13 + "','" + ZoneID14 + "','" + DeliveryPostOfficeID15 + "','" + EmployeeID16 + "')";
                        OleDbCommand cmd1 = new OleDbCommand(str, cnfox);
                        cmd1.ExecuteNonQuery();
                    }else if (loai == 2)
                    {
                        MaBc1 = ws.Cells[row, 1].Text;
                        Barcode2 = ws.Cells[row, 2].Text;                     
                        Noiden5 = ws.Cells[row, 3].Text;
                        Loaihinh6 = ws.Cells[row, 4].Text;
                        Soluong7 = int.Parse(ws.Cells[row, 5].Text);
                        Trluong8 = double.Parse(ws.Cells[row, 6].Text);
                        TrLuongBQ9 = double.Parse(ws.Cells[row, 7].Text);                      
                        ttoan12 = ws.Cells[row, 8].Text;
                        dichvu = ws.Cells[row, 9].Text;
                        if (ttoan12 == "GN")
                        {
                            ttoan12 = "N";
                        }
                        else if (ttoan12 == "TM")
                        {
                            ttoan12 = "T";
                        }
                        else
                        {
                            ttoan12 = "H";
                        }                     
                        string str = "insert into " + "" + Path.GetFileNameWithoutExtension(pathfox) + " values('" + MaBc1 + "','" + Barcode2 + "','" + Noiden5 + "','" + Loaihinh6 + "'," + Soluong7 + "," + Trluong8 + "," + TrLuongBQ9 + ",'" + ttoan12 + "','" + dichvu + "')";
                        OleDbCommand cmd1 = new OleDbCommand(str, cnfox);
                        cmd1.ExecuteNonQuery();
                    }
                }               
               // return tbl;
            }
        }
        private void cbbsheet_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var package = new ExcelPackage(new FileInfo(excelfile)))
            {               
                ExcelWorksheet worksheet = package.Workbook.Worksheets[cbbsheet.SelectedValue.ToString()];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                lblsodong.Text = colCount.ToString() + "/" + rowCount.ToString();
            }
        }
        private void FrmExcelToFox_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }        
    }
}
