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
    public partial class PrintPopup : Form
    {
        public bool confirmPrint;
        public bool printJob;
        public bool printReceipt;

        public PrintPopup()
        {
            InitializeComponent();
            confirmPrint = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            confirmPrint = true;
            printJob = checkBoxPrintDetails.Checked;
            printReceipt = checkBoxPrintReceipt.Checked;

            this.Close();
        }
    }
}
