using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype.Screens.Jobs
{
    public partial class Edit : Form
    {
        private bool forceClose = false;

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceClose)
            {
                DialogResult reply = MessageBox.Show("Do you want to close the program?", "Are you sure?", MessageBoxButtons.YesNo);
                if (reply == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
