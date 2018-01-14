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
    class PrintJobReceipt : PrintDocument
    {
        private string receiptKey;
        private string problem;
        private string details;

        private Font fontTitle;
        private Font fontText;
        private Font fontField;

        public PrintJobReceipt(string receiptKey, string problem, string details) : base()
        {
            this.receiptKey = receiptKey;
            this.problem = problem;
            this.details = details;

            fontTitle = new Font("Calibri", 32);
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

            #region print dockside branding

            Bitmap branding = global::Prototype.Properties.Resources.docksideBranding;

            e.Graphics.DrawImage(branding, new RectangleF(leftMargin + (printWidth - 300) / 2, topMargin, 300, 100));
            cursor.Y += 100;

            #endregion

            #region print job title

            measuredSize = e.Graphics.MeasureString("Job", fontTitle, printWidth);

            cursor.X = leftMargin + ((printWidth - measuredSize.Width) / 2);

            e.Graphics.DrawString("Job", fontTitle, Brushes.Black, new RectangleF(cursor, measuredSize));
            cursor.Y += measuredSize.Height;
            #endregion

            #region print the barcode

            cursor.X = leftMargin + (printWidth - 300) / 2;
            Image barcodeImg = Barcode.DoEncode(TYPE.CODE128, receiptKey, false, Color.Black, Color.Empty, 300, 100);
            e.Graphics.DrawImage(barcodeImg, cursor);
            cursor.Y += 110; 

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

            #endregion
        }
    }
}
