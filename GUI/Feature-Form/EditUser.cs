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
using System.Drawing.Imaging;
using BLL;
using DAL;

namespace GUI
{
    public partial class EditForm : Form
    {
        private string currentUserName;
        MiddleWare handleEditUser = new MiddleWare();
        string imageData = string.Empty;
        int permissionId = 0;
        int rowindex;

        public delegate void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail);
        public event UpdateUserData UpdateUserDataEvent;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(int rowindex, string userName)
        {
            InitializeComponent();
            this.currentUserName = userName;
            this.rowindex = rowindex;
        }
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
            userNameBox.Text = string.Empty;
            userFullNameBox.Text = string.Empty;
            userEmailBox.Text = string.Empty;
            userPassword.Text = string.Empty;
            userPasswordConfirm.Text = string.Empty;
            permissionSelect.SelectedIndex = 0;
        }
        private void loadPermissionOptions()
        {
            DatabaseAccess access = new DatabaseAccess();
            Response res = access.getPermissionList();
            foreach (DataRow row in res.data.Rows)
            {
                permissionSelect.Items.Add(row["permissionType"].ToString());
            }
        }
        private byte[] imagetobytearray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image stringToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(imageBytes);
            Image avatar = Image.FromStream(memoryStream);
            return avatar;
        } 
        public void getUserData()
        {
            MiddleWare handleGetData = new MiddleWare();
            Request req = new Request();
            req.AddData("userName", this.currentUserName);
            Response res = handleGetData.handleGetUserData(req);
            if (res.code == "success")
            {
                userNameBox.Text = res.data.Rows[0]["userName"].ToString();
                userFullNameBox.Text = res.data.Rows[0]["userFullName"].ToString();
                userEmailBox.Text = res.data.Rows[0]["userEmail"].ToString();
                userPassword.Text = res.data.Rows[0]["userPassword"].ToString();
                permissionId = (int)res.data.Rows[0]["permissionId"];
                avatarPreview.Image = stringToImage(res.data.Rows[0]["userAvatar"].ToString());
            }
            permissionSelect.SelectedIndex = permissionId;
        }
        private void permissionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionId = permissionSelect.SelectedIndex;
            permissionSelect.BorderColor = System.Drawing.Color.Plum;
            permisstionEmpty.Text = string.Empty;
        }
        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            Request editUser = new Request();
            Response res = new Response();
            editUser.AddData("currentUserName", currentUserName);
            editUser.AddData("newUserName", userNameBox.Text.Trim());
            editUser.AddData("fullName", userFullNameBox.Text.Trim());
            editUser.AddData("email", userEmailBox.Text.Trim());
            editUser.AddData("password", userPassword.Text.Trim());
            editUser.AddData("confirmPassword", userPasswordConfirm.Text.Trim());
            editUser.AddData("permissionType", permissionId.ToString());
            if (imageData == string.Empty && useDefaultImage.Checked == false)
            {
                imageRequied.Text = "Vui lòng chọn ảnh";
                return;

            }
            else if (imageData == string.Empty && useDefaultImage.Checked == true)
            {
                byte[] imageBytes = imagetobytearray(avatarPreview.Image);
                imageData = Convert.ToBase64String(imageBytes);
                editUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            else
            {
                editUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            res = handleEditUser.validateEditUserForm(editUser);

            switch (res.code)
            {
                case "update_successfully":
                    UpdateUserDataEvent(rowindex, userNameBox.Text, userPassword.Text, userEmailBox.Text);
                    this.Close();
                    break;
                case "user_not_exist":
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
                    userPassword.BorderColor = Color.Red;
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

        private void EditForm_Load(object sender, EventArgs e)
        {
            loadPermissionOptions();
            clearValidateForm();
            getUserData();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
