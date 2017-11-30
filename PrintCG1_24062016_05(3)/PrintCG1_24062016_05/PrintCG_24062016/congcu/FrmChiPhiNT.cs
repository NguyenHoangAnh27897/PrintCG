using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

                        bool flag = true; 
                        string existmailer = string.Empty;
                        for (int i = 0; i <= myGrid1.RowCount - 1; i++ )
                        {

                            existmailer = myGrid1.Rows[i].Cells[0].Value == null ? string.Empty : myGrid1.Rows[i].Cells[0].Value.ToString();

                            if (e.FormattedValue.ToString() == existmailer)
                            {
                                  flag = false;
                                  break;
                            }
                           
                        }
                        if(flag == true){
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
                                myGrid1.CurrentRow.Cells["pptt"].Value = item.PriceService;
                                myGrid1.CurrentRow.Cells["ppnt"].Value = item.CPNT;
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
                    District(DataCollection, matinh);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
                else
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.None;
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
                    sophieu = myGrid1.Rows[i].Cells["MailerID"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["MailerID"].Value.ToString();
                    if(sophieu != "" || sophieu != string.Empty)
                    {
                        khach = myGrid1.Rows[i].Cells["SenderName"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["SenderName"].Value.ToString();
                        noiden = myGrid1.Rows[i].Cells["PronviceID"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["PronviceID"].Value.ToString();
                        tinh = myGrid1.Rows[i].Cells["tinh"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["tinh"].Value.ToString();
                        ctvphat = myGrid1.Rows[i].Cells["Description"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["Description"].Value.ToString();
                        cptt = double.Parse(myGrid1.Rows[i].Cells["pptt"].Value.ToString());
                        cuocchinh = double.Parse(myGrid1.Rows[i].Cells["Price"].Value.ToString());
                        cpnt = double.Parse(myGrid1.Rows[i].Cells["ppnt"].Value.ToString());
                        ngaynhan = DateTime.Parse(myGrid1.Rows[i].Cells["AcceptDate"].Value.ToString());
                        trongluong = double.Parse(myGrid1.Rows[i].Cells["Weight"].Value.ToString());
                        bcgoc = myGrid1.Rows[i].Cells["PostOfficeIDAccept"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["PostOfficeIDAccept"].Value.ToString();
                        quanhuyen = myGrid1.Rows[i].Cells["DistrictID"].Value == null ? string.Empty : myGrid1.Rows[i].Cells["DistrictID"].Value.ToString();
                        phuphi = double.Parse(myGrid1.Rows[i].Cells["PriceService"].Value.ToString());
                        var insert = sgpservice.insertSGP_ChiPhi(ctvphat, dtpngaynhap.Value, sophieu, trongluong, "", noiden, cptt, cpnt, bcgoc, khach, cuocchinh, phuphi, quanhuyen, ngaynhan, noiden, FrmMain1.postofficeid);
                    }
                    
                }              
            }
            catch
            {
                MessageBox.Show("Thông tin nhập chưa chính xác");
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if(cmbloctheo.SelectedIndex ==0 && cmbloctheo.Text !="")
            {
                dataGridView1.DataSource = sgpservice.getCPNT(dtpfromdate.Value,dtptodate.Value,0,FrmMain1.postofficeid);
                txttotal.Text = dataGridView1.RowCount == null ? string.Empty : dataGridView1.RowCount.ToString();
            }
            else if (cmbloctheo.SelectedIndex == 1 && cmbloctheo.Text != "")
            {
                dataGridView1.DataSource = sgpservice.getCPNT(dtpfromdate.Value, dtptodate.Value, 0,FrmMain1.postofficeid);
                txttotal.Text = dataGridView1.RowCount == null ? string.Empty : dataGridView1.RowCount.ToString();
            }
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            Excel.Application obj = new Excel.Application();
            Excel.Workbook wbook;

            fsave.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                wbook = obj.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;

                // truyen data
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    wbook.Worksheets.Add();
                    //createdate = DateTime.Parse(dt.Rows[k][0].ToString());

                    //dat ten sheet
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        obj.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                obj.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                }


                wbook.SaveAs(fsave.FileName);
                MessageBox.Show("Save Success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Type Path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
