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
    public partial class FrmTLCan : Form
    {
        public FrmTLCan()
        {
            InitializeComponent();
        }
        public static string socg = string.Empty;
        public static string soluog = string.Empty;

        public delegate void SendTL(string tl);
        public SendTL send;
       
        private void FrmTLCan_Load(object sender, EventArgs e)
        {
            txtsocg.Text = socg;
            txtsoluong.Text = soluog;
            string excelfile = "D:\\InSony\\" + txtsocg.Text + ".xls";
            if (File.Exists(excelfile) == true)
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    DataTable dt = new DataTable();
                    string Import_FileName = excelfile;
                    string fileExtension = Path.GetExtension(Import_FileName);
                    if (fileExtension == ".xls")
                        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                    if (fileExtension == ".xlsx")
                        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                    using (OleDbCommand comm = new OleDbCommand())
                    {

                         comm.CommandText = "Select * from [Sheet1$]";

                        comm.Connection = conn;

                        using (OleDbDataAdapter da = new OleDbDataAdapter())
                        {
                            da.SelectCommand = comm;
                            da.Fill(dt);
                           
                            try
                            {
                                foreach (DataRow row in dt.Rows)
                                {
                                    string[] rows = new string[] { row["TL"].ToString(), row["STT"].ToString() };
                                    dataGridView1.Rows.Add(rows);
                                }


                            }
                            catch (Exception ex)
                            {

                            }

                        }

                    }
                }
            }
            else
            {
                string[] row = new string[] { "0", "1" };
                dataGridView1.Rows.Add(row);
            }
        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            if (dataGridView1.CurrentRow.Index > 0 && dataGridView1.CurrentRow.Index < int.Parse(txtsoluong.Text))
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.CurrentRow.Index + 1;               
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        // total = 0;
                        int detail = 0;
                        if (row.Cells[0].Value.ToString().Length == 13)
                        {
                             detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5));
                        }
                        else if (row.Cells[0].Value.ToString().Length != 13)
                        {
                            detail = int.Parse((row.Cells[0].Value.ToString()));
                        }
                        total += detail;
                        txttotal.Text = total.ToString();
                    }
                }
                catch (Exception ex)
                {
                }
                //More code here
            }
            if (dataGridView1.CurrentRow.Index == int.Parse(txtsoluong.Text))
            {
                 
                 dataGridView1.Enabled = false;
               
            }        
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                create_excel();
                send(txttotal.Text);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại định dạng excel trong control panel");
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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() != "")
                        {
                            // total = 0;
                            int detail = 0;
                            if (row.Cells[0].Value.ToString().Length == 13)
                            {
                                detail = int.Parse((row.Cells[0].Value.ToString()).Substring(7, 5));
                            }
                            else if (row.Cells[0].Value.ToString().Length != 12)
                            {
                                detail = int.Parse((row.Cells[0].Value.ToString()));
                            }
                            total += detail;
                            txttotal.Text = total.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    //More code here
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmTLCan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmSony.total = txttotal.Text;
            
        }
        private void create_excel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            string excelfile = "D:\\InSony\\" + txtsocg.Text + ".xls";
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "STT";
            xlWorkSheet.Cells[1, 2] = "CG";
            xlWorkSheet.Cells[1, 3] = "TL";

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

                    xlWorkSheet.Cells[row.Index + 2, 1] = row.Cells[1].Value;
                    xlWorkSheet.Cells[row.Index + 2, 2] = txtsocg.Text;
                    xlWorkSheet.Cells[row.Index + 2, 3] = detail.ToString();
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
           

           // MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            create_excel();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string aa = dataGridView1.CurrentRow.Index.ToString(); ;
            if (dataGridView1.CurrentRow.Index ==int.Parse( soluog))
            {

                btnclose.Focus();
            }
        }

        private void btnclose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                FrmSony.total = txttotal.Text;
                send(txttotal.Text);
            }
        }

        private void btnclose_Enter(object sender, EventArgs e)
        {
           
                FrmSony.total = txttotal.Text;
                send(txttotal.Text);
           
        }

        private void btnclose_KeyUp(object sender, KeyEventArgs e)
        {
            FrmSony.total = txttotal.Text;
            send(txttotal.Text);
            this.Hide();
        }
    }
}
