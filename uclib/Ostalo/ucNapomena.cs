using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uclib.Ostalo
{
    public partial class ucNapomena : UserControl
    {
        public ucNapomena()
        {
            InitializeComponent();
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            rtbNapomena.Clear();
            dSacuvaj.PerformClick();
        }
    }
}
