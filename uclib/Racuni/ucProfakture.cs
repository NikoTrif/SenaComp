using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iflib;
using System.Xml;

namespace uclib.Racuni
{
    public partial class ucProfakture : UserControl
    {
        bool noviRed = false;
        float[] izTemp = { 0, 0, 0 };
            /* var za proveru izmene direktno iz dgvProfArtikli
            0 - cena(bez PDV-a)
            1 - PDV
            2- kolicina*/
        clFunkcijeRazno fnr = new clFunkcijeRazno();

        public ucProfakture()
        {
            InitializeComponent();
        }

        private void ucProfakture_Load(object sender, EventArgs e)
        {
            try
            {
                //G 8
                profaktureTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                profaktureTableAdapter.Fill(dbSenaCompDataSet.Profakture);

                artikliTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);

                cbFilter.SelectedIndex = 0;
                try
                {
                    profaktureDataGridView.CurrentCell = profaktureDataGridView.Rows[profaktureDataGridView.RowCount - 1].Cells[0];
                }
                catch { }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            try
            {
                //ResetAutoIncrement();
                profaktureBindingSource.AddNew();
                rbNaCekanju.Checked = true;
                iDKlijentaTextBox.Select();
                datumDateTimePicker.Value = DateTime.Today;
                //redniBrojTextBox.Text = (int.Parse(redniBrojTextBox.Text) + 2).ToString();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            try
            {
                profaktureBindingSource.CancelEdit();
                ResetAutoIncrement();

                profaktureTableAdapter.Fill(dbSenaCompDataSet.Profakture);
                try
                {
                    profaktureDataGridView.CurrentCell = profaktureDataGridView.Rows[profaktureDataGridView.RowCount - 1].Cells[0];
                }
                catch { }

            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (noviRed == false)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovu profakturu?", "Izmena?", MessageBoxButtons.YesNo,
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
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dStampaj_Click(object sender, EventArgs e)
        {

        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu profakturu?", "Obriši profakturu?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    profaktureBindingSource.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dFaktura_Click(object sender, EventArgs e)
        {
            //prebaciti na ucFakture i automatski upisati podatke (tj samo broj profakture po kome ce se naci svi ostali podaci) u odgovarajuci TextBox
        }

        private void dOdaberi_Click(object sender, EventArgs e)
        {
            try
            {
                using (Ostalo.ucOdabirFirme of = new Ostalo.ucOdabirFirme())
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
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            iDKlijentaTextBox.Text = clTransfer.IDFirme;
                            klijentTextBox.Text = clTransfer.Firma;
                            pIBTextBox.Text = clTransfer.PIB;
                            matBrojTextBox.Text = clTransfer.MatBr;
                            adresaTextBox.Text = clTransfer.Adresa;
                            gradTextBox.Text = clTransfer.Grad;

                            //ciscenje clTransfera
                            clFunkcijeRazno.ClearTransfer();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dArtDodaj_Click(object sender, EventArgs e)
        {
            try
            {                
                RacunCenaITotal(false);

                tbArtPret.Select();
                tbArtPret.SelectAll();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dArtUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dgvProfArtikli.CurrentRow.IsNewRow)
                {
                    foreach(DataGridViewRow r in dgvProfArtikli.SelectedRows)
                    {
                        dgvProfArtikli.Rows.RemoveAt(r.Index);
                    } 
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void profaktureDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (profaktureDataGridView.RowCount > 0)
            {
                try
                {
                    noviRed = fnr.ProveraNoviRed(profaktureDataGridView.CurrentRow.Cells[3].Value.ToString());
                }
                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);
                }

                try
                {
                    string stat = profaktureDataGridView.CurrentRow.Cells[12].Value.ToString();
                    if (!string.IsNullOrEmpty(stat))
                    {
                        switch (stat)
                        {
                            case "Na čekanju":
                                rbNaCekanju.Checked = true;
                                break;
                            case "Plaćeno":
                                rbPlaceno.Checked = true;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);
                }
            }
        }

        private void rbPlaceno_CheckedChanged(object sender, EventArgs e)
        {
            datumIsplateDateTimePicker.Visible = rbPlaceno.Checked;
            (tableLayoutPanel2.Controls["datumIsplateLabel"] as Label).Visible = rbPlaceno.Checked;
        }

        private void tbArtKol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //dozvoljava samo jednu decimalnu tacku
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) ||
                (e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbArtKol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                dArtDodaj.PerformClick();
            }
        }

        private void tbArtPret_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int sifra = 0;
                    int.TryParse(tbArtPret.Text, out sifra);

                    if (tbArtPret.Text == "")
                    {
                        artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);
                    }
                    else if (sifra > 0)
                    {
                        artikliTableAdapter.qFilterSifra(dbSenaCompDataSet.Artikli, sifra);
                    }
                    else
                    {
                        artikliTableAdapter.qFilterNaziv(dbSenaCompDataSet.Artikli, tbArtPret.Text);
                    }
                }

                else if (e.KeyCode == Keys.Add)
                {
                    tbArtKol.Select();
                    tbArtKol.Text = "1";
                    tbArtKol.SelectAll();
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void artikliDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbArtKol.Text = "1";
                RacunCenaITotal(false);
                tbArtPret.Select();
                tbArtPret.SelectAll();
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void artikliDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                tbArtKol.Select();
                tbArtKol.Text = "1";
                tbArtKol.SelectAll();
            }
        }

        private void tbArtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void dgvProfArtikli_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((sender as DataGridView).CurrentRow.Cells[1].Value != null && (sender as DataGridView).CurrentRow.Cells[2].Value != null
                            && (sender as DataGridView).CurrentRow.Cells[3].Value != null)
                {
                    float.TryParse((sender as DataGridView).CurrentRow.Cells[1].Value.ToString(), out izTemp[0]); //cena bez PDV-a
                    float.TryParse((sender as DataGridView).CurrentRow.Cells[2].Value.ToString(), out izTemp[1]); //PDV
                    float.TryParse((sender as DataGridView).CurrentRow.Cells[3].Value.ToString(), out izTemp[2]); //Kolicina
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);

                izTemp[0] = 0;
                izTemp[1] = 0;
                izTemp[2] = 0;
            }
        }

        private void dgvProfArtikli_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 4 && e.ColumnIndex != 5)
            {
                float IzmenaTemp = 0;
                
                try
                {
                    if (!dgvProfArtikli.CurrentRow.IsNewRow)
                    {
                        if (dgvProfArtikli.CurrentCell.Value != null)
                        {
                            float.TryParse(dgvProfArtikli.CurrentRow.Cells[e.ColumnIndex].Value.ToString(), out IzmenaTemp);
                            if (IzmenaTemp != 0 || IzmenaTemp != izTemp[e.ColumnIndex - 1])
                            {
                                RacunCenaITotal(true);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ova kolona mora imati vrednost!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvProfArtikli.CurrentCell.Value = izTemp[e.ColumnIndex - 1]; //G 13                      
                        } 
                    }
                }
                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);

                    izTemp[0] = 0;
                    izTemp[1] = 0;
                    izTemp[2] = 0;
                }
            }
        }

        private void tbArtProfPret_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    foreach (DataGridViewRow r in dgvProfArtikli.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            foreach (DataGridViewCell c in dgvProfArtikli.Rows[r.Index].Cells)
                            {
                                if (c.Value.ToString().Contains(tbArtProfPret.Text))
                                {
                                    c.Selected = true;
                                    break;
                                }
                                else
                                {
                                    c.Selected = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void profaktureDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int xnIndex = -1;
            XmlDocument xdoc = new XmlDocument();

            try
            {
                if (!string.IsNullOrEmpty(profaktureDataGridView.CurrentRow.Cells[10/*ukupna cena*/].Value.ToString()))
                {
                    lTotal.Text = profaktureDataGridView.CurrentRow.Cells[10/*ukupna cena*/].Value.ToString() +
                        " " + profaktureDataGridView.CurrentRow.Cells[8/*Valuta*/].Value.ToString();
                }
                else
                {
                    lTotal.Text = "";
                }

                if (!string.IsNullOrEmpty(profaktureDataGridView.CurrentRow.Cells[9].Value.ToString()))
                {
                    dgvProfArtikli.Rows.Clear();
                    xdoc.LoadXml(profaktureDataGridView.CurrentRow.Cells[9].Value.ToString());

                    foreach (XmlNode xn in xdoc.ChildNodes[0])
                    {
                        int.TryParse(xn.Attributes["row"].Value, out xnIndex);
                        dgvProfArtikli.Rows.Add();
                        if (xnIndex != -1)
                        {
                            foreach (XmlNode xnn in xn)
                            {
                                dgvProfArtikli.Rows[xnIndex].Cells[xnn.Name].Value = xnn.InnerText; //ovde treba popraviti
                            }
                            xnIndex = -1;
                        }
                    }
                }
                else
                {
                    dgvProfArtikli.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(tbPretraga.Text))
                    {
                        switch (cbFilter.SelectedIndex)
                        {
                            case 0:
                                profaktureTableAdapter.qPretKlijent(dbSenaCompDataSet.Profakture, tbPretraga.Text, tbPretraga.Text,
                                    tbPretraga.Text, tbPretraga.Text, tbPretraga.Text);
                                break;
                            case 1:
                                int rb = 0;
                                int.TryParse(tbPretraga.Text, out rb);
                                if (rb != 0)
                                {
                                    profaktureTableAdapter.qPretRedniBroj(dbSenaCompDataSet.Profakture, rb);
                                }
                                break;
                            case 2:
                                int idk = 0;
                                int.TryParse(tbPretraga.Text, out idk);
                                if (idk != 0)
                                {
                                    profaktureTableAdapter.qPretKlijentID(dbSenaCompDataSet.Profakture, idk);
                                }
                                break;
                            case 3:
                                profaktureTableAdapter.qPretDatum(dbSenaCompDataSet.Profakture, tbPretraga.Text);
                                break; 
                        }
                    }
                    else
                    {
                        profaktureTableAdapter.Fill(dbSenaCompDataSet.Profakture);
                        try
                        {
                            profaktureDataGridView.CurrentCell = profaktureDataGridView.Rows[profaktureDataGridView.RowCount - 1].Cells[0];
                        }
                        catch { }
                    }
                }
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void ResetAutoIncrement()
        {
            dbSenaCompDataSet.Profakture.Clear();
            dbSenaCompDataSet.Profakture.redniBrojColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.Profakture.redniBrojColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.Profakture.redniBrojColumn.AutoIncrementStep = 1;
            dbSenaCompDataSet.Profakture.redniBrojColumn.AutoIncrementSeed = 1;
        }

        private void Cuvanje()
        {
            try
            {
                //cuvanje datuma
                profaktureDataGridView.CurrentRow.Cells[12].Value = tableLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                profaktureDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;
                if (rbPlaceno.Checked)
                {
                    profaktureDataGridView.CurrentRow.Cells[13].Value = datumIsplateDateTimePicker.Value;
                }

                //cuvanje ukupne cene
                float uCena = 0;
                string[] uCenaText = lTotal.Text.Split(' ');
                Console.WriteLine(uCenaText);
                if (!string.IsNullOrEmpty(lTotal.Text))
                {
                    float.TryParse(uCenaText[0], out uCena);
                    profaktureDataGridView.CurrentRow.Cells[10/*ukupna cena*/].Value = uCena;
                }

                //cuvanje liste artikala iz dgvProfArtikli u XML
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml("<artikli></artikli>");
                foreach(DataGridViewRow r in dgvProfArtikli.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        XmlElement xe = xdoc.CreateElement("roba");
                        xe.SetAttribute("row", r.Index.ToString());
                        xdoc.ChildNodes[0].AppendChild(xe);
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            xe = xdoc.CreateElement(dgvProfArtikli.Columns[c.ColumnIndex].Name);
                            xe.InnerText = c.Value.ToString();
                            xdoc.ChildNodes[0].ChildNodes[r.Index].AppendChild(xe);
                        } 
                    }
                }
                profaktureDataGridView.CurrentRow.Cells[9/*roba*/].Value = xdoc.OuterXml.ToString();

                // G 14
                Validate();
                profaktureBindingSource.EndEdit();
                profaktureTableAdapter.Update(dbSenaCompDataSet.Profakture);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        /// <summary>
        /// Racuna Cenu i upisuje label TOTAL
        /// </summary>
        /// <param name="direktnaIzmena">true - ako je napravljena izmena iz DataGridView-a; false - ako nije</param>
        private void RacunCenaITotal(bool direktnaIzmena)
        {
            string naziv, jedinica;
            float total = 0;
            float x = 0;
            float cenaSaPDV = 0;
            float cena = 0; //cena bez PDV-a iz kolone 1
            float pdv = 0;
            float kol = 0;
            float uCena = 0;

            try
            {
                if (direktnaIzmena == true)
                {
                    float.TryParse(dgvProfArtikli.CurrentRow.Cells[2].Value.ToString(), out pdv);
                    float.TryParse(dgvProfArtikli.CurrentRow.Cells[3].Value.ToString(), out kol);
                    float.TryParse(dgvProfArtikli.CurrentRow.Cells[1].Value.ToString(), out cena);
                    cenaSaPDV = cena * ((pdv / 100) + 1);
                    uCena = cenaSaPDV * kol;

                    dgvProfArtikli.CurrentRow.Cells[6].Value = cenaSaPDV;
                    dgvProfArtikli.CurrentRow.Cells[5].Value = uCena;
                }

                else
                {
                    naziv = artikliDataGridView.CurrentRow.Cells[1].Value.ToString();
                    jedinica = artikliDataGridView.CurrentRow.Cells[2].Value.ToString();
                    float.TryParse(artikliDataGridView.CurrentRow.Cells[5].Value.ToString(), out cena);
                    float.TryParse(artikliDataGridView.CurrentRow.Cells[4].Value.ToString(), out pdv);
                    float.TryParse(tbArtKol.Text, out kol);
                    float.TryParse(artikliDataGridView.CurrentRow.Cells[6].Value.ToString(), out cenaSaPDV);
                    uCena = cenaSaPDV * kol;

                    dgvProfArtikli.Rows.Add(naziv, cena, pdv, kol, jedinica, uCena, cenaSaPDV);
                }

                foreach (DataGridViewRow dgvr in dgvProfArtikli.Rows)
                {
                    if (dgvr.Cells[5].Value != null)
                    {
                        float.TryParse(dgvr.Cells[5].Value.ToString(), out x);
                        total = total + x;
                        x = 0;
                    }
                }

                lTotal.Text = string.Format("{0} {1}", total.ToString(), valutaTextBox.Text);

                izTemp[0] = 0;
                izTemp[1] = 0;
                izTemp[2] = 0;
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
                izTemp[0] = 0;
                izTemp[1] = 0;
                izTemp[2] = 0;
            }
        }
    }
}
