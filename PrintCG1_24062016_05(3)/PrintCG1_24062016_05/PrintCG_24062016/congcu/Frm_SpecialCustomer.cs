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
using System.Reflection;
namespace PrintCG_24062016.congcu
{
    public partial class Frm_SpecialCustomer : Form
    {
        FrmLogin login = new FrmLogin();
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        PrintCG_24062016.ChuyenThu.Service1SoapClient db = new ChuyenThu.Service1SoapClient();
        public Frm_SpecialCustomer()
        {
            InitializeComponent();
        }

        private void Frm_SpecialCustomer_Load(object sender, EventArgs e)
        {
            dgv1.ColumnCount = 15;
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
            dgv1.Columns[10].Name = "Bưu cục";
            dgv1.Columns[11].Name = "Ngày";
            dgv1.Columns[12].Name = "Giờ";
            dgv1.Columns[13].Name = "Nhân viên";
            dgv1.Columns[14].Name = "Ghi Chú";

            dgv2.ColumnCount = 12;
            dgv2.Columns[0].Name = "ID";
            dgv2.Columns[1].Name = "BC phát";
            dgv2.Columns[2].Name = "Nhân viên phát";
            dgv2.Columns[3].Name = "Nơi gửi";
            dgv2.Columns[4].Name = "Số CG";
            dgv2.Columns[5].Name = "Số chứng từ cần thu về";
            dgv2.Columns[6].Name = "Tên Node";
            dgv2.Columns[7].Name = "Địa chỉ";
            dgv2.Columns[8].Name = "Tên người nhận";
            dgv2.Columns[9].Name = "Ngày";
            dgv2.Columns[10].Name = "Giờ";
            dgv2.Columns[11].Name = "Ghi Chú";
            dgv2.Columns[0].Visible = false;

            dtpD.Format = DateTimePickerFormat.Custom;
            dtpD.CustomFormat = "dd-MM-yyyy";
            dtpH.Format = DateTimePickerFormat.Custom;
            dtpH.CustomFormat = "HH:mm";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd-MM-yyyy";
            txtMBC.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            // txtNhanvien.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtuser", string.Empty);

            txtID.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            DataTable dt = new DataTable();
            //dgv4.DataSource = sv.getCustomerID();
            //int count = dgv4.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

            //    cbbCus.DisplayMember = "Value";
            //    //cbbCus.ValueMember = 
            //}
            cbbCus.DataSource = sv.getCustomerID();
            cbbCus.DisplayMember = "CustomerID";
            cbbCus.ValueMember = "CustomerID";

            var lstcus = sv.getCustomerIDTab4(txtID.Text).ToList();
            //var count1 = lstcus.Count;
            //for (int i = 0; i < count1; i++)
            //{
            //    cbbKH.Items.Add(new { Text = lstcus[i].CustomerID, Value = lstcus[i].CustomerID });
            //}
            cbbKH.DataSource = lstcus;
            cbbKH.DisplayMember = "CustomerID";
            cbbKH.ValueMember = "CustomerID";

             dtpfromtab4.Format = DateTimePickerFormat.Custom;
             dtpfromtab4.CustomFormat = "dd-MM-yyyy";
             dtptotab4.Format = DateTimePickerFormat.Custom;
             dtptotab4.CustomFormat = "dd-MM-yyyy";

             var lstgroup = sv.getCustomerGroupTab4().ToList();
             //var count2 = lstgroup.Count;
             //for (int i = 0; i < count2; i++)
             //{
             //    cbbGroupKH.Items.Add(new { Text = lstgroup[i].CustomerGroupName, Value = lstgroup[i].CustomerGroupID });
             //}
             cbbGroupKH.DataSource = lstgroup;
             cbbGroupKH.DisplayMember = "CustomerGroupName";
             cbbGroupKH.ValueMember = "CustomerGroupID";
             cbbKH.Enabled = false;
             txtPost.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
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
            for (int i = 1; i < count; i++)
            {
                string[] row = new string[] { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString() };
                dgv1.Rows.Add(row);
            }
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ngay = "";
                string ngaypms = "";
                string gio = "";
                string giopms = "";
                string ngaygio = "";

                ngay = dtpD.Value.ToString("dd-MM-yyyy");
                ngaypms = dtpD.Value.ToString("yyyy-MM-dd");

                gio = dtpH.Value.ToString("hh:mm");
                giopms = dtpH.Value.ToString("HH:mm:ss");
                ngaygio = ngaypms + " " + giopms;

                DateTime datetime = DateTime.ParseExact(ngaygio, "yyyy-MM-dd HH:mm:ss",
                                          System.Globalization.CultureInfo.InvariantCulture);
                //nhanvien = txtNhanvien.Text;
                // ghichu = txtNote.Text;

                if(txtCG.Text != "")
                {
                    sv.changeCustomer(int.Parse(textBox1.Text), ngay, gio, txtDeliveryTo.Text);
                    sv.updateMailerDeliveryDetail(txtCG.Text, datetime, txtDeliveryTo.Text, "6");
                    MessageBox.Show("Lưu thành công");
                    load();
                }
                
            }catch
            {
                MessageBox.Show("Không thể lưu thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string buucuc = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            string ngay = "";
            string gio = "";
            string nhanvien = "";
            string ghichu = "";
            string socg = string.Empty; //1
            string ngaygiao = string.Empty; //4
            int count = dgv1.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                //ngay = dgv1.Rows[i].Cells[8].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[8].Value.ToString();
                //gio = dgv1.Rows[i].Cells[9].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[9].Value.ToString();
                //nhanvien = dgv1.Rows[i].Cells[10].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[10].Value.ToString();
                //ghichu = dgv1.Rows[i].Cells[11].Value.ToString() == null ? "" : dgv1.Rows[i].Cells[11].Value.ToString();
                socg = dgv1.Rows[i].Cells[1].Value.ToString();
                ngaygiao = dgv1.Rows[i].Cells[4].Value.ToString();
                if(socg !="" && ngay !="")
                {
                    sv.addCustomer(dgv1.Rows[i].Cells[0].Value.ToString(), dgv1.Rows[i].Cells[1].Value.ToString(), dgv1.Rows[i].Cells[2].Value.ToString(), dgv1.Rows[i].Cells[3].Value.ToString(), dgv1.Rows[i].Cells[4].Value.ToString(), dgv1.Rows[i].Cells[5].Value.ToString(), dgv1.Rows[i].Cells[6].Value.ToString(), dgv1.Rows[i].Cells[7].Value.ToString(), txtMBC.Text, cbbCus.Text, ngay, gio, nhanvien, ghichu, buucuc);
                }else
                {
                    MessageBox.Show("Số CG hoặc Ngày Giao không được bỏ trống","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            MessageBox.Show("Lưu thành công");
        }
        private void load()
        {
            string buucuc = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            string tungay = dtpFrom.Value.ToString("dd/MM/yy 12:00:00 SA");
            string denngay = dtpTo.Value.ToString("dd/MM/yy 12:00:00 SA");
            int loai = 0;
            int? ID = 0;
            string bcphat = string.Empty;
            string nvphat = string.Empty;
            string noigui = string.Empty;
            string socg = string.Empty;
            string chungtu = string.Empty;
            string node = string.Empty;
            string diachi = string.Empty;
            string nguoinhan = string.Empty;
            string ngay = string.Empty;
            string gio = string.Empty;
            string ghichu = string.Empty;
            if(rdbnhanvien.Checked == true)
            {
                loai = 0;
               // dgv3.DataSource = sv.getSpCustomer(buucuc, cmbnhanvien.SelectedValue.ToString(), tungay,denngay,0);//02/06/18 12:00:00 SA 02/06/2018 12:00:00 SA
            }else if (rdbkhachhang.Checked == true)
            {
                loai = 1;
               
            }
            var list=  sv.getSpCustomer(buucuc, cmbkhachhang.SelectedValue.ToString(), tungay, denngay, loai);//02/06/18 12:00:00 SA 02/06/2018 12:00:00 SA                
            dgv2.Rows.Clear();
            foreach(var item in list)
            {
                ID = item.ID;
                bcphat = item.PostOfficeID;
                nvphat = item.EmployeeID;
                noigui = item.FromPlace;
                socg = item.CGNumber;
                chungtu = item.SoChungTuThuVe;
                node = item.NodeName;
                diachi = item.ShiptoAddress;
                nguoinhan = item.DeliveryTo;
                ngay = item.Date;
                gio = item.Hour;
                ghichu = item.Note;
                    string[] row = new string[] { ID.ToString(),bcphat,nvphat,noigui,socg,chungtu,node,diachi,nguoinhan,ngay,gio,ghichu };
                    dgv2.Rows.Add(row);
            }
            //int count = dgv3.Rows.Count;
            //dgv2.Rows.Clear();
            //string nhanviennhan;
            //for (int i = 0; i < count; i++)
            //{
            //    nhanviennhan = dgv3.Rows[i].Cells[2].Value == null ? "" : dgv3.Rows[i].Cells[2].Value.ToString();
            //    string[] row = new string[] { dgv3.Rows[i].Cells[6].Value.ToString(), dgv3.Rows[i].Cells[3].Value.ToString(), dgv3.Rows[i].Cells[4].Value.ToString(), dgv3.Rows[i].Cells[0].Value.ToString(), dgv3.Rows[i].Cells[10].Value.ToString(), dgv3.Rows[i].Cells[7].Value.ToString(), dgv3.Rows[i].Cells[9].Value.ToString(), nhanviennhan, dgv3.Rows[i].Cells[1].Value.ToString(), dgv3.Rows[i].Cells[5].Value.ToString(), dgv3.Rows[i].Cells[8].Value.ToString() };
            //    dgv2.Rows.Add(row);
            //}
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sv.addCustomerID(txtID.Text, txtCustomerID.Text, txtName.Text);
            MessageBox.Show("Lưu thành công");
        }

        private void xtraTabPage1_Click(object sender, EventArgs e)
        {
            cbbCus.Items.Clear();
            //dgv4.DataSource = sv.getCustomerID();
            //int count = dgv4.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

            //    cbbCus.DisplayMember = "Value";
            //    //cbbCus.ValueMember = 
            //}
            cbbCus.DataSource = sv.getCustomerID();
            cbbCus.DisplayMember = "CustomerID";
            cbbCus.ValueMember = "CustomerID";
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            cbbCus.Items.Clear();
            //dgv4.DataSource = sv.getCustomerID();
            //int count = dgv4.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    cbbCus.Items.Add(new { Text = dgv4.Rows[i].Cells[1].Value.ToString(), Value = dgv4.Rows[i].Cells[0].Value.ToString() });

            //    cbbCus.DisplayMember = "Value";
            //    //cbbCus.ValueMember = 
            //}
            cbbCus.DataSource = sv.getCustomerID();
            cbbCus.DisplayMember = "CustomerID";
            cbbCus.ValueMember = "CustomerID";
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                const string MyFileName = @"excel\BangmauKHDB.xlsx";
                //string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var filePath = Path.Combine(Application.StartupPath, MyFileName);
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);
                book.SaveAs(saveFileDialog.FileName); //Save
                book.Close();
            }
        }

        private void cmbnhanvien_Enter(object sender, EventArgs e)
        {
            string postid = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            cmbnhanvien.DataSource = db.GetEmployees(postid).Tables[0];
            cmbnhanvien.DisplayMember = "EmployeeName";
            cmbnhanvien.ValueMember = "EmployeeID";


        }

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv2.SelectedRows.Count == 1)
            {
                int row = dgv2.CurrentCell.RowIndex;
                //int tim = int.Parse(dgv2.SelectedRows[0].Cells[0].Value.ToString());
                //int count = dgv3.Rows.Count;
                DateTime myDate;
                DateTime myHour; 
                //for (int i = 0; i < count; i++)
                //{
                //    if (int.Parse(dgv2.Rows[i].Cells[0].Value.ToString())== tim)
                //    {
                try
                {

                    myDate = DateTime.ParseExact(dgv2.Rows[row].Cells[9].Value.ToString(), "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    myHour = DateTime.ParseExact(dgv2.Rows[row].Cells[10].Value.ToString(), "HH:mm",
                                  System.Globalization.CultureInfo.InvariantCulture);
                    
                }catch
                {
                    myDate = DateTime.Now;
                    myHour = DateTime.Now;
                }
                        
                        txtDeliveryTo.Text = dgv2.Rows[row].Cells[8].Value.ToString();
                        textBox1.Text = dgv2.Rows[row].Cells[0].Value.ToString();
                        dtpD.Value = myDate;
                        dtpH.Value = myHour;
                        txtCG.Text = dgv2.Rows[row].Cells[4].Value.ToString();
                //    }
                //}
            }
        }

        private void btnTTXem_Click(object sender, EventArgs e)
        {
           
            int dem;
            string tungay = dtpfromtab4.Value.ToString("yyyy-MM-dd");
            string denngay = dtptotab4.Value.ToString("yyyy-MM-dd");
            //tungay = "2018-06-01";
           // denngay = "2018-06-14";
            if (chkAll.Checked == true)
            {
               
                var lst = sv.getListSpCustomer(tungay,denngay,cbbGroupKH.SelectedValue.ToString(),"",2).ToList();
               dgvList.DataSource = lst;

            }
            else
            {
                if (chkFollow.Checked == true)
                {
                    var lst = sv.getListSpCustomer(tungay, denngay, cbbKH.Text, txtPost.Text, 0).ToList();
                    dgvList.DataSource = lst;
                }
                else
                {
                    var lst = sv.getListSpCustomer(tungay, denngay, cbbGroupKH.SelectedValue.ToString(), txtPost.Text, 1).ToList();
                    dgvList.DataSource = lst;
                }
            }
            
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                txtPost.Enabled = false;
                cbbKH.Enabled = false;
                chkFollow.Enabled = false;
                cbbGroupKH.Enabled = true;
            }
            else
            {
                txtPost.Enabled = true;
                chkFollow.Enabled = true;
            }
        }

        private void chkFollow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFollow.Checked== true)
            {
                cbbGroupKH.Enabled = false;
                cbbKH.Enabled = true;
            }
            else
            {
                cbbGroupKH.Enabled = true;
                cbbKH.Enabled = false;
            }
        }

        private void btnTTXuat_Click(object sender, EventArgs e)
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
                for (int k = 0; k < dgvList.Rows.Count; k++)
                {
                    wbook.Worksheets.Add();
                    //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

                    //dat ten sheet
                    for (int i = 1; i < dgvList.Columns.Count + 1; i++)
                    {
                        obj.Cells[1, i] = dgvList.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvList.Columns.Count; j++)
                        {
                            if (dgvList.Rows[i].Cells[j].Value != null)
                            {
                                obj.Cells[i + 2, j + 1] = dgvList
                                    .Rows[i].Cells[j].Value.ToString();
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

        private void cmbkhachhang_Enter(object sender, EventArgs e)
        {
            cmbkhachhang.DataSource = sv.getCustomerID().ToList();
            cmbkhachhang.DisplayMember = "CustomerName";
            cmbkhachhang.ValueMember = "CustomerID";
        }

    }
}
