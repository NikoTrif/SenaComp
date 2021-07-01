using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iflib;

namespace uclib.Racuni
{
    public partial class ucProfakture : UserControl
    {
        bool noviRed = false;
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
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void profaktureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profaktureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSenaCompDataSet);
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
                if(noviRed == false)
                {
                    if(MessageBox.Show("Da li ste sigurni da želite da izmenite ovu profakturu?", "Izmena?", MessageBoxButtons.YesNo,
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
                string naziv, jedinica;
                float cena = 0;
                float pdv = 0;
                float kolicina = 1;
                float uCena = 0;

                naziv = artikliDataGridView.CurrentRow.Cells[1].Value.ToString();
                jedinica = artikliDataGridView.CurrentRow.Cells[2].Value.ToString();
                float.TryParse(artikliDataGridView.CurrentRow.Cells[5].Value.ToString(), out cena);
                Console.WriteLine(cena.ToString());
                float.TryParse(artikliDataGridView.CurrentRow.Cells[4].Value.ToString(), out pdv);
                Console.WriteLine(pdv.ToString());
                float.TryParse(tbArtKol.Text, out kolicina);
                Console.WriteLine(kolicina.ToString());
                uCena = (cena * ((pdv / 100) + 1) * kolicina);
                Console.WriteLine(uCena.ToString());

                dataGridView1.Rows.Add(naziv, cena, pdv, kolicina, jedinica, uCena);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }

        }

        private void dArtUkloni_Click(object sender, EventArgs e)
        {

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
                profaktureDataGridView.CurrentRow.Cells[12].Value = tableLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                profaktureDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;
                if (rbPlaceno.Checked)
                {
                    profaktureDataGridView.CurrentRow.Cells[13].Value = datumIsplateDateTimePicker.Value;
                }
            }
            catch(Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }

            try
            {
                Validate();
                profaktureBindingSource.EndEdit();
                profaktureTableAdapter.Update(dbSenaCompDataSet.Profakture);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Console.WriteLine("Sada smo u kolicini");
            }
        }

        private void tbArtKol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //dozvoljava samo jednu decimalnu tacku
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
            if(e.KeyCode == Keys.Enter)
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
            }
        }

        private void artikliDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                tbArtKol.Select();
            }
        }
    }
}
