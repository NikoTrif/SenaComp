using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uclib.Opcije
{
    public partial class ucKlauzula : UserControl
    {
        public ucKlauzula()
        {
            InitializeComponent();
        }

        private void dApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
