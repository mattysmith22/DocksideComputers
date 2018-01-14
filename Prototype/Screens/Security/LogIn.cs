using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

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
            string errormessage;
            if(Database.IsDatabaseConnected(out errormessage))
            {
                labelConnectionStatus.ForeColor = Color.Green;
                labelConnectionStatus.Text = "Connected";
                toolTip.SetToolTip(labelConnectionStatus, "Connection success");
            }
            else
            {
                labelConnectionStatus.ForeColor = Color.Red;
                labelConnectionStatus.Text = "Disconnected";
                toolTip.SetToolTip(labelConnectionStatus, errormessage);
            }
        }

        //Verifies the logon credentials
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //Open the connection to the database
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            //Get data for user
            string sql = "SELECT * FROM tbl_staff WHERE username = @username";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", textBoxUsername.Text);
            MySqlDataReader data = command.ExecuteReader();

            if (data.Read()) //If there is a result to read
            {
                string actualHash = data.GetString("passwordHash"); //Get actual password
                Debug.WriteLine(actualHash);
                bool result = Passwords.Verify(textBoxPassword.Text, actualHash); //Check against inputted password

                if (result) //If the password is correct
                {
                    isLoggedIn = true;
                    username = textBoxUsername.Text;
                    isAdmin = data.GetBoolean("isAdmin");
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

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buttonLogIn.PerformClick();
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }
    }
}
