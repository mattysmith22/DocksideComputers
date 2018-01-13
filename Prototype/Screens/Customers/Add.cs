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
    public partial class Add : Form
    {

        private bool shouldPopUp = false;

        public Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "INSERT INTO tbl_customers (firstname, surname, address, town, county, landline, mobile) VALUES (@firstname, @surname, @address, @town, @county, @landline, @mobile)";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@firstname", textBoxFirstname.Text);
            command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@address", textBoxAddress.Text);
            command.Parameters.AddWithValue("@town", textBoxTown.Text);
            command.Parameters.AddWithValue("@county", textBoxCounty.Text);
            command.Parameters.AddWithValue("@landline", textBoxLandline.Text);
            command.Parameters.AddWithValue("@mobile", textBoxMobile.Text);

            command.ExecuteNonQuery();

            connection.Close();

            shouldPopUp = false;

            this.Close();
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

        private void ChangeMade(object sender, EventArgs e)
        {
            shouldPopUp = true;
        }
    }
}
