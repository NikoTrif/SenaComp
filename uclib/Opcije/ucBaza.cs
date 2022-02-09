using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iflib;

namespace uclib.Opcije
{
    public partial class ucBaza : UserControl
    {
        public ucBaza()
        {
            InitializeComponent();
        }

        private void ucBaza_Load(object sender, EventArgs e)
        {
            rbLokalna_CheckedChanged(null, EventArgs.Empty);
            cbAutoAzuriranje_CheckedChanged(null, EventArgs.Empty);
            cbAutoBackup_CheckedChanged(null, EventArgs.Empty);
            Console.WriteLine(Properties.Settings.Default.BazaServer.ToString());
        }

        private void rbLokalna_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = !rbLokalna.Checked; //Lokacija:
            tbLokacija.ReadOnly = rbLokalna.Checked;
            dBrowse.Enabled = !rbLokalna.Checked;
            cbAutoAzuriranje.Enabled = !rbLokalna.Checked;

            if (rbLokalna.Checked)
            {
                tbLokacija.Text = ""; //ovde upisati default lokaciju lokalne baze
                cbAutoAzuriranje.Checked = false;
            }
        }

        private void cbAutoAzuriranje_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = cbAutoAzuriranje.Checked; //Ažuriraj Bazu svakih
            tbMinuti.Enabled = cbAutoAzuriranje.Checked;
            label5.Enabled = cbAutoAzuriranje.Checked; //minuta.
        }

        private void cbAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            label3.Enabled = cbAutoBackup.Checked; //Putanja Backup-a:
            tbBackupPath.ReadOnly = !cbAutoBackup.Checked;
            dBackupPathBrowse.Enabled = cbAutoBackup.Checked;
        }

        private void tbMinuti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dApply_Click(object sender, EventArgs e)
        {
            try
            {
                int vreme = 0;
                int.TryParse(tbMinuti.Text, out vreme);
                Properties.Settings.Default.BazaAutoUpdateVreme = vreme;

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
            }
        }
    }
}
