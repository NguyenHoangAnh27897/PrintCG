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

namespace PrintCG_24062016
{
    public partial class FrmCG7Print : Form
    {
        public FrmCG7Print()
        {
            InitializeComponent();
        }
        public static int flag = 0;
        public static string sheet = string.Empty;
        public static string path = string.Empty;
        public static int start = 0;
        public static string order = string.Empty;

        public static string stt = string.Empty;
        public static string nguoinhan = string.Empty;
        public static string sonha = string.Empty;
        public static string diachi = string.Empty;
        public static string phuong = string.Empty;
        public static string quan = string.Empty;
        public static string thanhpho = string.Empty;
        public static string ghichu = string.Empty;
        public static string lienhe = string.Empty;

        public static string bcnhan = string.Empty;
        public static string trongluong = string.Empty;
        public static string dichvu = string.Empty;
        public static string nguoigui = string.Empty;
        public static string ngaygui = string.Empty;
        public static string cg = string.Empty;
        private void FrmCG7Print_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ReadExcelFile(sheet, path);
            DsCG7 dscg7 = new DsCG7();
            string _stt , _nguoinhan, _diachi, _quan, _thanhpho, _ghichu, _lienhe;
            RptCG7_kim rptcg7_kim = new RptCG7_kim();
            RptCG7_laser rptcg7_laser = new RptCG7_laser();
            RptCG7_Label rptcg7_label = new RptCG7_Label();

            try
            {
                foreach (DataRow row in dt.Rows)
                {

                   
                    _stt = row[stt].ToString();
                    _nguoinhan = row[nguoinhan].ToString();
                    _diachi = row[sonha].ToString() + ", " + row[diachi].ToString() + ", " + row[phuong].ToString();
                    _quan = row[quan].ToString();
                    _thanhpho = row[thanhpho].ToString();
                    _ghichu = row[ghichu].ToString();
                    _lienhe = row[lienhe].ToString();
                    dscg7.CG7.AddCG7Row(_stt,_nguoinhan,_diachi,_quan,_thanhpho,_lienhe,_ghichu,bcnhan,trongluong,"1",dichvu,nguoigui,ngaygui,cg);                 
                }
                if (flag == 1)
                {
                    rptcg7_kim.SetDataSource(dscg7);
                    crystalReportViewer1.ReportSource = rptcg7_kim;
                }
                else if (flag == 2)
                {
                    rptcg7_laser.SetDataSource(dscg7);
                    crystalReportViewer1.ReportSource = rptcg7_laser;
                }
                else if (flag == 3)
                {
                    rptcg7_label.SetDataSource(dscg7);
                    crystalReportViewer1.ReportSource = rptcg7_label;
                }

            }
            catch (Exception ex)
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

                    if (start == 0)
                    {
                        comm.CommandText = "Select * from [" + sheetName + "] order by [" + order + "]";
                    }
                    else
                    {
                        comm.CommandText = "Select * from [" + sheetName + "] where " + stt + " >= " + start + " order by [" + order + "]";
                    }
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

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
