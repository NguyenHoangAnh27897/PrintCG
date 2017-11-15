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
    public partial class Frm_DMKH : Form
    {
        public Frm_DMKH()
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
                    OleDbConnection conn = new OleDbConnection();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    conn.Open();
                    string query = "insert into tb_fujixeroxdmkh (ID,Name,Email,Phone) values ('" + txtID.Text + "','" + txtName.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clear();
                }
                catch
                {
                    OleDbConnection conn = new OleDbConnection();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    conn.Open();
                    string query = "update tb_fujixeroxdmkh set Name = '"+ txtName.Text +"', Email ='"+ txtEmail.Text +"',Phone ='"+ txtPhone.Text +"' where ID ='"+ txtID.Text.Trim() +"'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clear();
                }
                load_danhmuc();
                
            }
            catch
            {

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_DMDC frm = new Frm_DMDC();
            frm.Show();
        }

        private void Frm_DMKH_Load(object sender, EventArgs e)
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
                cmd.CommandText = "select * from tb_fujixeroxdmkh";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }catch
            {
                MessageBox.Show("Không có dữ liệu");
            }
           
        }
        private void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
    }
}
