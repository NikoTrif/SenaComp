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
using System.Data.SqlClient;

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
                    if (sfd.ShowDialog() == DialogResult.OK && lokacijaBaze != "")
                    {
                        switch (sfd.FilterIndex)
                        {
                            case 1:
                                if (File.Exists(lokacijaBaze))
                                {
                                    File.Copy(lokacijaBaze, sfd.FileName); 
                                }
                                break;
                            case 2:
                                using (dbSenaCompDataSet dsSenaComp = new dbSenaCompDataSet())
                                {
                                    using (var tArtikliPFO = new dbSenaCompDataSetTableAdapters.ArtikliPFOTableAdapter())
                                    using (var tArtikli = new dbSenaCompDataSetTableAdapters.ArtikliTableAdapter())
                                    using (var tFakture = new dbSenaCompDataSetTableAdapters.FaktureTableAdapter())
                                    using (var tFirme = new dbSenaCompDataSetTableAdapters.FirmeTableAdapter())
                                    using (var tNaloziF = new dbSenaCompDataSetTableAdapters.NaloziFTableAdapter())
                                    using (var tNaloziP = new dbSenaCompDataSetTableAdapters.NaloziPTableAdapter())
                                    using (var tOtpremnice = new dbSenaCompDataSetTableAdapters.OtpremniceTableAdapter())
                                    using (var tProfakture = new dbSenaCompDataSetTableAdapters.ProfaktureTableAdapter())
                                    {
                                        tArtikliPFO.Fill(dsSenaComp.ArtikliPFO);
                                        tArtikli.Fill(dsSenaComp.Artikli);
                                        tFakture.Fill(dsSenaComp.Fakture);
                                        tFirme.Fill(dsSenaComp.Firme);
                                        tNaloziF.Fill(dsSenaComp.NaloziF);
                                        tNaloziP.Fill(dsSenaComp.NaloziP);
                                        tOtpremnice.Fill(dsSenaComp.Otpremnice);
                                        tProfakture.Fill(dsSenaComp.Profakture);
                                    }

                                    tlpBackup.Visible = true;
                                    OfficeIE.Excel.ExportToExcel("SenaComp", false, sfd.FileName, dsSenaComp, pbBackup, labBackup);
                                    tlpBackup.Visible = false;
                                }
                                break;
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
                        switch (ofd.FilterIndex)
                        {
                            case 1:
                                File.Copy(ofd.FileName, lokacijaBaze, true);
                                break;
                            case 2:
                                using (dbSenaCompDataSet ds = new dbSenaCompDataSet())
                                {
                                    labBackup.Visible = false;
                                    tlpBackup.Visible = true;
                                    dbSenaCompDataSetTableAdapters.ArtikliPFOTableAdapter apfo = new dbSenaCompDataSetTableAdapters.ArtikliPFOTableAdapter();
                                    OfficeIE.Excel.ImportFromExcel(ds, apfo.Connection.ConnectionString/*promeniti*/,
                                        ofd.FileName, pbBackup, labBackup);
                                    tlpBackup.Visible = false;
                                    labBackup.Visible = true;
                                    apfo.Dispose();
                                }
                                break;
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Jednom obrisana baza se ne može povratiti ako nije urađen backup!\nDa li ste sigurni da želite da obrišete bazu podataka?",
                        "Brisanje Baze? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbSenaCompConnectionString)) //promeni po potrebi
                    using (SqlCommand comm = new SqlCommand("", conn))
                    using (dbSenaCompDataSet ds = new dbSenaCompDataSet())
                    {
                        conn.Open();
                        foreach (DataTable tb in ds.Tables)
                        {
                            comm.CommandText = $"TRUNCATE TABLE {tb.TableName}";
                            comm.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
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
