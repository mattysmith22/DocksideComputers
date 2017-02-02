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
    public partial class SeeCustomerJobs : Form
    {
        private int customerID;
        public SeeCustomerJobs(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }
    }
}
