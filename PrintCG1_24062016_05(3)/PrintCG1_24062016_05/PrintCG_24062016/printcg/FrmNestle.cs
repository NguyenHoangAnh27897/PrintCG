using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.IO;
namespace PrintCG_24062016.printcg
{
    public partial class FrmNestle : Form
    {
        string excelfile = string.Empty;
        SGPService.SGPServiceClient sv = new SGPService.SGPServiceClient();
        public FrmNestle()
        {
            InitializeComponent();
        }
        private void load_settings()
        {
            txtbcchapnhan.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmnestle.txtbcchapnhan", string.Empty);
            txtnvchapnhan.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmnestle.txtnvchapnhan", string.Empty);
            txtnguoigui.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmnestle.txtnguoigui", string.Empty);
            txtdiachigui.Text = (String)Application.UserAppDataRegistry.GetValue("printcg.frmnestle.txtdiachigui", string.Empty);
        }

        private void save_settings()
        {
            Application.UserAppDataRegistry.SetValue("printcg.frmnestle.txtbcchapnhan", txtbcchapnhan.Text);
            Application.UserAppDataRegistry.SetValue("printcg.frmnestle.txtnvchapnhan", txtnvchapnhan.Text);
            Application.UserAppDataRegistry.SetValue("printcg.frmnestle.txtnguoigui", txtnguoigui.Text);
            Application.UserAppDataRegistry.SetValue("printcg.frmnestle.txtdiachigui", txtdiachigui.Text);
        }
        private void FrmNestle_Load(object sender, EventArgs e)
        {
            load_settings();
        }

        private void FrmNestle_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            excelfile = openFileDialog1.FileName;
            //lblfile.Text = excelfile;
            //lay ra sheetname
            using (var package = new ExcelPackage(new FileInfo(excelfile)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                lblfile.Text = "Cột/dòng :" +  colCount.ToString() + "/" + rowCount.ToString();
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            try
            {
                string post = txtbcchapnhan.Text.Trim();
                string customerid = string.Empty;
                string servicetypeid = string.Empty;
                int pricematrixtype = 1;
                string pricetype = "N";
                float weight = 0;
                float realweight = 0;
                float fnweight = 0;
                double? price = 0;
                float priceservice = 0;
                string priceserviceid = string.Empty;
                int distance = 0;
                string provinceid = string.Empty;
                string documentdate = string.Empty;
                string zoneid = string.Empty;
                string pricematrixid = string.Empty;
               // float rowindex = 0;
                using (var pck = new OfficeOpenXml.ExcelPackage())
                {
                    using (var stream = File.OpenRead(excelfile))
                    {
                        pck.Load(stream);
                    }
                    var ws = pck.Workbook.Worksheets[1];

                    var start = ws.Dimension.Start;
                    var end = ws.Dimension.End;
                    object cellvalue = string.Empty;
                    for (int row = start.Row + 1; row <= end.Row; row++)
                    { // Row by row...
                        documentdate = ws.Cells[row,0].Text;
                        provinceid = ws.Cells[row, 8].Text;
                        servicetypeid = ws.Cells[row, 4].Text;
                        weight = float.Parse( ws.Cells[row, 6].Text);
                        realweight =  float.Parse( ws.Cells[row, 7].Text);
                        distance =int.Parse( sv.getMM_Distances_procGetById(post, provinceid).Distance);
                        var pricematrix = sv.getMM_PriceMatrix_procGetPriceData(documentdate, post, servicetypeid, customerid, provinceid, distance, pricematrixtype, pricetype, zoneid);
                        var list = sv.getMM_PriceMatrix_procGetPriceDataDEtails(documentdate, post, servicetypeid, customerid, provinceid, distance, pricematrixtype, pricetype, zoneid).ToList();
                        pricematrixid = pricematrix.PriceMatrixID;
                        if(weight>= realweight )
                        {
                            fnweight = weight;
                        }else if(realweight> weight)
                        {
                            fnweight = realweight;
                        }
                        if(fnweight <= 2000)
                        {
                            price = list.Single(p => p.RangeWeightFrom >= fnweight && p.RangeWeightTo <= fnweight).Price;
                        }else
                        {

                        }
                        
                    }
                }
            }catch
            {

            }
        }
    }
}
