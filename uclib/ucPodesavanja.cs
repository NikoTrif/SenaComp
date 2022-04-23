using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uclib.Opcije;

namespace uclib
{
    public partial class ucPodesavanja : UserControl
    {
        public ucPodesavanja()
        {
            InitializeComponent();
        }

        private void ucPodesavanja_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            //promeni kada se napravi ucOsnovno
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Oprema":
                    Opcije.Osnovno.ucOprema op = new Opcije.Osnovno.ucOprema();
                    if (pOptMain.Controls.Count != 0)
                    {
                        pOptMain.Controls.Clear();
                    }
                    pOptMain.Controls.Add(op);
                    op.Dock = DockStyle.Fill;
                    op.BringToFront();
                    break;

                case "Uređaji":
                    Opcije.Osnovno.ucUredjaji ur = new Opcije.Osnovno.ucUredjaji();
                    if (pOptMain.Controls.Count != 0)
                    {
                        pOptMain.Controls.Clear();
                    }
                    pOptMain.Controls.Add(ur);
                    ur.Dock = DockStyle.Fill;
                    ur.BringToFront();
                    break;

                case "Podaci Firme":
                    ucPodaciFirme pf = new ucPodaciFirme();
                    if (pOptMain.Controls.Count != 0)
                    {
                        pOptMain.Controls.Clear();
                    }
                    pOptMain.Controls.Add(pf);
                    pf.Dock = DockStyle.Fill;
                    pf.BringToFront();
                    break;

                case "Klauzula":
                    ucKlauzula kl = new ucKlauzula();
                    if (pOptMain.Controls.Count != 0)
                    {
                        pOptMain.Controls.Clear();
                    }
                    pOptMain.Controls.Add(kl);
                    kl.Dock = DockStyle.Fill;
                    kl.BringToFront();
                    break;

                case "Baza":
                    ucBaza bz = new ucBaza();
                    if (pOptMain.Controls.Count != 0)
                    {
                        pOptMain.Controls.Clear();
                    }
                    pOptMain.Controls.Add(bz);
                    bz.Dock = DockStyle.Fill;
                    bz.BringToFront();
                    break;
                //default:
                //    Opcije.Osnovno.ucOprema opr = new Opcije.Osnovno.ucOprema();
                //    if (pOptMain.Controls.Count != 0)
                //    {
                //        pOptMain.Controls.Clear();
                //    }
                //    pOptMain.Controls.Add(opr);
                //    opr.Dock = DockStyle.Fill;
                //    opr.BringToFront();
                //    break;

                    //ucBaza bzz = new ucBaza();
                    //if (pOptMain.Controls.Count != 0)
                    //{
                    //    pOptMain.Controls.Clear();
                    //}
                    //pOptMain.Controls.Add(bzz);
                    //bzz.Dock = DockStyle.Fill;
                    //bzz.BringToFront();
                    //break;
            }
        }
    }
}
