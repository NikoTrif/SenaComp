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

        public ucPoslovni()
        {
            InitializeComponent();

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
            flpDodajKontrole();
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
                MessageBox.Show(ex.ToString());
            }
        }
        private void dObrisi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj nalog?", "Brisanje naloga", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                naloziFBindingSource.RemoveCurrent();

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
                        iflib.clTransfer.IDFirme = null;
                        iflib.clTransfer.Firma = null;
                        iflib.clTransfer.Kontakt = null;
                        iflib.clTransfer.eMail = null;
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
                MessageBox.Show(ex.ToString());
            }

            try
            {
                Validate();
                naloziFBindingSource.EndEdit();
                naloziFTableAdapter.Update(dbSenaCompDataSet.NaloziF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void naloziFDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            clFunkcijeRazno clf = new clFunkcijeRazno();
            try
            {
                noviRed = clf.ProveraNoviRed(naloziFDataGridView.CurrentRow.Cells[2].Value.ToString());
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
                    MessageBox.Show(ex.ToString());
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
                clFunkcijeRazno clf = new clFunkcijeRazno();
                opremaTextBox.Text = clf.DodajUkloniOpremu(opremaTextBox.Text, sender as CheckBox);
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
                MessageBox.Show(ex.ToString());
            }
            clRadniNalogPosBindingSource.Clear();
        }

        private void kontaktTextBox_Leave(object sender, EventArgs e)
        {
            kontaktTextBox.Text = (new clFunkcijeRazno()).FormatKontakt(kontaktTextBox.Text);
        }
    }
}
