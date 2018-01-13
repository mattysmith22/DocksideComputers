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
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxLocation.Text = openFileDialog.FileName;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = Database.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(cmd))
                        {
                            cmd.Connection = connection;
                            connection.Open();
                            backup.ImportInfo.TargetDatabase = "dockside";
                            backup.ImportFromFile(textBoxLocation.Text);
                            MessageBox.Show("Backup loaded");
                            connection.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error in the restore process, maybe check the file path?", "Error");
            }
        }
    }
}
