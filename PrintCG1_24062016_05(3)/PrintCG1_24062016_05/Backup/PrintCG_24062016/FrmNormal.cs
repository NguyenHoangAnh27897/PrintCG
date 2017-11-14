using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016
{
    public partial class FrmNormal : Form
    {
        public FrmNormal()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dtpngaygui.Value,txtnguoigui.Text,txtdiachigui.Text,txtsodtgui.Text,txtnguoinhan.Text,txtdiachinhan.Text,cmbthanhpho.Text,cmbquanhuyen.Text,txtsodtnhan.Text,cmbloaihang.Text,cmbdichvu.Text,txtsoluong.Text,txttrongluong.Text,txttrongluongkhoi.Text,txtghichu.Text,txtcuocchinh.Text,txthengio.Text,txtphikhac.Text);
        }


    }
}
