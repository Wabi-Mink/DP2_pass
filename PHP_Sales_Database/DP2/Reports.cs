using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void generateMonthlyReport() {
            try
            {
                try
                {
                    string[] linesSales = System.IO.File.ReadAllLines("salesRecords.txt");
                    string[] linesProducts = System.IO.File.ReadAllLines("productRecords.txt");

                    //filter sales by needed year
                    string yearNeeded = dropDownListYear.SelectedItem.ToString();
                    List<string> salesNeeded = new List<string>();

                    foreach (string row in linesSales)
                    {
                        //getting the year and month from salesRecords.txt
                        string[] rowDetails = row.Split(',');
                        string[] dateDetails = rowDetails[1].Split('/');

                        if (dateDetails.Length > 1)
                        {
                            if (dateDetails[2].ToString() == yearNeeded)
                            {
                                salesNeeded.Add(row);
                            }
                        }
                    }

                    //total values for the final report
                    double[] PD1Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD2Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD3Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD4Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD5Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD6Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD7Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] PD8Total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                    //get prices and names for each product in the store
                    Dictionary<string, string> products = new Dictionary<string, string>();
                    List<string> productNames = new List<string>();
                    foreach (string product in linesProducts)
                    {
                        string[] rowDetails = product.Split(',');
                        products.Add(rowDetails[0], rowDetails[3]);
                        productNames.Add(rowDetails[1]);
                    }

                    //calculate total prices for the report for each month
                    foreach (string sale in salesNeeded)
                    {
                        string[] saleDetails = sale.Split(',');
                        string[] dateDetails = saleDetails[1].Split('/');
                        switch (saleDetails[2].ToString())
                        {
                            case "PD000001":
                                PD1Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000002":
                                PD2Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000003":
                                PD3Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000004":
                                PD4Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000005":
                                PD5Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000006":
                                PD6Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000007":
                                PD7Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            case "PD000008":
                                PD8Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]) * double.Parse(products[saleDetails[2]]);
                                break;
                            default:
                                break;
                        }
                    }

                    //input calculated data into the report
                    List<double[]> productPricesFinal = new List<double[]>();
                    productPricesFinal.Add(PD1Total);
                    productPricesFinal.Add(PD2Total);
                    productPricesFinal.Add(PD3Total);
                    productPricesFinal.Add(PD4Total);
                    productPricesFinal.Add(PD5Total);
                    productPricesFinal.Add(PD6Total);
                    productPricesFinal.Add(PD7Total);
                    productPricesFinal.Add(PD8Total);
                    int rowIndex = 0;
                    foreach (double[] productFinal in productPricesFinal)
                    {
                        if (reportGrid.Rows.Count != productNames.Count - 1)
                        {
                            reportGrid.Rows.Add();
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            reportGrid[i + 1, rowIndex].Value = "$" + productFinal[i].ToString();
                        }
                        rowIndex++;
                    }

                    //input product names into the report
                    for (int i = 0; i < reportGrid.Rows.Count; i++)
                    {
                        reportGrid[0, i].Value = productNames[i + 1];
                    }
                }
           
                catch
                {
                    exportButton.Visible = false;
                    MessageBox.Show("Data found in salesRecords.txt/productRecords.txt is either corrupted or in wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find salesRecords.txt/productRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportReport() {
            string yearReport = dropDownListYear.SelectedItem.ToString();
            StreamWriter file;
            switch (yearReport) {
                case "2018":
                    file = new StreamWriter("MonthlySalesReport2018.csv", false);
                    break;
                case "2019":
                    file = new StreamWriter("MonthlySalesReport2019.csv", false);
                    break;
                case "2020":
                    file = new StreamWriter("MonthlySalesReport2020.csv", false);
                    break;
                default:
                    file = new StreamWriter("MonthlySalesReport2020.csv", false);
                    break;
            }

            file.WriteLine("Product,Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec");
            for (int i = 0; i < reportGrid.Rows.Count; i++) {
                for (int j = 0; j < reportGrid.Rows[i].Cells.Count; j++) {
                    file.Write(reportGrid.Rows[i].Cells[j].Value.ToString());
                    if (j != 12) { file.Write(","); };
                }
                file.WriteLine();
            }
            file.Flush();
            file.Close();
        }
        private void generateSalesGraph() {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = System.IO.File.ReadAllLines("salesRecords.txt");

                //Console.WriteLine(data[1]);

                if (lines.Length > 0)
                {
                    //first line is header
                    string firstLine = lines[0];

                    string[] headerLabels = firstLine.Split(',');

                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }

                    //for data

                    for (int r = 1; r < lines.Length; r++)
                    {
                        string[] dataWords = lines[r].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }

                    //Calculating Reports

                    int PD1count = 0;
                    int PD2count = 0;
                    int PD3count = 0;
                    int PD4count = 0;
                    int PD5count = 0;
                    int PD6count = 0;
                    int PD7count = 0;
                    int PD8count = 0;

                    foreach (DataRow datarow in dt.Rows)
                    {

                        if (datarow[2].Equals("PD000001"))
                        {
                            PD1count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000002"))
                        {
                            PD2count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000003"))
                        {
                            PD3count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000004"))
                        {
                            PD4count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000005"))
                        {
                            PD5count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000006"))
                        {
                            PD6count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000007"))
                        {
                            PD7count += int.Parse(datarow[3].ToString());
                        }
                        if (datarow[2].Equals("PD000008"))
                        {
                            PD8count += int.Parse(datarow[3].ToString());
                        }
                    }

                    //Creating Report
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(1, PD1count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(2, PD2count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(3, PD3count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(4, PD4count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(5, PD5count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(6, PD6count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(7, PD7count);
                    this.chart1.Series["Number of Product Sales"].Points.AddXY(8, PD8count);

                    chart1.ChartAreas[0].AxisX.Title = "Product ID's";
                    chart1.ChartAreas[0].AxisY.Title = "Quantity Sold";

                    dt.TableName = "TableName";
                    dt.WriteXml("dtSchema.xml");
                }
            }
        
            catch
            {
            }
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            generateSalesGraph();
            generateMonthlyReport();
        }
        private void button3_Click(object sender, EventArgs e) {
            //all time sales button
            chart1.Visible = true;
            reportGrid.Visible = false;
            yearLabel.Visible = false;
            dropDownListYear.Visible = false;
            exportButton.Visible = false;
        }
        private void monthySalesReport_Click(object sender, EventArgs e) {
            chart1.Visible = false;
            reportGrid.Visible = true;
            yearLabel.Visible = true;
            dropDownListYear.Visible = true;
            exportButton.Visible = true;
        }
        private void dropDownListYear_SelectedIndexChanged(object sender, EventArgs e) {
            generateMonthlyReport();
        }
        private void exportButton_Click(object sender, EventArgs e) {
            exportReport();
        }
    }
}
