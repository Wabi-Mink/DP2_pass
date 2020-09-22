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
        //bunch of random imports for custom title bar
        //cre: https://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public main()
        {
            InitializeComponent();
        }

        private void mainTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void mainTitleBar_label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainTitleBar_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainTitleBar_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //effectively switching between forms
        //cre: https://stackoverflow.com/questions/5848154/winforms-switching-between-forms
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var viewSales = new viewSales();
            viewSales.Location = this.Location;
            viewSales.StartPosition = FormStartPosition.Manual;
            viewSales.FormClosing += delegate { this.Show(); };
            viewSales.Show();
            this.Hide();
        }
    }
}
