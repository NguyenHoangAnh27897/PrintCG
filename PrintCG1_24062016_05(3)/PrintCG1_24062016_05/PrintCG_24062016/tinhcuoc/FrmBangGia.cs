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
    public partial class FrmBangGia : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        string _priceid = string.Empty;
        string _PostOfficeID = string.Empty;
        string _Type = string.Empty;
        int _Status = 0;
        int _Service = 0;
        string _Description = string.Empty;
        string _ZoneID = string.Empty;
        DateTime _CreateDate = DateTime.Now;
        string _CalPrice = string.Empty;

        string _Serviceid = string.Empty;
        string _Customerid = string.Empty;

        //thong tin bang gia
        float _FW = 0;
        float _TW = 0;
        int _Zone = 0;
        float _Price = 0;        
        int caltype = 0;
        //khai báo biến insert
        bool insert = false;
        public FrmBangGia()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }
        public static string priceid { get; set; }
        private void btncreatezone_Click(object sender, EventArgs e)
        {
            FrmProvinceZone frm = new FrmProvinceZone();
            frm.ShowDialog();
        }

        private void btnphanra_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int columns = sgpservice.getmaxZone(cmbmavung.Text.Trim());
            if(cmbcongthuc.SelectedIndex == 0)
            {               
                int rows = 8;
                dataGridView1.Columns.Add("Begin", "Bắt đầu");
                dataGridView1.Columns.Add("End", "Kết thúc");
                for (int i = 0; i <= columns - 1; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i.ToString());
                }

                for (int j = 0; j <= rows - 1; j++)
                {
                    dataGridView1.Rows.Add();
                }
                //tao dong
                var row0 = this.dataGridView1.Rows[0];
                row0.Cells["Begin"].Value = 0;
                row0.Cells["End"].Value = 50;
            }
            else if (cmbcongthuc.SelectedIndex == 1)
            {
                //phan ra cot và phan ra dong              
                int rows = 2;
                dataGridView1.Columns.Add("Weight", "Trọng lượng(gram)");
                for (int i = 0; i <= columns - 1; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i.ToString());
                }

                for (int j = 0; j <= rows - 1; j++)
                {
                    dataGridView1.Rows.Add();
                }

                var row0 = this.dataGridView1.Rows[0];
                row0.Cells["Weight"].Value = "1000";

                var row1 = this.dataGridView1.Rows[1];
                row1.Cells["Weight"].Value = "Làm tròn";
            }
            else if (cmbcongthuc.SelectedIndex == 2)
            {
                //phan ra cot và phan ra dong              
                int rows = 1;
                dataGridView1.Columns.Add("Quantity", "Số lượng");
                for (int i = 0; i <= columns - 1; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i.ToString());
                }

                for (int j = 0; j <= rows - 1; j++)
                {
                    dataGridView1.Rows.Add();
                }

                var row0 = this.dataGridView1.Rows[0];
                row0.Cells["Quantity"].Value = 1;

            }
            
        }

        private void btnapdung_Click(object sender, EventArgs e)
        {
            priceid = txtpriceid.Text.Trim();
            tinhcuoc.FrmDichVuKhachHang frm = new FrmDichVuKhachHang();
            frm.ShowDialog();
        }

        private void FrmBangGia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FrmProvinceZone.dtprovince.Rows.Count.ToString());
        }

        private void FrmBangGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            //clear all datatable
            FrmProvinceZone.dtprovince.Clear();
        }

        private void cmbmavung_Enter(object sender, EventArgs e)
        {
            var zonelist = sgpservice.getZoneList();
            cmbmavung.DataSource = zonelist;
            cmbmavung.DisplayMember = "ZoneID";
            cmbmavung.ValueMember = "ZoneID";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                //lưu bang master trước
                _priceid = txtpriceid.Text;
                _PostOfficeID = FrmMain1.postofficeid;
                _Type = cmbloai.Text;
                _Status = 1;
                _CalPrice = cmbcongthuc.Text;
                if(chkphuphi.Checked ==true)
                {
                    _Service = 1;
                }
                _Description = txtghichu.Text;
                _ZoneID = cmbmavung.Text;
                insert = sgpservice.insertSGP_Price_Policy(_priceid,_PostOfficeID,_Type,_CreateDate,_Status,_Service,_Description,_ZoneID,_CalPrice);
                if (insert == true)
                {
                    //insert danh sach dich vu
                    for (int i = 0; i <= FrmDichVuKhachHang.dtservice.Rows.Count - 1; i++)
                    {
                        insert = sgpservice.insertSGP_Price_Service(_priceid, FrmDichVuKhachHang.dtservice.Rows[i][0].ToString());
                    }
                    //insert danh sach khach hang
                    for (int i = 0; i <= FrmDichVuKhachHang.dtcustomer.Rows.Count - 1; i++)
                    {
                        insert = sgpservice.insertSGP_Price_Customer(_priceid, FrmDichVuKhachHang.dtcustomer.Rows[i][0].ToString());
                    }
                    //insert bang gia
                    if(cmbcongthuc.Text.Trim() =="nấc trọng lượng")
                    {
                        caltype = 0;
                    }else if(cmbcongthuc.Text.Trim() =="trọng lượng")
                    {
                        caltype = 1;
                    }else if(cmbcongthuc.Text.Trim() =="số lượng")
                    {
                        caltype = 2;
                    }
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                         _FW = float.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                         _TW = float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        for(int j = 2; j  <= dataGridView1.ColumnCount -1;j++ )
                        {                          
                            //_Zone = int.Parse(dataGridView1.Rows[0].Cells[j].Value.ToString());
                            _Zone = int.Parse(dataGridView1.Columns[j].HeaderText);
                            _Price = float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            insert = sgpservice.insertSGP_Price_Value(_priceid,_FW,_TW,_Zone,_Price,caltype,i,j);
                        }
                    }

                }
                

            }catch
            {

            }
        }
    }
}
