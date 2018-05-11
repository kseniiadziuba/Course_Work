namespace Course_Work
{
    partial class AccountForm
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
            this.AddNewAccount = new System.Windows.Forms.Button();
            this.RemoveAccount = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityOfVisitingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.beginDateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cardIdComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewAccount
            // 
            this.AddNewAccount.Location = new System.Drawing.Point(420, 96);
            this.AddNewAccount.Name = "AddNewAccount";
            this.AddNewAccount.Size = new System.Drawing.Size(107, 23);
            this.AddNewAccount.TabIndex = 1;
            this.AddNewAccount.Text = "Add New Account";
            this.AddNewAccount.UseVisualStyleBackColor = true;
            this.AddNewAccount.Click += new System.EventHandler(this.AddNewAccount_Click);
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.Location = new System.Drawing.Point(420, 125);
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.Size = new System.Drawing.Size(107, 23);
            this.RemoveAccount.TabIndex = 2;
            this.RemoveAccount.Text = "Remove Account";
            this.RemoveAccount.UseVisualStyleBackColor = true;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(420, 154);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(118, 23);
            this.BackToMainMenu.TabIndex = 3;
            this.BackToMainMenu.Text = "Back to Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(561, 124);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Card ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(98, 132);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // quantityOfVisitingTextBox
            // 
            this.quantityOfVisitingTextBox.Location = new System.Drawing.Point(132, 155);
            this.quantityOfVisitingTextBox.Name = "quantityOfVisitingTextBox";
            this.quantityOfVisitingTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityOfVisitingTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity of visiting";
            // 
            // quantityOfDaysTextBox
            // 
            this.quantityOfDaysTextBox.Location = new System.Drawing.Point(132, 184);
            this.quantityOfDaysTextBox.Name = "quantityOfDaysTextBox";
            this.quantityOfDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityOfDaysTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity of days";
            // 
            // beginDateTextBox
            // 
            this.beginDateTextBox.Location = new System.Drawing.Point(132, 210);
            this.beginDateTextBox.Name = "beginDateTextBox";
            this.beginDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginDateTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Begin Date";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(132, 232);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "End Date";
            // 
            // cardIdComboBox
            // 
            this.cardIdComboBox.FormattingEnabled = true;
            this.cardIdComboBox.Location = new System.Drawing.Point(98, 35);
            this.cardIdComboBox.Name = "cardIdComboBox";
            this.cardIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardIdComboBox.TabIndex = 21;
            this.cardIdComboBox.SelectedIndexChanged += new System.EventHandler(this.cardIdComboBox_SelectedIndexChanged);
            // 
            // accountTypeTextBox
            // 
            this.accountTypeTextBox.Location = new System.Drawing.Point(98, 98);
            this.accountTypeTextBox.Name = "accountTypeTextBox";
            this.accountTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountTypeTextBox.TabIndex = 22;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(98, 69);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIdTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Client ID";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 476);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountTypeTextBox);
            this.Controls.Add(this.cardIdComboBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.beginDateTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantityOfDaysTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityOfVisitingTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.RemoveAccount);
            this.Controls.Add(this.AddNewAccount);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddNewAccount;
        private System.Windows.Forms.Button RemoveAccount;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityOfVisitingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityOfDaysTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox beginDateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cardIdComboBox;
        private System.Windows.Forms.TextBox accountTypeTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.Label label2;
    }
}