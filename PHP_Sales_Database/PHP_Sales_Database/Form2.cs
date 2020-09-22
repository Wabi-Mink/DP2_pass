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

namespace PHP_Sales_Database {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e) {
            StreamReader fileRead = new StreamReader("salesRecords.txt");
            if (fileRead.EndOfStream) {
                fileRead.Close();
                StreamWriter fileWrite = new StreamWriter("salesRecords.txt", true);
                fileWrite.WriteLine("SalesID,Date,PurchaseID");
                fileWrite.Close();
            }
            else {
                fileRead.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void addRecord_Click(object sender, EventArgs e) {
            //initialises the new sales data into one string array
            string[] sale_record = {textBox1.Text, dateTimePicker1.Text, textBox3.Text};

            //outputs new sales record to the salesRecords.txt file
            StreamWriter file = new StreamWriter("salesRecords.txt", true);
            for (int i = 0; i < sale_record.Length; i++) {
                file.Write(sale_record[i]);
                if (i != 2) {
                    file.Write(",");
                }
                else {
                    file.WriteLine("");
                }
            }
            file.Flush();
            file.Close();

            //closes the add records form and goes back to the main screen of the application
            new Success().Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            new PHP_Sales_System().Show();
            this.Hide();
        }
    }
}
