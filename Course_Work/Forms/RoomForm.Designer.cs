namespace Course_Work.Forms
{
    partial class RoomForm
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
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewRoom = new System.Windows.Forms.Button();
            this.removeRoom = new System.Windows.Forms.Button();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Location = new System.Drawing.Point(61, 21);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.Size = new System.Drawing.Size(240, 150);
            this.roomDataGridView.TabIndex = 0;
            // 
            // addNewRoom
            // 
            this.addNewRoom.Location = new System.Drawing.Point(39, 196);
            this.addNewRoom.Name = "addNewRoom";
            this.addNewRoom.Size = new System.Drawing.Size(97, 23);
            this.addNewRoom.TabIndex = 1;
            this.addNewRoom.Text = "Add New Room";
            this.addNewRoom.UseVisualStyleBackColor = true;
            this.addNewRoom.Click += new System.EventHandler(this.addNewRoom_Click);
            // 
            // removeRoom
            // 
            this.removeRoom.Location = new System.Drawing.Point(39, 225);
            this.removeRoom.Name = "removeRoom";
            this.removeRoom.Size = new System.Drawing.Size(97, 23);
            this.removeRoom.TabIndex = 2;
            this.removeRoom.Text = "RemoveRoom";
            this.removeRoom.UseVisualStyleBackColor = true;
            this.removeRoom.Click += new System.EventHandler(this.removeRoom_Click);
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(161, 196);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(108, 23);
            this.backToMainMenu.TabIndex = 3;
            this.backToMainMenu.Text = "Back to Refference Book";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(178, 225);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 278);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.removeRoom);
            this.Controls.Add(this.addNewRoom);
            this.Controls.Add(this.roomDataGridView);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.Button addNewRoom;
        private System.Windows.Forms.Button removeRoom;
        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button Exit;
    }
}