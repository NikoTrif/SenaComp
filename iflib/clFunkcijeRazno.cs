using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

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

        public void PrintReport
            (
            string pLogo="",
            string pNazivFirme ="",
            string pDelatnost="",
            string pKontaktFirme="",
            string pMailFirme="",
            string pKlauzula="",

            string dbDatum="",
            string dbBrojNaloga="",
            string dbImePrezime="",
            string dbKontakt="",
            string dbUredjaj="",
            string dbProizvodjac="",
            string dbModel="",
            string dbSerijskiBroj="",
            string dbPribor="",
            string dbOpisKvara="",
            string dbIzvestaj=""
            )
        {
            BindingSource bsRNalog = new BindingSource();
            ReportViewer rpv1 = new ReportViewer();
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("parLogo", pLogo),
                new ReportParameter("parNazivFirme", pNazivFirme),
                new ReportParameter("parDelatnost", pDelatnost),
                new ReportParameter("parKontaktFirme", pKontaktFirme),
                new ReportParameter("parMailFirme", pMailFirme),
                new ReportParameter("parKlauzula", pKlauzula),
            };

            ReportClasses.clRadniNalogPriv rcls = new ReportClasses.clRadniNalogPriv
            {
                Datum = dbDatum,
                BrojNaloga = dbBrojNaloga,
                ImePrezime = dbImePrezime,
                Kontakt = dbKontakt,
                Uredjaj = dbUredjaj,
                Proizvodjac = dbProizvodjac,
                Model = dbModel,
                SerijskiBroj = dbSerijskiBroj,
                Pribor = dbPribor,
                OpisKvara = dbOpisKvara,
                Izvestaj = dbIzvestaj
            };

            //rpv1.LocalReport.ReportPath = @"C:\Users\MasterPro\Documents\Visual Studio 2015\Projects\SenaComp\iflib\Reportovi\rNalogP.rdlc";
            bsRNalog.Add(rcls);
            rpv1.LocalReport.DataSources.Clear();
            rpv1.LocalReport.DataSources.Add(new ReportDataSource("dsNP", bsRNalog));
            rpv1.LocalReport.ReportEmbeddedResource = @"C:\Users\MasterPro\Documents\Visual Studio 2015\Projects\SenaComp\iflib\Reportovi\rNalogP.rdlc";
            rpv1.RefreshReport();

            PrinterSettings prs = new PrinterSettings();

            try
            {
                rpv1.PrintDialog(prs);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            rpv1.RefreshReport();
            bsRNalog.Clear();
        }

    }
}
