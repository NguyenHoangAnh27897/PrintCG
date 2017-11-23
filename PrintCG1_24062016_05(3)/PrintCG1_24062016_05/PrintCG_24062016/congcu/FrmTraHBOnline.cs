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
    public partial class FrmTraHBOnline : Form
    {
        PrintCG_24062016.SGPService.SGPServiceClient sgpservice;
        public FrmTraHBOnline()
        {
            InitializeComponent();
            sgpservice = new PrintCG_24062016.SGPService.SGPServiceClient();
        }

        private void FrmTraHBOnline_Load(object sender, EventArgs e)
        {
            var userprofile = sgpservice.getUserTrackingProfile("");
            foreach(var item in userprofile)
            {
                this.datagridview2.Rows.Add(item.IsCheck,item.Columnname,item.ColumnID);
                if (item.IsCheck == 1)
                {
                    DataGridView1.Columns.Add(item.ColumnID, item.Columnname);
                }
            }          
        }
        private void CopyDataGridViewToClipboard(DataGridView dgv)
        {
            DataGridView1.Columns[0].Visible = false;
            DataGridView1.Columns[1].Visible = false;
            string s = "";
            DataGridViewColumn oCurrentCol = default(DataGridViewColumn);
            //Get header
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            do
            {
                s += oCurrentCol.HeaderText + Convert.ToChar(Keys.Tab);
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
            } while (!(oCurrentCol == null));
            s = s.Substring(0, s.Length - 1);
            s += Environment.NewLine;
            //Get rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                do
                {
                    if (row.Cells[oCurrentCol.Index].Value != null)
                    {
                        s += row.Cells[oCurrentCol.Index].Value.ToString();
                    }
                    s += Convert.ToChar(Keys.Tab);
                    oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                } while (!(oCurrentCol == null));
                s = s.Substring(0, s.Length - 1);
                s += Environment.NewLine;
            }
            //Put to clipboard
            DataObject o = new DataObject();
            o.SetText(s);
            Clipboard.SetDataObject(o, true);
        }
        public static DataTable ConvertToDataTable<T>(IList<T> list)
        {
            var dt = new DataTable();
            var properties = typeof(T).GetProperties();

            foreach (var pi in properties)
                try
                {
                    dt.Columns.Add(pi.Name, pi.PropertyType);
                }catch
                {
                    dt.Columns.Add(pi.Name, typeof(System.DateTime));
                }
                

            foreach (T element in list)
            {
                var row = dt.NewRow();
                foreach (var pi in properties)
                    row[pi.Name] = pi.GetValue(element, null);
                dt.Rows.Add(row);
            }
            return dt;
        }
        private void tracu()
        {

            for (int i = 0; i <= DataGridView1.Rows.Count - 2; i++)
            {
                var trackinginfo = sgpservice.ToolTracking( DataGridView1.Rows[i].Cells["MailerID"].Value.ToString());
                //test
                DataTable dt = ConvertToDataTable(trackinginfo);
                                                         
                               for (int c = 0; c <= dt.Rows.Count -1 ; c++)
                               {
                                   for (int b = 1; b <= DataGridView1.Columns.Count - 1; b++)
                                   {
                                       for (int d = 0; d <= dt.Columns.Count - 1; d++)
                                       {
                                           string columnnane = dt.Columns[d].ColumnName;
                                           int indexch = 0;
                                           if(b<4)
                                           {                                            
                                               try
                                               {
                                                   columnnane = columnnane.Remove(0, columnnane.IndexOf("_") + 1);
                                               }
                                               catch { }
                                               try
                                               {
                                                   columnnane = columnnane.Remove(0, columnnane.IndexOf("_") + 1);
                                               }
                                               catch { }
                                           } else
                                           {
                                               int idx = 0;
                                               int sc = 0;
                                               foreach (char ch in columnnane)
                                               {
                                                  
                                                   if (ch.ToString() == "_")
                                                   {
                                                       sc += 1;
                                                   }
                                                   idx++;
                                                   if(sc== 2)
                                                   {
                                                       break;
                                                   }
                                               }
                                               try
                                               {
                                                   if(columnnane.Contains("_"))
                                                   {
                                                       StringBuilder sb = new StringBuilder(columnnane);
                                                       sb[idx - 1] = '.';
                                                       columnnane = sb.ToString();
                                                   }
                                                   
                                               }
                                               catch {  }
                                               
                                           }
                                           string headername = DataGridView1.Columns[b].Name;
                                           if (columnnane == headername)
                                           {
                                               DataGridView1.Rows[i].Cells[b].Value = dt.Rows[c][d];
                                               break;
                                           }
                                       }
                                   }
                               }
                         
                    //test                              
            }
        }
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                try
                {
                    string s = Clipboard.GetText();
                    string[] lines = s.Split('\n');
                    int tong = 0;
                    int iFail = 0, iRow = DataGridView1.CurrentCell.RowIndex;
                    int iCol = DataGridView1.CurrentCell.ColumnIndex;
                    DataGridViewCell oCell;
                    foreach (string line in lines)
                    {
                        tong += 1;
                        //string item = line.Split('\r');
                        this.DataGridView1.Rows.Add(line.Replace("\r", ""));                                                                                              
                        if (iFail > 0)
                            MessageBox.Show(string.Format("{0} updates failed due" +
                                            " to read only column setting", iFail));
                    }
                    txttong.Text = (tong -1).ToString(); ;
                }
                catch (FormatException)
                {
                    MessageBox.Show("The data you pasted is in the wrong format for the cell");
                    return;
                }
            }
        }

        private void FrmTraHBOnline_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            tracu();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDataGridViewToClipboard(DataGridView1);
            MessageBox.Show("Hoàn tất");
        }

        private void datagridview2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridview2.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void datagridview2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           try
           {
               if (datagridview2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1")
               {
                   //do something
                   bool flag = false;
                   for (int i = 0; i <= DataGridView1.ColumnCount - 1;i++ )
                   {
                       if (DataGridView1.Columns[i].HeaderText == datagridview2.Rows[e.RowIndex].Cells[1].Value.ToString())
                       {
                           flag = true;
                           break;
                       }                                             
                   }
                   if (flag == false)
                   {
                       DataGridView1.Columns.Add(datagridview2.Rows[e.RowIndex].Cells[2].Value.ToString(), datagridview2.Rows[e.RowIndex].Cells[1].Value.ToString());
                   }
                       
               }
               else if (datagridview2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "0")
               {
                   //do something
                   try
                   {
                       DataGridView1.Columns.Remove(datagridview2.Rows[e.RowIndex].Cells[2].Value.ToString());
                   }catch{}
                   
               }
           }catch
           {

           }
                
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView1.Visible == false)
                {
                    DataGridView1.Columns["MailerID"].Visible = true;
                }
                else if (DataGridView1.Visible == true)
                {
                    DataGridView1.Columns["MailerID"].Visible = true;
                }
                DataGridView1.Rows.Clear();

            }
            catch (Exception ex)
            {
            }
        }

    }
}
