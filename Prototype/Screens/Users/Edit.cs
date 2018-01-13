using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype.Screens.Users
{
    public partial class Edit : Form
    {
        private bool shouldPopUp = false;
        private string username; 

        public Edit(string username)
        {
            InitializeComponent();

            this.username = username;
            populateData();
        }

        private void ChangeMade(object sender, EventArgs e)
        {
            shouldPopUp = true;
        }

        private void populateData()
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM tbl_staff WHERE username=@username;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBoxUsername.Text = reader.GetString("username");
                checkBoxIsAdmin.Checked = Database.DatabaseToBool(reader.GetInt32("isAdmin"));
            }
            else
            {
                MessageBox.Show("Error: Couldn't find staff member", "Error");
                shouldPopUp = false;
                this.Close();
            }
        }

        private bool isUsernameValid(out string message)
        {
            string username = textBoxUsername.Text;
            if (username.Trim().Length == 0)
            {
                message = "Username must not be empty";
                return false;
            }

            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM tbl_staff WHERE username=@username";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) //If there is an existing user with this username
            {
                message = "Username " + username + " already taken";
                return false;
            }
            message = "Username valid";
            return true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Security.ChangePassword changePassword = new Security.ChangePassword(username, true);
            changePassword.ShowDialog();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string message;
            if (isUsernameValid(out message) || textBoxUsername.Text == username)
            {
                MySqlConnection connection = Database.GetConnection();
                connection.Open();

                string sql = "UPDATE tbl_staff SET username=@usernameFinal, isAdmin=@isAdmin WHERE username=@usernameInitial";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@usernameFinal", textBoxUsername.Text);
                command.Parameters.AddWithValue("@isAdmin", Database.BoolToDatabase(checkBoxIsAdmin.Checked));
                command.Parameters.AddWithValue("@usernameInitial", username);

                if(command.ExecuteNonQuery() == 1) //If the staff member was changed
                {
                    MessageBox.Show("User changed", "Success");
                    shouldPopUp = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User not changed", "Failure");
                }
            }
            else
            {
                MessageBox.Show(message, "Username");
            }
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldPopUp)
            {
                DialogResult reply = MessageBox.Show("Do you want to close the form?", "Are you sure?", MessageBoxButtons.YesNo);
                if (reply == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
