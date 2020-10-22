using System;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void save()
        {
            try
            {
                //StreamReader records = new StreamReader("salesRecords.txt");
                File.WriteAllText("salesRecords.txt", "sales_ID,date,prod_ID,quantity");
                StreamWriter file = new StreamWriter("salesRecords.txt", true);
                file.WriteLine();
                for (int i = 0; i < salesGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < salesGrid.Rows[i].Cells.Count; j++)
                    {
                        file.Write(salesGrid.Rows[i].Cells[j].Value.ToString());
                        if (j != 3) { file.Write(","); };
                    }
                    file.WriteLine();
                }
                file.Flush();
                file.Close();
            }
            catch
            {

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                //salesRecords.txt is loaded by StreamReader
                //and all entries are placed into a table to be viewed/edited
                StreamReader records = new StreamReader("salesRecords.txt");
                records.ReadLine();
                while (!records.EndOfStream)
                {
                    string[] entry = records.ReadLine().Split(',');
                    salesGrid.Rows.Add(entry);
                }
                records.Close();
            }
            catch (FileNotFoundException)
            {
                addButton.Visible = false;
                MessageBox.Show("Could not find salesRecords.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewSalesEdit_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            salesGrid.ReadOnly = !salesGrid.ReadOnly;
            salesGrid.AllowUserToDeleteRows = !salesGrid.AllowUserToDeleteRows;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            save();
            var addSales = new addSales();
            addSales.Location = this.Location;
            addSales.StartPosition = FormStartPosition.CenterParent;
            addSales.FormClosing += delegate
            {
                salesGrid.Rows.Clear();
                salesGrid.Refresh();
                Sales_Load(sender, e);
            };
            addSales.ShowDialog();
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void salesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            save();
        }
    }
}
