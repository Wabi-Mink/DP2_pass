namespace DP2
{
    partial class Orders
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
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.viewOrdersEdit_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersGrid
            // 
            this.ordersGrid.AllowUserToAddRows = false;
            this.ordersGrid.AllowUserToDeleteRows = false;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_date,
            this.product_id,
            this.quantity});
            this.ordersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGrid.Location = new System.Drawing.Point(20, 20);
            this.ordersGrid.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.ordersGrid.MinimumSize = new System.Drawing.Size(643, 380);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.ReadOnly = true;
            this.ordersGrid.RowHeadersWidth = 5;
            this.ordersGrid.RowTemplate.Height = 24;
            this.ordersGrid.Size = new System.Drawing.Size(1042, 658);
            this.ordersGrid.StandardTab = true;
            this.ordersGrid.TabIndex = 1;
            this.ordersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGrid_CellContentClick);
            // 
            // order_id
            // 
            this.order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order_id.HeaderText = "order_id";
            this.order_id.MinimumWidth = 6;
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 90;
            // 
            // order_date
            // 
            this.order_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.order_date.HeaderText = "order_date";
            this.order_date.MinimumWidth = 6;
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 107;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.viewOrdersEdit_checkbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 100);
            this.panel1.TabIndex = 5;
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
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // viewOrdersEdit_checkbox
            // 
            this.viewOrdersEdit_checkbox.AutoSize = true;
            this.viewOrdersEdit_checkbox.Checked = true;
            this.viewOrdersEdit_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewOrdersEdit_checkbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewOrdersEdit_checkbox.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersEdit_checkbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewOrdersEdit_checkbox.Location = new System.Drawing.Point(859, 0);
            this.viewOrdersEdit_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewOrdersEdit_checkbox.MaximumSize = new System.Drawing.Size(183, 71);
            this.viewOrdersEdit_checkbox.MinimumSize = new System.Drawing.Size(183, 71);
            this.viewOrdersEdit_checkbox.Name = "viewOrdersEdit_checkbox";
            this.viewOrdersEdit_checkbox.Size = new System.Drawing.Size(183, 71);
            this.viewOrdersEdit_checkbox.TabIndex = 3;
            this.viewOrdersEdit_checkbox.Text = "READ ONLY";
            this.viewOrdersEdit_checkbox.UseVisualStyleBackColor = true;
            this.viewOrdersEdit_checkbox.CheckedChanged += new System.EventHandler(this.viewOrdersEdit_checkbox_CheckedChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ordersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Orders";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox viewOrdersEdit_checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}