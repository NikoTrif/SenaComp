using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.IO;

namespace iflib
{
    public class clFunkcijeRazno
    {
        public string FormatKontakt(string kontakt)
        {
            string[] tel = kontakt.Split(' ');
            string telefon = "";
            string formTel = "";
            int i = 0;

            foreach(string s in tel)
            {
                telefon = "";
                if (s.Length == 9)
                {
                    telefon = s.Insert(3, "/");
                    telefon = telefon.Insert(7, "-");
                }
                else if(s.Length == 10)
                {
                    telefon = s.Insert(3, "/");
                    telefon = telefon.Insert(6, "-");
                    telefon = telefon.Insert(9, "-");
                }
                tel[i] = telefon;
                i++;
            }

            i = 0;
            foreach(string s in tel)
            {
                if (formTel.Length > 0)
                {
                    formTel = formTel + " | " + tel[i];
                }

                else
                {
                    formTel = tel[i];
                }
                i++;
            }
            return formTel;
        }

        public bool ProveraNoviRed(string kolonaIme)
        {
            //TD 2.1.i
            if(string.IsNullOrEmpty(kolonaIme) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DodajUkloniOpremu(string tbOprema, CheckBox chk)
        {
            if (chk.Checked)
            {
                tbOprema = tbOprema + chk.Text + ", ";
            }
            else
            {
                tbOprema = tbOprema.Replace(chk.Text + ", ", "");
            }

            return tbOprema;
        }

        public void NapisiLog(Exception ex)
        {
            //TD 4
            MessageBox.Show(ex.Message + "\n\nZa više informacija pogledajte log.txt u folderu programa.", "Greška!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            using(StreamWriter sw = File.AppendText("Log.txt"))
            {
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.ToString());
                sw.WriteLine("\n\n");
            }
        }

        public void KalkulatorCene()
        {
            try
            {
                if (KalkulatorCenaArt.ProdajnaCena == 0)
                {
                    //dodaj racunicu
                    KalkulatorCenaArt.CenaBezPDV = KalkulatorCenaArt.NabavnaCena * ( 1 - KalkulatorCenaArt.Rabat) * KalkulatorCenaArt.Marza;
                    KalkulatorCenaArt.ProdajnaCena = KalkulatorCenaArt.CenaBezPDV * KalkulatorCenaArt.PDV;
                }

                else
                {
                    //matematika nije dobra, probaj ponovo
                    KalkulatorCenaArt.CenaBezPDV = KalkulatorCenaArt.ProdajnaCena * (1 - (KalkulatorCenaArt.PDV - 1));
                    KalkulatorCenaArt.Marza = (1 - (KalkulatorCenaArt.CenaBezPDV / (KalkulatorCenaArt.NabavnaCena * (1 - KalkulatorCenaArt.Rabat)))) * 100;
                }
            }
            catch (Exception ex)
            {
                NapisiLog(ex);
            }
        }

        public class PisanjeReporta
        {
            public ReportParameter[] PostavkeReportParametara(string Logo = "", string NazivFirme = "", string Delatnost = "", string AdresaFirme = "",
                string KontaktFirme = "", string MailFirme = "", string Klauzula = "")
            {
                //TD 3.1.c
                ReportParameter[] parametri = new ReportParameter[]
                {
                new ReportParameter("pLogo", @"File:///" +  Logo),
                new ReportParameter("pNazivFirme", NazivFirme),
                new ReportParameter("pDelatnost", Delatnost),
                new ReportParameter("pAdresaFirme", AdresaFirme),
                new ReportParameter("pKontaktFirme", KontaktFirme),
                new ReportParameter("pMailFirme", MailFirme),
                new ReportParameter("pKlauzula", Klauzula)
                };
                return parametri;
            }
        }
        public class KalkulatorCenaArt
        {
            public static double NabavnaCena = 0;
            public static double Rabat;
            public static double Marza;
            public static double CenaBezPDV;
            public static double PDV = 0;
            public static double ProdajnaCena = 0;
        }
    }
}
