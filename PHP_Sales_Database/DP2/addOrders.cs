using System;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class addOrders : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public addOrders()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
        }

        private void writeToFile(string filepath, string[] entries)
        {
            StreamWriter file = new StreamWriter(filepath, false);
            for (int i = 0; i < entries.Length; i++)
            {
                file.WriteLine(entries[i]);
            }

            file.Flush();
            file.Close();
        }

        private bool alterInventoryStock(string prodID, string quantity)
        {
            string[] linesProducts = System.IO.File.ReadAllLines("productRecords.txt");
            for (int i = 1; i < linesProducts.Length; i++)
            {
                string[] productSplit = linesProducts[i].Split(',');
                if (productSplit[0] == prodID)
                {
                    productSplit[4] = (int.Parse(productSplit[4]) + int.Parse(quantity)).ToString();
                    string alteredEntry = productSplit[0] + "," + productSplit[1] + "," + productSplit[2] + "," + productSplit[3] + "," + productSplit[4];
                    linesProducts[i] = alteredEntry;
                    writeToFile("productRecords.txt", linesProducts);
                    return true;
                }
            }
            return false;
        }

        private void doneIcon_Click(object sender, EventArgs e)
        {
            //initialises the new sales data into one string array
            string[] order_record = { idText.Text,
                                    datePicker.Text,
                                    prodIDText.Text,
                                    quantityNum.Text};

            //check and change the inventory of the item purchased (if able) so that its value goes down.
            if (alterInventoryStock(prodIDText.Text, quantityNum.Text))
            {
                //outputs new sales record to the orderRecords.txt file
                StreamWriter file = new StreamWriter("orderRecords.txt", true);
                for (int i = 0; i < order_record.Length; i++)
                {
                    file.Write(order_record[i]);
                    if (i != 3)
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
                var msgBox = MessageBox.Show("AddedL Item stock has been increased.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                deleteIcon_Click(sender, e);
            }
            else
            {

            }

            enterCurrentID();
            datePicker.Value = DateTime.Now;
            prodIDText.Text = "";
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {

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
        private void enterCurrentID()
        {
            string[] orders = System.IO.File.ReadAllLines("orderRecords.txt");
            idText.Text = "OD" + orders.Length.ToString();
        }

        private void addSales_Load(object sender, EventArgs e)
        {
            enterCurrentID();
        }
    }
}
