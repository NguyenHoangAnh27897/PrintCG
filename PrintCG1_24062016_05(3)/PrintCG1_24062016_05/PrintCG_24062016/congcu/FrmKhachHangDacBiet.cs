using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
namespace PrintCG_24062016.congcu
{
    public partial class FrmKhachHangDacBiet : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        PrintCG_24062016.ChuyenThu.Service1SoapClient db = new ChuyenThu.Service1SoapClient();
        public FrmKhachHangDacBiet()
        {
            InitializeComponent();
        }
        private void cbbdieukien_Enter(object sender, EventArgs e)
        {
            if(cbbloctheo.SelectedIndex == 1 || cbbloctheo.SelectedIndex == 3)
            {
                //lay ra zone
                var lstcus = sv.getZone().ToList();
                cbbdieukien.DataSource = lstcus;
                cbbdieukien.DisplayMember = "ZoneID";
                cbbdieukien.ValueMember = "ZoneID";
            }else if (cbbloctheo.SelectedIndex == 2 || cbbloctheo.SelectedIndex == 4)
            {
                var lstcus = sv.getPostOffice().ToList();
                cbbdieukien.DataSource = lstcus;
                cbbdieukien.DisplayMember = "PostOfficeName";
                cbbdieukien.ValueMember = "PostOfficeID";
            }
        }

        private void cbbcustomergroup_Enter(object sender, EventArgs e)
        {
            var lstcus = sv.getCustomerGroupPMS().ToList();
            cbbcustomergroup.DataSource = lstcus;
            cbbcustomergroup.DisplayMember = "CustomerGroupID";
            cbbcustomergroup.ValueMember = "CustomerGroupID";
        }
        private void load()
        {
            try
            {
                if (cbbloctheo.SelectedIndex == 0)
                {
                    int loai = cbbloctheo.SelectedIndex;
                    string tungay = dtpfromtab4.Value.ToString("yyyy-MM-dd");
                    string denngay = dtptotab4.Value.ToString("yyyy-MM-dd");
                    var lst = sv.getListCustomerGroupDetails(tungay, denngay, "", cbbcustomergroup.SelectedValue.ToString(), loai).ToList();
                    gridControl1.DataSource = lst;
                }
                else
                {
                    int loai = cbbloctheo.SelectedIndex;
                    string tungay = dtpfromtab4.Value.ToString("yyyy-MM-dd");
                    string denngay = dtptotab4.Value.ToString("yyyy-MM-dd");
                    var lst = sv.getListCustomerGroupDetails(tungay, denngay, cbbdieukien.SelectedValue.ToString(), cbbcustomergroup.SelectedValue.ToString(), loai).ToList();
                    gridControl1.DataSource = lst;
                }

            }
            catch
            {

            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void cbbloctheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbloctheo.SelectedIndex == 0)
            {
                cbbdieukien.Enabled = false;
            }else
            {
                cbbdieukien.Enabled = true;
            }
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var selectedRowIndex = gridView1.FocusedRowHandle;
                GridView view = gridControl1.FocusedView as GridView;
                txtcg.Text = view.GetRowCellValue(selectedRowIndex, view.Columns["MailerID"]).ToString();
                txtnguoinhan.Text = view.GetRowCellValue(selectedRowIndex, view.Columns["DeliveryTo"]).ToString();
                string ngay = dtpngaynhan.Value.ToString("yyyy-MM-dd");

                string gio = dtpgionhan.Value.ToString("HH:mm:ss");
                string ngaygio = ngay + " " + gio;

                DateTime datetime = DateTime.ParseExact(ngaygio, "yyyy-MM-dd HH:mm:ss",
                                          System.Globalization.CultureInfo.InvariantCulture);
                if (txtcg.Text != "")
                {
                    sv.updateMailerDeliveryDetail(txtcg.Text, datetime, txtnguoinhan.Text, "6");
                    load();
                    MessageBox.Show("Lưu thành công");                 
                }
            }catch
            {

            }
        }

        private void FrmKhachHangDacBiet_Load(object sender, EventArgs e)
        {

        }
    }
}
