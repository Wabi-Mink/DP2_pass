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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form4_Load(object sender, EventArgs e) {
            //salesRecords.txt is loaded by StreamReader
            //and all entries are placed into a table to be viewed/edited
            StreamReader records = new StreamReader("salesRecords.txt");
            while (!records.EndOfStream) {
                string[] entry = records.ReadLine().Split(',');
                dataGridView1.Rows.Add(entry);
            }
            records.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            //updates salesRecords.txt with any changes made by the user
            int colCount = dataGridView1.Columns.Count;
            int rowCount = dataGridView1.Rows.Count;
            StreamWriter file = new StreamWriter("salesRecords.txt", false);
            for (int i = 0; i < rowCount -1; i++) {
                for (int s = 0; s < colCount; s++) {
                    file.Write(dataGridView1[s,i].Value.ToString());
                    if (s != 2) {
                        file.Write(",");
                    }
                    else {
                        file.WriteLine("");
                    }
                }
            }
            file.Close();

            new Form5().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            new PHP_Sales_System().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
