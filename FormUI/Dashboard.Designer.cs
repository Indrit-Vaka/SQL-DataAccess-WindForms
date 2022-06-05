namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInText = new System.Windows.Forms.TextBox();
            this.firstNameInLabel = new System.Windows.Forms.Label();
            this.lastNameInLabel = new System.Windows.Forms.Label();
            this.lastNameInText = new System.Windows.Forms.TextBox();
            this.emailInLabel = new System.Windows.Forms.Label();
            this.emailAddressInText = new System.Windows.Forms.TextBox();
            this.phoneNumberInLabel = new System.Windows.Forms.Label();
            this.phoneNumberInText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 20;
            this.peopleFoundListBox.Location = new System.Drawing.Point(13, 173);
            this.peopleFoundListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(659, 164);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(153, 82);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameText.Multiline = true;
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(184, 29);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(50, 82);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(153, 128);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInText
            // 
            this.firstNameInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInText.Location = new System.Drawing.Point(180, 358);
            this.firstNameInText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameInText.Multiline = true;
            this.firstNameInText.Name = "firstNameInText";
            this.firstNameInText.Size = new System.Drawing.Size(184, 29);
            this.firstNameInText.TabIndex = 4;
            // 
            // firstNameInLabel
            // 
            this.firstNameInLabel.AutoSize = true;
            this.firstNameInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInLabel.Location = new System.Drawing.Point(50, 361);
            this.firstNameInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameInLabel.Name = "firstNameInLabel";
            this.firstNameInLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameInLabel.TabIndex = 5;
            this.firstNameInLabel.Text = "First Name";
            // 
            // lastNameInLabel
            // 
            this.lastNameInLabel.AutoSize = true;
            this.lastNameInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInLabel.Location = new System.Drawing.Point(50, 400);
            this.lastNameInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameInLabel.Name = "lastNameInLabel";
            this.lastNameInLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameInLabel.TabIndex = 7;
            this.lastNameInLabel.Text = "Last Name";
            // 
            // lastNameInText
            // 
            this.lastNameInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInText.Location = new System.Drawing.Point(180, 397);
            this.lastNameInText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameInText.Multiline = true;
            this.lastNameInText.Name = "lastNameInText";
            this.lastNameInText.Size = new System.Drawing.Size(184, 29);
            this.lastNameInText.TabIndex = 6;
            // 
            // emailInLabel
            // 
            this.emailInLabel.AutoSize = true;
            this.emailInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInLabel.Location = new System.Drawing.Point(50, 439);
            this.emailInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailInLabel.Name = "emailInLabel";
            this.emailInLabel.Size = new System.Drawing.Size(107, 20);
            this.emailInLabel.TabIndex = 9;
            this.emailInLabel.Text = "EmailAddress";
            // 
            // emailAddressInText
            // 
            this.emailAddressInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressInText.Location = new System.Drawing.Point(180, 436);
            this.emailAddressInText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailAddressInText.Multiline = true;
            this.emailAddressInText.Name = "emailAddressInText";
            this.emailAddressInText.Size = new System.Drawing.Size(184, 29);
            this.emailAddressInText.TabIndex = 8;
            // 
            // phoneNumberInLabel
            // 
            this.phoneNumberInLabel.AutoSize = true;
            this.phoneNumberInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInLabel.Location = new System.Drawing.Point(50, 478);
            this.phoneNumberInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberInLabel.Name = "phoneNumberInLabel";
            this.phoneNumberInLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberInLabel.TabIndex = 11;
            this.phoneNumberInLabel.Text = "Phone Number";
            // 
            // phoneNumberInText
            // 
            this.phoneNumberInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInText.Location = new System.Drawing.Point(180, 475);
            this.phoneNumberInText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberInText.Multiline = true;
            this.phoneNumberInText.Name = "phoneNumberInText";
            this.phoneNumberInText.Size = new System.Drawing.Size(184, 29);
            this.phoneNumberInText.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(153, 517);
            this.insertRecordButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(112, 35);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 566);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInLabel);
            this.Controls.Add(this.phoneNumberInText);
            this.Controls.Add(this.emailInLabel);
            this.Controls.Add(this.emailAddressInText);
            this.Controls.Add(this.lastNameInLabel);
            this.Controls.Add(this.lastNameInText);
            this.Controls.Add(this.firstNameInLabel);
            this.Controls.Add(this.firstNameInText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Acces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameInText;
        private System.Windows.Forms.Label firstNameInLabel;
        private System.Windows.Forms.Label lastNameInLabel;
        private System.Windows.Forms.TextBox lastNameInText;
        private System.Windows.Forms.Label emailInLabel;
        private System.Windows.Forms.TextBox emailAddressInText;
        private System.Windows.Forms.Label phoneNumberInLabel;
        private System.Windows.Forms.TextBox phoneNumberInText;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

