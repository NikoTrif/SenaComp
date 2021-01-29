using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iflib
{
    public class clFunkcijeRazno
    {
        public string FormatKontakt(string kontakt)
        {
            string[] tel = kontakt.Split(' ');
            string formTel = "";
            foreach(string s in tel)
            {
                if (s.Length == 9)
                {
                    //ovde sam stao
                }
            }
            return formTel; //promeni da bude string od arraya tel
        }
    }
}
