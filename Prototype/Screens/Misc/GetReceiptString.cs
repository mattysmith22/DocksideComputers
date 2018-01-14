using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype.Screens.Misc
{
    public partial class GetReceiptString : Form
    {
        public string receiptCode;
        public bool confirmed = false;

        public GetReceiptString()
        {
            InitializeComponent();
            receiptCode = "";
        }

        private void buttonReceiptCode_Click(object sender, EventArgs e)
        {
            receiptCode = textBoxReceiptCode.Text;
            confirmed = true;
            this.Close();
        }

        private void textBoxReceiptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                receiptCode = textBoxReceiptCode.Text;
                confirmed = true;
                this.Close();
            }
        }
    }
}
