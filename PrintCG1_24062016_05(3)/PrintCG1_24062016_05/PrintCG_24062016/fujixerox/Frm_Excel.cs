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
using Excel = Microsoft.Office.Interop.Excel;
using CrystalDecisions.CrystalReports.Engine;

namespace PrintCG_24062016
{
    public partial class Frm_Excel : Form
    {
        public DataTable dt;
        public Frm_Excel()
        {
            InitializeComponent();
        }

        private void Frm_Excel_Load(object sender, EventArgs e)
        {
            cbbType.Items.Add(new { Text = "Nhập hàng", Value = "1" });
            cbbType.Items.Add(new { Text = "Xuất hàng", Value = "2" });
            cbbType.Items.Add(new { Text = "Báo cáo tồn", Value = "3" });
            cbbType.Items.Add(new { Text = "In Xuất nhập tồn", Value = "4" });

            cbbType.DisplayMember = "Text";
            cbbType.ValueMember = "Value";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string cbb = cbbType.Text;
            OleDbConnection conn = new OleDbConnection();
            dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            int count;
            if (cbb == "Nhập hàng")
            {
                cmd.CommandText = "select log.CreateDate, log.IDSP, sp.Name, log.Quantity, log.Employee from tb_fujixeroxlog log inner join tb_fujixeroxdmsp sp on log.IDSP = sp.ID where log.CreateDate between #" + dtp1.Value.ToString("MM-dd-yyyy") + "# and #" + dtp2.Value.ToString("MM-dd-yyyy") + "# and log.Type ='N'";
                da.SelectCommand = cmd;
                da.Fill(dt);
                count = dt.Rows.Count;
                string name;
                string id;
                int quan;
                string employee;
                for (int i = 0; i < count; i++)
                {
                    name = dt.Rows[i][2].ToString();
                    id = dt.Rows[i][1].ToString();
                    quan = int.Parse(dt.Rows[i][3].ToString());
                    employee = dt.Rows[i][4].ToString();
                    DateTime date = DateTime.Parse(dt.Rows[i][0].ToString());
                    string[] row = new string[] { (i+1).ToString(), date.ToString("MM-dd-yyyy"), date.ToString("HH:mm"), name, id, "",quan.ToString(), employee};
                    dataGridView1.Rows.Add(row);
                }
                    //dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbb == "Xuất hàng")
            {
                cmd.CommandText = "select log.CreateDate, log.IDSP, sp.Name, log.Quantity, log.Employee from tb_fujixeroxlog log inner join tb_fujixeroxdmsp sp on log.IDSP = sp.ID where log.CreateDate between #" + dtp1.Value.ToString("MM-dd-yyyy") + "# and #" + dtp2.Value.ToString("MM-dd-yyyy") + "# and log.Type ='X'";
                da.SelectCommand = cmd;
                da.Fill(dt);
                count = dt.Rows.Count;
                string name;
                string id;
                int quan;
                string employee;
                for (int i = 0; i < count; i++)
                {
                    name = dt.Rows[i][2].ToString();
                    id = dt.Rows[i][1].ToString();
                    quan = int.Parse(dt.Rows[i][3].ToString());
                    employee = dt.Rows[i][4].ToString();
                    DateTime date = DateTime.Parse(dt.Rows[i][0].ToString());
                    string[] row = new string[] { (i + 1).ToString(), date.ToString("MM-dd-yyyy"), date.ToString("HH:mm"), name, id, "", quan.ToString(), employee };
                    dataGridView1.Rows.Add(row);
                }
                //dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbb == "Báo cáo tồn")
            {
                cmd.CommandText = "select nx.CreateDate,sp.Name, nx.Quantity - nx.RealQuantity as SLT, nx.RealQuantity from tb_fujixeroxnx nx inner join tb_fujixeroxdmsp sp on nx.IDSP = sp.ID where nx.CreateDate between #" + dtp1.Value.ToString("MM-dd-yyyy") + "# and #" + dtp2.Value.ToString("MM-dd-yyyy") + "#";
                da.SelectCommand = cmd;
                da.Fill(dt);
                count = dt.Rows.Count;
                string name;
                int slt;
                int real;
                for (int i = 0; i < count; i++)
                {
                    name = dt.Rows[i][1].ToString();
                    slt = int.Parse(dt.Rows[i][2].ToString());
                    real = int.Parse(dt.Rows[i][3].ToString());
                    DateTime date = DateTime.Parse(dt.Rows[i][0].ToString());
                    string[] row = new string[] { (i + 1).ToString(), date.ToString("MM-dd-yyyy"), name, slt.ToString(), real.ToString(), ""};
                    dataGridView1.Rows.Add(row);
                }
                //dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbb == "In Xuất nhập tồn")
            {
                cmd.CommandText = "select CreateDate, IDSP, Quantity - RealQuantity as SLT from tb_fujixeroxnx where CreateDate = #" + dtp1.Value.ToString("MM-dd-yyyy") + "#";
                da.SelectCommand = cmd;
                da.Fill(dt);
                count = dt.Rows.Count;
                DateTime date = DateTime.Parse(dt.Rows[0][0].ToString());
                string idsp;
                int slt;
                for (int i = 0; i < count; i++)
                {
                    slt = int.Parse(dt.Rows[i][2].ToString());
                    idsp = dt.Rows[i][1].ToString();
                    
                    string[] row = new string[] {date.ToString(), idsp, slt.ToString()};
                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbb = cbbType.Text;
            if (cbb == "Nhập hàng")
            {
                labelControl1.Text = "Từ ngày";
                labelControl2.Visible = true;
                button2.Text = "Xuất Excel";
                dtp2.Visible = true;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "STT";
                dataGridView1.Columns[1].Name = "Ngay nhap hang";
                dataGridView1.Columns[2].Name = "Thoi gian nhap hang";
                dataGridView1.Columns[3].Name = "Ten san pham";
                dataGridView1.Columns[4].Name = "Ma san pham ";
                dataGridView1.Columns[5].Name = "So lo san pham";
                dataGridView1.Columns[6].Name = "So luong";
                dataGridView1.Columns[7].Name = "Nguoi nhap hang";
            }
            else if (cbb == "Xuất hàng")
            {
                labelControl1.Text = "Từ ngày";
                labelControl2.Visible = true;
                button2.Text = "Xuất Excel";
                dtp2.Visible = true;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "STT";
                dataGridView1.Columns[1].Name = "Ngay xuat hang";
                dataGridView1.Columns[2].Name = "Thoi gian xuat hang";
                dataGridView1.Columns[3].Name = "Ten san pham";
                dataGridView1.Columns[4].Name = "Ma san pham ";
                dataGridView1.Columns[5].Name = "So lo san pham";
                dataGridView1.Columns[6].Name = "So luong";
                dataGridView1.Columns[7].Name = "Nguoi nhap hang";
            }
            else if (cbb == "Báo cáo tồn")
            {
                labelControl1.Text = "Từ ngày";
                labelControl2.Visible = true;
                button2.Text = "Xuất Excel";
                dtp2.Visible = true;
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "STT";
                dataGridView1.Columns[1].Name = "Ngay thuc hien";
                dataGridView1.Columns[2].Name = "Ten san pham";
                dataGridView1.Columns[3].Name = "So luong ton";
                dataGridView1.Columns[4].Name = "So luong thuc xuat";
                dataGridView1.Columns[5].Name = "Hang mop. Hong";
            }
            else if (cbb == "In Xuất nhập tồn")
            {
                labelControl1.Text = "Chọn ngày";
                labelControl2.Visible = false;
                button2.Text = "In";
                dtp2.Visible = false;
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Ngay";
                dataGridView1.Columns[1].Name = "Ma san pham";
                dataGridView1.Columns[2].Name = "So luong ton";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbbType.Text == "Nhập hàng" || cbbType.Text == "Xuất hàng" || cbbType.Text == "Báo cáo tồn")
            {
                SaveFileDialog fsave = new SaveFileDialog();

                Excel.Application obj = new Excel.Application();
                Excel.Workbook wbook;

                fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
                fsave.ShowDialog();
                DateTime createdate;
                if (fsave.FileName != "")
                {
                    wbook = obj.Workbooks.Add(Type.Missing);
                    obj.Columns.ColumnWidth = 25;

                    // truyen data
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        wbook.Worksheets.Add();
                        //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

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
            if (cbbType.Text == "In Xuất nhập tồn")
            {  
                Rpt_XuatNhapTon rpt = new Rpt_XuatNhapTon();

                int count = dt.Rows.Count;
                string idsp;
                int slt;
                DateTime date = DateTime.Parse(dt.Rows[0][0].ToString());
                string printdate = date.ToString("dd-MM-yyyy");
                TextObject _txtPrintDate = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtPrintDate"];
                _txtPrintDate.Text = printdate;
                TextObject[] textoj = new TextObject[count];
                TextObject[] textobj = new TextObject[count];
                for (int i = 0; i < count; i++)
                {
                    slt = int.Parse(dt.Rows[i][2].ToString());
                    idsp = dt.Rows[i][1].ToString();
                    textoj[i] = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtIDSP"];
                    textoj[i].Text = idsp;
                    textobj[i] = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtQuantity"];
                    textobj[i].Text = slt.ToString();
                }
                rpt.PrintToPrinter(1, false, 1, 1);
            }
        }
    }
}
