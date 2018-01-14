using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;
using BarcodeLib;

namespace Prototype.Printing
{
    class PrintJob : PrintDocument
    {
        private int customerID;
        private string customerName;
        private string problem;
        private string details;
        private string computerUsername;
        private string computerPassword;
        private bool backup;
        private bool format;
        private bool shouldCallBefore;
        private string speakingAuthorisation;
        private string receiptKey;

        private int padding;
        private string tickChar;
        private string crossChar;

        private Font fontTitle;
        private Font fontText;
        private Font fontField;

        public PrintJob(int customerID, string customerFirstname, string customerSurname, string problem, string details, string computerUsername, string computerPassword, bool backup, bool format, bool shouldCallBefore, string speakingAuthorisation, string receiptKey) : base()
        {
            this.customerID = customerID;
            this.customerName = customerFirstname + " " + customerSurname;
            this.problem = problem;
            this.details = details;
            this.computerUsername = computerUsername;
            this.computerPassword = computerPassword;
            this.backup = backup;
            this.format = format;
            this.shouldCallBefore = shouldCallBefore;
            this.speakingAuthorisation = speakingAuthorisation;
            this.receiptKey = receiptKey;

            padding = 10;

            tickChar = "✓";
            crossChar = "✗";

            fontTitle = new Font("Calibri", 32);
            fontField = new Font("Calibri", 12, FontStyle.Bold);
            fontText = new Font("Calibri", 12);
        }

        private string translateBool(bool i)
        {
            if(i)
            {
                return tickChar;
            }
            else
            {
                return crossChar;
            }
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

            #region print dockside branding

            Bitmap branding = global::Prototype.Properties.Resources.docksideBranding;

            e.Graphics.DrawImage(branding, new RectangleF(leftMargin + (printWidth - 300) / 2, topMargin, 300, 100));
            cursor.Y += 100;

            #endregion

            #region print customer title

            measuredSize = e.Graphics.MeasureString("Job", fontTitle, printWidth);

            cursor.X = leftMargin;

            e.Graphics.DrawString("Job", fontTitle, Brushes.Black, cursor);
            cursor.Y += measuredSize.Height;
            #endregion

            #region print problem;
            cursor.X = leftMargin;
            measuredSize = e.Graphics.MeasureString("Problem: ", fontField);
            e.Graphics.DrawString("Problem: ", fontField, Brushes.Black, cursor);

            cursor.X += measuredSize.Width;

            measuredSize = e.Graphics.MeasureString(problem, fontText, DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Right - (int)cursor.X);
            e.Graphics.DrawString(problem, fontText, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height;
            #endregion

            #region print details;
            cursor.X = leftMargin;
            measuredSize = e.Graphics.MeasureString("Details: ", fontField);
            e.Graphics.DrawString("Details: ", fontField, Brushes.Black, cursor);

            cursor.X += measuredSize.Width;

            measuredSize = e.Graphics.MeasureString(details, fontText, DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Right - (int)cursor.X);
            e.Graphics.DrawString(details, fontText, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height + (2*padding);

            #endregion
            
            #region print separating line

            e.Graphics.DrawLine(Pens.Black, leftMargin, cursor.Y, leftMargin + printWidth, cursor.Y);
            cursor.Y += padding;

            #endregion

            #region print computer username
            cursor.X = leftMargin;
            measuredSize = e.Graphics.MeasureString("Computer Username: ", fontField);
            e.Graphics.DrawString("Computer Username: ", fontField, Brushes.Black, cursor);

            cursor.X += measuredSize.Width;

            measuredSize = e.Graphics.MeasureString(computerUsername, fontText, DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Right - (int)cursor.X);
            e.Graphics.DrawString(computerUsername, fontText, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height;

            #endregion

            #region print computer password
            cursor.X = leftMargin;
            measuredSize = e.Graphics.MeasureString("Computer Password: ", fontField);
            e.Graphics.DrawString("Computer Password: ", fontField, Brushes.Black, cursor);

            cursor.X += measuredSize.Width;

            measuredSize = e.Graphics.MeasureString(computerPassword, fontText, DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Right - (int)cursor.X);
            e.Graphics.DrawString(computerPassword, fontText, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height + padding;

            #endregion

            #region print separating line

            e.Graphics.DrawLine(Pens.Black, leftMargin, cursor.Y, leftMargin + printWidth, cursor.Y);
            cursor.Y += padding;

            #endregion

            #region print checkmarks
            cursor.X = leftMargin;
            e.Graphics.DrawString("Backup?: " + translateBool(backup), fontField, Brushes.Black, cursor);

            measuredSize = e.Graphics.MeasureString("Format?: " + translateBool(format), fontField);
            cursor.X = leftMargin + (printWidth - measuredSize.Width) / 2;
            e.Graphics.DrawString("Format?: " + translateBool(format), fontField, Brushes.Black, cursor);

            measuredSize = e.Graphics.MeasureString("Should call before?: " + translateBool(shouldCallBefore), fontField);
            cursor.X = leftMargin + printWidth - measuredSize.Width;
            e.Graphics.DrawString("Should call before?: " + translateBool(shouldCallBefore), fontField, Brushes.Black, cursor);

            cursor.Y += measuredSize.Height + padding;

            #endregion

            #region print separating line

            e.Graphics.DrawLine(Pens.Black, leftMargin, cursor.Y, leftMargin + printWidth, cursor.Y);
            cursor.Y += padding;

            #endregion

            #region print speak to

            cursor.X = leftMargin;
            measuredSize = e.Graphics.MeasureString("Speak to: ", fontField);
            e.Graphics.DrawString("Speak to: ", fontField, Brushes.Black, cursor);

            cursor.X += measuredSize.Width;

            measuredSize = e.Graphics.MeasureString(speakingAuthorisation, fontText, DefaultPageSettings.PaperSize.Width - DefaultPageSettings.Margins.Right - (int)cursor.X);
            e.Graphics.DrawString(speakingAuthorisation, fontText, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height + padding;

            #endregion

            #region print the barcode

            cursor.X = leftMargin + (printWidth - 300) / 2;
            Image barcodeImg = Barcode.DoEncode(TYPE.CODE128, receiptKey, false, Color.Black, Color.Empty, 300, 100);
            e.Graphics.DrawImage(barcodeImg, cursor);
            cursor.Y += 100 + padding;

            #endregion
        }
    }
}
