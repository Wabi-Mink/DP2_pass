using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_Sales_Database {
    public partial class Success : Form {
        public Success() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            new Form2().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            new PHP_Sales_System().Show();
            this.Hide();
        }
    }
}
