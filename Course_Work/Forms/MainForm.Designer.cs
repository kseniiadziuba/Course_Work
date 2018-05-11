namespace Course_Work
{
    partial class MainForm
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
            this.Clients = new System.Windows.Forms.Button();
            this.Cards = new System.Windows.Forms.Button();
            this.Accounts = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.refferenceBookButton = new System.Windows.Forms.Button();
            this.visitingCalculations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(165, 249);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(75, 23);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Cards
            // 
            this.Cards.Location = new System.Drawing.Point(165, 278);
            this.Cards.Name = "Cards";
            this.Cards.Size = new System.Drawing.Size(75, 23);
            this.Cards.TabIndex = 1;
            this.Cards.Text = "Cards";
            this.Cards.UseVisualStyleBackColor = true;
            this.Cards.Click += new System.EventHandler(this.Cards_Click);
            // 
            // Accounts
            // 
            this.Accounts.Location = new System.Drawing.Point(165, 307);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(113, 23);
            this.Accounts.TabIndex = 2;
            this.Accounts.Text = "Account Selling";
            this.Accounts.UseVisualStyleBackColor = true;
            this.Accounts.Click += new System.EventHandler(this.Accounts_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(325, 277);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(165, 337);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(75, 23);
            this.Schedule.TabIndex = 4;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // refferenceBookButton
            // 
            this.refferenceBookButton.Location = new System.Drawing.Point(165, 395);
            this.refferenceBookButton.Name = "refferenceBookButton";
            this.refferenceBookButton.Size = new System.Drawing.Size(97, 23);
            this.refferenceBookButton.TabIndex = 5;
            this.refferenceBookButton.Text = "Refference Book";
            this.refferenceBookButton.UseVisualStyleBackColor = true;
            this.refferenceBookButton.Click += new System.EventHandler(this.refferenceBookButton_Click);
            // 
            // visitingCalculations
            // 
            this.visitingCalculations.Location = new System.Drawing.Point(165, 366);
            this.visitingCalculations.Name = "visitingCalculations";
            this.visitingCalculations.Size = new System.Drawing.Size(113, 23);
            this.visitingCalculations.TabIndex = 6;
            this.visitingCalculations.Text = "Visiting Calculations";
            this.visitingCalculations.UseVisualStyleBackColor = true;
            this.visitingCalculations.Click += new System.EventHandler(this.visitingCalculations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitingCalculations);
            this.Controls.Add(this.refferenceBookButton);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Accounts);
            this.Controls.Add(this.Cards);
            this.Controls.Add(this.Clients);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Cards;
        private System.Windows.Forms.Button Accounts;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button refferenceBookButton;
        private System.Windows.Forms.Button visitingCalculations;
    }
}