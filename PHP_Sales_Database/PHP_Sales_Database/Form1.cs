using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PHP_Sales_Database {
    public partial class PHP_Sales_System : Form {
        public PHP_Sales_System() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            //Just testing the file output feature when the button is pressed
            //Prints and appends "Hello World" to the test file when button is pressed
            StreamWriter file = new StreamWriter("test.txt", true);
            file.WriteLine("Hello World");
            file.Flush();
            file.Close();
        }

    }
}
