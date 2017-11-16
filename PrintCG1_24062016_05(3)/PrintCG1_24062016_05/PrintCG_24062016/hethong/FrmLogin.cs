using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PrintCG_24062016
{
    public partial class FrmLogin : Form
    {
       // PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmLogin()
        {
            InitializeComponent();
            //sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {

               // flag = sgpservice.login(txtuser.Text.Trim(), txtpass.Text.Trim(), txtpost.Text.Trim());
                flag = true;
                if (flag == false)
                {
                    MessageBox.Show("Check login info");
                }
                else
                {
                    save_settings();
                    PrintCG_24062016.FrmMain1 frm = new PrintCG_24062016.FrmMain1();
                    frm.Sender(txtuser.Text, txtpost.Text);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bool flag = false;
                try
                {
                   // flag = sgpservice.login(txtuser.Text.Trim(), txtpass.Text.Trim(), txtpost.Text.Trim());
                    flag = true;
                    if (flag == false)
                    {
                        MessageBox.Show("Check login info");
                    }
                    else
                    {
                        save_settings();
                        PrintCG_24062016.FrmMain1 frm = new PrintCG_24062016.FrmMain1();
                        frm.Sender(txtuser.Text, txtpost.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                }
                
                catch
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        private void load_settings()
        {
            txtuser.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtuser", string.Empty);
            txtpost.Text = (String)Application.UserAppDataRegistry.GetValue("sony.frmlogin.txtpost", string.Empty);
        }

        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("sony.frmlogin.txtuser", txtuser.Text);
            Application.UserAppDataRegistry.SetValue("sony.frmlogin.txtpost", txtpost.Text);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bool flag = false;
                try
                {
                   // flag = sgpservice.login(txtuser.Text.Trim(), txtpass.Text.Trim(), txtpost.Text.Trim());
                    flag = true;
                    if (flag == false)
                    {
                        MessageBox.Show("Check login info");
                    }
                    else
                    {
                        save_settings();
                        PrintCG_24062016.FrmMain1 frm = new PrintCG_24062016.FrmMain1();
                        frm.Sender(txtuser.Text, txtpost.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                }

                catch
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
        }
    }
}
