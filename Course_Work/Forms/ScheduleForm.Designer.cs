namespace Course_Work.Forms
{
    partial class ScheduleForm
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
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewSchedule = new System.Windows.Forms.Button();
            this.RemoveSchedule = new System.Windows.Forms.Button();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AllowUserToAddRows = false;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(37, 35);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(710, 199);
            this.scheduleDataGridView.TabIndex = 0;
            // 
            // addNewSchedule
            // 
            this.addNewSchedule.Location = new System.Drawing.Point(506, 260);
            this.addNewSchedule.Name = "addNewSchedule";
            this.addNewSchedule.Size = new System.Drawing.Size(107, 23);
            this.addNewSchedule.TabIndex = 1;
            this.addNewSchedule.Text = "Add New Schedule";
            this.addNewSchedule.UseVisualStyleBackColor = true;
            this.addNewSchedule.Click += new System.EventHandler(this.addNewSchedule_Click);
            // 
            // RemoveSchedule
            // 
            this.RemoveSchedule.Location = new System.Drawing.Point(506, 299);
            this.RemoveSchedule.Name = "RemoveSchedule";
            this.RemoveSchedule.Size = new System.Drawing.Size(107, 23);
            this.RemoveSchedule.TabIndex = 2;
            this.RemoveSchedule.Text = "Remove Schedule";
            this.RemoveSchedule.UseVisualStyleBackColor = true;
            this.RemoveSchedule.Click += new System.EventHandler(this.RemoveSchedule_Click);
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(496, 339);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(117, 23);
            this.backToMainMenu.TabIndex = 3;
            this.backToMainMenu.Text = "Back to Main Menu";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(647, 299);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.RemoveSchedule);
            this.Controls.Add(this.addNewSchedule);
            this.Controls.Add(this.scheduleDataGridView);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.Button addNewSchedule;
        private System.Windows.Forms.Button RemoveSchedule;
        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Button Exit;
    }
}