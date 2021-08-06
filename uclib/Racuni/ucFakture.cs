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
    public partial class ucFakture : UserControl
    {
        bool noviRed = false;
        float[] izTemp = { 0, 0, 0 };
        public ucFakture()
        {
            InitializeComponent();
        }

        private void ResetAutoIncrement()
        {
            dbSenaCompDataSet.Fakture.Clear();
            dbSenaCompDataSet.Fakture.redniBrojColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.Fakture.redniBrojColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.Fakture.redniBrojColumn.AutoIncrementStep = 1;
            dbSenaCompDataSet.Fakture.redniBrojColumn.AutoIncrementSeed = 1;
        }
        private void Cuvanje()
        {
            try
            {
                //cuvanje datuma
                faktureDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;

                //cuvanje ukupne cene
                float uCena = 0;
                string[] uCenaText = lTotal.Text.Split(' ');
                Console.WriteLine(uCenaText);
                if (!string.IsNullOrEmpty(lTotal.Text))
                {
                    float.TryParse(uCenaText[0], out uCena);
                    faktureDataGridView.CurrentRow.Cells[11/*ukupna cena*/].Value = uCena;
                }

                //cuvanje liste artikala iz dgvProfArtikli u XML
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml("<artikli></artikli>");
                foreach (DataGridViewRow r in dgvFaktArtikli.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        XmlElement xe = xdoc.CreateElement("roba");
                        xe.SetAttribute("row", r.Index.ToString());
                        xdoc.ChildNodes[0].AppendChild(xe);
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            xe = xdoc.CreateElement(dgvFaktArtikli.Columns[c.ColumnIndex].Name);
                            xe.InnerText = c.Value.ToString();
                            xdoc.ChildNodes[0].ChildNodes[r.Index].AppendChild(xe);
                        }
                    }
                }
                faktureDataGridView.CurrentRow.Cells[10/*roba*/].Value = xdoc.OuterXml.ToString();

                // G 14
                Validate();
                faktureBindingSource.EndEdit();
                faktureTableAdapter.Update(dbSenaCompDataSet.Fakture);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void ucFakture_Load(object sender, EventArgs e)
        {
            try
            {
                //G 8
                faktureTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                faktureTableAdapter.Fill(dbSenaCompDataSet.Fakture);

                artikliTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
                artikliTableAdapter.Fill(dbSenaCompDataSet.Artikli);

                cbFilter.SelectedIndex = 0;
                try
                {
                    faktureDataGridView.CurrentCell = faktureDataGridView.Rows[faktureDataGridView.RowCount - 1].Cells[0];
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
                faktureBindingSource.AddNew();
                iDKlijentaTextBox.Select();
                datumDateTimePicker.Value = DateTime.Today;
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
                faktureBindingSource.CancelEdit();
                ResetAutoIncrement();
                faktureTableAdapter.Fill(dbSenaCompDataSet.Fakture);

                try
                {
                    faktureDataGridView.CurrentCell = faktureDataGridView.Rows[faktureDataGridView.RowCount - 1].Cells[0];
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
                    if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovu fakturu?", "Izmena?", MessageBoxButtons.YesNo,
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
            try
            {

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
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu fakturu?", "Obriši fakturu?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    faktureBindingSource.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
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
                clFunkcijeRazno.RacunCenaITotal(false, false, dgvFaktArtikli, artikliDataGridView, lTotal, valutaTextBox.Text,
                    tbArtKol.Text);

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
                if (!dgvFaktArtikli.CurrentRow.IsNewRow)
                {
                    foreach (DataGridViewRow r in dgvFaktArtikli.SelectedRows)
                    {
                        dgvFaktArtikli.Rows.RemoveAt(r.Index);
                    }
                    clFunkcijeRazno.RacunCenaITotal(false, true, dgvFaktArtikli, artikliDataGridView, lTotal, valutaTextBox.Text,
                        tbArtKol.Text);
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void artikliDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbArtKol.Text = "1";
            clFunkcijeRazno.RacunCenaITotal(false, false, dgvFaktArtikli, artikliDataGridView, lTotal, valutaTextBox.Text,
                tbArtKol.Text);
            tbArtPret.Select();
            tbArtPret.SelectAll();
        }

        private void artikliDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Add)
            {
                tbArtKol.Select();
                tbArtKol.Text = "1";
                tbArtKol.SelectAll();
            }
        }

        private void tbArtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                e.Handled = true;
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
                else if(e.KeyCode == Keys.Add)
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

        private void tbArtFaktPret_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    foreach (DataGridViewRow r in dgvFaktArtikli.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            foreach (DataGridViewCell c in dgvFaktArtikli.Rows[r.Index].Cells)
                            {
                                if (c.Value.ToString().Contains(dgvFaktArtikli.Text))
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

        private void dgvFaktArtikli_CellEnter(object sender, DataGridViewCellEventArgs e)
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

        private void dgvFaktArtikli_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 4 && e.ColumnIndex != 5)
            {
                float IzmenaTemp = 0;

                try
                {
                    if (!dgvFaktArtikli.CurrentRow.IsNewRow)
                    {
                        if (dgvFaktArtikli.CurrentCell.Value != null)
                        {
                            float.TryParse(dgvFaktArtikli.CurrentRow.Cells[e.ColumnIndex].Value.ToString(), out IzmenaTemp);
                            if (IzmenaTemp != 0 || IzmenaTemp != izTemp[e.ColumnIndex - 1])
                            {
                                clFunkcijeRazno.RacunCenaITotal(true, false, dgvFaktArtikli, artikliDataGridView, lTotal, valutaTextBox.Text,
                    tbArtKol.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ova kolona mora imati vrednost!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvFaktArtikli.CurrentCell.Value = izTemp[e.ColumnIndex - 1]; //G 13                      
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

        private void dgvFaktArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    dArtUkloni.PerformClick();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            /*try
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
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }*/
        }

        private void faktureDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (faktureDataGridView.RowCount > 0)
            {
                try
                {
                    noviRed = clFunkcijeRazno.ProveraNoviRed(faktureDataGridView.CurrentRow.Cells[4].Value.ToString());
                }
                catch (Exception ex)
                {
                    clFunkcijeRazno.NapisiLog(ex);
                }
            }
        }

        private void faktureDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int xnIndex = -1;
            XmlDocument xdoc = new XmlDocument();

            try
            {
                if (!string.IsNullOrEmpty(faktureDataGridView.CurrentRow.Cells[11/*ukupna cena*/].Value.ToString()))
                {
                    lTotal.Text = faktureDataGridView.CurrentRow.Cells[11/*ukupna cena*/].Value.ToString() +
                        " " + faktureDataGridView.CurrentRow.Cells[9/*Valuta*/].Value.ToString();
                }
                else
                {
                    lTotal.Text = "";
                }

                if (!string.IsNullOrEmpty(faktureDataGridView.CurrentRow.Cells[10/*roba*/].Value.ToString()))
                {
                    dgvFaktArtikli.Rows.Clear();
                    xdoc.LoadXml(faktureDataGridView.CurrentRow.Cells[10/*roba*/].Value.ToString());

                    foreach (XmlNode xn in xdoc.ChildNodes[0])
                    {
                        int.TryParse(xn.Attributes["row"].Value, out xnIndex);
                        dgvFaktArtikli.Rows.Add();
                        if (xnIndex != -1)
                        {
                            foreach (XmlNode xnn in xn)
                            {
                                dgvFaktArtikli.Rows[xnIndex].Cells[xnn.Name].Value = xnn.InnerText; //ovde treba popraviti
                            }
                            xnIndex = -1;
                        }
                    }
                }
                else
                {
                    dgvFaktArtikli.Rows.Clear();
                }
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
    }
}
