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
using PrintCG_24062016.Report;
using PrintCG_24062016.dataset;

namespace PrintCG_24062016
{
    public partial class FrmSonyPrint : Form
    {
        public FrmSonyPrint()
        {
            InitializeComponent();
        }
        public static string path = string.Empty;
        public static string sheet = string.Empty;
        public static string socg = string.Empty;
        private void FrmSonyPrint_Load(object sender, EventArgs e)
        {
            try
            {
                RptBangKeSony rptbangkesony = new RptBangKeSony();
                DataTable dt = new DataTable();
                DsKienHangSony dskienhang = new DsKienHangSony();
                dt = ReadExcelFile(sheet, path);
                int count = 1;
                string _STT;
                string _CG;
                double _TL;
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        // _STT = 1;
                        _STT = count.ToString();
                        count = count + 1;
                    }
                    catch (Exception ex)
                    {
                        _STT = "";
                    }
                    try
                    {
                        _CG = row["CG"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _CG = "";
                    }
                    try
                    {
                        _TL = double.Parse(row["TL"].ToString());
                    }
                    catch (Exception ex)
                    {
                        _TL = 0;
                    }
                    dskienhang.KienHang.AddKienHangRow(_STT, _CG, _TL);
                }
                rptbangkesony.SetDataSource(dskienhang);
                crystalReportViewer1.ReportSource = rptbangkesony;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

                         comm.CommandText = "Select * from [" + sheetName + "] where CG = '"+ socg+ "'";
                       // comm.CommandText = "Select * from [" + sheetName + "] where CG = " + socg;
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
