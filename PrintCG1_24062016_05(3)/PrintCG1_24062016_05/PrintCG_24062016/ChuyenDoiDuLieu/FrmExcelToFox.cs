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
namespace PrintCG_24062016.ChuyenDoiDuLieu
{
    public partial class FrmExcelToFox : Form
    {
        OleDbConnection cnfox = new OleDbConnection();
        string excelfile = string.Empty;
        string dbffile = string.Empty;
        string fulldbffile = string.Empty;
        DataSet ds;
        public FrmExcelToFox()
        {
            InitializeComponent();
        }
       
        private void FrmExcelToFox_Load(object sender, EventArgs e)
        {

        }
        public bool ConnectFox(string DataPath)
        {

            cnfox = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=" + DataPath + ";" + "Mode=Share Deny None;Extended Properties=\"\";UserID=\"\";" + "Mask Password=False;Cache Authentication=False;EncryptPassword=False;" + "Collating Sequence=MACHINE;Exclusive=ON;DSN=\"\"");

            try
            {
                cnfox.Open();
                return true;
            }
            catch (Exception ex)
            {
                cnfox = null;
                return false;

            }

        }
        private void createfoxtable()
        {
            
            //string filename_with_ext = Path.GetFileName(fileName);
            //string filename_without_ext = Path.GetFileNameWithoutExtension(fileName);
            //string ext_only = Path.GetExtension(fileName);
           
           // fulldbffile = saveFileDialog1.FileName;
            if(fulldbffile !="")
            {
                dbffile = Path.GetFileNameWithoutExtension(fulldbffile);
                string path = Path.GetDirectoryName(fulldbffile);

                OleDbConnection con = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=" + path + ";");
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("Create Table " + dbffile + " (Field1 I, Field2 C(10))", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }           
        }
        private void inserttofox()
        {
            if (!ConnectFox(fulldbffile)) return;
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    string maso = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //    string ten = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //    string diachi = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //    string reponum = "";
            //    string buucuc = "DNAG";
            //    string lienhe = "";
            //    string dienthoai = "";
            //    string msthue = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //    try
            //    {
            //        string str = "insert into " + "" + openFileDialog1.SafeFileName + " values('" + maso + "','" + ten + "','" + diachi + "','" + dienthoai + "','" + reponum + "','" + buucuc + "','" + lienhe + "','" + msthue + "')";

            //        OleDbCommand cmd1 = new OleDbCommand(str, cnfox);

            //        cmd1.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
        }
        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            excelfile = openFileDialog1.FileName;
            string[] sheetnames = GetExcelSheetNames(excelfile);
            cbbsheet.DataSource = sheetnames;
        }

        private void btnnoiluu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fulldbffile = saveFileDialog1.FileName;
        }

        private void btnchuyenfox_Click(object sender, EventArgs e)
        {
            //buoc 1 tao table
            createfoxtable();
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

                    comm.CommandText = "Select * from [CG11$]";

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
        private string ExcelConnection(string fileName)
        {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data Source=" + fileName + ";" +
                   @"Extended Properties=" + Convert.ToChar(34).ToString() +
                   @"Excel 8.0 Xml;";
        }
        public string[] GetExcelSheetNames(string path)
        {
            OleDbConnection con = null;
            string conStr = null;
            DataTable dt = null;
            string Import_FileName = path;
            string fileExtension = Path.GetExtension(Import_FileName);
            if (fileExtension == ".xls")
                conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                 conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0 Xml;HDR=No;'";
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
    }
}
