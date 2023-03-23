using BLL;
using COM;
using DAL;
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
using static DevExpress.Data.Helpers.ExpressiveSortInfo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class EditForm : Form
    {
        private string currentUserName; 
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(string userName)
        {
            InitializeComponent();
            this.currentUserName = userName;
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
                permissionSelect.SelectedIndex = (int)res.data.Rows[0]["permissionId"];
                avatarPreview.Image = stringToImage(res.data.Rows[0]["userAvatar"].ToString());
            }

        }
        private void addUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            loadPermissionOptions();
            clearValidateForm();
            getUserData();
        }
    }
}
