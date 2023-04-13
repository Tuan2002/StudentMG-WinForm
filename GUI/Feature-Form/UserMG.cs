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

namespace GUI
{
    public partial class UserMG : Form
    {
        // Thuộc tính
        private int rowIndex;

        // Constructor
        public UserMG()
        {
            InitializeComponent();
        }

        // Phương thức tải dữ liệu từ server
        public async void loadData(Func<Response> res)
        {
            // Ẩn nút search và hiển thị progress bar nếu searchBox không trống
            if (searchBox.Text != string.Empty)
            {
                waitProgess.Visible = true;
                searchBtn.Visible = false;
            }

            // Hiển thị progress bar khi đang tải dữ liệu
            dataLoading.Visible = true;

            // Gọi phương thức res để tải dữ liệu
            var data = await Task.Run(() => res());

            // Ẩn progress bar sau khi tải dữ liệu xong
            waitProgess.Visible = false;
            dataLoading.Visible = false;
            searchBtn.Visible = true;

            // Nếu tải dữ liệu thành công, hiển thị danh sách người dùng lên DataGridView
            if (data.code == "success")
            {
                userList.Rows.Clear();
                foreach (DataRow row in data.data.Rows)
                {
                    userList.Rows.Add(row["userName"].ToString(), row["userPassword"].ToString(), row["userEmail"].ToString());
                }
            }
        }

        // Phương thức lấy dữ liệu danh sách người dùng từ server
        public Response getData()
        {
            UserAccess access = new UserAccess();
            Response res = access.getListUser();
            return res;
        }

        // Phương thức tìm kiếm người dùng dựa trên từ khóa
        public Response getSearchData(string keyword)
        {
            UserAccess access = new UserAccess();
            Response res = access.getSearchUserData(keyword);
            return res;
        }

        // Sự kiện Load của Form
        private void UserMG_Load(object sender, EventArgs e)
        {
            loadData(() => getData());
        }

        // Sự kiện CellFormatting của DataGridView
        private void userList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nếu là ô trong cột "Actions", đặt lại tên và kiểu chữ của nút và đặt màu sắc và căn giữa cho nút
            if (userList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = userList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Value = "Chỉnh sửa";
                buttonCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonCell.Style.BackColor = Color.LightBlue;
                buttonCell.Style.ForeColor = Color.LightGreen;
                buttonCell.Style.Font = new Font("Roboto", 10, FontStyle.Regular);
            }
        }
        // Thêm người dùng mới
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.UpdateUserListEvent += new AddUser.UpdateUserListView(UpdateUserList);
            addUserForm.ShowDialog();
        }

        // Sự kiện UpdateUserListEvent được gọi khi có người dùng mới được thêm vào
        private void UpdateUserList(string userName, string userPassword, string userEmail)
        {
            userList.Rows.Add(userName, userPassword, userEmail);
        }

        // Phương thức cập nhật dữ liệu của một người dùng
        private void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail)
        {
            userList.Rows[rowIndex].Cells["userName"].Value = userName;
            userList.Rows[rowIndex].Cells["passWord"].Value = userPassword;
            userList.Rows[rowIndex].Cells["userEmail"].Value = userEmail;
        }

        // Sự kiện CellClick của DataGridView
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            // Nếu click vào nút "Chỉnh sửa" trong cột "Actions", hiển thị Form để chỉnh sửa thông tin người dùng
            if (userList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Lấy dữ liệu của hàng được click
                DataGridViewRow row = userList.Rows[e.RowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();

                // Hiển thị Form để chỉnh sửa thông tin người dùng
                EditForm editForm = new EditForm(rowIndex, cellValue);
                editForm.UpdateUserDataEvent += new EditForm.UpdateUserData(UpdateUserData);
                editForm.ShowDialog();
            }
        }

        // Sự kiện Click của nút "Xoá người dùng"
        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
                return;
            else
            {
                // Lấy dữ liệu của hàng được chọn
                DataGridViewRow row = userList.Rows[rowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                string message = "Bạn có chắc chắn muốn xoá người dùng '" + cellValue + "' không? Mọi thay đổi không thể hoàn tác";

                // Hiển thị hộp thoại xác nhận trước khi xoá người dùng
                UserAccess deleteAccess = new UserAccess();
                Response res = new Response();
                Request deleteUserRq = new Request();
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    // Gửi yêu cầu xoá người dùng đến server
                    deleteUserRq.AddData("userName", cellValue);
                    res = deleteAccess.DeleteUser(deleteUserRq);
                    if (res.code == "delele_successfully")
                    {
                        // Nếu xoá thành công, xoá dòng đó khỏi DataGridView và reset rowIndex
                        userList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        userList.Refresh();
                    }
                }
            }
        }

        // Sự kiện Click của nút "Refresh"
        private void refeshBtn_Click(object sender, EventArgs e)
        {
            // Tải lại dữ liệu từ server
            loadData(() => getData());
        }

        // Sự kiện TextChanged của ô tìm kiếm
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Chờ một chút trước khi thực hiện tìm kiếm để tránh quá tải server
            SearchInputEvent.Stop();
            SearchInputEvent.Start();
        }

        // Sự kiện kết thúc của SearchInputEvent
        private void SearchInputEventEnd(object sender, EventArgs e)
        {
            SearchInputEvent.Stop();
            if (searchBox.Text == string.Empty)
                loadData(() => getData());
            else
                loadData(() => getSearchData(searchBox.Text));
        }
    }
}
