using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class Dashboard_Admin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string userFullName;
        private string permissionType;
        private Image userAvatar;
        private Form currentChildForm;
        private bool isLogout = false;
        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        public Dashboard_Admin(string userFullName, string permissionType, Image userAvatar)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            sidebarMenu.Controls.Add(leftBorderBtn);
            this.userFullName = userFullName;
            this.permissionType = permissionType;
            this.userAvatar = userAvatar;
             
        }
        public LoginForm LoginFormInstance { get; set; }

        private void ActivateButton (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                // Border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.DarkSlateBlue;
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign= ContentAlignment.MiddleLeft;
            }
        }
        private void openChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();   
        }

        private void userMangerBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new UserMG());
        }

        private void classManagerBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        private void maijorManagerBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openChildForm(new MajorMG());
        }

        private void studentListBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = userFullName;
            userPermisstionLabel.Text = permissionType;
            avatarBox.Image = userAvatar;
            if (permissionType == "Teacher")
            {
                userMangerBtn.Visible = false;
                maijorManagerBtn.Visible = false;
            }
        }

        private void Dashboard_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout)
            {
                LoginFormInstance.Refresh();
                LoginFormInstance.Show();
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
