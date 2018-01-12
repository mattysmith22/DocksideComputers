using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype.Screens.Customers
{
    public partial class Edit : Form
    {
        private int customerID;
        private bool forceClose = false;

        public Edit(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            refreshData();
        }

        private void refreshData()
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM tbl_customers WHERE customerID = @customerID";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@customerID", customerID);

            MySqlDataReader data = command.ExecuteReader();

            if (data.Read())
            {
                textBoxFirstname.Text = data.GetString("firstname");
                textBoxSurname.Text = data.GetString("surname");
                textBoxAddress.Text = data.GetString("address");
                textBoxTown.Text = data.GetString("town");
                textBoxCounty.Text = data.GetString("county");
                textBoxMobile.Text = data.GetString("mobile");
                textBoxLandline.Text = data.GetString("landline");
            }

            connection.Close();
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "UPDATE tbl_customers SET firstname=@firstname, surname=@surname, address=@address, town=@town, county=@county, mobile=@mobile, landline=@landline WHERE customerID = @customerID";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@firstname", textBoxFirstname.Text);
            command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@address", textBoxAddress.Text);
            command.Parameters.AddWithValue("@town", textBoxTown.Text);
            command.Parameters.AddWithValue("@county", textBoxCounty.Text);
            command.Parameters.AddWithValue("@mobile", textBoxMobile.Text);
            command.Parameters.AddWithValue("@landline", textBoxLandline.Text);

            command.Parameters.AddWithValue("@customerID", customerID);

            command.ExecuteNonQuery();

            connection.Close();

            forceClose = true;

            this.Close();
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceClose)
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
