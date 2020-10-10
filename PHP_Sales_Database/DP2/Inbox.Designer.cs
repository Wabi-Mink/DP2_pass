namespace DP2
{
    partial class Inbox
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
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.idLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockGrid
            // 
            this.stockGrid.AllowUserToAddRows = false;
            this.stockGrid.AllowUserToDeleteRows = false;
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Stock});
            this.stockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockGrid.Location = new System.Drawing.Point(0, 0);
            this.stockGrid.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.stockGrid.MinimumSize = new System.Drawing.Size(643, 380);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.ReadOnly = true;
            this.stockGrid.RowHeadersWidth = 5;
            this.stockGrid.RowTemplate.Height = 24;
            this.stockGrid.Size = new System.Drawing.Size(1042, 604);
            this.stockGrid.StandardTab = true;
            this.stockGrid.TabIndex = 1;
            // 
            // idLable
            // 
            this.idLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.idLable.Location = new System.Drawing.Point(0, 0);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(1042, 54);
            this.idLable.TabIndex = 5;
            this.idLable.Text = "Products With Low Stock";
            this.idLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 54);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stockGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 604);
            this.panel2.TabIndex = 7;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inbox";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Inbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}