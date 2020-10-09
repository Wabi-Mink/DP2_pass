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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(33, 96);
            this.chart1.Name = "chart1";
            series5.BorderColor = System.Drawing.Color.White;
            series5.ChartArea = "ChartArea2";
            series5.Color = System.Drawing.Color.MediumBlue;
            series5.LegendText = "Number of\\nItem Sales";
            series5.Name = "Number of Product Sales";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(444, 285);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.Text = "Product Item Sales";
            title5.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title5);
            this.chart1.Visible = false;
            // 
            // monthySalesReport
            // 
            this.monthySalesReport.Location = new System.Drawing.Point(18, 19);
            this.monthySalesReport.Name = "monthySalesReport";
            this.monthySalesReport.Size = new System.Drawing.Size(168, 22);
            this.monthySalesReport.TabIndex = 2;
            this.monthySalesReport.Text = "Display Monthly Sales Data";
            this.monthySalesReport.UseVisualStyleBackColor = true;
            this.monthySalesReport.Click += new System.EventHandler(this.monthySalesReport_Click);
            // 
            // allTimeSalesButton
            // 
            this.allTimeSalesButton.Location = new System.Drawing.Point(326, 19);
            this.allTimeSalesButton.Name = "allTimeSalesButton";
            this.allTimeSalesButton.Size = new System.Drawing.Size(168, 22);
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
            this.reportGrid.Location = new System.Drawing.Point(15, 72);
            this.reportGrid.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.reportGrid.MinimumSize = new System.Drawing.Size(482, 309);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.RowHeadersWidth = 5;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(482, 309);
            this.reportGrid.StandardTab = true;
            this.reportGrid.TabIndex = 5;
            this.reportGrid.Visible = false;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 80;
            // 
            // Jan
            // 
            this.Jan.HeaderText = "Jan";
            this.Jan.MinimumWidth = 6;
            this.Jan.Name = "Jan";
            this.Jan.ReadOnly = true;
            this.Jan.Width = 75;
            // 
            // Feb
            // 
            this.Feb.HeaderText = "Feb";
            this.Feb.MinimumWidth = 6;
            this.Feb.Name = "Feb";
            this.Feb.ReadOnly = true;
            this.Feb.Width = 75;
            // 
            // Mar
            // 
            this.Mar.FillWeight = 80F;
            this.Mar.HeaderText = "Mar";
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            this.Mar.Width = 75;
            // 
            // Apr
            // 
            this.Apr.HeaderText = "Apr";
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            this.Apr.Width = 75;
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.Name = "May";
            this.May.ReadOnly = true;
            this.May.Width = 75;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "Jun";
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            this.Jun.Width = 75;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "Jul";
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            this.Jul.Width = 5;
            // 
            // Aug
            // 
            this.Aug.HeaderText = "Aug";
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            this.Aug.Width = 75;
            // 
            // Sep
            // 
            this.Sep.HeaderText = "Sep";
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            this.Sep.Width = 75;
            // 
            // Oct
            // 
            this.Oct.HeaderText = "Oct";
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            this.Oct.Width = 75;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "Nov";
            this.Nov.Name = "Nov";
            this.Nov.ReadOnly = true;
            this.Nov.Width = 75;
            // 
            // Dec
            // 
            this.Dec.HeaderText = "Dec";
            this.Dec.Name = "Dec";
            this.Dec.ReadOnly = true;
            this.Dec.Width = 75;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yearLabel.Location = new System.Drawing.Point(24, 49);
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
            this.dropDownListYear.Location = new System.Drawing.Point(62, 46);
            this.dropDownListYear.Name = "dropDownListYear";
            this.dropDownListYear.Size = new System.Drawing.Size(121, 21);
            this.dropDownListYear.TabIndex = 8;
            this.dropDownListYear.Text = "2020";
            this.dropDownListYear.Visible = false;
            this.dropDownListYear.SelectedIndexChanged += new System.EventHandler(this.dropDownListYear_SelectedIndexChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.dropDownListYear);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.allTimeSalesButton);
            this.Controls.Add(this.monthySalesReport);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button monthySalesReport;
        private System.Windows.Forms.Button allTimeSalesButton;
        private System.Windows.Forms.DataGridView reportGrid;
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
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox dropDownListYear;
    }
}