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
    public partial class SeeCustomerJobs : Form
    {
        private int customerID;

        public SeeCustomerJobs(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            string sql = "SELECT jobID, receiptKey, problem FROM tbl_jobs WHERE customerID = @customerID";
            MySqlDataAdapter data = Database.GetDataAdapter(sql);

            data.SelectCommand.Parameters.AddWithValue("@customerID", customerID);

            using (DataTable dt = new DataTable()) //Increases efficiency
            {
                data.Fill(dt);
                dataGridViewJobs.DataSource = dt;
            } 
        }

        private int GetSelectedJobId()
        {
            int rowIndex = dataGridViewJobs.SelectedCells[0].RowIndex;
            return (int)dataGridViewJobs.Rows[rowIndex].Cells["jobID"].Value;
        }

        private void UpdateData()
        {
            if (dataGridViewJobs.SelectedCells.Count > 0)
            {
                MySqlConnection connection = Database.GetConnection();
                connection.Open();

                string sql = "SELECT problem, details FROM tbl_jobs WHERE jobID = @jobID";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@jobID", GetSelectedJobId());

                MySqlDataReader data = command.ExecuteReader();

                data.Read();

                textBoxProblem.Text = data.GetString(data.GetOrdinal("problem"));
                textBoxDetails.Text = data.GetString(data.GetOrdinal("details"));
            }
        }

        private void dataGridViewJobs_SelectionChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (dataGridViewJobs.SelectedCells.Count > 0)
            {
                Jobs.View viewJob = new View(GetSelectedJobId());
                viewJob.ShowDialog();
            }
        }
    }
}
