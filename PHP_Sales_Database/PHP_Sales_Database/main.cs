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



namespace PHP_Sales_Database
{
    public partial class main : Form
    {
        //Constants for moving borderless window
        //Cre: https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void mainTitleBar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainClose_panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMinimise_panel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Open a viewSales instance at the same position
        private void mainSales_label_Click(object sender, EventArgs e)
        {
            var viewSales = new viewSales();
            viewSales.Location = this.Location;
            viewSales.StartPosition = FormStartPosition.Manual;
            viewSales.Show();
            this.Hide();
        }
    }
}
