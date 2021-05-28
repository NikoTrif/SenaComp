using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uclib;

namespace SenaComp
{
    public partial class fSenaComp : Form
    {
        bool menuOtvoren = false;

        public fSenaComp()
        {
            InitializeComponent();
        }

        private void fSenaComp_Load(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = uclib.Properties.SettLogo.Default.Logo;
            pbLogo.Refresh();
        }

        private void dMenu_Click(object sender, EventArgs e)
        {
            pMenu.BringToFront();
            dMenu.BringToFront();
            tMenu.Start();
        }

        private void tMenu_Tick(object sender, EventArgs e)
        {
            if (menuOtvoren)
            {
                pMenu.Width -= 20;
                if (pMenu.Width == 0)
                {
                    tMenu.Stop();
                    menuOtvoren = false;
                }
            }

            else
            {
                pMenu.Width += 20;
                if (pMenu.Width >= 160)
                {
                    tMenu.Stop();
                    menuOtvoren = true;
                    dPrivatni.Width = 160;
                }
            }
        }

        private void dPrivatni_Click(object sender, EventArgs e)
        {
            uclib.Nalozi.ucPrivatni priv = new uclib.Nalozi.ucPrivatni();

            tMenu.Start();

            pMain.Controls.Clear();
            pMain.Controls.Add(priv);
            priv.Dock = DockStyle.Fill;
            priv.SendToBack();
            //priv.BringToFront();
            //dMenu.BringToFront();
            pbLogo.BringToFront();
        }

        private void dPoslovni_Click(object sender, EventArgs e)
        {
            uclib.Nalozi.ucPoslovni pos = new uclib.Nalozi.ucPoslovni();

            tMenu.Start();

            pMain.Controls.Clear();
            pMain.Controls.Add(pos);
            pos.Dock = DockStyle.Fill;
            pos.SendToBack();
            pbLogo.BringToFront();
        }

        private void dProfakt_Click(object sender, EventArgs e)
        {

        }

        private void dFakt_Click(object sender, EventArgs e)
        {

        }

        private void dOtp_Click(object sender, EventArgs e)
        {

        }

        private void dArtikli_Click(object sender, EventArgs e)
        {
            uclib.Baze.ucArtikli art = new uclib.Baze.ucArtikli();

            tMenu.Start();

            pMain.Controls.Clear();
            pMain.Controls.Add(art);
            art.Dock = DockStyle.Fill;
            art.SendToBack();
            pbLogo.BringToFront();
        }

        private void dFirme_Click(object sender, EventArgs e)
        {
            uclib.Baze.ucFirme fir = new uclib.Baze.ucFirme();

            tMenu.Start();

            pMain.Controls.Clear();
            pMain.Controls.Add(fir);
            fir.Dock = DockStyle.Fill;
            fir.SendToBack();
            pbLogo.BringToFront();
        }

        private void dPodesavanja_Click(object sender, EventArgs e)
        {
            //pod.OtvoriProzor();
            using (fRazno fr = new fRazno())
            {
                using (ucPodesavanja pod = new ucPodesavanja())
                {
                    fr.Text = "Podešavanja";
                    fr.MaximizeBox = false;
                    fr.Size = new Size(pod.Width, pod.Height + 40);
                    fr.Controls.Add(pod);
                    pod.Dock = DockStyle.Fill;
                    pod.BringToFront();
                    //promeni kada se napravi ucOsnovna
                    using (uclib.Opcije.Osnovno.ucOprema op = new uclib.Opcije.Osnovno.ucOprema())
                    {
                        pod.pOptMain.Controls.Add(op);
                        op.Dock = DockStyle.Fill;
                        op.BringToFront();
                        fr.ShowDialog();
                    }
                }
            }
        }
    }
}
