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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            updateDataTable();
        }

        private void updateDataTable() //Does what it says on the tin
        {
            //Get relevant data
            string sql = "SELECT username, isAdmin FROM tbl_staff";
            MySqlDataAdapter data = Database.GetDataAdapter(sql);

            using (DataTable dt = new DataTable()) //Increases efficiency
            {
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private string getSelectedUsername()//Gets the ID of the selected customer in the dataGridView
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            return (string)dataGridView1.Rows[rowIndex].Cells["username"].Value;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit editUser = new Edit(getSelectedUsername());
            editUser.ShowDialog();
            updateDataTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add addUser = new Add();
            addUser.ShowDialog();
            updateDataTable();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string user = getSelectedUsername();
            if (MessageBox.Show("Are you sure you want to delete " + user + "?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (user == Globals.currentUsername)
                {
                    MessageBox.Show("Error: tried to delete current user");
                }
                else
                {
                    MySqlConnection connection = Database.GetConnection();
                    connection.Open();

                    string sql = "DELETE FROM tbl_staff WHERE username = @username";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", user);

                    if (command.ExecuteNonQuery() == 1) //If one row has been affected (one has been deleted)
                    {
                        MessageBox.Show("User deleted", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Error: user not deleted", "Error");
                    }
                    updateDataTable();
                }
            }
        }
    }
}
