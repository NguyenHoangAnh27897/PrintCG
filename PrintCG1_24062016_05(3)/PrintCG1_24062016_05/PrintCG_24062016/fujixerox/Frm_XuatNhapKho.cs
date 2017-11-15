using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;

namespace PrintCG_24062016
{
    public partial class Frm_XuatNhapKho : Form
    {
        public Frm_XuatNhapKho()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
            conn.ConnectionString = con;
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.CommandText = "select kh.Name as Customer,dc.Address as CustomerAddress ,sp.Name,xn.Quantity,xn.RealQuantity,xn.Type,xn.CreateDate from tb_fujixeroxdmsp sp inner join ( tb_fujixeroxnx xn inner join ( tb_fujixeroxdmdc dc inner join  tb_fujixeroxdmkh kh on dc.ID_Customer = kh.ID) on xn.AddressID = dc.ID ) on sp.ID = xn.IDSP   where CreateDate between #" + dpk1.Value.ToString("MM-dd-yyyy") + "# and #" + dpk2.Value.ToString("MM-dd-yyyy") + "#";
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvTable.DataSource = dt;
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Rpt_Fijuxerox rpt = new Rpt_Fijuxerox();
            //TextObject _txtbcnhan = (TextObject)rpt.ReportDefinition.Sections["Section3"].ReportObjects["txtbcnhan"];
            //_txtbcnhan.Text = "DHL";
        }
    }
}
