using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace uclib.Baze
{
    public partial class ucFirme : UserControl
    {
        public ucFirme()
        {
            InitializeComponent();
        }

        private void ucFirme_Load(object sender, EventArgs e)
        {
            firmeTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\bin\debug\dbSenaComp.mdf;Password=Master1!";
            firmeTableAdapter.Fill(dbSenaCompDataSet.Firme);
            cbFilter.SelectedIndex = 0;
            try
            {
                firmeDataGridView.CurrentCell = firmeDataGridView.Rows[firmeDataGridView.RowCount - 1].Cells[0];
            }
            catch { }
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            firmeBindingSource.AddNew();
            nazivTextBox.Select();
        }

        private void dOtkazi_Click(object sender, EventArgs e)
        {
            firmeBindingSource.CancelEdit();
            ResetID();
        }

        private void ResetID()
        {
            //G 6
            dbSenaCompDataSet.Clear();
            dbSenaCompDataSet.Firme.IDColumn.AutoIncrementSeed = -1;
            dbSenaCompDataSet.Firme.IDColumn.AutoIncrementStep = -1;
            dbSenaCompDataSet.Firme.IDColumn.AutoIncrementSeed = 1;
            dbSenaCompDataSet.Firme.IDColumn.AutoIncrementSeed = 1;
            firmeTableAdapter.Fill(dbSenaCompDataSet.Firme);
            firmeDataGridView.CurrentCell = firmeDataGridView.Rows[firmeDataGridView.RowCount - 1].Cells[0];
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            Validate();
            firmeBindingSource.EndEdit();
            firmeTableAdapter.Update(dbSenaCompDataSet.Firme);
        }

        private void dObrisi_Click(object sender, EventArgs e)
        {
            firmeBindingSource.RemoveCurrent();
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPretraga.Text != "")
                {
                    string pretraga = tbPretraga.Text;

                    switch (cbFilter.SelectedIndex)
                    {
                        case 0:
                            firmeTableAdapter.qPretString(dbSenaCompDataSet.Firme, pretraga, pretraga, pretraga, pretraga, pretraga, 
                                pretraga, pretraga);
                            break;
                        case 1:
                            try
                            {
                                firmeTableAdapter.qPretID(dbSenaCompDataSet.Firme, int.Parse(pretraga));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        case 2:
                            firmeTableAdapter.qPretNaziv(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 3:
                            firmeTableAdapter.qPretPIB(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 4:
                            firmeTableAdapter.qPretMB(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 5:
                            firmeTableAdapter.qPretGrad(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 6:
                            firmeTableAdapter.qPretUlicaBroj(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 7:
                            firmeTableAdapter.qPretKontakt(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 8:
                            firmeTableAdapter.qPretEmail(dbSenaCompDataSet.Firme, pretraga);
                            break;
                        case 9:
                            firmeTableAdapter.qPretTekuciRacun(dbSenaCompDataSet.Firme, pretraga);
                            break;
                    }
                }
                else
                {
                    firmeTableAdapter.Fill(dbSenaCompDataSet.Firme);
                }
            }
        }
    }
}
