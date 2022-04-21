using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace uclib.Opcije
{
    public class conStringManager
    {
        SqlConnection cn;
        public conStringManager(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

        public bool isConnected
        {
            get
            {
                if(cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();                   
                }
                return true;
            }
        }
    }

    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
