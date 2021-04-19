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

        private void ucPoslovni_Load(object sender, EventArgs e)
        {
            try
            {
                naloziFDataGridView.CurrentCell = naloziFDataGridView.Rows[naloziFDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e
            }
            catch /*(Exception ex)*/
            {
                
            }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            naloziFBindingSource.AddNew();
            naCekanjuRadioButton.Select();
            datumDateTimePicker.Value = DateTime.Now;
            firmaTextBox.Select();
            resetBrojNalogaTextBoxReadOnly();

        }

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            naloziFBindingSource.CancelEdit();

            // G 6 - Vraca autoincrement na odgovarajuci broj, ali se i cela baza resetuje, treba proveriti brzinu vracanja kada je baza puna
            dbSenaCompDataSet.Clear();
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = 1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = 1;

            naloziFTableAdapter.Fill(dbSenaCompDataSet.NaloziF);
            naloziFDataGridView.CurrentCell = naloziFDataGridView.Rows[naloziFDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e

            resetBrojNalogaTextBoxReadOnly();
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            Validate();
            naloziFBindingSource.EndEdit();
            naloziFTableAdapter.Update(dbSenaCompDataSet.NaloziF);
        }

        private void dStampaj_Click(object sender, EventArgs e)
        {

        }
        private void dObrisi_Click(object sender, EventArgs e)
        {

        }

        private void resetBrojNalogaTextBoxReadOnly()
        {
            if (brojNalogaTextBox.ReadOnly == false)
            {
                brojNalogaTextBox.ReadOnly = true;
                //izmeniBrojNalogaToolStripMenuItem.Checked = false;
            }
        }

        private void dFOdabir_Click(object sender, EventArgs e)
        {
            using(Ostalo.ucOdabirFirme of = new Ostalo.ucOdabirFirme())
            {
                using (fRazno fr = new fRazno
                {
                    Size = new Size(of.Width + 6, of.Height + 40),
                    FormBorderStyle = FormBorderStyle.FixedDialog
                })
                {
                    fr.pRazno.Controls.Clear();
                    fr.pRazno.Controls.Add(of);
                    of.Dock = DockStyle.Fill;
                    //fr.ShowDialog();
                    if(fr.ShowDialog() == DialogResult.OK)
                    {
                        firmaTextBox.Text = iflib.clTransfer.Firma;
                        kontaktTextBox.Text = iflib.clTransfer.Kontakt;
                        eMailTextBox.Text = iflib.clTransfer.eMail;
                        kontaktOsobaTextBox.Select();

                        //ciscenje clTransfera
                        iflib.clTransfer.Firma = null;
                        iflib.clTransfer.Kontakt = null;
                        iflib.clTransfer.eMail = null;
                    }
                }
            }
        }
    }
}
