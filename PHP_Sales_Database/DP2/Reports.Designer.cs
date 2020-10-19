namespace DP2
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthySalesReport = new System.Windows.Forms.Button();
            this.allTimeSalesButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dropDownListYear = new System.Windows.Forms.ComboBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.MediumBlue;
            series2.LegendText = "Number of\\nItem Sales";
            series2.Name = "Number of Product Sales";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(782, 472);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Product Item Sales";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title2);
            this.chart1.Visible = false;
            // 
            // monthySalesReport
            // 
            this.monthySalesReport.Location = new System.Drawing.Point(13, 3);
            this.monthySalesReport.Name = "monthySalesReport";
            this.monthySalesReport.Size = new System.Drawing.Size(198, 22);
            this.monthySalesReport.TabIndex = 2;
            this.monthySalesReport.Text = "Display Monthly Sales Data";
            this.monthySalesReport.UseVisualStyleBackColor = true;
            this.monthySalesReport.Click += new System.EventHandler(this.monthySalesReport_Click);
            // 
            // allTimeSalesButton
            // 
            this.allTimeSalesButton.Location = new System.Drawing.Point(13, 32);
            this.allTimeSalesButton.Name = "allTimeSalesButton";
            this.allTimeSalesButton.Size = new System.Drawing.Size(198, 22);
            this.allTimeSalesButton.TabIndex = 4;
            this.allTimeSalesButton.Text = "Display All Time Product Sales";
            this.allTimeSalesButton.UseVisualStyleBackColor = true;
            this.allTimeSalesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportGrid
            // 
            this.reportGrid.AllowUserToAddRows = false;
            this.reportGrid.AllowUserToDeleteRows = false;
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Jan,
            this.Feb,
            this.Mar,
            this.Apr,
            this.May,
            this.Jun,
            this.Jul,
            this.Aug,
            this.Sep,
            this.Oct,
            this.Nov,
            this.Dec});
            this.reportGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportGrid.Location = new System.Drawing.Point(0, 0);
            this.reportGrid.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.reportGrid.MinimumSize = new System.Drawing.Size(482, 309);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.RowHeadersWidth = 5;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(782, 472);
            this.reportGrid.StandardTab = true;
            this.reportGrid.TabIndex = 5;
            this.reportGrid.Visible = false;
            this.reportGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportGrid_CellContentClick);
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Jan
            // 
            this.Jan.HeaderText = "Jan";
            this.Jan.MinimumWidth = 70;
            this.Jan.Name = "Jan";
            this.Jan.ReadOnly = true;
            this.Jan.Width = 70;
            // 
            // Feb
            // 
            this.Feb.HeaderText = "Feb";
            this.Feb.MinimumWidth = 70;
            this.Feb.Name = "Feb";
            this.Feb.ReadOnly = true;
            this.Feb.Width = 70;
            // 
            // Mar
            // 
            this.Mar.FillWeight = 80F;
            this.Mar.HeaderText = "Mar";
            this.Mar.MinimumWidth = 70;
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            this.Mar.Width = 70;
            // 
            // Apr
            // 
            this.Apr.HeaderText = "Apr";
            this.Apr.MinimumWidth = 70;
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            this.Apr.Width = 70;
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 70;
            this.May.Name = "May";
            this.May.ReadOnly = true;
            this.May.Width = 70;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "Jun";
            this.Jun.MinimumWidth = 70;
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            this.Jun.Width = 70;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "Jul";
            this.Jul.MinimumWidth = 70;
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            this.Jul.Width = 70;
            // 
            // Aug
            // 
            this.Aug.HeaderText = "Aug";
            this.Aug.MinimumWidth = 70;
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            this.Aug.Width = 70;
            // 
            // Sep
            // 
            this.Sep.HeaderText = "Sep";
            this.Sep.MinimumWidth = 70;
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            this.Sep.Width = 70;
            // 
            // Oct
            // 
            this.Oct.HeaderText = "Oct";
            this.Oct.MinimumWidth = 70;
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            this.Oct.Width = 70;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "Nov";
            this.Nov.MinimumWidth = 70;
            this.Nov.Name = "Nov";
            this.Nov.ReadOnly = true;
            this.Nov.Width = 70;
            // 
            // Dec
            // 
            this.Dec.HeaderText = "Dec";
            this.Dec.MinimumWidth = 70;
            this.Dec.Name = "Dec";
            this.Dec.ReadOnly = true;
            this.Dec.Width = 70;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yearLabel.Location = new System.Drawing.Point(261, 36);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year:";
            this.yearLabel.Visible = false;
            // 
            // dropDownListYear
            // 
            this.dropDownListYear.FormattingEnabled = true;
            this.dropDownListYear.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018"});
            this.dropDownListYear.Location = new System.Drawing.Point(298, 34);
            this.dropDownListYear.Name = "dropDownListYear";
            this.dropDownListYear.Size = new System.Drawing.Size(49, 21);
            this.dropDownListYear.TabIndex = 8;
            this.dropDownListYear.Text = "2020";
            this.dropDownListYear.Visible = false;
            this.dropDownListYear.SelectedIndexChanged += new System.EventHandler(this.dropDownListYear_SelectedIndexChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(263, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(198, 22);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Export Report as .CSV File";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Visible = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthySalesReport);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.dropDownListYear);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.allTimeSalesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 63);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportGrid);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 472);
            this.panel2.TabIndex = 11;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(812, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button monthySalesReport;
        private System.Windows.Forms.Button allTimeSalesButton;
        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox dropDownListYear;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apr;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dec;
    }
}