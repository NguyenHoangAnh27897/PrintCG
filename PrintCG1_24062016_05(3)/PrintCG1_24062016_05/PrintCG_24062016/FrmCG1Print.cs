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
    public partial class FrmCG1Print : Form
    {
        public FrmCG1Print()
        {
            InitializeComponent();
        }
        public static int flag = 0;
        public static string path = string.Empty ;
        public static string bcchapnhan = string.Empty;
        public static string nvchapnhan = string.Empty;
        public static string nguoigui = string.Empty;
        public static string diachi = string.Empty;
        public static string cuoc = string.Empty;
        public static string hengio = string.Empty;
        public static string phikhac = string.Empty;
        public static string ems = string.Empty;
        private void FrmCG1Print_Load(object sender, EventArgs e)
        {
            RptCG1_A5 rptcc1_a5 = new RptCG1_A5();
            RptCG1_Label rptcg1_label = new RptCG1_Label();
            RptCG1_Label_30 rptcg1__label30 = new RptCG1_Label_30();
            DataTable dt = new DataTable();
            DsCG11 dscg11 = new DsCG11();
            dt = ReadExcelFile("CG11", path);
            string _ngaynhan;
            string _gio;
            string _sophieu;
            string _lh;
            string _dv;
            string _sl;
            string _tl;
            string _tlkhoi;
            string _hotennhan;
            string _diachinhan;
            string _tinhthanh;
            string _ghichu;
            string _bc;
            string _ems;
            foreach (DataRow row in dt.Rows)
            {

                try
                {
                    _ngaynhan = row[0].ToString();
                }
                catch (Exception ex)
                {
                    _ngaynhan = "";
                }

                try
                {
                    _gio = row[1].ToString();
                }
                catch (Exception ex)
                {
                    _gio = "";
                }

                try
                {
                    _sophieu = row[2].ToString() ;
                }
                catch (Exception ex)
                {
                    _sophieu = "";
                }

                try
                {
                    _lh = row[3].ToString();
                }
                catch (Exception ex)
                {
                    _lh = "";
                }

                try
                {
                    _dv = row[4].ToString();
                }
                catch (Exception ex)
                {
                    _dv = "";
                }

                try
                {
                    _sl = row[5].ToString();
                }
                catch (Exception ex)
                {
                    _sl = "0";
                }

                try
                {
                    _tl = row[6].ToString();
                }
                catch (Exception ex)
                {
                    _tl = "0";
                }

                try
                {
                    _tlkhoi = row[7].ToString();
                }
                catch (Exception ex)
                {
                    _tlkhoi = "0";
                }

                try
                {
                    _hotennhan = row[8].ToString();
                }
                catch (Exception ex)
                {
                    _hotennhan = "";
                }

                try
                {
                    _diachinhan = row[9].ToString();
                }
                catch (Exception ex)
                {
                    _diachinhan = "";
                }

                try
                {
                    _tinhthanh = row[10].ToString();
                }
                catch (Exception ex)
                {
                    _tinhthanh = "";
                }


                try
                {
                    _ghichu = row[11].ToString();
                }
                catch (Exception ex)
                {
                    _ghichu = "";
                }

                try
                {
                    _bc = row["BC"].ToString();
                }
                catch (Exception ex)
                {
                    _bc = "";
                }

                try
                {
                    _ems = row["EMS"].ToString();
                }
                catch (Exception ex)
                {
                    _ems = "";
                }
                dscg11.CG11.AddCG11Row(_ngaynhan, _gio, _sophieu, _lh, _dv, _sl, _tl, _tlkhoi, _hotennhan, _diachinhan, _tinhthanh, _ghichu,bcchapnhan,nvchapnhan,nguoigui,diachi,cuoc,hengio,phikhac,"0","","","","",_bc,_ems);

               
                
            }
            if (flag == 1) {
               // TextObject _txtems = (TextObject)rptcc1_a5.ReportDefinition.Sections["Section3"].ReportObjects["txtems"];
               // _txtems.Text = ems.ToString();
                rptcc1_a5.SetDataSource(dscg11);
                crystalReportViewer1.ReportSource = rptcc1_a5;
            }
            else if (flag == 2)
            {
                rptcg1_label.SetDataSource(dscg11);
                crystalReportViewer1.ReportSource = rptcg1_label;
            }
            else if (flag == 3)
            {      
                rptcg1__label30.SetDataSource(dscg11);
                crystalReportViewer1.ReportSource = rptcg1__label30;
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
                   
                     comm.CommandText = "Select * from [CG11$]";

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
