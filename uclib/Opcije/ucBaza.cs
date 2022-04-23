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
        bool ucLoaded = false;
        string copySource = "";

        public ucBaza()
        {
            InitializeComponent();

            label2.DataBindings.Add("Enabled", rbServer, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //Lokacija baze:
            tbLokacija.DataBindings.Add("ReadOnly", rbLokalna, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            dBrowse.DataBindings.Add("Enabled", rbServer, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            cbAutoAzuriranje.DataBindings.Add("Enabled", rbServer, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);

            label6.DataBindings.Add("Enabled", cbAutoBackup, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //Sačuvaj svakih
            tbDani.DataBindings.Add("Enabled", cbAutoBackup, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            label7.DataBindings.Add("Enabled", cbAutoBackup, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //dana.
            label3.DataBindings.Add("Enabled", cbAutoBackup, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //Putanja Backup-a:
            tbBackupPath.DataBindings.Add("Enabled", cbAutoBackup, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            dBackupPathBrowse.DataBindings.Add("Enabled", cbAutoBackup,"Checked", true, DataSourceUpdateMode.OnPropertyChanged);

            label4.DataBindings.Add("Enabled", cbAutoAzuriranje, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //Putanja Backup-a:
            tbMinuti.DataBindings.Add("Enabled", cbAutoAzuriranje, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            label5.DataBindings.Add("Enabled", cbAutoAzuriranje, "Checked", true, DataSourceUpdateMode.OnPropertyChanged); //minuta.            
        }

        private void ucBaza_Load(object sender, EventArgs e)
        {
            ucLoaded = true;
        }

        private void rbLokalna_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucLoaded == true)
                {
                    if (rbLokalna.Checked)
                    {
                        tbLokacija.Text = cGlobalVariables.localDB;
                        cbAutoAzuriranje.Checked = false;
                    }
                    else /*(rbServer.Checked)*/
                    {
                        switch (MessageBox.Show("Da li se baza podataka čuva na ovom računaru?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    if (fbd.ShowDialog() == DialogResult.OK)
                                    {
                                        if (File.Exists($@"{fbd.SelectedPath}\dbSenaComp.mdf"))
                                        {
                                            tbLokacija.Text = $@"{fbd.SelectedPath}\dbSenaComp.mdf";
                                        }
                                        else
                                        {
                                            if (File.Exists(cGlobalVariables.localDB))
                                            {
                                                //File.Copy(cGlobalVariables.localDB, $@"{fbd.SelectedPath}\dbSenaComp.mdf");
                                                copySource = cGlobalVariables.localDB;
                                                tbLokacija.Text = $@"{fbd.SelectedPath}\dbSenaComp.mdf";
                                            }
                                            else
                                            {
                                                //File.Copy(cGlobalVariables.zeroDB, $@"{fbd.SelectedPath}\dbSenaComp.mdf");
                                                copySource = cGlobalVariables.zeroDB;
                                                tbLokacija.Text = $@"{fbd.SelectedPath}\dbSenaComp.mdf";
                                            }
                                        }
                                        rbServer.Checked = true;
                                    }
                                }
                                break;
                            case DialogResult.No:
                                using (var fbd = new FolderBrowserDialog())
                                {
                                    if (fbd.ShowDialog() == DialogResult.OK)
                                    {
                                        if (File.Exists($@"{fbd.SelectedPath}\dbSenaComp.mdf"))
                                        {
                                            tbLokacija.Text = $@"{fbd.SelectedPath}\dbSenaComp.mdf";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Na ovoj lokaciji ne postoji baza podataka!", "Baza nije pronađena!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            rbLokalna.Checked = true;
                                        }
                                    }
                                    else
                                    {
                                        rbLokalna.Checked = true;
                                    }
                                }
                                break;
                            case DialogResult.Cancel:
                                rbLokalna.Checked = true;
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

        private void cbAutoAzuriranje_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //cbAutoAzuriranjeBind();
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
                //cbAutoBackupBind();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
        
        private void tbMinuti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
                    lokacijaBaze = cGlobalVariables.localDB;
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
                    lokacijaBaze = cGlobalVariables.localDB;
                }
                else
                {
                    lokacijaBaze = tbLokacija.Text;
                }

                using (OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Microsoft Data Base | *.mdf | Excel | *.xls",
                    InitialDirectory = tbLokacija.Text
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
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
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={lokacija};Password=Master1!";
            
            //G 17
            try
            {
                int vreme = 0;
                int.TryParse(tbMinuti.Text, out vreme);
                Properties.Settings.Default.BazaAutoUpdateVreme = vreme;

                int.TryParse(tbDani.Text, out vreme);
                Properties.Settings.Default.BazaAutoBackupVreme = vreme;

                //if (rbServer.Checked)
                //{
                //    //Properties.Settings.Default["dbSenaCompConnectionString"] = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={tbLokacija.Text};Password=Master1!";
                //}
                //else
                //{
                //    //Properties.Settings.Default["dbSenaCompConnectionString"] = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={localDB};Password=Master1!";
                //}

                if (rbLokalna.Checked)
                {
                    if (!File.Exists(cGlobalVariables.localDB))
                    {
                        File.Copy(cGlobalVariables.zeroDB, cGlobalVariables.localDB);
                    }
                    connString = connString.Replace("{lokacija}", cGlobalVariables.localDB);
                }
                else
                {
                    if(copySource != "")
                    {
                        File.Copy(copySource, tbLokacija.Text);
                    }
                    connString = connString.Replace("{lokacija}", tbLokacija.Text);
                }

                //pokusaj cuvanja config fajla
                Console.WriteLine($"ConnectionString: {connString}");
                conStringManager helper = new conStringManager(connString);
                if (helper.isConnected)
                {
                    Console.WriteLine("***Connection established!***");
                    AppSetting setting = new AppSetting();
                    Console.WriteLine(setting.GetConnectionString("SenaComp.Properties.Settings.dbSenaCompConnectionString"));
                    setting.SaveConnectionString("SenaComp.Properties.Settings.dbSenaCompConnectionString", connString);
                }

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
    }
}
