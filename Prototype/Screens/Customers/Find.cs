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

            buttonDelete.Visible = Globals.isAdmin; //Only show admin menus if the user is an administrator
            adminToolStripMenuItem.Visible = Globals.isAdmin;

            updateDataTable();

            toolTip.SetToolTip(textBoxQuery, "Search options for customers");
            toolTip.SetToolTip(buttonSearch, "Run the typed-in search");
            toolTip.SetToolTip(buttonAdd, "Add a new customer");
            toolTip.SetToolTip(buttonAddJob, "Add a job to the selected customer");
            toolTip.SetToolTip(buttonDelete, "Delete the selected customer");
            toolTip.SetToolTip(buttonViewJobs, "View all jobs stored by a customer");
            toolTip.SetToolTip(buttonEdit, "Edit a customer's details");
            toolTip.SetToolTip(buttonPrint, "Print out the details of a customer");
            toolTip.SetToolTip(buttonExit, "Log out of the current account");
        }

        private void updateDataTable() //Does what it says on the tin
        {
            string sql;

            //Get relevant data
            if (textBoxQuery.Text.Trim().Length != 0 && checkBoxEnableQuery.Checked) //if there is something in query box
            {
                sql = "SELECT * FROM tbl_customers WHERE MATCH (firstname, surname, address, town, county, mobile, landline) AGAINST (@query IN NATURAL LANGUAGE MODE)"; //Create query
            }
            else
            {
                sql = "SELECT * FROM tbl_customers"; //Create query
            }
            MySqlDataAdapter data = Database.GetDataAdapter(sql);
            data.SelectCommand.Parameters.AddWithValue("@query", textBoxQuery.Text);

            using (DataTable dt = new DataTable()) //Increases efficiency
            {
                data.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows.Count == 0 && checkBoxEnableQuery.Checked)
                {
                    MessageBox.Show("The query released no customers.", "No results");
                }
            }
        }

        private int getSelectedCustomerID()//Gets the ID of the selected customer in the dataGridView
        {
            return (int)dataGridView1.SelectedRows[0].Cells["customerID"].Value;
        }

        private void updateDataList() //Updates the in-depth list of details on the right-hand side of the selected customer
        {
            MySqlCommand command;

            Debug.WriteLine("Selected cells:" + dataGridView1.SelectedCells.Count.ToString());
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int customerID = getSelectedCustomerID(); //Get the ID of the selected customer

                MySqlConnection connection = Database.GetConnection(); //Open database connection
                connection.Open();

                string sql = "SELECT * FROM tbl_customers WHERE customerID = @id"; //Create query
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", customerID);

                MySqlDataReader data = command.ExecuteReader(); //Get Data

                if (data.Read()) //If any is selected at all
                {
                    textBoxCustomerData.Text = "Firstname: " + data.GetString("firstname") + Environment.NewLine +
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

        #region Toolstrip Event Handler
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.ChangePassword changePassword = new Security.ChangePassword(Globals.currentUsername);
            changePassword.ShowDialog();
        }

        private void viewUnfinishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobs.ViewUnfinished viewUnfinished = new Jobs.ViewUnfinished();
            viewUnfinished.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.Add addUser = new Users.Add();
            addUser.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.View viewUser = new Users.View();
            viewUser.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup.Save saveBackup = new Backup.Save();
            saveBackup.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup.Open openBackup = new Backup.Open();
            openBackup.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.About about = new Misc.About();
            about.ShowDialog();
        }
        #endregion

        private void verifyReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.GetReceiptString receiptString = new Misc.GetReceiptString();
            receiptString.ShowDialog();

            string receiptCode = receiptString.receiptCode;
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM tbl_jobs WHERE receiptKey = @receiptCode";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@receiptcode", receiptCode);

            MySqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                DialogResult result = MessageBox.Show("Job Found, would you like to open?", "Success", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Jobs.View viewJob = new Jobs.View(reader.GetInt32("jobID"));
                    viewJob.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid receipt code, please try again");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            updateDataTable();
        }

        private void textBoxQuery_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                updateDataTable();
            }
        }

        private void checkBoxEnableQuery_CheckedChanged(object sender, EventArgs e)
        {
            updateDataTable();
        }
    }
}