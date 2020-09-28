namespace PHP_Sales_Database
{
    partial class addSales
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
            this.addSalesAdd_label = new System.Windows.Forms.Label();
            this.addSalesSaleDate_picker = new System.Windows.Forms.DateTimePicker();
            this.addSalesSubmit_button = new System.Windows.Forms.Button();
            this.addSalesProdID_textBox = new System.Windows.Forms.TextBox();
            this.addSalesSaleID_textBox = new System.Windows.Forms.TextBox();
            this.addSalesProdID_label = new System.Windows.Forms.Label();
            this.addSalesSaleDate_label = new System.Windows.Forms.Label();
            this.addSalesSaleID_label = new System.Windows.Forms.Label();
            this.addSalesDone_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSalesAdd_label
            // 
            this.addSalesAdd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesAdd_label.Location = new System.Drawing.Point(-1, 9);
            this.addSalesAdd_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addSalesAdd_label.Name = "addSalesAdd_label";
            this.addSalesAdd_label.Size = new System.Drawing.Size(326, 30);
            this.addSalesAdd_label.TabIndex = 7;
            this.addSalesAdd_label.Text = "Add Sales Record";
            this.addSalesAdd_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSalesSaleDate_picker
            // 
            this.addSalesSaleDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addSalesSaleDate_picker.Location = new System.Drawing.Point(167, 103);
            this.addSalesSaleDate_picker.Margin = new System.Windows.Forms.Padding(4);
            this.addSalesSaleDate_picker.Name = "addSalesSaleDate_picker";
            this.addSalesSaleDate_picker.Size = new System.Drawing.Size(132, 22);
            this.addSalesSaleDate_picker.TabIndex = 16;
            this.addSalesSaleDate_picker.Value = new System.DateTime(2020, 9, 24, 0, 0, 0, 0);
            // 
            // addSalesSubmit_button
            // 
            this.addSalesSubmit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSalesSubmit_button.Location = new System.Drawing.Point(33, 211);
            this.addSalesSubmit_button.Margin = new System.Windows.Forms.Padding(4);
            this.addSalesSubmit_button.Name = "addSalesSubmit_button";
            this.addSalesSubmit_button.Size = new System.Drawing.Size(119, 57);
            this.addSalesSubmit_button.TabIndex = 15;
            this.addSalesSubmit_button.Text = "Submit";
            this.addSalesSubmit_button.UseVisualStyleBackColor = true;
            this.addSalesSubmit_button.Click += new System.EventHandler(this.addSalesSubmit_button_Click);
            // 
            // addSalesProdID_textBox
            // 
            this.addSalesProdID_textBox.Location = new System.Drawing.Point(167, 163);
            this.addSalesProdID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.addSalesProdID_textBox.Name = "addSalesProdID_textBox";
            this.addSalesProdID_textBox.Size = new System.Drawing.Size(132, 22);
            this.addSalesProdID_textBox.TabIndex = 14;
            // 
            // addSalesSaleID_textBox
            // 
            this.addSalesSaleID_textBox.Location = new System.Drawing.Point(167, 50);
            this.addSalesSaleID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.addSalesSaleID_textBox.Name = "addSalesSaleID_textBox";
            this.addSalesSaleID_textBox.Size = new System.Drawing.Size(132, 22);
            this.addSalesSaleID_textBox.TabIndex = 13;
            // 
            // addSalesProdID_label
            // 
            this.addSalesProdID_label.AutoSize = true;
            this.addSalesProdID_label.Location = new System.Drawing.Point(30, 168);
            this.addSalesProdID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addSalesProdID_label.Name = "addSalesProdID_label";
            this.addSalesProdID_label.Size = new System.Drawing.Size(78, 17);
            this.addSalesProdID_label.TabIndex = 12;
            this.addSalesProdID_label.Text = "Product ID:";
            // 
            // addSalesSaleDate_label
            // 
            this.addSalesSaleDate_label.AutoSize = true;
            this.addSalesSaleDate_label.Location = new System.Drawing.Point(30, 108);
            this.addSalesSaleDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addSalesSaleDate_label.Name = "addSalesSaleDate_label";
            this.addSalesSaleDate_label.Size = new System.Drawing.Size(74, 17);
            this.addSalesSaleDate_label.TabIndex = 11;
            this.addSalesSaleDate_label.Text = "Sale Date:";
            // 
            // addSalesSaleID_label
            // 
            this.addSalesSaleID_label.AutoSize = true;
            this.addSalesSaleID_label.Location = new System.Drawing.Point(30, 55);
            this.addSalesSaleID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addSalesSaleID_label.Name = "addSalesSaleID_label";
            this.addSalesSaleID_label.Size = new System.Drawing.Size(57, 17);
            this.addSalesSaleID_label.TabIndex = 10;
            this.addSalesSaleID_label.Text = "Sale ID:";
            // 
            // addSalesDone_button
            // 
            this.addSalesDone_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSalesDone_button.Location = new System.Drawing.Point(180, 211);
            this.addSalesDone_button.Margin = new System.Windows.Forms.Padding(4);
            this.addSalesDone_button.Name = "addSalesDone_button";
            this.addSalesDone_button.Size = new System.Drawing.Size(119, 57);
            this.addSalesDone_button.TabIndex = 17;
            this.addSalesDone_button.Text = "Done";
            this.addSalesDone_button.UseVisualStyleBackColor = true;
            this.addSalesDone_button.Click += new System.EventHandler(this.addSalesDone_button_Click);
            // 
            // addSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 287);
            this.Controls.Add(this.addSalesDone_button);
            this.Controls.Add(this.addSalesSaleDate_picker);
            this.Controls.Add(this.addSalesSubmit_button);
            this.Controls.Add(this.addSalesProdID_textBox);
            this.Controls.Add(this.addSalesSaleID_textBox);
            this.Controls.Add(this.addSalesProdID_label);
            this.Controls.Add(this.addSalesSaleDate_label);
            this.Controls.Add(this.addSalesSaleID_label);
            this.Controls.Add(this.addSalesAdd_label);
            this.Name = "addSales";
            this.Text = "Add Sales Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addSalesAdd_label;
        private System.Windows.Forms.DateTimePicker addSalesSaleDate_picker;
        private System.Windows.Forms.Button addSalesSubmit_button;
        private System.Windows.Forms.TextBox addSalesProdID_textBox;
        private System.Windows.Forms.TextBox addSalesSaleID_textBox;
        private System.Windows.Forms.Label addSalesProdID_label;
        private System.Windows.Forms.Label addSalesSaleDate_label;
        private System.Windows.Forms.Label addSalesSaleID_label;
        private System.Windows.Forms.Button addSalesDone_button;
    }
}