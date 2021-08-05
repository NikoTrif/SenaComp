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

            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
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
    }
}
