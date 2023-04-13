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
using static GUI.EditMajor;

namespace GUI
{
    public partial class MajorMG : Form
    {
        private int rowIndex;
        // Hàm khởi tạo của form MajorMG
        public MajorMG()
        {
            InitializeComponent();

        }

        // Hàm loadData() để load dữ liệu từ cơ sở dữ liệu và hiển thị lên DataGridView
        public async void loadData(Func<Response> getData)
        {
            if (searchBox.Text != string.Empty)
            {
                waitProgess.Visible = true;
                searchBtn.Visible = false;
            }
            dataLoading.Visible = true;

            // Sử dụng Task.Run() để thực hiện lấy dữ liệu từ cơ sở dữ liệu một cách bất đồng bộ
            var res = await Task.Run(() => getData());

            waitProgess.Visible = false;
            dataLoading.Visible = false;
            searchBtn.Visible = true;

            // Nếu dữ liệu được trả về thành công, tiến hành xóa tất cả các dòng trong DataGridView và thêm dữ liệu mới vào
            if (res.code == "success")
            {
                MajorList.Rows.Clear();
                foreach (DataRow row in res.data.Rows)
                {
                    MajorList.Rows.Add(row["MajorID"].ToString(), row["MajorName"].ToString());
                }
            }
        }

        // Hàm getData() để lấy toàn bộ dữ liệu của bảng ngành từ cơ sở dữ liệu
        public Response getData()
        {
            MajorAccess access = new MajorAccess();
            Response res = access.getListMajor();
            return res;
        }

        // Hàm getSearchData() để tìm kiếm dữ liệu của bảng ngành dựa trên từ khóa keyword
        public Response getSearchData(string keyword)
        {
            MajorAccess access = new MajorAccess();
            Response res = access.getSearchMajorData(keyword);
            return res;
        }

        // Hàm MajorMG_Load() được gọi khi Form được load lên, sẽ gọi hàm loadData() để hiển thị dữ liệu lên DataGridView
        private void MajorMG_Load(object sender, EventArgs e)
        {
            loadData(() => getData());
        }

        // Hàm MajorList_CellFormatting() để định dạng các nút "Chỉnh sửa" trong DataGridView
        private void MajorList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (MajorList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = MajorList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Value = "Chỉnh sửa";
                buttonCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonCell.Style.BackColor = Color.LightBlue;
                buttonCell.Style.ForeColor = Color.LightGreen;
                buttonCell.Style.Font = new Font("Roboto", 10, FontStyle.Regular);
            }
        }

        // Hàm UpdateMajorList() để cập nhật thêm một dòng mới vào DataGridView khi người dùng thêm mới một bản ghi
        private void UpdateMajorList(string majorID, string majorName)
        {
            MajorList.Rows.Add(majorID, majorName);
        }

        // Hàm UpdateMajorData() để cập nhật lại dữ liệu
        private void UpdateMajorData(int rowIndex, string majorID, string majorName)
        {
            MajorList.Rows[rowIndex].Cells["MajorID"].Value = majorID;
            MajorList.Rows[rowIndex].Cells["MajorName"].Value = majorName;
        }

        private void addMajorBtn_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới ngành học
            AddMajor addMajorForm = new AddMajor();
            // Gán sự kiện cập nhật danh sách ngành học sau khi thêm mới
            addMajorForm.UpdateNajorListEvent += new AddMajor.UpdateMajorListView(UpdateMajorList);
            addMajorForm.ShowDialog();
        }

        private void MajorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lưu lại chỉ số hàng được chọn
            rowIndex = e.RowIndex;
            // Kiểm tra nếu người dùng click vào cột "Actions"
            if (MajorList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = MajorList.Rows[e.RowIndex];
                string majorID = row.Cells["MajorID"].Value.ToString();
                string majorName = row.Cells["MajorName"].Value.ToString();
                // Mở form chỉnh sửa thông tin ngành học
                EditMajor editForm = new EditMajor(rowIndex, majorID, majorName);
                // Đăng ký sự kiện cập nhật thông tin ngành học sau khi chỉnh sửa
                editForm.UpdateMajorDataEvent += new EditMajor.UpdateMajorData(UpdateMajorData);
                editForm.ShowDialog();
            }
        }
        private void removeMajorBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có hàng nào được chọn
            if (rowIndex < 0)
                return;
            else
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = MajorList.Rows[rowIndex];
                string majorID = row.Cells["MajorID"].Value.ToString();
                // Hiển thị hộp thoại xác nhận xoá ngành học
                string message = "Bạn có chắc chắn muốn xoá ngành '" + majorID + "' không? Thao tác này có thể ảnh hưởng đến lớp học và sinh viên.";
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    // Gọi phương thức xoá ngành học từ lớp truy cập CSDL
                    MajorAccess deleteAccess = new MajorAccess();
                    Response res = new Response();
                    Request deleteUserRq = new Request();
                    deleteUserRq.AddData("MajorID", majorID);
                    res = deleteAccess.DeleteMajor(deleteUserRq);
                    // Kiểm tra kết quả xoá thành công
                    if (res.code == "delele_successfully")
                    {
                        // Xoá hàng khỏi bảng danh sách ngành học và cập nhật lại chỉ số hàng được chọn
                        MajorList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        MajorList.Refresh();
                    }
                }
            }
        }
        private void refeshBtn_Click(object sender, EventArgs e)
        {
            loadData(() => getData()); // load lại dữ liệu khi nhấn nút Refresh
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SearchInputEvent.Stop(); // dừng timer nếu đang chạy
            SearchInputEvent.Start(); // bắt đầu thực hiện timer
        }
        private void SearchInputEventEnd(object sender, EventArgs e)
        {
            SearchInputEvent.Stop(); // dừng timer
            string keyword = searchBox.Text.Trim(); // lấy từ khóa tìm kiếm
            if (keyword == string.Empty)
                loadData(() => getData()); // nếu từ khóa rỗng thì load lại toàn bộ dữ liệu
            else
                loadData(() => getSearchData(searchBox.Text)); // nếu có từ khóa thì thực hiện tìm kiếm và load dữ liệu tìm kiếm
        }
    }
}
