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
        Dictionary<string, bool> unos = new Dictionary<string, bool>();

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
                uslugaCheckBox.Checked = false;
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
                if (tbPretraga.Text != "")
                {
                    string pretraga = tbPretraga.Text;

                    switch (cbFilter.SelectedIndex)
                    {
                        case 0:
                            try
                            {
                                artikliTableAdapter.qFilterSifra(dbSenaCompDataSet.Artikli, int.Parse(pretraga));
                            }
                            catch (Exception ex)
                            {
                                fnr.NapisiLog(ex);
                            }
                            break;
                        case 1:
                            artikliTableAdapter.qFilterNaziv(dbSenaCompDataSet.Artikli, pretraga);
                            break;
                        case 2:
                            try
                            {
                                artikliTableAdapter.qFilterUsluga(dbSenaCompDataSet.Artikli, unos[pretraga.ToLower()]);
                            }
                            catch (Exception ex)
                            {
                                fnr.NapisiLog(ex);
                            }
                            break;
                    }
                }
                else
                {
                    try
                    {
                        artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);
                    }
                    catch(Exception ex)
                    {
                        fnr.NapisiLog(ex);
                    }
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

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFilter.SelectedIndex == 2)
                {
                    unos.Add("da", true);
                    unos.Add("ne", false);
                    unos.Add("usluga", true);
                    unos.Add("roba", false);
                    unos.Add("u", true);
                    unos.Add("r", false);
                    unos.Add("true", true);
                    unos.Add("false", false);
                }
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dIzracunaj_Click(object sender, EventArgs e)
        {
            double rabat;
            double marza;
            double pdv;

            try
            {
                double.TryParse(tbKalkNabavnaCena.Text, out clFunkcijeRazno.KalkulatorCenaArt.NabavnaCena);
                double.TryParse(tbKalkRabat.Text, out rabat);
                clFunkcijeRazno.KalkulatorCenaArt.Rabat = rabat / 100;
                double.TryParse(tbKalkMarza.Text, out marza);
                clFunkcijeRazno.KalkulatorCenaArt.Marza = marza / 100 + 1;
                double.TryParse(tbKalkCenaBezPDV.Text, out clFunkcijeRazno.KalkulatorCenaArt.CenaBezPDV);
                double.TryParse(tbKalkPDV.Text, out pdv);
                clFunkcijeRazno.KalkulatorCenaArt.PDV = pdv / 100 + 1;
                double.TryParse(tbKalkProdajnaCena.Text, out clFunkcijeRazno.KalkulatorCenaArt.ProdajnaCena);

                //Console.WriteLine(fnr.KalkulatorCene());
                fnr.KalkulatorCene();
                tbKalkCenaBezPDV.Text = clFunkcijeRazno.KalkulatorCenaArt.CenaBezPDV.ToString();
                tbKalkProdajnaCena.Text = clFunkcijeRazno.KalkulatorCenaArt.ProdajnaCena.ToString();
                tbKalkMarza.Text = clFunkcijeRazno.KalkulatorCenaArt.Marza.ToString();
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }

        private void dCE_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control tb in tableLayoutPanel3.Controls)
                {
                    if (tb is TextBox)
                    {
                        (tb as TextBox).Clear();
                        clFunkcijeRazno.KalkulatorCenaArt.CenaBezPDV = 0;
                        clFunkcijeRazno.KalkulatorCenaArt.Marza = 0;
                        clFunkcijeRazno.KalkulatorCenaArt.NabavnaCena = 0;
                        clFunkcijeRazno.KalkulatorCenaArt.PDV = 0;
                        clFunkcijeRazno.KalkulatorCenaArt.ProdajnaCena = 0;
                        clFunkcijeRazno.KalkulatorCenaArt.Rabat = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                fnr.NapisiLog(ex);
            }
        }
    }
}
