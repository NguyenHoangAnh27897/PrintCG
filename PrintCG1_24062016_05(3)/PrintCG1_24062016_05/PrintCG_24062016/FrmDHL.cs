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
using System.Drawing.Printing;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel; 

namespace PrintCG_24062016
{
    public partial class FrmDHL : Form
    {
        public FrmDHL()
        {
            InitializeComponent();
        }

        string path;
        string pathkh;
        string pathtt;

        string[] listsheet;
        string[] listsheetkh;

        string[] listdo;
        string[] listnguoinhan;
        string[] listdiachi;
        string[] listthanhpho;
        string[] listghichu;
        string[] listngaynhan;
        string[] listngayphat;
        string[] listshipcode;

        //thong tin khách hang
        string[] listkhnodecode;
        string[] listkhshipname;
        string[] listkhshipaddress;
        string[] listkhremark;

        //thong tin tinh thanh
        string[] listsheettt;
        string[] listttmatinh;
        string[] listtttentinh;

        //thong tin phieu gui
        string nguoigui = string.Empty;
        string diachigui = string.Empty;
        string nvnhan = string.Empty;
        string bcnhan = string.Empty;
        string nguoinhan = string.Empty;
        string diachinhan = string.Empty;
        string thanhpho = string.Empty;
        string ghichu = string.Empty;
        string ngaynhan = string.Empty;
        string ngayphat = string.Empty;
        string remark = string.Empty;
        string tenthanhpho = string.Empty;

        string shipnodecode;
        string zonename;

    
        private void FrmDHL_Load(object sender, EventArgs e)
        {
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
            listnguoinhan =GetExcelSheetColumns(path,cmbsheet.Text);
            listdiachi = GetExcelSheetColumns(path, cmbsheet.Text);
            listthanhpho = GetExcelSheetColumns(path, cmbsheet.Text);
            listghichu = GetExcelSheetColumns(path, cmbsheet.Text);
            listngaynhan = GetExcelSheetColumns(path, cmbsheet.Text);
            listngayphat = GetExcelSheetColumns(path, cmbsheet.Text);
            listdo = GetExcelSheetColumns(path, cmbsheet.Text);
            listshipcode = GetExcelSheetColumns(path, cmbsheet.Text);
          
        }
        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string fileExtension = Path.GetExtension(excelFileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
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
        public string[] GetExcelSheetColumns(string excelFileName,string sheet)
        {


            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string fileExtension = Path.GetExtension(excelFileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheet + "]";
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
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
            cmbdiachi.DataSource = listdiachi;
        }

        private void cmbthanhpho_Enter(object sender, EventArgs e)
        {
            cmbthanhpho.DataSource = listthanhpho;
        }

        private void cmbghichu_Enter(object sender, EventArgs e)
        {
            cmbghichu.DataSource = listghichu;
        }

        private void cmbngaynhan_Enter(object sender, EventArgs e)
        {
            cmbngaynhan.DataSource = listngaynhan;
        }

        private void cmbngayphat_Enter(object sender, EventArgs e)
        {
            cmbngayphat.DataSource = listngayphat;
        }
        private void cmbdo_Enter(object sender, EventArgs e)
        {
            cmbdo.DataSource = listdo;
        }
        private void load_settings()
        {
            cmbdo.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbdo", String.Empty);
            cmbnguoinhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbnguoinhan", String.Empty);
            cmbdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbdiachi", String.Empty);
            cmbthanhpho.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbthanhpho", String.Empty);
            cmbghichu.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbghichu", String.Empty);
            cmbngaynhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbngaynhan", String.Empty);
            cmbngayphat.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbngayphat", String.Empty);
            txtnvnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtnvnhan", String.Empty);
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtnguoigui", String.Empty);
            txtdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtdiachi", String.Empty);
            txtghichuphat.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtghichuphat", String.Empty);
            txtghichuphat1.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtghichuphat1", String.Empty);
            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.txtfolder", String.Empty);
            cmbshipcode.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbshipcode", String.Empty);

            cmbkhnodecode.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbkhnodecode", String.Empty);
            cmbkhshipname.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbkhshipname", String.Empty);
            cmbkhshipaddress.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbkhshipaddress", String.Empty);
            cmbkhremark.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbkhremark", String.Empty);
            lblkhchonfile.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.lblkhchonfile", String.Empty);
            cmbsheetkh.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbsheetkh", String.Empty);

            lblttfile.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.lblttfile", String.Empty);
            cmbsheettt.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbsheettt", String.Empty);
            cmbttmatinh.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbttmatinh", String.Empty);
            cmbtttentinh.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl.cmbtttentinh", String.Empty);

            
        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbdo", cmbdo.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbnguoinhan", cmbnguoinhan.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbdiachi", cmbdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbthanhpho", cmbthanhpho.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbghichu", cmbghichu.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbngaynhan", cmbngaynhan.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbngayphat", cmbngayphat.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtnvnhan", txtnvnhan.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtnguoigui", txtnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtdiachi", txtdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtghichuphat", txtghichuphat.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtghichuphat1", txtghichuphat1.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.txtfolder", txtfolder.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbshipcode", cmbshipcode.Text);

            Application.UserAppDataRegistry.SetValue("frmdhl.cmbkhshipname", cmbkhshipname.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbkhnodecode", cmbkhnodecode.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbkhshipaddress", cmbkhshipaddress.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbkhremark", cmbkhremark.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.lblkhchonfile", lblkhchonfile.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbsheetkh", cmbsheetkh.Text);

            Application.UserAppDataRegistry.SetValue("frmdhl.lblttfile", lblttfile.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbsheettt", cmbsheettt.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbttmatinh", cmbttmatinh.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl.cmbtttentinh", cmbtttentinh.Text);


        }

        private void FrmDHL_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void txtdo_Enter(object sender, EventArgs e)
        {
            //txtdo.SelectAll();
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
                    comm.CommandText = "Select *  from [" + sheetName + "] where [" + cmbdo.Text + "] like '%" + txtdo.Text + "%'";

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
        private DataTable ReadExcelFile2(string sheetName, string path)
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
                    comm.CommandText = "Select *  from [" + sheetName + "] where [" + cmbshipcode.Text + "] = '" + dataGridView1.Rows[0].Cells[cmbshipcode.Text].Value + "'";

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
        private DataTable ReadExcelFile3(string sheetName, string path)
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
                    comm.CommandText = "Select *  from [" + sheetName + "] where [" + cmbtttentinh.Text.Trim() + "] = '" + dataGridView1.Rows[0].Cells[cmbthanhpho.Text].Value + "'";

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

        private void btnin_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                string DO = string.Empty;

                try
                {
                    DO = dataGridView1.Rows[0].Cells[cmbdo.Text].Value.ToString();
                }
                catch (Exception ex)
                {
                    DO = "";
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string sophieu = string.Empty;

                    try
                    {
                        sophieu = row.Cells["CG"].Value.ToString().Trim();
                        // DO = row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim();
                        if (DO == row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim())
                        {
                            flag = false;
                        }
                        else if (DO != row.Cells[cmbdo.Text.Trim()].Value.ToString().Trim())
                        {
                            flag = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        sophieu = "";
                        DO = "";
                    }

                    if (sophieu != "")
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    updateexcel();
                    // MessageBox.Show("khong co trung so DO");
                }
                else
                {
                    MessageBox.Show("Có quá nhiều DO khác nhau trên lưới, hoặc DO đã in trước đó. Vui lòng kiểm tra lại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại thông tin : Mã bill chưa đúng chuẩn quy định");
            }
            
        }
        string sokien;
        private void updateexcel()
        {
            //truoc khi in cap nhat so phieu, so luong, trong luong, hoa don, noi den vao file excel;
            //sau do load lai danh sach nay len luoi de nguoi dung xem.
            //in ra so kien tren phieu gui neu tong so kien < 10
            //tien hanh in phieu gui
            int numberOfRecords;
            if (txttongtrongluong.Text.Trim() != "" && txtsoluong.Text.Trim() !="")
            {
                sokien = "";
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
                        comm.CommandText = "Update [" + cmbsheet.Text + "] set CG = '" + txtmabill.Text + "',KH ='"+ lblremark.Text +"',SL ='" + txtsoluong.Text + "',TL ='" + txttongtrongluong.Text + "',TP ='"+ lbltp.Text +"'  where [" + cmbdo.Text + "] like '%" + txtdo.Text + "%'";
                        comm.Connection = conn;
                        conn.Open();
                        comm.ExecuteNonQuery();
                        numberOfRecords = comm.ExecuteNonQuery();
                        conn.Close();

                    }
                }

                dataGridView1.DataSource = ReadExcelFile(cmbsheet.SelectedItem.ToString(), path);
                try
                {
                    if (txtsoluong.Text != "1")
                    {
                        //lay ra danh sach so kien cua cg
                        using (OleDbConnection conn = new OleDbConnection())
                        {
                            DataTable dt = new DataTable();
                            string excelfile = txtfolder.Text.Trim() +"\\" + txtmabill.Text + ".xls";
                            string Import_FileName = excelfile;

                            string fileExtension = Path.GetExtension(Import_FileName);
                            if (fileExtension == ".xls")
                                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                            if (fileExtension == ".xlsx")
                                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                            using (OleDbCommand comm = new OleDbCommand())
                            {

                                // comm.CommandText = "Select * from [" + sheetName + "] where CG = '"+ socg+ "'";
                                // comm.CommandText = "Select * from [Sheet1$] where CG = " + txtsocg.Text;
                                comm.CommandText = "Select * from [Sheet1$]";
                                comm.Connection = conn;

                                using (OleDbDataAdapter da = new OleDbDataAdapter())
                                {
                                    da.SelectCommand = comm;
                                    dt.Rows.Clear();
                                    da.Fill(dt);
                                    if (dt.Rows.Count <= 10)
                                    {
                                        int sttkien = 1;
                                        foreach (DataRow row in dt.Rows)
                                        {

                                            sokien = sokien  + String.Format("{0:0,0}", float.Parse(row["TL"].ToString())) + "x" + row["SL"].ToString() + "K ; ";
                                            sttkien = sttkien + 1;
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        //sokien = "Số kiện : 1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check MailerID");
                }
                if (numberOfRecords > 0)
                {
                    inphieugui();
                }
                else
                {
                    MessageBox.Show("Cập nhật CG, SL,TL,TP,KH lên plan không thành công. Vui lòng thử lại");
                }

                //tang so phieu len 1
                // txtsocg.Text = (int.Parse(txtsocg.Text) + 1).ToString();
               
                txtsoluong.Text = "1";
              
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            //in bang ke neu 10 kien


            txtdo.Focus();
            txtdo.SelectAll();
        }
        private void inphieugui()
        {
            try
            {
                RptDHL_A5 rpt = new RptDHL_A5();

                TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                _txtbcnhan.Text = bcnhan;

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtDO.Text = "*" + txtmabill.Text + "*";

                TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo1"];
                _txtDO1.Text =  txtmabill.Text;

                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = nguoigui;

                TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                _txtdiachigui.Text = diachigui;

                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                _txtnvnhan.Text = nvnhan;

                TextObject _txtghichuphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat"];
                _txtghichuphat.Text = (txtghichuphat.Text).Replace(".", " \n ");

                TextObject _txtghichuphat1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat1"];
                _txtghichuphat1.Text = (txtghichuphat1.Text).Replace(".", " \n ");

                TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
                _txtngayphat.Text = ngayphat;

                TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngaynhan.Text = ngaynhan;

                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = nguoinhan;

                TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _txtdiachinhan.Text = diachinhan;
         
                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = ghichu;

                TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                _txtsl.Text = txtsoluong.Text;

                TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                _txttl.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));


                TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));

                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = sokien;

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = remark;

                TextObject _txtthanhpho = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txtthanhpho.Text = tenthanhpho;

                //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void txtdo_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (lblfile.Text != "Bạn chưa chọn file")
                {
                    DataTable dt = ReadExcelFile(cmbsheet.SelectedItem.ToString(), path);
                    dataGridView1.DataSource = dt;
                    //neu co du lieu tu DO thi lay thong tin
                    if (dt.Rows.Count > 0)
                    {
                        nguoigui = txtnguoigui.Text;
                        diachigui = txtdiachi.Text;
                        nvnhan = txtnvnhan.Text;
                        bcnhan = "DHL";
                        DataTable dtkh = ReadExcelFile2(cmbsheetkh.Text.Trim(), lblkhchonfile.Text);
                        if (dtkh.Rows.Count > 0)
                        {
                            nguoinhan = dtkh.Rows[0][cmbkhshipname.Text].ToString();
                            diachinhan = dtkh.Rows[0][cmbkhshipaddress.Text].ToString();
                            remark = dtkh.Rows[0][cmbkhremark.Text].ToString();
                            DataTable dttp = ReadExcelFile3(cmbsheettt.Text.Trim(), lblttfile.Text);
                            thanhpho = dttp.Rows[0][cmbttmatinh.Text].ToString();
                            tenthanhpho = dt.Rows[0][cmbthanhpho.Text].ToString();
                            ngaynhan = dt.Rows[0][cmbngaynhan.Text].ToString();
                            ngayphat = dt.Rows[0][cmbngayphat.Text].ToString();
                            txtmabill.Text = DateTime.Parse(dt.Rows[0][cmbngaynhan.Text].ToString()).ToString("yyMMdd") + dt.Rows[0][cmbdo.Text].ToString().Trim();
                            if (dt.Rows[0]["CG"].ToString() != "")
                            {
                                txtsocg.Text = dt.Rows[0]["CG"].ToString();
                                txtsoluong.Text = dt.Rows[0]["SL"].ToString();
                                txttongtrongluong.Text = dt.Rows[0]["TL"].ToString();                             
                            }
                            else if (dt.Rows[0]["CG"].ToString() == "")
                            {
                                txtsocg.Text = "";
                                txtsoluong.Text = "1";
                                txttongtrongluong.Text = "";
                            }
                            try
                            {
                                ghichu = dt.Rows[0][cmbghichu.Text].ToString();
                            }
                            catch (Exception ex)
                            {
                                ghichu = "";
                            }
                        }
                        else
                        {
                            lblremark.Text = "Name not found!";
                        }
                        lblremark.Text = remark;
                        lbltp.Text = thanhpho;
                        txtkhachhang.Text = nguoinhan;
                        txtdiachikh.Text = diachinhan;
                        //can query lay thong tin người nhan
                    }
                }

                else
                {
                    MessageBox.Show("Chưa chọn file excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbsheet_SelectedValueChanged(object sender, EventArgs e)
        {
            listnguoinhan = GetExcelSheetColumns(path,cmbsheet.Text);
            listdiachi = GetExcelSheetColumns(path, cmbsheet.Text);
            listthanhpho = GetExcelSheetColumns(path, cmbsheet.Text);
            listghichu = GetExcelSheetColumns(path, cmbsheet.Text);
            listngaynhan = GetExcelSheetColumns(path, cmbsheet.Text);
            listngayphat = GetExcelSheetColumns(path, cmbsheet.Text);
            listdo = GetExcelSheetColumns(path, cmbsheet.Text);
        }              
        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttrongluong.Focus();
            }
        }

        private void cmbtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsoluong.Focus();
            }
        }

        private void txttrongluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnin.Focus();
            }
        }

        private void txttrongluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txttrongluong.Text.Trim() != "")
            {
                if (txttrongluong.Text.ToString().Length == 13)
                {
                    txttongtrongluong.Text = txttrongluong.Text.ToString().Substring(7, 5);
                }
                else if (txttrongluong.Text.ToString().Length != 13)
                {
                    txttongtrongluong.Text = txttrongluong.Text;
                }
            }
        }

        private void txttrongluong_Enter(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                txttrongluong.SelectAll();
                if (int.Parse(txtsoluong.Text) > 1)
                {
                    FrmDHL_Listweight frmtlcan = new FrmDHL_Listweight();
                    FrmDHL_Listweight.socg = txtmabill.Text;
                    FrmDHL_Listweight.soluog = txtsoluong.Text;
                    FrmDHL_Listweight.folder = txtfolder.Text.Trim();
                    if (frmtlcan.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //Gán giá trị textValue trong DialogForm cho textbox txtValue trong MainForm
                        txttongtrongluong.Text = frmtlcan.textValue;
                    }
                   // frmtlcan.Show();

                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại trọng lượng");
            }
        }
       
        private void cmbdiadiem_MouseClick(object sender, MouseEventArgs e)
        {
            //loadtxtfile();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text != "1")
                {
                    //lay ra danh sach so kien cua cg
                    using (OleDbConnection conn = new OleDbConnection())
                    {
                        DataTable dt = new DataTable();
                        string excelfile = txtfolder.Text.Trim() +"\\" + txtsocg.Text + ".xls";
                        string Import_FileName = excelfile;

                        string fileExtension = Path.GetExtension(Import_FileName);
                        if (fileExtension == ".xls")
                            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                        if (fileExtension == ".xlsx")
                            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                        using (OleDbCommand comm = new OleDbCommand())
                        {

                            // comm.CommandText = "Select * from [" + sheetName + "] where CG = '"+ socg+ "'";
                            // comm.CommandText = "Select * from [Sheet1$] where CG = " + txtsocg.Text;
                            comm.CommandText = "Select * from [Sheet1$]";
                            comm.Connection = conn;

                            using (OleDbDataAdapter da = new OleDbDataAdapter())
                            {
                                da.SelectCommand = comm;
                                dt.Rows.Clear();
                                da.Fill(dt);
                                if (dt.Rows.Count <= 10)
                                {
                                    int sttkien = 1;
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        sokien = sokien + sttkien + ": " + String.Format("{0:0,0}", float.Parse(row["TL"].ToString())) + "*" + row["SL"].ToString() + "  ;";
                                        sttkien = sttkien + 1;
                                    }
                                }


                            }

                        }
                    }
                }
                else
                {
                    //sokien = "Số kiện : 1";
                }
                RptDHL_A5 rpt = new RptDHL_A5();

                TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                _txtbcnhan.Text = bcnhan;

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtDO.Text = "*" + txtsocg.Text + "*";

                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = nguoigui;

                TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                _txtdiachigui.Text = diachigui;

                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                _txtnvnhan.Text = nvnhan;

                TextObject _txtghichuphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat"];
                _txtghichuphat.Text = txtghichuphat.Text;

                TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
                _txtngayphat.Text = ngayphat;

                TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngaynhan.Text = ngaynhan;

                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = nguoinhan;

                TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _txtdiachinhan.Text = diachinhan;

                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = ghichu;

                TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                _txtsl.Text = txtsoluong.Text;

                TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                _txttl.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text));
                

                TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text));

                TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                _txtsokien.Text = sokien;



                // rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);

                txtsoluong.Text = "1";
                txttongtrongluong.Text = "";
            }
            catch (Exception ex)
            {
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                create_excel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void create_excel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            string excelfile = txtfolder.Text.Trim() + "\\Excel\\DHL_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



            xlWorkSheet.Cells[1, 1] = "Ngày nhận";
            xlWorkSheet.Cells[1, 2] = "Giờ";
            xlWorkSheet.Cells[1, 3] = "Số phiếu";
            xlWorkSheet.Cells[1, 4] = "LH";
            xlWorkSheet.Cells[1, 5] = "DV";
            xlWorkSheet.Cells[1, 6] = "SL";
            xlWorkSheet.Cells[1, 7] = "TL";
            xlWorkSheet.Cells[1, 8] = "TL Khối";
            xlWorkSheet.Cells[1, 9] = "Tên đường(Nhận)";
            xlWorkSheet.Cells[1, 10] = "T/Thành(NĐ)";
            xlWorkSheet.Cells[1, 11] = "Q/Huyện(Nhận)";
            xlWorkSheet.Cells[1, 12] = "Ghi chú";

            xlWorkSheet.Cells.NumberFormat = "@";

            string _ngaynhan;
            string _gio = "00:00";
            string _sophieu;
            string _loaihang = "HH";
            string _dichvu = "SN";
            string _soluong = "1";
            string _trongluong;
            string _trongluongkhoi;
            string _tenduong;
            string _tinhthanh;
            string _quanhuyen;
            string _ghichu = "";
            string data;
            int i = 0;
            int j = 0;

            DsExcel dsexcel = new DsExcel();
            DataTable dt = new DataTable();
            dt = ReadExcelFile1(cmbsheet.Text, path);

            foreach (DataRow row in dt.Rows)
            {
                try
                {

                    _ngaynhan = row[cmbngaynhan.Text].ToString();
                }
                catch (Exception ex)
                {
                    _ngaynhan = (DateTime.Today).ToString("dd/MM/yyyy");
                }

                try
                {
                    _sophieu = row["CG"].ToString();
                }
                catch (Exception ex)
                {
                    _sophieu = "";
                }

                try
                {
                    _soluong = row["SL"].ToString();
                }
                catch (Exception ex)
                {
                    _soluong = "0";
                }

                try
                {
                    _trongluong = row["TL"].ToString();
                }
                catch (Exception ex)
                {
                    _trongluong = "0";
                }

                try
                {
                    _trongluongkhoi = row["TL"].ToString();
                }
                catch (Exception ex)
                {
                    _trongluongkhoi = "0";
                }

                try
                {
                    _tenduong = row[cmbdiachi.Text].ToString();
                }
                catch (Exception ex)
                {
                    _tenduong = "";
                }

                try
                {
                    _quanhuyen = "";

                }
                catch (Exception ex)
                {
                    _quanhuyen = "";
                }

                try
                {
                    _tinhthanh = row["TP"].ToString();

                }
                catch (Exception ex)
                {
                    _tinhthanh = "";
                }

                //_ghichu = row[cmbdo.Text].ToString() + "/" + row["KH"].ToString().ToUpper();
                dsexcel.Excel.AddExcelRow(DateTime.Parse(_ngaynhan).ToString("MM/dd/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong, _tinhthanh, _quanhuyen, _ghichu,"","","","","","","","");

            }
            for (i = 0; i <= dsexcel.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= dsexcel.Tables[0].Columns.Count - 1; j++)
                {

                    data = dsexcel.Tables[0].Rows[i].ItemArray[j].ToString();
                    i = i + 1;
                    xlWorkSheet.Cells[i + 1, j + 1] = data;

                    i = i - 1;
                    //excelSheet.Cells[i , j ] = data;
                }
            }


            if (File.Exists(excelfile) == true)
            {
                File.Delete(excelfile);
            }

            xlWorkBook.SaveAs(excelfile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);



            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Xuất thành công " + excelfile);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private DataTable ReadExcelFile1(string sheetName, string path)
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
                    //comm.CommandText = "Select distinct * from [" + sheetName + "]";
                    comm.CommandText = "select count(CG),CG,SL,TL,TP,KH,[" + cmbdiachi.Text + "],[" + cmbngaynhan.Text + "] from [" + sheetName + "] group by CG,SL,TL,TP,KH,[" + cmbdiachi.Text + "],[" + cmbngaynhan.Text + "]  having COUNT(CG) > 0";
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

        private void label25_DoubleClick(object sender, EventArgs e)
        {
            if (txtfolder.Enabled == true)
            {
                txtfolder.Enabled = false;

            }
            else if (txtfolder.Enabled == false)
            {
                txtfolder.Enabled = true;
            }
        }

        private void cmbshipcode_Enter(object sender, EventArgs e)
        {
            cmbshipcode.DataSource = listshipcode;
        }

        private void btnkhchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            pathkh = openFileDialog2.FileName;
            lblkhchonfile.Text = pathkh;
            listsheetkh = GetExcelSheetNames(pathkh);
            cmbsheetkh.DataSource = listsheetkh;
            listkhnodecode = GetExcelSheetColumns(pathkh,cmbsheetkh.Text);
            listkhshipname = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
            listkhshipaddress = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
            listkhremark = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
        }

        private void cmbkhnodecode_Enter(object sender, EventArgs e)
        {
            cmbkhnodecode.DataSource = listkhnodecode;
        }

        private void cmbkhshipname_Enter(object sender, EventArgs e)
        {
            cmbkhshipname.DataSource = listkhshipname;
        }

        private void cmbkhshipaddress_Enter(object sender, EventArgs e)
        {
            cmbkhshipaddress.DataSource = listkhshipaddress;
        }

        private void cmbkhremark_Enter(object sender, EventArgs e)
        {
            cmbkhremark.DataSource = listkhremark;
        }

        private void cmbsheetkh_SelectedValueChanged(object sender, EventArgs e)
        {
            listkhnodecode = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
            listkhshipname = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
            listkhshipaddress = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
            listkhremark = GetExcelSheetColumns(pathkh, cmbsheetkh.Text);
        }

        private void btnttchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            pathtt = openFileDialog3.FileName;
            lblttfile.Text = pathtt;
            listsheettt = GetExcelSheetNames(pathtt);
            cmbsheettt.DataSource = listsheettt;
            listttmatinh = GetExcelSheetColumns(pathtt, cmbsheettt.Text);
            listtttentinh = GetExcelSheetColumns(pathtt, cmbsheettt.Text);
        }

        private void cmbsheettt_SelectedValueChanged(object sender, EventArgs e)
        {
            listttmatinh = GetExcelSheetColumns(pathtt, cmbsheettt.Text);
            listtttentinh = GetExcelSheetColumns(pathtt, cmbsheettt.Text);
        }

        private void cmbttmatinh_Enter(object sender, EventArgs e)
        {
            cmbttmatinh.DataSource = listttmatinh;
        }

        private void cmbtttentinh_Enter(object sender, EventArgs e)
        {
            cmbtttentinh.DataSource = listtttentinh;
        }

        private void txtdo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsoluong.Focus();
            }
        }

    }
}
