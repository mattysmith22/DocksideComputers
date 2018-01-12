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
        FilterOptions filterOptions;

        public Find()
        {
            InitializeComponent();
            adminToolStripMenuItem.Visible = Globals.isAdmin; //Only show admin menus if the user is an administrator
            updateDataTable();

            filterOptions = new FilterOptions();
            filterOptions.firstname = "";
            filterOptions.surname = "";
            filterOptions.mobile = "";
            filterOptions.landline = "";
        }

        private void updateDataTable() //Does what it says on the tin
        {
            //Get relevant data
            string sql = "SELECT customerID, firstname, surname FROM tbl_customers";
            MySqlDataAdapter data = Database.GetDataAdapter(sql);

            using (DataTable dt = new DataTable()) //Increases efficiency
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
            if (dataGridView1.SelectedCells.Count == 1)
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
                    textBoxCustomerData.Text= "Firstname: " + data.GetString("firstname") + Environment.NewLine +
                    "Surname: " + data.GetString("surname") + Environment.NewLine +
                    "Address: " + data.GetString("address") + Environment.NewLine +
                    "Town: " + data.GetString("town") + Environment.NewLine +
                    "County: " + data.GetString("county") + Environment.NewLine +
                    "Landline: " + data.GetString("landline") + Environment.NewLine +
                    "Mobile: " + data.GetString("mobile");
                }
                connection.Close(); //Cleanup
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
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
                    Printing.PrintReceipt document = new Printing.PrintReceipt(getSelectedCustomerID(),
                        data.GetString("firstname"),
                        data.GetString("surname"),
                        data.GetString("address"),
                        data.GetString("town"),
                        data.GetString("county"),
                        data.GetString("landline"),
                        data.GetString("mobile"));

                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        document.PrinterSettings = printDialog1.PrinterSettings;
                        document.Print();
                    }
                }
                connection.Close(); //Cleanup
            }
        }

        private void buttonViewJobs_Click(object sender, EventArgs e)
        {
            Screens.Jobs.SeeCustomerJobs viewJobs = new Jobs.SeeCustomerJobs(getSelectedCustomerID());
            viewJobs.ShowDialog();
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            Jobs.Add addJobScreen = new Jobs.Add(getSelectedCustomerID());
            addJobScreen.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            updateDataList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customers.Add addCustomerScreen = new Add();
            addCustomerScreen.ShowDialog();

            updateDataTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Security.VerifyAdmin verifyAdminScreen = new Security.VerifyAdmin();
            verifyAdminScreen.ShowDialog();

            if (verifyAdminScreen.success)
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    MySqlConnection connection = Database.GetConnection();
                    connection.Open();
                    string sql = "DELETE FROM tbl_customers WHERE customerID = @customerID";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@customerID", getSelectedCustomerID());

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Error: Customer not properly highlighted");
                }
                updateDataTable();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                Customers.Edit editScreen = new Edit(getSelectedCustomerID());
                editScreen.ShowDialog();
                updateDataTable();
                updateDataList();
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter filterScreen = new Filter(filterOptions);
            filterScreen.ShowDialog();

            filterOptions = filterScreen.filterOptions;
        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("As this is a prototype, filtering has not been implemented");
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reply = MessageBox.Show("Do you want to close the program?", "Are you sure?", MessageBoxButtons.YesNo);
            if (reply == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.ChangePassword changePassword = new Security.ChangePassword(Globals.currentUsername);
            changePassword.ShowDialog();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }
    }
}