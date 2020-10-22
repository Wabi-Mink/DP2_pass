using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DP2
{
    public partial class main : Form
    {
        private IconButton currentBtn;
        private Form activiteForm = null;
        private void changeMain(IconButton button)
        {
            mainIcon.IconChar = button.IconChar;
            mainLabel.Text = button.Text;
        }
        private void open(Form form)
        {
            if (activiteForm != null)
            {
                activiteForm.Close();
            }

            activiteForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            childPanel.Controls.Add(form);
            childPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void HighlightButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(153, 155, 158);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 32, 39);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public main()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }
        private void salesButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.Gainsboro);
            changeMain(salesButton);
            open(new Sales());
        }
        private void inboxButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.Gainsboro);
            changeMain(inboxButton);
            open(new Inbox());
        }
        private void reportsButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.Gainsboro);
            changeMain(reportsButton);
            open(new Reports());
        }
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.Gainsboro);
            changeMain(inventoryButton);
            open(new Inventory());
        }
        private void ordersButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.Gainsboro);
            changeMain(ordersButton);
            open(new Orders());
        }
        private void logo_Click(object sender, EventArgs e)
        {
            if (activiteForm != null)
            {
                activiteForm.Close();
                mainIcon.IconChar = IconChar.Home;
                mainLabel.Text = "Homepage";
                DisableButton();
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wabi-Mink/DP2_pass/blob/master/README.md");
        }
    }
}
