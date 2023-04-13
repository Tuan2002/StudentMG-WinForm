using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class EditMajor : Form
    {
        // Khai báo biến để truy cập đến form MajorMG
        // Khai báo biến lưu trữ chỉ số hàng và mã ngành học hiện tại
        public MajorMG parentInstance { get; set; }
        private int rowIndex;
        private string currentMajorID;
        public EditMajor()
        {
            InitializeComponent();
        }
        // Constructor có tham số, khởi tạo form với các giá trị truyền vào
        public EditMajor(int rowIndex, string majorID, string majorName)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.currentMajorID = majorID;
            MajorIDBox.Text = majorID;
            MajorNameBox.Text = majorName;
        }

        // Hàm xóa message validation của form
        public void clearValidate()
        {
            MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            MajorNameEmpty.Text = string.Empty;
            MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            MajorIDEmpty.Text = string.Empty;
            formError.Text = string.Empty;
        }
        // Hàm xóa dữ liệu của form
        public void clearForm()
        {
            MajorIDBox.Text = string.Empty;
            MajorNameBox.Text = string.Empty;
            clearValidate();
        }

        // Sự kiện khi form được load, xóa các message validation
        private void EditMajor_Load(object sender, EventArgs e)
        {
            clearValidate();
        }

        // Sự kiện khi click vào nút hủy, đóng form
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //  Sự kiện khi bấm nút chỉnh sửa
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Tạo request chứa thông tin ngành học cần sửa
            Request editMajorReq = new Request();
            editMajorReq.AddData("CurrentMajorID", currentMajorID);
            editMajorReq.AddData("NewMajorID", MajorIDBox.Text.Trim().ToUpper());
            editMajorReq.AddData("MajorName", MajorNameBox.Text.Trim());

            // Khởi tạo middleware để xử lý việc sửa ngành học
            MiddleWare handleEditMajor = new MiddleWare();

            // Gọi hàm validateEditMajor() trong middleware và trả về response
            Response res = handleEditMajor.validateEditMajor(editMajorReq);

            // Kiểm tra mã code của response để xử lý kết quả
            switch (res.code)
            {
                case "update_successfully":
                    // Nếu sửa thành công, gọi phương thức UpdateMajorData để cập nhật lại dữ liệu ngành học
                    parentInstance.UpdateMajorData(rowIndex, MajorIDBox.Text.Trim().ToUpper(), MajorNameBox.Text.Trim());
                    // Đóng form sửa ngành học
                    this.Close();
                    break;
                case "majorid_null":
                    // Nếu mã ngành học không được nhập, hiển thị thông báo lỗi và bôi đỏ textbox nhập mã ngành học
                    MajorIDBox.BorderColor = System.Drawing.Color.Red;
                    MajorIDEmpty.Text = "Mã ngành không được để trống";
                    break;
                case "majorname_null":
                    // Nếu tên ngành học không được nhập, hiển thị thông báo lỗi và bôi đỏ textbox nhập tên ngành học
                    MajorNameBox.BorderColor = System.Drawing.Color.Red;
                    MajorNameEmpty.Text = "Tên ngành không được để trống";
                    break;
                case "major_already_exist":
                    // Nếu mã ngành học đã tồn tại trong hệ thống, hiển thị thông báo lỗi
                    formError.Text = "Mã ngành học đã tồn tại trên hệ thống";
                    break;
                default:
                    // Nếu có lỗi xảy ra, hiển thị thông báo lỗi và mã lỗi
                    formError.Text = "Có lỗi xảy ra! Mã lỗi: " + res.code;
                    break;
            }
        }
    }
}
