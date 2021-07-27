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
    public partial class ucFakture : UserControl
    {
        public ucFakture()
        {
            InitializeComponent();
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

        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {

        }

        private void dStampaj_Click(object sender, EventArgs e)
        {

        }

        private void dObrisi_Click(object sender, EventArgs e)
        {

        }

        private void dOdaberi_Click(object sender, EventArgs e)
        {

        }

        private void dArtDodaj_Click(object sender, EventArgs e)
        {

        }

        private void dArtUkloni_Click(object sender, EventArgs e)
        {

        }
    }
}
