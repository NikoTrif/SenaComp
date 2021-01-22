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
using uclib.Nalozi;

namespace uclib.Opcije.Osnovno
{
    public partial class ucOprema : UserControl
    {
        public ucOprema()
        {
            InitializeComponent();
        }

        private void ucOprema_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Oprema == null)
                Properties.Settings.Default.Oprema = new StringCollection();
            else
                lbOprema.Items.AddRange(Properties.Settings.Default.Oprema.Cast<string>().ToArray());
        }

        private void dDodaj_Click(object sender, EventArgs e)
        {
            if (tbOprema.Text != string.Empty)
            {
                lbOprema.Items.Add(tbOprema.Text);
                tbOprema.Clear();
                tbOprema.Select(); 
            }
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            if (lbOprema.SelectedItems != null)
            {
                lbOprema.Items.Remove(lbOprema.SelectedItem); 
            }
        }

        private void dGore_Click(object sender, EventArgs e)
        {
            string stext; /* = lbOprema.SelectedItem.ToString();*/
            int sindex; /* = lbOprema.SelectedIndex - 1;*/
            if (lbOprema.SelectedItem != null)
            {
                stext = lbOprema.SelectedItem.ToString();
                sindex = lbOprema.SelectedIndex - 1;

                if (sindex >= 0)
                {
                    lbOprema.Items.Remove(lbOprema.SelectedItem);
                    lbOprema.Items.Insert(sindex, stext);
                    lbOprema.SelectedIndex = sindex;
                } 
            }
        }

        private void dDole_Click(object sender, EventArgs e)
        {

            string stext; /* = lbOprema.SelectedItem.ToString();*/
            int sindex; /* = lbOprema.SelectedIndex + 1;*/

            if (lbOprema.SelectedItem != null)
            {
                stext = lbOprema.SelectedItem.ToString();
                sindex = lbOprema.SelectedIndex + 1;

                if (sindex <= lbOprema.Items.Count - 1)
                {
                    lbOprema.Items.Remove(lbOprema.SelectedItem);
                    lbOprema.Items.Insert(sindex, stext);
                    lbOprema.SelectedIndex = sindex;
                } 
            }
        }

        private void dApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Oprema = new StringCollection();
            Properties.Settings.Default.Oprema.AddRange(lbOprema.Items.Cast<string>().ToArray());

            Properties.Settings.Default.Save();
        }

        private void tbOprema_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbOprema.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Add)
                {
                    dDodaj_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void tbOprema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void lbOprema_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                dObrisi_Click(sender, EventArgs.Empty);
            }
        }
    }
}
