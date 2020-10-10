using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void stockAlert(DataGridView grid) {

            void addProductToLowStockTable(string[] entry)
            {
                string[] newRow = { entry[1], entry[4] };
                grid.Rows.Add(newRow);
            }

            if (activeMode != "lowStock")
            {
                if (grid.Columns.Count > 1)
                    grid.Columns.RemoveAt(1);

                grid.Columns.Add("Stock", "Stock");
                grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
        }

        private void lowStockButton_Click(object sender, EventArgs e)
        {
            inboxLabel.Visible = true;
            inboxGrid.Visible = true;
            stockAlert(inboxGrid);

            activeMode = "lowStock";
        }
    }
}
