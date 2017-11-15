using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel; 
namespace PrintCG_24062016
{
    public partial class FrmCG8 : Form
    {
        public FrmCG8()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            load_mailerdelivery();
        }
        private void load_mailerdelivery()
        {
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            string fromdate = dtpfromdate.Value.ToString("yyyy-MM-dd");
            string todate = dtptodate.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = ct.SGP_CG8_Employee(fromdate, todate, txtbuucuc.Text).Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            string employee = dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
            string fromdate = dtpfromdate.Value.ToString("yyyy-MM-dd");
            string todate = dtptodate.Value.ToString("yyyy-MM-dd");
            dataGridView2.DataSource = ct.SGP_CG8_EmployeeDetail(fromdate, todate, employee).Tables[0];
            tabControl1.SelectedTab = tabthaotac;
        }

        private void load_settings()
        {

            txtfolder.Text = (String)Application.UserAppDataRegistry.GetValue("frmcg8.txtfolder", String.Empty);

        }
        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("frmcg8.txtfolder", txtfolder.Text);

        }

        private void FrmCG8_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void FrmCG8_Load(object sender, EventArgs e)
        {
            load_settings();
        }

        private void xuatExcelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog2.InitialDirectory = "C:";
            saveFileDialog2.Title = "Save excel file as";
            saveFileDialog2.FileName = "";
            saveFileDialog2.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
            try
            {
                if (saveFileDialog2.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass Excelapp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    Excelapp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        Excelapp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            Excelapp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    Excelapp.ActiveWorkbook.SaveCopyAs(saveFileDialog2.FileName.ToString());
                    Excelapp.ActiveWorkbook.Saved = true;
                    Excelapp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("ok");

        }

        private void xuatExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save excel file as";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass Excelapp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    Excelapp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        Excelapp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count -1; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            Excelapp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    Excelapp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    Excelapp.ActiveWorkbook.Saved = true;
                    Excelapp.Quit();
                }
            }
            catch (Exception ex)
            {
            }
            MessageBox.Show("ok");
            
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {

        }
    }
}
