namespace DP2
{
    partial class Sales
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
            this.salesGrid = new System.Windows.Forms.DataGridView();
            this.sales_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.viewSalesEdit_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // salesGrid
            // 
            this.salesGrid.AllowUserToAddRows = false;
            this.salesGrid.AllowUserToDeleteRows = false;
            this.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sales_id,
            this.sales_date,
            this.product_id,
            this.quantity});
            this.salesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesGrid.Location = new System.Drawing.Point(15, 16);
            this.salesGrid.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.salesGrid.MinimumSize = new System.Drawing.Size(482, 309);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.ReadOnly = true;
            this.salesGrid.RowHeadersWidth = 5;
            this.salesGrid.RowTemplate.Height = 24;
            this.salesGrid.Size = new System.Drawing.Size(482, 309);
            this.salesGrid.StandardTab = true;
            this.salesGrid.TabIndex = 0;
            this.salesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesGrid_CellContentClick);
            // 
            // sales_id
            // 
            this.sales_id.HeaderText = "sales_id";
            this.sales_id.MinimumWidth = 6;
            this.sales_id.Name = "sales_id";
            this.sales_id.ReadOnly = true;
            this.sales_id.Width = 125;
            // 
            // sales_date
            // 
            this.sales_date.HeaderText = "sales_date";
            this.sales_date.MinimumWidth = 6;
            this.sales_date.Name = "sales_date";
            this.sales_date.ReadOnly = true;
            this.sales_date.Width = 125;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.Location = new System.Drawing.Point(15, 325);
            this.addButton.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.addButton.MaximumSize = new System.Drawing.Size(91, 58);
            this.addButton.MinimumSize = new System.Drawing.Size(91, 58);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 58);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewSalesEdit_checkbox
            // 
            this.viewSalesEdit_checkbox.AutoSize = true;
            this.viewSalesEdit_checkbox.Checked = true;
            this.viewSalesEdit_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewSalesEdit_checkbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewSalesEdit_checkbox.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalesEdit_checkbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewSalesEdit_checkbox.Location = new System.Drawing.Point(360, 325);
            this.viewSalesEdit_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.viewSalesEdit_checkbox.MaximumSize = new System.Drawing.Size(137, 58);
            this.viewSalesEdit_checkbox.MinimumSize = new System.Drawing.Size(137, 58);
            this.viewSalesEdit_checkbox.Name = "viewSalesEdit_checkbox";
            this.viewSalesEdit_checkbox.Size = new System.Drawing.Size(137, 58);
            this.viewSalesEdit_checkbox.TabIndex = 3;
            this.viewSalesEdit_checkbox.Text = "READ ONLY";
            this.viewSalesEdit_checkbox.UseVisualStyleBackColor = true;
            this.viewSalesEdit_checkbox.CheckedChanged += new System.EventHandler(this.viewSalesEdit_checkbox_CheckedChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.viewSalesEdit_checkbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sales";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox viewSalesEdit_checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}