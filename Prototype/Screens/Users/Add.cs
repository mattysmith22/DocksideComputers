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
    public partial class Add : Form
    {
        private bool shouldPopUp = false;

        public Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string message;
            if(isUsernameValid(out message))
            {
                if(isPasswordValid(out message))
                {
                    MySqlConnection connection = Database.GetConnection();
                    connection.Open();

                    string sql = "INSERT INTO tbl_staff (username, passwordHash, isAdmin) VALUES (@username, @passwordHash, @isAdmin);";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@passwordHash", Passwords.GetHash(textBoxPassword.Text));
                    command.Parameters.AddWithValue("@isAdmin", Database.BoolToDatabase(checkBoxIsAdmin.Checked));
                    
                    if(command.ExecuteNonQuery()==1) //If the addition was a success
                    {
                        MessageBox.Show("User " + textBoxUsername.Text + " added successfully.", "Success");
                        shouldPopUp = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: User not added", "Error");
                    }
                }
                else
                {
                    MessageBox.Show(message, "Password");
                }
            }
            else
            {
                MessageBox.Show(message, "Username");
            }
        }

        private bool isPasswordValid(out string message)
        {
            string password = labelPassword.Text;
            if (password.Trim().Length == 0)
            {
                message = "Password must not be empty";
                return false;
            }
            else
            {
                message = "Valid password";
                return true;
            }
        }

        private bool isUsernameValid(out string message)
        {
            string username = textBoxUsername.Text;
            if(username.Trim().Length == 0)
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

        private void ChangeMade(object sender, EventArgs e)
        {
            shouldPopUp = true;
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
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
