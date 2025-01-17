using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ağ.Siniflar
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7ICBQ5T\\A;Initial Catalog=Gezi;Integrated Security=True;Encrypt=False");
        
        public static void CheckConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }

        }
    }
}