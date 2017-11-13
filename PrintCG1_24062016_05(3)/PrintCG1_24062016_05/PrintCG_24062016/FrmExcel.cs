using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
    }
}