using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace uclib.Opcije.Osnovno
{
    public partial class ucUredjaji : UserControl
    {
        Nalozi.ucPrivatni np = new Nalozi.ucPrivatni();
        public ucUredjaji()
        {
            InitializeComponent();
        }

        private void ucUredjaji_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Uredjaji == null)
            {
                Properties.Settings.Default.Uredjaji = new StringCollection();
            }
            else
            {
                lbUredjaji.Items.AddRange(Properties.Settings.Default.Uredjaji.Cast<string>().ToArray());
            }

            if(Properties.Settings.Default.Proizvodjaci == null)
            {
                Properties.Settings.Default.Proizvodjaci = new StringCollection();
            }
            else
            {
                lbProizvodjaci.Items.AddRange(Properties.Settings.Default.Proizvodjaci.Cast<string>().ToArray());
            }
        }

        private void dApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Uredjaji = new StringCollection();
            Properties.Settings.Default.Proizvodjaci = new StringCollection();

            Properties.Settings.Default.Uredjaji.AddRange(lbUredjaji.Items.Cast<string>().ToArray());
            Properties.Settings.Default.Proizvodjaci.AddRange(lbProizvodjaci.Items.Cast<string>().ToArray());

            Properties.Settings.Default.Save();
        }

        private void dUrDodaj_Click(object sender, EventArgs e)
        {
            if(tbUredjaj.Text != string.Empty)
            {
                lbUredjaji.Items.Add(tbUredjaj.Text);
                tbUredjaj.Clear();
                tbUredjaj.Select();
            }
        }

        private void dUrObrisi_Click(object sender, EventArgs e)
        {
            if(lbUredjaji.SelectedItems != null)
            {
                lbUredjaji.Items.Remove(lbUredjaji.SelectedItem);
            }
        }

        private void tbUredjaj_KeyDown(object sender, KeyEventArgs e)
        {
            if(tbUredjaj.Text != string.Empty)
            {
                if(e.KeyCode == Keys.Add)
                {
                    dUrDodaj_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void tbUredjaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void lbUredjaji_KeyDown(object sender, KeyEventArgs e)
        {
            if(lbUredjaji.SelectedItem != null)
            {
                if(e.KeyCode == Keys.Delete)
                {
                    dUrObrisi_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void dPrDodaj_Click(object sender, EventArgs e)
        {
            if(tbProizvodjac.Text != string.Empty)
            {
                lbProizvodjaci.Items.Add(tbProizvodjac.Text);
                tbProizvodjac.Clear();
                tbProizvodjac.Select();
            }
        }

        private void dPrObrisi_Click(object sender, EventArgs e)
        {
            if(lbProizvodjaci.SelectedItem != null)
            {
                lbProizvodjaci.Items.Remove(lbProizvodjaci.SelectedItem);
            }
        }

        private void tbProizvodjac_KeyDown(object sender, KeyEventArgs e)
        {
            if(tbProizvodjac.Text != string.Empty)
            {
                if(e.KeyCode == Keys.Add)
                {
                    dPrDodaj_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void tbProizvodjac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void lbProizvodjaci_KeyDown(object sender, KeyEventArgs e)
        {
            if(lbProizvodjaci.SelectedItem != null)
            {
                if(e.KeyCode == Keys.Delete)
                {
                    dPrObrisi_Click(sender, EventArgs.Empty);
                }
            }
        }
    }
}
