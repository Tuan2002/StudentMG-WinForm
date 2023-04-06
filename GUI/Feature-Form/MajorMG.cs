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
    public partial class MajorMG : Form
    {
        AddMajor addMajorForm = new AddMajor();
        private int rowIndex;

        public MajorMG()
        {
            InitializeComponent();
            addMajorForm.UpdateNajorListEvent += new AddMajor.UpdateMajorListView(UpdateMajorList);

        }
        private Response getListMajor()
        {
            DatabaseAccess access = new DatabaseAccess();
            return access.getListMajor();
        }

        public void loadData()
        {
            Response res = new Response();
            res = getListMajor();
            if (res.code == "success")
            {
                MajorList.Rows.Clear();
                foreach (DataRow row in res.data.Rows)
                {
                    MajorList.Rows.Add(row["MajorID"].ToString(), row["MajorName"].ToString());
                }
            }
            else
                MessageBox.Show("Lỗi");
        }
        private void MajorMG_Load(object sender, EventArgs e)
        {
            loadData();
        }

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
        private void UpdateMajorList(string majorID, string majorName)
        {
            MajorList.Rows.Add(majorID, majorName);
        }

        private void addMajorBtn_Click(object sender, EventArgs e)
        {
            addMajorForm.Refresh();
            addMajorForm.Show();
        }
        private void UpdateUserData(int rowIndex, string userName, string userPassword, string userEmail)
        {
            MajorList.Rows[rowIndex].Cells["userName"].Value = userName;
            MajorList.Rows[rowIndex].Cells["passWord"].Value = userPassword;
            MajorList.Rows[rowIndex].Cells["userEmail"].Value = userEmail;
        }
        private void MajorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (MajorList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Get the data from the cell
                DataGridViewRow row = MajorList.Rows[e.RowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                EditForm editForm = new EditForm(rowIndex, cellValue);
                editForm.UpdateUserDataEvent += new EditForm.UpdateUserData(UpdateUserData);
                editForm.Show();
            }
        }

        private void removeMajorBtn_Click(object sender, EventArgs e)
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
                DataGridViewRow row = MajorList.Rows[rowIndex];
                string cellValue = row.Cells["userName"].Value.ToString();
                deleteUserRq.AddData("userName", cellValue);
                res = deleteAccess.DeleteUser(deleteUserRq);
                if (res.code == "delele_successfully")
                {
                    MajorList.Rows.RemoveAt(rowIndex);
                    rowIndex = -1;
                    MajorList.Refresh();
                }
                else
                {
                    MessageBox.Show(res.code);
                }

            }
        }

            private void refeshBtn_Click(object sender, EventArgs e)
            {
                loadData();
            }
    }
}

