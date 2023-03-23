using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL; //
using DTO;
using BLL;
using COM;

namespace GUI
{
    public partial class LoginForm : Form
    {
        MiddleWare loginProcess = new MiddleWare();
        UserAccount user = new UserAccount();
        Request loginReq = new Request();
        public void clearValidate()
        {
            useNameError.Text = string.Empty;
            passwordError.Text = string.Empty;
            loginError.Text = string.Empty;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginReq.ClearData();
            loginReq.AddData("userName", txtUserName.Text);
            loginReq.AddData("password", txtPassword.Text);
            Response res = loginProcess.validateForm(loginReq);

            if (res.code == "success")
            {
                byte[] imageBytes = Convert.FromBase64String(res.userImage);
                MemoryStream memoryStream= new MemoryStream(imageBytes);
                Image avatar = Image.FromStream(memoryStream);
                // Open dashboard form
                this.Hide();
                Dashboard_Admin dashboard = new Dashboard_Admin(res.userFullName, res.permissionType, avatar);
                dashboard.Show();

            }    
            else
            {
                switch (res.code)
                {  
                    case "username_null":
                        useNameError.Text = "Tên người dùng không hợp lệ";
                        txtUserName.BorderColor = Color.Red;
                        return;
                    case "password_null":
                        passwordError.Text = "Mật khẩu không hợp lệ";
                        txtPassword.BorderColor = Color.Red;
                        return;
                    case "user_not_exsist":
                        loginError.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                        return;
                    default:
                        loginError.Text = "Có lỗi xảy ra! Mã lỗi: " + res.code + "";
                        return;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            clearValidate();
            this.ActiveControl = txtUserName;

        }


    }
}
