using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.OleDb;

namespace PrintCG_24062016
{
    public partial class FrmExcel : DevExpress.XtraEditors.XtraForm
    {
        public FrmExcel()
        {
            InitializeComponent();
        }

        private void FrmExcel_Load(object sender, EventArgs e)
        {
            cbbType.Items.Add(new { Text = "Nhập hàng", Value = "1" });
            cbbType.Items.Add(new { Text = "Xuất hàng", Value = "2" });
            cbbType.Items.Add(new { Text = "Báo cáo tồn", Value = "3" });

            cbbType.DisplayMember = "Text";
            cbbType.ValueMember = "Value";
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBox cmb = (DevExpress.XtraEditors.ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            int selectedValue = (int)cmb.SelectedItem;
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            if (selectedValue == 1)
            {
                cmd.CommandText = "select * from tb_fujixeroxdmsp";
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}