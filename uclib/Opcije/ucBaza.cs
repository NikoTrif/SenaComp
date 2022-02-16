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
using System.IO;

namespace uclib.Opcije
{
    public partial class ucBaza : UserControl
    {
        public ucBaza()
        {
            InitializeComponent();
        }

        private void ucBaza_Load(object sender, EventArgs e)
        {
            try
            {
                rbLokalna_CheckedChanged(null, EventArgs.Empty);
                cbAutoAzuriranje_CheckedChanged(null, EventArgs.Empty);
                cbAutoBackup_CheckedChanged(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void rbLokalna_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Enabled = !rbLokalna.Checked; //Lokacija:
                tbLokacija.ReadOnly = rbLokalna.Checked;
                dBrowse.Enabled = !rbLokalna.Checked;
                cbAutoAzuriranje.Enabled = !rbLokalna.Checked;

                if (rbLokalna.Checked)
                {
                    tbLokacija.Text = ""; //ovde upisati default lokaciju lokalne baze
                    cbAutoAzuriranje.Checked = false;
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void cbAutoAzuriranje_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label4.Enabled = cbAutoAzuriranje.Checked; //Ažuriraj Bazu svakih
                tbMinuti.Enabled = cbAutoAzuriranje.Checked;
                label5.Enabled = cbAutoAzuriranje.Checked; //minuta.
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void cbAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label6.Enabled = cbAutoBackup.Checked; //Sačuvaj svakih
                tbDani.ReadOnly = !cbAutoBackup.Checked;
                label7.Enabled = cbAutoBackup.Checked; //dana.
                label3.Enabled = cbAutoBackup.Checked; //Putanja Backup-a:
                tbBackupPath.ReadOnly = !cbAutoBackup.Checked;
                dBackupPathBrowse.Enabled = cbAutoBackup.Checked;
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void tbMinuti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Microsoft Data Base | *.mdf",
                    InitialDirectory = tbLokacija.Text
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        tbLokacija.Text = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dBazaHelp_Click(object sender, EventArgs e)
        {

        }

        private void dBackupPathBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        tbBackupPath.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            string lokacijaBaze = "";
            try
            {
                if (rbLokalna.Checked)
                {
                    //promeni po potrebi
                    lokacijaBaze = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Sena\SenaComp\dbSenaComp.mdf";
                }
                else
                {
                    lokacijaBaze = tbLokacija.Text;
                }

                using (SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Microsoft Data Base | *.mdf | Excel | *.xls",
                    InitialDirectory = tbLokacija.Text
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK/* && lokacijaBaze != ""*/)
                    {
                        if (sfd.FilterIndex == 1)
                        {
                            File.Copy(lokacijaBaze, sfd.FileName);
                        }
                        else
                        {
                            object[] dtParam = { null, null, null, null, null, null, null, null };
                            int i = 0;
                            foreach(DataTable dt in dbSenaCompDataSet1.Tables)
                            {
                                dtParametri dtp = new dtParametri();
                                dtp.ConnectionString = naloziPTableAdapter1.Connection.ConnectionString;
                                dtp.DataTableName = dt.TableName;

                                switch (dt.TableName)
                                {
                                    case "Artikli":
                                        dtp.StoredProcedure = @"SELECT Sifra, Naziv, jedinicaMere, Usluga, PDV, 
                                                                prodajnaCena, Cena, IznosPDV 
                                                                FROM Artikli";
                                        break;
                                    case "ArtikliPFO":
                                        dtp.StoredProcedure = @"SELECT Id, Tabela, Artikal, Kolicina, Cena, ukupnaCena 
                                                                FROM dbo.ArtikliPFO";
                                        break;
                                    case "Faktura":
                                        dtp.StoredProcedure = @"SELECT Id, Tabela, Artikal, Kolicina, Cena, ukupnaCena 
                                                                FROM dbo.ArtikliPFO";
                                        break;
                                    case "Firme":
                                        dtp.StoredProcedure = @"SELECT ID, Naziv, PIB, Grad, UlicaBroj, Kontakt, eMail, 
                                                                tekuciRacun, maticniBroj FROM Firme";
                                        break;
                                    case "NaloziF":
                                        dtp.StoredProcedure = @"SELECT brojNaloga, Datum, IDFirme, Firma, kontaktOsoba, 
                                                                Kontakt, eMail, Uredjaj, Proizvodjac, Model, serijskiBroj, 
                                                                Oprema, opisKvara, Izvestaj, cenaDelovi, cenaServisa, 
                                                                ukupnaCena, Status, naCekanju, Zavrseno, korisnikOdustao, 
                                                                servisOdustao, korisnikOdbioPlacanje, Napomena 
                                                                FROM NaloziF";
                                        break;
                                    case "NaloziP":
                                        dtp.StoredProcedure = @"SELECT brojNaloga, Datum, imePrezime, Kontakt, eMail, Uredjaj, Proizvodjac, 
                                                                Model, serijskiBroj, Oprema, opisKvara, Izvestaj, cenaDelova, cenaServis, 
                                                                ukupnaCena, Status, naCekanju, Zavrseno, korisnikOdustao, servisOdustao, 
                                                                korisnikOdbioPlacanje, Napomena
                                                                FROM     NaloziP";
                                        break;
                                    case "Otpremnice":
                                        dtp.StoredProcedure = @"SELECT redniBroj, datum, datProf, datFakt, racun, adresaMagacina, 
                                                                imeOL, brojLKOL, regVozilaOL, nazivPR, adresaPR, pibPR, matBrojPR, 
                                                                adresaIsporPR, imePR, brojLKPR, ukupnaCena 
                                                                FROM dbo.Otpremnice";
                                        break;
                                    case "Profakture":
                                        dtp.StoredProcedure = @"SELECT redniBroj, Datum, Valuta, Status, datumIsplate, 
                                                                IDKlijenta, Klijent, PIB, matBroj, Adresa, Grad, Roba, 
                                                                Ukupno, Klauzule
                                                                FROM Profakture";
                                        break;
                                    default:
                                        dtp.StoredProcedure = "";
                                        break;
                                }
                                dtParam[i] = dtp;
                                i++;
                            }
                            ExcelIE.ExportXLS(dtParam, "Celija", "ServisDB", true, pbBackup, sfd.FileName);
                            //ovako od prilike treba da izgleda samo sada treba urediti ExportXLS bazu da radi foreach za dtParam
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dVrati_Click(object sender, EventArgs e)
        {
            string lokacijaBaze = "";
            try
            {
                if (rbLokalna.Checked)
                {
                    //promeni po potrebi
                    lokacijaBaze = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Sena\SenaComp\dbSenaComp.mdf";
                }
                else
                {
                    lokacijaBaze = tbLokacija.Text;
                }

                using(OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Microsoft Data Base | *.mdf | Excel | *.xls",
                    InitialDirectory = tbLokacija.Text
                })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(ofd.FileName, lokacijaBaze, true);
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dNovaBaza_Click(object sender, EventArgs e)
        {

        }

        private void dObrisi_Click(object sender, EventArgs e)
        {

        }

        private void dApply_Click(object sender, EventArgs e)
        {
            try
            {
                int vreme = 0;
                int.TryParse(tbMinuti.Text, out vreme);
                Properties.Settings.Default.BazaAutoUpdateVreme = vreme;

                int.TryParse(tbDani.Text, out vreme);
                Properties.Settings.Default.BazaAutoBackupVreme = vreme;

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
    }
}
