using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iflib;
using Microsoft.Reporting.WinForms;

namespace uclib.Nalozi
{
    public partial class ucPoslovni : UserControl
    {
        bool noviRed = false; //TD 2.1.c
        bool editTbOprema = false; //TD 2.1.c
        clFunkcijeRazno fnr = new clFunkcijeRazno();
        Timer tRefresh;

        public ucPoslovni()
        {
            InitializeComponent();

            try
            {
                if (Properties.Settings.Default.Uredjaji != null)
                {
                    uredjajComboBox.Items.AddRange(Properties.Settings.Default.Uredjaji.Cast<string>().ToArray());
                    uredjajComboBox.AutoCompleteCustomSource.AddRange(Properties.Settings.Default.Uredjaji.Cast<string>().ToArray());
                }
                if (Properties.Settings.Default.Proizvodjaci != null)
                {
                    proizvodjacComboBox.Items.AddRange(Properties.Settings.Default.Proizvodjaci.Cast<string>().ToArray());
                    proizvodjacComboBox.AutoCompleteCustomSource.AddRange(Properties.Settings.Default.Proizvodjaci.Cast<string>().ToArray());
                }
                if (Properties.Settings.Default.BazaAutoUpdate == true && Properties.Settings.Default.BazaAutoUpdateVreme > 0)
                {
                    tRefresh = new Timer();
                    tRefresh.Tick += TRefresh_Tick;
                    tRefresh.Interval = Properties.Settings.Default.BazaAutoUpdateVreme * 60000; //60.000 ms = 1min
                }
                //Console.WriteLine(Properties.Settings.Default.VremeDatumKolone);
                naloziFDataGridView.Columns[1].DefaultCellStyle.Format = Properties.Settings.Default.VremeDatumFormat;
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void TRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshDB();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void ucPoslovni_Load(object sender, EventArgs e)
        {
            try
            {
                //G 8
                //naloziFTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                //naloziFTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\dbSenaComp.mdf;Password=Master1!";
                if (Properties.Settings.Default.BazaServer)
                {
                    naloziFTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Properties.Settings.Default.BazaServerPath};Password=Master1!";
                    firmeTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Properties.Settings.Default.BazaServerPath};Password=Master1!";
                    dRefresh.Visible = true;
                }
                else
                {
                    naloziFTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={cGlobalVariables.localDB};Password=Master1!";
                    firmeTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={cGlobalVariables.localDB};Password=Master1!";
                    dRefresh.Visible = false;
                }
                naloziFTableAdapter.Fill(dbSenaCompDataSet.NaloziF);
                cbFilter.SelectedIndex = 0;
                try
                {
                    naloziFDataGridView.CurrentCell = naloziFDataGridView.Rows[naloziFDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e
                }
                catch { }
                try
                {
                    flpDodajKontrole();
                }
                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            naloziFBindingSource.AddNew();
            naCekanjuRadioButton.Select();
            datumDateTimePicker.Value = DateTime.Now;
            iDFirmeTextBox.Select();
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
            if (noviRed == false)
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovaj nalog?", "Izmena naloga", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cuvanje();
                } 
            }
            else
            {
                Cuvanje();
                noviRed = false;
            }

            resetBrojNalogaTextBoxReadOnly();
        }

        private void dStampaj_Click(object sender, EventArgs e)
        {
            try
            {
                resetBrojNalogaTextBoxReadOnly();

                ReportParameter[] para = (new iflib.clFunkcijeRazno.PisanjeReporta()).PostavkeReportParametara(
                    Properties.Settings.Default.Logo,
                    Properties.Settings.Default.NazivFirme,
                    Properties.Settings.Default.Delatnost,
                    Properties.Settings.Default.Adresa,
                    Properties.Settings.Default.Telefon,
                    Properties.Settings.Default.eMail,
                    Properties.Settings.Default.Klauzula);

                iflib.ReportClasses.clRadniNalogPos rcls = new iflib.ReportClasses.clRadniNalogPos()
                {
                    BrojNaloga = brojNalogaTextBox.Text,
                    IDFirme = iDFirmeTextBox.Text,
                    KontaktOsoba = kontaktOsobaTextBox.Text,
                    KontaktTelefon = kontaktTextBox.Text,
                    NazivFirme = firmaTextBox.Text,
                    eMail = eMailTextBox.Text,
                    Datum = datumDateTimePicker.Value.ToShortDateString(),
                    Uredjaj = uredjajComboBox.Text,
                    Proizvodjac = proizvodjacComboBox.Text,
                    Model = modelTextBox.Text,
                    SerijskiBroj = serijskiBrojTextBox.Text,
                    Pribor = opremaTextBox.Text,
                    OpisKvara = opisKvaraTextBox.Text,
                    Izvestaj = izvestajRichTextBox.Text
                };
                clRadniNalogPosBindingSource.Add(rcls);

                //G 11
                repViewPos.LocalReport.SetParameters(para);
                repViewPos.RefreshReport();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
        private void dObrisi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj nalog?", "Brisanje naloga", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                naloziFBindingSource.RemoveCurrent();

                naloziFTableAdapter.Update(dbSenaCompDataSet.NaloziF);

                //G 6
                dbSenaCompDataSet.Clear();
                dbSenaCompDataSet.NaloziF.brojNalogaColumn.AutoIncrementSeed = -1;
                dbSenaCompDataSet.NaloziF.brojNalogaColumn.AutoIncrementStep = -1;
                dbSenaCompDataSet.NaloziF.brojNalogaColumn.AutoIncrementSeed = 1;
                dbSenaCompDataSet.NaloziF.brojNalogaColumn.AutoIncrementStep = 1;
                naloziFTableAdapter.Fill(dbSenaCompDataSet.NaloziF);
            }
            resetBrojNalogaTextBoxReadOnly();
        }

        private void resetBrojNalogaTextBoxReadOnly()
        {
            if (brojNalogaTextBox.ReadOnly == false)
            {
                brojNalogaTextBox.ReadOnly = true;
                izmeniBrojNalogaToolStripMenuItem.Checked = false;
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
                        iDFirmeTextBox.Text = iflib.clTransfer.IDFirme;
                        firmaTextBox.Text = iflib.clTransfer.Firma;
                        kontaktTextBox.Text = iflib.clTransfer.Kontakt;
                        eMailTextBox.Text = iflib.clTransfer.eMail;
                        kontaktOsobaTextBox.Select();

                        //ciscenje clTransfera
                        clFunkcijeRazno.ClearTransfer();
                    }
                }
            }
        }

        private void noviBrojNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] nbn =
            {
                firmaTextBox.Text, //..........0
                kontaktOsobaTextBox.Text, //...1
                kontaktTextBox.Text, //........2
                eMailTextBox.Text, //..........3
                uredjajComboBox.Text, //.......4
                proizvodjacComboBox.Text, //...5
                modelTextBox.Text, //..........6
                serijskiBrojTextBox.Text, //...7
                opremaTextBox.Text //..........8
            };

            dNovi_Click(null, EventArgs.Empty);

            firmaTextBox.Text = nbn[0];
            kontaktOsobaTextBox.Text = nbn[1];
            kontaktTextBox.Text = nbn[2];
            eMailTextBox.Text = nbn[3];
            uredjajComboBox.Text = nbn[4];
            proizvodjacComboBox.Text = nbn[5];
            modelTextBox.Text = nbn[6];
            serijskiBrojTextBox.Text = nbn[7];
            opisKvaraTextBox.Text = nbn[8];

            opisKvaraTextBox.Select();
        }

        private void izmeniBrojNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brojNalogaTextBox.ReadOnly = !izmeniBrojNalogaToolStripMenuItem.Checked;
        }

        private void Cuvanje()
        {
            try
            {
                naloziFDataGridView.CurrentRow.Cells[14].Value = tableLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; //Status

                //G 2
                naloziFDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }

            try
            {
                Validate();
                naloziFBindingSource.EndEdit();
                naloziFTableAdapter.Update(dbSenaCompDataSet.NaloziF);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void naloziFDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                noviRed = clFunkcijeRazno.ProveraNoviRed(naloziFDataGridView.CurrentRow.Cells[2].Value.ToString());
            }
            catch { }
        }

        private void flpDodajKontrole()
        {
            if (Properties.Settings.Default.Oprema.Count != 0)
            {
                try
                {
                    foreach (string s in Properties.Settings.Default.Oprema)
                    {
                        CheckBox chkb = new CheckBox();
                        chkb.Name = "cb" + s;
                        chkb.Text = s;
                        flowLayoutPanel1.Controls.Add(chkb);

                        //TD 2.1.c
                        chkb.CheckedChanged += new EventHandler(FlowLayoutPanel1CheckBox_CheckedChanged);
                        chkb.MouseDown += new MouseEventHandler(FlowLayoutPanel1CheckBox_MouseDown);
                        chkb.KeyDown += new KeyEventHandler(flowLayoutPanel1CheckBox_KeyDown);
                    }
                }

                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);
                }
            }
        }

        private void flowLayoutPanel1CheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                editTbOprema = true;
            }
        }

        private void FlowLayoutPanel1CheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            editTbOprema = true;
        }

        private void FlowLayoutPanel1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editTbOprema == true)
            {
                opremaTextBox.Text = fnr.DodajUkloniOpremu(opremaTextBox.Text, sender as CheckBox);
            }

            editTbOprema = false;
        }

        private void repViewPos_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            try
            {
                repViewPos.PrintDialog();
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
            clRadniNalogPosBindingSource.Clear();
        }

        private void kontaktTextBox_Leave(object sender, EventArgs e)
        {
            kontaktTextBox.Text = fnr.FormatKontakt(kontaktTextBox.Text);
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            //TD 2.2.f
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPretraga.Text != "")
                {
                    string pretraga = tbPretraga.Text;

                    //TD 2.2.g
                    switch (cbFilter.SelectedIndex)
                    {
                        case 0:
                            naloziFTableAdapter.qFilterFirma(dbSenaCompDataSet.NaloziF, pretraga, pretraga, pretraga);
                            break;
                        case 1:
                            try
                            {
                                naloziFTableAdapter.qFilterIdFirme(dbSenaCompDataSet.NaloziF, int.Parse(pretraga));
                            }
                            catch (Exception ex)
                            {
                                clFunkcijeRazno.NapisiLog(ex);
                            }
                            break;
                        case 2:
                            try
                            {
                                naloziFTableAdapter.qFilterBrojNaloga(dbSenaCompDataSet.NaloziF, int.Parse(pretraga));
                            }
                            catch (Exception ex)
                            {
                                clFunkcijeRazno.NapisiLog(ex);
                            }
                            break;
                        case 3:
                            naloziFTableAdapter.qFilterUredjaj(dbSenaCompDataSet.NaloziF, pretraga, pretraga, pretraga, pretraga);
                            break;
                        case 4:
                            naloziFTableAdapter.qFilterKvar(dbSenaCompDataSet.NaloziF, pretraga, pretraga);
                            break;
                        case 5:
                            naloziFTableAdapter.qFilterStatus(dbSenaCompDataSet.NaloziF, pretraga);
                            break;
                    }
                }
            }
        }

        private void dProFakt_Click(object sender, EventArgs e)
        {
            cmsKorisnik.Show(MousePosition);
        }

        private void dRefresh_Click(object sender, EventArgs e)
        {
            RefreshDB();
            clFunkcijeRazno.TimerRestart(tRefresh);
        }

        private void iDFirmeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(iDFirmeTextBox.Text == "")
                {
                    dFOdabir_Click(null, EventArgs.Empty);
                }
                else
                {
                    int idf = 0;
                    int.TryParse(iDFirmeTextBox.Text, out idf);

                    if (idf > 0)
                    {
                        try
                        {
                            firmeTableAdapter.qPretID(dbSenaCompDataSet.Firme, idf);
                            DataTable dt = dbSenaCompDataSet.Firme;

                            if (dt.Rows.Count == 1)
                            {
                                DataRow r = dt.Rows[0];
                                firmaTextBox.Text = r[1].ToString();
                                kontaktTextBox.Text = r[5].ToString();
                                eMailTextBox.Text = r[6].ToString();
                                kontaktOsobaTextBox.Select();
                            }
                            else
                            {
                                MessageBox.Show($"Korisnik sa ID {iDFirmeTextBox.Text} nije pronađen.", "Greška!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                iDFirmeTextBox.SelectAll();
                            }
                            dt.Dispose();
                        }
                        catch (Exception ex)
                        {
                            clFunkcijeRazno.NapisiLog(ex);
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
            }
        }

        private void ucPoslovni_KeyPress(object sender, KeyPressEventArgs e)
        {
            clFunkcijeRazno.TimerRestart(tRefresh);
        }

        private void ucPoslovni_MouseMove(object sender, MouseEventArgs e)
        {
            clFunkcijeRazno.TimerRestart(tRefresh);
        }

        private void izvestajRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            clFunkcijeRazno.OgranicenjeRedovaRitchTexBoxa(izvestajRichTextBox, 6, e);
        }

        private void RefreshDB()
        {
            naloziFTableAdapter.Fill(dbSenaCompDataSet.NaloziF);
            if (naloziFDataGridView.RowCount != 0)
            {
                naloziFDataGridView.CurrentCell = naloziFDataGridView.Rows[naloziFDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e 
            }
        }
    }
}
