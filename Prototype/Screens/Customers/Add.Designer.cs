namespace Prototype.Screens.Customers
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxLandline = new System.Windows.Forms.TextBox();
            this.textBoxCounty = new System.Windows.Forms.TextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelLandline = new System.Windows.Forms.Label();
            this.labelCounty = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(102, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 28);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobile.Location = new System.Drawing.Point(102, 204);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(160, 26);
            this.textBoxMobile.TabIndex = 29;
            this.textBoxMobile.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxLandline
            // 
            this.textBoxLandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLandline.Location = new System.Drawing.Point(102, 172);
            this.textBoxLandline.Name = "textBoxLandline";
            this.textBoxLandline.Size = new System.Drawing.Size(160, 26);
            this.textBoxLandline.TabIndex = 28;
            this.textBoxLandline.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxCounty
            // 
            this.textBoxCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCounty.Location = new System.Drawing.Point(102, 140);
            this.textBoxCounty.Name = "textBoxCounty";
            this.textBoxCounty.Size = new System.Drawing.Size(159, 26);
            this.textBoxCounty.TabIndex = 27;
            this.textBoxCounty.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxTown
            // 
            this.textBoxTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTown.Location = new System.Drawing.Point(102, 108);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(160, 26);
            this.textBoxTown.TabIndex = 26;
            this.textBoxTown.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(102, 76);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(160, 26);
            this.textBoxAddress.TabIndex = 25;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(102, 44);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(160, 26);
            this.textBoxSurname.TabIndex = 24;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(102, 12);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(160, 26);
            this.textBoxFirstname.TabIndex = 23;
            this.textBoxFirstname.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(12, 207);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(59, 20);
            this.labelMobile.TabIndex = 22;
            this.labelMobile.Text = "Mobile:";
            // 
            // labelLandline
            // 
            this.labelLandline.AutoSize = true;
            this.labelLandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLandline.Location = new System.Drawing.Point(12, 175);
            this.labelLandline.Name = "labelLandline";
            this.labelLandline.Size = new System.Drawing.Size(73, 20);
            this.labelLandline.TabIndex = 21;
            this.labelLandline.Text = "Landline:";
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounty.Location = new System.Drawing.Point(12, 143);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(63, 20);
            this.labelCounty.TabIndex = 20;
            this.labelCounty.Text = "County:";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTown.Location = new System.Drawing.Point(12, 111);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(51, 20);
            this.labelTown.TabIndex = 19;
            this.labelTown.Text = "Town:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 79);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 20);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "Address:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(12, 47);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(78, 20);
            this.labelSurname.TabIndex = 17;
            this.labelSurname.Text = "Surname:";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.Location = new System.Drawing.Point(12, 15);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(84, 20);
            this.labelFirstname.TabIndex = 16;
            this.labelFirstname.Text = "Firstname:";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 276);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxLandline);
            this.Controls.Add(this.textBoxCounty);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelLandline);
            this.Controls.Add(this.labelCounty);
            this.Controls.Add(this.labelTown);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelFirstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "Add Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxLandline;
        private System.Windows.Forms.TextBox textBoxCounty;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelLandline;
        private System.Windows.Forms.Label labelCounty;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelFirstname;
    }
}