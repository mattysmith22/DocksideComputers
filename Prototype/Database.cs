using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Configuration;

namespace Prototype
{
    class Database
    {
        public static SQLiteConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DocksideDatabase"].ConnectionString;
            return new SQLiteConnection(connectionString);
        }

        public static SQLiteDataAdapter GetDataAdapter(string sql)
        {
            SQLiteConnection connection = GetConnection();
            connection.Open();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql, connection);
            connection.Close();
            return data;
        }
    }
}
