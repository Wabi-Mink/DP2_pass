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

        private void doneIcon_Click(object sender, EventArgs e)
        {
            //initialises the new sales data into one string array
            string[] sale_record = { idText.Text,
                                    datePicker.Text,
                                    prodIDText.Text };

            //outputs new sales record to the salesRecords.txt file
            StreamWriter file = new StreamWriter("salesRecords.txt", true);
            for (int i = 0; i < sale_record.Length; i++)
            {
                file.Write(sale_record[i]);
                if (i != 2)
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
            var msgBox = MessageBox.Show("Added", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            deleteIcon_Click(sender, e);
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            idText.Text = "";
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
    }
}
