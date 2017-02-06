using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Prototype.Screens.Customers
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
            adminToolStripMenuItem.Visible = Globals.isAdmin; //Only show admin menus if the user is an administrator
            updateDataTable();
        }

        private void updateDataTable() //Does what it says on the tin
        {
            //Get relevant data
            string sql = "SELECT customerID, firstname, surname FROM tbl_customers";
            MySqlDataAdapter data = Database.GetDataAdapter(sql);

            using(DataTable dt = new DataTable()) //Increases efficiency
            {
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            } 
        }

        private int getSelectedCustomerID()//Gets the ID of the selected customer in the dataGridView
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            return (int)dataGridView1.Rows[rowIndex].Cells["customerID"].Value;
        }

        private void updateDataList() //Updates the in-depth list of details on the right-hand side of the selected customer
        {
            Debug.WriteLine("Selected cells:" + dataGridView1.SelectedCells.Count.ToString());
            if (dataGridView1.SelectedCells.Count== 1)
            {
                int customerID = getSelectedCustomerID(); //Get the ID of the selected customer

                MySqlConnection connection = Database.GetConnection(); //Open database connection
                connection.Open();

                string sql = "SELECT * FROM tbl_customers WHERE customerID = @id"; //Create query
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", customerID);

                MySqlDataReader data = command.ExecuteReader(); //Get Data

                if (data.Read()) //If any is selected at all
                {
                    labelFirstname.Text = "Firstname: " + data.GetString("firstname"); //Copy data into labels
                    labelSurname.Text = "Surname: " + data.GetString("surname");
                    labelAddress.Text = "Address: " + data.GetString("address");
                    labelTown.Text = "Town: " + data.GetString("town");
                    labelCounty.Text = "County: " + data.GetString("county");
                    labelLandline.Text = "Landline: " + data.GetString("landline");
                    labelMobile.Text = "Mobile: " + data.GetString("mobile");
                }
                connection.Close(); //Cleanup
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Functionality not added as this is a prototype
            MessageBox.Show("This is a prototype, this functionality has not been added");
        }

        private void buttonViewJobs_Click(object sender, EventArgs e)
        {
            Screens.Jobs.SeeCustomerJobs viewJobs = new Jobs.SeeCustomerJobs(getSelectedCustomerID());
            viewJobs.ShowDialog();
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            Jobs.Add addJobScreen = new Jobs.Add(getSelectedCustomerID());
            addJobScreen.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            updateDataList();
        }


    }
}
