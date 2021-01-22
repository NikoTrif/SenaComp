using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uclib.Nalozi
{
    public partial class ucPrivatni : UserControl
    {
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
        }

        private void ucPrivatni_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            //G 8
            naloziPTableAdapter.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Visual Studio 2015\Projects\SenaComp\SenaComp\dbSenaComp.mdf;Password=Master1!";
            naloziPTableAdapter.Fill(dbSenaCompDataSet.NaloziP);
            flpDodajKontrole(); // ovo radi i treba ovako
        }

        private void dNovi_Click(object sender, EventArgs e)
        {
            naloziPBindingSource.AddNew();
            naCekanjuRadioButton.Select();
            datumDateTimePicker.Value = DateTime.Today;
            imePrezimeTextBox.Select();
        }

        private void dSacuvaj_Click(object sender, EventArgs e)
        {
            //TD 2.1.b
            try
            {
                naloziPDataGridView.CurrentRow.Cells[14].Value = tableLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                //G 2
                naloziPDataGridView.CurrentRow.Cells[1].Value = datumDateTimePicker.Value;

                
            }
            catch { }


            Validate();
            naloziPBindingSource.EndEdit();

            //G1
            naloziPTableAdapter.Update(dbSenaCompDataSet.NaloziP);
            //tableAdapterManager.UpdateAll(dbSenaCompDataSet);
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
        }

        private void dStampaj_Click(object sender, EventArgs e)
        {

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
        }

        public void flpDodajKontrole()
        {
            try
            {
                foreach (string s in Properties.Settings.Default.Oprema)
                {
                    CheckBox chkb = new CheckBox();
                    chkb.Name = "cb" + s;
                    chkb.Text = s;
                    flowLayoutPanel1.Controls.Add(chkb);
                } 
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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
                    ucn.Dock = DockStyle.Fill;
                    ucn.BringToFront();

                    if(fr.ShowDialog() == DialogResult.OK)
                    {
                        naloziPDataGridView.CurrentRow.Cells[20].Value = ucn.rtbNapomena.Text;
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
                        fr.AcceptButton = ucn.dSacuvaj;
                        fr.CancelButton = ucn.dOtkazi;
                        ucn.Dock = DockStyle.Fill;
                        ucn.BringToFront();
                        ucn.rtbNapomena.Text = naloziPDataGridView.CurrentRow.Cells[20].Value.ToString();

                        if(fr.ShowDialog() == DialogResult.OK)
                        {
                            naloziPDataGridView.CurrentRow.Cells[20].Value = ucn.rtbNapomena.Text;
                        }
                    }
                }
            }
        }
    }
}
