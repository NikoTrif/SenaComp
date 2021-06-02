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
    public partial class ucProfakture : UserControl
    {
        public ucProfakture()
        {
            InitializeComponent();
        }

        private void profaktureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profaktureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSenaCompDataSet);

        }
    }
}
