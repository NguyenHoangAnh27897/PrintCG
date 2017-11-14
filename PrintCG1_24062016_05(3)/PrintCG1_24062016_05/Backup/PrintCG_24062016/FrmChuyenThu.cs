using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PrintCG_24062016
{
    public partial class FrmChuyenThu : Form
    {
        public FrmChuyenThu()
        {
            InitializeComponent();
        }

        private void txtmailerid_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean flag = false;
            string socg = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //kiem tra neu so phieu da quet roi
                    
                    foreach (DataGridViewRow item1 in this.dataGridView2.Rows)
                    {
                        try
                        {
                            socg = item1.Cells["MailerID"].Value.ToString().Trim();
                        }
                        catch (Exception ex)
                        {
                            socg = "";
                        }

                        if (socg.ToUpper() == txtmailerid.Text.Trim().ToUpper())
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        DataSet ds = new DataSet();
                        OleDbConnection conn = new OleDbConnection();
                        string con = "Provider=SQLOLEDB;Data Source=10.0.10.10;Initial Catalog=PMSSGP_200911;User ID=sa;Password=pm$$gp@26102010@";
                        //string con = "Provider=SQLOLEDB;Data Source=10.0.10.10;Initial Catalog=PMS-TEST;User ID=sa;Password=pm$$gp@26102010@";
                        conn.ConnectionString = con;
                        conn.Open();
                        string query = "select MailerID,Quantity,Weight,RealWeight,RecieverProvinceID,MailerDescription from MM_Mailers where MailerID = '" + txtmailerid.Text + "' and CurrentPostOfficeID ='KV02' and CurrentStatusID in(0,4,13)";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        int a = ds.Tables[0].Rows.Count;
                        string[] row = new string[] { ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString() };
                        conn.Close();
                        dataGridView2.Rows.Add(row);
                        txtmailerid.SelectAll();
                        txtquantity.Text = "0";
                        txtweight.Text = "0";
                        txttotalmailer.Text = "0";
                        txttotalmailer.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();
                        //cong so phieu
                        foreach (DataGridViewRow item in this.dataGridView2.Rows)
                        {
                            try
                            {
                                txtquantity.Text = (int.Parse(txtquantity.Text) + int.Parse(item.Cells["Quantity"].Value.ToString().Trim())).ToString();
                                txtweight.Text = (int.Parse(txtweight.Text) + int.Parse(item.Cells["Weight"].Value.ToString())).ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy phiếu gửi");
                    txtmailerid.SelectAll();
                }

            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            string cg = string.Empty;
            string flag = string.Empty;
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            if (e.KeyCode == Keys.Delete)
            {
                //kiem tra neu ton tai thi xoa trong db
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    if (txtdocumentid.Text.Trim() != "")
                    {
                        cg = item.Cells["MailerID"].Value.ToString();
                        flag = ct.SGP_DeleteMailerDeliveryDetail(txtdocumentid.Text.Trim(), cg);
                    }                  
                    dataGridView2.Rows.RemoveAt(item.Index);
                }
                dataGridView2.Refresh();
                txttotalmailer.Text = (int.Parse(dataGridView2.Rows.Count.ToString()) - 1).ToString();
                //cong so phieu
                txtquantity.Text = "0";
                txtweight.Text = "0";
                foreach (DataGridViewRow item in this.dataGridView2.Rows)
                {
                    try
                    {
                        txtquantity.Text = (int.Parse(txtquantity.Text) + int.Parse(item.Cells["Quantity"].Value.ToString().Trim())).ToString();
                        txtweight.Text = (int.Parse(txtweight.Text) + int.Parse(item.Cells["Weight"].Value.ToString())).ToString();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                flag = ct.UpdateMailerDelivery(txtdocumentid.Text.Trim(), int.Parse(txttotalmailer.Text), int.Parse(txtquantity.Text), double.Parse(txtweight.Text), double.Parse(txtnumberpackge.Text), "CTHO");
                
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string flag = string.Empty;
            string socg = string.Empty;
            string notes = string.Empty;
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            if (txtdocumentid.Text.Trim() != "" && cmbempoyeeid.Text.Trim() != "")
            {
                try
                {

                    string DocumentID = string.Empty;
                    DocumentID = ct.SGP_MailerDeliveryInsert(txtdocumentid.Text.Trim(), txtbuucuc.Text.Trim(), cmbempoyeeid.Text, txtdescription.Text, int.Parse(txtnumberpackge.Text), "CTHO", double.Parse(txttotalmailer.Text), double.Parse(txtquantity.Text), double.Parse(txtweight.Text));

                    if (DocumentID != "")
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            try
                            {
                                socg = row.Cells["MailerID"].Value.ToString().Trim();
                            }
                            catch (Exception ex)
                            {
                            }

                            try
                            {
                                notes = row.Cells["Description"].Value.ToString().Trim();
                            }
                            catch (Exception ex)
                            {
                            }

                            if (socg != "")
                            {
                                flag = ct.InsertMailerDeliveryDetail(DocumentID, socg, notes);
                                flag = ct.InsertHistory(socg, "KV04", DocumentID, "CTHO", 10);
                            }
                        }
                        dataGridView2.Rows.Clear();
                        txtdocumentid.Text = "";
                        cmbempoyeeid.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    //truong hop bao da co chung tu ton tai se bo sung vao bang ke
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            try
                            {
                                socg = row.Cells["MailerID"].Value.ToString().Trim();
                            }
                            catch (Exception ex1)
                            {
                            }

                            try
                            {
                                notes = row.Cells["Description"].Value.ToString().Trim();
                            }
                            catch (Exception ex1)
                            {
                            }

                            if (socg != "")
                            {
                                try
                                {
                                    //update lai bang chung tu
                                    flag = ct.UpdateMailerDelivery(txtdocumentid.Text.Trim(), int.Parse(txttotalmailer.Text), int.Parse(txtquantity.Text),double.Parse( txtweight.Text),double.Parse( txtnumberpackge.Text), "CTHO");
                                    flag = ct.InsertMailerDeliveryDetail(txtdocumentid.Text.Trim(), socg, notes);
                                    flag = ct.InsertHistory(socg, "KV04", txtdocumentid.Text.Trim(), "CTHO", 10);
                                }
                                catch (Exception ex1)
                                {

                                }
                            }
                        }
                        dataGridView2.Rows.Clear();
                        txtdocumentid.Text = "";
                        cmbempoyeeid.Text = "";
                    }
                    catch (Exception ex1)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa khai báo số chứng từ và nhân viên.");
            }
        }

        private void cmbempoyeeid_Enter(object sender, EventArgs e)
        {
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            if (txtbuucuc.Text != "")
            {
                cmbempoyeeid.DataSource = ct.GetEmployees(txtbuucuc.Text.Trim()).Tables[0];
                cmbempoyeeid.ValueMember = "EmployeeID";
                cmbempoyeeid.ValueMember = "EmployeeID";
            }
        }

        private void FrmChuyenThu_Load(object sender, EventArgs e)
        {

        }

        private void btnmaxid_Click(object sender, EventArgs e)
        {
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            txtdocumentid.Text = ct.SGP_MaxMailerDeliveryDocumentID();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            //xem cac chuyen thu da dong cho KV04 va trang thai da chuyen CG3 chua
            load_mailerdelivery();
            timer1.Interval = 300000;//5 minutes
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
            
        }
        private void load_mailerdelivery()
        {
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            string fromdate = dtpfromdate.Value.ToString("yyyy-MM-dd");
            string todate = dtptodate.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = ct.GetMailerDelivery(txtbuucuc.Text, fromdate, todate).Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmailerid.Enabled = true;
            btnluu.Enabled = true;
            ChuyenThu.Service1SoapClient ct = new PrintCG_24062016.ChuyenThu.Service1SoapClient();
            string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            string docit = dataGridView1.Rows[e.RowIndex].Cells["DocumentID"].Value.ToString();
            DataSet ds = new DataSet();
            ds = ct.GetMailerDeliveryDetails(docit);
            dataGridView2.Rows.Clear();
            txtdocumentid.Text = docit;
            cmbempoyeeid.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
            txttotalmailer.Text = dataGridView1.Rows[e.RowIndex].Cells["MailerCount"].Value.ToString();
            txtquantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txtweight.Text = dataGridView1.Rows[e.RowIndex].Cells["Weight"].Value.ToString();
            txtnumberpackge.Text = dataGridView1.Rows[e.RowIndex].Cells["NumberOfPackage"].Value.ToString();
            txtdescription.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            if (status != "0")
            {
                txtmailerid.Enabled = false;
                btnluu.Enabled = false;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                //string[] rowcg8 = new string[] { row["MailerID"].ToString(), row["Quantity"].ToString(), row["Weight"].ToString(), row["RealWeight"].ToString(), row["ReceiveProvinceID"].ToString(), row["MailerDescription"].ToString() };
                string[] rowcg8 = new string[] { row["MailerID"].ToString(), row["Quantity"].ToString(), row["Weight"].ToString(), row["RealWeight"].ToString(), row["ReceiveProvinceID"].ToString(), row["MailerDescription"].ToString() };
                dataGridView2.Rows.Add(rowcg8);
                tabControl1.SelectedTab = tabthaotac;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_mailerdelivery();
        }

    }
}
