using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Prototype
{
    class Database
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DocksideDatabase"].ConnectionString;
            return new MySqlConnection(connectionString);
        }

        public static MySqlDataAdapter GetDataAdapter(string sql)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlDataAdapter data = new MySqlDataAdapter(sql, connection);
            connection.Close();
            return data;
        }
    }
}
