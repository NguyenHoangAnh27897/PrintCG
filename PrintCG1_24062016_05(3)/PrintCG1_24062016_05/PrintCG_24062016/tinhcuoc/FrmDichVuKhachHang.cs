using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016.tinhcuoc
{
    public partial class FrmDichVuKhachHang : Form
    {
        public static tinhcuoc.dataset.DsCuoc.DtServiceDataTable dtservice = new dataset.DsCuoc.DtServiceDataTable();
        public static tinhcuoc.dataset.DsCuoc.DtCustomerDataTable dtcustomer = new dataset.DsCuoc.DtCustomerDataTable();
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmDichVuKhachHang()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }
        string postofficeid = string.Empty;
        private void btnthemdv_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(cmbdv.Text.Trim());
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(cmbkh.Text.Trim());
        }

        private void FrmDichVuKhachHang_Load(object sender, EventArgs e)
        {
            lblpriceid.Text = FrmBangGia.priceid;
            postofficeid = FrmMain1.postofficeid;
            if(lblpriceid.Text != "...")
            {
                var service = sgpservice.getPriceService(lblpriceid.Text);
                var customer = sgpservice.getPriceCustomer(lblpriceid.Text);
                foreach(var item in service)
                {
                    dataGridView1.Rows.Add(item.ServiceID);
                }
                foreach (var item in customer)
                {
                    dataGridView2.Rows.Add(item.CustomerID);
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string serviceid = string.Empty;
            string customer = string.Empty;
            //datagridview1 là dich vu
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                serviceid = dataGridView1.Rows[i].Cells[0].Value.ToString();
                DataRow dr = dtservice.NewRow();
                dr[0] = serviceid;
                dtservice.Rows.Add(dr);//this will add the row at the end of the datatable
                //insert = sgpservice.insertSGP_Province_Zones(txtmavung.Text.Trim(), provinceid, int.Parse(lblvung.Text));
            }
            //datagridview2 la khach hang
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                customer = dataGridView2.Rows[i].Cells[0].Value.ToString();
                DataRow dr = dtcustomer.NewRow();
                dr[0] = customer;
                dtcustomer.Rows.Add(dr);//this will add the row at the end of the datatable
                //insert = sgpservice.insertSGP_Province_Zones(txtmavung.Text.Trim(), provinceid, int.Parse(lblvung.Text));
            }
        }
    }
}
