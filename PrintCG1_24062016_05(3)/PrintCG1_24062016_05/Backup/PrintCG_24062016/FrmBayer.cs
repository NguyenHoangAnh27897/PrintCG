using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
namespace PrintCG_24062016
{
    public partial class FrmBayer : Form
    {
        public FrmBayer()
        {
            InitializeComponent();
        }

        private void FrmBayer_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_settings()
        {
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtnguoigui", String.Empty);
            txtdiachigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtdiachigui", String.Empty);
            txtbc.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtbc", String.Empty);
            txtnhanvien.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtnhanvien", String.Empty);
            txttelgui.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txttelgui", String.Empty);
            txtnoidung.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtnoidung", String.Empty);
            txtsoluong.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtsoluong", String.Empty);
            txttrongluong.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txttrongluong", String.Empty);
            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmbayer.txtfolder", String.Empty);
        }
        private void save_settings()
        {

            Application.UserAppDataRegistry.SetValue("frmbayer.txtnguoigui", txtnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtdiachigui", txtdiachigui.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtbc", txtbc.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtnhanvien", txtnhanvien.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txttelgui", txttelgui.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtnoidung", txtnoidung.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtsoluong", txtsoluong.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txttrongluong", txttrongluong.Text);
            Application.UserAppDataRegistry.SetValue("frmbayer.txtfolder", txtfolder.Text);
        }

        private void btninphieu_Click(object sender, EventArgs e)
        {

            FrmBayerPrint.report = "CG";
            FrmBayerPrint.soluong = txtsoluong.Text;
            FrmBayerPrint.trongluong = txttrongluong.Text;
            FrmBayerPrint.bc = txtbc.Text;
            FrmBayerPrint.nhanvien = txtnhanvien.Text;
            FrmBayerPrint.nguoigui = txtnguoigui.Text;
            FrmBayerPrint.diachigui = txtdiachigui.Text;
            FrmBayerPrint.telgui = txttelgui.Text;
            FrmBayerPrint.ngaygui = dtpngaygui.Text;
            FrmBayerPrint.noidung = txtnoidung.Text;
            FrmBayerPrint frm = new FrmBayerPrint();
            frm.ShowDialog();
        }

        private void FrmBayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void btnbaophat_Click(object sender, EventArgs e)
        {
            FrmBayerPrint.report = "BP";
            FrmBayerPrint.soluong = txtsoluong.Text;
            FrmBayerPrint.trongluong = txttrongluong.Text;
            FrmBayerPrint.bc = txtbc.Text;
            FrmBayerPrint.nhanvien = txtnhanvien.Text;
            FrmBayerPrint.nguoigui = txtnguoigui.Text;
            FrmBayerPrint.diachigui = txtdiachigui.Text;
            FrmBayerPrint.telgui = txttelgui.Text;
            FrmBayerPrint.ngaygui = dtpngaygui.Text;
            FrmBayerPrint.noidung = txtnoidung.Text;
            FrmBayerPrint frm = new FrmBayerPrint();
            frm.ShowDialog();
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

            string excelfile = txtfolder.Text.Trim() + "\\BY_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
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


            xlWorkSheet.Cells.NumberFormat = "@";

            string _ngaynhan = dtpngaygui.Value.ToString();
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
            string _ghichu = txtnoidung.Text;

            // khai bao them thong tin

            string data;
            int i = 0;
            int j = 0;

            DsExcel dsexcel = new DsExcel();
            DataTable dt = new DataTable();
            dt = ReadInfo(dtpngaygui.Value);
            string _stt;
            foreach (DataRow row in dt.Rows)
            {
                _stt = row["STT"].ToString();
                if (_stt.Length == 1)
                {
                    _sophieu = "BY" + _ngaynhan.Substring(8, 2) + _ngaynhan.Substring(3, 2) + _ngaynhan.Substring(0, 2) + "0" + _stt;
                }
                else
                {
                    _sophieu = "BY" + _ngaynhan.Substring(8, 2) + _ngaynhan.Substring(3, 2) + _ngaynhan.Substring(0, 2) + _stt;
                }

                try
                {
                    _soluong = txtsoluong.Text;
                }
                catch (Exception ex)
                {
                    _soluong = "0";
                }

                try
                {
                    _trongluong = txttrongluong.Text;
                }
                catch (Exception ex)
                {
                    _trongluong = "0";
                }

                try
                {
                    _trongluongkhoi = txttrongluong.Text;
                }
                catch (Exception ex)
                {
                    _trongluongkhoi = "0";
                }

                try
                {
                    _tenduong = row["DiaChi"].ToString();
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
                    _tinhthanh = row["Matinh"].ToString();

                }
                catch (Exception ex)
                {
                    _tinhthanh = "";
                }

               

                //_ghichu = row[cmbdo.Text].ToString() + "/" + row["KH"].ToString().ToUpper();
                dsexcel.Excel.AddExcelRow(DateTime.Parse(_ngaynhan).ToString("dd/MM/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong, _tinhthanh, _quanhuyen, _ghichu, "", "", "", "", "", "");

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
            // comm.CommandText = "Select [D/O],CG,SL,TL,TP,ShiptoAddress,KH from tb_dhlplan where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            comm.CommandText = "Select * from tb_bayer where Isactive = 1 order by STT";
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
    }
}
