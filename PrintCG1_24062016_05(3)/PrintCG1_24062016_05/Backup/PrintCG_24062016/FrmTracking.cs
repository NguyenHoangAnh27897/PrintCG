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
    public partial class FrmTracking : Form
    {
        public FrmTracking()
        {
            InitializeComponent();
        }

        private void btntracking_Click(object sender, EventArgs e)
        {
            DBLIST.Service1SoapClient list = new PrintCG_24062016.DBLIST.Service1SoapClient();
            dataGridView1.DataSource = list.SGP_KT_GetPackingListbyMailerID(txtmailer.Text.ToString()).Tables[0];
        }

        private void txtmailer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DBLIST.Service1SoapClient list = new PrintCG_24062016.DBLIST.Service1SoapClient();
                dataGridView1.DataSource = list.SGP_KT_GetPackingListbyMailerID(txtmailer.Text.ToString()).Tables[0];
            }
        }
    }
}
