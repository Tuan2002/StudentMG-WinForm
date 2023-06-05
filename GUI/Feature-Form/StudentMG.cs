using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class StudentMG : Form
    {
        private int rowIndex;
        private DataTable majorList;
        private string currentMajorID;
        public StudentMG()
        {
            InitializeComponent();
            currentMajorID = "All";
        }

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

        public async void loadData(Func<Response> res)
        {
            if (searchBox.Text != string.Empty)
            {
                waitProgess.Visible = true;
                searchBtn.Visible = false;
            }
            dataLoading.Visible = true;

            var data = await Task.Run(() => res());

            waitProgess.Visible = false;
            dataLoading.Visible = false;
            searchBtn.Visible = true;

            if (data.code == "success")
            {
                StudentList.Rows.Clear();
                foreach (DataRow row in data.data.Rows)
                {
                    StudentList.Rows.Add(row["StudentID"].ToString(), row["Fullname"].ToString(), row["Birthday"].ToString(), row["Gender"].ToString(), row["ClassID"].ToString(), row["MajorName"].ToString());
                }
            }
        }

        public Response getData(string majorID)
        {
            StudentAccess access = new StudentAccess();
            Response res = access.getStudentList(majorID);
            return res;
        }

        private void StudentMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData(() => getData(currentMajorID));
        }

        private void userList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (StudentList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = StudentList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Value = "Chỉnh sửa";
                buttonCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonCell.Style.BackColor = Color.LightBlue;
                buttonCell.Style.ForeColor = Color.LightGreen;
                buttonCell.Style.Font = new Font("Roboto", 10, FontStyle.Regular);
            }
        }

        public void UpdateStudentList(string studentID, string studentName, string birthday, string gender, string classID, string majorName)
        {
            StudentList.Rows.Add(studentID, studentName, birthday, gender, classID, majorName);
        }

        public void UpdateStudentData(int rowIndex, string studentID, string studentName, string biirthday, string gender, string classID, string majorName)
        {
            StudentList.Rows[rowIndex].Cells["StudentID"].Value = studentID;
            StudentList.Rows[rowIndex].Cells["StudentName"].Value = studentName;
            StudentList.Rows[rowIndex].Cells["Birthday"].Value = biirthday;
            StudentList.Rows[rowIndex].Cells["Gender"].Value = gender;
            StudentList.Rows[rowIndex].Cells["ClassID"].Value = classID;
            StudentList.Rows[rowIndex].Cells["MajorName"].Value = majorName;
        }
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (StudentList.Columns[e.ColumnIndex].Name == "Actions")
            {
                DataGridViewRow row = StudentList.Rows[e.RowIndex];
                string StudentID = row.Cells["StudentID"].Value.ToString();
                EditStudent editForm = new EditStudent(rowIndex, StudentID);
                editForm.parentInstance = this;
                editForm.ShowDialog();
            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
            loadData(() => getData(currentMajorID));
        }

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

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.parentInstance = this;
            addStudentForm.ShowDialog();
        }

        private void removeClassBtn_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
                return;
            else
            {
                DataGridViewRow row = StudentList.Rows[rowIndex];
                string studentID = row.Cells["StudentID"].Value.ToString();
                string message = $"Bạn có chắc chắn muốn xoá sinh viên '{studentID}' không? Thao tác này không thể hoàn tác";
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    StudentAccess deleteAccess = new StudentAccess();
                    Response res = new Response();
                    Request deleteUserRq = new Request();
                    deleteUserRq.AddData("StudentID", studentID);
                    res = deleteAccess.DeleteStudent(deleteUserRq);
                    if (res.code == "delete_successfully")
                    {
                        StudentList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        StudentList.Refresh();
                    }

                }
            }
        }

        public Response getSearchData(string keyword)
        {
            StudentAccess access = new StudentAccess();
            Response res = access.getSearchStudentData(keyword);
            return res;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SearchInputEvent.Stop();
            SearchInputEvent.Start();
        }

        private void SearchInputEventEnd(object sender, EventArgs e)
        {
            SearchInputEvent.Stop();
            if (searchBox.Text == string.Empty)
                loadData(() => getData(currentMajorID));
            else
                loadData(() => getSearchData(searchBox.Text));
        }
    }
}

