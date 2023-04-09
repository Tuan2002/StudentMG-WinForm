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
        private string imageData = string.Empty;
        private int permissionId = 0;
        private int rowindex;
        // Khai báo event để gọi hàm cập nhật thông tin người dùng
        public delegate void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail);
        public event UpdateUserData UpdateUserDataEvent;
        public EditForm()
        {
            InitializeComponent();
        }
        // Hàm khởi tạo form với thông tin người dùng cần sửa
        public EditForm(int rowindex, string userName)
        {
            InitializeComponent();
            this.currentUserName = userName;
            this.rowindex = rowindex;
        }

        // Hàm xóa thông báo lỗi trong form sửa thông tin người dùng
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

        // Hàm xóa dữ liệu trong form sửa thông tin người dùng
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

        // Hàm tải danh sách quyền hạn từ CSDL và hiển thị lên combobox
        private void loadPermissionOptions()
        {
            UserAccess access = new UserAccess();
            Response res = access.getPermissionList();
            foreach (DataRow row in res.data.Rows)
            {
                permissionSelect.Items.Add(row["permissionType"].ToString());
            }
        }

        // Hàm chuyển đổi ảnh sang mảng byte
        private byte[] imagetobytearray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // Hàm chuyển đổi chuỗi base64 sang ảnh
        private Image stringToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(imageBytes);
            Image avatar = Image.FromStream(memoryStream);
            return avatar;
        }
        public void getUserData()
        {
            // Tạo một đối tượng MiddleWare để gửi yêu cầu lấy thông tin người dùng từ server
            MiddleWare handleGetData = new MiddleWare();
            Request req = new Request();
            req.AddData("userName", this.currentUserName);
            // Nhận phản hồi từ server
            Response res = handleGetData.handleGetUserData(req);
            // Nếu phản hồi trả về mã code "success", hiển thị thông tin người dùng lên giao diện
            if (res.code == "success")
            {
                userNameBox.Text = res.data.Rows[0]["userName"].ToString();
                userFullNameBox.Text = res.data.Rows[0]["userFullName"].ToString();
                userEmailBox.Text = res.data.Rows[0]["userEmail"].ToString();
                userPassword.Text = res.data.Rows[0]["userPassword"].ToString();
                permissionId = (int)res.data.Rows[0]["permissionId"];
                avatarPreview.Image = stringToImage(res.data.Rows[0]["userAvatar"].ToString());
            }
            // Thiết lập giá trị mặc định cho combobox permissionSelect
            permissionSelect.SelectedIndex = permissionId;
        }

        private void permissionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thiết lập giá trị permissionId bằng chỉ số được chọn trong combobox permissionSelect
            permissionId = permissionSelect.SelectedIndex;
            // Đặt màu khung viền cho combobox permissionSelect thành màu hồng nhạt
            permissionSelect.BorderColor = System.Drawing.Color.Plum;
            // Xóa nội dung lỗi hiển thị trên giao diện
            permisstionEmpty.Text = string.Empty;
        }
        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng MiddleWare để thực hiện xử lý sửa thông tin người dùng
            MiddleWare handleEditUser = new MiddleWare();
            // Tạo một đối tượng Request để chứa thông tin người dùng mới
            Request editUser = new Request();
            // Tạo một đối tượng Response để lưu trữ kết quả trả về từ xử lý sửa thông tin người dùng
            Response res = new Response();

            // Thêm các thông tin người dùng mới vào đối tượng editUser
            editUser.AddData("currentUserName", currentUserName);
            editUser.AddData("newUserName", userNameBox.Text.Trim());
            editUser.AddData("fullName", userFullNameBox.Text.Trim());
            editUser.AddData("email", userEmailBox.Text.Trim());
            editUser.AddData("password", userPassword.Text.Trim());
            editUser.AddData("confirmPassword", userPasswordConfirm.Text.Trim());
            editUser.AddData("permissionType", permissionId.ToString());

            // Kiểm tra xem người dùng đã chọn ảnh hay chưa
            if (imageData == string.Empty && useDefaultImage.Checked == false)
            {
                // Nếu chưa chọn ảnh và không sử dụng ảnh mặc định thì hiển thị thông báo yêu cầu chọn ảnh và không thực hiện các thao tác khác
                imageRequied.Text = "Vui lòng chọn ảnh";
                return;
            }
            else if (imageData == string.Empty && useDefaultImage.Checked == true)
            {
                // Nếu chưa chọn ảnh nhưng sử dụng ảnh mặc định thì chuyển đổi ảnh mặc định sang định dạng base64 và thêm vào đối tượng editUser
                byte[] imageBytes = imagetobytearray(avatarPreview.Image);
                imageData = Convert.ToBase64String(imageBytes);
                editUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            else
            {
                // Nếu đã chọn ảnh thì thêm ảnh vào đối tượng editUser
                editUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }

            // Thực hiện kiểm tra tính hợp lệ của thông tin người dùng mới
            res = handleEditUser.validateEditUserForm(editUser);
            // Xử lý các kết quả trả về
            switch (res.code)
            {
                case "update_successfully":
                    UpdateUserDataEvent(rowindex, userNameBox.Text, userPassword.Text, userEmailBox.Text);
                    this.Close();
                    break;
                case "user_already_exist":
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
