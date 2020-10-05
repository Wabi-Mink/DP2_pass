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

                //Calculating Reports

                int PD1count = 0;
                int PD2count = 0;
                int PD3count = 0;
                int PD4count = 0;
                int PD5count = 0;
                int PD6count = 0;
                int PD7count = 0;
                int PD8count = 0;

                foreach (DataRow datarow in dt.Rows)
                {

                    if (datarow[2].Equals("PD000001"))
                    {
                        PD1count++;
                    }
                    if (datarow[2].Equals("PD000002"))
                    {
                        PD2count++;
                    }
                    if (datarow[2].Equals("PD000003"))
                    {
                        PD3count++;
                    }
                    if (datarow[2].Equals("PD000004"))
                    {
                        PD4count++;
                    }
                    if (datarow[2].Equals("PD000005"))
                    {
                        PD5count++;
                    }
                    if (datarow[2].Equals("PD000006"))
                    {
                        PD6count++;
                    }
                    if (datarow[2].Equals("PD000007"))
                    {
                        PD7count++;
                    }
                    if (datarow[2].Equals("PD000008"))
                    {
                        PD8count++;
                    }

                   



                }

                //Creating Reports

                //Report 1
                this.chart1.Series["Number of Product Sales"].Points.AddXY(1, PD1count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(2, PD2count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(3, PD3count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(4, PD4count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(5, PD5count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(6, PD6count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(7, PD7count);
                this.chart1.Series["Number of Product Sales"].Points.AddXY(8, PD8count);

                chart1.ChartAreas[0].AxisX.Title = "Product ID's";
                chart1.ChartAreas[0].AxisY.Title = "Numbers Sold";

                //Report 2

                

                this.chart1.ChartAreas[1].AxisX.Title = "Month";
                this.chart1.ChartAreas[1].AxisY.Title = "Sales Number";
                
                
                this.chart1.Series["Sales Per Month"].Points.AddXY("Jan", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Feb", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Mar", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Apr", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("May", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Jun", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Jul", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Aug", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Sep", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Oct", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Nov", 1);
                this.chart1.Series["Sales Per Month"].Points.AddXY("Dec", 1);








                //other

                dt.TableName = "TableName";
                dt.WriteXml("dtSchema.xml");

                //foreach (var item in dataRow.ItemArray)
                //{
                //    Console.WriteLine(item);
                //}













            }


        }
    }
}
