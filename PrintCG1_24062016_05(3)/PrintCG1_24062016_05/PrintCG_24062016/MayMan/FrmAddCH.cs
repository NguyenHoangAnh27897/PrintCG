using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;

namespace PrintCG_24062016.MayMan
{
    public partial class FrmAddCH : Form
    {
        public FrmAddCH()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                string query = "insert into tb_maymanstore (Name, Address, PhoneNumber, ZoneDecs, Remark, NT) values ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + cbbZoneDec.Text + "','" + txtRemark.Text + "','" + cbbNT.Text+"')";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
        }

        private void FrmAddCH_Load(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("DebugSelectAllComboBoxProvinces.xml");
            XmlNodeList province = xmldoc.GetElementsByTagName("BS_Countries");
            for (int i = 0; i < province.Count; i++)
            {
                cbbZoneDec.Items.Add(province[i].ChildNodes.Item(0).InnerText)
                    ;
            }

            cbbNT.Items.Add(new { Text = "Trong Tuyến", Value = "0" });
            cbbNT.Items.Add(new { Text = "Ngoại Tuyến", Value = "1" });

            cbbNT.DisplayMember = "Text";
            cbbNT.ValueMember = "Value";

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
            dataGridView1.DataSource = dt0.Tables[0];

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tên cửa hàng";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "SĐT";
            dataGridView1.Columns[4].HeaderText = "Mã tỉnh";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query0 = "select * from tb_maymanstore where ID = " + int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DataSet dt0 = new DataSet();
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.CommandText = query0;
            cmd0.Connection = conn;
            OleDbDataAdapter da0 = new OleDbDataAdapter();
            da0.SelectCommand = cmd0;
            da0.Fill(dt0);

            txtName.Text = dt0.Tables[0].Rows[0].ItemArray[1].ToString();
            txtAddress.Text = dt0.Tables[0].Rows[0].ItemArray[2].ToString();
            txtPhone.Text = dt0.Tables[0].Rows[0].ItemArray[3].ToString();
            cbbZoneDec.Text = dt0.Tables[0].Rows[0].ItemArray[4].ToString();
            txtRemark.Text = dt0.Tables[0].Rows[0].ItemArray[5].ToString();
            cbbNT.Text = dt0.Tables[0].Rows[0].ItemArray[6].ToString();
        }
    }
}
