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
                    if (sfd.ShowDialog() == DialogResult.OK/* && lokacijaBaze != ""*/)
                    {
                        if (sfd.FilterIndex == 1)
                        {
                            File.Copy(lokacijaBaze, sfd.FileName);
                        }
                        else
                        {
                            dbSenaCompDataSet dsSenaComp = new dbSenaCompDataSet();

                            using (var dta = new dbSenaCompDataSetTableAdapters.ArtikliPFOTableAdapter())
                            {
                                dta.Fill(dsSenaComp.ArtikliPFO);
                            }
                            //ako je moguce naci nacin da se ovo sprovede u jednom redu da kod bude citkiji

                            tlpBackup.Visible = true;
                            ExcelIE.ExportToExcel("SenaComp", true, sfd.FileName, dsSenaComp, pbBackup, labBackup);
                            tlpBackup.Visible = false;
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
