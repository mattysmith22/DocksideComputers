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
    public partial class ChangePassword : Form
    {
        private string username;
        private bool isAdmin;

        public ChangePassword(string username, bool isAdmin = false)
        {
            InitializeComponent();
            this.username = username;
            this.isAdmin = isAdmin;

            textBoxNew.Enabled = !isAdmin;
            textBoxNewConfirm.Enabled = !isAdmin;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(textBoxNew.Text == textBoxNewConfirm.Text)
            {
                MySqlConnection connection = Database.GetConnection();
                connection.Open();
                string sql = "SELECT passwordHash FROM tbl_staff WHERE username = @username;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader data = command.ExecuteReader();
                data.Read();
                
                if(isAdmin || (Passwords.Verify(textBoxOld.Text, data.GetString(data.GetOrdinal("passwordHash")))))
                {
                    data.Close();

                    sql = "UPDATE tbl_staff SET passwordHash = @passwordHash WHERE username = @username;";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", Passwords.GetHash(textBoxNew.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password Changed");
                    this.Close();
                } else
                {
                    data.Close();
                    MessageBox.Show("Incorrect current password, please try again");
                    textBoxOld.Text = "";
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("The two new passwords do not match, please try again");
                textBoxNew.Text = "";
                textBoxNewConfirm.Text = "";
            }
        }
    }
}
