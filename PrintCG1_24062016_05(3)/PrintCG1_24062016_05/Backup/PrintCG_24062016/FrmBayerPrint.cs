using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PrintCG_24062016
{
    public partial class FrmBayerPrint : Form
    {
        public FrmBayerPrint()
        {
            InitializeComponent();
        }

        public static string report;
        public static string bc;
        public static string nhanvien;
        public static string nguoigui;
        public static string diachigui;
        public static string telgui;
        public static string ngaygui;
        public static string noidung;
        public static string soluong;
        public static string trongluong;
        public static string loaihang;
        private void FrmBayerPrint_Load(object sender, EventArgs e)
        {
            string _stt;
            string _nguoinhan;
            string _diachinhan;
            string _telnhan;
            string _noiden;
            string _sophieu;
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DsCG11 dscg11 = new DsCG11();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                 OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select * from tb_bayer where Isactive = 1 order by STT";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    _stt = row["STT"].ToString();
                    _nguoinhan = row["Ten"].ToString();
                    _diachinhan = row["Diachi"].ToString();
                    _telnhan = row["SDT"].ToString();
                    _noiden = row["Tentinh"].ToString();
                    if (_stt.Length == 1)
                    {
                        _sophieu = "BY" + ngaygui.Substring(8, 2) + ngaygui.Substring(3, 2) + ngaygui.Substring(0, 2) + "0" + _stt;
                    }
                    else
                    {
                        _sophieu = "BY" + ngaygui.Substring(8, 2) + ngaygui.Substring(3, 2) + ngaygui.Substring(0, 2) + _stt;
                    }
                    dscg11.CG11.AddCG11Row(ngaygui, "", _sophieu, loaihang, "SN", soluong, trongluong,trongluong, _nguoinhan, _diachinhan, _noiden, noidung,bc , nhanvien, nguoigui, diachigui, "", "", "", "", _telnhan, telgui, "", "", "","");
                }
                conn.Close();

                //khai bao thong tin nguoi gui
                if (report == "CG")
                {
                    RptBayer_A5 rpt = new RptBayer_A5();

                    TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbuucuc"];
                    _txtbc.Text = bc;

                    TextObject _txtnv = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnhanvien"];
                    _txtnv.Text = nhanvien;

                    TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                    _txtnguoigui.Text = nguoigui;

                    TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                    _txtdiachigui.Text = diachigui;

                    TextObject _txttelgui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelgui"];
                    _txttelgui.Text = telgui;

                    TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                    _txtsoluong.Text = soluong;

                    TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                    _txttrongluong.Text = trongluong;

                    TextObject _txttrongluongkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluongkhoi"];
                    _txttrongluongkhoi.Text = trongluong;

                    TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                    _txtngaynhan.Text = ngaygui;

                    TextObject _txtnoidung = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnoidung"];
                    _txtnoidung.Text = noidung;

                    rpt.SetDataSource(dscg11);
                    crystalReportViewer1.ReportSource = rpt;
                }
                else if(report=="BP")
                {
                    RptBayerBP rpt = new RptBayerBP();
                    TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbuucuc"];
                    _txtbc.Text = bc;

                    TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                    _txtnguoigui.Text = nguoigui;

                    TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                    _txtngaynhan.Text = ngaygui;

                    rpt.SetDataSource(dscg11);
                    crystalReportViewer1.ReportSource = rpt;
                }
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}
