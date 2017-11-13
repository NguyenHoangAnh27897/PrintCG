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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;

namespace PrintCG_24062016
{
    public partial class FrmInPhieuGuiPrint : Form
    {
        public FrmInPhieuGuiPrint()
        {
            InitializeComponent();
        }
        public static string sheet = string.Empty;
        public static  string path = string.Empty;
        public static string nguoigui = string.Empty;
        public static string diachigui = string.Empty;
        public static string tellgui = string.Empty;
        public static string ngaygui = string.Empty;
        public static string nvnhan = string.Empty;
        public static string bcnhan = string.Empty;
        public static string cuocchinh = string.Empty;
        public static string hengio = string.Empty;
        public static string cuockhac = string.Empty;
        public static string tongtien = string.Empty;
        public static string loaihang = string.Empty;

        public static string nguoinhan = string.Empty;
        public static string diachi = string.Empty;
        public static string thanhpho = string.Empty;
        public static string telnhan = string.Empty;
        public static string soluong = string.Empty;
        public static string trongluong = string.Empty;
        public static string trongluongkhoi = string.Empty;
        public static string ghichu = string.Empty;
        public static string cod = string.Empty;
        public static string thuho = string.Empty;
        public static string paper = string.Empty;
        public static string sophieu = string.Empty;

        private void FrmInPhieuGuiPrint_Load(object sender, EventArgs e)
        {
                        
            Rptinphieugui_kim_listexcel rpt_kim = new Rptinphieugui_kim_listexcel();
            RptCOD_A5 rpt_laser = new RptCOD_A5();
            DataTable dt = new DataTable();
            DsCG11 dscg11 = new DsCG11();
            dt = ReadExcelFile(sheet, path);
            string _ngaynhan;
            string _gio = "00:00";
            string _sophieu = "";
            string _lh;
            string _dv = "";
            string _sl;
            string _tl;
            string _tlkhoi;
            string _hotennhan;
            string _diachinhan;
            string _tinhthanh;
            string _ghichu;
            string _bc;
            string _nv;
            string _kh;
            string _diachi;
            string _cuoc;
            string _hengio;
            string _phikhac;
            string _tongtien;
            string _telnhan;
            string _telgui;
            string _cod;
            string _thuho;
            
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    _ngaynhan = ngaygui;
                }
                catch (Exception ex)
                {
                    _ngaynhan = DateTime.Today.Day.ToString("dd/MM/yyyy");
                }

                try
                {
                    _lh = loaihang.ToUpper();
                }
                catch (Exception ex)
                {
                    _lh = "TL";
                }

                try
                {
                    //_sl = row[soluong].ToString();
                    _sl = row[soluong].ToString();
                }
                catch (Exception ex)
                {
                    _sl = soluong;
                }

                try
                {
                    _tl = row[trongluong].ToString();
                    _tlkhoi = row[trongluong].ToString();
                }
                catch (Exception ex)
                {
                    _tl = trongluong;
                    _tlkhoi = trongluong;
                }

                try
                {
                    _tlkhoi = row[trongluongkhoi].ToString();
                }
                catch (Exception ex)
                {
                    _tlkhoi = trongluongkhoi;
                }

                try
                {
                    _hotennhan = row[nguoinhan].ToString();
                }
                catch (Exception ex)
                {
                    _hotennhan = "";
                }

                try
                {
                    _diachinhan = row[diachi].ToString();
                }
                catch (Exception ex)
                {
                    _diachinhan = "";
                }

                try
                {
                    
                    OleDbConnection conn = new OleDbConnection();
                    DataTable dttt = new DataTable();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    OleDbCommand comm = new OleDbCommand();
                    conn.Open();
                    comm.CommandText = "Select TenTinh from tb_tinhthanh where MaTinh = '" + row[thanhpho].ToString() + "'";
                    comm.Connection = conn;
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = comm;
                    da.Fill(dttt);
                    _tinhthanh = dttt.Rows[0][0].ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    _tinhthanh = thanhpho;
                }

                try
                {
                    _ghichu = row[ghichu].ToString();
                }
                catch (Exception ex)
                {
                    _ghichu = "";
                }

                try
                {
                    _bc = bcnhan;
                }
                catch (Exception ex)
                {
                    _bc = "";
                }

                try
                {
                    _nv = nvnhan;
                }
                catch (Exception ex)
                {
                    _nv = "";
                }

                try
                {
                    _kh = row[nguoigui].ToString();
                }
                catch (Exception ex)
                {
                    _kh = nguoigui;
                }

                try
                {
                    _diachi = row[diachigui].ToString();
                }
                catch (Exception ex)
                {
                    _diachi = diachigui;
                }

                try
                {
                    _cuoc = row[cuocchinh].ToString();
                }
                catch (Exception ex)
                {
                    _cuoc = cuocchinh;
                }

                try
                {
                    _hengio = row[hengio].ToString();
                }
                catch (Exception ex)
                {
                    _hengio = hengio;
                }

                try
                {
                    _phikhac = row[cuockhac].ToString();
                }
                catch (Exception ex)
                {
                    _phikhac = cuockhac;
                }

                try
                {
                    _tongtien = row[tongtien].ToString();
                }
                catch (Exception ex)
                {
                    _tongtien = tongtien;
                }

                try
                {
                    _telnhan = row[telnhan].ToString();
                }
                catch (Exception ex)
                {
                    _telnhan = telnhan;
                }

                try
                {
                    _telgui = row[tellgui].ToString();
                }
                catch (Exception ex)
                {
                    _telgui = tellgui;
                }

                try
                {
                    _sophieu = row[sophieu].ToString();
                }
                catch (Exception ex)
                {
                    _sophieu = sophieu;
                }

                try
                {
                    _cod = String.Format("{0:0,0}", float.Parse(row[cod].ToString())); 
                }
                catch (Exception ex)
                {
                    _cod = "0";
                }

                try
                {
                    _thuho = String.Format("{0:0,0}", float.Parse(row[thuho].ToString()));
                }
                catch (Exception ex)
                {
                    _thuho = "0";
                }
                dscg11.CG11.AddCG11Row(_ngaynhan, _gio, _sophieu, _lh, _dv, _sl, _tl, _tlkhoi, _hotennhan, _diachinhan, _tinhthanh, _ghichu, _bc, _nv, _kh, _diachi, _cuoc, _hengio, _phikhac, _tongtien, _telnhan, _telgui,_cod,"","","");
            }
            //string papername = string.Empty;
            //int i = 0;
            //System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();

            //// doctoprint.PrinterSettings.PrinterName = "\\\\RD2\\Epson LX-300+";
            //int rawKind = 0;
            //for (i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
            //{
            //    if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "CG1") //CG1
            //    {
            //        rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField("kind", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
            //        papername = "CG1"; //CG1
            //        break; // TODO: might not be correct. Was : Exit For
            //    }
            //}
            //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
           // rpt.PrintOptions.PaperOrientation = PaperOrientation.Landscape;
            if (paper == "Kim")
            {
                rpt_kim.SetDataSource(dscg11);
                crystalReportViewer1.ReportSource = rpt_kim;
            }
            else if (paper == "Laser")
            {
                rpt_laser.SetDataSource(dscg11);
                crystalReportViewer1.ReportSource = rpt_laser;
            }
            
           
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
                    comm.CommandText = "Select * from [" + sheetName + "]";

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
    }
}
