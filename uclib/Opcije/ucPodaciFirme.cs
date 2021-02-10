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
    public partial class ucPodaciFirme : UserControl
    {
        public ucPodaciFirme()
        {
            InitializeComponent();
        }

        private void dBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = "Slika *.jpg, *.jpeg, *.png, *.bmp | *.jpg; *.jpeg; *.png; *.bmp | Sve | *.*",
                FilterIndex = 1
            })
            {
                ofd.ShowDialog();
                tbLogo.Text = ofd.FileName.ToString();
                pbSetLogo.ImageLocation = tbLogo.Text;
            }
        }
    }
}
