using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class ClassMG : Form
    {
        private int rowIndex;
        private DataTable majorList;
        private string currentMajorID;
        public ClassMG()
        {
            InitializeComponent();
            currentMajorID = "All";
        }

        // Load danh sách tất cả ngành và hiển thị lên combobox MajorOptions
        private void loadMajorOptions()
        {
            MajorOptions.Items.Clear();
            MajorOptions.Items.Add("Tất cả các ngành");
            MajorAccess access = new MajorAccess();
            Response res = access.getListMajor();
            majorList = res.data;
            foreach (DataRow row in majorList.Rows)
            {
                MajorOptions.Items.Add(row["MajorName"].ToString());
                MajorOptions.SelectedIndex = 0;
            }
        }

        // Load dữ liệu danh sách lớp học
        public async void loadData(Func<Response> res)
        {
            // Hiển thị loading khi đang load dữ liệu
            if (searchBox.Text != string.Empty)
            {
                waitProgess.Visible = true;
                searchBtn.Visible = false;
            }
            dataLoading.Visible = true;

            // Sử dụng Task.Run để load dữ liệu danh sách lớp học mà không ảnh hưởng đến UI
            var data = await Task.Run(() => res());

            // Tắt loading khi load dữ liệu xong
            waitProgess.Visible = false;
            dataLoading.Visible = false;
            searchBtn.Visible = true;

            // Nếu dữ liệu load thành công thì hiển thị danh sách lớp học lên DataGridView ClassList
            if (data.code == "success")
            {
                ClassList.Rows.Clear();
                foreach (DataRow row in data.data.Rows)
                {
                    ClassList.Rows.Add(row["ClassID"].ToString(), row["ClassName"].ToString(), row["MajorName"].ToString());
                }
            }
        }

        // Lấy danh sách lớp học dựa trên majorID
        public Response getData(string majorID)
        {
            ClassAccess access = new ClassAccess();
            Response res = access.getListClass(majorID);
            return res;
        }
        public Response getSearchData(string keyword)
        {
            ClassAccess access = new ClassAccess();
            Response res = access.getSearchClassData(keyword);
            return res;
        }
        // Load danh sách ngành và danh sách lớp học lên DataGridView ClassList khi Form được load
        private void ClassMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData(() => getData(currentMajorID));
        }

        // Format hiển thị cho button "Chỉnh sửa" trong DataGridView ClassList
        private void userList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ClassList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = ClassList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Value = "Chỉnh sửa";
                buttonCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonCell.Style.BackColor = Color.LightBlue;
                buttonCell.Style.ForeColor = Color.LightGreen;
                buttonCell.Style.Font = new Font("Roboto", 10, FontStyle.Regular);
            }
        }

        // Thêm 1 lớp học mới vào DataGridView ClassList
        public void UpdateClassList(string classID, string className, string majorName)
        {
            ClassList.Rows.Add(classID, className, majorName);
        }

        public void UpdateClassData(int rowIndex, string classID, string className, string majorName)
        {
            ClassList.Rows[rowIndex].Cells["ClassID"].Value = classID;
            ClassList.Rows[rowIndex].Cells["ClassName"].Value = className;
            ClassList.Rows[rowIndex].Cells["MajorName"].Value = majorName;
        }
        // Xử lý sự kiện click vào nút Chỉnh sửa
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (ClassList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Lấy dữ liệu của dòng được click
                DataGridViewRow row = ClassList.Rows[e.RowIndex];
                string classID = row.Cells["ClassID"].Value.ToString();
                EditClass editForm = new EditClass(rowIndex,classID);
                editForm.parentInstance = this;
                editForm.ShowDialog();
                // Tiếp
            }
        }

        // Xử lý sự kiện click cho nút Refresh để load lại danh sách lớp học
        private void refeshBtn_Click(object sender, EventArgs e)
        {
                searchBox.Text = string.Empty;
                loadData(() => getData(currentMajorID));
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
                loadData(() => getData(currentMajorID));
            else
                loadData(() => getSearchData(searchBox.Text));
        }
        // Xử lý sự kiện chọn cho ComboBox ngành học để lọc danh sách lớp học
        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
            {
                currentMajorID = "All";
                loadData(() => getData(currentMajorID));
            }    
            else
            {
                DataRow row = majorList.Rows[optionIndex - 1];
                currentMajorID = row["MajorID"].ToString();
                loadData(() => getData(currentMajorID));
            }
        }

        // Xử sự kiện click cho nút Thêm lớp học để mở form thêm mới lớp học
        private void addClassBtn_Click(object sender, EventArgs e)
        {
            AddClass addClassForm = new AddClass();
            addClassForm.parentInstance= this;
            addClassForm.ShowDialog();
        }

        private void removeClassBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có hàng nào được chọn
            if (rowIndex < 0)
                return;
            else
            {
                // Lấy thông tin từ hàng được chọn
                DataGridViewRow row = ClassList.Rows[rowIndex];
                string classID = row.Cells["ClassID"].Value.ToString();
                // Hiển thị hộp thoại xác nhận xoá lớp học
                string message = "Bạn có chắc chắn muốn xoá lớp '" + classID + "' không? Thao tác này có thể ảnh hưởng đến sinh viên.";
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    // Gọi phương thức xoá lớp học từ lớp truy cập CSDL
                    ClassAccess deleteAccess = new ClassAccess();
                    Response res = new Response();
                    Request deleteUserRq = new Request();
                    deleteUserRq.AddData("ClassID", classID);
                    res = deleteAccess.DeleteClass(deleteUserRq);
                    Console.WriteLine(res.code);
                    // Kiểm tra kết quả xoá thành công
                    if (res.code == "delete_successfully")
                    {
                        // Xoá hàng khỏi bảng danh sách lớp học và cập nhật lại chỉ số hàng được chọn
                        ClassList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        ClassList.Refresh();
                    }

                }
            }
        }
    }
}

