using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class Inbox : Form
    {
        private string activeMode = "";
        public Inbox()
        {
            InitializeComponent();
        }

        private void stockAlert(DataGridView grid)
        {

            void addProductToLowStockTable(string[] entry)
            {
                string[] newRow = { entry[1], entry[4] };
                grid.Rows.Add(newRow);
            }

            if (activeMode != "lowStock")
            {
                if (grid.Columns.Count > 1)
                {
                    grid.Columns.RemoveAt(1);
                }

                grid.Rows.Clear();

                grid.Columns.Add("Stock", "Stock");
                grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                try
                {
                    try
                    {
                        string[] strLines = File.ReadAllLines("productRecords.txt");
                        for (int i = 1; i < strLines.Length; i++)
                        {
                            string[] entry = strLines[i].Split(',');
                            if (int.Parse(entry[4]) < 10) // replace array element with corresponding column for AMOUNT
                            {
                                string message = "ALERT: " + "Low stock of " + entry[1] + " - " + entry[4] + " in stock"; // replace array elements with corresponding column for ITEM NAME and AMOUNT
                                MessageBox.Show(message);
                                addProductToLowStockTable(entry);
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Data found in productRecords.txt is either corrupted or in wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not find productRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lowStockButton_Click(object sender, EventArgs e)
        {
            inboxLabel.Text = "Products with Low Stock";
            inboxLabel.Visible = true;
            inboxGrid.Visible = true;
            stockAlert(inboxGrid);

            activeMode = "lowStock";
        }

        private void growthRateCalculation(DataGridView grid)
        {
            if (activeMode != "highDemand")
            {
                if (grid.Columns.Count > 1)
                {
                    grid.Columns.RemoveAt(1);
                }

                grid.Rows.Clear();
                try
                {
                    string[] linesSales = System.IO.File.ReadAllLines("salesRecords.txt");
                    string[] linesProducts = System.IO.File.ReadAllLines("productRecords.txt");

                    //filter sales by needed year
                    string yearNeeded = "2020";
                    List<string> salesNeeded = new List<string>();

                    try
                    {
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
                                    PD1Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000002":
                                    PD2Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000003":
                                    PD3Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000004":
                                    PD4Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000005":
                                    PD5Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000006":
                                    PD6Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000007":
                                    PD7Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                case "PD000008":
                                    PD8Total[int.Parse(dateDetails[1]) - 1] += int.Parse(saleDetails[3]);
                                    break;
                                default:
                                    break;
                            }
                        }

                        double[][] PDTotal = {  PD1Total, PD2Total, PD3Total,
                                        PD4Total, PD5Total, PD6Total,
                                        PD7Total, PD8Total };

                        Hashtable monthlyGrowRate = new Hashtable();

                        int i = 1;
                        foreach (double[] product in PDTotal)
                        {
                            monthlyGrowRate.Add(productNames[i++], product[8] == 0 ?
                                "Not Available" :
                                Math.Round(((product[9] - product[8]) / product[8]), 4).ToString());
                        }

                        grid.Columns.Add("Monthly growth rate", "Monthly growth rate");
                        grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        foreach (DictionaryEntry record in monthlyGrowRate)
                        {
                            string[] newRow = { record.Key.ToString(), record.Value.ToString() };
                            grid.Rows.Add(newRow);
                        }
                    }

                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Data found in salesRecords.txt/productRecords.txt is either corrupted or in wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not find salesRecords.txt/productRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void highDemandButton_Click(object sender, EventArgs e)
        {
            inboxLabel.Text = "Products with High Demand";
            inboxLabel.Visible = true;
            inboxGrid.Visible = true;

            growthRateCalculation(inboxGrid);
            try
            {
                inboxGrid.Sort(inboxGrid.Columns[1], ListSortDirection.Ascending);
            }
            catch { }

            activeMode = "highDemand";
        }
    }
}
