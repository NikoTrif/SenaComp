using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iflib.ReportClasses
{
    public class clProfaktura
    {
        public int BrojProfakture { get; set; }
        public string Datum { get; set; }
        public string Klauzula { get; set; }
        public string IDKlijenta { get; set; }
        public string Klijent { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string PIB { get; set; }
        public string MatBr { get; set; }
        public float uStopaPDV { get; set; }
        public float uIznosPDV { get; set; } // ukupan iznos PDV-a
        public float Total { get; set; }
    }

    public class clRoba
    {
        public string Opis { get; set; }
        public float Kolicina { get; set; }
        public string JedinicaMere { get; set; }
        public float Cena { get; set; }        
        public float IznosBezPDV { get; set; }
        public float PDV { get; set; }
        public float IznosPDV { get; set; }
        public float UkupnaCena { get; set; }
    }
}
