using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uclib.Nalozi
{
    public partial class ucPoslovni : UserControl
    {
        public ucPoslovni()
        {
            InitializeComponent();
        }

        private void naloziFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.naloziFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSenaCompDataSet);

        }
    }
}
