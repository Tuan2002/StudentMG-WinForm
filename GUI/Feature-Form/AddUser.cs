using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using COM;

namespace GUI
{
    public partial class AddUser : Form
    {

        string imageData = string.Empty;
        int permissionId = 0;
        public AddUser()
        {
            InitializeComponent();
        }
        private void loadPermissionOptions() {
            DatabaseAccess access= new DatabaseAccess();
            Response res = access.getPermissionList();
            foreach (DataRow row in res.data.Rows)
            {
                permissionSelect.Items.Add(row["permissionType"].ToString());
                permissionSelect.SelectedIndex = 0;
            }
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarPreview.Image = Image.FromFile(openFileDialog.FileName);
                byte[] imageBytes = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                imageData = Convert.ToBase64String(imageBytes);
                Console.WriteLine(imageData);
            }
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            loadPermissionOptions();

        }

        private void permissionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionId = permissionSelect.SelectedIndex;

        }
    }
}
