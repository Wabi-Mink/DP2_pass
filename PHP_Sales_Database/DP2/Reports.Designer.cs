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
            this.yearLabel = new System.Windows.Forms.Label();
            this.dropDownListYear = new System.Windows.Forms.ComboBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.MediumBlue;
            series2.LegendText = "Number of\\nItem Sales";
            series2.Name = "Number of Product Sales";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1042, 581);
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
            this.monthySalesReport.Location = new System.Drawing.Point(17, 4);
            this.monthySalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.monthySalesReport.Name = "monthySalesReport";
            this.monthySalesReport.Size = new System.Drawing.Size(264, 27);
            this.monthySalesReport.TabIndex = 2;
            this.monthySalesReport.Text = "Display Monthly Sales Data";
            this.monthySalesReport.UseVisualStyleBackColor = true;
            this.monthySalesReport.Click += new System.EventHandler(this.monthySalesReport_Click);
            // 
            // allTimeSalesButton
            // 
            this.allTimeSalesButton.Location = new System.Drawing.Point(17, 39);
            this.allTimeSalesButton.Margin = new System.Windows.Forms.Padding(4);
            this.allTimeSalesButton.Name = "allTimeSalesButton";
            this.allTimeSalesButton.Size = new System.Drawing.Size(264, 27);
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
            this.reportGrid.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.reportGrid.MinimumSize = new System.Drawing.Size(643, 380);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.RowHeadersWidth = 5;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(1042, 581);
            this.reportGrid.StandardTab = true;
            this.reportGrid.TabIndex = 5;
            this.reportGrid.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yearLabel.Location = new System.Drawing.Point(348, 44);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 17);
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
            this.dropDownListYear.Location = new System.Drawing.Point(398, 42);
            this.dropDownListYear.Margin = new System.Windows.Forms.Padding(4);
            this.dropDownListYear.Name = "dropDownListYear";
            this.dropDownListYear.Size = new System.Drawing.Size(64, 24);
            this.dropDownListYear.TabIndex = 8;
            this.dropDownListYear.Text = "2020";
            this.dropDownListYear.Visible = false;
            this.dropDownListYear.SelectedIndexChanged += new System.EventHandler(this.dropDownListYear_SelectedIndexChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(351, 4);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(264, 27);
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
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 77);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportGrid);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 581);
            this.panel2.TabIndex = 11;
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
            this.Jan.MinimumWidth = 6;
            this.Jan.Name = "Jan";
            this.Jan.ReadOnly = true;
            this.Jan.Width = 60;
            // 
            // Feb
            // 
            this.Feb.HeaderText = "Feb";
            this.Feb.MinimumWidth = 6;
            this.Feb.Name = "Feb";
            this.Feb.ReadOnly = true;
            this.Feb.Width = 60;
            // 
            // Mar
            // 
            this.Mar.FillWeight = 80F;
            this.Mar.HeaderText = "Mar";
            this.Mar.MinimumWidth = 6;
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            this.Mar.Width = 60;
            // 
            // Apr
            // 
            this.Apr.HeaderText = "Apr";
            this.Apr.MinimumWidth = 6;
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            this.Apr.Width = 60;
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 6;
            this.May.Name = "May";
            this.May.ReadOnly = true;
            this.May.Width = 60;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "Jun";
            this.Jun.MinimumWidth = 6;
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            this.Jun.Width = 60;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "Jul";
            this.Jul.MinimumWidth = 6;
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            this.Jul.Width = 60;
            // 
            // Aug
            // 
            this.Aug.HeaderText = "Aug";
            this.Aug.MinimumWidth = 6;
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            this.Aug.Width = 60;
            // 
            // Sep
            // 
            this.Sep.HeaderText = "Sep";
            this.Sep.MinimumWidth = 6;
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            this.Sep.Width = 60;
            // 
            // Oct
            // 
            this.Oct.HeaderText = "Oct";
            this.Oct.MinimumWidth = 6;
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            this.Oct.Width = 60;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "Nov";
            this.Nov.MinimumWidth = 6;
            this.Nov.Name = "Nov";
            this.Nov.ReadOnly = true;
            this.Nov.Width = 60;
            // 
            // Dec
            // 
            this.Dec.HeaderText = "Dec";
            this.Dec.MinimumWidth = 6;
            this.Dec.Name = "Dec";
            this.Dec.ReadOnly = true;
            this.Dec.Width = 60;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Padding = new System.Windows.Forms.Padding(20);
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