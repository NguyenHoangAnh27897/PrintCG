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
    public partial class Frm_DMDC : Form
    {
        public Frm_DMDC()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                //neu id đã tồn tại thì update , nếu chưa có thì thêm mới.
                try
                {
                    if (txtID.Text.Trim() =="")
                    {
                        OleDbConnection conn = new OleDbConnection();
                        string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                        conn.ConnectionString = con;
                        conn.Open();
                        string query = "insert into tb_fujixeroxdmdc (ID_Customer,Address,Phone,Contact_Person) values ('" + cbbCustomer.SelectedValue + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + txtContact.Text + "')";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        clear();
                    }else
                    {
                        OleDbConnection conn = new OleDbConnection();
                        string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                        conn.ConnectionString = con;
                        conn.Open();
                        string query = "update tb_fujixeroxdmdc set Address = '" + txtAddress.Text + "', Phone ='" + txtPhone.Text + "',Contact_Person ='" + txtContact.Text + "' where ID =" + txtID.Text.Trim() + "";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        clear();
                    }
                   
                }
                catch
                {                    
                                    
                }
                load_danhmuc();

            }
            catch
            {

            }
        }
        private void clear()
        {
            txtID.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtPhone.Text = "";
            cbbCustomer.Text = "";
        }
        private void Frm_DMDC_Load(object sender, EventArgs e)
        {
            load_danhmuc();
        }
        private void load_danhmuc()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select kh.ID,kh.Name,dc.ID,dc.Address,dc.Phone,dc.Contact_Person  from tb_fujixeroxdmkh kh inner join tb_fujixeroxdmdc dc on kh.ID = dc.ID_Customer ";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }           
        }


        private void cbbCustomer_Enter(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.CommandText = "select ID from tb_fujixeroxdmkh";
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cbbCustomer.DataSource = dt;
            cbbCustomer.DisplayMember = "ID";
            cbbCustomer.ValueMember = "ID";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void cbbCustomer_Enter_1(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select ID,Name from tb_fujixeroxdmkh";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                cbbCustomer.DataSource = dt;
                cbbCustomer.DisplayMember = "Name";
                cbbCustomer.ValueMember = "ID";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }   
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtContact.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }
    }
}
