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
    public partial class Edit : Form
    {
        private bool forceClose = false;
        private int jobID;
        private DateTime completionDate;
        private bool dateIsNull = true;
        private string receiptKey;

        public Edit(int jobID)
        {
            InitializeComponent();

            this.jobID = jobID;
            UpdateData();

            buttonBackdate.Visible = Globals.isAdmin;
            buttonBackdate.Enabled = Globals.isAdmin;
        }

        private void UpdateData()
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();
            string sql = "SELECT * FROM tbl_jobs INNER JOIN tbl_transactions ON tbl_jobs.jobID = tbl_transactions.jobID WHERE tbl_jobs.jobID = @jobID";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@jobID", jobID);

            MySqlDataReader data = command.ExecuteReader();

            data.Read();

            textBoxProblem.Text = data.GetString(data.GetOrdinal("problem"));
            textBoxDetails.Text = data.GetString(data.GetOrdinal("details"));
            textBoxUsername.Text = data.GetString(data.GetOrdinal("computerUsername"));
            textBoxPassword.Text = data.GetString(data.GetOrdinal("computerPassword"));
            checkBoxBackup.Checked = Database.DatabaseToBool(data.GetInt32(data.GetOrdinal("backup")));
            checkBoxFormat.Checked = Database.DatabaseToBool(data.GetInt32(data.GetOrdinal("format")));
            checkBoxNeedCall.Checked = Database.DatabaseToBool(data.GetInt32(data.GetOrdinal("shouldCallBefore")));
            textBoxSpeakTo.Text = data.GetString(data.GetOrdinal("speakingAuthorisation"));
            try
            {
                completionDate = data.GetDateTime(data.GetOrdinal("completionDate"));
                labelCompletionDateData.Text = completionDate.ToString();
                dateIsNull = false;
            }
            catch
            {
                labelCompletionDateData.Text = "Incomplete";
                dateIsNull = true;
            }
            checkBoxLeftMessage.Checked = Database.DatabaseToBool(data.GetOrdinal("leftMessage"));
            numericUpDownAmountPaid.Value = data.GetDecimal(data.GetOrdinal("amountPaid"));
            textBoxPaymentMethod.Text = data.GetString(data.GetOrdinal("paymentMethod"));
            receiptKey = data.GetString(data.GetOrdinal("receiptKey"));
            data.Close();
            connection.Close();
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

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "UPDATE tbl_jobs SET problem = @problem, details = @details, computerUsername = @computerUsername, computerPassword = @computerPassword, backup = @backup, format = @format, shouldCallBefore = @shouldCallBefore, speakingAuthorisation = @speakingAuthorisation, receiptKey = @receiptKey WHERE jobID = @jobID; UPDATE tbl_transactions SET leftMessage = @leftMessage, amountPaid = @amountPaid, paymentMethod = @paymentMethod, staffUsername = @staffUsername, completionDate = @completionDate WHERE jobID = @jobID;";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@jobID", jobID);
            command.Parameters.AddWithValue("@problem", textBoxProblem.Text);
            command.Parameters.AddWithValue("@details", textBoxDetails.Text);
            command.Parameters.AddWithValue("@computerUsername", textBoxUsername.Text);
            command.Parameters.AddWithValue("@computerPassword", textBoxPassword.Text);
            command.Parameters.AddWithValue("@backup", Database.BoolToDatabase(checkBoxBackup.Checked));
            command.Parameters.AddWithValue("@format", Database.BoolToDatabase(checkBoxFormat.Checked));
            command.Parameters.AddWithValue("@shouldCallBefore", Database.BoolToDatabase(checkBoxNeedCall.Checked));
            command.Parameters.AddWithValue("@speakingAuthorisation", textBoxSpeakTo.Text);
            if (!dateIsNull)
            {
                command.Parameters.AddWithValue("@completionDate", completionDate);
            }
            else
            {
                command.Parameters.AddWithValue("@completiondate", null);
            }
            command.Parameters.AddWithValue("@leftMessage", Database.BoolToDatabase(checkBoxLeftMessage.Checked));
            command.Parameters.AddWithValue("@amountPaid", numericUpDownAmountPaid.Value);
            command.Parameters.AddWithValue("@paymentMethod", textBoxPaymentMethod.Text);
            command.Parameters.AddWithValue("@receiptKey", receiptKey);
            command.Parameters.AddWithValue("@staffUsername", Globals.currentUsername);

            command.ExecuteNonQuery();

            connection.Close();

            forceClose = true;
            this.Close();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonMarkComplete_Click(object sender, EventArgs e)
        {
            dateIsNull = false;
            completionDate = DateTime.Now;
            labelCompletionDateData.Text = completionDate.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            dateIsNull = true;
            labelCompletionDateData.Text = "Incomplete";
        }

        private void buttonBackdate_Click(object sender, EventArgs e)
        {
            Screens.Misc.DateTimePicker picker;

            if (dateIsNull)
            {
                picker = new Misc.DateTimePicker();
            }
            else
            {
                picker = new Misc.DateTimePicker(completionDate);
            }

            picker.ShowDialog();

            dateIsNull = picker.isNull;
            if(!picker.isNull)
            {
                labelCompletionDateData.Text = completionDate.ToString();
                completionDate = picker.value;
            }
            else
            {
                labelCompletionDateData.Text = "Incomplete";
            }
        }
    }
}
