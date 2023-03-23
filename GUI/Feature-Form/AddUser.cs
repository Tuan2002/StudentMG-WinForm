using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BLL;
using COM;
using System.Drawing.Imaging;
using System.IO;

namespace GUI
{
    public partial class AddUser : Form
    {
        MiddleWare handleAddUser = new MiddleWare();
        string imageData = string.Empty;
        int permissionId = 0;
        public delegate void UpdateUserListView(string userName, string userPassword, string userEmail);
        public event UpdateUserListView UpdateUserListEvent;


        public void clearValidateForm()
        {
            userNameBox.BorderColor = System.Drawing.Color.Plum;
            userFullNameBox.BorderColor = System.Drawing.Color.Plum;
            userEmailBox.BorderColor = System.Drawing.Color.Plum;
            userPassword.BorderColor = System.Drawing.Color.Plum;
            userPasswordConfirm.BorderColor = System.Drawing.Color.Plum;
            permissionSelect.BorderColor = System.Drawing.Color.Plum;
            userNameEmpty.Text = string.Empty;
            fullNameEmpty.Text = string.Empty;
            emailEmpty.Text = string.Empty;
            passwordEmpty.Text = string.Empty;
            passwordNotSame.Text = string.Empty;
            permisstionEmpty.Text = string.Empty;
            imageRequied.Text = string.Empty;
            formError.Text = string.Empty;

        }
        public void clearForm()
        {
            this.clearValidateForm();
            userNameBox.Text= string.Empty;
            userFullNameBox.Text= string.Empty;
            userEmailBox.Text= string.Empty;
            userPassword.Text= string.Empty;
            userPasswordConfirm.Text= string.Empty;
            permissionSelect.SelectedIndex = 0;
        }
     
        public AddUser()
        {
            InitializeComponent();
            clearValidateForm();
            useDefaultImage.Checked = true;
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
            permissionSelect.BorderColor = System.Drawing.Color.Plum;
            permisstionEmpty.Text = string.Empty;

        }
        private byte[] imagetobytearray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            Request addUser = new Request();
            Response res = new Response();
            addUser.AddData("userName", userNameBox.Text);
            addUser.AddData("fullName", userFullNameBox.Text);
            addUser.AddData("email", userEmailBox.Text);
            addUser.AddData("password", userPassword.Text);
            addUser.AddData("confirmPassword", userPasswordConfirm.Text);
            addUser.AddData("permissionType", permissionId.ToString());
            if (imageData == string.Empty && useDefaultImage.Checked == false) {
                imageRequied.Text = "Vui lòng chọn ảnh";
                return;
             
            }
            else if (imageData == string.Empty && useDefaultImage.Checked == true)
            {
                byte[] imageBytes = imagetobytearray(avatarPreview.Image);
                imageData = Convert.ToBase64String(imageBytes);
                addUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            else
            {
                addUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            res = handleAddUser.validateAddUserForm(addUser);
            if (res.code == "success")
            {
            }
            switch (res.code)
            {
                case "success": 
                    UpdateUserListEvent(userNameBox.Text, userPassword.Text, userEmailBox.Text);
                    clearForm();
                    break;
                case "user_exist":
                    clearValidateForm();
                    formError.Text = "Tên người dùng đã tồn tại trong hệ thống";
                    break;
                case "userName_null":
                    userNameBox.BorderColor = Color.Red;
                    userNameEmpty.Text = "Têm người dùng không được để trống";
                    break;
                case "fullName_null":
                    userFullNameBox.BorderColor = Color.Red;
                    fullNameEmpty.Text = "Tên không được để trống";
                    break;
                case "email_null":
                    userEmailBox.BorderColor = Color.Red;
                    emailEmpty.Text = "Email không được để trống";
                    break;
                case "password_null":
                    userPassword.BorderColor= Color.Red;
                    passwordEmpty.Text = "Mật khẩu không được để trống";
                    break;
                case "confirmPassword_notMatch":
                    userPasswordConfirm.BorderColor = Color.Red;
                    passwordNotSame.Text = "Mật khẩu không khớp";
                    break;
                case "permissionType_null":
                    permissionSelect.BorderColor = Color.Red;
                    permisstionEmpty.Text = "Vui lòng chọn quyền hạn";
                    break;
            }


        }

   
    }
}
