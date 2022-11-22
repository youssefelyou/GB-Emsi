using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.Classes
{
    internal class Connexion
    {
        public MySqlConnection connMaster;
        public void Connection()
        {
            connMaster = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=;database=twengo");
        }
        public void connOpen()
        {
            connMaster.Open();
        }
        public void connclose()
        {
            connMaster.Close();
        }
    }
}
