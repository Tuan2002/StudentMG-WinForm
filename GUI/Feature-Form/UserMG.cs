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
            UserAccess access = new UserAccess();
            Response res = access.getListUser();
            return res;
        }

        public Response getSearchData(string keyword)
        {
            UserAccess access = new UserAccess();
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
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.parentInstance = this;
            addUserForm.ShowDialog();
        }

        public void UpdateUserList(string userName, string userPassword, string userEmail)
        {
            userList.Rows.Add(userName, userPassword, userEmail);
        }

        public void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail)
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
                Console.WriteLine("Chỉnh sửa");
                DataGridViewRow row = userList.Rows[e.RowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();

                EditForm editForm = new EditForm(rowIndex, cellValue);
                editForm.parentInstance = this;
                editForm.ShowDialog();
            }
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
                return;
            else
            {
                DataGridViewRow row = userList.Rows[rowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                string message = "Bạn có chắc chắn muốn xoá người dùng '" + cellValue + "' không? Mọi thay đổi không thể hoàn tác";

                UserAccess deleteAccess = new UserAccess();
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
                loadData(() => getData());
            else
                loadData(() => getSearchData(searchBox.Text));
        }
    }
}
