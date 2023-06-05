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
                ClassList.Rows.Clear();
                foreach (DataRow row in data.data.Rows)
                {
                    ClassList.Rows.Add(row["ClassID"].ToString(), row["ClassName"].ToString(), row["MajorName"].ToString());
                }
            }
        }

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
        private void ClassMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData(() => getData(currentMajorID));
        }

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
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (ClassList.Columns[e.ColumnIndex].Name == "Actions")
            {
                DataGridViewRow row = ClassList.Rows[e.RowIndex];
                string classID = row.Cells["ClassID"].Value.ToString();
                EditClass editForm = new EditClass(rowIndex, classID);
                editForm.parentInstance = this;
                editForm.ShowDialog();
            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
            loadData(() => getData(currentMajorID));
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
            AddClass addClassForm = new AddClass();
            addClassForm.parentInstance = this;
            addClassForm.ShowDialog();
        }

        private void removeClassBtn_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
                return;
            else
            {
                DataGridViewRow row = ClassList.Rows[rowIndex];
                string classID = row.Cells["ClassID"].Value.ToString();
                string message = "Bạn có chắc chắn muốn xoá lớp '" + classID + "' không? Thao tác này có thể ảnh hưởng đến sinh viên.";
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    ClassAccess deleteAccess = new ClassAccess();
                    Response res = new Response();
                    Request deleteUserRq = new Request();
                    deleteUserRq.AddData("ClassID", classID);
                    res = deleteAccess.DeleteClass(deleteUserRq);
                    Console.WriteLine(res.code);
                    if (res.code == "delete_successfully")
                    {
                        ClassList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        ClassList.Refresh();
                    }

                }
            }
        }
    }
}

