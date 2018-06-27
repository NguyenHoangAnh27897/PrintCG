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
    public partial class FrmBCSLMsYen : Form
    {
        public FrmBCSLMsYen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            int check = 0;
            if (cmbdata.SelectedIndex == 0)
            {
                check = 0;
            }
            else if (cmbdata.SelectedIndex == 1)
            {
                check = 1;
            }

            BaoCaoSLMsYen.Service1Client sv = new BaoCaoSLMsYen.Service1Client();

            string cs;
            cs = sv.connectionString(check);
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();

            string fromdate = txttungay.Value.ToString("yyyy-MM-dd");
            string todate = txtdenngay.Value.ToString("yyyy-MM-dd");
            if (cbbdate.SelectedIndex == 0)
            {
                ds1 = sv.baocaotuanDT(cs, txtbc.Text, fromdate, todate);
            }else if(cbbdate.SelectedIndex == 1){
                ds1 = sv.baocaotuan(cs, txtbc.Text, fromdate, todate);
            }

            bcgiaoban.DataSource = ds1.Tables[0];
            //bcgiaoban.Columns[0].Width = 35;
            //bcgiaoban.Columns[1].Width = 70;

            DataSet ds = new DataSet();
            if(cbbdate.SelectedIndex == 0){
                ds = sv.baocaotuantongDT(cs, txtbc.Text, fromdate, todate);
            }else if(cbbdate.SelectedIndex == 1){  
                ds = sv.baocaotuantong(cs, txtbc.Text, fromdate, todate);
            }

            txtdsgb.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            txtdtgb.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BaoCaoSLMsYen.Service1Client sv = new BaoCaoSLMsYen.Service1Client();

            string fromdate = txttungay.Value.ToString("yyyy-MM-dd");
            string todate = txtdenngay.Value.ToString("yyyy-MM-dd");

            int check = 0;
            if (cmbdata.SelectedIndex == 0)
            {
                check = 0;
            }
            else if (cmbdata.SelectedIndex == 1)
            {
                check = 1;
            }
            string cs;
            cs = sv.connectionString(check);

            if (chkctv.Checked == true)
            {
                DataSet ds1 = new DataSet();
                if (cbbdate.SelectedIndex == 0)
                {
                    ds1 = sv.baocaothangctvDT(cs, fromdate, todate);
                }else if(cbbdate.SelectedIndex == 1){
                    ds1 = sv.baocaothangctv(cs, fromdate, todate);
                }

                bcthang.DataSource = ds1.Tables[0];

                DataSet ds = new DataSet();

                if (cbbdate.SelectedIndex == 0)
                {
                    ds = sv.baocaotuantongctvDT(cs, fromdate, todate);
                }else if (cbbdate.SelectedIndex == 1){                 
                    ds = sv.baocaotuantongctv(cs, fromdate, todate);
                }
                txttongtien.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                DataSet ds1 = new DataSet();
                if (cbbdate.SelectedIndex == 0)
                {
                    ds1 = sv.baocaothangDT(cs, txtbc.Text, fromdate, todate);
                }
                else if (cbbdate.SelectedIndex == 1)
                { 
                    ds1 = sv.baocaothang(cs, txtbc.Text, fromdate, todate);
                }

                bcthang.DataSource = ds1.Tables[0];

                DataSet ds = new DataSet();

                ds = sv.baocaotuantong(cs, txtbc.Text, fromdate, todate);
                txttongtien.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            }
        }
    }
}
