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
        AddUser addUserForm = new AddUser();
        private int rowIndex;
        private DataTable majorList;
        public ClassMG()
        {
            InitializeComponent();
            addUserForm.UpdateUserListEvent += new AddUser.UpdateUserListView(UpdateUserList);

        }
  
        private void loadMajorOptions()
        {
            DatabaseAccess access = new DatabaseAccess();
            Response res = access.getListMajor();
            majorList = res.data;
            foreach (DataRow row in majorList.Rows)
            {
                MajorOptions.Items.Add(row["MajorName"].ToString());
                MajorOptions.SelectedIndex = 0;
            }
        }
        public void loadData(string majorID)
        {
            DatabaseAccess access = new DatabaseAccess();
            Response res = access.getListClass(majorID);
            if (res.code == "success")
            {
                ClassList.Rows.Clear();
                foreach (DataRow row in res.data.Rows)
                {
                    ClassList.Rows.Add(row["ClassID"].ToString(), row["ClassName"].ToString(), row["MajorName"].ToString());
                }
            }
            else
                MessageBox.Show("Lỗi");
        }
        private void ClassMG_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            loadData("All");
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

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            addUserForm.StartPosition = FormStartPosition.CenterScreen;
            addUserForm.Show();
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
            
        }

        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
            {
                loadData("All");
            }
            else
            {
                DataRow row = majorList.Rows[optionIndex - 1];
                string majorID = row["MajorID"].ToString();
                loadData(majorID);
            }

        }
    }
}

