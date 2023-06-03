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
        // Xóa thông báo lỗi trước khi đăng nhập
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

        // Xử lý đăng nhập khi click nút đăng nhập
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
            // Hiện progress bar khi đang đăng nhập
            waitProgess.Visible = true;
            loginBtn.Text = string.Empty;

            // Thực hiện đăng nhập
            Response res = await Task.Run(() => loginHandle());

            // Ẩn progress bar sau khi đăng nhập xong
            waitProgess.Visible = false;
            loginBtn.Text = "Đăng nhập";

            // Kiểm tra kết quả đăng nhập
            if (res.code == "success" && !isLogin)
            {
                string userFullName = res.data.Rows[0]["userFullName"].ToString();
                string userAvatar = res.data.Rows[0]["userAvatar"].ToString();
                string permissionType = res.data.Rows[0]["permissionType"].ToString();
                isLogin = true;
                // Chuyển đến form dashboard
                byte[] imageBytes = Convert.FromBase64String(userAvatar);
                MemoryStream memoryStream = new MemoryStream(imageBytes);
                Image avatar = Image.FromStream(memoryStream);
                this.Hide();
                Dashboard_Admin adminDashboard = new Dashboard_Admin(userFullName, permissionType, avatar);
                adminDashboard.LoginFormInstance = this;
                adminDashboard.Show();
            }
            else if (res.code != "success")
            {
                // Hiển thị thông báo lỗi
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
            // Xóa thông báo lỗi
            clearValidate();
            // Đặt focus vào textbox tên đăng nhập
            this.ActiveControl = txtUserName;
        }
    }
}
