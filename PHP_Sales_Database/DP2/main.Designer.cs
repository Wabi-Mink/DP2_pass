namespace DP2
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.aboutButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ordersButton = new FontAwesome.Sharp.IconButton();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.inventoryButton = new FontAwesome.Sharp.IconButton();
            this.salesButton = new FontAwesome.Sharp.IconButton();
            this.inboxButton = new FontAwesome.Sharp.IconButton();
            this.menuButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainIcon = new FontAwesome.Sharp.IconPictureBox();
            this.childPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mainPanel.Controls.Add(this.settingsButton);
            this.mainPanel.Controls.Add(this.aboutButton);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.menuButton);
            this.mainPanel.Controls.Add(this.userPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 755);
            this.mainPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.settingsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.IconSize = 45;
            this.settingsButton.Location = new System.Drawing.Point(0, 613);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Rotation = 0D;
            this.settingsButton.Size = new System.Drawing.Size(200, 71);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.aboutButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.aboutButton.IconColor = System.Drawing.Color.Gainsboro;
            this.aboutButton.IconSize = 45;
            this.aboutButton.Location = new System.Drawing.Point(0, 684);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Rotation = 0D;
            this.aboutButton.Size = new System.Drawing.Size(200, 71);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "ABOUT";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.ordersButton);
            this.panel3.Controls.Add(this.reportsButton);
            this.panel3.Controls.Add(this.inventoryButton);
            this.panel3.Controls.Add(this.salesButton);
            this.panel3.Controls.Add(this.inboxButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 239);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 205);
            this.panel3.TabIndex = 2;
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ordersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersButton.FlatAppearance.BorderSize = 0;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ordersButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ordersButton.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.ordersButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ordersButton.IconSize = 25;
            this.ordersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersButton.Location = new System.Drawing.Point(0, 164);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.ordersButton.Rotation = 0D;
            this.ordersButton.Size = new System.Drawing.Size(200, 41);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "Orders";
            this.ordersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.reportsButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.reportsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.reportsButton.IconSize = 25;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 123);
            this.reportsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.reportsButton.Rotation = 0D;
            this.reportsButton.Size = new System.Drawing.Size(200, 41);
            this.reportsButton.TabIndex = 2;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.inventoryButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inventoryButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.inventoryButton.IconColor = System.Drawing.Color.Gainsboro;
            this.inventoryButton.IconSize = 25;
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(0, 82);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.inventoryButton.Rotation = 0D;
            this.inventoryButton.Size = new System.Drawing.Size(200, 41);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.salesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.salesButton.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.salesButton.IconColor = System.Drawing.Color.Gainsboro;
            this.salesButton.IconSize = 25;
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(0, 41);
            this.salesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesButton.Name = "salesButton";
            this.salesButton.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.salesButton.Rotation = 0D;
            this.salesButton.Size = new System.Drawing.Size(200, 41);
            this.salesButton.TabIndex = 1;
            this.salesButton.Text = "Sales";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // inboxButton
            // 
            this.inboxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.inboxButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inboxButton.FlatAppearance.BorderSize = 0;
            this.inboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboxButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.inboxButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.inboxButton.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.inboxButton.IconColor = System.Drawing.Color.Gainsboro;
            this.inboxButton.IconSize = 25;
            this.inboxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboxButton.Location = new System.Drawing.Point(0, 0);
            this.inboxButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.inboxButton.Rotation = 0D;
            this.inboxButton.Size = new System.Drawing.Size(200, 41);
            this.inboxButton.TabIndex = 0;
            this.inboxButton.Text = "Alerts";
            this.inboxButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inboxButton.UseVisualStyleBackColor = false;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.menuButton.Location = new System.Drawing.Point(0, 193);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.menuButton.Size = new System.Drawing.Size(200, 46);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPanel.Controls.Add(this.logo);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 193);
            this.userPanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::DP2.Properties.Resources.PHPlogo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 193);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.panel4.Controls.Add(this.mainLabel);
            this.panel4.Controls.Add(this.mainIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 57);
            this.panel4.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mainLabel.Location = new System.Drawing.Point(59, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(176, 36);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Homepage";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainIcon
            // 
            this.mainIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.mainIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.mainIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.mainIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.mainIcon.IconSize = 53;
            this.mainIcon.Location = new System.Drawing.Point(0, 0);
            this.mainIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(53, 57);
            this.mainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainIcon.TabIndex = 0;
            this.mainIcon.TabStop = false;
            // 
            // childPanel
            // 
            this.childPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(200, 57);
            this.childPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(1082, 698);
            this.childPanel.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 755);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "main";
            this.Text = "PHP_SRePS";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton inventoryButton;
        private FontAwesome.Sharp.IconButton reportsButton;
        private FontAwesome.Sharp.IconButton salesButton;
        private FontAwesome.Sharp.IconButton inboxButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton aboutButton;
        private System.Windows.Forms.Label mainLabel;
        private FontAwesome.Sharp.IconPictureBox mainIcon;
        private System.Windows.Forms.PictureBox logo;
        private FontAwesome.Sharp.IconButton ordersButton;
    }
}

