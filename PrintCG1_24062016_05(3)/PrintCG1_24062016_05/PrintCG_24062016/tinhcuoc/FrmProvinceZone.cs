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
    public partial class FrmProvinceZone : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmProvinceZone()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }

        private void btntaovung_Click(object sender, EventArgs e)
        {
            int isovung = int.Parse(txtsovung.Text);
            dataGridView1.Rows.Clear();
            for (int i = 0; i <= isovung - 1; i++)
            {
                //test
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();                
                row.Cells[0].Value = i;
                row.Cells[1].Value = 0;
                dataGridView1.Rows.Add(row);
                //end test
            }
        }
        private void FrmProvinceZone_Load(object sender, EventArgs e)
        {
            if(txtmavung.Text =="")
            {
                var province = sgpservice.getProvince();
                foreach(var item in province)
                {
                    string[] row = new string[] { item.ProvinceID, item.ProvinceName };
                    dataGridView2.Rows.Add(row);
                }
            }
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView2.CurrentCell.RowIndex;
                string provinceid = dataGridView2.Rows[rowindex].Cells["ProvinceID"].Value.ToString();
                string provincename = dataGridView2.Rows[rowindex].Cells["ProvinceName"].Value.ToString();
                string[] row = new string[] { provinceid, provincename };
                dataGridView3.Rows.Add(row);
                dataGridView2.Rows.RemoveAt(rowindex);
            }catch
            {

            }
            
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView3.CurrentCell.RowIndex;
                string provinceid = dataGridView3.Rows[rowindex].Cells["ProvinceID1"].Value.ToString();
                string provincename = dataGridView3.Rows[rowindex].Cells["ProvinceName1"].Value.ToString();
                string[] row = new string[] { provinceid, provincename };
                dataGridView2.Rows.Add(row);
                dataGridView3.Rows.RemoveAt(rowindex);
            }
            catch
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            lblvung.Text = dataGridView1.Rows[rowindex].Cells["Zone"].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = dataGridView2.CurrentCell.RowIndex;
                string provinceid = dataGridView2.Rows[rowindex].Cells["ProvinceID"].Value.ToString();
                string provincename = dataGridView2.Rows[rowindex].Cells["ProvinceName"].Value.ToString();
                string[] row = new string[] { provinceid, provincename };
                dataGridView3.Rows.Add(row);
                dataGridView2.Rows.RemoveAt(rowindex);
            }
            catch
            {

            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = dataGridView3.CurrentCell.RowIndex;
                string provinceid = dataGridView3.Rows[rowindex].Cells["ProvinceID1"].Value.ToString();
                string provincename = dataGridView3.Rows[rowindex].Cells["ProvinceName1"].Value.ToString();
                string[] row = new string[] { provinceid, provincename };
                dataGridView2.Rows.Add(row);
                dataGridView3.Rows.RemoveAt(rowindex);
            }
            catch
            {

            }
        }

        private void btnluuvung_Click(object sender, EventArgs e)
        {
            //luu tung vung
            if(lblvung.Text != "" && txtmavung.Text != "")
            {
                string provinceid = string.Empty;
                bool insert = false;
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    provinceid = dataGridView3.Rows[i].Cells[0].Value.ToString();
                    insert = sgpservice.insertSGP_Province_Zones(txtmavung.Text.Trim(), provinceid, int.Parse(lblvung.Text));
                }
                dataGridView3.Rows.Clear();
            }
            
        }
    }
}
