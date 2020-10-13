namespace PHP_Sales_Database
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ID_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID_No
            // 
            this.ID_No.Location = new System.Drawing.Point(123, 87);
            this.ID_No.Name = "ID_No";
            this.ID_No.Size = new System.Drawing.Size(266, 20);
            this.ID_No.TabIndex = 1;
            this.ID_No.TextChanged += new System.EventHandler(this.txt_ID);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(123, 127);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(266, 20);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.txt_password);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Re-PASSWORD";
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(123, 169);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(266, 20);
            this.RePassword.TabIndex = 5;
            this.RePassword.UseSystemPasswordChar = true;
            this.RePassword.TextChanged += new System.EventHandler(this.txt_rePassword);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(211, 224);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(178, 23);
            this.register.TabIndex = 9;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.btn_register);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 324);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_No);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.Button register;
    }
}