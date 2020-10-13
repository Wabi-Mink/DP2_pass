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
    public partial class addSales : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public addSales()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
        }

        private void writeToFile(string filepath, string[] entries) {
            StreamWriter file = new StreamWriter(filepath, false);
            for (int i = 0; i < entries.Length; i++) {
                file.WriteLine(entries[i]);
            }

            file.Flush();
            file.Close();
        }

        private bool alterInventoryStock(string prodID, string quantity) {
            string[] linesProducts = System.IO.File.ReadAllLines("productRecords.txt");
            for (int i = 1; i < linesProducts.Length; i++) {
                string[] productSplit = linesProducts[i].Split(',');
                if (productSplit[0] == prodID) {
                    if ((int.Parse(productSplit[4]) - int.Parse(quantity)) >= 0 ) {
                        productSplit[4] = (int.Parse(productSplit[4]) - int.Parse(quantity)).ToString();
                        string alteredEntry = productSplit[0] + "," + productSplit[1] + "," + productSplit[2] + "," + productSplit[3] + "," + productSplit[4];
                        linesProducts[i] = alteredEntry;
                        writeToFile("productRecords.txt", linesProducts);
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            return false;
        }

        private void doneIcon_Click(object sender, EventArgs e)
        {
            //initialises the new sales data into one string array
            string[] sale_record = { idText.Text,
                                    datePicker.Text,
                                    prodIDText.Text,
                                    quantityNum.Text};

            //check and change the inventory of the item purchased (if able) so that its value goes down.
            if (alterInventoryStock(prodIDText.Text, quantityNum.Text)) {
                //outputs new sales record to the salesRecords.txt file
                StreamWriter file = new StreamWriter("salesRecords.txt", true);
                for (int i = 0; i < sale_record.Length; i++) {
                    file.Write(sale_record[i]);
                    if (i != 3) {
                        file.Write(",");
                    } else {
                        file.WriteLine("");
                    }
                }
                file.Flush();
                file.Close();

                //Show a success message box
                var msgBox = MessageBox.Show("Added", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                deleteIcon_Click(sender, e);
            }
            else {
                //Show a success message box
                var msgBox = MessageBox.Show("Not enough product stock left. Sale cannot be added.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            enterCurrentID();
            datePicker.Value = DateTime.Now;
            prodIDText.Text = "";
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addSales_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void enterCurrentID() {
            string[] sales = System.IO.File.ReadAllLines("salesRecords.txt");
            idText.Text = "S0000000" + sales.Length.ToString();
        }

        private void addSales_Load(object sender, EventArgs e) {
            enterCurrentID();
        }
    }
}
