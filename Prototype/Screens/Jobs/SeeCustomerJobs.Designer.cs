namespace Prototype.Screens.Jobs
{
    partial class SeeCustomerJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeCustomerJobs));
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelProblem = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.AllowUserToAddRows = false;
            this.dataGridViewJobs.AllowUserToDeleteRows = false;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.ReadOnly = true;
            this.dataGridViewJobs.Size = new System.Drawing.Size(385, 155);
            this.dataGridViewJobs.TabIndex = 0;
            this.dataGridViewJobs.SelectionChanged += new System.EventHandler(this.dataGridViewJobs_SelectionChanged);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(12, 275);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(386, 23);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(12, 174);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(48, 13);
            this.labelProblem.TabIndex = 2;
            this.labelProblem.Text = "Problem:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(12, 200);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(42, 13);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "Details:";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Enabled = false;
            this.textBoxProblem.Location = new System.Drawing.Point(62, 174);
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(336, 20);
            this.textBoxProblem.TabIndex = 4;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Enabled = false;
            this.textBoxDetails.Location = new System.Drawing.Point(62, 200);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(336, 69);
            this.textBoxDetails.TabIndex = 5;
            // 
            // SeeCustomerJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dataGridViewJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeeCustomerJobs";
            this.Text = "View Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.TextBox textBoxProblem;
        private System.Windows.Forms.TextBox textBoxDetails;
    }
}