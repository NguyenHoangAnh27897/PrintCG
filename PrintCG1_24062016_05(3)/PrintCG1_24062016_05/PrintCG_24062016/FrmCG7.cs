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
using PrintCG_24062016.dataset;

namespace PrintCG_24062016
{
    public partial class FrmCG7 : Form
    {
        public FrmCG7()
        {
            InitializeComponent();
        }
        //khai bao cac bien ban dau
        string path;
        int flag = 0;
        string[] liststt;
        string[] listnguoinhan;
        string[] listsonha;
        string[] listdiachi;
        string[] listphuong;
        string[] listquan;
        string[] listthanhpho;
        string[] listorder;
        string[] listlienhe;
        string[] listghichu;

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            lblexcel.Text = path;
            cmbsheet.Text = "";
            string[] sheetnames = GetExcelSheetNames(path);
            cmbsheet.DataSource = sheetnames;
      
            liststt = GetExcelSheetColumns(cmbsheet.Text);
            listnguoinhan = GetExcelSheetColumns(cmbsheet.Text);
            listsonha = GetExcelSheetColumns(cmbsheet.Text);
            listdiachi = GetExcelSheetColumns(cmbsheet.Text);
            listphuong = GetExcelSheetColumns(cmbsheet.Text);
            listquan = GetExcelSheetColumns(cmbsheet.Text);
            listthanhpho = GetExcelSheetColumns(cmbsheet.Text);
            listghichu = GetExcelSheetColumns(cmbsheet.Text);
            listlienhe = GetExcelSheetColumns(cmbsheet.Text);
            listorder = GetExcelSheetColumns(cmbsheet.Text);
           
        }
        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string Import_FileName = path;
            string fileExtension = Path.GetExtension(Import_FileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
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
        public string[] GetExcelSheetColumns(string excelFileName)
        {


            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + cmbsheet.Text + "]";
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        String[] excelSheetNames = new String[dt.Columns.Count];
                        //string a = " row " + dt.Rows.Count.ToString() + " Col " + dt.Columns.Count.ToString();

                        int i = 0;
                        try
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                //this.Invoke(new MethodInvoker(delegate()
                                {
                                    if (column.ColumnName.ToString().Substring(0, 1) != "F")
                                    {
                                        excelSheetNames[i] = column.ColumnName.ToString();
                                        i++;
                                    }
                                    else
                                    {
                                        return excelSheetNames;
                                    }


                                };
                            }

                            
                        }
                        catch (Exception ex)
                        {
                        }
                        return excelSheetNames;
                    }

                }
            }

        }
        private void FrmCG7_Load(object sender, EventArgs e)
        {
            load_settings();
        }

        private void cmbsheet_Enter(object sender, EventArgs e)
        {
            try
            {
               

               // MessageBox.Show(cmbsheet.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbstt_Enter(object sender, EventArgs e)
        {
            try
            {
               // liststt = GetExcelSheetColumns(cmbsheet.Text);
                cmbstt.DataSource = liststt;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbnguoinhan_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbnguoinhan.DataSource = listnguoinhan;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbdiachi_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbdiachi.DataSource = listdiachi;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbquan_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbquan.DataSource = listquan;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbthanhpho_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbthanhpho.DataSource = listthanhpho;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbghichu_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbghichu.DataSource = listghichu;
            }
            catch (Exception ex)
            {

            }
        }

        private void cmblienhe_Enter(object sender, EventArgs e)
        {
            try
            {
                cmblienhe.DataSource = listlienhe;
            }
            catch (Exception ex)
            {

            }
        }

        private void btninkim_Click(object sender, EventArgs e)
        {
            FrmCG7Print.flag = 1;
            FrmCG7Print.start = int.Parse(txtintustt.Text.ToString());
            FrmCG7Print.order = cmbsapxeptheo.Text;
            load_info();
            FrmCG7Print frmcg7print = new FrmCG7Print();
            frmcg7print.ShowDialog();
        }
        private void load_info()
        {
            FrmCG7Print.path = path;
            FrmCG7Print.sheet = cmbsheet.Text;
            FrmCG7Print.stt = cmbstt.Text;
            FrmCG7Print.nguoinhan = cmbnguoinhan.Text;
            FrmCG7Print.sonha = cmbsonha.Text;
            FrmCG7Print.diachi = cmbdiachi.Text;
            FrmCG7Print.phuong = cmbphuong.Text;
            FrmCG7Print.quan = cmbquan.Text;
            FrmCG7Print.thanhpho = cmbthanhpho.Text;
            FrmCG7Print.ghichu = cmbghichu.Text;
            FrmCG7Print.lienhe = cmblienhe.Text;
            FrmCG7Print.bcnhan = txtbcnhan.Text;
            FrmCG7Print.trongluong = txttl.Text;
            FrmCG7Print.dichvu = txtdv.Text;
            FrmCG7Print.nguoigui = txtnguoigui.Text;
            FrmCG7Print.ngaygui = txtngaygui.Text;
            FrmCG7Print.cg = txtcg1.Text;
        }

        private void btnlaser_Click(object sender, EventArgs e)
        {
            FrmCG7Print.flag = 2;
            FrmCG7Print.start = int.Parse(txtintustt.Text.ToString());
            FrmCG7Print.order = cmbsapxeptheo.Text;
            load_info();
            FrmCG7Print frmcg7print = new FrmCG7Print();
            frmcg7print.ShowDialog();
        }

        private void btnlabel_Click(object sender, EventArgs e)
        {
            FrmCG7Print.flag = 3;
            FrmCG7Print.start = int.Parse(txtintustt.Text.ToString());
            FrmCG7Print.order = cmbsapxeptheo.Text;
            load_info();
            FrmCG7Print frmcg7print = new FrmCG7Print();
            frmcg7print.ShowDialog();
        }

        private void cmbsapxeptheo_Enter(object sender, EventArgs e)
        {
            try
            {
                cmbsapxeptheo.DataSource = listorder;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DsExcel dsexcel = new DsExcel();
            dt = ReadExcelFile1(cmbsheet.Text, path);

            //khai bao cac thong tin can thiet
            string _ngaynhan;
            string _gio = "";
            string _sophieu;
            string _loaihang = "HH";
            string _dichvu = txtdv.Text;
            string _soluong = "1";
            string _trongluong = txttl.Text;
            string _trongluongkhoi = txttl.Text;
            string _tenduong;
            string _tinhthanh;
            string _quanhuyen;
            string _ghichu = "";

            foreach (DataRow row in dt.Rows)
            {

                 _ngaynhan = txtngaygui.Text;
                 _sophieu = txtcg1.Text + "-" + row[cmbstt.Text].ToString();
                 _tenduong = row[cmbsonha.Text].ToString() + ", " + row[cmbdiachi.Text].ToString() + ", " + row[cmbphuong.Text].ToString();
                 _quanhuyen = row[cmbquan.Text].ToString();
                 _ghichu = row[cmbghichu.Text].ToString();
                    switch (_quanhuyen)
                    {
                        case "Q. 1":
                            _quanhuyen = "001HCM";
                            break;
                        case "Q. 2":
                            _quanhuyen = "002HCM";
                            break;
                        case "Q. 3":
                            _quanhuyen = "003HCM";
                            break;
                        case "Q. 4":
                            _quanhuyen = "004HCM";
                            break;
                        case "Q. 5":
                            _quanhuyen = "005HCM";
                            break;
                        case "Q. 6":
                            _quanhuyen = "006HCM";
                            break;
                        case "Q. 7":
                            _quanhuyen = "007HCM";
                            break;
                        case "Q. 8":
                            _quanhuyen = "008HCM";
                            break;
                        case "Q. 9":
                            _quanhuyen = "009HCM";
                            break;
                        case "Q. 10":
                            _quanhuyen = "010HCM";
                            break;
                        case "Q. 11":
                            _quanhuyen = "011HCM";
                            break;
                        case "Q. 12":
                            _quanhuyen = "012HCM";
                            break;
                        case "Q. Bình Tân":
                            _quanhuyen = "BTNHCM";
                            break;
                        case "Q. Tân Bình":
                            _quanhuyen = "TBHHCM";
                            break;
                        case "Q. Tân Phú":
                            _quanhuyen = "TPUHCM";
                            break;
                        case "Q. Bình Thạnh":
                            _quanhuyen = "BTHHCM";
                            break;
                        case "Q. Gò Vấp":
                            _quanhuyen = "GVPHCM";
                            break;
                        case "Q. Phú Nhuận":
                            _quanhuyen = "PNNHCM";
                            break;
                        case "Q. Thủ Đức":
                            _quanhuyen = "TDCHCM";
                            break;
                        case "H. Gia Lâm":
                            _quanhuyen = "GLMHNI";
                            break;
                        case "H. Sơn Tây":
                            _quanhuyen = "STYHNI";
                            break;
                        case "H. Thanh Oai":
                            _quanhuyen = "TOIHNI";
                            break;
                        case "H. Thanh Trì":
                            _quanhuyen = "TTIHNI";
                            break;
                    }
                try
                {
                    _tinhthanh = row[cmbthanhpho.Text].ToString();
                    switch (_tinhthanh)
                    {
                        case "Hà Nội":
                            _tinhthanh = "HNI";
                            break;
                        case "Hồ Chí Minh":
                            _tinhthanh = "HCM";
                            break;

                    }
                }
                catch (Exception ex)
                {
                    _tinhthanh = "";
                }

                //dsexcel.Excel.AddExcelRow(_stt, _nguoinhan, _diachi,txtbcnhan.Text,txtcg1.Text,txttl.Text,txtdv.Text,txtnguoigui.Text,_lienhe,txtngay.Text);
                dsexcel.Excel.AddExcelRow((DateTime.Parse( _ngaynhan)).ToString("dd/MM/yyyy"), _gio, _sophieu, _loaihang, _dichvu, _soluong, _trongluong, _trongluongkhoi, _tenduong,_tinhthanh, _quanhuyen,_ghichu,"","","","","","","","");

            }

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            // Start Excel and get Application object.
            excel = new Microsoft.Office.Interop.Excel.Application();

            // for making Excel visible
            excel.Visible = true;
            //excel.Visible = true;
            excel.DisplayAlerts = false;

            // Creation a new Workbook
            excelworkBook = excel.Workbooks.Add(Type.Missing);

            // Workk sheet
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "CG7";

            int i = 0;
            int j = 0;
            string data = null;
            excelSheet.Cells[1, 1] = "Ngày nhận";
            excelSheet.Cells[1, 2] = "Giờ";
            excelSheet.Cells[1, 3] = "Số phiếu";
            excelSheet.Cells[1, 4] = "LH";
            excelSheet.Cells[1, 5] = "DV";
            excelSheet.Cells[1, 6] = "SL";
            excelSheet.Cells[1, 7] = "TL";
            excelSheet.Cells[1, 8] = "TL Khối";
            excelSheet.Cells[1, 9] = "Tên đường(Nhận)";
            excelSheet.Cells[1, 10] = "T/Thành(NĐ)";
            excelSheet.Cells[1, 11] = "Q/Huyện(Nhận)";
            excelSheet.Cells[1, 12] = "Ghi chú";

            for (i = 0; i <= dsexcel.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= dsexcel.Tables[0].Columns.Count - 1; j++)
                {
                    data = dsexcel.Tables[0].Rows[i].ItemArray[j].ToString();
                    i = i + 1;
                    excelSheet.Cells[i + 1, j + 1] = data;
                    i = i - 1;
                    //excelSheet.Cells[i , j ] = data;
                }
            }

            MessageBox.Show("Hoàn tất");
        }
        private DataTable ReadExcelFile1(string sheetName, string path)
        {

            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheetName + "]";
                    // comm.CommandText = "Select * from [" + sheetName + "$]";

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

        private void cmbsonha_Enter(object sender, EventArgs e)
        {
            cmbsonha.DataSource = listsonha;
        }

        private void cmbphuong_Enter(object sender, EventArgs e)
        {
            cmbphuong.DataSource = listphuong;
        }

        private void cmbsheet_Leave(object sender, EventArgs e)
        {
            //liststt = GetExcelSheetColumns(cmbsheet.Text);
            //listnguoinhan = GetExcelSheetColumns(cmbsheet.Text);
            //listsonha = GetExcelSheetColumns(cmbsheet.Text);
            //listdiachi = GetExcelSheetColumns(cmbsheet.Text);
            //listphuong = GetExcelSheetColumns(cmbsheet.Text);
            //listquan = GetExcelSheetColumns(cmbsheet.Text);
            //listthanhpho = GetExcelSheetColumns(cmbsheet.Text);
            //listghichu = GetExcelSheetColumns(cmbsheet.Text);
            //listlienhe = GetExcelSheetColumns(cmbsheet.Text);
            //listorder = GetExcelSheetColumns(cmbsheet.Text);
        }

        private void FrmCG7_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
        private void load_settings()
        {
            cmbstt.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbstt", String.Empty);
            cmbnguoinhan.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbnguoinhan", String.Empty);
            cmbsonha.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbsonha", String.Empty);
            cmbdiachi.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbdiachi", String.Empty);
            cmbphuong.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbphuong", String.Empty);
            cmbquan.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbquan", String.Empty);
            cmbthanhpho.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbthanhpho", String.Empty);
            cmbghichu.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmbghichu", String.Empty);
            cmblienhe.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmblienhe", String.Empty);
            cmbsapxeptheo.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg7.cmborder", String.Empty);

        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbstt", cmbstt.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbnguoinhan", cmbnguoinhan.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbsonha", cmbsonha.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbdiachi", cmbdiachi.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbphuong", cmbphuong.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbquan", cmbquan.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbthanhpho", cmbthanhpho.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmbghichu", cmbghichu.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmblienhe", cmblienhe.Text);
            Application.UserAppDataRegistry.SetValue("frmcg7.cmborder", cmbsapxeptheo.Text);
        }
    }
}
