using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uclib.Racuni
{
    public partial class ucFakture : UserControl
    {
        public ucFakture()
        {
            InitializeComponent();
        }

        private void faktureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.faktureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSenaCompDataSet);

        }
    }
}
