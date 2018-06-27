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

namespace PrintCG_24062016.MayMan
{
    public partial class FrmMayMan : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmMayMan()
        {
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddCH frm = new FrmAddCH();
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.RptMayMan rpt = new Report.RptMayMan();

            TextObject _txtnguoigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoigui"];
            _txtnguoigui.Text = txtSender.Text;
            TextObject _txtdiachigui = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachigui"];
            _txtdiachigui.Text = txtAddressSender.Text;
            TextObject _txtnguoinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtnguoinhan"];
            _txtnguoinhan.Text = cbbName.Text;
            TextObject _txtdiachinhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiachinhan"];
            _txtdiachinhan.Text = txtAddress.Text;
            TextObject _txtdiadiem = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdiadiem"];
            _txtdiadiem.Text = textBox3.Text;
            TextObject _txtdo1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtdo1"];
            _txtdo1.Text = txtSoPhieu.Text;

            TextObject _txtsoluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsoluong"];
            _txtsoluong.Text = txtQuantity.Text;
            TextObject _txttrongluong = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttrongluong"];
            _txttrongluong.Text = txtWeight.Text;
            TextObject _txttlkhoi = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txttlkhoi"];
            _txttlkhoi.Text = txtWeight.Text;
            TextObject _txtsokien = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtsokien"];
            _txtsokien.Text = txtkien.Text;
            TextObject _txtghichu = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtghichu"];
            _txtghichu.Text = txanote.Text;

            TextObject _txtngayphat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtngayphat"];
            _txtngayphat.Text = dtpSend.Value.ToString("dd/MM/yyyy");
            rpt.PrintToPrinter(int.Parse(txtPrint.Text), false, 1, 1);
            MessageBox.Show("In thanh cong"); 

            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query = "insert into tb_mayman (Sender, SendAddress, SendDate, MailerID, Store,Address, Quantity,Weight,RealWeight,Price,PriceService,Total, [Note], Package, SoMay) values ('" + txtSender.Text + "','" + txtAddressSender.Text + "',#" + dtpSend.Value.ToString("MM/dd/yyyy") + "#,'" + txtSoPhieu.Text + "','" + cbbName.Text + "','" + txtAddress.Text + "'," + txtQuantity.Text + "," + txtWeight.Text + "," + txtRealWeight.Text + "," + txtCuoc.Text + "," + txtNT.Text + "," + txtTotal.Text + ",'" + txanote.Text + "'," + txtkien.Text + "," + txtsomay.Text + ")";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query0 = "select m.Address, [z.Zone], m.NT, m.Remark from tb_maymanstore m inner join tb_zone z on m.ZoneDecs = z.ProvinceName where m.Name = '" + cbbName.Text + "'";
            DataSet dt0 = new DataSet();
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.CommandText = query0;
            cmd0.Connection = conn;
            OleDbDataAdapter da0 = new OleDbDataAdapter();
            da0.SelectCommand = cmd0;
            da0.Fill(dt0);
            txtAddress.Text = dt0.Tables[0].Rows[0].ItemArray[0].ToString();
            textBox3.Text = dt0.Tables[0].Rows[0].ItemArray[3].ToString();

            if (!dt0.Tables[0].Rows[0].ItemArray[2].ToString().Equals("Trong Tuyến"))
            {
                txtNT.Text = "3500";
            }
            else
            {
                txtNT.Text = "0";
            }

            textBox1.Text = dt0.Tables[0].Rows[0].ItemArray[1].ToString();
        }

        private void FrmMayMan_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query0 = "select * from tb_maymanstore";
            DataSet dt0 = new DataSet();
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.CommandText = query0;
            cmd0.Connection = conn;
            OleDbDataAdapter da0 = new OleDbDataAdapter();
            da0.SelectCommand = cmd0;
            da0.Fill(dt0);
            cbbName.DataSource = dt0.Tables[0];
            cbbName.DisplayMember = "Name";

            cbbName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getData(combData);
            cbbName.AutoCompleteCustomSource = combData;

            dtpSend.Format = DateTimePickerFormat.Custom;
            dtpSend.CustomFormat = "dd/MM/yyyy";

            txtSoPhieu.Text = sgpservice.getmaxMailerID("SGP");

          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            txtRealWeight.Text = txtWeight.Text;
            try
            {
                if (int.Parse(txtWeight.Text) > 0 && int.Parse(txtWeight.Text) < 50)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select B50kg from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 50 && int.Parse(txtWeight.Text) < 100)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F50T100 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 100 && int.Parse(txtWeight.Text) < 250)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F100T250 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 250 && int.Parse(txtWeight.Text) < 500)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F250T500 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 500 && int.Parse(txtWeight.Text) < 1000)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F500T1000 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 1000 && int.Parse(txtWeight.Text) < 1500)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F1000T1500 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) >= 1500 && int.Parse(txtWeight.Text) < 2000)
                {
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F1500T2000 from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    txtCuoc.Text = dt1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else if (int.Parse(txtWeight.Text) == 0)
                {
                    txtCuoc.Text = "0";
                }
                else if (int.Parse(txtWeight.Text) >= 2000)
                {
                    int nac = (int.Parse(txtWeight.Text) - 2000) / 500;
                    OleDbConnection conn1 = new OleDbConnection();
                    string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn1.ConnectionString = con1;
                    conn1.Open();
                    string query1 = "select F1500T2000, A2000kg from tb_price where ToZone = '" + textBox1.Text + "'";
                    DataSet dt1 = new DataSet();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.CommandText = query1;
                    cmd1.Connection = conn1;
                    OleDbDataAdapter da1 = new OleDbDataAdapter();
                    da1.SelectCommand = cmd1;
                    da1.Fill(dt1);
                    textBox2.Text = (int.Parse(dt1.Tables[0].Rows[0].ItemArray[0].ToString()) + int.Parse(dt1.Tables[0].Rows[0].ItemArray[1].ToString())).ToString();
                    txtCuoc.Text =textBox2.Text;
                    for(int i =0 ; i<nac; i++){
                        txtCuoc.Text = (int.Parse(txtCuoc.Text)+ int.Parse(dt1.Tables[0].Rows[0].ItemArray[1].ToString())).ToString();
                            
                    }
                }

                txtTotal.Text = (int.Parse(txtCuoc.Text) + int.Parse(txtNT.Text)).ToString();
            }
            catch (Exception em)
            {
                MessageBox.Show("Chưa nhập trọng lượng");
            }
           
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query0 = "select * from tb_maymanstore";
            DataSet dt0 = new DataSet();
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.CommandText = query0;
            cmd0.Connection = conn;
            OleDbDataAdapter da0 = new OleDbDataAdapter();
            da0.SelectCommand = cmd0;
            da0.Fill(dt0); 
            foreach(DataRow row in dt0.Tables[0].Rows){
                dataCollection.Add(row.ItemArray[1].ToString());
            }
        }

        private void txtNT_TextChanged(object sender, EventArgs e)
        {
            //txtTotal.Text = (int.Parse(txtCuoc.Text) + int.Parse(txtNT.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShow_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("dd/MM/yy").Trim();

            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query0 = "select * from tb_mayman where SendDate like '"+now+"'";
            DataSet dt0 = new DataSet();
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.CommandText = query0;
            cmd0.Connection = conn;
            OleDbDataAdapter da0 = new OleDbDataAdapter();
            da0.SelectCommand = cmd0;
            da0.Fill(dt0);
            dataGridView1.DataSource = dt0.Tables[0];

            dataGridView1.Columns[0].Visible = false;
        }
    }
}
