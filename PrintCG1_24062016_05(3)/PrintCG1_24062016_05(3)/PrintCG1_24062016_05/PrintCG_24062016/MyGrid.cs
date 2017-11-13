using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCG_24062016
{
    public partial class MyGrid : DataGridView
    {
        public MyGrid()
        {
            InitializeComponent();
        }

        public MyGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                base.ProcessTabKey(Keys.Tab);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                base.ProcessTabKey(Keys.Tab);
                return true;
            }
            return base.ProcessDataGridViewKey(e);
        }

    }
}
