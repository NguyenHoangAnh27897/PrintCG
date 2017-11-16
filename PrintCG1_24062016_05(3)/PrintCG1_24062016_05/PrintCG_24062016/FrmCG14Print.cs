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
    public partial class FrmCG14Print : Form
    {
        public FrmCG14Print()
        {
            InitializeComponent();
        }
        public static string bcgui = string.Empty;
        public static string ngaygui = string.Empty;
        public static string path = string.Empty;
        public static string sheet = string.Empty;
        public static string kinhgui = string.Empty;


        public static string nguoinhan = string.Empty;
        public static string sophieu = string.Empty;
        public static string diachi = string.Empty;


        private void FrmCG14Print_Load(object sender, EventArgs e)
        {
            RptCG14 rptcg14 = new RptCG14();
            DataTable dt = new DataTable();
            DsCG14 dscg14 = new DsCG14();
           

            string _nguoinhan;
            string _sophieu;
            string _diachi;

            if (path == "Bạn chưa chọn file")
            {
                _nguoinhan = nguoinhan;
                _sophieu = sophieu;
                _diachi = diachi;
                dscg14.CG14.AddCG14Row(bcgui, _nguoinhan, _sophieu, ngaygui, _diachi,kinhgui);
            }
            else
            {
                dt = ReadExcelFile(sheet, path);
                foreach (DataRow row in dt.Rows)
                {
                    _nguoinhan = row[nguoinhan].ToString();
                    _sophieu = row[sophieu].ToString();
                    _diachi = row[diachi].ToString();
                    dscg14.CG14.AddCG14Row(bcgui, _nguoinhan, _sophieu, ngaygui, _diachi,kinhgui);
                }

            }
           

            rptcg14.SetDataSource(dscg14);
            crystalReportViewer1.ReportSource = rptcg14;
          
           
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
