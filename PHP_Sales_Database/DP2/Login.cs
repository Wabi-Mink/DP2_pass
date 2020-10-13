using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PHP_Sales_Database
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login(object sender, EventArgs e)
        {
            int i = 0;
            string line;
            bool match = false;

            //initialises the new registaation data into one string array
            string login_attempt = ID_No.Text + "," + Password.Text;

            //Open the registeredUsers.txt file
            StreamReader file = new StreamReader("registeredUsers.txt", true);

            while ((line = file.ReadLine()) != null)
            {
                if(line == login_attempt)
                {
                    match = true;
                    break;
                }
                i++;
            }


            if (match)
            {
                file.Close();
                this.Hide();
                main Main = new main();
                Main.Show();
                //reset textBox and date picker
                ID_No.Text = "";
                Password.Text = "";
            }
            else
            {
                var msgBox = MessageBox.Show("Password or User ID is wrong!", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                Password.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signUp(object sender, EventArgs e)
        {
            SignUp signUp  = new SignUp();
            signUp.Show();
        }
    }
}
