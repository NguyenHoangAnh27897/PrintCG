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
    public partial class FrmCG1 : Form
    {
        public FrmCG1()
        {
            InitializeComponent();
        }
        string path;
        private void FrmCG1_Load(object sender, EventArgs e)
        {
            txtbcchapnhan.Focus();
        }

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lblfile.Text = openFileDialog1.FileName;
        }

        private void btnxemfile_Click(object sender, EventArgs e)
        {
           
        }

        private void btnxemin_Click(object sender, EventArgs e)
        {
            try
            {

                FrmCG1Print.flag = 1;
                FrmCG1Print.path = lblfile.Text;
                FrmCG1Print.bcchapnhan = txtbcchapnhan.Text;
                FrmCG1Print.nvchapnhan = txtnvchapnhan.Text;
                FrmCG1Print.nguoigui = txtnguoigui.Text;
                FrmCG1Print.diachi = txtdiachigui.Text;
                FrmCG1Print.cuoc = txtcuocchinh.Text;
                FrmCG1Print.hengio = txthengio.Text;
                FrmCG1Print.phikhac = txtcuocchinh.Text;
                if (chkems.Checked == true)
                {
                    FrmCG1Print.ems = "EMS";
                }
                else if (chkems.Checked == false)
                {
                    FrmCG1Print.ems = "";
                }
                FrmCG1Print frmcg1print = new FrmCG1Print();
                // FrmMain frmmain = new FrmMain();
                //frmcg1print.MdiParent = frmmain;
                frmcg1print.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlabel_Click(object sender, EventArgs e)
        {
            FrmCG1Print.flag = 2;
            FrmCG1Print.path = lblfile.Text;
            FrmCG1Print.bcchapnhan = txtbcchapnhan.Text;
            FrmCG1Print.nvchapnhan = txtnvchapnhan.Text;
            FrmCG1Print.nguoigui = txtnguoigui.Text;
            FrmCG1Print.diachi = txtdiachigui.Text;
            FrmCG1Print.cuoc = txtcuocchinh.Text;
            FrmCG1Print.hengio = txthengio.Text;
            FrmCG1Print.phikhac = txtcuocchinh.Text;
            FrmCG1Print frmcg1print = new FrmCG1Print();
            frmcg1print.ShowDialog();
        }

        private void btnlabel30_Click(object sender, EventArgs e)
        {
            FrmCG1Print.flag = 3;
            FrmCG1Print.path = lblfile.Text;
            FrmCG1Print.bcchapnhan = txtbcchapnhan.Text;
            FrmCG1Print.nvchapnhan = txtnvchapnhan.Text;
            FrmCG1Print.nguoigui = txtnguoigui.Text;
            FrmCG1Print.diachi = txtdiachigui.Text;
            FrmCG1Print.cuoc = txtcuocchinh.Text;
            FrmCG1Print.hengio = txthengio.Text;
            FrmCG1Print.phikhac = txtcuocchinh.Text;
            FrmCG1Print frmcg1print = new FrmCG1Print();
            frmcg1print.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCG1Print.flag = 4;
                FrmCG1Print.path = lblfile.Text;
                FrmCG1Print.bcchapnhan = txtbcchapnhan.Text;
                FrmCG1Print.nvchapnhan = txtnvchapnhan.Text;
                FrmCG1Print.nguoigui = txtnguoigui.Text;
                FrmCG1Print.diachi = txtdiachigui.Text;
                FrmCG1Print.cuoc = txtcuocchinh.Text;
                FrmCG1Print.hengio = txthengio.Text;
                FrmCG1Print.phikhac = txtcuocchinh.Text;
                if (chkems.Checked == true)
                {
                    FrmCG1Print.ems = "EMS";
                }
                else if (chkems.Checked == false)
                {
                    FrmCG1Print.ems = "";
                }
                FrmCG1Print frmcg1print = new FrmCG1Print();
                // FrmMain frmmain = new FrmMain();
                //frmcg1print.MdiParent = frmmain;
                frmcg1print.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCG1Print.flag = 5;
                FrmCG1Print.path = lblfile.Text;
                FrmCG1Print.bcchapnhan = txtbcchapnhan.Text;
                FrmCG1Print.nvchapnhan = txtnvchapnhan.Text;
                FrmCG1Print.nguoigui = txtnguoigui.Text;
                FrmCG1Print.diachi = txtdiachigui.Text;
                FrmCG1Print.cuoc = txtcuocchinh.Text;
                FrmCG1Print.hengio = txthengio.Text;
                FrmCG1Print.phikhac = txtcuocchinh.Text;
                if (chkems.Checked == true)
                {
                    FrmCG1Print.ems = "EMS";
                }
                else if (chkems.Checked == false)
                {
                    FrmCG1Print.ems = "";
                }
                FrmCG1Print frmcg1print = new FrmCG1Print();
                // FrmMain frmmain = new FrmMain();
                //frmcg1print.MdiParent = frmmain;
                frmcg1print.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
