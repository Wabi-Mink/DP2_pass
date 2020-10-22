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
using DP2;

namespace DP2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login(object sender, EventArgs e)
        {
            encryptedLogin();
            return;

            int i = 0;
            string line;
            bool match = false;

            //initialises the new registaation data into one string array
            string login_attempt = ID_No.Text + "," + Password.Text;

            //Open the registeredUsers.txt file
            try
            {
                StreamReader file = new StreamReader("registeredUsers.txt", true);

                while ((line = file.ReadLine()) != null)
                {
                    if (line == login_attempt)
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
                    try
                    {
                        main Main = new main();
                        Main.Closed += (s, args) => this.Close();
                        Main.Show();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Missing FontAwesome.Sharp.dll","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find registeredUsers.txt");
                this.Close();
            }
        }

        private void encryptedLogin()
        {
            if (Encryption.CheckPassword(ID_No.Text, Password.Text, "registeredUsers.dat"))
            {
                this.Hide();
                main Main = new main();
                Main.Closed += (s, args) => this.Close();
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

        private void signUp(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
