using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Prototype
{
    class Receipts
    {
        public static string GetRandomString()
        {
            Random random = new Random();
            StringBuilder possibleKey = new StringBuilder();
            string characters = "1234567890abcdefghijklmnopqrstuvwxyz";

            possibleKey = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                possibleKey.Append(characters[random.Next(0, characters.Length)]);
            }
            return possibleKey.ToString();
        }

        public static string GenerateReceiptKey()
        {
            bool unique = false;

            MySqlConnection connection = Database.GetConnection();
            connection.Open();
            
            string sql = "SELECT * FROM tbl_jobs WHERE receiptKey = @receiptKey";
            MySqlCommand command;
            MySqlDataReader data;

            string possibleReceipt;

            do
            {
                possibleReceipt = GetRandomString();

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@receiptKey", possibleReceipt);

                data = command.ExecuteReader();

                unique = !data.Read();
            }
            while (!unique);

            return possibleReceipt;
        }
    }
}
