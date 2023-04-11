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
using BLL;
using System.Drawing.Imaging;
using System.IO;

namespace GUI
{
    public partial class AddUser : Form
    {
        // Biến lưu trữ ảnh được chọn để đăng ký tài khoản
        private string imageData = string.Empty;
        // Biến lưu trữ id của quyền được chọn khi đăng ký tài khoản
        private int permissionId = 0;
        // Biến lưu trữ ảnh mặc định
        private Image defautImage;

        // Định nghĩa event để cập nhật danh sách người dùng
        public delegate void UpdateUserListView(string userName, string userPassword, string userEmail);
        public event UpdateUserListView UpdateUserListEvent;

        // Phương thức dùng để xóa các thông báo lỗi trên form đăng ký
        public void clearValidateForm()
        {
            // Thiết lập lại màu của các border color trên các textbox
            userNameBox.BorderColor = System.Drawing.Color.Plum;
            userFullNameBox.BorderColor = System.Drawing.Color.Plum;
            userEmailBox.BorderColor = System.Drawing.Color.Plum;
            userPassword.BorderColor = System.Drawing.Color.Plum;
            userPasswordConfirm.BorderColor = System.Drawing.Color.Plum;
            permissionSelect.BorderColor = System.Drawing.Color.Plum;
            // Xóa các thông báo lỗi trên các textbox
            userNameEmpty.Text = string.Empty;
            fullNameEmpty.Text = string.Empty;
            emailEmpty.Text = string.Empty;
            passwordEmpty.Text = string.Empty;
            passwordNotSame.Text = string.Empty;
            permisstionEmpty.Text = string.Empty;
            imageRequied.Text = string.Empty;
            // Xóa thông báo trên form
            formMessage.Text = string.Empty;
            formMessage.ForeColor = System.Drawing.Color.Red;
        }

        // Phương thức dùng để xóa dữ liệu trên form đăng ký
        public void clearForm()
        {
            // Gọi phương thức xóa thông báo lỗi trên form đăng ký
            this.clearValidateForm();
            // Xóa dữ liệu trên các textbox
            userNameBox.Text = string.Empty;
            userFullNameBox.Text = string.Empty;
            userEmailBox.Text = string.Empty;
            userPassword.Text = string.Empty;
            userPasswordConfirm.Text = string.Empty;
            // Thiết lập giá trị mặc định cho combobox quyền
            permissionSelect.SelectedIndex = 0;
            // Thiết lập ảnh mặc định
            avatarPreview.Image = defautImage;
        }

        public AddUser()
        {
            InitializeComponent();
            // Gọi phương thức xóa thông báo lỗi trên form đăng ký
            clearValidateForm();
            // Thiết lập checkbox sử dụng ảnh mặc định
            useDefaultImage.Checked = true;
        }
        // Tải danh sách quyền hạn và hiển thị lên combobox
        private void loadPermissionOptions()
        {
            UserAccess access = new UserAccess();
            Response res = access.getPermissionList(); // Lấy danh sách quyền hạn từ cơ sở dữ liệu
            foreach (DataRow row in res.data.Rows) // Lặp qua các dòng để hiển thị lên combobox
            {
                permissionSelect.Items.Add(row["permissionType"].ToString());
                permissionSelect.SelectedIndex = 0; // Chọn phần tử đầu tiên trong combobox
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút chọn ảnh đại diện
        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Nếu người dùng đã chọn ảnh
            {
                avatarPreview.Image = Image.FromFile(openFileDialog.FileName); // Hiển thị ảnh đại diện
                byte[] imageBytes = System.IO.File.ReadAllBytes(openFileDialog.FileName); // Chuyển ảnh đại diện sang dạng byte[]
                imageData = Convert.ToBase64String(imageBytes); // Chuyển dạng byte[] sang dạng string để lưu trữ ở cơ sở dữ liệu
                //Console.WriteLine(imageData);
            }
        }

        // Xử lý sự kiện khi người dùng nhấn nút Hủy bỏ
        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng cửa sổ
        }

        // Xử lý sự kiện khi cửa sổ AddUser được tải lên
        private void AddUser_Load(object sender, EventArgs e)
        {
            loadPermissionOptions(); // Tải danh sách quyền hạn và hiển thị lên combobox
            defautImage = avatarPreview.Image; // Lưu trữ ảnh mặc định hiển thị trước khi người dùng chọn ảnh đại diện
        }

        // Xử lý sự kiện khi người dùng thay đổi quyền hạn được chọn
        private void permissionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionId = permissionSelect.SelectedIndex; // Lưu trữ quyền hạn được chọn
            permissionSelect.BorderColor = System.Drawing.Color.Plum; // Đặt màu viền cho combobox
            permisstionEmpty.Text = string.Empty; // Xóa thông báo lỗi nếu có
        }

        // Hàm chuyển đổi ảnh từ dạng Image sang dạng byte[]
        private byte[] imagetobytearray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Lưu ảnh vào MemoryStream
                return ms.ToArray(); // Trả về dạng byte[] của ảnh
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng MiddleWare để xử lý việc thêm người dùng
            MiddleWare handleAddUser = new MiddleWare();

            // Tạo một đối tượng Request để lưu các thông tin người dùng được nhập từ form
            Request addUser = new Request();

            // Tạo một đối tượng Response để lưu kết quả trả về từ việc xử lý việc thêm người dùng
            Response res = new Response();

            // Thêm các thông tin người dùng vào đối tượng Request
            addUser.AddData("userName", userNameBox.Text.Trim());
            addUser.AddData("fullName", userFullNameBox.Text.Trim());
            addUser.AddData("email", userEmailBox.Text.Trim());
            addUser.AddData("password", userPassword.Text.Trim());
            addUser.AddData("confirmPassword", userPasswordConfirm.Text.Trim());
            addUser.AddData("permissionType", permissionId.ToString());

            // Kiểm tra nếu chưa chọn ảnh đại diện và không sử dụng ảnh mặc định thì hiển thị thông báo lỗi
            if (imageData == string.Empty && useDefaultImage.Checked == false)
            {
                imageRequied.Text = "Vui lòng chọn ảnh";
                return;
            }
            // Nếu không chọn ảnh đại diện và sử dụng ảnh mặc định thì chuyển ảnh mặc định thành dạng byte array và thêm vào đối tượng Request
            else if (imageData == string.Empty && useDefaultImage.Checked == true)
            {
                byte[] imageBytes = imagetobytearray(avatarPreview.Image);
                imageData = Convert.ToBase64String(imageBytes);
                addUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }
            // Nếu đã chọn ảnh đại diện thì thêm ảnh vào đối tượng Request
            else
            {
                addUser.AddData("avatar", imageData);
                imageData = string.Empty;
            }

            // Gọi hàm validateAddUserForm của đối tượng MiddleWare để kiểm tra tính hợp lệ của thông tin người dùng nhập từ form
            res = handleAddUser.validateAddUserForm(addUser);

            // Xử lý kết quả trả về từ hàm validateAddUserForm

            switch (res.code)
            {
                case "success": 
                    UpdateUserListEvent(userNameBox.Text, userPassword.Text, userEmailBox.Text);
                    clearForm();
                    formMessage.Text = "Thêm người dùng thành công";
                    formMessage.ForeColor = Color.ForestGreen;
                    break;
                case "user_exist":
                    clearValidateForm();
                    formMessage.Text = "Tên người dùng đã tồn tại trong hệ thống";
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
