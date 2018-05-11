namespace Course_Work
{
    partial class CardForm
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
            this.cardsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddNewCard = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RemoveCard = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cardsDataGridView
            // 
            this.cardsDataGridView.AllowUserToAddRows = false;
            this.cardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsDataGridView.Location = new System.Drawing.Point(28, 39);
            this.cardsDataGridView.Name = "cardsDataGridView";
            this.cardsDataGridView.Size = new System.Drawing.Size(729, 200);
            this.cardsDataGridView.TabIndex = 0;
            // 
            // AddNewCard
            // 
            this.AddNewCard.Location = new System.Drawing.Point(527, 253);
            this.AddNewCard.Name = "AddNewCard";
            this.AddNewCard.Size = new System.Drawing.Size(75, 36);
            this.AddNewCard.TabIndex = 1;
            this.AddNewCard.Text = "Add New Card";
            this.AddNewCard.UseVisualStyleBackColor = true;
            this.AddNewCard.Click += new System.EventHandler(this.AddNewCard_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(638, 260);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // RemoveCard
            // 
            this.RemoveCard.Location = new System.Drawing.Point(527, 307);
            this.RemoveCard.Name = "RemoveCard";
            this.RemoveCard.Size = new System.Drawing.Size(75, 36);
            this.RemoveCard.TabIndex = 3;
            this.RemoveCard.Text = "Remove Card";
            this.RemoveCard.UseVisualStyleBackColor = true;
            this.RemoveCard.Click += new System.EventHandler(this.RemoveCard_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(380, 314);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(121, 23);
            this.BackToMainMenu.TabIndex = 5;
            this.BackToMainMenu.Text = "Back to Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.RemoveCard);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddNewCard);
            this.Controls.Add(this.cardsDataGridView);
            this.Name = "CardForm";
            this.Text = "CardForm";
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cardsDataGridView;
        private System.Windows.Forms.Button AddNewCard;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button RemoveCard;
        private System.Windows.Forms.Button BackToMainMenu;
    }
}