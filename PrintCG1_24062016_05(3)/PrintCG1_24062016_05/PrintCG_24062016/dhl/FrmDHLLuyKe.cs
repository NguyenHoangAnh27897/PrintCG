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
using Excel = Microsoft.Office.Interop.Excel;
using PrintCG_24062016.dataset; 
namespace PrintCG_24062016
{
    public partial class FrmDHLLuyKe : Form
    {
        public FrmDHLLuyKe()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            //OleDbConnection conn = new OleDbConnection();
            //DataTable dt = new DataTable();
            //string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            //conn.ConnectionString = con;
            //OleDbCommand comm = new OleDbCommand();
            //conn.Open();
            //// comm.CommandText = "Select [D/O],CG,SL,TL,TP,ShiptoAddress,KH from tb_dhlplan where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            //comm.CommandText = "select * from tb_dhlplan,tb_diachi,tb_tinhthanh where tb_dhlplan.[ToZone] = tb_diachi.[Zone] and tb_diachi.[ZoneDesc] = tb_tinhthanh.[TenTinh]";
            ////comm.CommandText = "Select [tb_dhlplan.CG] from tb_dhlplan inner join tb_diachi on tb_diachi.[Zone] = tb_dhlplan.[ToZone]  where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            //comm.Connection = conn;
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //da.SelectCommand = comm;
            //da.Fill(dt);
            //conn.Close();
            //dataGridView1.DataSource = dt;
            OleDbConnection conn = new OleDbConnection();
            DataSet ds = new DataSet();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select [D/O],CG,SL,TL,ZoneDesc,TP,ShiptoNM,ShiptoAddress,ToNodeCode,Quatity,KH,PGI,DeliveryDate,ToZone,Unit1,Weight,Unit2,Unit3,Vung from tb_dhlplan where  [PGI] >= CDate('" + dtptungay.Value.ToString("dd/MM/yyyy 00:00:00") + "') and [PGI] <= CDate('" + dtpdenngay.Value.ToString("dd/MM/yyyy 00:00:00") + "')";
            //comm.CommandText = "Select [D/O],CG,SL,TL,ZoneDesc,TP,ShiptoNM,ShiptoAddress,ToNodeCode,Quatity,KH,PGI,DeliveryDate,ToZone,Unit1,Weight,Unit2,Unit3 from tb_dhlplan where [PGI] > CDate('" + dtptungay.Value.ToString("dd/MM/yyyy 00:00:00") + "')";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
            lbltong.Text = ds.Tables[0].Rows.Count.ToString();
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

            string excelfile = txtfolder.Text.Trim() + "\\Excel\\LuyKe" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            //số phiếu, ngày nhận, lh, sl,tl ,tl khối, dv, thành phố, quận huyện, người nhận, địa chỉ nhận, ghi chú, bp, giờ nhận.

            xlWorkSheet.Cells[1, 1] = "D/O";
            xlWorkSheet.Cells[1, 2] = "CG";
            xlWorkSheet.Cells[1, 3] = "SL";
            xlWorkSheet.Cells[1, 4] = "TL";
            xlWorkSheet.Cells[1, 5] = "ZoneDesc";
            xlWorkSheet.Cells[1, 6] = "TP";
            xlWorkSheet.Cells[1, 7] = "ShiptoNM";
            //thong tin nguoi gui
            xlWorkSheet.Cells[1, 8] = "ShiptoAddress";
            xlWorkSheet.Cells[1, 9] = "ToNodeCode";
            xlWorkSheet.Cells[1, 10] = "Quatity";
            //thong tin nguoi nhan
            xlWorkSheet.Cells[1, 11] = "KH";
            xlWorkSheet.Cells[1, 12] = "PGI";
            xlWorkSheet.Cells[1, 13] = "DeliveryDate";
            xlWorkSheet.Cells[1, 14] = "ToZone";
            //xlWorkSheet.Cells[1, 14] = "Q/Huyện(Nhận)";
            xlWorkSheet.Cells[1, 15] = "Unit1";

            xlWorkSheet.Cells[1, 16] = "Weight";
            xlWorkSheet.Cells[1, 17] = "Unit2";

            xlWorkSheet.Cells[1, 18] = "Unit3";
            xlWorkSheet.Cells[1, 19] = "Vung";



            //bo sung them cac cot khac theo yeu cau cua HNI

            xlWorkSheet.Cells.NumberFormat = "@";
            string data;
            int i = 0;
            int j = 0;

            DsExcel dsexcel = new DsExcel();
            DataTable dt = new DataTable();

            for (i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                {
                    try
                    {
                        data = dataGridView1.Rows[i].Cells[j].Value.ToString().ToUpper();
                        i = i + 1;
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

        private void FrmDHLLuyKe_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_settings()
        {
            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhlluyke.txtfolder", String.Empty);
        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmdhlluyke.txtfolder", txtfolder.Text);
        }

        private void FrmDHLLuyKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
    }
}
