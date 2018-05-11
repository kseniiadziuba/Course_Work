namespace Course_Work.Forms
{
    partial class VisitingCalculations
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
            this.visitingCalculationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitingCalculationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitingCalculationsDataGridView
            // 
            this.visitingCalculationsDataGridView.AllowUserToAddRows = false;
            this.visitingCalculationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitingCalculationsDataGridView.Location = new System.Drawing.Point(21, 26);
            this.visitingCalculationsDataGridView.Name = "visitingCalculationsDataGridView";
            this.visitingCalculationsDataGridView.Size = new System.Drawing.Size(470, 171);
            this.visitingCalculationsDataGridView.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(214, 231);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // VisitingCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 272);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.visitingCalculationsDataGridView);
            this.Name = "VisitingCalculations";
            this.Text = "VisitingCalculations";
            ((System.ComponentModel.ISupportInitialize)(this.visitingCalculationsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitingCalculationsDataGridView;
        private System.Windows.Forms.Button Back;
    }
}