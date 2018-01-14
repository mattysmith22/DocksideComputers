namespace Prototype.Screens.Misc
{
    partial class GetReceiptString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetReceiptString));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReceiptCode = new System.Windows.Forms.TextBox();
            this.buttonReceiptCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt code:";
            // 
            // textBoxReceiptCode
            // 
            this.textBoxReceiptCode.Location = new System.Drawing.Point(128, 14);
            this.textBoxReceiptCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxReceiptCode.Name = "textBoxReceiptCode";
            this.textBoxReceiptCode.Size = new System.Drawing.Size(154, 26);
            this.textBoxReceiptCode.TabIndex = 1;
            this.textBoxReceiptCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReceiptCode_KeyDown);
            // 
            // buttonReceiptCode
            // 
            this.buttonReceiptCode.Location = new System.Drawing.Point(128, 50);
            this.buttonReceiptCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReceiptCode.Name = "buttonReceiptCode";
            this.buttonReceiptCode.Size = new System.Drawing.Size(154, 28);
            this.buttonReceiptCode.TabIndex = 2;
            this.buttonReceiptCode.Text = "Enter";
            this.buttonReceiptCode.UseVisualStyleBackColor = true;
            this.buttonReceiptCode.Click += new System.EventHandler(this.buttonReceiptCode_Click);
            // 
            // GetReceiptString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 89);
            this.Controls.Add(this.buttonReceiptCode);
            this.Controls.Add(this.textBoxReceiptCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetReceiptString";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReceiptCode;
        private System.Windows.Forms.Button buttonReceiptCode;
    }
}