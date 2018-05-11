namespace Course_Work.Forms
{
    partial class RefferenceBook
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
            this.roomsButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomsButton
            // 
            this.roomsButton.Location = new System.Drawing.Point(55, 44);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(75, 23);
            this.roomsButton.TabIndex = 0;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = true;
            this.roomsButton.Click += new System.EventHandler(this.roomsButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(214, 44);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(214, 73);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(115, 23);
            this.backToMainMenu.TabIndex = 2;
            this.backToMainMenu.Text = "Back to Main Menu";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // RefferenceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 165);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.roomsButton);
            this.Name = "RefferenceBook";
            this.Text = "RefferenceBook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button backToMainMenu;
    }
}