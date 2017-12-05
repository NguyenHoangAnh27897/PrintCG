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
    public partial class FrmHoaDon : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmChiTietHoaDon frm = new FrmChiTietHoaDon(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
            frm.Show();
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
    }
}
