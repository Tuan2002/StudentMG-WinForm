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
  
        private void loadMajorOptions()
        {
            MajorOptions.Items.Clear();
            MajorOptions.Items.Add("Tất cả các ngành");
            DatabaseAccess access = new DatabaseAccess();
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
            DatabaseAccess access = new DatabaseAccess();
            Response res = access.getListClass(majorID);
            return res;
        }
        private void ClassMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData(() => getData("All"));
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
        private void UpdateUserList(string userName, string userPassword, string userEmail)
        {
            ClassList.Rows.Add(userName, userPassword, userEmail);
        }

        private void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail)
        {
            ClassList.Rows[rowIndex].Cells["userName"].Value = userName;
            ClassList.Rows[rowIndex].Cells["passWord"].Value = userPassword;
            ClassList.Rows[rowIndex].Cells["userEmail"].Value = userEmail;
        }
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (ClassList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Get the data from the cell
                DataGridViewRow row = ClassList.Rows[e.RowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                EditForm editForm = new EditForm(rowIndex, cellValue);
                editForm.UpdateUserDataEvent += new EditForm.UpdateUserData(UpdateUserData);
                editForm.Show();
            }
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {

            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                DatabaseAccess deleteAccess = new DatabaseAccess();
                Response res = new Response();
                Request deleteUserRq = new Request();
                DataGridViewRow row = ClassList.Rows[rowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                deleteUserRq.AddData("userName", cellValue);
                res = deleteAccess.DeleteUser(deleteUserRq);
                if (res.code == "delele_successfully")
                {
                    ClassList.Rows.RemoveAt(rowIndex);
                    rowIndex = -1;
                    ClassList.Refresh();
                }
                else
                {
                    MessageBox.Show(res.code);
                }

            }
        }
        private void refeshBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text= string.Empty;
            loadData(() => getData(currentMajorID));
        }

        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
            {
                loadData(() => getData("All"));
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
            addClassForm.ShowDialog();
        }
    }
}

