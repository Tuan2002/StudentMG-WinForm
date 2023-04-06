using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Feature_Form
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }
        private Response getListUser()
        {
            DatabaseAccess access = new DatabaseAccess();
            return access.getListUser();
        }
        public void loadData()
        {
            Response res = new Response();
            res = getListUser();
            if (res.code == "success")
            {
                dgvStudents.Rows.Clear();
                foreach (DataRow row in res.data.Rows)
                {
                    dgvStudents.Rows.Add(row["studentID"].ToString(), row["fullname"].ToString(), row["adress"].ToString());
                }
            }
            else
                MessageBox.Show("Lỗi");
        }
        private void AddMajor_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
