namespace Prototype.Screens.Jobs
{
    partial class ViewUnfinished
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelProblem = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.buttonViewMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(13, 178);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(48, 13);
            this.labelProblem.TabIndex = 1;
            this.labelProblem.Text = "Problem:";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Enabled = false;
            this.textBoxProblem.Location = new System.Drawing.Point(68, 178);
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(234, 20);
            this.textBoxProblem.TabIndex = 2;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(13, 203);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(42, 13);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "Details:";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Enabled = false;
            this.textBoxDetails.Location = new System.Drawing.Point(68, 204);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(234, 75);
            this.textBoxDetails.TabIndex = 4;
            // 
            // buttonViewMore
            // 
            this.buttonViewMore.Location = new System.Drawing.Point(68, 285);
            this.buttonViewMore.Name = "buttonViewMore";
            this.buttonViewMore.Size = new System.Drawing.Size(135, 23);
            this.buttonViewMore.TabIndex = 5;
            this.buttonViewMore.Text = "View More";
            this.buttonViewMore.UseVisualStyleBackColor = true;
            // 
            // ViewUnfinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 320);
            this.Controls.Add(this.buttonViewMore);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewUnfinished";
            this.Text = "View Unfinished";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.TextBox textBoxProblem;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Button buttonViewMore;
    }
}