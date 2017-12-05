using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using PrintCG_24062016;
using Excel = Microsoft.Office.Interop.Excel;
namespace PrintCG_24062016.congcu
{
    public partial class Frm_SpecialCustomer : Form
    {
        FrmLogin login = new FrmLogin();
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        public Frm_SpecialCustomer()
        {
            InitializeComponent();
        }

        private void Frm_SpecialCustomer_Load(object sender, EventArgs e)
        {
            dgv1.ColumnCount = 14;
            dgv1.Columns[0].Name = "Nơi gửi";
            dgv1.Columns[1].Name = "Số CG";
            dgv1.Columns[2].Name = "Số chứng từ cần thu về";
            dgv1.Columns[3].Name = "Số chứng từ liên quan";
            dgv1.Columns[4].Name = "Ngày giao";
            dgv1.Columns[5].Name = "Tên Node";
            dgv1.Columns[6].Name = "Địa chỉ";
            dgv1.Columns[7].Name = "Tỉnh";
            dgv1.Columns[8].Name = "Khu vực";
            dgv1.Columns[9].Name = "Khách hàng";
            dgv1.Columns[10].Name = "Ngày";
            dgv1.Columns[11].Name = "Giờ";
            dgv1.Columns[12].Name = "Nhân viên";
            dgv1.Columns[13].Name = "Ghi Chú";

            dgv2.ColumnCount = 14;
            dgv2.Columns[0].Name = "Nơi gửi";
            dgv2.Columns[1].Name = "Số CG";
            dgv2.Columns[2].Name = "Số chứng từ cần thu về";
            dgv2.Columns[3].Name = "Số chứng từ liên quan";
            dgv2.Columns[4].Name = "Ngày giao";
            dgv2.Columns[5].Name = "Tên Node";
            dgv2.Columns[6].Name = "Địa chỉ";
            dgv2.Columns[7].Name = "Tỉnh";
            dgv2.Columns[8].Name = "Khu vực";
            dgv2.Columns[9].Name = "Khách hàng";
            dgv2.Columns[10].Name = "Ngày";
            dgv2.Columns[11].Name = "Giờ";
            dgv2.Columns[12].Name = "Nhân viên";
            dgv2.Columns[13].Name = "Ghi Chú";

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd-MM-yyyy hh:mm";
            txtMBC.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            txtNhanvien.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtuser", string.Empty);

            txtID.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            DataTable dt = new DataTable();
            dgv4.DataSource = sv.getCustomerID();
            int count = dgv4.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

                cbbCus.DisplayMember = "Value";
                //cbbCus.ValueMember = 
            }

        }
        OpenFileDialog open;
        string path;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.ShowDialog();
            path = open.FileName;
            label2.Text = open.FileName;
            string[] listsheet = GetExcelSheetNames(path);
            cbbsheet.DataSource = listsheet;
        }

        private void cbbsheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = new OleDbConnection();
            string conStr = "";
            DataTable dt = new DataTable();
            string Import_FileName = path;
            string fileExtension = Path.GetExtension(Import_FileName);
            if (fileExtension == ".xls")
                conStr = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";Extended Properties='Excel 8.0;HRD=NO';";
            if (fileExtension == ".xlsx")
                conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";Extended Properties='Excel 12.0;HDR=NO';";
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

        private DataTable ReadExcelFile(string sheetName, string path)
        {
            dgv1.Rows.Clear();
            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";Extended Properties='Excel 8.0;HRD=NO';";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";Extended Properties='Excel 12.0;HDR=NO';";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheetName + "]";
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

        private void btnSee_Click(object sender, EventArgs e)
        {
            DataTable dt = ReadExcelFile(cbbsheet.SelectedValue.ToString(), path);
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string[] row = new string[] { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString() };
                dgv1.Rows.Add(row);
            }
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ngay = "";
            string gio = "";
            string nhanvien = "";
            string ghichu = "";

            ngay = dtpDate.Value.ToString("dd-MM-yyyy");
            gio = dtpDate.Value.ToString("hh:mm");
            nhanvien = txtNhanvien.Text;
            ghichu = txtNote.Text;
            int count = dgv2.Rows.Count;
            dgv2.Rows.Clear();
            for (int i = 0; i < count - 1; i++)
            {
                string[] row = new string[] { dgv3.Rows[i].Cells[4].Value.ToString(), dgv3.Rows[i].Cells[0].Value.ToString(), dgv3.Rows[i].Cells[12].Value.ToString(), dgv3.Rows[i].Cells[11].Value.ToString(), dgv3.Rows[i].Cells[3].Value.ToString(), dgv3.Rows[i].Cells[7].Value.ToString(), dgv3.Rows[i].Cells[10].Value.ToString(), dgv3.Rows[i].Cells[9].Value.ToString(), dgv3.Rows[i].Cells[1].Value.ToString(), dgv3.Rows[i].Cells[14].Value.ToString(), ngay, gio, nhanvien, ghichu };
                dgv2.Rows.Add(row);
            }
            for (int i = 0; i < count - 1; i++)
            {
                sv.changeCustomer(int.Parse(id[i]), dgv2.Rows[i].Cells[0].Value.ToString(), dgv2.Rows[i].Cells[1].Value.ToString(), dgv2.Rows[i].Cells[2].Value.ToString(), dgv2.Rows[i].Cells[3].Value.ToString(), dgv2.Rows[i].Cells[4].Value.ToString(), dgv2.Rows[i].Cells[5].Value.ToString(), dgv2.Rows[i].Cells[6].Value.ToString(), dgv2.Rows[i].Cells[7].Value.ToString(), dgv2.Rows[i].Cells[8].Value.ToString(), dgv2.Rows[i].Cells[9].Value.ToString(), dgv2.Rows[i].Cells[10].Value.ToString(), dgv2.Rows[i].Cells[11].Value.ToString(), dgv2.Rows[i].Cells[12].Value.ToString(), dgv2.Rows[i].Cells[13].Value.ToString());
            }
            MessageBox.Show("Lưu thành công");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ngay = "";
            string gio = "";
            string nhanvien = "";
            string ghichu = "";

            int count = dgv1.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                //ngay = dgv1.Rows[i].Cells[8].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[8].Value.ToString();
                //gio = dgv1.Rows[i].Cells[9].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[9].Value.ToString();
                //nhanvien = dgv1.Rows[i].Cells[10].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[10].Value.ToString();
                //ghichu = dgv1.Rows[i].Cells[11].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[11].Value.ToString();
                sv.addCustomer(dgv1.Rows[i].Cells[0].Value.ToString(), dgv1.Rows[i].Cells[1].Value.ToString(), dgv1.Rows[i].Cells[2].Value.ToString(), dgv1.Rows[i].Cells[3].Value.ToString(), dgv1.Rows[i].Cells[4].Value.ToString(), dgv1.Rows[i].Cells[5].Value.ToString(), dgv1.Rows[i].Cells[6].Value.ToString(), dgv1.Rows[i].Cells[7].Value.ToString(), txtMBC.Text, cbbCus.Text, ngay, gio, nhanvien, ghichu);
            }
            MessageBox.Show("Lưu thành công");
        }
        string[] id;

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgv3.DataSource = sv.getSpCustomer();
            int count = dgv3.Rows.Count;
            dgv2.Rows.Clear();
            id = new string[count];
            for (int i = 0; i < count; i++)
            {
                id[i] = dgv3.Rows[i].Cells[6].Value.ToString();
                string[] row = new string[] { dgv3.Rows[i].Cells[4].Value.ToString(), dgv3.Rows[i].Cells[0].Value.ToString(), dgv3.Rows[i].Cells[12].Value.ToString(), dgv3.Rows[i].Cells[11].Value.ToString(), dgv3.Rows[i].Cells[3].Value.ToString(), dgv3.Rows[i].Cells[7].Value.ToString(), dgv3.Rows[i].Cells[10].Value.ToString(), dgv3.Rows[i].Cells[9].Value.ToString(), dgv3.Rows[i].Cells[1].Value.ToString(), dgv3.Rows[i].Cells[14].Value.ToString(), dgv3.Rows[i].Cells[2].Value.ToString(), dgv3.Rows[i].Cells[5].Value.ToString(), dgv3.Rows[i].Cells[13].Value.ToString(), dgv3.Rows[i].Cells[8].Value.ToString() };
                dgv2.Rows.Add(row);
            }
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sv.addCustomerID(txtID.Text, txtCustomerID.Text, txtName.Text);
            MessageBox.Show("Lưu thành công");
        }

        private void xtraTabPage1_Click(object sender, EventArgs e)
        {
            cbbCus.Items.Clear();
            dgv4.DataSource = sv.getCustomerID();
            int count = dgv4.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

                cbbCus.DisplayMember = "Value";
                //cbbCus.ValueMember = 
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            cbbCus.Items.Clear();
            dgv4.DataSource = sv.getCustomerID();
            int count = dgv4.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

                cbbCus.DisplayMember = "Value";
                //cbbCus.ValueMember = 
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
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

                // truyen data
                for (int k = 0; k < dgv2.Rows.Count; k++)
                {
                    wbook.Worksheets.Add();
                    //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

                    //dat ten sheet
                    for (int i = 1; i < dgv2.Columns.Count + 1; i++)
                    {
                        obj.Cells[1, i] = dgv2.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgv2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv2.Columns.Count; j++)
                        {
                            if (dgv2.Rows[i].Cells[j].Value != null)
                            {
                                obj.Cells[i + 2, j + 1] = dgv2.Rows[i].Cells[j].Value.ToString();
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
