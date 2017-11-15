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
    public partial class FrmKHDB : DevExpress.XtraEditors.XtraForm
    {
        public FrmKHDB()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Frm_ImportExcel frm = new Frm_ImportExcel();
            frm.ShowDialog();
        }
    }
}