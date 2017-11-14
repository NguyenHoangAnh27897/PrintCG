using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryFileFormat;

namespace PrintCG_24062016
{
    public partial class FrmDHL_Listweight : Form
    {
        public FrmDHL_Listweight()
        {
            InitializeComponent();
        }
        public static string socg = string.Empty;
        public static string soluog = string.Empty;
        public static string folder = string.Empty;
        public static string type = string.Empty;
        public string textValue = "";

        private void FrmDHL_Listweight_Load(object sender, EventArgs e)
        {
            txtsocg.Text = socg;
            txtsoluong.Text = soluog;
            string[] row = new string[] { "0", "1", "1" };
            dataGridView1.Rows.Add(row);
            //OleDbConnection conn = new OleDbConnection();
            //DataSet ds = new DataSet();
            //string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            //conn.ConnectionString = con;
            //OleDbCommand comm = new OleDbCommand();
            //conn.Open();
            //comm.CommandText = "select * from tb_sltl where CG = '" + txtsocg.Text.Trim() + "'";
            //comm.Connection = conn;
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //da.SelectCommand = comm;
            //da.Fill(ds);
            //conn.Close();
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    int i = 1 ;
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        string[] rows = new string[] { row["TL"].ToString(), row["SL"].ToString(), i.ToString() };
            //        i += 1;
            //        dataGridView1.Rows.Add(rows);
            //    }
            //}
            //else
            //{
            //    string[] row = new string[] { "0", "1", "1" };
            //    dataGridView1.Rows.Add(row);
            //}

            //load danh sach
           
        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            int total_kien = 0;
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        // total = 0;
                        int detail_kien = 0;
                        int detail = 0;
                        if (row.Cells[0].Value.ToString().Length == 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5)) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        else if (row.Cells[0].Value.ToString().Length != 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString())) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        detail_kien = int.Parse((row.Cells[1].Value.ToString()));
                        total_kien += detail_kien;
                        total += detail;
                        txttotal.Text = total.ToString();
                        //FrmSony.total = txttotal.Text;
                       
                    }
                }
                catch (Exception ex)
                {
                }
                //More code here
            }
            //chuyen them so thu tu ben duoi
            if (dataGridView1.CurrentRow.Index > 0 && int.Parse(txtsoluong.Text) > total_kien)
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = 1;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = dataGridView1.CurrentRow.Index + 1;
            }
            if (int.Parse(txtsoluong.Text) == total_kien )
            {

                dataGridView1.Enabled = false;

            }  
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled == false)
            {
               // dataGridView1.Enabled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //string aa = dataGridView1.CurrentRow.Index.ToString(); ;
            if (dataGridView1.CurrentRow.Index == int.Parse(soluog))
            {

                btnclose.Focus();
            }
            // kiem tra gia tri nhap vao co lon hon so kien.====================
            int total = 0;
            int total_kien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        // total = 0;
                        int detail_kien = 0;
                        int detail = 0;
                        if (row.Cells[0].Value.ToString().Length == 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5)) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        else if (row.Cells[0].Value.ToString().Length != 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString())) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        detail_kien = int.Parse((row.Cells[1].Value.ToString()));
                        total_kien += detail_kien;
                        total += detail;
                        txttotal.Text = total.ToString();
                        //FrmSony.total = txttotal.Text;

                    }
                }
                catch (Exception ex)
                {
                }
                //More code here
            }
            //chuyen them so thu tu ben duoi
            if (int.Parse(total_kien.ToString()) > int.Parse(txtsoluong.Text))
            {
                MessageBox.Show("Số kiện không vượt quá " + txtsoluong.Text);
            }
            else
            {
                if (dataGridView1.CurrentRow.Index > 0 && int.Parse(txtsoluong.Text) > total_kien)
                {
                    // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = 1;
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = dataGridView1.CurrentRow.Index + 1;
                }

                if (int.Parse(txtsoluong.Text) == total_kien)
                {

                    dataGridView1.Enabled = false;

                }
            }
            //ket thuc kiem tra===========================================================================
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                    update_weight();
                    insert_sltl();
                    textValue = txttotal.Text;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại định dạng excel trong control panel");
            }     
        }
        private void create_excel()
        {
            try
            {
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                string excelfile =  folder+"\\" + txtsocg.Text + ".xls";
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Cells[1, 1] = "STT";
                xlWorkSheet.Cells[1, 2] = "CG";
                xlWorkSheet.Cells[1, 3] = "TL";
                xlWorkSheet.Cells[1, 4] = "SL";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    int detail = 0;
                    try
                    {
                        if (row.Cells[0].Value.ToString().Length == 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5));
                        }
                        else if (row.Cells[0].Value.ToString().Length != 12)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()));
                        }

                        xlWorkSheet.Cells[row.Index + 2, 1] = row.Cells[2].Value;
                        xlWorkSheet.Cells[row.Index + 2, 2] = txtsocg.Text;
                        xlWorkSheet.Cells[row.Index + 2, 3] = detail.ToString();
                        xlWorkSheet.Cells[row.Index + 2, 4] = row.Cells[1].Value;
                    }
                    catch (Exception ex)
                    {
                    }

                }
                if (File.Exists(excelfile) == true)
                {
                    File.Delete(excelfile);
                    //xlApp.DisplayAlerts = false;
                    //xlWorkBook.SaveAs(excelfile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    //xlWorkBook.Close(true, excelfile, misValue);
                }

                xlWorkBook.SaveAs(excelfile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);



                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            catch (Exception ex)
            {
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
        private void update_weight()
        {
            int total = 0;
            int total_kien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        // total = 0;
                        int detail_kien = 0;
                        int detail = 0;
                        if (row.Cells[0].Value.ToString().Length == 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5)) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        else if (row.Cells[0].Value.ToString().Length != 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString())) * int.Parse(row.Cells[1].Value.ToString());
                        }
                        detail_kien = int.Parse((row.Cells[1].Value.ToString()));
                        total_kien += detail_kien;
                        total += detail;
                        txttotal.Text = total.ToString();
                        //FrmSony.total = txttotal.Text;

                    }
                }
                catch (Exception ex)
                {
                }
                //More code here
            }
            //chuyen them so thu tu ben duoi
            if (dataGridView1.CurrentRow.Index > 0 && int.Parse(txtsoluong.Text) > total_kien)
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = 1;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = dataGridView1.CurrentRow.Index + 1;
            }
            if (int.Parse(txtsoluong.Text) == total_kien)
            {

                dataGridView1.Enabled = false;

            } 
        }
        private void insert_sltl()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                string delete = "delete * from tb_sltl where CG = '" + txtsocg.Text.Trim() + "'";
                OleDbCommand cmd1 = new OleDbCommand(delete, conn);
                cmd1.ExecuteNonQuery();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string khachhang = string.Empty;
                    string diachi = string.Empty;
                    string remark = string.Empty;
                    if (row.Cells["TL"].Value.ToString() != "")
                    {                      
                        string query = "insert into tb_sltl(CG,SL,TL) values('" + txtsocg.Text.Trim() + "'," + row.Cells["SL"].Value + "," + row.Cells["TL"].Value + ")";
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            int newInteger;

            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.
            if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
            if (!int.TryParse(e.FormattedValue.ToString(),
                out newInteger) || newInteger <0)
            {
                e.Cancel = true;
                dataGridView1.Rows[e.RowIndex].ErrorText = "Giá trị nhập vào phải lớn hơn 0";
            }
            //kiem tra số lượng chinh xác
            if (e.ColumnIndex == dataGridView1.Columns["SL"].Index)
            {
                //dataGridView1.Rows[e.RowIndex].ErrorText = "";
                ////lay ra so luong tren lưới.
                //int sum = 0;
                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                //}
                if (dataGridView1.CurrentRow.Index == 0)
                {
                    int newSL;
                    if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!int.TryParse(e.FormattedValue.ToString(),out newSL) || newSL > int.Parse(txtsoluong.Text))
                    {
                        e.Cancel = true;
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Số lượng không đúng";
                    }
                }
                else // neu khong phai la row 0 thì cong nhưng row trước đo và currentrow lai de so sanh
                {
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    }
                    //
                    int newSL;
                    if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!int.TryParse(e.FormattedValue.ToString(),
                        out newSL) || newSL > int.Parse(txtsoluong.Text) - (sum-1) )
                    {
                        e.Cancel = true;
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Số lượng không đúng";
                    }

                }
            }
                
        }
    }
}
