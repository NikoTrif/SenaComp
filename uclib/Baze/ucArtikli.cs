using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iflib;

namespace uclib.Baze
{
    public partial class ucArtikli : UserControl
    {
        clFunkcijeRazno fnr = new clFunkcijeRazno();
        public ucArtikli()
        {
            InitializeComponent();
        }

        private void ucArtikli_Load(object sender, EventArgs e)
        {
            try
            {
                artikliTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);
                cbFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            try
            {
                artikliBindingSource.AddNew();
                sifraTextBox.Select();
            }
            catch(Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            try
            {
                artikliBindingSource.CancelEdit();
                ResetID();
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                artikliBindingSource.EndEdit();
                artikliTableAdapter.Update(dbSenaCompDataSet.Artikli);
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj artikal?", "Brisanje artikla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                artikliBindingSource.RemoveCurrent();
            }
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPretraga.Text != null)
                {

                }
                else
                {

                }
            }
        }

        private void ResetID()
        {
            dbSenaCompDataSet.Clear();
            dbSenaCompDataSet.Artikli.SifraColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.Artikli.SifraColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.Artikli.SifraColumn.AutoIncrementSeed = 1;
            dbSenaCompDataSet.Artikli.SifraColumn.AutoIncrementSeed = 1;
            artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);
        }
    }
}
