using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iflib
{
    public static class cGlobalVariables
    {
        public static string localDB = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\Sena\SenaComp\dbSenaComp.mdf";
        public static string zeroDB = "dbSenaComp.mdf";
    }
}
