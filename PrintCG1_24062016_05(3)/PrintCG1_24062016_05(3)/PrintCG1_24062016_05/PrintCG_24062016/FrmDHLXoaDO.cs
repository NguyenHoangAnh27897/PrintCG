using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;
namespace PrintCG_24062016
{
    public partial class FrmDHLXoaDO : Form
    {
        public FrmDHLXoaDO()
        {
            InitializeComponent();
        }
        public static string type = string.Empty;
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                char[] rowSplitter = { '\r', '\n' };
                char[] columnSplitter = { '\t' };
                //get the text from clipboard
                IDataObject dataInClipboard = Clipboard.GetDataObject();
                string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);
                //split it into lines
                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);
                //get the row and column of selected cell in grid
                int r = dataGridView1.SelectedCells[0].RowIndex;
                int c = dataGridView1.SelectedCells[0].ColumnIndex;
                //add rows into grid to fit clipboard lines
                if (dataGridView1.Rows.Count < (r + rowsInClipboard.Length))
                {
                    dataGridView1.Rows.Add(r + rowsInClipboard.Length - dataGridView1.Rows.Count);
                }
                // loop through the lines, split them into cells and place the values in the corresponding cell.
                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
                {
                    //split row into cell values
                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);
                    //cycle through cell values
                    for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                    {
                        //assign cell value, only if it within columns of the grid
                        if (dataGridView1.ColumnCount - 1 >= c + iCol)
                        {
                            dataGridView1.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];
                        }
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
            string DO = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DO = row.Cells["DO"].Value.ToString();
                if (DO != "")
                {
                    DataTable dt = new DataTable();
                    OleDbConnection conn = new OleDbConnection();
                    string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\PrintCG.mdb";
                    conn.ConnectionString = con;
                    OleDbCommand comm = new OleDbCommand();
                    conn.Open();
                    if (type == "D")
                    {
                        comm.CommandText = "delete * from tb_dhlplan where [D/O] ='" + DO + "'";
                    }
                    else if (type == "S")
                    {
                        comm.CommandText = "delete * from tb_sonyplan where [DO] ='" + DO + "'";
                    }
                    comm.Connection = conn;
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = comm;
                    da.Fill(dt);                   
                    conn.Close();
                }
            }
                    MessageBox.Show("Đã xóa");
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmDHLXoaDO_Load(object sender, EventArgs e)
        {
            
        }

    }
}
