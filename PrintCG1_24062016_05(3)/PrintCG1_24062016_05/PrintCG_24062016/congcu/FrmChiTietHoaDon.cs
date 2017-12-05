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
    public partial class FrmChiTietHoaDon : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        private string soct;
        public FrmChiTietHoaDon(string soCT)
        {
            this.soct = soCT;
            InitializeComponent();
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgv1.ColumnCount = 5;
            dgv1.Columns[0].Name = "Số CG";
            dgv1.Columns[1].Name = "Tên hàng háo, dịch vụ";
            dgv1.Columns[2].Name = "Cước DV";
            dgv1.Columns[3].Name = "VAT";
            dgv1.Columns[4].Name = "Tổng";


            txtSoCT.Text = soct;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = dgv1.Rows.Count;
            for(int i = 0; i< count-1;i++){
                int cuoc = int.Parse(dgv1.Rows[i].Cells[2].Value.ToString());
                int vat = int.Parse(dgv1.Rows[i].Cells[3].Value.ToString());
                int total = int.Parse(dgv1.Rows[i].Cells[4].Value.ToString());
                sv.addChiTietHoaDon(txtSoCT.Text, dtpCreate.Value, dgv1.Rows[i].Cells[0].Value.ToString(), cuoc, vat, total, dgv1.Rows[i].Cells[1].Value.ToString());
            }
            MessageBox.Show("Lưu thành công");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int total = int.Parse(txtCuoc.Text) + int.Parse(txtVAT.Text);
            string[] row = new string[] { txtSoCG.Text,txtPackage.Text, txtCuoc.Text, txtVAT.Text, total.ToString() };
            dgv1.Rows.Add(row);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Rpt_HoaDon rp = new Rpt_HoaDon();
            DsHoaDon ds = new DsHoaDon();
            string userid = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtuser", string.Empty);
            string postid = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
            string username = sv.getUserName(userid);
            string postname = sv.getPostOfficeName(postid);
            int count = dgv1.Rows.Count;
            int stt = 1;
            for (int i = 0; i < count-1; i++)
            {
                ds.ChiTietHoaDon.AddChiTietHoaDonRow(stt.ToString(), dgv1.Rows[i].Cells[0].Value.ToString(), dgv1.Rows[i].Cells[1].Value.ToString(), dgv1.Rows[i].Cells[2].Value.ToString(), dgv1.Rows[i].Cells[3].Value.ToString(), dgv1.Rows[i].Cells[4].Value.ToString());
                stt++;
            }
            TextObject _txtPostOffice = (TextObject)rp.ReportDefinition.Sections["Section1"].ReportObjects["txtPostOffice"];
            _txtPostOffice.Text = postname;
            TextObject _txtUser = (TextObject)rp.ReportDefinition.Sections["Section1"].ReportObjects["txtUser"];
            _txtUser.Text = username;
            rp.SetDataSource(ds);
            rp.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("In thành công");
        }
    }
}
