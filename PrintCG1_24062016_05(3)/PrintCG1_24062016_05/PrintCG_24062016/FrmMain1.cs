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
    public partial class FrmMain1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain1()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        public static string user {get;set;}
        public static string postofficeid{get;set;}
        public delegate void SendMessage(string userlogin, string postlogin);
        public SendMessage Sender;
        private void GetMessage(string userlogin, string postlogin)
        {
            user = userlogin;
            postofficeid = postlogin;            
            lblmanv.Text = "Mã NV : " + userlogin;
            lblmabc.Text = "Mã BC : " + postlogin; 
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CG1_LE frmcg1le = new CG1_LE();
            if ((Application.OpenForms["CG1_LE"] as CG1_LE) != null)
            {
                frmcg1le = new CG1_LE();
                frmcg1le.Focus();
            }
            else
            {
                frmcg1le = new CG1_LE();
                frmcg1le.MdiParent = this;
                frmcg1le.Dock = DockStyle.Fill;
                frmcg1le.Show();
            }
           
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmCG7 frmcg7 = new FrmCG7();
            if ((Application.OpenForms["FrmCG7"] as FrmCG7) != null)
            {
                frmcg7.Focus();
            }
            else
            {
                frmcg7 = new FrmCG7();
                frmcg7.MdiParent = this;
                frmcg7.Show();
            }
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmCG1 frmcg1 = new FrmCG1();
            if ((Application.OpenForms["FrmCG1"] as FrmCG1) != null)
            {
                frmcg1.Focus();
            }
            else
            {
                frmcg1 = new FrmCG1();
                frmcg1.MdiParent = this;
                frmcg1.Show();
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSony frmsony = new FrmSony();
            if ((Application.OpenForms["FrmSony"] as FrmSony) != null)
            {
                frmsony.Focus();
            }
            else
            {
                frmsony = new FrmSony();
                frmsony.MdiParent = this;
                frmsony.Show();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmBaoPhat frmbaophat = new FrmBaoPhat();
            if ((Application.OpenForms["FrmBaoPhat"] as FrmBaoPhat) != null)
            {
                frmbaophat.Focus();
            }
            else
            {
                frmbaophat = new FrmBaoPhat();
                frmbaophat.MdiParent = this;
                frmbaophat.Show();
            }
            
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmFromTo frmfromto = new FrmFromTo();
            if ((Application.OpenForms["FrmFromTo"] as FrmFromTo) != null)
            {
                frmfromto.Focus();
            }
            else
            {
                frmfromto = new FrmFromTo();
                frmfromto.MdiParent = this;
                frmfromto.Show();
            }
         
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmInPhieuGui frminphieugui = new FrmInPhieuGui();
            if ((Application.OpenForms["FrmInPhieuGui"] as FrmInPhieuGui) != null)
            {
                frminphieugui.Focus();
            }
            else
            {
                frminphieugui = new FrmInPhieuGui();
                frminphieugui.MdiParent = this;
                frminphieugui.Show();
            }
           
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmDHL_New frm = new FrmDHL_New();
            if ((Application.OpenForms["FrmDHL_New"] as FrmDHL_New) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmDHL_New();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmCOD frm = new FrmCOD();
            if ((Application.OpenForms["FrmCOD"] as FrmCOD) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmCOD();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmBayer frm = new FrmBayer();
            if ((Application.OpenForms["FrmBayer"] as FrmBayer) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmBayer();
                frm.MdiParent = this;
                // frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSony_New frm = new FrmSony_New();
            if ((Application.OpenForms["FrmSony_New"] as FrmSony_New) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmSony_New();
                 frm.MdiParent = this;
                 frm.Show();
            }
           
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmTracking frm = new FrmTracking();
            if ((Application.OpenForms["FrmTracking"] as FrmTracking) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmTracking();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmDHLLuyKe frm = new FrmDHLLuyKe();
            if ((Application.OpenForms["FrmDHLLuyKe"] as FrmDHLLuyKe) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmDHLLuyKe();
                frm.MdiParent = this;
                frm.Show();
            }
           
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmCG8 frm = new FrmCG8();
            if ((Application.OpenForms["FrmCG8"] as FrmCG8) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmCG8();
                frm.MdiParent = this;
                frm.Show();
            }
          
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmChuyenThu frm = new FrmChuyenThu();
            if ((Application.OpenForms["FrmChuyenThu"] as FrmChuyenThu) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmChuyenThu();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            Frm_DMSP frm = new Frm_DMSP();
            if ((Application.OpenForms["Frm_DMSP"] as Frm_DMSP) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_DMSP();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_DMKH frm = new Frm_DMKH();
            if ((Application.OpenForms["Frm_DMKH"] as Frm_DMKH) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_DMKH();
                frm.MdiParent = this;
                frm.Show();
            }
           
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_NhapKho frm = new Frm_NhapKho();
            if ((Application.OpenForms["Frm_NhapKho"] as Frm_NhapKho) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_NhapKho();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_XuatKho frm = new Frm_XuatKho();
            if ((Application.OpenForms["Frm_XuatKho"] as Frm_XuatKho) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_XuatKho();
                frm.MdiParent = this;
                frm.Show();
            }
          
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_XuatNhapKho frm = new Frm_XuatNhapKho();
            if ((Application.OpenForms["Frm_XuatNhapKho"] as Frm_XuatNhapKho) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_XuatNhapKho();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void navBarItem25_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmKHDB frm = new FrmKHDB();
            if ((Application.OpenForms["FrmKHDB"] as FrmKHDB) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new FrmKHDB();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem26_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_Excel frm = new Frm_Excel();
            if ((Application.OpenForms["FrmKHDB"] as Frm_Excel) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new Frm_Excel();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void FrmMain1_Load(object sender, EventArgs e)
        {

        }

        private void navBarItem29_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tinhcuoc.FrmBangGia frm = new tinhcuoc.FrmBangGia();
            if ((Application.OpenForms["FrmBangGia"] as tinhcuoc.FrmBangGia) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new tinhcuoc.FrmBangGia();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            congcu.FrmTraHBOnline frm = new congcu.FrmTraHBOnline();
            if ((Application.OpenForms["FrmTraHBOnline"] as tinhcuoc.FrmBangGia) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new congcu.FrmTraHBOnline();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem28_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            congcu.FrmChiPhiNT frm = new congcu.FrmChiPhiNT();
            if ((Application.OpenForms["FrmChiPhiNT"] as tinhcuoc.FrmBangGia) != null)
            {
                frm.Focus();
            }
            else
            {
                frm = new congcu.FrmChiPhiNT();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}