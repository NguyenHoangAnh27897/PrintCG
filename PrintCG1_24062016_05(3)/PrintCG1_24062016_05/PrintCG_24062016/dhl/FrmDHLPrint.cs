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
using System.IO;
using PrintCG_24062016.Report;

namespace PrintCG_24062016
{
    public partial class FrmDHLPrint : Form
    {
        public FrmDHLPrint()
        {
            InitializeComponent();
        }
        public static string type = string.Empty;
        public static string sophieu = string.Empty;
        public static string ghichuphat = string.Empty;
        public static string ghichuphat1 = string.Empty;
        string nguoigui = string.Empty;
        string diachigui = string.Empty;
        string employee = string.Empty;
        string deliverydate = string.Empty;
        string DODate = string.Empty;
        string shiptoname = string.Empty;
        string shiptoaddress = string.Empty;
        string kh = string.Empty;
        string tp = string.Empty;
        private void FrmDHLPrint_Load(object sender, EventArgs e)
        {
            DBLIST.Service1SoapClient list = new PrintCG_24062016.DBLIST.Service1SoapClient();
            DataSet ds = new DataSet();
            if (type == "D")
            {
                ds = list.DHL_GetDO(sophieu);
                nguoigui = ds.Tables[0].Rows[0]["SenderName"].ToString();
                diachigui = ds.Tables[0].Rows[0]["SenderAddress"].ToString();
                employee = ds.Tables[0].Rows[0]["Employee"].ToString();
                deliverydate = ds.Tables[0].Rows[0]["DeliveryDate"].ToString();
                DODate = ds.Tables[0].Rows[0]["PGI"].ToString();
                shiptoname = ds.Tables[0].Rows[0]["ShiptoNM"].ToString();
                shiptoaddress = ds.Tables[0].Rows[0]["ShiptoAddress"].ToString();
                kh = ds.Tables[0].Rows[0]["KH"].ToString();
                tp = ds.Tables[0].Rows[0]["ZoneDesc"].ToString();
            }
            else if (type == "S")
            {
                ds = list.Sony_GetDO(sophieu);
                nguoigui = ds.Tables[0].Rows[0]["SenderName"].ToString();
                diachigui = ds.Tables[0].Rows[0]["SenderAddress"].ToString();
                employee = ds.Tables[0].Rows[0]["Employee"].ToString();
                deliverydate = ds.Tables[0].Rows[0]["DeliveryDate"].ToString();
                DODate = ds.Tables[0].Rows[0]["DODate"].ToString();
                shiptoname = ds.Tables[0].Rows[0]["ShipToName"].ToString();
                shiptoaddress = ds.Tables[0].Rows[0]["ShipToStreet"].ToString();
                kh = ds.Tables[0].Rows[0]["Remark"].ToString();
                tp = ds.Tables[0].Rows[0]["Province"].ToString();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                RptDHL_A5 rpt = new RptDHL_A5();

                TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                _txtbcnhan.Text = "DHL";

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtDO.Text = "*" + sophieu + "*";

                TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo1"];
                _txtDO1.Text = sophieu;

                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = nguoigui;

                TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                _txtdiachigui.Text = diachigui;

                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                //_txtnvnhan.Text = nhanvien;
                _txtnvnhan.Text = employee;

                TextObject _txtghichuphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat"];
                _txtghichuphat.Text = (ghichuphat).Replace(".", " \n ");

                TextObject _txtghichuphat1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat1"];
                _txtghichuphat1.Text = (ghichuphat1).Replace(".", " \n ");

                TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
                _txtngayphat.Text = deliverydate;

                TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngaynhan.Text = DODate;

                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = shiptoname;

                TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _txtdiachinhan.Text = shiptoaddress ;

                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = "";

                TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                _txtsl.Text = ds.Tables[0].Rows[0]["SL"].ToString();

                TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                _txttl.Text = String.Format("{0:0,0}", float.Parse(ds.Tables[0].Rows[0]["TL"].ToString()));


                TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(ds.Tables[0].Rows[0]["TL"].ToString()));

                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = ds.Tables[0].Rows[0]["TongSL"].ToString();

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = kh;

                TextObject _txtthanhpho = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txtthanhpho.Text = tp;

                TextObject _txtquality = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtquality"];
                _txtquality.Text = ds.Tables[0].Rows[0]["Quatity"].ToString() + " điện thoại + PK";

                TextObject _txtlh1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh1"];
                _txtlh1.Text = ds.Tables[0].Rows[0]["Contact1"].ToString();

                TextObject _txtlh2 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh2"];
                _txtlh2.Text = ds.Tables[0].Rows[0]["Contact2"].ToString();

                TextObject _txtlh3 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh3"];
                _txtlh3.Text = ds.Tables[0].Rows[0]["Contact3"].ToString();

                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu gửi, liên hệ bộ phận in phiếu để Đồng bộ dữ liệu");
            }
        }
    }
}
