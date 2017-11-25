using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016.congcu
{
    public partial class FrmChiPhiNT : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmChiPhiNT()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }
        public void District(AutoCompleteStringCollection col,string ProvinceID)
        {
            try
            {
                var district = sgpservice.getDisitrct(ProvinceID);
                foreach (var item in district)
                {
                    col.Add(item.DistrictID);
                }
            }catch
            {

            }
           
        }
        private void myGrid1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                string headerText = myGrid1.Columns[e.ColumnIndex].HeaderText;

                if (headerText.Equals("Số CG"))
                {

                        bool flag = false; 
                        string existmailer = string.Empty;
                       
                        for (int i = 0; i <= myGrid1.RowCount - 1; i++ )
                        {
                            try
                            {
                                existmailer = myGrid1.Rows[i].Cells[0].Value.ToString();
                            }
                            catch { 
                            }

                            if (e.FormattedValue.ToString() == existmailer)
                            {
                                  flag = true;
                                  break;
                            }
                           
                        }

                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || (flag == true))
                        {
                            myGrid1.Rows[e.RowIndex].ErrorText = "CG đã tồn tại";
                            myGrid1.CurrentCell.Value = "";
                            e.Cancel = true;
                        }
                        else
                        {
                            e.Cancel = false;
                            //string mailerid = myGrid1.CurrentRow.Cells["MailerID"].Value.ToString();
                            string mailerid = e.FormattedValue.ToString();
                            var mailer = sgpservice.getMailer(mailerid);
                            foreach (var item in mailer)
                            {
                                myGrid1.CurrentRow.Cells["SenderName"].Value = item.SenderName;
                                myGrid1.CurrentRow.Cells["PronviceID"].Value = item.ProvinceID;
                                myGrid1.CurrentRow.Cells["tinh"].Value = item.ProvinceID;
                                myGrid1.CurrentRow.Cells["Description"].Value = item.Description;
                                myGrid1.CurrentRow.Cells["PriceService"].Value = item.PriceService;
                                myGrid1.CurrentRow.Cells["Price"].Value = item.Price;
                                myGrid1.CurrentRow.Cells["AcceptDate"].Value = item.AcceptDate;
                                myGrid1.CurrentRow.Cells["Weight"].Value = item.Weight;
                                myGrid1.CurrentRow.Cells["PostOfficeIDAccept"].Value = item.PostOfficeAcceptID;

                            }
                        }                                          
                } 
            }catch
            {

            }
            
        }

        private void myGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                string titleText = myGrid1.Columns[myGrid1.CurrentCell.ColumnIndex].HeaderText;
                string colname = myGrid1.Columns[myGrid1.CurrentCell.ColumnIndex].Name;
                string matinh = myGrid1.CurrentRow.Cells["tinh"].Value.ToString();
                TextBox autoText = e.Control as TextBox;
                ComboBox combo = e.Control as ComboBox;
                if (titleText.Equals("Huyện"))
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    //autoText.AutoCompleteSource = AutoCompleteSource.ListItems;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    District(DataCollection,matinh);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
            }catch
            { 
            }
        }

        private void FrmChiPhiNT_Load(object sender, EventArgs e)
        {
            txtbuucuc.Text = FrmMain1.postofficeid;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string noiden = null;
                double cptt = 0;
                double cpnt = 0;
                double phuphi = 0;
                double cuocchinh = 0;
                string ctvphat = null;
                DateTime ngay;
                string sophieu = null;
                double trongluong = 0;
                string loaihang = null;
                string bcgoc = null;
                string khach = null;
                string ngaynhap = null;
                string quanhuyen = null;
                DateTime ngaynhan = DateTime.Now;
                string tinh = null;
                for (int i = 0; i <= myGrid1.RowCount - 1; i++)
                {
                    khach = myGrid1.CurrentRow.Cells["SenderName"].Value.ToString();
                    noiden = myGrid1.CurrentRow.Cells["PronviceID"].Value.ToString();
                    tinh = myGrid1.CurrentRow.Cells["tinh"].Value.ToString();
                    ctvphat = myGrid1.CurrentRow.Cells["Description"].Value.ToString();
                    cptt= double.Parse(myGrid1.CurrentRow.Cells["cptt"].Value.ToString());
                    cuocchinh = double.Parse(myGrid1.CurrentRow.Cells["Price"].Value.ToString());
                    cpnt = double.Parse(myGrid1.CurrentRow.Cells["cpnt"].Value.ToString());
                    ngaynhan = DateTime.Parse(myGrid1.CurrentRow.Cells["AcceptDate"].Value.ToString());
                    trongluong =double.Parse( myGrid1.CurrentRow.Cells["Weight"].Value.ToString());
                    bcgoc = myGrid1.CurrentRow.Cells["PostOfficeIDAccept"].Value.ToString();
                    quanhuyen = myGrid1.CurrentRow.Cells["DistrictID"].Value.ToString();
                    sophieu = myGrid1.CurrentRow.Cells["MailerID"].Value.ToString();
                    phuphi = double.Parse(myGrid1.CurrentRow.Cells["PriceService"].Value.ToString());
                }
                var insert = sgpservice.insertSGP_ChiPhi(ctvphat,dtpngaynhap.Value,sophieu,trongluong,"",noiden,cptt,cpnt,bcgoc,khach,cuocchinh,phuphi,quanhuyen,ngaynhan,noiden,bcgoc);
            }
            catch
            {

            }
        }

    }
}
