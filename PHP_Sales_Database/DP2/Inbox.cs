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
    public partial class Inbox : Form
    {
        public Inbox()
        {
            InitializeComponent();
        }

        private void addProductToLowStockTable(string[] entry) {
            string[] newRow = { entry[1], entry[4] };
            stockGrid.Rows.Add(newRow);
        }

        private void stockAlert() {
            string[] strLines = File.ReadAllLines("productRecords.txt");
            for (int i = 1; i < strLines.Length; i++) {
                string[] entry = strLines[i].Split(',');
                if (int.Parse(entry[4]) < 10) // replace array element with corresponding column for AMOUNT
                {
                    string message = "ALERT: " + "Low stock of " + entry[1] + " - " + entry[4] + " in stock"; // replace array elements with corresponding column for ITEM NAME and AMOUNT
                    MessageBox.Show(message);
                    addProductToLowStockTable(entry);
                }
            }
        }
        private void Inbox_Load(object sender, EventArgs e) {
            stockAlert();
        }
    }
}
