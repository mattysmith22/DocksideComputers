namespace Prototype.Screens.Jobs
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.labelProblem = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelBackup = new System.Windows.Forms.Label();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.checkBoxFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxNeedCall = new System.Windows.Forms.CheckBox();
            this.labelNeedCall = new System.Windows.Forms.Label();
            this.textBoxSpeakTo = new System.Windows.Forms.TextBox();
            this.labelSpeakTo = new System.Windows.Forms.Label();
            this.labelCompletionDate = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMarkComplete = new System.Windows.Forms.Button();
            this.buttonRegenerate = new System.Windows.Forms.Button();
            this.labelLeftMessage = new System.Windows.Forms.Label();
            this.checkBoxLeftMessage = new System.Windows.Forms.CheckBox();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelCompletionDateData = new System.Windows.Forms.Label();
            this.numericUpDownAmountPaid = new System.Windows.Forms.NumericUpDown();
            this.textBoxPaymentMethod = new System.Windows.Forms.TextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonBackdate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelJobHeading = new System.Windows.Forms.Label();
            this.labelTransactionHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(13, 48);
            this.labelProblem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(71, 20);
            this.labelProblem.TabIndex = 0;
            this.labelProblem.Text = "Problem:";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Location = new System.Drawing.Point(112, 45);
            this.textBoxProblem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(210, 26);
            this.textBoxProblem.TabIndex = 1;
            this.textBoxProblem.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelDetails
            // 
            this.labelDetails.AllowDrop = true;
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(13, 79);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(62, 20);
            this.labelDetails.TabIndex = 2;
            this.labelDetails.Text = "Details:";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(112, 81);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(210, 110);
            this.textBoxDetails.TabIndex = 3;
            this.textBoxDetails.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(112, 201);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(210, 26);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelUsername
            // 
            this.labelUsername.AllowDrop = true;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 208);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AllowDrop = true;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(13, 241);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(112, 237);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(210, 26);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelBackup
            // 
            this.labelBackup.AllowDrop = true;
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(25, 277);
            this.labelBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(67, 20);
            this.labelBackup.TabIndex = 8;
            this.labelBackup.Text = "Backup:";
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.Location = new System.Drawing.Point(100, 281);
            this.checkBoxBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBackup.TabIndex = 9;
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            this.checkBoxBackup.CheckedChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelFormat
            // 
            this.labelFormat.AllowDrop = true;
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(123, 277);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(64, 20);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Format:";
            // 
            // checkBoxFormat
            // 
            this.checkBoxFormat.AutoSize = true;
            this.checkBoxFormat.Location = new System.Drawing.Point(195, 281);
            this.checkBoxFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxFormat.Name = "checkBoxFormat";
            this.checkBoxFormat.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFormat.TabIndex = 11;
            this.checkBoxFormat.UseVisualStyleBackColor = true;
            this.checkBoxFormat.CheckedChanged += new System.EventHandler(this.ChangeMade);
            // 
            // checkBoxNeedCall
            // 
            this.checkBoxNeedCall.AutoSize = true;
            this.checkBoxNeedCall.Location = new System.Drawing.Point(307, 281);
            this.checkBoxNeedCall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxNeedCall.Name = "checkBoxNeedCall";
            this.checkBoxNeedCall.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNeedCall.TabIndex = 12;
            this.checkBoxNeedCall.UseVisualStyleBackColor = true;
            this.checkBoxNeedCall.CheckedChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelNeedCall
            // 
            this.labelNeedCall.AllowDrop = true;
            this.labelNeedCall.AutoSize = true;
            this.labelNeedCall.Location = new System.Drawing.Point(218, 277);
            this.labelNeedCall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeedCall.Name = "labelNeedCall";
            this.labelNeedCall.Size = new System.Drawing.Size(81, 20);
            this.labelNeedCall.TabIndex = 13;
            this.labelNeedCall.Text = "Need Call:";
            // 
            // textBoxSpeakTo
            // 
            this.textBoxSpeakTo.Location = new System.Drawing.Point(112, 305);
            this.textBoxSpeakTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSpeakTo.Name = "textBoxSpeakTo";
            this.textBoxSpeakTo.Size = new System.Drawing.Size(210, 26);
            this.textBoxSpeakTo.TabIndex = 14;
            this.textBoxSpeakTo.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelSpeakTo
            // 
            this.labelSpeakTo.AllowDrop = true;
            this.labelSpeakTo.AutoSize = true;
            this.labelSpeakTo.Location = new System.Drawing.Point(13, 308);
            this.labelSpeakTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeakTo.Name = "labelSpeakTo";
            this.labelSpeakTo.Size = new System.Drawing.Size(81, 20);
            this.labelSpeakTo.TabIndex = 15;
            this.labelSpeakTo.Text = "Speak To:";
            // 
            // labelCompletionDate
            // 
            this.labelCompletionDate.AutoSize = true;
            this.labelCompletionDate.Location = new System.Drawing.Point(330, 48);
            this.labelCompletionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompletionDate.Name = "labelCompletionDate";
            this.labelCompletionDate.Size = new System.Drawing.Size(132, 20);
            this.labelCompletionDate.TabIndex = 16;
            this.labelCompletionDate.Text = "Completion Date:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(622, 73);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(86, 31);
            this.buttonRemove.TabIndex = 18;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Receipt Key:";
            // 
            // buttonMarkComplete
            // 
            this.buttonMarkComplete.Location = new System.Drawing.Point(474, 73);
            this.buttonMarkComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(140, 31);
            this.buttonMarkComplete.TabIndex = 17;
            this.buttonMarkComplete.Text = "Mark Complete";
            this.buttonMarkComplete.UseVisualStyleBackColor = true;
            this.buttonMarkComplete.Click += new System.EventHandler(this.buttonMarkComplete_Click);
            // 
            // buttonRegenerate
            // 
            this.buttonRegenerate.Location = new System.Drawing.Point(476, 155);
            this.buttonRegenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegenerate.Name = "buttonRegenerate";
            this.buttonRegenerate.Size = new System.Drawing.Size(140, 31);
            this.buttonRegenerate.TabIndex = 20;
            this.buttonRegenerate.Text = "Re-generate";
            this.buttonRegenerate.UseVisualStyleBackColor = true;
            this.buttonRegenerate.Click += new System.EventHandler(this.buttonRegenerate_Click);
            // 
            // labelLeftMessage
            // 
            this.labelLeftMessage.AutoSize = true;
            this.labelLeftMessage.Location = new System.Drawing.Point(328, 201);
            this.labelLeftMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeftMessage.Name = "labelLeftMessage";
            this.labelLeftMessage.Size = new System.Drawing.Size(110, 20);
            this.labelLeftMessage.TabIndex = 21;
            this.labelLeftMessage.Text = "Left Message:";
            // 
            // checkBoxLeftMessage
            // 
            this.checkBoxLeftMessage.AutoSize = true;
            this.checkBoxLeftMessage.Location = new System.Drawing.Point(476, 205);
            this.checkBoxLeftMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxLeftMessage.Name = "checkBoxLeftMessage";
            this.checkBoxLeftMessage.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLeftMessage.TabIndex = 22;
            this.checkBoxLeftMessage.UseVisualStyleBackColor = true;
            this.checkBoxLeftMessage.CheckedChanged += new System.EventHandler(this.ChangeMade);
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(330, 239);
            this.labelAmountPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(104, 20);
            this.labelAmountPaid.TabIndex = 24;
            this.labelAmountPaid.Text = "Amount Paid:";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(335, 277);
            this.labelPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(133, 20);
            this.labelPaymentMethod.TabIndex = 26;
            this.labelPaymentMethod.Text = "Payment Method:";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(476, 310);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(234, 35);
            this.buttonFinish.TabIndex = 27;
            this.buttonFinish.Text = "Save and Exit";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelCompletionDateData
            // 
            this.labelCompletionDateData.AutoSize = true;
            this.labelCompletionDateData.Location = new System.Drawing.Point(470, 48);
            this.labelCompletionDateData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompletionDateData.Name = "labelCompletionDateData";
            this.labelCompletionDateData.Size = new System.Drawing.Size(59, 20);
            this.labelCompletionDateData.TabIndex = 28;
            this.labelCompletionDateData.Text = "<date>";
            // 
            // numericUpDownAmountPaid
            // 
            this.numericUpDownAmountPaid.DecimalPlaces = 2;
            this.numericUpDownAmountPaid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAmountPaid.Location = new System.Drawing.Point(476, 238);
            this.numericUpDownAmountPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAmountPaid.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownAmountPaid.Name = "numericUpDownAmountPaid";
            this.numericUpDownAmountPaid.Size = new System.Drawing.Size(234, 26);
            this.numericUpDownAmountPaid.TabIndex = 29;
            this.numericUpDownAmountPaid.ValueChanged += new System.EventHandler(this.ChangeMade);
            // 
            // textBoxPaymentMethod
            // 
            this.textBoxPaymentMethod.Location = new System.Drawing.Point(476, 274);
            this.textBoxPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPaymentMethod.Name = "textBoxPaymentMethod";
            this.textBoxPaymentMethod.Size = new System.Drawing.Size(232, 26);
            this.textBoxPaymentMethod.TabIndex = 25;
            this.textBoxPaymentMethod.TextChanged += new System.EventHandler(this.ChangeMade);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(476, 355);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(234, 35);
            this.buttonReload.TabIndex = 30;
            this.buttonReload.Text = "Undo Changes";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonBackdate
            // 
            this.buttonBackdate.Location = new System.Drawing.Point(622, 114);
            this.buttonBackdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackdate.Name = "buttonBackdate";
            this.buttonBackdate.Size = new System.Drawing.Size(86, 31);
            this.buttonBackdate.TabIndex = 31;
            this.buttonBackdate.Text = "Backdate";
            this.buttonBackdate.UseVisualStyleBackColor = true;
            this.buttonBackdate.Click += new System.EventHandler(this.buttonBackdate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 26);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.buttonBackdate_Click);
            // 
            // labelJobHeading
            // 
            this.labelJobHeading.AutoSize = true;
            this.labelJobHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobHeading.Location = new System.Drawing.Point(107, 9);
            this.labelJobHeading.Name = "labelJobHeading";
            this.labelJobHeading.Size = new System.Drawing.Size(56, 29);
            this.labelJobHeading.TabIndex = 61;
            this.labelJobHeading.Text = "Job";
            // 
            // labelTransactionHeading
            // 
            this.labelTransactionHeading.AutoSize = true;
            this.labelTransactionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransactionHeading.Location = new System.Drawing.Point(473, 9);
            this.labelTransactionHeading.Name = "labelTransactionHeading";
            this.labelTransactionHeading.Size = new System.Drawing.Size(150, 29);
            this.labelTransactionHeading.TabIndex = 62;
            this.labelTransactionHeading.Text = "Transaction";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 413);
            this.Controls.Add(this.labelTransactionHeading);
            this.Controls.Add(this.labelJobHeading);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonBackdate);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.numericUpDownAmountPaid);
            this.Controls.Add(this.labelCompletionDateData);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.textBoxPaymentMethod);
            this.Controls.Add(this.labelAmountPaid);
            this.Controls.Add(this.checkBoxLeftMessage);
            this.Controls.Add(this.labelLeftMessage);
            this.Controls.Add(this.buttonRegenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonMarkComplete);
            this.Controls.Add(this.labelCompletionDate);
            this.Controls.Add(this.labelSpeakTo);
            this.Controls.Add(this.textBoxSpeakTo);
            this.Controls.Add(this.labelNeedCall);
            this.Controls.Add(this.checkBoxNeedCall);
            this.Controls.Add(this.checkBoxFormat);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.labelBackup);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.labelProblem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.TextBox textBoxProblem;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.CheckBox checkBoxFormat;
        private System.Windows.Forms.CheckBox checkBoxNeedCall;
        private System.Windows.Forms.Label labelNeedCall;
        private System.Windows.Forms.TextBox textBoxSpeakTo;
        private System.Windows.Forms.Label labelSpeakTo;
        private System.Windows.Forms.Label labelCompletionDate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMarkComplete;
        private System.Windows.Forms.Button buttonRegenerate;
        private System.Windows.Forms.Label labelLeftMessage;
        private System.Windows.Forms.CheckBox checkBoxLeftMessage;
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelCompletionDateData;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPaid;
        private System.Windows.Forms.TextBox textBoxPaymentMethod;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonBackdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelJobHeading;
        private System.Windows.Forms.Label labelTransactionHeading;
    }
}