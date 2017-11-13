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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void celeracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCG1 frmcg1 = new FrmCG1();
            frmcg1.MdiParent = this;
            frmcg1.Show();
        }

        private void netToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCG7 frmcg7 = new FrmCG7();
            frmcg7.MdiParent = this;
            frmcg7.Show();
        }

        private void inBáoPhátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoPhat frmbaophat = new FrmBaoPhat();
            frmbaophat.MdiParent = this;
            frmbaophat.Show();
        }

        private void sonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSony frmsony = new FrmSony();
            frmsony.MdiParent = this;
            frmsony.Show();
        }

        private void inPhiếuLẽToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNormal frmcg1le = new FrmNormal();
            CG1_LE frmcg1le = new CG1_LE();
            frmcg1le.MdiParent = this;
            frmcg1le.Dock = DockStyle.Fill;
            frmcg1le.Show();
        }

        private void inFromToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFromTo frmfromto = new FrmFromTo();
            frmfromto.MdiParent = this;
            frmfromto.Show();
        }

        private void inDHLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDHL frmdhl = new FrmDHL();
            frmdhl.MdiParent = this;
            frmdhl.Dock = DockStyle.Fill;
            frmdhl.Show();
        }

        private void inCG1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInPhieuGui frminphieugui = new FrmInPhieuGui();
            frminphieugui.MdiParent = this;
            frminphieugui.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void inDHLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDHL_New frm = new FrmDHL_New();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void cODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCOD frm = new FrmCOD();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void bayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBayer frm = new FrmBayer();
            frm.MdiParent = this;
           // frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void hỗTrợKhaiThácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenThu frm = new FrmChuyenThu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lũyKếDHLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDHLLuyKe frm = new FrmDHLLuyKe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sonyHNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSony_New frm = new FrmSony_New();
            frm.MdiParent = this;
            frm.Show();
        }

        private void traHồiBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTracking frm = new FrmTracking();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phátCTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCG8 frm = new FrmCG8();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
