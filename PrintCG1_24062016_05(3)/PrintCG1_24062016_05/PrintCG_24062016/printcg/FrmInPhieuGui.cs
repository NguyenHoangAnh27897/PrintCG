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
using PrintCG_24062016.Report;
using PrintCG_24062016.dataset;
using Excel = Microsoft.Office.Interop.Excel;

namespace PrintCG_24062016
{
    public partial class FrmInPhieuGui : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmInPhieuGui()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }
        string path;
        string path1;
        string[] listsheet1;
        string[] listsheet;
        string[] listnguoinhan;
        string[] listdiachinhan;
        string[] listthanhpho;
        string[] listtelnhan;
        string[] listsoluong;
        string[] listtrongluong;
        string[] listtrongluongkhoi;
        string[] listloaihang;
        string[] listghichu;
        string[] listcod;
        string[] listthuho;
        string[] listnguoigui;
        string[] listdiachigui;
        string[] listtelgui;
        string[] listsophieu;
        string[] listcuocchinh;
        string[] listhengio;
        string[] listcuockhac;
        string[] listtongtien;

        //thiet lap a4
        string[] lista4masterkey;
        string[] lista4detailkey;
        string[] lista4noidung;
        string[] lista4ghichu;
        string[] lista4sl;
        string[] lista4tl;

        private void FrmInPhieuGui_Load(object sender, EventArgs e)
        {
           
            txtngaygui.Text = DateTime.Now.ToString("dd/MM/yyyy");
            load_settings();
        }

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;

            lblfile.Text = path;
            listsheet = GetExcelSheetNames(path);
            cmbsheet.DataSource = listsheet;

            listnguoinhan = GetExcelSheetColumns(path);
            listdiachinhan = GetExcelSheetColumns(path);
            listthanhpho = GetExcelSheetColumns(path);
            listtelnhan = GetExcelSheetColumns(path);
            listsoluong = GetExcelSheetColumns(path);
            listtrongluong = GetExcelSheetColumns(path);
            listtrongluongkhoi = GetExcelSheetColumns(path);
            listloaihang = GetExcelSheetColumns(path);
            listghichu = GetExcelSheetColumns(path);
            listcod = GetExcelSheetColumns(path);
            listthuho = GetExcelSheetColumns(path);
            listnguoigui = GetExcelSheetColumns(path);
            listdiachigui = GetExcelSheetColumns(path);
            listtelgui = GetExcelSheetColumns(path);
            listsophieu = GetExcelSheetColumns(path);
            listcuocchinh = GetExcelSheetColumns(path);
            listhengio = GetExcelSheetColumns(path);
            listcuockhac = GetExcelSheetColumns(path);
            listtongtien = GetExcelSheetColumns(path);
            lista4masterkey = GetExcelSheetColumns(path);

            //a4
            //lista4noidung = GetExcelSheetColumns(path);
            //lista4ghichu = GetExcelSheetColumns(path);
            //lista4sl = GetExcelSheetColumns(path);
            //lista4tl = GetExcelSheetColumns(path);
        }
        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string Import_FileName = path;
            string fileExtension = Path.GetExtension(Import_FileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            con = new OleDbConnection(conStr);
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }
            return excelSheetNames;
        }
        public string[] GetExcelSheetColumns(string excelFileName)
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
                    comm.CommandText = "Select * from [" + cmbsheet.Text + "]";
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        String[] excelSheetNames = new String[dt.Columns.Count];
                        //string a = " row " + dt.Rows.Count.ToString() + " Col " + dt.Columns.Count.ToString();

                        int i = 0;
                        try
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                //this.Invoke(new MethodInvoker(delegate()
                                {
                                    if (column.ColumnName.ToString().Substring(0, 1) != "F")
                                    {
                                        excelSheetNames[i] = column.ColumnName.ToString();
                                        i++;
                                    }
                                    else
                                    {
                                        return excelSheetNames;
                                    }

                                };
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        return excelSheetNames;
                    }

                }
            }

        }

        private void cmbnguoinhan_Enter(object sender, EventArgs e)
        {
            cmbnguoinhan.DataSource = listnguoinhan;
        }

        private void cmbdiachi_Enter(object sender, EventArgs e)
        {
            cmbdiachi.DataSource = listdiachinhan;
        }

        private void cmbthanhpho_Enter(object sender, EventArgs e)
        {
            cmbthanhpho.DataSource = listthanhpho;
        }

        private void cmbtelnhan_Enter(object sender, EventArgs e)
        {
            cmbtelnhan.DataSource = listtelnhan;
        }

        private void cmbsoluong_Enter(object sender, EventArgs e)
        {
            cmbsoluong.DataSource = listsoluong;
        }

        private void cmbtrongluong_Enter(object sender, EventArgs e)
        {
            cmbtrongluong.DataSource = listtrongluong;
        }

        private void cmbloaihang_Enter(object sender, EventArgs e)
        {
            // cmbloaihang.DataSource = listloaihang;
        }

        private void cmbghichu_Enter(object sender, EventArgs e)
        {
            cmbghichu.DataSource = listghichu;
        }

        private void btnincg1_Click(object sender, EventArgs e)
        {
            FrmInPhieuGuiPrint.paper = "Kim";
            try
            {
                if (lblfile.Text == "Bạn chưa chọn file")
                {
                    Rptphieugui_kim rpt = new Rptphieugui_kim();
                    string papername = string.Empty;
                    int i = 0;
                    System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();
                    string sotudong = "";

                    // doctoprint.PrinterSettings.PrinterName = "\\\\RD2\\Epson LX-300+";
                    int rawKind = 0;
                    for (i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
                    {
                        if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "CG1") //CG1
                        {
                            rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField("kind", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
                            papername = "CG1"; //CG1
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }

                    if (papername == "CG1") //CG1
                    {
                        TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbc"];
                        _txtbc.Text = txtbcnhan.Text;
                        TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                        _txtghichu.Text = cmbghichu.Text;
                        TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                        _txtnguoigui.Text = cmbnguoigui.Text;
                        TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                        _txtdiachigui.Text = cmbdiachigui.Text;
                        TextObject _txttelgui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelgui"];
                        _txttelgui.Text = cmbtelgui.Text;
                        TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                        _txtnguoinhan.Text = cmbnguoinhan.Text;
                        TextObject _diachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachi"];
                        _diachi.Text = cmbdiachi.Text;
                        TextObject _txttelnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelnhan"];
                        _txttelnhan.Text = cmbtelnhan.Text;
                        TextObject _txttp = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttp"];
                        _txttp.Text = cmbthanhpho.Text;
                        TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                        _txtnvnhan.Text = txtnvnhan.Text; ;
                        TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                        _txtsoluong.Text = cmbsoluong.Text; ;
                        TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                        _txttrongluong.Text = cmbtrongluong.Text;
                        TextObject _txtngay = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngay"];
                        _txtngay.Text = txtngaygui.Text;

                        TextObject _txtcuocchinh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtcuocchinh"];
                        if (cmbcuocchinh.Text != "0")
                        {
                            _txtcuocchinh.Text = String.Format("{0:0,0}", float.Parse(cmbcuocchinh.Text));
                        }
                        else
                        {
                            _txtcuocchinh.Text = "";
                        }

                        TextObject _txthengio = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthengio"];
                        if (cmbhengio.Text != "0")
                        {
                            _txthengio.Text = String.Format("{0:0,0}", float.Parse(cmbhengio.Text));
                        }
                        else
                        {
                            _txthengio.Text = "";
                        }
                        TextObject _txtphikhac = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphikhac"];
                        if (cmbcuockhac.Text != "0")
                        {
                            _txtphikhac.Text = String.Format("{0:0,0}", float.Parse(cmbcuockhac.Text));
                        }
                        else
                        {
                            _txtphikhac.Text = "";
                        }


                        TextObject _txttong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttong"];

                        if (cmbcuockhac.Text != "0")
                        {
                            _txttong.Text = String.Format("{0:0,0}", float.Parse(cmbcuockhac.Text));
                        }
                        else
                        {
                            _txttong.Text = "";
                        }

                        if (cmbloaihang.Text == "HH")
                        {
                            TextObject _txthh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthh"];
                            _txthh.Text = cmbloaihang.Text;

                        }
                        else if (cmbloaihang.Text == "TL")
                        {
                            TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                            _txttl.Text = cmbloaihang.Text;

                        }

                        rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind; // an tam thoi
                        rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);
                        //rpt.PrintToPrinter(1, false, 1, 1);


                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhận chọn lại máy in mặc định. Kiểm tra khổ giấy đã tạo là CG1(24x15in)");
                    }
                }
                else //in phieu gui tu file excel
                {
                    //khai bao thong tin cac cot .
                    FrmInPhieuGuiPrint.path = lblfile.Text;
                    FrmInPhieuGuiPrint.sheet = cmbsheet.Text;
                    FrmInPhieuGuiPrint.nguoigui = cmbnguoigui.Text;
                    FrmInPhieuGuiPrint.diachigui = cmbdiachigui.Text;
                    FrmInPhieuGuiPrint.tellgui = cmbtelgui.Text;
                    FrmInPhieuGuiPrint.ngaygui = txtngaygui.Text;
                    FrmInPhieuGuiPrint.nvnhan = txtnvnhan.Text;
                    FrmInPhieuGuiPrint.bcnhan = txtbcnhan.Text;
                    FrmInPhieuGuiPrint.cuocchinh = cmbcuocchinh.Text;
                    FrmInPhieuGuiPrint.hengio = cmbhengio.Text;
                    FrmInPhieuGuiPrint.cuockhac = cmbcuockhac.Text;
                    FrmInPhieuGuiPrint.tongtien = cmbtongtien.Text;
                    FrmInPhieuGuiPrint.loaihang = cmbloaihang.Text;

                    FrmInPhieuGuiPrint.nguoinhan = cmbnguoinhan.Text;
                    FrmInPhieuGuiPrint.diachi = cmbdiachi.Text;
                    FrmInPhieuGuiPrint.thanhpho = cmbthanhpho.Text;
                    FrmInPhieuGuiPrint.telnhan = cmbtelnhan.Text;
                    FrmInPhieuGuiPrint.soluong = cmbsoluong.Text;
                    FrmInPhieuGuiPrint.trongluong = cmbtrongluong.Text;
                    FrmInPhieuGuiPrint.ghichu = cmbghichu.Text;
                    FrmInPhieuGuiPrint frm = new FrmInPhieuGuiPrint();
                    frm.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnina5_Click(object sender, EventArgs e)
        {
            if (lblfile.Text != "Bạn chưa chọn file")
            {
                FrmInPhieuGuiPrint.paper = "Laser";
                string sotudong = "";
                //so tu dong

                try
                {
                    FrmInPhieuGuiPrint.path = lblfile.Text;
                    FrmInPhieuGuiPrint.sheet = cmbsheet.Text;
                    FrmInPhieuGuiPrint.nguoigui = cmbnguoigui.Text;
                    FrmInPhieuGuiPrint.diachigui = cmbdiachigui.Text;
                    FrmInPhieuGuiPrint.tellgui = cmbtelgui.Text;
                    FrmInPhieuGuiPrint.ngaygui = txtngaygui.Text;
                    FrmInPhieuGuiPrint.nvnhan = txtnvnhan.Text;
                    FrmInPhieuGuiPrint.bcnhan = txtbcnhan.Text;
                    FrmInPhieuGuiPrint.cuocchinh = cmbcuocchinh.Text;
                    FrmInPhieuGuiPrint.hengio = cmbhengio.Text;
                    FrmInPhieuGuiPrint.cuockhac = cmbcuockhac.Text;
                    FrmInPhieuGuiPrint.tongtien = cmbtongtien.Text;
                    FrmInPhieuGuiPrint.loaihang = cmbloaihang.Text;

                    FrmInPhieuGuiPrint.nguoinhan = cmbnguoinhan.Text;
                    FrmInPhieuGuiPrint.diachi = cmbdiachi.Text;
                    FrmInPhieuGuiPrint.thanhpho = cmbthanhpho.Text;
                    FrmInPhieuGuiPrint.telnhan = cmbtelnhan.Text;
                    FrmInPhieuGuiPrint.soluong = cmbsoluong.Text;
                    FrmInPhieuGuiPrint.trongluong = cmbtrongluong.Text;
                    FrmInPhieuGuiPrint.trongluongkhoi = cmbtrongluongkhoi.Text;
                    FrmInPhieuGuiPrint.ghichu = cmbghichu.Text;
                    FrmInPhieuGuiPrint.cod = cmbcod.Text;
                    FrmInPhieuGuiPrint.thuho = cmbthuho.Text;
                    if (chkcgtudong.Checked == true)
                    {
                        FrmInPhieuGuiPrint.check = true;
                    }
                    else
                    {
                        FrmInPhieuGuiPrint.sophieu = cmbsophieu.Text;
                    }
                    //FrmInPhieuGuiPrint.sophieu = cmbsophieu.Text;
                    FrmInPhieuGuiPrint frm = new FrmInPhieuGuiPrint();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }


            }
            else
            {
                MessageBox.Show("Chưa mở tính năng in phiếu lẽ trên A5");
            }
        }

        private void txtdiachigui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbtelgui.Focus();
                cmbtelgui.SelectAll();
            }
        }

        private void txttelgui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtngaygui.Focus();
                txtngaygui.SelectAll();
            }
        }

        private void txtngaygui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnvnhan.Focus();
                txtnvnhan.SelectAll();
            }
        }

        private void txtnvnhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbcnhan.Focus();
                txtbcnhan.SelectAll();
            }
        }

        private void cmbdiachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbthanhpho.Focus();
                cmbthanhpho.SelectAll();
            }
        }

        private void cmbnguoinhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbdiachi.Focus();
                cmbdiachi.SelectAll();
            }
        }

        private void cmbthanhpho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbtelnhan.Focus();
                cmbtelnhan.SelectAll();
            }
        }

        private void cmbloaihang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbsoluong.Focus();
                cmbsoluong.SelectAll();
            }
        }

        private void cmbsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbtrongluong.Focus();
                cmbtrongluong.SelectAll();
            }
        }

        private void cmbtrongluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbghichu.Focus();
                cmbghichu.SelectAll();
            }
        }

        private void cmbghichu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcuocchinh.Focus();
                cmbcuocchinh.SelectAll();
            }
        }

        private void txtcuocchinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbhengio.Focus();
                cmbhengio.SelectAll();
            }
        }

        private void txthengio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcuockhac.Focus();
                cmbcuockhac.SelectAll();
            }
        }

        private void txtnguoigui_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbdiachigui.Focus();
                cmbdiachigui.SelectAll();
            }
        }

        private void txtnvnhan_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbcnhan.Focus();
                txtbcnhan.SelectAll();
            }
        }

        private void txtbcnhan_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbnguoinhan.Focus();
                cmbnguoinhan.SelectAll();
            }
        }

        private void cmbtelnhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbloaihang.Focus();
                cmbloaihang.SelectAll();
            }
        }

        private void txtsaochep_Enter(object sender, EventArgs e)
        {
            txtsaochep.SelectAll();
        }

        private void txtsoluongin_Enter(object sender, EventArgs e)
        {
            txtsoluongin.SelectAll();
        }

        private void txtcuocchinh_KeyUp(object sender, KeyEventArgs e)
        {
            cmbtongtien.Text = (float.Parse(cmbcuocchinh.Text) + float.Parse(cmbhengio.Text) + float.Parse(cmbcuockhac.Text)).ToString();
        }

        private void txthengio_KeyUp(object sender, KeyEventArgs e)
        {
            cmbtongtien.Text = (float.Parse(cmbcuocchinh.Text) + float.Parse(cmbhengio.Text) + float.Parse(cmbcuockhac.Text)).ToString();
        }

        private void txtcuockhac_KeyUp(object sender, KeyEventArgs e)
        {
            cmbtongtien.Text = (float.Parse(cmbcuocchinh.Text) + float.Parse(cmbhengio.Text) + float.Parse(cmbcuockhac.Text)).ToString();
        }

        private void cmbsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("test");
        }
        private void load_settings()
        {
            cmbnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbnguoigui", String.Empty);
            cmbdiachigui.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbdiachigui", String.Empty);
            cmbtelgui.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbtelgui", String.Empty);
            txtnvnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.txtnvnhan", String.Empty);
            txtbcnhan.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            cmbnguoinhan.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbnguoinhan", String.Empty);
            cmbdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbdiachi", String.Empty);
            cmbthanhpho.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbthanhpho", String.Empty);
            cmbtelnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbtelnhan", String.Empty);
            cmbghichu.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbghichu", String.Empty);
            cmbcod.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbcod", String.Empty);
            cmbthuho.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbthuho", String.Empty);
            cmbnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbnguoigui", String.Empty);
            cmbdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbdiachi", String.Empty);
            cmbtelgui.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbtelgui", String.Empty);
            cmbsophieu.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbsophieu", String.Empty);
            cmbcuocchinh.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbcuocchinh", String.Empty);
            cmbhengio.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbhengio", String.Empty);
            cmbcuockhac.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbcuockhac", String.Empty);
            cmbtongtien.Text = (String)Application.UserAppDataRegistry.GetValue("frminphieugui.cmbtongtien", String.Empty);

        }
        private void save_settings()
        {

            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbnguoigui", cmbnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbdiachigui", cmbdiachigui.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbtelgui", cmbtelgui.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.txtnvnhan", txtnvnhan.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.txtbcnhan", txtbcnhan.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbnguoinhan", cmbnguoinhan.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbdiachi", cmbdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbthanhpho", cmbthanhpho.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbtelnhan", cmbtelnhan.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbghichu", cmbghichu.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbcod", cmbcod.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbthuho", cmbthuho.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbnguoigui", cmbnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbdiachi", cmbdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbtelgui", cmbtelgui.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbsophieu", cmbsophieu.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbcuocchinh", cmbcuocchinh.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbhengio", cmbhengio.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbcuockhac", cmbcuockhac.Text);
            Application.UserAppDataRegistry.SetValue("frminphieugui.cmbtongtien", cmbtongtien.Text);

        }

        private void FrmInPhieuGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void cmbcod_Enter(object sender, EventArgs e)
        {
            cmbcod.DataSource = listcod;
        }

        private void cmbnguoigui_Enter(object sender, EventArgs e)
        {
            cmbnguoigui.DataSource = listnguoigui;
        }

        private void cmbdiachigui_Enter(object sender, EventArgs e)
        {
            cmbdiachigui.DataSource = listdiachigui;
        }

        private void cmbtelgui_Enter(object sender, EventArgs e)
        {
            cmbtelgui.DataSource = listtelgui;
        }

        private void cmbsophieu_Enter(object sender, EventArgs e)
        {
            cmbsophieu.DataSource = listsophieu;
        }

        private void cmbtrongluongkhoi_Enter(object sender, EventArgs e)
        {
            cmbtrongluongkhoi.DataSource = listtrongluongkhoi;
        }

        private void cmbthuho_Enter(object sender, EventArgs e)
        {
            cmbthuho.DataSource = listthuho;
        }

        private void cmbcuocchinh_Enter(object sender, EventArgs e)
        {
            cmbcuocchinh.DataSource = listcuocchinh;
        }

        private void cmbhengio_Enter(object sender, EventArgs e)
        {
            cmbhengio.DataSource = listhengio;
        }

        private void cmbcuockhac_Enter(object sender, EventArgs e)
        {
            cmbcuockhac.DataSource = listcuockhac;
        }

        private void cmbtongtien_Enter(object sender, EventArgs e)
        {
            cmbtongtien.DataSource = listtongtien;
        }

        private void cmba4noidung_Enter(object sender, EventArgs e)
        {
            cmba4noidung.DataSource = lista4noidung;
        }

        private void cmba4ghichu_Enter(object sender, EventArgs e)
        {
            cmba4ghichu.DataSource = lista4ghichu;
        }

        private void cmba4sl_Enter(object sender, EventArgs e)
        {
            cmba4sl.DataSource = lista4sl;
        }

        private void cmba4tl_Enter(object sender, EventArgs e)
        {
            cmba4tl.DataSource = lista4tl;
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
                    comm.CommandText = "Select *  from [" + sheetName + "]";
                    //comm.CommandText = "Select * from [" + sheetName + "]";

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
        private DataTable ReadExcelFile1(string sheetName, string path, string shipcode)
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
                    //comm.CommandText = "Select *  from [" + sheetName + "] where [" + cmba4keydetails.Text + "] = " + shipcode + "";
                    comm.CommandText = "Select [" + cmba4keydetails.Text + "],[" + cmba4noidung.Text + "],[" + cmba4ghichu.Text + "],Sum([" + cmba4sl.Text + "]) as " + cmba4sl.Text + ",sum([" + cmba4tl.Text + "]) as " + cmba4tl.Text + "  from [" + sheetName + "] where [" + cmba4keydetails.Text + "] = " + shipcode + " group by [" + cmba4noidung.Text + "],[" + cmba4ghichu.Text + "],[" + cmba4keydetails.Text + "]";
                    //comm.CommandText = "Select * from [" + sheetName + "]";

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
        private void btnina4_Click(object sender, EventArgs e)
        {
            if (lblfile.Text != "Bạn chưa chọn file")
            {
                RptPhieuGui_A4 rpt = new RptPhieuGui_A4();
                DataTable dt = ReadExcelFile(cmbsheet.SelectedItem.ToString(), path);
                DsA4 dsa4 = new DsA4();
                string shipcode = string.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    TextObject _txtsophieu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu"];
                    _txtsophieu.Text = "*" + row[cmbsophieu.Text].ToString() + "*";


                    TextObject _txtsophieu1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsophieu1"];
                    _txtsophieu1.Text = row[cmbsophieu.Text].ToString();

                    TextObject _txtbc = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbuucuc"];
                    _txtbc.Text = txtbcnhan.Text;
                    TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                    _txtnguoigui.Text = row[cmbnguoigui.Text].ToString();

                    TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                    try
                    {
                        _txtdiachigui.Text = row[cmbdiachigui.Text].ToString();
                    }
                    catch
                    {
                        _txtdiachigui.Text = "";
                    }

                    TextObject _txttelgui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelgui"];
                    try
                    {
                        _txttelgui.Text = row[cmbtelgui.Text].ToString();
                    }
                    catch
                    {
                        _txttelgui.Text = "";
                    }

                    TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                    _txtnguoinhan.Text = row[cmbnguoinhan.Text].ToString();
                    TextObject _diachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                    _diachi.Text = row[cmbdiachi.Text].ToString();

                    TextObject _telnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttelnhan"];
                    _telnhan.Text = row[cmbtelnhan.Text].ToString();

                    TextObject _noiden = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnoiden"];
                    _noiden.Text = row[cmbthanhpho.Text].ToString();

                    if (cmbloaihang.SelectedText == "HH")
                    {
                        TextObject _tl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                        _tl.Text = "";
                        TextObject _hh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthh"];
                        _hh.Text = "X";
                    }
                    else
                    {
                        TextObject _tl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttl"];
                        _tl.Text = "X";
                        TextObject _hh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthh"];
                        _hh.Text = "";
                    }

                    TextObject _noidung = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                    _noidung.Text = row[cmbghichu.Text].ToString();
                    TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                    _txtnvnhan.Text = txtnvnhan.Text;

                    TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                    try
                    {
                        _txtsoluong.Text = row[cmbsoluong.Text].ToString();
                    }
                    catch
                    {
                        _txtsoluong.Text = "";
                    }

                    TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                    TextObject _txttrongluongkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluongkhoi"];
                    try
                    {
                        _txttrongluong.Text = row[cmbtrongluong.Text].ToString();
                        _txttrongluongkhoi.Text = row[cmbtrongluong.Text].ToString();
                    }
                    catch
                    {
                        _txttrongluong.Text = "";
                        _txttrongluongkhoi.Text = "";
                    }
                    TextObject _txtngay = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                    _txtngay.Text = txtngaygui.Text;

                    TextObject _txtcuocchinh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtcuocchinh"];
                    try
                    {
                        _txtcuocchinh.Text = row[cmbcuocchinh.Text].ToString();
                    }
                    catch
                    {
                        _txtcuocchinh.Text = cmbcuocchinh.Text.ToString();
                    }

                    TextObject _txthengio = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txthengio"];
                    try
                    {
                        _txthengio.Text = row[cmbhengio.Text].ToString();
                    }
                    catch
                    {
                        _txthengio.Text = cmbhengio.Text.ToString();
                    }

                    TextObject _txtphikhac = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtphikhac"];
                    try
                    {
                        _txtphikhac.Text = row[cmbhengio.Text].ToString();
                    }
                    catch
                    {
                        _txtphikhac.Text = cmbhengio.Text.ToString();
                    }

                    TextObject _txttongcong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttongcong"];
                    try
                    {
                        _txttongcong.Text = row[cmbtongtien.Text].ToString();
                    }
                    catch
                    {
                        _txttongcong.Text = cmbtongtien.Text.ToString();
                    }



                    DataTable dt1 = ReadExcelFile1(cmba4sheet.SelectedItem.ToString(), path1, row[cmba4keymaster.Text].ToString());
                    int introw = 1;
                    dsa4.PrintA4.Rows.Clear();
                    foreach (DataRow row1 in dt1.Rows)
                    {
                        dsa4.PrintA4.Rows.Add(introw, row1[cmba4noidung.Text].ToString(), row1[cmba4ghichu.Text].ToString(), row1[cmba4sl.Text].ToString(), row1[cmba4tl.Text].ToString(), row1[cmba4keydetails.Text].ToString());
                        introw += 1;
                    }
                    //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                    rpt.SetDataSource(dsa4);
                    rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);

                }
            }

            else
            {
                //MessageBox.Show("Chưa chọn file excel");
            }
        }

        private void btna4file_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            path1 = openFileDialog2.FileName;

            lbla4file.Text = path1;
            listsheet1 = GetExcelSheetNames(path1);
            cmba4sheet.DataSource = listsheet1;
            //a4
            lista4detailkey = GetExcelSheetColumns(path1);
            lista4noidung = GetExcelSheetColumns(path1);
            lista4ghichu = GetExcelSheetColumns(path1);
            lista4sl = GetExcelSheetColumns(path1);
            lista4tl = GetExcelSheetColumns(path1);
        }

        private void cmba4keymaster_Enter(object sender, EventArgs e)
        {
            cmba4keymaster.DataSource = lista4masterkey;
        }

        private void cmba4keydetails_Enter(object sender, EventArgs e)
        {
            cmba4keydetails.DataSource = lista4detailkey;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chkcgtudong.Checked == true)
            {
                string sotudong;
                for(int i = 0; i < dataGridView1.RowCount -1; i++)
                {
                    sotudong = sgpservice.getmaxMailerID("SGP");
                    dataGridView1.Rows[i].Cells[0].Value = sotudong;
                }

                SaveFileDialog fsave = new SaveFileDialog();
                Excel.Application obj = new Excel.Application();
                Excel.Workbook wbook;

                fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
                fsave.ShowDialog();
                if (fsave.FileName != "")
                {
                    wbook = obj.Workbooks.Add(Type.Missing);
                    obj.Columns.ColumnWidth = 25;
                    wbook.Worksheets.Add();
                    // truyen data
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                   
                        //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

                        //dat ten sheet
                        for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                        {
                            obj.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }
                    }


                    wbook.SaveAs(fsave.FileName);
                    MessageBox.Show("Save Success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else
            {
                SaveFileDialog fsave = new SaveFileDialog();
                Excel.Application obj = new Excel.Application();
                Excel.Workbook wbook;

                fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
                fsave.ShowDialog();
                if (fsave.FileName != "")
                {
                    wbook = obj.Workbooks.Add(Type.Missing);
                    obj.Columns.ColumnWidth = 25;
                    wbook.Worksheets.Add();
                    // truyen data
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        
                        //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

                        //dat ten sheet
                        for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                        {
                            obj.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }
                    }


                    wbook.SaveAs(fsave.FileName);
                    MessageBox.Show("Save Success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
