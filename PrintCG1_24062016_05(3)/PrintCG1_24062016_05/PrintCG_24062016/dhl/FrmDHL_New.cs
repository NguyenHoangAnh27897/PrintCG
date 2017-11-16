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
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using KeepAutomation;
using KeepAutomation.Barcode.Bean;
using PrintCG_24062016.Report;
using PrintCG_24062016.dataset;
namespace PrintCG_24062016
{

    public partial class FrmDHL_New : Form
    {
        public FrmDHL_New()
        {
            InitializeComponent();
           
        }
        private void btnnhapplan_Click(object sender, EventArgs e)
        {
            FrmDHL_PLAN_INSERT frm = new FrmDHL_PLAN_INSERT();
            frm.Show();
        }
        static string NullValue(object Value)
        {
            return Value == null ? "" : Value.ToString();
        }
        private void txtdo_KeyUp(object sender, KeyEventArgs e)
        {
     
        }

        private int number(int n)
        {
            return n;
        }
        private string Get_Month()
        {
            string str = DateTime.Now.ToString("yyyy-MM-dd").Trim();
            str = str.Substring(5, 2);
            return str;
        }
        private string Get_Year()
        {
            string str = DateTime.Now.ToString("yyyy-MM-dd").Trim();
            str = str.Substring(2, 2);
            return str;
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            if (txttrongluong.Text == " " )
            {
                MessageBox.Show("Vui long nhap trong luong");  
            }
            else
            {

                //neu so luong dong > 1 thi cong du lieu vao nhau va lay so DO dau tien lam barcode.
            int maxid;
            maxid = getMax();
                string sophieu = NullValue(dataGridView1.Rows[0].Cells["CG"].Value.ToString());
                string DO = NullValue(dataGridView1.Rows[0].Cells["DO"].Value.ToString());
                int countmailer = dataGridView1.Rows.Count - 1;
                if (txtkhachhang.Text.Trim() != "" && txtdiachikh.Text.Trim() != "")
                {
                    if (countmailer == 1)
                    {
                        if (sophieu != "")
                        {

                            DialogResult dialogResult = MessageBox.Show("CG đã được in trước đó! Bạn muốn in lại ?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //dong y se in de lai thong tin
                                int total = update_plan(DO, DO);
                                if (total > 0)
                                {
                                    
                                    get_sokien(DO);
                                    inphieugui();
                                    idkien = Get_Year() + Get_Month() + s + number(n);
                                    
                                    if (chkIn.Checked == true)
                                        if (int.Parse(txtsoluong.Text) > int.Parse(txtdieukien.Text))
                                        {
                                            {                                              
                                                if (int.Parse(idkien) > maxid)
                                                {
                                                    for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                                    {
                                                        idkien = Get_Year() + Get_Month() + s + number(n);
                                                        intem(i);                                                     
                                                        pd.Print();
                                                        n += 1;
                                                    }
                                                }
                                                if (int.Parse(idkien) < maxid)
                                                {
                                                    for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                                    {

                                                        maxid += 1;
                                                        idkien = maxid.ToString();
                                                        intem(i);
                                                        n += 1;
                                                    }
                                                }
                                            }
                                        }                                                       
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật không thành công");
                                }
                            }
                        }
                        else
                        {
                            int total = update_plan(DO, DO);
                            if (total > 0)
                            {
                                get_sokien(DO);
                                inphieugui();
                                idkien = Get_Year() + Get_Month() + s + number(n);
                                pd.Print();
                                if (chkIn.Checked == true)
                                    if (int.Parse(txtsoluong.Text) > int.Parse(txtdieukien.Text))
                                    {
                                        {
                                            if (int.Parse(idkien) > maxid)
                                            {
                                                for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                                {
                                                    idkien = Get_Year() + Get_Month() + s + number(n);                                             
                                                    intem(i);
                                                    pd.Print();
                                                    n += 1;
                                                }
                                            }
                                            if (int.Parse(idkien) < maxid)
                                            {
                                                for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                                {

                                                    maxid += 1;
                                                    idkien = maxid.ToString();
                                                    intem(i);
                                                    n += 1;
                                                }
                                            }
                                        }
                                    }                     
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                            }
                        }
                    }
                    else if (countmailer > 1)
                    {
                        int total = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            try
                            {
                                total = update_plan(NullValue(row.Cells["DO"].Value.ToString()), DO);
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                        if (total > 0)
                        {
                            get_sokien(DO);
                            inphieugui();
                            idkien = Get_Year() + Get_Month() + s + number(n);
                            //pd.PrinterSettings.PrinterName = cbbtem.Text;
                            pd.Print();
                            if (chkIn.Checked == true)
                                if (int.Parse(txtsoluong.Text) > int.Parse(txtdieukien.Text))
                                {
                                    {
                                        if (int.Parse(idkien) > maxid)
                                        {
                                            for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                            {
                                                idkien = Get_Year() + Get_Month() + s + number(n);
                                                intem(i);
                                                pd.Print();
                                                n += 1;
                                            }
                                        }
                                        if (int.Parse(idkien) < maxid)
                                        {
                                            for (int i = 1; i <= int.Parse(txtsoluong.Text); i++)
                                            {

                                                maxid += 1;
                                                idkien = maxid.ToString();
                                                intem(i);
                                                n += 1;
                                            }
                                        }
                                    }
                                }            
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }
                    }
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Thông tin chưa đủ");
                }
                txtdo.Focus();
                
            }
        }

        private void txttrongluong_Enter(object sender, EventArgs e)
        {
            if(int.Parse(txtsoluong.Text)  > 1)
            {
                txttrongluong.Text = "";
            }
            if (txtsoluong.Text != "")
            {
                txttrongluong.SelectAll();
                if (int.Parse(txtsoluong.Text) > 1)
                {
                    FrmDHL_Listweight frmtlcan = new FrmDHL_Listweight();
                    FrmDHL_Listweight.socg = txtmabill.Text;
                    FrmDHL_Listweight.soluog = txtsoluong.Text;
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

        private void txtdo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    string DO = string.Empty;
                    string DO1 = string.Empty;
                    bool flag = true;
                    OleDbConnection conn = new OleDbConnection();
                    DataSet ds = new DataSet();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    OleDbCommand comm = new OleDbCommand();
                        conn.Open();
                        comm.CommandText = "Select [D/O],CG,SL,TL,ZoneDesc,TP,ShiptoNM,ShiptoAddress,ToNodeCode,Quatity,KH,PGI,DeliveryDate,ToZone,Unit1,Weight,Unit2,Unit3 from tb_dhlplan where [D/O] = '" + txtdo.Text + "' and [PGI] = CDate('" + dtppgi.Value.ToString("dd/MM/yyyy 00:00:00") + "')";
                        comm.Connection = conn;
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = comm;
                        da.Fill(ds);
                        conn.Close();
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (chkghep.Checked == true)
                            {
                                txtdo.Focus();
                            }
                            else
                            {
                                txtsoluong.Focus();
                                if (dataGridView1.Rows.Count > 0)
                                {
                                    dataGridView1.Rows.Clear();
                                }
                            }

                            try
                            {
                                DO = txtdo.Text.Trim();
                            }
                            catch (Exception ex)
                            {
                                DO = "";
                            }
                            foreach (DataGridViewRow rowdo in dataGridView1.Rows)
                            {
                                try
                                {
                                    DO1 = rowdo.Cells[0].Value.ToString();
                                }
                                catch (Exception ex)
                                {
                                    DO1 = "";
                                }
                                if (DO1 == DO)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag == true)
                            {
                                string[] row = new string[] { NullValue(ds.Tables[0].Rows[0]["D/O"].ToString()), NullValue(ds.Tables[0].Rows[0]["CG"].ToString()), NullValue(ds.Tables[0].Rows[0]["SL"].ToString()), NullValue(ds.Tables[0].Rows[0]["TL"].ToString()), ds.Tables[0].Rows[0]["ZoneDesc"].ToString(), NullValue(ds.Tables[0].Rows[0]["TP"].ToString()), ds.Tables[0].Rows[0]["Quatity"].ToString(), NullValue(ds.Tables[0].Rows[0]["KH"].ToString()), ds.Tables[0].Rows[0]["PGI"].ToString(), ds.Tables[0].Rows[0]["DeliveryDate"].ToString(), ds.Tables[0].Rows[0]["ToNodeCode"].ToString(), ds.Tables[0].Rows[0]["Unit1"].ToString(), ds.Tables[0].Rows[0]["Weight"].ToString(), ds.Tables[0].Rows[0]["Unit2"].ToString(), ds.Tables[0].Rows[0]["Unit3"].ToString(), ds.Tables[0].Rows[0]["ShiptoNM"].ToString(), ds.Tables[0].Rows[0]["ShiptoAddress"].ToString() };
                                dataGridView1.Rows.Add(row);
                            }

                            txtkhachhang.ForeColor = Color.Black;
                            txtdiachikh.ForeColor = Color.Black;
                            txtmabill.Text = NullValue(ds.Tables[0].Rows[0]["D/O"].ToString().Trim());
                            txtkhachhang.Text = NullValue(ds.Tables[0].Rows[0]["ShiptoNM"].ToString());
                            txtdiachikh.Text = NullValue(ds.Tables[0].Rows[0]["ShiptoAddress"].ToString());
                            lblremark.Text = NullValue(ds.Tables[0].Rows[0]["KH"].ToString());

                            dataGridView1.Columns["DO"].Width = 75;
                            dataGridView1.Columns["CG"].Width = 110;
                            dataGridView1.Columns["SL"].Width = 30;
                            dataGridView1.Columns["TL"].Width = 50;
                            dataGridView1.Columns["ZoneDesc"].Width = 80;
                            dataGridView1.Columns["TP"].Width = 40;
                            dataGridView1.Columns["Quatity"].Width = 50;
                            dataGridView1.Columns["KH"].Width = 60;
                            dataGridView1.Columns["PGI"].Width = 90;
                            dataGridView1.Columns["DeliveryDate"].Width = 90;
                            dataGridView1.Columns["ToNodeCode"].Width = 80;
                            dataGridView1.Columns["Unit1"].Width = 40;
                            dataGridView1.Columns["Weight"].Width = 50;
                            dataGridView1.Columns["Unit2"].Width = 40;
                            dataGridView1.Columns["Unit3"].Width = 40;
                            dataGridView1.Columns["ShiptoNM"].Width = 300;
                            dataGridView1.Columns["ShiptoAddress"].Width = 400;
                            //dataGridView1.Columns["TongSoLuong"].Width = 400;
                        }
                        txtdo.SelectAll();
                        txtsoluong.Focus();
            }
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
   
                    txttrongluong.Focus();
                
            }
        }

        private void txttrongluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnin.Focus();
            }
        }
        private int update_plan(string donumber,string cg)
        {
            
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                string query = string.Empty;
                if (txtkhachhang.ForeColor == Color.Black)
                {
                    query = "update tb_dhlplan set CG = '" + cg + "',SL = " + txtsoluong.Text + ",TL =" + txttongtrongluong.Text + " where [D/O] = '" + donumber + "'";
                }
                else if (txtkhachhang.ForeColor == Color.Red)
                {
                    query = "update tb_dhlplan set CG = '" + cg + "',SL = " + txtsoluong.Text + ",TL =" + txttongtrongluong.Text + ",ShiptoNM ='" + txtkhachhang.Text + "'," + "ShiptoAddress = '" + txtdiachikh.Text + "'," + " KH ='" + lblremark.Text + "',Contact1 ='" + txtlh1.Text.Trim() + "',Contact2 = '" + txtlh2.Text.Trim() + "',Contact3 = '" + txtlh3.Text.Trim() + "',Employee ='" + txtnvnhan.Text.Trim() + "',SenderName = '" + txtnguoigui.Text.Trim() + "',SenderAddress ='" + txtdiachi.Text.Trim() + "'" + " where [D/O] = '" + donumber + "'";
                }
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                int int_upd = cmd.ExecuteNonQuery();
                conn.Close();
                return int_upd;
            
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

        private void FrmDHL_New_Load(object sender, EventArgs e)
        {
            load_settings();
            ListPrinter();
            //ListBox();
        }
        private void load_settings()
        {            
            txtnvnhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtnvnhan", String.Empty);
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtnguoigui", String.Empty);
            txtdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtdiachi", String.Empty);
            txtghichuphat.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtghichuphat", String.Empty);
            txtghichuphat1.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtghichuphat1", String.Empty);
            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtfolder", String.Empty);
            txtlh1.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtlh1", String.Empty);
            txtlh2.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtlh2", String.Empty);
            txtlh3.Text = (String)Application.UserAppDataRegistry.GetValue("frmdhl_new.txtlh3", String.Empty);
        }
        private void save_settings()
        {

            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtnvnhan", txtnvnhan.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtnguoigui", txtnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtdiachi", txtdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtghichuphat", txtghichuphat.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtghichuphat1", txtghichuphat1.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtfolder", txtfolder.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtlh1", txtlh1.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtlh2", txtlh2.Text);
            Application.UserAppDataRegistry.SetValue("frmdhl_new.txtlh3", txtlh3.Text);
        }

        private void FrmDHL_New_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
        private DataTable get_diachi(string codenode)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = new OleDbConnection();

                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select ShipName,ShipAddress,Remark from tb_diachi where NodeCode = '" + codenode + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return dt;
        }
        string TongSL = string.Empty;
        private void inphieugui()
        {
            try
            {
                RptDHL_A5 rpt = new RptDHL_A5();
                int quatity = 0;
                string cg = string.Empty;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        quatity += int.Parse(row.Cells["Quatity"].Value.ToString());
                    }
                    
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Không tìm thấy Quality");
                }
                //phat sinh hinh barcode
             

                TongSL = sokien;
                TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                _txtbcnhan.Text = "DHL";

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo"];
                _txtDO.Text = "*" + dataGridView1.Rows[0].Cells["DO"].Value.ToString() + "*";

                TextObject _txtDO1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo1"];
                _txtDO1.Text = dataGridView1.Rows[0].Cells["DO"].Value.ToString();

               // BarCode code39 = new BarCode();
               // code39.Symbology = KeepAutomation.Barcode.Symbology.Code39;
               // code39.CodeToEncode = cg;                
               //// code39.generateBarcodeToImageFile(Application.StartupPath + "//barcode.jpg"); // // code dang su dung
               //// rpt.SetParameterValue("imageUrl", Application.StartupPath + "\\barcode.jpg"); // \\

                //ket thuc phat sinh hinh barcode

                TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
                _txtnguoigui.Text = txtnguoigui.Text;

                TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
                _txtdiachigui.Text = txtdiachi.Text;

                TextObject _txtnvnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnvnhan"];
                _txtnvnhan.Text = txtnvnhan.Text;

                TextObject _txtghichuphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat"];
                _txtghichuphat.Text = (txtghichuphat.Text).Replace(".", " \n ");

                TextObject _txtghichuphat1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtyeucauphat1"];
                _txtghichuphat1.Text = (txtghichuphat1.Text).Replace(".", " \n ");

                TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
                _txtngayphat.Text = dataGridView1.Rows[0].Cells["DeliveryDate"].Value.ToString();

                TextObject _txtngaynhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngaynhan"];
                _txtngaynhan.Text = dataGridView1.Rows[0].Cells["PGI"].Value.ToString();

                TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
                _txtnguoinhan.Text = dataGridView1.Rows[0].Cells["ShiptoNM"].Value.ToString();

                TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
                _txtdiachinhan.Text = dataGridView1.Rows[0].Cells["ShiptoAddress"].Value.ToString();

                TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
                _txtghichu.Text = "";

                TextObject _txtsl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
                _txtsl.Text = txtsoluong.Text;

                TextObject _txttl = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
                _txttl.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));


                TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
                _txttlkhoi.Text = String.Format("{0:0,0}", float.Parse(txttongtrongluong.Text.ToString()));

                if (int.Parse(txtsoluong.Text) > 1)
                {
                    TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                    _txtsokien.Text = sokien;
                }
                if (int.Parse(txtsoluong.Text) == 1)
                {
                    TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
                    _txtsokien.Text = txttrongluong.Text + "x" + txtsoluong.Text +"K";
                }

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = dataGridView1.Rows[0].Cells["KH"].Value.ToString();
                ;

                TextObject _Text5 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["Text5"];
                _Text5.Text = dataGridView1.Rows[0].Cells["KH"].Value.ToString();
                ;

                TextObject _txtthanhpho = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtthanhpho"];
                _txtthanhpho.Text = dataGridView1.Rows[0].Cells["ZoneDesc"].Value.ToString();

                TextObject _txtquality = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtquality"];
                _txtquality.Text = quatity.ToString() + " điện thoại + PK";

                TextObject _txtlh1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh1"];
                _txtlh1.Text = txtlh1.Text;

                TextObject _txtlh2 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh2"];
                _txtlh2.Text = txtlh2.Text;

                TextObject _txtlh3 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtlh3"];
                _txtlh3.Text = txtlh3.Text;

                //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluongin.Text), false, 1, 1);


                //cap nhat so kien.

                    OleDbConnection conn = new OleDbConnection();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    conn.Open();
                    string query = string.Empty;
                    if (int.Parse(txtsoluong.Text) > 1)
                    {
                        query = "update tb_dhlplan set TongSL = '" + TongSL + "',Contact1 = '"+ txtlh1.Text.Trim() +"',Contact2 ='"+ txtlh2.Text.Trim() +"',Contact3 = '"+ txtlh3.Text.Trim() +"',SenderName = '"+ txtnguoigui.Text.Trim() +"',SenderAddress ='"+ txtdiachi.Text.Trim() +"',Employee = '"+ txtnvnhan.Text.Trim()+"',PrintTime = '"+ DateTime.Now.ToString() +"' where [D/O] = '" + txtmabill.Text.Trim() + "'";
                    }
                    if (int.Parse(txtsoluong.Text) == 1)
                    {
                        query = "update tb_dhlplan set TongSL = '" + txttrongluong.Text + "x" + txtsoluong.Text + "K" + "',Contact1 = '" + txtlh1.Text.Trim() + "',Contact2 ='" + txtlh2.Text.Trim() + "',Contact3 = '" + txtlh3.Text.Trim() + "',SenderName = '" + txtnguoigui.Text.Trim() + "',SenderAddress ='" + txtdiachi.Text.Trim() + "',Employee = '" + txtnvnhan.Text.Trim() + "',PrintTime = '" + DateTime.Now.ToString() + "' where [D/O] = '" + txtmabill.Text.Trim() + "'";
                    }
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string s = "0000";
        private int n = 0;
        private string idkien;
        private void intem(int soluongin)
        {
            try
            {
               
                RptInTem rpt = new RptInTem();
                if (n > 9)
                 {
                     s = "000";
                 }
                if (n > 99)
                 {
                     s = "00";
                 }
                if (n > 999)
                 {
                     s = "0";
                 }
                if (n > 9999)
                 {
                     s = "";
                 }

                TextObject _txtsoDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoDO"];
                _txtsoDO.Text =  dataGridView1.Rows[0].Cells["DO"].Value.ToString();

                TextObject _txtDO = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtDO"];
                _txtDO.Text = "*" + dataGridView1.Rows[0].Cells["DO"].Value.ToString() + "*";

                TextObject _txtdiachi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachi"];
                _txtdiachi.Text = dataGridView1.Rows[0].Cells["ShiptoAddress"].Value.ToString();

                TextObject _txtdentinh = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdentinh"];
                _txtdentinh.Text = dataGridView1.Rows[0].Cells["ZoneDesc"].Value.ToString();

                TextObject _txttongso = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttongso"];
                _txttongso.Text = txtsoluong.Text;

                TextObject _txtsothutu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsothutu"];
                _txtsothutu.Text = soluongin.ToString();

                TextObject _txtidkien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtidkien"];
                _txtidkien.Text = idkien;

                TextObject _txtidkienmv = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtidkienmv"];
                _txtidkienmv.Text = "*"+idkien+"*";

                TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
                _txtdiadiem.Text = dataGridView1.Rows[0].Cells["KH"].Value.ToString();
                ;

                ////rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.PrintToPrinter(int.Parse(txtsoluong.Text), false, 1, 1);


                ////cap nhat so kien.

                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                string query = string.Empty;
                if (int.Parse(txtsoluong.Text) > 1)
                {
                    query = "insert into tb_dhltem (ID_Kien,SoLuong,DiaChi,ThoiGianTraHang,DiaDiem,DenTinh,DenQuanHuyen) values  ('" + int.Parse(idkien) + "', '" + int.Parse(txtsoluong.Text) + "','" + dataGridView1.Rows[0].Cells["ShiptoAddress"].Value.ToString() + "','" + DateTime.Now + "','" + dataGridView1.Rows[0].Cells["KH"].Value.ToString() + "','" + " TPHCM " + "','" + "" + "')";
                }
                else if ((txtsoluong.Text) == "1")
                {
                    query = "insert into tb_dhltem (ID_Kien,SoLuong,DiaChi,ThoiGianTraHang,DiaDiem,DenTinh,DenQuanHuyen) values  ('" + int.Parse(idkien) + "', '" + int.Parse(txtsoluong.Text) + "','" + dataGridView1.Rows[0].Cells["ShiptoAddress"].Value.ToString() + "','" + DateTime.Now + "','" + dataGridView1.Rows[0].Cells["KH"].Value.ToString() + "','" + " TPHCM " + "','" + "" + "')";
                }
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string sokien = string.Empty;
        private string get_sokien(string socg)
        {
            sokien = "";
            DataTable dt = new DataTable();
            
            try
            {
                OleDbConnection conn = new OleDbConnection();

                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select SL,TL from tb_sltl where CG = '" + socg + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                if (dt.Rows.Count <= 10)
                {
                    int sttkien = 1;
                    foreach (DataRow row in dt.Rows)
                    {

                        sokien = sokien + String.Format("{0:0,0}", float.Parse(row["TL"].ToString())) + "x" + row["SL"].ToString() + "K ; ";
                        sttkien = sttkien + 1;
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return sokien;
        }
        private void get_do()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select * from tb_dhlplan where [D/O] like '%" + txtdo.Text + "%'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtsocg.Text.Trim() != "")
            {
               //xem in phieu gui cũ.
                FrmDHLPrint.type = "D";
                FrmDHLPrint.sophieu = txtsocg.Text.Trim();
                FrmDHLPrint.ghichuphat = txtghichuphat.Text.Trim();
                FrmDHLPrint.ghichuphat1 = txtghichuphat1.Text.Trim();
                FrmDHLPrint frm = new FrmDHLPrint();
                frm.ShowDialog();
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

        SaveFileDialog fsave = new SaveFileDialog();
        private void create_excel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                //string excelfile = txtfolder.Text.Trim() + "\\Excel\\DHL_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".xls";
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
                //bo sung them cac cot khac theo yeu cau cua HNI
                xlWorkSheet.Cells[1, 13] = "DO";
                xlWorkSheet.Cells[1, 14] = "Shop";
                xlWorkSheet.Cells[1, 15] = "Số Máy";
                xlWorkSheet.Cells[1, 16] = "Mã Khách Hàng";
                xlWorkSheet.Cells[1, 17] = "Ngày Phát";
                xlWorkSheet.Cells[1, 18] = "Khu Vực";
                xlWorkSheet.Cells[1, 19] = "Tổng Số Lượng";
                xlWorkSheet.Cells[1, 20] = "Ngày in";

                xlWorkSheet.Cells.NumberFormat = "@";

                string _ngaynhan = dtppgi.Value.ToString();
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

                // khai bao them thong tin
                string _do;
                string _shop;
                string _somay;
                string _makh;
                string _ngayphat;
                string _khuvuc;
                string _tongsl;
                string _ngayin;

                string data;
                int i = 0;
                int j = 0;

                DsExcel dsexcel = new DsExcel();
                DataTable dt = new DataTable();
                dt = ReadInfo(dtppgi.Value);

                foreach (DataRow row in dt.Rows)
                {

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
                        _tenduong = row["ShiptoAddress"].ToString();
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

                    try
                    {
                        _do = row["D/O"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _do = "";
                    }

                    try
                    {
                        _shop = row["ShiptoNM"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _shop = "";
                    }

                    try
                    {
                        _somay = row["Quatity"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _somay = "";
                    }

                    try
                    {
                        _makh = row["ToNodeCode"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _makh = "";
                    }

                    try
                    {
                        _ngayphat = row["DeliveryDate"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _ngayphat = "";
                    }

                    try
                    {
                        _khuvuc = row["Vung"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _khuvuc = "";
                    }
                    try
                    {
                        _tongsl = row["TongSL"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _tongsl = "";
                    }

                    try
                    {
                        _ngayin = row["PrintTime"].ToString();
                    }
                    catch (Exception ex)
                    {
                        _ngayin = "";
                    }

                    //_ghichu = row[cmbdo.Text].ToString() + "/" + row["KH"].ToString().ToUpper();
                    try
                    {
                        dsexcel.Excel.AddExcelRow(DateTime.Parse(_ngaynhan).ToString("dd/MM/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong, _tinhthanh, _quanhuyen, _ghichu, _do, _shop, _somay, _makh, _ngayphat,_khuvuc, _tongsl,_ngayin);
                    }
                    catch (Exception ex)
                    {
                    }

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


                //if (File.Exists(excelfile) == true)
                //{
                //    File.Delete(excelfile);
                //}

                //xlWorkBook.SaveAs(excelfile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.SaveAs(fsave.FileName);
                xlWorkBook.Close(true, misValue, misValue);



                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                MessageBox.Show("Xuất thành công ");
            }
            else
            {
                MessageBox.Show("Vui long nhap ten");
            }
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
        private DataTable ReadInfo(DateTime PGI)
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select * from tb_dhlplan where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
           // comm.CommandText = "select * from tb_dhlplan,tb_diachi,tb_tinhthanh where tb_dhlplan.[ToZone] = tb_diachi.[Zone] and tb_diachi.[ZoneDesc] = tb_tinhthanh.[TenTinh] and [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            //comm.CommandText = "Select [tb_dhlplan.CG] from tb_dhlplan inner join tb_diachi on tb_diachi.[Zone] = tb_dhlplan.[ToZone]  where [PGI] = CDate('" + PGI.ToString("dd/MM/yyyy 00:00:00") + "') and CG <> ''";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            return dt;
        }
        private void getdo()
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select [D/O],CG,SL,TL,ZoneDesc,TP,ShiptoNM,ShiptoAddress,ToNodeCode,Quatity,KH,PGI,DeliveryDate,ToZone,Unit1,Weight,Unit2,Unit3 from tb_dhlplan where [D/O] like '%" + txtdo.Text + "%' and [PGI] = CDate('" + dtppgi.Value.ToString("dd/MM/yyyy 00:00:00") + "')";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private int getMax()
        {
            int maxid = 0;
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select Max(ID_Kien) from tb_dhltem')";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            maxid = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return maxid;
        }

        private void btnxoado_Click(object sender, EventArgs e)
        {
            FrmDHLXoaDO.type = "D";
            FrmDHLXoaDO frm = new FrmDHLXoaDO();
            frm.Show();
        }

        private void btndoanhthu_Click(object sender, EventArgs e)
        {
           
        }

        private void btndongbo_Click(object sender, EventArgs e)
        {
            // them moi vao db sau do update lai syn =  1
            int total = 0;
            string DO;
            string PGI;
            string DeliveryDate;
            string ToZone;
            string ZoneDesc;
            string ToNodeCode;
            string ShiptoNM;
            string ShiptoAddress;
            int Quatity;
            string Unit1;
            int Weight;
            string Unit2;
            string Subcon;
            string CG;
            int SL;
            int TL;
            string TP;
            string KH;
            string Unit3;
            string TongSL;
            string SenderName;
            string SenderAddress;
            string Contact1;
            string Contact2;
            string Contact3;
            string Employee;
            string Vung;

            DBLIST.Service1SoapClient list = new PrintCG_24062016.DBLIST.Service1SoapClient();
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand comm = new OleDbCommand();
            conn.Open();
            comm.CommandText = "Select * from tb_dhlplan where Syn is Null and CG IS NOT NULL";
            //comm.CommandText = "Select * from tb_dhlplan";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                DO = row["D/O"].ToString();
                PGI = DateTime.Parse(row["PGI"].ToString()).ToString("yyyy-MM-dd") ;
                DeliveryDate = DateTime.Parse(row["DeliveryDate"].ToString()).ToString("yyyy-MM-dd");
                ToZone = row["ToZone"].ToString();
                ZoneDesc = row["ZoneDesc"].ToString();
                ToNodeCode = row["ToNodeCode"].ToString();
                ShiptoNM = row["ShiptoNM"].ToString();
                ShiptoAddress = row["ShiptoAddress"].ToString();
                Quatity = int.Parse(row["Quatity"].ToString());
                Unit1 = row["Unit1"].ToString();
                Weight = int.Parse(row["Weight"].ToString());
                Unit2 = row["Unit2"].ToString();
                Subcon = row["Subcon"].ToString();
                CG = row["CG"].ToString();
                SL = int.Parse(row["SL"].ToString());
                TL = int.Parse(row["TL"].ToString());
                TP = row["TP"].ToString();
                KH = row["KH"].ToString();
                Unit3 = row["Unit3"].ToString();
                TongSL = row["TongSL"].ToString();
                SenderName = row["SenderName"].ToString();
                SenderAddress = row["SenderAddress"].ToString();
                Contact1 = row["Contact1"].ToString();
                Contact2 = row["Contact2"].ToString();
                Contact3 = row["Contact3"].ToString();
                Employee = row["Employee"].ToString();
                Vung = row["Vung"].ToString();
                string count = list.InsertDHLPlan(DO,PGI,DeliveryDate,ToZone,ZoneDesc,ToNodeCode,ShiptoNM,ShiptoAddress,Quatity,Unit1,Weight,Unit2,Subcon,CG,SL,TL,TP,KH,Unit3,TongSL,SenderName,SenderAddress,Contact1,Contact2,Contact3,Employee,Vung);
                if (count == "0")
                {
                    string query = "update tb_dhlplan set Syn = '1' where [D/O] ='" + DO + "'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    total += 1;
                }
            }
            MessageBox.Show("Đã cập nhật [" + total + "] DO");
            conn.Close();
        }

        private void txttrongluong_TextChanged(object sender, EventArgs e)
        {
           
        }


        private PrintDocument pd = new PrintDocument();

        //private void ListBox()
        //{
        //    foreach (var p in PrinterSettings.InstalledPrinters)
        //    {
        //        cbbtem.Items.Add(p);
        //    }
        //}

        //public static class Printer
        //{
        //    [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        //    public static extern bool SetDefaultPrinter(string printername);
        //}

        //private void cbbtem_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string pname = cbbtem.SelectedItem.ToString();
        //    Printer.SetDefaultPrinter(pname);
        //}

        private void ListPrinter()
        {
            try
            {
                DataTable dtp = new DataTable();
                dtp.Clear();
                dtp.Columns.Add("Printer", Type.GetType("System.String"));
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    DataRow dr = dtp.NewRow();
                    dr["Printer"] = printer;
                    dtp.Rows.Add(dr);
                    // MessageBox.Show(printer);
                }
                cbbtem.DataSource = dtp;
                //cbbtem.DataMember = "Printer";
                cbbtem.DisplayMember = "Printer";
                cbbtem.ValueMember = "Printer";
                PrintDocument pd = new PrintDocument();
                string sPrinterName = pd.PrinterSettings.PrinterName;
                cbbtem.SelectedText = sPrinterName;
            }
            catch (Exception ex)
            {
                cbbtem.Text = "Không thể tìm thấy máy in";
            }


        }
    
    }
}
