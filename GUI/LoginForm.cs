using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;
namespace GUI
{
    public partial class LoginForm : Form
    {
        public bool isLogin = false;
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

        public Response loginHandle()
        {
            Request loginReq = new Request();
            MiddleWare loginProcess = new MiddleWare();
            loginReq.AddData("userName", txtUserName.Text);
            loginReq.AddData("password", txtPassword.Text);
            Response res = loginProcess.validateForm(loginReq);
            return res;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            waitProgess.Visible = true;
            loginBtn.Text = string.Empty;

            Response res = await Task.Run(() => loginHandle());

            waitProgess.Visible = false;
            loginBtn.Text = "Đăng nhập";

            if (res.code == "success" && !isLogin)
            {
                isLogin = true;
                byte[] imageBytes = Convert.FromBase64String(res.userImage);
                MemoryStream memoryStream = new MemoryStream(imageBytes);
                Image avatar = Image.FromStream(memoryStream);
                this.Hide();
                Dashboard_Admin adminDashboard = new Dashboard_Admin(res.userFullName, res.permissionType, avatar);
                adminDashboard.LoginFormInstance = this;
                adminDashboard.Show();
            }
            else if (res.code != "success")
            {
                switch (res.code)
                {
                    case "username_null":
                        useNameError.Text = "Tên người dùng không hợp lệ";
                        txtUserName.BorderColor = Color.Red;
                        break;
                    case "password_null":
                        passwordError.Text = "Mật khẩu không hợp lệ";
                        txtPassword.BorderColor = Color.Red;
                        break;
                    case "user_not_exsist":
                        loginError.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                        break;
                    default:
                        loginError.Text = "Có lỗi xảy ra! Mã lỗi: " + res.code + "";
                        break;
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
