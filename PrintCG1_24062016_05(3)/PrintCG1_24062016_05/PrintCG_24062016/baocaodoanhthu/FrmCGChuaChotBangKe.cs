using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016.baocaodoanhthu
{
    public partial class FrmCGChuaChotBangKe : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        PrintCG_24062016.ChuyenThu.Service1SoapClient db = new ChuyenThu.Service1SoapClient();
        string mabc = string.Empty;
        public FrmCGChuaChotBangKe()
        {
            InitializeComponent();
            mabc = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
        }

        private void FrmCGChuaChotBangKe_Load(object sender, EventArgs e)
        {
            cmbpost.DataSource = sv.getPostOffice();
            cmbpost.ValueMember = "PostOfficeID";
            cmbpost.DisplayMember = "PostOfficeName";
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                string tungay = dtptungay.Value.ToString("yyyy-MM-dd");
                string denngay = dtpdenngay.Value.ToString("yyyy-MM-dd");
                var lst = sv.getListCGChuaXuatBK(tungay, denngay, cmbpost.SelectedValue.ToString()).ToList();
                dataGridView1.DataSource = lst;
                txttongso.Text = dataGridView1.Rows.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Save Success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
