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

        private void dIzmeni_Click(object sender, EventArgs e)
        {
            Izmene(true);
        }

        public void Izmene(bool dozvolaIzmene)
        {
            if (dozvolaIzmene == true)
            {
                dIzmeni.Visible = false;
                dOK.Visible = false;
                dSacuvaj.Visible = true;
                dOtkazi.Visible = true;
                dObrisi.Visible = true;
                rtbNapomena.ReadOnly = false;
            }
            else
            {
                dIzmeni.Visible = true;
                dOK.Visible = true;
                dSacuvaj.Visible = false;
                dOtkazi.Visible = false;
                dObrisi.Visible = false;
                rtbNapomena.ReadOnly = true;
            }
        }

        private void dOK_Click(object sender, EventArgs e)
        {

        }
    }
}
