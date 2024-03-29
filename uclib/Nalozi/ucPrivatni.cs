﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iflib;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace uclib.Nalozi
{
    public partial class ucPrivatni : UserControl
    {
        bool noviRed = false; //TD 2.1.c
        bool editTbOstalo = false; //TD 2.1.c
        Timer tRefresh;
        clFunkcijeRazno fnr = new clFunkcijeRazno();

        public ucPrivatni()
        {
            InitializeComponent();
            //naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
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
            naloziPDataGridView.Columns[1].DefaultCellStyle.Format = Properties.Settings.Default.VremeDatumFormat;
        }

        private async void ucPrivatni_Load(object sender, EventArgs e)
        {
            try
            {
                var tm = System.Diagnostics.Stopwatch.StartNew();
                await LoadDatabase();
                tm.Stop();
                Console.WriteLine(tm.ElapsedMilliseconds);

                try
                {
                    flpDodajKontrole(); // ovo radi i treba ovako 
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

        private async Task /*void*/ LoadDatabase()
        {
            try
            {
                //G 8
                if (Properties.Settings.Default.BazaServer)
                {
                    naloziPTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Properties.Settings.Default.BazaServerPath};Password=Master1!";
                    dRefresh.Visible = true;
                }
                else
                {
                    naloziPTableAdapter.Connection.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={cGlobalVariables.localDB};Password=Master1!";
                    dRefresh.Visible = false;
                }

                await naloziPTableAdapter.Connection.OpenAsync();

                naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
                cbFilter.SelectedIndex = 0;
                if (naloziPDataGridView.RowCount != 0)
                {
                    naloziPDataGridView.CurrentCell = naloziPDataGridView.Rows[naloziPDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e 
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            naloziPBindingSource.AddNew();
            //G 7
            foreach(RadioButton rb in tableLayoutPanel1.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            naCekanjuRadioButton.Checked = true;
            datumDateTimePicker.Value = DateTime.Now;
            imePrezimeTextBox.Select();
            resetBrojNalogaTextBoxReadOnly();
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            //TD 2.1.i
           if(noviRed == false)
            {
                if(MessageBox.Show("Da li ste sigurni da želite da izmenite ovaj nalog?", "Izmena naloga", MessageBoxButtons.YesNo,
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

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            naloziPBindingSource.CancelEdit();

            // G 6 - Vraca autoincrement na odgovarajuci broj, ali se i cela baza resetuje, treba proveriti brzinu vracanja kada je baza puna
            dbSenaCompDataSet.Clear();
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = 1;
            dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = 1;

            naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
            try
            {
                naloziPDataGridView.CurrentCell = naloziPDataGridView.Rows[naloziPDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e
            }
            catch { }

            resetBrojNalogaTextBoxReadOnly();
        }

        private void dStampaj_Click(object sender, EventArgs e)
        {
            resetBrojNalogaTextBoxReadOnly();

            ////TD 3.1.c
            //ReportParameter[] para = new ReportParameter[]
            //{
            //    new ReportParameter("pLogo", @"File:///" +  Properties.SettLogo.Default.Logo),
            //    new ReportParameter("pNazivFirme", Properties.Settings.Default.NazivFirme),
            //    new ReportParameter("pDelatnost", Properties.Settings.Default.Delatnost),
            //    new ReportParameter("pAdresaFirme", Properties.Settings.Default.Adresa),
            //    new ReportParameter("pKontaktFirme", Properties.Settings.Default.Telefon),
            //    new ReportParameter("pMailFirme", Properties.Settings.Default.eMail),
            //    new ReportParameter("pKlauzula", Properties.Settings.Default.Klauzula)
            //};

            clFunkcijeRazno.PisanjeReporta prep = new clFunkcijeRazno.PisanjeReporta();

            ReportParameter[] para = prep.PostavkeReportParametara(
                Properties.SettLogo.Default.Logo, 
                Properties.Settings.Default.NazivFirme,
                Properties.Settings.Default.Delatnost, 
                Properties.Settings.Default.Adresa, 
                Properties.Settings.Default.Telefon,
                Properties.Settings.Default.eMail, 
                Properties.Settings.Default.Klauzula);

            iflib.ReportClasses.clRadniNalogPriv rcls = new iflib.ReportClasses.clRadniNalogPriv
            {
                Datum = datumDateTimePicker.Value.ToShortDateString(),
                BrojNaloga = brojNalogaTextBox.Text,
                ImePrezime = imePrezimeTextBox.Text,
                Kontakt = kontaktTextBox.Text,
                Uredjaj = uredjajComboBox.Text,
                Proizvodjac = proizvodjacComboBox.Text,
                Model = modelTextBox.Text,
                SerijskiBroj = serijskiBrojTextBox.Text,
                Pribor = ostaloTextBox.Text,
                OpisKvara = opisKvaraTextBox.Text,
                Izvestaj = izvestajRichTextBox.Text
            };

            clRadniNalogPrivBindingSource.Add(rcls);
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(para);
            
            reportViewer1.RefreshReport();
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj nalog?", "Brisanje naloga", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                naloziPBindingSource.RemoveCurrent();
                //G 6
                dbSenaCompDataSet.Clear();
                dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = -1;
                dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = -1;
                dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementSeed = 1;
                dbSenaCompDataSet.NaloziP.brojNalogaColumn.AutoIncrementStep = 1;
                naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
            }

            resetBrojNalogaTextBoxReadOnly();
        }

        private void napomenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (fRazno fr = new fRazno())
            {
                using(Ostalo.ucNapomena ucn = new Ostalo.ucNapomena())
                {
                    fr.Size = new Size(ucn.Size.Width, ucn.Size.Height);
                    fr.Text = "Napomena";
                    fr.pRazno.Controls.Clear();
                    fr.pRazno.Controls.Add(ucn);
                    fr.AcceptButton = ucn.dSacuvaj;
                    fr.CancelButton = ucn.dOtkazi;
                    ucn.Izmene(true);
                    ucn.Dock = DockStyle.Fill;
                    ucn.BringToFront();

                    if(naloziPDataGridView.CurrentRow.Cells[20].Value.ToString() != "")
                    {
                        ucn.rtbNapomena.Text = naloziPDataGridView.CurrentRow.Cells[20].Value.ToString();
                    }

                    if(fr.ShowDialog() == DialogResult.OK)
                    {
                        naloziPDataGridView.CurrentRow.Cells[20].Value = ucn.rtbNapomena.Text;

                        Validate();
                        naloziPBindingSource.EndEdit();
                        naloziPTableAdapter.Update(dbSenaCompDataSet.NaloziP.Rows[naloziPDataGridView.CurrentRow.Index]);

                        //TD 2.1.f
                        if (MessageBox.Show("Da li želite da ovu napomenu uključite u svaki nalog ovog korisnika?", "Napomena", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            naloziPTableAdapter.qImeNapomena(dbSenaCompDataSet.NaloziP, 
                                naloziPDataGridView.CurrentRow.Cells[2].Value.ToString());
                            foreach (DataGridViewRow r in naloziPDataGridView.Rows)
                            {
                                r.Cells[20].Value = ucn.rtbNapomena.Text;
                            }

                            Validate();
                            naloziPBindingSource.EndEdit();
                            naloziPTableAdapter.Update(dbSenaCompDataSet.NaloziP);

                            naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
                            naloziPDataGridView.CurrentCell = naloziPDataGridView.Rows[naloziPDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e

                        }
                        //ovde ubaciti promenu boje reda
                    }
                }
            }
        }

        private void naloziPDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(naloziPDataGridView.CurrentRow.Cells[20].Value.ToString() != string.Empty)
            {
                using (fRazno fr = new fRazno())
                {
                    using(Ostalo.ucNapomena ucn = new Ostalo.ucNapomena())
                    {
                        fr.Size = ucn.Size;
                        fr.Text = "Napomena";
                        fr.pRazno.Controls.Clear();
                        fr.pRazno.Controls.Add(ucn);
                        fr.AcceptButton = ucn.dOK;
                        fr.CancelButton = null;
                        ucn.Izmene(false);
                        ucn.Dock = DockStyle.Fill;
                        ucn.BringToFront();
                        ucn.rtbNapomena.Text = naloziPDataGridView.CurrentRow.Cells[20].Value.ToString();

                        //G 9
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            naloziPDataGridView.CurrentRow.Cells[20].Value = ucn.rtbNapomena.Text;
                        }
                    }
                }
            }
        }

        private void naloziPDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                noviRed = clFunkcijeRazno.ProveraNoviRed(naloziPDataGridView.CurrentRow.Cells[2].Value.ToString());
            }
            catch { }

            //TD 2.1.c
            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (ostaloTextBox.Text.Contains(chk.Text))
                {
                    chk.Checked = true;
                }
                else
                {
                    chk.Checked = false;
                }
            }
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            //TD 2.1.h
            if(e.KeyCode == Keys.Enter)
            {
                if (tbPretraga.Text != "")
                {
                    switch (cbFilter.SelectedIndex)
                    {
                        case 0:
                            naloziPTableAdapter.qFilterKorisnik(dbSenaCompDataSet.NaloziP, tbPretraga.Text, tbPretraga.Text, tbPretraga.Text);
                            break;
                        case 1:
                            try
                            {
                                naloziPTableAdapter.qFilterBrojNaloga(dbSenaCompDataSet.NaloziP, int.Parse(tbPretraga.Text));
                            }
                            catch
                            {
                                MessageBox.Show("Vrednost pretrage mora biti broj.");
                            }
                            break;
                        case 2:
                            naloziPTableAdapter.qFilterUredjaj(dbSenaCompDataSet.NaloziP, tbPretraga.Text, tbPretraga.Text, tbPretraga.Text,
                                tbPretraga.Text);
                            break;
                        case 3:
                            naloziPTableAdapter.qFilterKvar(dbSenaCompDataSet.NaloziP, tbPretraga.Text, tbPretraga.Text);
                            break;
                        case 4:
                            naloziPTableAdapter.qFilterStatus(dbSenaCompDataSet.NaloziP, tbPretraga.Text);
                            break; 
                    }
                }
                else
                {
                    naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
                    naloziPDataGridView.Rows[naloziPDataGridView.RowCount - 1].Selected = true;
                }

            }
        }

        private void kontaktTextBox_Leave(object sender, EventArgs e)
        {
            kontaktTextBox.Text = fnr.FormatKontakt(kontaktTextBox.Text);
        }

        private void noviBrojNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] nBrNaloga =
            {
                imePrezimeTextBox.Text, //..0
                kontaktTextBox.Text, //.....1
                eMailTextBox.Text, //.......2
                uredjajComboBox.Text, //....3
                proizvodjacComboBox.Text, //4
                modelTextBox.Text, //.......5
                serijskiBrojTextBox.Text, //6
                ostaloTextBox.Text //.......7
            };

            dNovi_Click(null, EventArgs.Empty);

            datumDateTimePicker.Value = DateTime.Now;
            imePrezimeTextBox.Text = nBrNaloga[0];
            kontaktTextBox.Text = nBrNaloga[1];
            eMailTextBox.Text = nBrNaloga[2];
            uredjajComboBox.Text = nBrNaloga[3];
            proizvodjacComboBox.Text = nBrNaloga[4];
            modelTextBox.Text = nBrNaloga[5];
            serijskiBrojTextBox.Text = nBrNaloga[6];
            ostaloTextBox.Text = nBrNaloga[7];

            opisKvaraTextBox.Select();
        }

        private void izmeniBrojNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brojNalogaTextBox.ReadOnly = !izmeniBrojNalogaToolStripMenuItem.Checked;
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

        private void ucPrivatni_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                clFunkcijeRazno.TimerRestart(tRefresh);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void ucPrivatni_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                clFunkcijeRazno.TimerRestart(tRefresh);

            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                clFunkcijeRazno.TimerRestart(tRefresh);
                RefreshDB();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void Cuvanje()
        {
            //TD 2.1.b
            try
            {
                naloziPDataGridView.CurrentRow.Cells[14].Value = tableLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text; //status

                //G 2
                naloziPDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }

            try
            {
                Validate();
                naloziPBindingSource.EndEdit();
                //G1
                naloziPTableAdapter.Update(dbSenaCompDataSet.NaloziP.Rows[naloziPDataGridView.CurrentRow.Index]); //update samo jednog Row-a
                //naloziPTableAdapter.Update(dbSenaCompDataSet.NaloziP);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
            //tableAdapterManager.UpdateAll(dbSenaCompDataSet);
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            //TD 2.1.j
            try
            {
                reportViewer1.PrintDialog();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }

            clRadniNalogPrivBindingSource.Clear();
        }

        private void izvestajRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            clFunkcijeRazno.OgranicenjeRedovaRitchTexBoxa(izvestajRichTextBox, 6, 100, e);
        }

        public void flpDodajKontrole()
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

        // TD 2.1.c
        private void FlowLayoutPanel1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editTbOstalo == true)
            {
                ostaloTextBox.Text = fnr.DodajUkloniOpremu(ostaloTextBox.Text, sender as CheckBox); 
            }

            editTbOstalo = false;
        }

        private void FlowLayoutPanel1CheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            editTbOstalo = true;
        }

        private void flowLayoutPanel1CheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                editTbOstalo = true;
            }
        }

        private void resetBrojNalogaTextBoxReadOnly()
        {
            if(brojNalogaTextBox.ReadOnly == false)
            {
                brojNalogaTextBox.ReadOnly = true;
                izmeniBrojNalogaToolStripMenuItem.Checked = false;
            }
        }
        private void RefreshDB()
        {
            naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
            if (naloziPDataGridView.RowCount != 0)
            {
                naloziPDataGridView.CurrentCell = naloziPDataGridView.Rows[naloziPDataGridView.RowCount - 1].Cells[0]; //TD 2.1.e 
            }
        }
    }
}
