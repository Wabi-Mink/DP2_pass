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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load_1(object sender, EventArgs e) {
            //productRecords.txt is loaded by StreamReader
            //and all entries are placed into a table
            StreamReader records = new StreamReader("productRecords.txt");
            records.ReadLine();
            while (!records.EndOfStream) {
                string[] entry = records.ReadLine().Split(',');
                productGrid.Rows.Add(entry);
            }
            records.Close();
        }
    }
}
