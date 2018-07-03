using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016.congcu
{
    public partial class FrmLuuChuyenChungTu : Form
    {
        PrintCG_24062016.ChuyenThu.Service1SoapClient db = new ChuyenThu.Service1SoapClient();
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        string PostOfficeID = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
        public FrmLuuChuyenChungTu()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbcustomergroup.Text !="")
                {
                    string POD = string.Empty;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        POD = row.Cells["POD"].Value.ToString();
                        bool insert = sv.insert_DocumentReturn(cbbcustomergroup.SelectedValue.ToString(), dtpngaygiao.Value, POD, PostOfficeID);
                    }
                }
                
            }catch
            {

            }
        }

        private void FrmLuuChuyenChungTu_Load(object sender, EventArgs e)
        {

        }

        private void cbbcustomergroup_Enter(object sender, EventArgs e)
        {
            try
            {
                var lstcus = sv.getCustomerGroupPMS().ToList();
                cbbcustomergroup.DataSource = lstcus;
                cbbcustomergroup.DisplayMember = "CustomerGroupID";
                cbbcustomergroup.ValueMember = "CustomerGroupID";
            }catch
            {

            }
         
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdbngay.Checked == true)
                {
                    gridControl1.DataSource = sv.get_DocumentReturn(dtpfromdate.Value, dtptodate.Value, PostOfficeID);
                }else if(rdbtheopod.Checked == true)
                {
                    gridControl1.DataSource = sv.get_DocumentReturnbyPOD(txtpod.Text);
                }
               
            }catch
            {

            }
            
        }

        private void dataGridView2_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            txttong.Text = (dataGridView2.RowCount -1).ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string POD = string.Empty;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        POD = row.Cells["POD"].Value.ToString();
                        bool insert = sv.delete_DocumentReturn( POD, PostOfficeID);
                    }

            }
            catch
            {

            }
        }

        private void btnxoaluoi_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            gridControl1.ExportToXls(saveFileDialog1.FileName);
        }

        private void rdbngay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbngay.Checked == true)
            {
                groupBox1.Enabled = true;
                rdbtheopod.Checked = false;
            }else
            {
                groupBox1.Enabled = false;
                rdbtheopod.Checked = true;
            }
        }

        private void rdbtheopod_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtheopod.Checked == true)
            {
                groupBox2.Enabled = true;
                rdbngay.Checked = false;
            }
            else
            {
                groupBox2.Enabled = false;
                rdbngay.Checked = true;
            }
        }
    }
}
