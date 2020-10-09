namespace DP2
{
    partial class addSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.prodIDText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.prodidLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idLable = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteIcon = new FontAwesome.Sharp.IconButton();
            this.closeIcon = new FontAwesome.Sharp.IconButton();
            this.doneIcon = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainLabel);
            this.panel1.Controls.Add(this.mainIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 69);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mainLabel.Location = new System.Drawing.Point(73, 24);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(197, 19);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Add a new Sales Record";
            // 
            // mainIcon
            // 
            this.mainIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.mainIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.mainIcon.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.mainIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.mainIcon.Location = new System.Drawing.Point(34, 19);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(32, 32);
            this.mainIcon.TabIndex = 2;
            this.mainIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datePicker);
            this.panel2.Controls.Add(this.prodIDText);
            this.panel2.Controls.Add(this.idText);
            this.panel2.Controls.Add(this.prodidLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.idLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 347);
            this.panel2.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(53, 131);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(207, 23);
            this.datePicker.TabIndex = 19;
            this.datePicker.Value = new System.DateTime(2020, 9, 24, 0, 0, 0, 0);
            // 
            // prodIDText
            // 
            this.prodIDText.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodIDText.Location = new System.Drawing.Point(53, 211);
            this.prodIDText.Margin = new System.Windows.Forms.Padding(4);
            this.prodIDText.Name = "prodIDText";
            this.prodIDText.Size = new System.Drawing.Size(207, 23);
            this.prodIDText.TabIndex = 18;
            // 
            // idText
            // 
            this.idText.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(53, 55);
            this.idText.Margin = new System.Windows.Forms.Padding(4);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(207, 23);
            this.idText.TabIndex = 17;
            // 
            // prodidLabel
            // 
            this.prodidLabel.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodidLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.prodidLabel.Location = new System.Drawing.Point(3, 157);
            this.prodidLabel.Name = "prodidLabel";
            this.prodidLabel.Size = new System.Drawing.Size(127, 62);
            this.prodidLabel.TabIndex = 6;
            this.prodidLabel.Text = "Product ID";
            this.prodidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateLabel.Location = new System.Drawing.Point(3, 81);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(127, 62);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Sale Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLable
            // 
            this.idLable.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.idLable.Location = new System.Drawing.Point(3, 3);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(127, 62);
            this.idLable.TabIndex = 4;
            this.idLable.Text = "Sale ID";
            this.idLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteIcon);
            this.panel4.Controls.Add(this.closeIcon);
            this.panel4.Controls.Add(this.doneIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 100);
            this.panel4.TabIndex = 3;
            // 
            // deleteIcon
            // 
            this.deleteIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.deleteIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteIcon.FlatAppearance.BorderSize = 0;
            this.deleteIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteIcon.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.deleteIcon.IconSize = 50;
            this.deleteIcon.Location = new System.Drawing.Point(97, 0);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Rotation = 0D;
            this.deleteIcon.Size = new System.Drawing.Size(96, 100);
            this.deleteIcon.TabIndex = 3;
            this.deleteIcon.UseVisualStyleBackColor = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.closeIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeIcon.FlatAppearance.BorderSize = 0;
            this.closeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.closeIcon.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.closeIcon.IconSize = 50;
            this.closeIcon.Location = new System.Drawing.Point(193, 0);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Rotation = 0D;
            this.closeIcon.Size = new System.Drawing.Size(97, 100);
            this.closeIcon.TabIndex = 2;
            this.closeIcon.UseVisualStyleBackColor = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // doneIcon
            // 
            this.doneIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.doneIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.doneIcon.FlatAppearance.BorderSize = 0;
            this.doneIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.doneIcon.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.doneIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.doneIcon.IconSize = 50;
            this.doneIcon.Location = new System.Drawing.Point(0, 0);
            this.doneIcon.Name = "doneIcon";
            this.doneIcon.Rotation = 0D;
            this.doneIcon.Size = new System.Drawing.Size(97, 100);
            this.doneIcon.TabIndex = 0;
            this.doneIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doneIcon.UseVisualStyleBackColor = false;
            this.doneIcon.Click += new System.EventHandler(this.doneIcon_Click);
            // 
            // addSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(330, 456);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addSales";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addSales_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainLabel;
        private FontAwesome.Sharp.IconPictureBox mainIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox prodIDText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label prodidLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton deleteIcon;
        private FontAwesome.Sharp.IconButton doneIcon;
        private FontAwesome.Sharp.IconButton closeIcon;
    }
}