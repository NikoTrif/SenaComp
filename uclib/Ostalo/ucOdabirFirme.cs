using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iflib;

namespace uclib.Ostalo
{
    public partial class ucOdabirFirme : UserControl
    {
        clFunkcijeRazno fnr = new clFunkcijeRazno();

        public ucOdabirFirme()
        {
            InitializeComponent();
        }

        private void ucOdabirFirme_Load(object sender, EventArgs e)
        {
            firmeTableAdapter.Fill(dbSenaCompDataSet.Firme);
        }

        private void dPretraga_Click(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "Sve":
                    firmeTableAdapter.qPretString(dbSenaCompDataSet.Firme, tbPretraga.Text, tbPretraga.Text, tbPretraga.Text, tbPretraga.Text,
                        tbPretraga.Text, tbPretraga.Text, tbPretraga.Text);
                    break;
                case "ID":
                    try
                    {
                        firmeTableAdapter.qPretID(dbSenaCompDataSet.Firme, Int32.Parse(tbPretraga.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void dOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (firmeDataGridView.SelectedRows != null)
                {
                    clTransfer.IDFirme = firmeDataGridView.CurrentRow.Cells[0].Value.ToString();
                    clTransfer.Firma = firmeDataGridView.CurrentRow.Cells[1].Value.ToString();
                    clTransfer.Kontakt = firmeDataGridView.CurrentRow.Cells[5].Value.ToString();
                    clTransfer.eMail = firmeDataGridView.CurrentRow.Cells[6].Value.ToString();

                    ParentForm.Close();
                }
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void firmeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dOK.PerformClick();
        }
    }
}
