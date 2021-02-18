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
    }
}
