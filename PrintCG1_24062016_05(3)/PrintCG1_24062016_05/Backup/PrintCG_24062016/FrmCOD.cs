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
    public partial class FrmCOD : Form
    {
        public FrmCOD()
        {
            InitializeComponent();
        }
        string path;
        private void btnchonfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lblfile.Text = openFileDialog1.FileName;
            path = openFileDialog1.FileName;
        }
    }
}
