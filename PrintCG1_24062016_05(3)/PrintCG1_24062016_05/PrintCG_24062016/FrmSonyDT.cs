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
namespace PrintCG_24062016
{
    public partial class FrmSonyDT : Form
    {
        public FrmSonyDT()
        {
            InitializeComponent();
        }
        public static string path = string.Empty;
        private void FrmSonyDT_Load(object sender, EventArgs e)
        {
            try
            {
                RptSony_DT rptsonydt = new RptSony_DT();
                DataTable dt = new DataTable();
                DsCG1Sony dscg1sony = new DsCG1Sony();
                dt = ReadExcelFile("Sheet1$", path);
                string _CG = string.Empty;
                double _SL =0;
                double _TL = 0;
                string _ND = string.Empty;
                string _DO = string.Empty;
                string _HD = string.Empty;
                string _ghichu = string.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    
                    try
                    {
                        _CG = "*" + row[2].ToString() + "*";
                    }
                    catch (Exception ex)
                    {
                        _CG = "";
                    }
                    try
                    {
                        _SL = double.Parse(row[5].ToString());
                    }
                    catch (Exception ex)
                    {
                        _SL = 0;
                    }
                    try
                    {
                        _TL = double.Parse(row[6].ToString());
                    }
                    catch (Exception ex)
                    {
                        _TL = 0;
                    }
                    try
                    {
                        _ND = (row[9].ToString());
                    }
                    catch (Exception ex)
                    {
                        _ND = "";
                    }

                    try
                    {
                        _ghichu = (row[11].ToString());
                    }
                    catch (Exception ex)
                    {
                        _ghichu = "";
                    }
                    dscg1sony.CG1Sony.AddCG1SonyRow(_CG,_SL.ToString(),_TL.ToString(),_ND,_DO,_HD,_ghichu);
                    
                }
                TextObject _txttieude = (TextObject)rptsonydt.ReportDefinition.Sections["Section3"].ReportObjects["txttieude"];
                _txttieude.Text = path;
                rptsonydt.SetDataSource(dscg1sony);
                crystalReportViewer1.ReportSource = rptsonydt;
            }
            catch(Exception ex)
            {
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

                    comm.CommandText = "Select * from [" + sheetName + "] ";
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
