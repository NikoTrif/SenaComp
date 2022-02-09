using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void rbLokalna_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = !rbLokalna.Checked;
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
            label4.Enabled = cbAutoAzuriranje.Checked;
            tbMinuti.Enabled = cbAutoAzuriranje.Checked;
            label5.Enabled = cbAutoAzuriranje.Checked;
        }

        private void cbAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            label3.Enabled = cbAutoBackup.Checked;
            tbBackupPath.ReadOnly = !cbAutoBackup.Checked;
            dBackupPathBrowse.Enabled = cbAutoBackup.Checked;
        }
    }
}
