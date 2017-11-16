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
    public partial class FrmFromToPrint : Form
    {
        public FrmFromToPrint()
        {
            InitializeComponent();
        }
        public static string path = string.Empty;
        public static string nguoigui = string.Empty;
        public static string nguoinhan = string.Empty;
        public static string diachinhan = string.Empty;
        public static string sheet = string.Empty;
        private void FrmFromToPrint_Load(object sender, EventArgs e)
        {
            RptFromTo rptfromto = new RptFromTo();
            DataTable dt = new DataTable();
            DsFromTo dsfromto = new DsFromTo();
            dt = ReadExcelFile(sheet, path);
            string _nguoigui;
            string _nguoinhan;
            string _diachi;
            foreach (DataRow row in dt.Rows)
            {

                try
                {
                    _nguoigui = nguoigui;
                }
                catch (Exception ex)
                {
                    _nguoigui = "";
                }

                try
                {
                    _nguoinhan = row[nguoinhan].ToString();
                }
                catch (Exception ex)
                {
                    _nguoinhan = "";
                }

                try
                {
                    _diachi = row[diachinhan].ToString();
                }
                catch (Exception ex)
                {
                    _diachi = "";
                }
              
                dsfromto.FromTo.AddFromToRow(_nguoigui, _nguoinhan, _diachi);
                rptfromto.SetDataSource(dsfromto);
                crystalReportViewer1.ReportSource = rptfromto;

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

                    comm.CommandText = "Select * from ["+ sheetName +"]";

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
