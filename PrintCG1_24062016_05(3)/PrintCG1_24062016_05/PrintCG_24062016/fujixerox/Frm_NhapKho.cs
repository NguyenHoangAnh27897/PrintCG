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
    public partial class Frm_NhapKho : Form
    {
        public Frm_NhapKho()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
                //kiem tra da nhap ma san pham nay da ton tai chua
                string query0 = "select count(IDSP) as Tong from tb_fujixeroxnx where IDSP = '"+ txtID.Text.Trim() +"' and  CreateDate = #" + DateTime.Now.ToString("MM-dd-yyyy") + "#";
                DataTable dt0 = new DataTable();
                OleDbCommand cmd0 = new OleDbCommand();
                cmd0.CommandText = query0;
                cmd0.Connection = conn;
                OleDbDataAdapter da0 = new OleDbDataAdapter();
                da0.SelectCommand = cmd0;
                da0.Fill(dt0);
               // int count = int.Parse(dt0.Rows[0][0].ToString());
                if (int.Parse(dt0.Rows[0][0].ToString()) == 0)
                {
                    string query = "insert into tb_fujixeroxnx (IDSP,CreateDate,[Quantity],RealQuantity) values ('" + txtID.Text.Trim() + "',#" + DateTime.Now.ToString("MM-dd-yyyy") + "#," + int.Parse(txtQuan.Text) + "," + int.Parse(txtQuan.Text) + ")";
                    //string query = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] + " + int.Parse(txtQuan.Text) + ", [Type] = 'Nhập', [Date] = #" + DateTime.Now.ToString("MM-dd-yyyy") + "# where [ID] = '" + txtID.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }else
                {
                    string query = "update tb_fujixeroxnx set RealQuantity = RealQuantity + " + int.Parse(txtQuan.Text) + ",[Quantity] = [Quantity] + "+ int.Parse(txtQuan.Text) +" where IDSP ='"+ txtID.Text +"' and CreateDate = #" + DateTime.Now.ToString("MM-dd-yyyy") + "#";
                    //string query = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] + " + int.Parse(txtQuan.Text) + ", [Type] = 'Nhập', [Date] = #" + DateTime.Now.ToString("MM-dd-yyyy") + "# where [ID] = '" + txtID.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
               
                
                //sau khi ghi nhật ký nhập kho cần update lại số lượng của sản phẩm có trong kho.
                string query1 = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] + " + int.Parse(txtQuan.Text) + " where [ID] = '" + txtID.Text.Trim() + "'";
                OleDbCommand cmd1 = new OleDbCommand(query1, conn);
                cmd1.ExecuteNonQuery();

                //ghi lại nhật ký những lần nhập kho
                string query2 = "insert into tb_fujixeroxlog (IDSP,CreateDate,Type,[Quantity]) values ('" + txtID.Text.Trim() + "',#" + DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss") + "#,'N'," + int.Parse(txtQuan.Text) + ")";
                //string query = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] + " + int.Parse(txtQuan.Text) + ", [Type] = 'Nhập', [Date] = #" + DateTime.Now.ToString("MM-dd-yyyy") + "# where [ID] = '" + txtID.Text + "'";
                OleDbCommand cmd2 = new OleDbCommand(query2, conn);
                cmd2.ExecuteNonQuery();

                conn.Close();
                load_danhmuc();
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật - frm_nhapkho-38");
            }
            

        }

        private void insert()
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            bool checksp = false;
            if (e.KeyCode == Keys.Enter) // kiem tra đã tồn tại sản phẩm trước khi nhập số lượng
            {
                checksp = checksanpham();
                if(checksp == false)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }
                else
                {
                    txtQuan.Focus();
                }
            }
            

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
                cmd.CommandText = "select * from tb_fujixeroxdmsp";
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
        private bool checksanpham()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select ID from tb_fujixeroxdmsp where ID ='" + txtID.Text.Trim() +"'";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    return true;
                }else
                {
                    return false;
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
                return false;
            }
        }

        private void Frm_NhapKho_Load(object sender, EventArgs e)
        {
            load_danhmuc();
        }
    }
}
