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
    public partial class AddMajor : Form
    {
        // Khai báo biến để truy cập đến form MajorMG
        public MajorMG parentInstance { get; set; }
        public AddMajor()
        {
            InitializeComponent();
        }
        // Hàm xóa các thông báo lỗi và reset màu sắc cho các textbox
        public void clearValidate()
        {
            MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            MajorNameEmpty.Text = string.Empty;
            MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            MajorIDEmpty.Text = string.Empty;
            formMessage.Text = string.Empty;
            formMessage.ForeColor = System.Drawing.Color.Red;
        }

        // Hàm reset lại các giá trị của form khi người dùng thêm thành công ngành học
        public void clearForm()
        {
            MajorIDBox.Text = string.Empty;
            MajorNameBox.Text = string.Empty;
            clearValidate();
        }

        // Hàm được gọi khi form AddMajor được load lên
        private void AddMajor_Load(object sender, EventArgs e)
        {
            clearValidate();
        }

        // Hàm xử lý sự kiện khi người dùng nhấn nút Cancel để đóng form
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm xử lý sự kiện khi người dùng nhấn nút Add để thêm mới ngành học
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Khai báo các biến và khởi tạo đối tượng MiddleWare để gửi yêu cầu đến server
            Request addMajorReq = new Request();
            Response res = new Response();
            MiddleWare handleAddMajor = new MiddleWare();

            // Thêm các thông tin về ngành học vào yêu cầu
            addMajorReq.AddData("MajorID", MajorIDBox.Text.Trim().ToUpper());
            addMajorReq.AddData("MajorName", MajorNameBox.Text.Trim());

            // Gửi yêu cầu đến server để kiểm tra tính hợp lệ của thông tin ngành học
            res = handleAddMajor.validateAddMajor(addMajorReq);

            // Xử lý kết quả trả về từ server
            switch (res.code)
            {
                case "success":
                    parentInstance.UpdateMajorList(MajorIDBox.Text.Trim().ToUpper(), MajorNameBox.Text.Trim());
                    this.clearForm();
                    formMessage.ForeColor = Color.ForestGreen;
                    formMessage.Text = "Thêm ngành học thành công!";
                    break;
                case "majorid_null":
                    MajorIDBox.BorderColor = System.Drawing.Color.Red;
                    MajorIDEmpty.Text = "Mã ngành học không được để trống";
                    break;
                case "majorname_null":
                    MajorNameBox.BorderColor = System.Drawing.Color.Red;
                    MajorNameEmpty.Text = "Tên ngành học không được để trống";
                    break;
                case "major_exist":
                    formMessage.Text = "Ngành học này đã tồn tại trong hệ thống";
                    break;
                default:
                    formMessage.Text = "Có lõi xảy ra, Mã lỗi: " + res.code;
                    break;
            }
        }
    }
}
