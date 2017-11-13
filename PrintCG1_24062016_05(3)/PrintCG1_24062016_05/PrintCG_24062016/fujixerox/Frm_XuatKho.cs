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
using Excel = Microsoft.Office.Interop.Excel;

namespace PrintCG_24062016
{
    public partial class Frm_XuatKho : Form
    {
        public Frm_XuatKho()
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
                //cần kiềm tra số lượng còn tồn trong kho trước khi xuất.
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select [Quantity] from tb_fujixeroxdmsp where ID = '" + txtID.Text.Trim() + "'";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (int.Parse(dt.Rows[0][0].ToString()) >= int.Parse(txtQuan.Text))
                {
                //Update lai RealQuantity của ngày nhap kho cũ nhat cua san pham can xuat , nêu RealQuantity < OutputQuantity sẽ - RealQuantity ngày kế tiếp
                //1 lay ra ngay cũ nhat RealQuantity > 0 theo mã sản phẩm từ bảng xuất nhập.
                    string checkrealquantity = "SELECT CreateDate,Quantity,RealQuantity FROM tb_fujixeroxnx where RealQuantity > 0 and IDSP = '" + txtID.Text.ToUpper().Trim() + "' order by CreateDate asc";
                    DataTable dtcheckavailable = new DataTable();
                    OleDbCommand cmdcheckavailable = new OleDbCommand();
                    cmdcheckavailable.Connection = conn;
                    cmdcheckavailable.CommandText = checkrealquantity;
                    OleDbDataAdapter dacheckavailable = new OleDbDataAdapter();
                    dacheckavailable.SelectCommand = cmdcheckavailable;
                    dacheckavailable.Fill(dtcheckavailable);

                    int rowcount = dtcheckavailable.Rows.Count;
                    int currentquantity = 0;
                    int outpuquantity = int.Parse(txtQuan.Text);
                    int realquantity = 0;
                    string strupdaterealquantity = string.Empty;
                    DateTime createdate;
                    for (int i = 0; i <= rowcount; i++)
                    { 
                        realquantity = int.Parse(dtcheckavailable.Rows[i][2].ToString());
                        createdate = DateTime.Parse(dtcheckavailable.Rows[i][0].ToString());
                        if (realquantity > 0)
                        {
                            //do so luong xuat = hoặc ít hơn dòng đầu tiên nên update lại realquantity và thoát khỏi vòng lặp
                            if (realquantity >= outpuquantity)
                            {
                                strupdaterealquantity = "update tb_fujixeroxnx set RealQuantity = RealQuantity - " + outpuquantity + " where IDSP ='" + txtID.Text.ToUpper().Trim() + "' and  CreateDate = #" + createdate.ToString("MM-dd-yyyy") + "#";
                                OleDbCommand cmdupdaterealquantity = new OleDbCommand(strupdaterealquantity, conn);
                                cmdupdaterealquantity.ExecuteNonQuery();
                                break;
                            }else
                            {
                                strupdaterealquantity = "update tb_fujixeroxnx set RealQuantity = RealQuantity - " + realquantity + " where IDSP ='" + txtID.Text.ToUpper().Trim() + "' and  CreateDate = #" + createdate.ToString("MM-dd-yyyy") + "#";
                                OleDbCommand cmdupdaterealquantity = new OleDbCommand(strupdaterealquantity, conn);
                                cmdupdaterealquantity.ExecuteNonQuery();
                                outpuquantity = outpuquantity - realquantity;
                            }
                           
                           
                        }
                    }
                    //tru di so luong da xuat vao thuc te so luong

                //sau khi ghi nhật ký nhập kho cần update lại số lượng của sản phẩm có trong kho.
                            
                    string query1 = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] - " + int.Parse(txtQuan.Text) + " where [ID] = '" + txtID.Text.Trim() + "'";
                    OleDbCommand cmd1 = new OleDbCommand(query1, conn);
                    cmd1.ExecuteNonQuery();

                    //ghi lại nhật ký những lần xuat kho
                    string querynk = "insert into tb_fujixeroxlog (IDSP,CreateDate,Type,[Quantity],CustomerID,AddressID,CG,Employee) values ('" + txtID.Text.Trim() + "',#" + DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss") + "#,'X'," + int.Parse(txtQuan.Text) + ",'"+ comboBox1.SelectedValue +"',"+ cbbAdd.SelectedValue +",'"+ txtcg.Text.Trim() +"','SGP')";
                    //string query = "update tb_fujixeroxdmsp set [Quantity] = [Quantity] + " + int.Parse(txtQuan.Text) + ", [Type] = 'Nhập', [Date] = #" + DateTime.Now.ToString("MM-dd-yyyy") + "# where [ID] = '" + txtID.Text + "'";
                    OleDbCommand cmdnk = new OleDbCommand(querynk, conn);
                    cmdnk.ExecuteNonQuery();
                    conn.Close();

                    //sau khi thành công sẽ in phiếu gửi
                    //Rpt_Fijuxerox rpt = new Rpt_Fijuxerox();
                    //TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
                    //_txtbcnhan.Text = "DHL";
                }else
                {
                    MessageBox.Show("Số lượng tồn nhỏ hơn số lượng xuất : " + dt.Rows[0][0].ToString() + "/" + txtQuan.Text);
                }
              
                load_danhmuc();
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật - frm_xuatkho-43");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ComboBox cmb = (ComboBox)sender;
                int selectedIndex = cmb.SelectedIndex;
                int selectedValue = (int)cmb.SelectedValue;

                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select ID,Address,Phone,Contact_Person from tb_fujixeroxdmdc where ID = " + selectedValue + "";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
                txtperson.Text = dt.Rows[0][3].ToString();
                txtphone.Text = dt.Rows[0][2].ToString();
            }
            catch
            {
               // MessageBox.Show("Lỗi kết nối");
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
        private void Frm_XuatKho_Load(object sender, EventArgs e)
        {
            load_danhmuc();
            //OleDbConnection conn = new OleDbConnection();
            //DataTable dt = new DataTable();
            //string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            //conn.ConnectionString = con;
            //OleDbCommand cmd = new OleDbCommand();
            //conn.Open();
            //cmd.CommandText = "select ID,Address from tb_fujixeroxdmdc";
            //cmd.Connection = conn;
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //cbbAdd.DataSource = dt;
            //cbbAdd.DisplayMember = "Address";
            //cbbAdd.ValueMember = "ID";
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            int checksp = 0;
            if (e.KeyCode == Keys.Oem2) // kiem tra đã tồn tại sản phẩm trước khi nhập số lượng
            {
                MessageBox.Show("fff");
                checksp = checksanpham().Rows.Count;
                if (checksp == 0)
                {
                    lbltensanpham.Text = "Không tìm thấy sản phẩm";
                    txtID.SelectAll();
                    txtID.Focus();
                }
                else
                {
                    lbltensanpham.Text = checksanpham().Rows[0][1].ToString();
                    txtQuan.Focus();
                }
            }
        }
        private DataTable checksanpham()
        {
            DataTable dt = new DataTable();

            try
            {
                OleDbConnection conn = new OleDbConnection();             
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select ID,Name from tb_fujixeroxdmsp where ID ='" + txtID.Text.Trim() + "'";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
                return dt;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
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
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }   
        }

        private void cbbAdd_Enter(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                DataTable dt = new DataTable();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand cmd = new OleDbCommand();
                conn.Open();
                cmd.CommandText = "select ID,Address from tb_fujixeroxdmdc where ID_Customer = '"+ comboBox1.SelectedValue.ToString() +"'";
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
                cbbAdd.DataSource = dt;
                cbbAdd.DisplayMember = "Address";
                cbbAdd.ValueMember = "ID";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }   
        }
        private void txtQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // kiem tra đã tồn tại sản phẩm trước khi nhập số lượng
            {
                comboBox1.Focus();
            }

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            int checksp = checksanpham().Rows.Count;
            if (checksp == 0)
            {
                lbltensanpham.Text = "Không tìm thấy sản phẩm";
                txtID.SelectAll();
                txtID.Focus();
            }
            else
            {
                lbltensanpham.Text = checksanpham().Rows[0][1].ToString();
                txtQuan.Focus();
            }
        }

        private void txtQuan_Leave(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            cbbAdd.Focus();
        }

        private void cbbAdd_Leave(object sender, EventArgs e)
        {
            txtperson.Focus();
        }

        private void txtperson_Leave(object sender, EventArgs e)
        {
            txtphone.Focus();
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            txtcg.Focus();
        }

        private void txtcg_Leave(object sender, EventArgs e)
        {
            btnSave.Focus();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();

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

            Excel.Application obj = new Excel.Application();
            Excel.Workbook wbook;

            fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                wbook = obj.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;

                // truyen data
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    wbook.Worksheets.Add();

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
            else
            {
                MessageBox.Show("Please Type Path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
