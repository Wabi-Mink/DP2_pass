﻿using System;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        private void save()
        {
            File.WriteAllText("orderRecords.txt", "order_ID,prod_ID,quantity,date");
            StreamWriter file = new StreamWriter("orderRecords.txt", true);
            file.WriteLine();
            for (int i = 0; i < ordersGrid.Rows.Count; i++)
            {
                for (int j = 0; j < ordersGrid.Rows[i].Cells.Count; j++)
                {
                    file.Write(ordersGrid.Rows[i].Cells[j].Value.ToString());
                    if (j != 3) { file.Write(","); };
                }
                file.WriteLine();
            }
            file.Flush();
            file.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                //orderRecords.txt is loaded by StreamReader
                //and all entries are placed into a table to be viewed/edited
                StreamReader records = new StreamReader("orderRecords.txt");
                records.ReadLine();
                try
                {
                    while (!records.EndOfStream)
                    {
                        string[] entry = records.ReadLine().Split(',');
                        if (entry.Length == 4)
                        {
                            ordersGrid.Rows.Add(entry);
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
                    MessageBox.Show("Data found in orderRecords.txt is either corrupted or in wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException)
            {
                addButton.Visible = false;
                MessageBox.Show("Could not find orderRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            save();
            var addSales = new addOrders();
            addSales.Location = this.Location;
            addSales.StartPosition = FormStartPosition.CenterParent;
            addSales.FormClosing += delegate
            {
                ordersGrid.Rows.Clear();
                ordersGrid.Refresh();
                Orders_Load(sender, e);
            };

            addSales.ShowDialog();
        }

        private void viewOrdersEdit_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            ordersGrid.ReadOnly = !ordersGrid.ReadOnly;
            ordersGrid.AllowUserToDeleteRows = !ordersGrid.AllowUserToDeleteRows;
        }

        private void ordersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            save();
        }
    }
}
