using System;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load_1(object sender, EventArgs e)
        {
            //productRecords.txt is loaded by StreamReader
            //and all entries are placed into a table
            try
            {
                StreamReader records = new StreamReader("productRecords.txt");
                records.ReadLine();
                try
                {
                    while (!records.EndOfStream)
                    {
                        string[] entry = records.ReadLine().Split(',');
                        if (entry.Length == 5)
                        {
                            productGrid.Rows.Add(entry);
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }

                    records.Close();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("1Data found in salesRecords.txt/productRecords.txt is either corrupted or in wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find productRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
