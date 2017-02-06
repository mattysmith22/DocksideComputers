using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype.Screens.Customers
{
    public struct FilterOptions
    {
        public string firstname;
        public string surname;
        public string mobile;
        public string landline;
    }

    public partial class Filter : Form
    {
        public FilterOptions filterOptions;

        public Filter(FilterOptions filterOptions)
        {
            InitializeComponent();

            this.filterOptions = filterOptions;

            textBoxFirstname.Text = filterOptions.firstname;
            textBoxSurname.Text = filterOptions.surname;
            textBoxLandline.Text = filterOptions.landline;
            textBoxMobile.Text = filterOptions.mobile;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterOptions.firstname = textBoxFirstname.Text;
            filterOptions.surname = textBoxSurname.Text;
            filterOptions.mobile = textBoxMobile.Text;
            filterOptions.landline = textBoxLandline.Text;

            this.Close();
        }
    }
}
