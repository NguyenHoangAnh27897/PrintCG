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
        public FrmBangGia()
        {
            InitializeComponent();
        }

        private void btncreatezone_Click(object sender, EventArgs e)
        {
            FrmProvinceZone frm = new FrmProvinceZone();
            frm.ShowDialog();
        }

        private void btnphanra_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            if(cmbcongthuc.SelectedIndex == 0)
            {                
                int columns = 3;
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
                int columns = 3;
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
                int columns = 3;
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
    }
}
