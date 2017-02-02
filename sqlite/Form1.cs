using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateDataGridView();
        }

        private void updateDataGridView()
        {
            string connectionString = (string)System.Configuration.ConfigurationManager.ConnectionStrings["DocksideDatabase"].ConnectionString;
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string sql = "SELECT customerID, firstname, surname FROM tbl_customers";
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql, connection);

            using (DataTable dt = new DataTable())
            {
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
