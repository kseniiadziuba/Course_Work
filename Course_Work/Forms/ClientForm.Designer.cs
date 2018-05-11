namespace Course_Work
{
    partial class ClientForm
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
            this.clientsTableView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ShowCards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsTableView
            // 
            this.clientsTableView.AllowUserToAddRows = false;
            this.clientsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsTableView.Location = new System.Drawing.Point(0, 0);
            this.clientsTableView.Name = "clientsTableView";
            this.clientsTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsTableView.Size = new System.Drawing.Size(800, 231);
            this.clientsTableView.TabIndex = 0;
            this.clientsTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsTableView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove All Clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveAllClientsClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseAppClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add New Client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddNewClientClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove Client";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveClientClick);
            // 
            // ShowCards
            // 
            this.ShowCards.Location = new System.Drawing.Point(434, 294);
            this.ShowCards.Name = "ShowCards";
            this.ShowCards.Size = new System.Drawing.Size(116, 24);
            this.ShowCards.TabIndex = 5;
            this.ShowCards.Text = "Back to Main Menu";
            this.ShowCards.UseVisualStyleBackColor = true;
            this.ShowCards.Click += new System.EventHandler(this.BackToMainMenu);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowCards);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientsTableView);
            this.Name = "ClientForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.clientsTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsTableView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ShowCards;
    }
}

