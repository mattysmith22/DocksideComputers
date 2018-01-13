using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Prototype.Screens.Misc
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Prototype.Resources.about.rtf"))
            {
                richTextBoxAbout.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
