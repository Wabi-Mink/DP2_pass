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
            this.inboxGrid = new System.Windows.Forms.DataGridView();
            this.inboxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.highDemmandButton = new System.Windows.Forms.Button();
            this.lowStockButton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inboxGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inboxGrid
            // 
            this.inboxGrid.AllowUserToAddRows = false;
            this.inboxGrid.AllowUserToDeleteRows = false;
            this.inboxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inboxGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product});
            this.inboxGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxGrid.Location = new System.Drawing.Point(0, 0);
            this.inboxGrid.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.inboxGrid.MinimumSize = new System.Drawing.Size(643, 380);
            this.inboxGrid.Name = "inboxGrid";
            this.inboxGrid.ReadOnly = true;
            this.inboxGrid.RowHeadersWidth = 5;
            this.inboxGrid.RowTemplate.Height = 24;
            this.inboxGrid.Size = new System.Drawing.Size(1042, 550);
            this.inboxGrid.StandardTab = true;
            this.inboxGrid.TabIndex = 1;
            this.inboxGrid.Visible = false;
            // 
            // inboxLabel
            // 
            this.inboxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.inboxLabel.Location = new System.Drawing.Point(0, 0);
            this.inboxLabel.Name = "inboxLabel";
            this.inboxLabel.Size = new System.Drawing.Size(1042, 61);
            this.inboxLabel.TabIndex = 5;
            this.inboxLabel.Text = "Products With Low Stock";
            this.inboxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inboxLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inboxLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 61);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inboxGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 550);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.highDemmandButton);
            this.panel3.Controls.Add(this.lowStockButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1042, 47);
            this.panel3.TabIndex = 8;
            // 
            // highDemmandButton
            // 
            this.highDemmandButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.highDemmandButton.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highDemmandButton.Location = new System.Drawing.Point(736, 5);
            this.highDemmandButton.Name = "highDemmandButton";
            this.highDemmandButton.Size = new System.Drawing.Size(301, 37);
            this.highDemmandButton.TabIndex = 1;
            this.highDemmandButton.Text = "Products With High Demmand";
            this.highDemmandButton.UseVisualStyleBackColor = true;
            // 
            // lowStockButton
            // 
            this.lowStockButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.lowStockButton.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowStockButton.Location = new System.Drawing.Point(5, 5);
            this.lowStockButton.Name = "lowStockButton";
            this.lowStockButton.Size = new System.Drawing.Size(301, 37);
            this.lowStockButton.TabIndex = 0;
            this.lowStockButton.Text = "Products With Low Stock";
            this.lowStockButton.UseVisualStyleBackColor = true;
            this.lowStockButton.Click += new System.EventHandler(this.lowStockButton_Click);
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inbox";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.inboxGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inboxGrid;
        private System.Windows.Forms.Label inboxLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button highDemmandButton;
        private System.Windows.Forms.Button lowStockButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
    }
}