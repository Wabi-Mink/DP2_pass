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

namespace PHP_Sales_Database
{
    public partial class addSales : Form
    {
        public addSales()
        {
            InitializeComponent();
        }

        private void addSalesDone_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSalesSubmit_button_Click(object sender, EventArgs e)
        {
            //initialises the new sales data into one string array
            string[] sale_record = { addSalesSaleID_textBox.Text, 
                                    addSalesSaleDate_picker.Text, 
                                    addSalesProdID_textBox.Text };

            //outputs new sales record to the salesRecords.txt file
            StreamWriter file = new StreamWriter("salesRecords.txt", true);
            for (int i = 0; i < sale_record.Length; i++)
            {
                file.Write(sale_record[i]);
                if (i != 2)
                {
                    file.Write(",");
                }
                else
                {
                    file.WriteLine("");
                }
            }
            file.Flush();
            file.Close();

            //Show a success message box
            var msgBox = MessageBox.Show("Added", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset textBox and date picker
            addSalesSaleID_textBox.Text = "";
            addSalesSaleDate_picker.Value = DateTime.Now;
            addSalesProdID_textBox.Text = "";
        }

        private void addSalesSaleID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
