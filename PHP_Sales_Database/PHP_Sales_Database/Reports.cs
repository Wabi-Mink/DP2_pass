using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq.Expressions;

namespace PHP_Sales_Database
{
    public partial class Reports : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Reports()
        {
            InitializeComponent();
        }

        private void mainTitleBar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void viewSalesMinimise_panel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void viewSalesTitleBar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainBack_label_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Location = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            this.Close();
            main.Show();
        }

        private void mainSales_label_Click(object sender, EventArgs e)
        {
            var viewSales = new viewSales();
            viewSales.Location = this.Location;
            viewSales.StartPosition = FormStartPosition.Manual;
            this.Close();
            viewSales.Show();
        }

        private void mainInventory_label_Click(object sender, EventArgs e)
        {
            var Inventory = new Inventory();
            Inventory.Location = this.Location;
            Inventory.StartPosition = FormStartPosition.Manual;
            this.Close();
            Inventory.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines("SalesRecords.txt");

            //Console.WriteLine(data[1]);

            if (lines.Length > 0)
            {
                //first line is header
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //for data

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }

                foreach (DataRow dataRow in dt.Rows)
                {
                    this.chart1.Series["BarChartTrial"].Points.AddXY(dataRow[1], 1);

                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);

                    }
                }
            }
        }
    }
}
