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
            }
        }
    }
}
