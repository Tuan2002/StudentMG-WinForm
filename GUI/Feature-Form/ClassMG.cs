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
    public partial class ClassMG : Form
    {
        private int rowIndex;
        private DataTable majorList;
        private string currentMajorID;

        public ClassMG()
        {
            InitializeComponent();
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

        // Load danh sách ngành và danh sách lớp học lên DataGridView ClassList khi Form được load
        private void ClassMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData(() => getData("All"));
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
        private void UpdateClassList(string classID, string className, string majorName)
        {
            ClassList.Rows.Add(classID, className, majorName);
        }

        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (ClassList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Lấy dữ liệu của dòng được click
                DataGridViewRow row = ClassList.Rows[e.RowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                // Tiếp
            }
        }

        // Xử lý sự kiện click cho nút Refresh để load lại danh sách lớp học
        private void refeshBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
            loadData(() => getData(currentMajorID));
        }

        // Xử lý sự kiện chọn cho ComboBox ngành học để lọc danh sách lớp học
        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
                loadData(() => getData("All"));
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
            addClassForm.UpdateClassListEvent += new AddClass.UpdateClassList(UpdateClassList);
            addClassForm.ShowDialog();
        }
    }
}

