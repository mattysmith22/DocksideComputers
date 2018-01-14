namespace Prototype.Screens.Jobs
{
    partial class PrintPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxPrintDetails = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintReceipt = new System.Windows.Forms.CheckBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxPrintDetails
            // 
            this.checkBoxPrintDetails.AutoSize = true;
            this.checkBoxPrintDetails.Location = new System.Drawing.Point(13, 14);
            this.checkBoxPrintDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPrintDetails.Name = "checkBoxPrintDetails";
            this.checkBoxPrintDetails.Size = new System.Drawing.Size(143, 24);
            this.checkBoxPrintDetails.TabIndex = 0;
            this.checkBoxPrintDetails.Text = "Print Job Details";
            this.checkBoxPrintDetails.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintReceipt
            // 
            this.checkBoxPrintReceipt.AutoSize = true;
            this.checkBoxPrintReceipt.Location = new System.Drawing.Point(13, 48);
            this.checkBoxPrintReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPrintReceipt.Name = "checkBoxPrintReceipt";
            this.checkBoxPrintReceipt.Size = new System.Drawing.Size(149, 24);
            this.checkBoxPrintReceipt.TabIndex = 1;
            this.checkBoxPrintReceipt.Text = "Print Job Receipt";
            this.checkBoxPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(13, 81);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(143, 31);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 124);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.checkBoxPrintReceipt);
            this.Controls.Add(this.checkBoxPrintDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintPopup";
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPrintDetails;
        private System.Windows.Forms.CheckBox checkBoxPrintReceipt;
        private System.Windows.Forms.Button buttonPrint;
    }
}