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
    public partial class Add : Form
    {
        private int customerID;
        public Add(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }
    }
}
