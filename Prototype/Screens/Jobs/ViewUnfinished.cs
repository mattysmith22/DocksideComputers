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
    public partial class ViewUnfinished : Form
    {
        public ViewUnfinished()
        {
            InitializeComponent();
            fillTable();
        }

        private void fillTable()
        {
            //Get relevant data
            string sql = "SELECT tbl_jobs.jobID, tbl_jobs.problem, tbl_jobs.receiptKey, tbl_jobs.problem, tbl_jobs.details FROM tbl_jobs INNER JOIN tbl_transactions ON tbl_jobs.jobID=tbl_transactions.jobID WHERE tbl_transactions.completionDate IS NULL;";
            MySqlDataAdapter data = Database.GetDataAdapter(sql);

            using (DataTable dt = new DataTable()) //Increases efficiency
            {
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private int getSelectedJobID()//Gets the ID of the selected customer in the dataGridView
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            return (int)dataGridView1.Rows[rowIndex].Cells["jobID"].Value;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                textBoxProblem.Text = (string)dataGridView1.Rows[rowIndex].Cells["problem"].Value;
                textBoxDetails.Text = (string)dataGridView1.Rows[rowIndex].Cells["details"].Value;
            }
        }

        private void buttonViewMore_Click(object sender, EventArgs e)
        {
            View viewJob = new View(getSelectedJobID());
            viewJob.ShowDialog();
        }
    }
}
