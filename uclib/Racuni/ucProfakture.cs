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
            }
        }

        private void ResetAutoIncrement()
        {
            dbSenaCompDataSet.Clear();
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
    }
}
