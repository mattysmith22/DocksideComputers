using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Prototype.Screens.Security
{
    public partial class LogIn : Form
    {
        public bool isLoggedIn { get; private set; }
        public string username { get; private set; }
        public bool isAdmin { get; private set; }

        public LogIn()
        {
            InitializeComponent();
        }

        //Verifies the logon credentials
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //Open the connection to the database
            SQLiteConnection connection = Database.GetConnection();
            connection.Open();

            //Get data for user
            string sql = "SELECT * FROM tbl_staff WHERE username = @username";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@username", textBoxUsername.Text);
            SQLiteDataReader data = command.ExecuteReader();

            if (data.Read()) //If there is a result to read
            {
                string actualHash = data.GetString(data.GetOrdinal("passwordHash")); //Get actual password
                bool result = Passwords.Verify(textBoxPassword.Text, actualHash); //Check against inputted password

                if (result) //If the password is correct
                {
                    isLoggedIn = true;
                    username = textBoxUsername.Text;
                    isAdmin = data.GetBoolean(data.GetOrdinal("isAdmin"));
                    //Set data

                    this.Close(); //Close the window
                }
                else
                {
                    MessageBox.Show("Error: Incorrect password");
                }
            }
            else
            {
                MessageBox.Show("Error: Incorrect username");
            }
        }
    }
}
