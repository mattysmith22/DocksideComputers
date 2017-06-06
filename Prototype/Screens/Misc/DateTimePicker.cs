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
    public partial class DateTimePicker : Form
    {
        public DateTime value { get; private set; }
        public bool isNull { get; private set; }

        public DateTimePicker(DateTime inital)
        {
            InitializeComponent();
            isNull = false;
            value = inital;
        }

        public DateTimePicker()
        {
            InitializeComponent();
            isNull = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (this.isNull)
            {
                value = monthCalendar.SelectionRange.Start;
                isNull = false;
                this.Close();
            }
            else
            {
                value = monthCalendar.SelectionRange.Start;
                isNull = false;
                this.Close();
            }
        }
    }
}
