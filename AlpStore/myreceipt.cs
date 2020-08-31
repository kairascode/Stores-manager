using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AlpStores
{
    class myreceipt
    {


        public myreceipt() {


        }
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;


        MySqlConnection co = new MySqlConnection();
       // co.Open();

        MySqlCommand reccommnad = new MySqlCommand();
    }
}
