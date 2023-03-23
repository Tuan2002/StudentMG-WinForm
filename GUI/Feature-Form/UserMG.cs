using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL; //
using DTO;
using BLL;
using COM;

namespace GUI
{
    public partial class UserMG : Form
    {
        AddUser addUserForm = new AddUser();

        public UserMG()
        {
            InitializeComponent();
            addUserForm.UpdateUserListEvent += new AddUser.UpdateUserListView(UpdateUserList);
        }
        private Response getListUser()
        {
            DatabaseAccess access = new DatabaseAccess();
            return access.getListUser();
        }

        private void UserMG_Load(object sender, EventArgs e)
        {

            Response res = new Response();
            res = getListUser();

            if (res.code == "success")
            {
                foreach (DataRow row in res.data.Rows)
                {
                    userList.Rows.Add(row["userName"].ToString(), row["userPassword"].ToString(), row["userEmail"].ToString());
                }
            }
            else
                MessageBox.Show("Lỗi");
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
            addUserForm.StartPosition = FormStartPosition.CenterScreen;
            addUserForm.Show();
        }

        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userList.Columns[e.ColumnIndex].Name == "Actions")
            {
                    // Get the data from the cell
                    DataGridViewRow row = userList.Rows[e.RowIndex];
                    string cellValue = row.Cells["userName"].Value.ToString(); 
                    EditForm editForm = new EditForm(cellValue);
                    editForm.Show();  
            }
        }
    }
}
