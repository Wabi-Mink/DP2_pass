﻿using System;
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
    public partial class Inventory : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Inventory()
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

        private void viewSalesSales_label_Click(object sender, EventArgs e)
        {
            var viewSales = new viewSales();
            viewSales.Location = this.Location;
            viewSales.StartPosition = FormStartPosition.Manual;
            this.Close();
            viewSales.Show();
        }

        private void mainReports_label_Click(object sender, EventArgs e)
        {
            var Reports = new Reports();
            Reports.Location = this.Location;
            Reports.StartPosition = FormStartPosition.Manual;
            this.Close();
            Reports.Show();
        }
    }
}