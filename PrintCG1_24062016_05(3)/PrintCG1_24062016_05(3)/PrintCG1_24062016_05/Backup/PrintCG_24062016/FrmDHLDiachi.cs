using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PrintCG_24062016
{
    public partial class FrmDHLDiachi : Form
    {
        public FrmDHLDiachi()
        {
            InitializeComponent();
        }
        public static DataTable dt;
        private void FrmDHLDiachi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 300;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string zone = string.Empty;
            string zonedesc = string.Empty;
            string nodecode = string.Empty;
            string shipname = string.Empty;
            string shipaddress = string.Empty;
            string remark = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    string query = "insert into tb_diachi values ('" + row.Cells[0].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "','" + row.Cells[4].Value.ToString() + "','" + row.Cells[5].Value.ToString() + "') ";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
            conn.Close();
            MessageBox.Show("Đã cập nhật");
            this.Close();
        }
    }
}
