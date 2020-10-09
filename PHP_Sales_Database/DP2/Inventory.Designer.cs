namespace DP2
{
    partial class Inventory
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
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.prod_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_ID,
            this.prod_name,
            this.prescription,
            this.price,
            this.num_in_stock});
            this.productGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.productGrid.Location = new System.Drawing.Point(15, 16);
            this.productGrid.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.productGrid.MinimumSize = new System.Drawing.Size(482, 309);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersWidth = 5;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(482, 309);
            this.productGrid.StandardTab = true;
            this.productGrid.TabIndex = 1;
            // 
            // prod_ID
            // 
            this.prod_ID.HeaderText = "prod_ID";
            this.prod_ID.MinimumWidth = 6;
            this.prod_ID.Name = "prod_ID";
            this.prod_ID.ReadOnly = true;
            this.prod_ID.Width = 80;
            // 
            // prod_name
            // 
            this.prod_name.HeaderText = "prod_name";
            this.prod_name.MinimumWidth = 6;
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            this.prod_name.Width = 150;
            // 
            // prescription
            // 
            this.prescription.HeaderText = "prescription";
            this.prescription.MinimumWidth = 6;
            this.prescription.Name = "prescription";
            this.prescription.ReadOnly = true;
            this.prescription.Width = 80;
            // 
            // price
            // 
            this.price.FillWeight = 80F;
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // num_in_stock
            // 
            this.num_in_stock.HeaderText = "num_in_stock";
            this.num_in_stock.Name = "num_in_stock";
            this.num_in_stock.ReadOnly = true;
            this.num_in_stock.Width = 80;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.productGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Inventory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_in_stock;
    }
}