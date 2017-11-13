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
    public partial class FrmBaoPhat : Form
    {
        public FrmBaoPhat()
        {
            InitializeComponent();
        }
        string path;
        string[] listsheetname;
        string[] listnguoinhan;
        string[] listsophieu;
        string[] listngaygui;
        string[] listdiachi;

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            lblfile.Text = path;
            listsheetname = GetExcelSheetNames(path);
            cmbsheet.DataSource = listsheetname;
            listnguoinhan = GetExcelSheetColumns(path);
            listsophieu = GetExcelSheetColumns(path);
            listngaygui = GetExcelSheetColumns(path);
            listdiachi = GetExcelSheetColumns(path);
        }

        private void FrmBaoPhat_Load(object sender, EventArgs e)
        {
            load_settings();
            path = lblfile.Text;
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

        private void cmbnguoinhan_Enter(object sender, EventArgs e)
        {
            cmbnguoinhan.DataSource = listnguoinhan;
        }

        private void cmbsophieu_Enter(object sender, EventArgs e)
        {
            cmbsophieu.DataSource = listsophieu;
        }

        private void cmbdiachi_Enter(object sender, EventArgs e)
        {
            cmbdiachi.DataSource = listdiachi;
        }

        private void btninbaophat_Click(object sender, EventArgs e)
        {
            FrmCG14Print.bcgui = txtbcgoc.Text;
            FrmCG14Print.nguoinhan = cmbnguoinhan.Text;
            FrmCG14Print.sophieu = cmbsophieu.Text;
            FrmCG14Print.ngaygui = txtngaygui.Text;
            FrmCG14Print.diachi = cmbdiachi.Text;
            FrmCG14Print.path = path;
            FrmCG14Print.sheet = cmbsheet.Text;
            FrmCG14Print.kinhgui = txtkinhgui.Text;
            FrmCG14Print frmcg14 = new FrmCG14Print();
            frmcg14.ShowDialog();
        }
        private void load_settings()
        {
            txtbcgoc.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg14.txtbc", String.Empty);
        
        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmcg14.txtbc", txtbcgoc.Text);
            
        }

        private void FrmBaoPhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }
    }
}
