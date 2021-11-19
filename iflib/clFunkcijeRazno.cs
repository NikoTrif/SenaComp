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

        public static bool ProveraNoviRed(string kolonaIme)
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

        public static void NapisiLog(Exception ex)
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
            //potrebno ubaciti racunicu za iznos PDV-a
            try
            {
                if (KalkulatorCenaArt.ProdajnaCena == 0)
                {
                    //dodaj racunicu
                    KalkulatorCenaArt.CenaBezPDV = KalkulatorCenaArt.NabavnaCena * (1 - (KalkulatorCenaArt.Rabat / 100)) * (1 + (KalkulatorCenaArt.Marza / 100));
                    KalkulatorCenaArt.iznosPDV = KalkulatorCenaArt.CenaBezPDV / 100 * KalkulatorCenaArt.PDV;
                    KalkulatorCenaArt.ProdajnaCena = KalkulatorCenaArt.CenaBezPDV * (1 + (KalkulatorCenaArt.PDV / 100));
                }

                else
                {
                    /* 
                    NC - Nabavna cena | R - Rabat | M - Marza | NPDV - Cena bez PDV-a | PDV - PDV | PC - Prodajna cena

                    NC = 1256
                    R = 5%
                    M = 23%
                    NPDV = 1467.636
                    PDV = 20%
                    PC = 1761.636

                    NPDV * PDV = PC
                    [(NC * R) * M] * PDV = PC
                    { NC * [1 - (R / 100)] * [1 + (M / 100)]} * [1 + (PDV / 100)] = PC

                    NPDV = PC / PDV
                    NPDV = PC / [1 + (PDV / 100)]
                    NPDV = 1761,163 / [1 + (20 / 100)]
                    NPDV = 1761,163 / 1,2
                    NPDV = 1467,636

                    {NC * [1 - (R / 100)]} * [1 + (M / 100)] = NPDV
                    [1+(M/100)] = NPDV / { NC * [1 - (R / 100)]}
                    [1+(M/100)] = 1467,636 / {1256 * [1-(5/100)]}
                    [1+(M/100)] = 1467,636 / {1256 * [1 - 0, 05]}
                    [1+(M/100)] = 1467,636 / {1256 * 0,95}
                    [1+(M/100)] = 1467,636 / {1256 * 0,95}
                    [1+(M/100)] = 1467,636 / 1193,2
                    [1+(M/100)] =1,23
                    (M/100) = 1,23 - 1
                    (M/100) = 0,23
                    M = 0,23 * 100
                    M = 23

                    => M = (NPDV / (NC * (1 - (R / 100))) - 1) * 100
                    */

                    KalkulatorCenaArt.CenaBezPDV = KalkulatorCenaArt.ProdajnaCena / (1 + (KalkulatorCenaArt.PDV / 100));
                    KalkulatorCenaArt.iznosPDV = KalkulatorCenaArt.CenaBezPDV / 100 * KalkulatorCenaArt.PDV;
                    KalkulatorCenaArt.Marza = (KalkulatorCenaArt.CenaBezPDV / (KalkulatorCenaArt.NabavnaCena * (1 - (KalkulatorCenaArt.Rabat / 100))) - 1) * 100;
                }
            }
            catch (Exception ex)
            {
                NapisiLog(ex);
            }
        }

        public static void ClearTransfer()
        {
            clTransfer.IDFirme = null;
            clTransfer.Firma = null;
            clTransfer.Kontakt = null;
            clTransfer.eMail = null;
            clTransfer.PIB = null;
            clTransfer.MatBr = null;
            clTransfer.Grad = null;
            clTransfer.Adresa = null;
        }

        /// <summary>
        /// Racuna Cenu i upisuje label TOTAL
        /// </summary>
        /// <param name="direktnaIzmena">true - ako je napravljena izmena iz DataGridView-a; false - ako nije</param>
        /// <param name="Brisanje">True - ako se artikal brise, False - ako se artikal unosi</param>
        /// <param name="dgvPFOArtikli">DataGridView Artikala za upis u (pro)Fakturu / otpremnicu</param>
        /// <param name="dgvArtikli">DataGridView sa svim artiklima iz baze artikala</param>
        /// <param name="lTotal">Label sa ukupnom cenom - lTotal</param>
        /// <param name="Valuta">Vrednost iz tbValuta</param>
        /// <param name="ArtikalKolicina">vrednost iz tbArtKol - kolicina artikla</param>
        public static void RacunCenaITotal(bool direktnaIzmena, bool Brisanje, DataGridView dgvPFOArtikli, DataGridView dgvArtikli, Label lTotal, string Valuta, string ArtikalKolicina)
        {
            string naziv, jedinica;
            float total = 0;
            float x = 0;
            float cenaSaPDV = 0;
            float cena = 0; //cena bez PDV-a iz kolone 1
            float pdv = 0;
            float izPdv = 0;
            float kol = 0;
            float uCena = 0;

            try
            {
                if (!Brisanje)
                {
                    if (direktnaIzmena == true)
                    {
                        float.TryParse(dgvPFOArtikli.CurrentRow.Cells[2].Value.ToString(), out pdv);
                        float.TryParse(dgvPFOArtikli.CurrentRow.Cells[3].Value.ToString(), out kol);
                        float.TryParse(dgvPFOArtikli.CurrentRow.Cells[1].Value.ToString(), out cena);
                        Math.Round(cena, 2);
                        izPdv = (cena / 100 * pdv) * kol;
                        Math.Round(izPdv, 2);
                        cenaSaPDV = cena * ((pdv / 100) + 1);
                        Math.Round(cenaSaPDV, 2);
                        uCena = cenaSaPDV * kol;
                        Math.Round(uCena, 2);

                        dgvPFOArtikli.CurrentRow.Cells[7].Value = cenaSaPDV;
                        dgvPFOArtikli.CurrentRow.Cells[6].Value = uCena;
                        dgvPFOArtikli.CurrentRow.Cells[5].Value = izPdv;
                    }

                    else
                    {
                        naziv = dgvArtikli.CurrentRow.Cells[1].Value.ToString();
                        jedinica = dgvArtikli.CurrentRow.Cells[2].Value.ToString();
                        float.TryParse(dgvArtikli.CurrentRow.Cells[4].Value.ToString(), out cena);
                        Math.Round(cena, 2);
                        float.TryParse(dgvArtikli.CurrentRow.Cells[5].Value.ToString(), out pdv);
                        float.TryParse(ArtikalKolicina, out kol);
                        float.TryParse(dgvArtikli.CurrentRow.Cells[6].Value.ToString(), out izPdv);
                        Math.Round(izPdv, 2);
                        float.TryParse(dgvArtikli.CurrentRow.Cells[7].Value.ToString(), out cenaSaPDV);
                        Math.Round(cenaSaPDV, 2);
                        uCena = cenaSaPDV * kol;
                        Math.Round(uCena, 2);

                        dgvPFOArtikli.Rows.Add(naziv, cena, pdv, izPdv * kol, kol, jedinica, uCena, cenaSaPDV);
                    }

                    foreach (DataGridViewRow dgvr in dgvPFOArtikli.Rows)
                    {
                        if (dgvr.Cells[6].Value != null)
                        {
                            float.TryParse(dgvr.Cells[6].Value.ToString(), out x);
                            total = total + x;
                            x = 0;
                        }
                    } 
                }
                else
                {
                    foreach (DataGridViewRow dgvr in dgvPFOArtikli.Rows)
                    {
                        if (!dgvr.IsNewRow)
                        {
                            float.TryParse(dgvr.Cells[6].Value.ToString(), out x);
                            total = total + x;
                            x = 0;
                        }
                        else if (dgvr.IsNewRow && dgvPFOArtikli.RowCount <= 1)
                        {
                            total = 0;
                            x = 0;
                        }
                    }
                }

                lTotal.Text = string.Format("{0} {1}", total.ToString(), Valuta);
            }
            catch (Exception ex)
            {
                clFunkcijeRazno.NapisiLog(ex);
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
            public static double iznosPDV = 0;
            public static double ProdajnaCena = 0;
        }
    }
}
