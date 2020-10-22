using System;
using System.IO;
using System.Windows.Forms;

namespace DP2
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_register(object sender, EventArgs e)
        {
            encryptedRegister();
            return;

            //initialises the new registation data into one string array
            string[] registration_record = {ID_No.Text,
                                            Password.Text};

            //Open the registeredUsers.txt file
            StreamWriter file = new StreamWriter("registeredUsers.txt", true);

            if (Password.Text == RePassword.Text)
            {
                //insert registration into the text file
                for (int i = 0; i < registration_record.Length; i++)
                {
                    file.Write(registration_record[i]);
                    if (i != 1)
                    {
                        file.Write(",");
                    }
                    else
                    {
                        file.WriteLine("");
                    }
                }
                //reset textBox and date picker
                ID_No.Text = "";
                Password.Text = "";
                RePassword.Text = "";

                this.Close();

                //Show a success message box
                var msgBox = MessageBox.Show("You have succesfully Registered!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var msgBox = MessageBox.Show("Passwords do not match!", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            file.Flush();
            file.Close();
        }

        public void encryptedRegister()
        {
            if (Encryption.CheckUserExists(ID_No.Text, "registeredUsers.dat") == false)
            {
                Encryption.SaveNameAndPassword(ID_No.Text, Password.Text, "registeredUsers.dat");

                //reset textBox and date picker
                ID_No.Text = "";
                Password.Text = "";
                RePassword.Text = "";

                this.Close();

                //Show a success message box
                var msgBox = MessageBox.Show("You have succesfully Registered!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
