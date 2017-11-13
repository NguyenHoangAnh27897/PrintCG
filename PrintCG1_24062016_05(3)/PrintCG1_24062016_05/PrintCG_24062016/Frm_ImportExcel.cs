using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel = Microsoft.Office.Interop.Excel;

namespace PrintCG_24062016
{
    public partial class Frm_ImportExcel : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ImportExcel()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "(All Files)|*.*|(All Files Excel)|*.xlsx";
            fopen.ShowDialog();
            string path = fopen.FileName;
            Excel.Application obj = new Excel.Application();
            Excel.Workbook wbook = obj.Workbooks.Open(path);
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)wbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;
            DataTable dt = new DataTable();
            if (fopen.FileName != "")
            {
                obj.Columns.ColumnWidth = 25;
                for (int i = 0; i < xlWorksheet.UsedRange.Columns.Count; i++)
                {
                    dt.Rows.Add(xlRange);
                    //for (int j = 0; j < xlWorksheet.UsedRange.Rows.Count; j++)
                    //{
                    //    gvTable.DataSource = 
                    //}
                    gridTable.DataSource = dt;
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}