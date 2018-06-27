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
    public partial class FrmDHL_PLAN_INSERT : Form
    {
        public FrmDHL_PLAN_INSERT()
        {
            InitializeComponent();
        }

        //khai bao cac bien excel
        string path;
        string[] listsheet;
        string[] listDO;
        string[] listPGI;
        string[] listDeliveryDate;
        string[] listToZone;
        string[] listZoneDesc;
        string[] listNodeCode;
        string[] listQuality;
        string[] listUnit1;
        string[] listUnit2;
        string[] listUnit3;
        string[] listWeight;
        string[] listSubcon;
        string[] listVolumn;
        string[] listshiptonm;
        string[] listshipaddress; 


        private void FrmDHL_PLAN_INSERT_Load(object sender, EventArgs e)
        {
            load_settings();
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
            listPGI = GetExcelSheetColumns(path, cmbsheet.Text);
            listDeliveryDate = GetExcelSheetColumns(path, cmbsheet.Text);
            listToZone = GetExcelSheetColumns(path, cmbsheet.Text);
            listToZone = GetExcelSheetColumns(path, cmbsheet.Text);
            listZoneDesc = GetExcelSheetColumns(path, cmbsheet.Text);
            listNodeCode = GetExcelSheetColumns(path, cmbsheet.Text);
            listQuality = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit1 = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit2 = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit3 = GetExcelSheetColumns(path, cmbsheet.Text);
            listWeight = GetExcelSheetColumns(path, cmbsheet.Text);
            listSubcon = GetExcelSheetColumns(path, cmbsheet.Text);
            listVolumn = GetExcelSheetColumns(path, cmbsheet.Text);
            listshiptonm = GetExcelSheetColumns(path, cmbsheet.Text);
            listshipaddress = GetExcelSheetColumns(path, cmbsheet.Text);
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

        private void btnxem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadExcelFile(cmbsheet.Text, path);
            lbltotaldo.Text = "Tổng số DO là :" + dataGridView1.RowCount; 
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
        private void btninsert_Click(object sender, EventArgs e)
        {
            //kiem tra noi dung các cmb co thay doi.

            int total = 0;
            bool flag = true;
            string matinh = string.Empty;
            string vung = string.Empty;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            DsDHLDiachi dsdiachi = new DsDHLDiachi();
            string Zone;
            string ZoneDesc;
            string NodeCode;
            string ShipName;
            string ShipAddress;
            string Remark;
            DateTime pgi;
            DateTime deliverydate;
            string error = string.Empty;
            try
            {
                OleDbConnection conn = new OleDbConnection();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                conn.Open();
               
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string khachhang = string.Empty;
                    string diachi = string.Empty;
                    string remark = string.Empty;
                    string DO = string.Empty;
                    string pgidate = string.Empty;
                    string deliverydatecon = string.Empty;
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
                       //lay ra ma tinh va ten nguoi nhan, dia chi nhan, remark
                        try
                        {
                            ds = get_matinh(row.Cells[cmbzonedesc.Text].Value.ToString().Trim());
                            matinh = ds.Tables[0].Rows[0]["MaTinh"].ToString();
                            vung = ds.Tables[0].Rows[0]["Vung"].ToString();
                            dt = get_diachi(row.Cells[cmbshipcode.Text].Value.ToString().Trim());
                        }catch(Exception ex)
                        {
                            error = "Không tim thấy " + row.Cells[cmbzonedesc.Text].Value.ToString().Trim();
                        }
                       
                        if (dt.Rows.Count > 0)
                        {
                            khachhang = dt.Rows[0][0].ToString();
                            if (khachhang.Length < 5)
                            {
                                khachhang = row.Cells[cmbshiptoNM.Text].Value.ToString();
                            }
                            diachi = dt.Rows[0][1].ToString();
                            if (diachi.Length < 5)
                            {
                                diachi = row.Cells[cmbshiptoaddress.Text].Value.ToString();
                            }
                            remark = dt.Rows[0][2].ToString();

                            pgi = DateTime.Parse(row.Cells[cmbpgi.Text].Value.ToString());
                            pgidate = pgi.ToString("dd-MM-yyyy");
                            deliverydate = DateTime.Parse(row.Cells[cmbdeliverydate.Text].Value.ToString());
                            deliverydatecon = deliverydate.ToString("dd-MM-yyyy");
                            string query = "insert into tb_dhlplan ([D/O],PGI,DeliveryDate,ToZone,ZoneDesc,ToNodeCode,Quatity,Unit1,Weight,Unit2,Subcon,Unit3,ShiptoNM,ShiptoAddress,TP,KH,Vung)" +
                            " values('" + row.Cells[cmbdo.Text].Value.ToString() + "','" + pgidate + "'," +
                            " '" + deliverydatecon + "','" + row.Cells[cmbtozone.Text].Value.ToString() + "'," +
                            " '" + row.Cells[cmbzonedesc.Text].Value.ToString() + "','" + row.Cells[cmbshipcode.Text].Value.ToString() + "'," + row.Cells[cmbquality.Text].Value.ToString() + "," +
                            " '" + row.Cells[cmbunit1.Text].Value.ToString() + "'," + row.Cells[cmbweight.Text].Value.ToString() + "," +
                            " '" + row.Cells[cmbunit2.Text].Value.ToString() + "'," +
                            " '" + row.Cells[cmbsubcon.Text].Value.ToString() + "'," +
                            " '" + row.Cells[cmbunit3.Text].Value.ToString() + "'," +
                            " '" + khachhang + "'," +
                            "'" + diachi + "'," +
                            "'" + matinh + "'," +
                            "'" + remark + "', " +
                            "'" + vung + 
                            "'" +
                            " )";
                           
                           
                            try
                            {
                                OleDbCommand cmd = new OleDbCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                total += 1;
                               // MessageBox.Show("test");
                            }
                            catch (Exception ex)
                            {
                                error = "Insert không thành công";
                                //MessageBox.Show(ex.ToString());
                            }
                            
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            flag = false;
                            Zone = row.Cells[cmbtozone.Text].Value.ToString();
                            ZoneDesc = row.Cells[cmbzonedesc.Text].Value.ToString();
                            NodeCode = row.Cells[cmbshipcode.Text].Value.ToString();
                            ShipName = row.Cells[cmbshiptoNM.Text].Value.ToString();
                            ShipAddress = row.Cells[cmbshiptoaddress.Text].Value.ToString();
                            try
                            {
                                dsdiachi.DHLDiachi.Rows.Add(Zone, ZoneDesc, NodeCode, ShipName, ShipAddress, "");
                                
                            }
                            catch (Exception ex)
                            {
                               // MessageBox.Show(ex.ToString());  khong bat catch o day
                            }
                            FrmDHLDiachi.dt = dsdiachi.Tables[0];
                        }
                        
                    }
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Cập nhật thành công " + total + " DO!");
            if (flag == false)
            {
                FrmDHLDiachi frm = new FrmDHLDiachi();
                frm.Show();
            }
        }
        static string NullValue(object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }
        private void cmbdo_Enter(object sender, EventArgs e)
        {
            cmbdo.DataSource = listDO;
        }

        private void cmbpgi_Enter(object sender, EventArgs e)
        {
            cmbpgi.DataSource = listPGI;
        }

        private void cmbdeliverydate_Enter(object sender, EventArgs e)
        {
            cmbdeliverydate.DataSource = listDeliveryDate;
        }

        private void cmbtozone_Enter(object sender, EventArgs e)
        {
            cmbtozone.DataSource = listToZone;
        }

        private void cmbzonedesc_Enter(object sender, EventArgs e)
        {
            cmbzonedesc.DataSource = listZoneDesc;
        }

        private void cmbshipcode_Enter(object sender, EventArgs e)
        {
            cmbshipcode.DataSource = listNodeCode;
        }

        private void cmbquality_Enter(object sender, EventArgs e)
        {
            cmbquality.DataSource = listQuality;
        }

        private void cmbunit1_Enter(object sender, EventArgs e)
        {
            cmbunit1.DataSource = listUnit1;
        }

        private void cmbvolume_Enter(object sender, EventArgs e)
        {
            cmbvolume.DataSource = listVolumn;
        }

        private void cmbunit2_Enter(object sender, EventArgs e)
        {
            cmbunit2.DataSource = listUnit2;
        }

        private void cmbweight_Enter(object sender, EventArgs e)
        {
            cmbweight.DataSource = listWeight;
        }

        private void cmbunit3_Enter(object sender, EventArgs e)
        {
            cmbunit3.DataSource = listUnit3;
        }

        private void cmbsubcon_Enter(object sender, EventArgs e)
        {
            cmbsubcon.DataSource = listSubcon;
        }
        private void load_settings()
        {
            cmbdo.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbdo", String.Empty);
            cmbpgi.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbpgi", String.Empty);
            cmbdeliverydate.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbdeliverydate", String.Empty);
            cmbtozone.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbtozone", String.Empty);
            cmbzonedesc.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbzonedesc", String.Empty);
            cmbshipcode.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbshipcode", String.Empty);
            cmbquality.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbquality", String.Empty);
            cmbunit1.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbunit1", String.Empty);
            cmbvolume.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbvolume", String.Empty);
            cmbunit2.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbunit2", String.Empty);
            cmbweight.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbweight", String.Empty);
            cmbunit3.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbunit3", String.Empty);
            cmbsubcon.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbsubcon", String.Empty);
            cmbshiptoNM.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbshiptoNM", String.Empty);
            cmbshiptoaddress.Text = (String)Application.UserAppDataRegistry.GetValue("FrmDHL_PLAN_INSERT.cmbshiptoaddress", String.Empty);
        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbdo", cmbdo.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbpgi", cmbpgi.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbdeliverydate", cmbdeliverydate.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbtozone", cmbtozone.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbzonedesc", cmbzonedesc.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbshipcode", cmbshipcode.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbquality", cmbquality.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbunit1", cmbunit1.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbvolume", cmbvolume.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbunit2", cmbunit2.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbweight", cmbweight.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbunit3", cmbunit3.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbsubcon", cmbsubcon.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbshiptoNM", cmbshiptoNM.Text);
            Application.UserAppDataRegistry.SetValue("FrmDHL_PLAN_INSERT.cmbshiptoaddress", cmbshiptoaddress.Text);
        }

        private void FrmDHL_PLAN_INSERT_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
        private DataSet get_matinh(string tentinh)
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
        private DataTable get_diachi(string codenode)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = new OleDbConnection();
               
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                conn.ConnectionString = con;
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.CommandText = "Select ShipName,ShipAddress,Remark from tb_diachi where NodeCode = '" + codenode + "'";
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

        private void cmbshiptoNM_Enter(object sender, EventArgs e)
        {
            cmbshiptoNM.DataSource = listshiptonm;
        }

        private void cmbshiptoaddress_Enter(object sender, EventArgs e)
        {
            cmbshiptoaddress.DataSource = listshipaddress;
        }

        private void cmbsheet_SelectedValueChanged(object sender, EventArgs e)
        {
            listDO = GetExcelSheetColumns(path, cmbsheet.Text);
            listPGI = GetExcelSheetColumns(path, cmbsheet.Text);
            listDeliveryDate = GetExcelSheetColumns(path, cmbsheet.Text);
            listToZone = GetExcelSheetColumns(path, cmbsheet.Text);
            listToZone = GetExcelSheetColumns(path, cmbsheet.Text);
            listZoneDesc = GetExcelSheetColumns(path, cmbsheet.Text);
            listNodeCode = GetExcelSheetColumns(path, cmbsheet.Text);
            listQuality = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit1 = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit2 = GetExcelSheetColumns(path, cmbsheet.Text);
            listUnit3 = GetExcelSheetColumns(path, cmbsheet.Text);
            listWeight = GetExcelSheetColumns(path, cmbsheet.Text);
            listSubcon = GetExcelSheetColumns(path, cmbsheet.Text);
            listVolumn = GetExcelSheetColumns(path, cmbsheet.Text);
            listshiptonm = GetExcelSheetColumns(path, cmbsheet.Text);
            listshipaddress = GetExcelSheetColumns(path, cmbsheet.Text);
        }
        private void visiblecmb()
        {
            cmbdo.Enabled = false;
        }
    }
}
