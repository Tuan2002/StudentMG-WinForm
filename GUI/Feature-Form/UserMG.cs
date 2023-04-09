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
        
        private int rowIndex;

        public UserMG()
        {
            InitializeComponent();

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
                userList.Rows.Clear();
                foreach (DataRow row in data.data.Rows)
                {
                    userList.Rows.Add(row["userName"].ToString(), row["userPassword"].ToString(), row["userEmail"].ToString());
                }
            }
        }
        public Response getData()
        {
            DatabaseAccess access = new DatabaseAccess();
            Response res =  access.getListUser();
            return res;
        }  
        public Response getSearchData(string keyword)
        {
            DatabaseAccess access = new DatabaseAccess();
            Response res = access.getSearchUserData(keyword);
            return res;
        }
        private void UserMG_Load(object sender, EventArgs e)
        {
            loadData(() => getData());
        }

        private void userList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
        private void UpdateUserList(string userName, string userPassword, string userEmail)
        {
            userList.Rows.Add(userName, userPassword, userEmail);
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.UpdateUserListEvent += new AddUser.UpdateUserListView(UpdateUserList);
            addUserForm.Show();
        }
        private void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail)
        {
            userList.Rows[rowIndex].Cells["userName"].Value = userName;
            userList.Rows[rowIndex].Cells["passWord"].Value = userPassword;
            userList.Rows[rowIndex].Cells["userEmail"].Value = userEmail;
        }
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (userList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Get the data from the cell
                DataGridViewRow row = userList.Rows[e.RowIndex];
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
                DataGridViewRow row = userList.Rows[rowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                string message = "Bạn có chắc chắn muốn xoá người dùng '" + cellValue + "' không? Mọi thay đổi không thể hoàn tác";
                DatabaseAccess deleteAccess = new DatabaseAccess();
                Response res = new Response();
                Request deleteUserRq = new Request();
                var result = RJMessageBox.Show(message, "Chú ý!", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    deleteUserRq.AddData("userName", cellValue);
                    res = deleteAccess.DeleteUser(deleteUserRq);
                    if (res.code == "delele_successfully")
                    {
                        userList.Rows.RemoveAt(rowIndex);
                        rowIndex = -1;
                        userList.Refresh();
                    }
                    else
                    {
                        MessageBox.Show(res.code);
                    }
                }

            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            loadData(() => getData());
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
            {
                loadData(() => getData());
            }
            else
            {
                loadData(() => getSearchData(searchBox.Text));
            }
        }
    }
}
