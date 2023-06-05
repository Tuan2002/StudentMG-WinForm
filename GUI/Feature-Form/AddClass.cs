using BLL;
using DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddClass : Form
    {
        private DataTable majorList;
        private string currentMajorID;
        private string currentMajorName;

        public ClassMG parentInstance { get; set; }

        public AddClass()
        {
            InitializeComponent();
        }

        public void clearValidate()
        {
            classIDError.Text = string.Empty;
            classNameError.Text = string.Empty;
            majorOptionError.Text = string.Empty;
            formMessage.Text = string.Empty;
            formMessage.ForeColor = Color.Red;
            classIDBox.BorderColor = Color.Plum;
            classNameBox.BorderColor = Color.Plum;
            MajorOptions.BorderColor = Color.Plum;
        }

        public void clearForm()
        {
            clearValidate();
            classIDBox.Text = string.Empty;
            classNameBox.Text = string.Empty;
            MajorOptions.SelectedIndex = 0;
        }

        private void loadMajorOptions()
        {
            MajorAccess access = new MajorAccess();
            Response res = access.getListMajor();
            majorList = res.data;
            foreach (DataRow row in majorList.Rows)
            {
                MajorOptions.Items.Add(row["MajorName"].ToString());
                MajorOptions.SelectedIndex = 0;
            }
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            loadMajorOptions();
            clearForm();
            ActiveControl = this.classIDBox;
        }
        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
            {
                currentMajorID = string.Empty;
            }
            else
            {
                DataRow row = majorList.Rows[optionIndex - 1];
                currentMajorID = row["MajorID"].ToString();
                currentMajorName = row["MajorName"].ToString();
            }
        }

        private void classIDBox_TextChanged(object sender, EventArgs e)
        {

            classNameBox.Text = classIDBox.Text.Trim().ToUpper();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MiddleWare addClass = new MiddleWare();
            Request req = new Request();
            Response res = new Response();
            req.AddData("ClassID", classIDBox.Text.Trim().ToUpper());
            req.AddData("ClassName", classNameBox.Text.Trim());
            req.AddData("MajorID", currentMajorID);
            res = addClass.validateAddClass(req);
            switch (res.code)
            {
                case "success":
                    parentInstance.UpdateClassList(classIDBox.Text.Trim().ToUpper(), classNameBox.Text.Trim(), currentMajorName);
                    this.clearForm();
                    formMessage.ForeColor = Color.ForestGreen;
                    formMessage.Text = "Thêm lớp học thành công!";
                    break;
                case "majorid_null":
                    majorOptionError.Text = "Vui lòng chọn ngành học";
                    MajorOptions.BorderColor = Color.Red;
                    break;
                case "classid_null":
                    classIDError.Text = "Chưa nhập mã lớp";
                    classIDBox.BorderColor = Color.Red;
                    break;
                case "classname_null":
                    classNameError.Text = "Chưa nhập mã lớp";
                    classNameBox.BorderColor = Color.Red;
                    break;
                case "class_exist":
                    formMessage.Text = "Lớp học này đã tồn tại hoặc ngành học không đúng";
                    break;
                default:
                    formMessage.Text = "Có lỗi xảy ra! Mã lối: " + res.code;
                    break;
            }

        }
    }
}

