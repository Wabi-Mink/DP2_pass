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

namespace PHP_Sales_Database
{
    public partial class viewSales : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public viewSales()
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

        private void mainBack_label_Click(object sender, EventArgs e)
        {
            File.WriteAllText("salesRecords.txt", "sales_ID,date,prod_ID");
            StreamWriter file = new StreamWriter("salesRecords.txt", true);
            file.WriteLine();
            for (int i = 0; i < viewSalesSales_grid.Rows.Count; i++)
            {
                for (int j = 0; j < viewSalesSales_grid.Rows[i].Cells.Count; j++)
                {
                    file.Write(viewSalesSales_grid.Rows[i].Cells[j].Value.ToString());
                    if (j != 2) { file.Write(",");  };
                }
                file.WriteLine();
            }
            file.Flush();
            file.Close();

            var main = new main();
            main.Location = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            this.Close();
            main.Show();
        }

        private void viewSalesAdd_button_Click(object sender, EventArgs e)
        {
            var addSales = new addSales();
            addSales.Location = this.Location;
            addSales.StartPosition = FormStartPosition.CenterParent;

            //create and use a new viewSales instance to get updated info in data grid 
            addSales.FormClosing += delegate
            {
                var newInstance = new viewSales();
                newInstance.Location = this.Location;
                newInstance.StartPosition = FormStartPosition.Manual;
                newInstance.Show();
                this.Close();
            };

            addSales.ShowDialog();    
        }
        private void viewSalesTitleBar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void viewSales_Load(object sender, EventArgs e)
        {
            //salesRecords.txt is loaded by StreamReader
            //and all entries are placed into a table to be viewed/edited
            StreamReader records = new StreamReader("salesRecords.txt");
            records.ReadLine();
            while (!records.EndOfStream)
            {
                string[] entry = records.ReadLine().Split(',');
                viewSalesSales_grid.Rows.Add(entry);
            }
            records.Close();
        }

        private void viewSalesEdit_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            viewSalesSales_grid.ReadOnly = !viewSalesSales_grid.ReadOnly;
            viewSalesSales_grid.AllowUserToDeleteRows = !viewSalesSales_grid.AllowUserToDeleteRows;
        }
    }
}
