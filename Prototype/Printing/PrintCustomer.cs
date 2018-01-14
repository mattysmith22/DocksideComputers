using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;

namespace Prototype.Printing
{
    class PrintCustomer : PrintDocument
    {
        private int customerID;
        private string name;
        private string address;
        private string town;
        private string county;
        private string landline;
        private string mobile;

        private Font fontTitle;
        private Font fontText;
        private Font fontField;
        private Font fontName;

        public PrintCustomer(int customerID, string firstname, string surname, string address, string town, string county, string landline, string mobile) : base()
        {
            this.customerID = customerID;
            this.name = firstname + " " + surname;
            Debug.WriteLine(name);
            this.address = address;
            this.town = town;
            this.county = county;
            this.landline = landline;
            this.mobile = mobile;

            fontTitle = new Font("Calibri", 32, FontStyle.Bold);
            fontName = new Font("Calibri", 24, FontStyle.Bold);
            fontText = new Font("Calibri", 12);
            fontField = new Font("Calibri", 12, FontStyle.Bold);
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            int printHeight = DefaultPageSettings.PaperSize.Height - DefaultPageSettings.Margins.Top - DefaultPageSettings.Margins.Bottom;
            int printWidth = DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Left - DefaultPageSettings.Margins.Right;

            int leftMargin = DefaultPageSettings.Margins.Left;
            int topMargin = DefaultPageSettings.Margins.Top;

            PointF cursor = new PointF(leftMargin, topMargin); //in essence where I am currently editing

            SizeF measuredSize; //Used to store the results from measurements of string size
            SizeF totalSize; //Used to store the size of the entire line, used to calculate spacing

            #region print dockside branding

            Bitmap branding = global::Prototype.Properties.Resources.docksideBranding;

            e.Graphics.DrawImage(branding, new RectangleF(leftMargin + (printWidth - 300)/2, topMargin, 300, 100));
            cursor.Y += 100;

            #endregion

            #region print customer title

            measuredSize = e.Graphics.MeasureString("Customer", fontTitle, printWidth);

            cursor.X = leftMargin;
            e.Graphics.DrawString("Customer", fontTitle, Brushes.Black, new Rectangle(Point.Round(cursor), Size.Round(measuredSize)));
            cursor.Y += measuredSize.Height;
            #endregion

            #region print customer name
            
            measuredSize = e.Graphics.MeasureString(name, fontName, printWidth);
            cursor.X = leftMargin;

            e.Graphics.DrawString(name, fontName, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height;
            #endregion

            #region finding the largest field name

            totalSize = new SizeF(0, 0);
            foreach (string i in new string[] { "Customer ID", "Address", "Town", "County", "Landline", "Mobile" })
            {
                measuredSize = e.Graphics.MeasureString(i, fontField);
                totalSize = DrawingTools.Max(totalSize, measuredSize);
            }
            #endregion

            #region printing all fields
            foreach (string[] field in new string[][] {
                new string[]{ "Customer ID", customerID.ToString() },
                new string[]{"Address", address },
                new string[]{"Town", town },
                new string[]{"County", county },
                new string[]{"Landline", landline},
                new string[]{"Mobile", mobile} })
            {
                cursor.X = leftMargin;
                e.Graphics.DrawString(field[0], fontField, Brushes.Black, cursor);
                cursor.X += totalSize.Width;
                e.Graphics.DrawString(field[1], fontText, Brushes.Black, cursor);
                cursor.Y += totalSize.Height;
            }
            #endregion
        }
    }
}
