using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PrintCG_24062016.congcu
{
    public partial class FrmHoaDon : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtp1.Value;
            DateTime todate = dtp2.Value;

            dgv2.DataSource = sv.getHoaDon(fromdate, todate);
            int count = dgv2.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string[] row = new string[] { dgv2.Rows[i].Cells[2].Value.ToString(), dgv2.Rows[i].Cells[3].Value.ToString(), dgv2.Rows[i].Cells[0].Value.ToString() };
                dgv1.Rows.Add(row);
            }
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            dgv1.ColumnCount = 3;
            dgv1.Columns[0].Name = "Số CT";
            dgv1.Columns[1].Name = "Số Hoá Đơn";
            dgv1.Columns[2].Name = "Ngày lập";
            dgv1.Rows.Clear();

            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "MM/dd/yyyy";

            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "MM/dd/yyyy";

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { txtCT.Text, txtHD.Text, DateTime.Now.ToString() };
            dgv1.Rows.Add(row);
            sv.addHoaDon(txtCT.Text, txtHD.Text, DateTime.Now);
            MessageBox.Show("Thêm thành công");
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("In hoá đơn cho CT này?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Rpt_HoaDon rpt = new Rpt_HoaDon();

                    dgv3.DataSource = sv.getChiTietHoaDon(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int count = dgv3.Rows.Count;
                    int total = 0;
                    int addnumber= 0;
                    for (int i = 0; i < count; i++)
                    {
                        addnumber = int.Parse(dgv3.Rows[i].Cells[6].Value.ToString());
                        total += addnumber;
                    }
                    int vat = total / 10;
                    int tong = total + vat;
                    string postid = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
                    string postname = sv.getPostOfficeName(postid);
                    TextObject _txtPostOffice = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtPostOffice"];
                    _txtPostOffice.Text = postname;
                    TextObject _txtDes = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtDes"];
                    _txtDes.Text = dgv3.Rows[e.RowIndex].Cells[5].Value.ToString();
                    TextObject _txtbefvatamount = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbefvatamount"];
                    _txtbefvatamount.Text = total.ToString();
                    TextObject _txtbefvatamount1 = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbefvatamount1"];
                    _txtbefvatamount1.Text = total.ToString();
                    TextObject _txtvat = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtvat"];
                    _txtvat.Text = vat.ToString();

                    TextObject _txtTotal = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtTotal"];
                    _txtTotal.Text = tong.ToString();
                    rpt.PrintToPrinter(1, false, 0, 0);
                    MessageBox.Show("In thành công");
                }
                else
                {
                    FrmChiTietHoaDon frm = new FrmChiTietHoaDon(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    frm.Show();
                }
            }
        }
    }
}
