using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uclib.Baze
{
    public partial class ucFirme : UserControl
    {
        public ucFirme()
        {
            InitializeComponent();
        }

        private void ucFirme_Load(object sender, EventArgs e)
        {
            firmeTableAdapter.Fill(dbSenaCompDataSet.Firme);
        }

        private void firmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSenaCompDataSet);

        }
    }
}
