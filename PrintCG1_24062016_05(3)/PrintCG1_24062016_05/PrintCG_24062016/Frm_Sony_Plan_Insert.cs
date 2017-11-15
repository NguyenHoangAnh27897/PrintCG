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
    public partial class Frm_Sony_Plan_Insert : Form
    {
        public Frm_Sony_Plan_Insert()
        {
            InitializeComponent();
        }
        string path;
        string[] listsheet;
        string[] listDO;
        string[] listDate;
        string[] listParty;
        string[] listName;
        string[] listStreet;
        string[] listProvince;
        string[] listWeight;
        string[] listMaterial;
        string[] listQuatity;
        string[] listDelivery;

        private void Frm_Sony_Plan_Insert_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_config()
        {
            OleDbConnection conn = new OleDbConnection();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            conn.Open();
            string query = "select * from tb_column";
            OleDbCommand Command = new OleDbCommand(query, conn);
            OleDbDataReader reader = Command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();
            foreach (DataRow row in schemaTable.Rows)
            {
                MessageBox.Show(row.Field<string>("ColumnName"));
            }
            conn.Close();
        }
        private void load_settings()
        {
            cmbdo.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbdo", String.Empty);          
            cmbparty.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbparty", String.Empty);
            cmbname.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbname", String.Empty);
            cmbstreet.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbstreet", String.Empty);
            cmbcity.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbcity", String.Empty);
            cmbweight.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbweight", String.Empty);
            cmbquatity.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbquatity", String.Empty);
            cmbmaterial.Text = (String)Application.UserAppDataRegistry.GetValue("FrmSony_Plan_insert.cmbmaterial", String.Empty);
           
        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbdo", cmbdo.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbparty", cmbparty.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbname", cmbname.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbstreet", cmbstreet.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbcity", cmbcity.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbweight", cmbweight.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbquatity", cmbquatity.Text);
            Application.UserAppDataRegistry.SetValue("FrmSony_Plan_insert.cmbmaterial", cmbmaterial.Text);
        }

        private void Frm_Sony_Plan_Insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            lblfile.Text = path;
            listsheet = GetExcelSheetNames(path);
            cmbsheet.DataSource = listsheet;
            listDO = GetExcelSheetColumns(path, cmbsheet.Text);
            listDate = GetExcelSheetColumns(path, cmbsheet.Text);
            listParty = GetExcelSheetColumns(path, cmbsheet.Text);
            listName = GetExcelSheetColumns(path, cmbsheet.Text);
            listStreet = GetExcelSheetColumns(path, cmbsheet.Text);
            listProvince = GetExcelSheetColumns(path, cmbsheet.Text);
            listWeight = GetExcelSheetColumns(path, cmbsheet.Text);
            listMaterial = GetExcelSheetColumns(path, cmbsheet.Text);
            listQuatity = GetExcelSheetColumns(path, cmbsheet.Text);
            listDelivery = GetExcelSheetColumns(path, cmbsheet.Text);
        }
        public string[] GetExcelSheetNames(string excelFileName)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string fileExtension = Path.GetExtension(excelFileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
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
        public string[] GetExcelSheetColumns(string excelFileName, string sheet)
        {


            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string fileExtension = Path.GetExtension(excelFileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheet + "]";
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

        private void cmbdo_Enter(object sender, EventArgs e)
        {
            cmbdo.DataSource = listDO;
        }
        private void cmbparty_Enter(object sender, EventArgs e)
        {
            cmbparty.DataSource = listParty;
        }

        private void cmbname_Enter(object sender, EventArgs e)
        {
            cmbname.DataSource = listName;
        }

        private void cmbstreet_Enter(object sender, EventArgs e)
        {
            cmbstreet.DataSource = listStreet;
        }

        private void cmbweight_Enter(object sender, EventArgs e)
        {
            cmbweight.DataSource = listWeight;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadExcelFile(cmbsheet.Text, path);
        }
        private DataTable ReadExcelFile(string sheetName, string path)
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
                    comm.CommandText = "Select *  from [" + sheetName + "]";
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

        private void btninsert_Click(object sender, EventArgs e)
        {
            //kiem tra noi dung các cmb co thay doi.

            int total = 0;
            bool flag = true;
            string matinh = string.Empty;
            string vung = string.Empty;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DsSonyDiachi dsdiachi = new DsSonyDiachi();
 
            string ShipID = string.Empty;
            string ShipName;
            string ShipStreet;
            string Province;
            string Remark;

            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string remark = string.Empty;
                    string DO = string.Empty;
                    try
                    {
                        DO = row.Cells[cmbdo.Text].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        DO = "";
                    }
                    if (DO != "")
                    {
                        
                        dt = get_diachi(row.Cells[cmbparty.Text].Value.ToString().Trim());                        
                        
                        if (dt.Rows.Count > 0 )
                        {

                            string query = "insert into tb_sonyplan (DODate,DO,ShipToParty,ShipToName,ShipToStreet,Province,GrossWeight,Material,Quatity)" +
                            " values('" + dtppgi.Value.ToString("dd/MM/yyyy 00:00:00") + "','" + row.Cells[cmbdo.Text].Value.ToString() + "'," +
                            " '" + row.Cells[cmbparty.Text].Value.ToString() + "','" + row.Cells[cmbname.Text].Value.ToString() + "'," +
                            " '" + row.Cells[cmbstreet.Text].Value.ToString() + "','" + row.Cells[cmbcity.Text].Value.ToString() + "'," + row.Cells[cmbweight.Text].Value.ToString() + "," +
                            " '" + row.Cells[cmbmaterial.Text].Value.ToString() + "'," + row.Cells[cmbquatity.Text].Value.ToString() +")";
                         
                            try
                            {
                                OleDbCommand cmd = new OleDbCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                total += 1;
                            }
                            catch (Exception ex)
                            {
                            }
                            
                        }
                        else
                        {
                            flag = false;
                            ShipID = row.Cells[cmbparty.Text].Value.ToString();
                            ShipName = row.Cells[cmbname.Text].Value.ToString();
                            ShipStreet = row.Cells[cmbstreet.Text].Value.ToString();
                            Province = "";
                           
                            try
                            {
                                dsdiachi.SonyDiachi.Rows.Add(ShipID, ShipName, ShipStreet, Province, "");

                            }
                            catch (Exception ex)
                            {

                            }
                            FrmSonyDiachi.dt = dsdiachi.Tables[0];
                        }

                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại thông tin khai báo chưa chính xác : các combobox, tinh thanh tren luoi");
            }
            MessageBox.Show("Cập nhật thành công " + total + " DO!");
            if (flag == false)
            {
                FrmSonyDiachi frm = new FrmSonyDiachi();
                frm.Show();
            }
        }
        private DataTable get_diachi(string shipid)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = new OleDbConnection();

                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select ShipID from tb_sonydiachi where ShipID = '" + shipid + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(dt);
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return dt;
        }
        private DataSet get_vendor(string tentinh)
        {
            DataSet ds = new DataSet();
            string matinh = string.Empty;
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select MaTinh,Vung from tb_tinhthanh where TenTinh = '" + tentinh + "'";
                comm.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                matinh = "";
            }
            return ds;
        }
        private void cmbquatity_Enter(object sender, EventArgs e)
        {
            cmbquatity.DataSource = listQuatity;
        }

        private void cmbmaterial_Enter(object sender, EventArgs e)
        {
            cmbmaterial.DataSource = listMaterial;
        }

        private void cmbcity_Enter(object sender, EventArgs e)
        {
            cmbcity.DataSource = listProvince;
        }
    }
}
