using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype.Screens.Security
{
    public partial class VerifyAdmin : Form
    {
        public bool success = false;

        public VerifyAdmin()
        {
            InitializeComponent();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (Passwords.Verify(textBoxPassword.Text, getPasswordHash()))
            {
                success = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Incorrect Password");
            }
        }

        private string getPasswordHash()
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();
            string sql = "SELECT passwordHash FROM tbl_staff WHERE username = @username";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", Globals.currentUsername);

            MySqlDataReader data = command.ExecuteReader();

            data.Read();

            string passwordHash = data.GetString("passwordHash");

            connection.Close();

            return passwordHash;
        }

        private void VerifyAdmin_Shown(object sender, EventArgs e)
        {
            if (!Globals.isAdmin)
            {
                MessageBox.Show("Error: User is not admin", "Error");
                this.Close();
            }
        }
    }
}
