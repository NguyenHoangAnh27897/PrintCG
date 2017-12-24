using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016.khachhang
{
    public partial class FrmNhomKhachHang : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmNhomKhachHang()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }

        private void FrmNhomKhachHang_Load(object sender, EventArgs e)
        {
            var list = sgpservice.getCustomerGroup();
            foreach (var item in list)
            {
                dataGridView2.Rows.Add(item.GroupID, item.Name, item.Address, item.Phone, item.Taxcode);
            }
        }

        private void cmbcustomer_Enter(object sender, EventArgs e)
        {
            if (txtpost.Text.Trim() != "")
            {
                var list = sgpservice.getCustomerIDbyPost(txtpost.Text.Trim());
                foreach (var item in list)
                {
                    cmbcustomer.Items.Add(item.CustomerID);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(cmbcustomer.Text.Trim());
        }

        private void xóaDòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);
            }
            catch
            {

            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            var rowIdx = dataGridView2.CurrentCell.RowIndex;
            txtgroupid.Text = dataGridView2.Rows[rowIdx].Cells["GroupID"].Value.ToString();
            txtname.Text = dataGridView2.Rows[rowIdx].Cells["GName"].Value.ToString();
            txtaddress.Text = dataGridView2.Rows[rowIdx].Cells["Address"].Value.ToString();
            txtphone.Text = dataGridView2.Rows[rowIdx].Cells["Phone"].Value.ToString();
            txttaxcode.Text = dataGridView2.Rows[rowIdx].Cells["TaxCode"].Value.ToString();
            dataGridView1.DataSource = sgpservice.getCustomerIDbyGroup(txtgroupid.Text.Trim());
        }

    }
}
