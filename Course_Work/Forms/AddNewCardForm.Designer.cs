namespace Course_Work
{
    partial class AddNewCardForm
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
            this.Type = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.QuantityOfVisiting = new System.Windows.Forms.Label();
            this.quantityOfVisitingTextBox = new System.Windows.Forms.TextBox();
            this.cardPriceTextBox = new System.Windows.Forms.TextBox();
            this.cardTypeTextBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.quantityOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(56, 51);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(56, 88);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // QuantityOfVisiting
            // 
            this.QuantityOfVisiting.AutoSize = true;
            this.QuantityOfVisiting.Location = new System.Drawing.Point(56, 125);
            this.QuantityOfVisiting.Name = "QuantityOfVisiting";
            this.QuantityOfVisiting.Size = new System.Drawing.Size(96, 13);
            this.QuantityOfVisiting.TabIndex = 3;
            this.QuantityOfVisiting.Text = "Quantity Of Visiting";
            // 
            // quantityOfVisitingTextBox
            // 
            this.quantityOfVisitingTextBox.Location = new System.Drawing.Point(197, 118);
            this.quantityOfVisitingTextBox.Name = "quantityOfVisitingTextBox";
            this.quantityOfVisitingTextBox.Size = new System.Drawing.Size(170, 20);
            this.quantityOfVisitingTextBox.TabIndex = 5;
            // 
            // cardPriceTextBox
            // 
            this.cardPriceTextBox.Location = new System.Drawing.Point(197, 81);
            this.cardPriceTextBox.Name = "cardPriceTextBox";
            this.cardPriceTextBox.Size = new System.Drawing.Size(170, 20);
            this.cardPriceTextBox.TabIndex = 6;
            // 
            // cardTypeTextBox
            // 
            this.cardTypeTextBox.Location = new System.Drawing.Point(197, 44);
            this.cardTypeTextBox.Name = "cardTypeTextBox";
            this.cardTypeTextBox.Size = new System.Drawing.Size(170, 20);
            this.cardTypeTextBox.TabIndex = 7;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(77, 200);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(262, 200);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // quantityOfDaysTextBox
            // 
            this.quantityOfDaysTextBox.Location = new System.Drawing.Point(197, 154);
            this.quantityOfDaysTextBox.Name = "quantityOfDaysTextBox";
            this.quantityOfDaysTextBox.Size = new System.Drawing.Size(170, 20);
            this.quantityOfDaysTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity Of Days";
            // 
            // AddNewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.quantityOfDaysTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cardTypeTextBox);
            this.Controls.Add(this.cardPriceTextBox);
            this.Controls.Add(this.quantityOfVisitingTextBox);
            this.Controls.Add(this.QuantityOfVisiting);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Type);
            this.Name = "AddNewCardForm";
            this.Text = "AddNewCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label QuantityOfVisiting;
        private System.Windows.Forms.TextBox quantityOfVisitingTextBox;
        private System.Windows.Forms.TextBox cardPriceTextBox;
        private System.Windows.Forms.TextBox cardTypeTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox quantityOfDaysTextBox;
        private System.Windows.Forms.Label label1;
    }
}