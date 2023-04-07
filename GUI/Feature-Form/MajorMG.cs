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
        private int rowIndex;

        public MajorMG()
        {
            InitializeComponent();

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
        private void UpdateMajorData(int rowIndex, string majorID, string majorName)
        {
            MajorList.Rows[rowIndex].Cells["MajorID"].Value = majorID;
            MajorList.Rows[rowIndex].Cells["MajorName"].Value = majorName;
        }

        private void addMajorBtn_Click(object sender, EventArgs e)
        {
            AddMajor addMajorForm = new AddMajor();
            addMajorForm.UpdateNajorListEvent += new AddMajor.UpdateMajorListView(UpdateMajorList);
            addMajorForm.Show();
        }
        private void MajorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (MajorList.Columns[e.ColumnIndex].Name == "Actions")
            {
                // Get the data from the cell
                DataGridViewRow row = MajorList.Rows[e.RowIndex];
                string majorID = row.Cells["MajorID"].Value.ToString();
                string majorName = row.Cells["MajorName"].Value.ToString();
                EditMajor editForm = new EditMajor(rowIndex, majorID, majorName);
                editForm.UpdateMajorDataEvent += new EditMajor.UpdateMajorData(UpdateMajorData);
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
                string majorID = row.Cells["MajorID"].Value.ToString();
                deleteUserRq.AddData("MajorID", majorID);
                res = deleteAccess.DeleteMajor(deleteUserRq);
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

