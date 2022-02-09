using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uclib
{
    public partial class fRazno : Form
    {
        public fRazno()
        {
            InitializeComponent();
        }

        private void fRazno_Load(object sender, EventArgs e)
        {

        }

        private void fRazno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Text == "Podešavanja")
            {
                Properties.Settings.Default.Reload();
            }
        }
    }
}
