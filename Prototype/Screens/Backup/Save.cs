using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype.Screens.Backup
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                textBoxLocation.Text = saveFileDialog.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(cmd))
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        backup.ExportInfo.ExportEvents = false;
                        backup.ExportInfo.ExportFunctions = false;
                        backup.ExportInfo.ExportProcedures = false;
                        backup.ExportInfo.ExportRoutinesWithoutDefiner = false;
                        backup.ExportInfo.ExportRows = true;
                        backup.ExportInfo.ExportTableStructure = true;
                        backup.ExportInfo.ExportTriggers = false;
                        backup.ExportInfo.ExportViews = false;
                        backup.ExportInfo.RowsExportMode = RowsDataExportMode.Insert;
                        backup.ExportInfo.TablesToBeExportedList = new List<string>() {"tbl_customers", "tbl_jobs", "tbl_staff", "tbl_transactions"};

                        backup.ExportToFile(textBoxLocation.Text);
                        MessageBox.Show("Backup completed");
                        connection.Close();
                    }
                }
            }
        }
    }
}
