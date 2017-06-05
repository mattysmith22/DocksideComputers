using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype.Screens.Jobs
{
    public partial class Add : Form
    {
        private int customerID;
        private bool forceClose = false;

        public Add(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "INSERT INTO tbl_jobs (customerID, problem, details, computerUsername, computerPassword, backup, format, shouldCallBefore, speakingAuthorisation, receiptKey) VALUES (@customerID, @problem, @details, @computerUsername, @computerPassword, @backup, @format, @shouldCallBefore, @speakingAuthorisation, @receiptKey); INSERT INTO tbl_transactions (jobID, cost, phonedCustomer, leftMessage, amountPaid, paymentMethod, staffUsername) VALUES (LAST_INSERT_ID(), 0.00, 0, 0, 0.00, '', '');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            command.Parameters.AddWithValue("@customerID", customerID);
            command.Parameters.AddWithValue("@problem", textBoxProblem.Text);
            command.Parameters.AddWithValue("@details", textBoxDetails.Text);
            command.Parameters.AddWithValue("@computerUsername", textBoxUsername.Text);
            command.Parameters.AddWithValue("@computerPassword", textBoxPassword.Text);
            command.Parameters.AddWithValue("@backup", Database.BoolToDatabase(checkBoxBackup.Checked));
            command.Parameters.AddWithValue("@format", Database.BoolToDatabase(checkBoxFormat.Checked));
            command.Parameters.AddWithValue("@shouldCallBefore", Database.BoolToDatabase(checkBoxNeedCall.Checked));
            command.Parameters.AddWithValue("@speakingAuthorisation", textBoxSpeakTo.Text);
            command.Parameters.AddWithValue("@receiptKey", Receipts.GenerateReceiptKey());

            command.ExecuteNonQuery();

            connection.Close();

            forceClose = true;

            this.Close();
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
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
