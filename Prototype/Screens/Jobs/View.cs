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
    public partial class View : Form
    {
        private int jobID;
        private string receiptKey;

        public View(int jobID)
        {
            InitializeComponent();
            this.jobID = jobID;
            loadData();
        }

        private void loadData()
        {
            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM tbl_jobs, tbl_transactions WHERE tbl_jobs.jobID = @jobID AND tbl_transactions.jobID = @jobID";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@jobID", jobID);

            MySqlDataReader data = command.ExecuteReader();

            if (data.Read())
            {
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
                    labelCompletionDateData.Text = data.GetDateTime(data.GetOrdinal("completionDate")).ToString();
                }
                catch
                {
                    labelCompletionDateData.Text = "Incomplete";
                }
                receiptKey = data.GetString(data.GetOrdinal("receiptKey"));
                checkBoxLeftMessage.Checked = Database.DatabaseToBool(data.GetInt32(data.GetOrdinal("leftMessage")));
                textBoxAmountPaid.Text = data.GetDecimal(data.GetOrdinal("amountPaid")).ToString();
                textBoxPaymentMethod.Text = data.GetString(data.GetOrdinal("paymentMethod"));
                textBoxStaffMember.Text = data.GetString(data.GetOrdinal("staffUsername"));
            }
            else
            {
                MessageBox.Show("Error: Could not retrieve job");
                this.Close();
            }
            connection.Close();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            Misc.GetReceiptString getReceiptString = new Misc.GetReceiptString();
            getReceiptString.ShowDialog();

            MySqlConnection connection = Database.GetConnection();
            connection.Open();

            string sql = "SELECT jobID FROM tbl_jobs WHERE receiptKey = @receiptKey";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@receiptKey", getReceiptString.receiptCode);

            MySqlDataReader data = command.ExecuteReader();
            if (data.Read())
            {
                if (data.GetInt32(data.GetOrdinal("jobID")) == jobID)
                {
                    MessageBox.Show("Receipt is valid");
                }
                else
                {
                    MessageBox.Show("Receipt is invalid");
                }
            }
            else
            {
                MessageBox.Show("Receipt is invalid");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Screens.Jobs.Edit editScreen = new Edit(jobID);
            editScreen.ShowDialog();
            loadData();
        }
    }
}
