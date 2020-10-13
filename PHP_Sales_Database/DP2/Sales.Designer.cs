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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.salesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGrid.Location = new System.Drawing.Point(0, 0);
            this.salesGrid.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.salesGrid.MinimumSize = new System.Drawing.Size(643, 380);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.ReadOnly = true;
            this.salesGrid.RowHeadersWidth = 5;
            this.salesGrid.RowTemplate.Height = 24;
            this.salesGrid.Size = new System.Drawing.Size(1042, 558);
            this.salesGrid.StandardTab = true;
            this.salesGrid.TabIndex = 0;
            this.salesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesGrid_CellContentClick);
            // 
            // sales_id
            // 
            this.sales_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_id.HeaderText = "sales_id";
            this.sales_id.MinimumWidth = 6;
            this.sales_id.Name = "sales_id";
            this.sales_id.ReadOnly = true;
            this.sales_id.Width = 89;
            // 
            // sales_date
            // 
            this.sales_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_date.HeaderText = "sales_date";
            this.sales_date.MinimumWidth = 6;
            this.sales_date.Name = "sales_date";
            this.sales_date.ReadOnly = true;
            this.sales_date.Width = 106;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.product_id.HeaderText = "product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 104;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.addButton.MaximumSize = new System.Drawing.Size(121, 71);
            this.addButton.MinimumSize = new System.Drawing.Size(121, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 71);
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
            this.viewSalesEdit_checkbox.Location = new System.Drawing.Point(859, 0);
            this.viewSalesEdit_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewSalesEdit_checkbox.MaximumSize = new System.Drawing.Size(183, 71);
            this.viewSalesEdit_checkbox.MinimumSize = new System.Drawing.Size(183, 71);
            this.viewSalesEdit_checkbox.Name = "viewSalesEdit_checkbox";
            this.viewSalesEdit_checkbox.Size = new System.Drawing.Size(183, 71);
            this.viewSalesEdit_checkbox.TabIndex = 3;
            this.viewSalesEdit_checkbox.Text = "READ ONLY";
            this.viewSalesEdit_checkbox.UseVisualStyleBackColor = true;
            this.viewSalesEdit_checkbox.CheckedChanged += new System.EventHandler(this.viewSalesEdit_checkbox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.viewSalesEdit_checkbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.salesGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 558);
            this.panel2.TabIndex = 5;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sales";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox viewSalesEdit_checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}