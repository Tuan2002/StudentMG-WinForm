using BLL;
using DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditClass : Form
    {
        // Khai báo thuộc tính cần thiết
        private DataTable majorList;
        private string currentMajorID;
        private string currentMajorName;
        private string currentClassID;
        private int rowIndex;
        public ClassMG parentInstance;

        public EditClass()
        {
            InitializeComponent();
        }

        public EditClass (int rowIndex ,string classID)
        {
            InitializeComponent();
            this.currentClassID = classID;
            this.rowIndex = rowIndex;
        }

        // Hàm xóa thông báo lỗi
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

        // Hàm xóa form nhập liệu
        public void clearForm()
        {
            clearValidate();
            classIDBox.Text = string.Empty;
            classNameBox.Text = string.Empty;
        }

        // Hàm tải danh sách các ngành học vào combobox
        private void loadMajorOptions()
        {
            MajorAccess access = new MajorAccess();
            Response res = access.getListMajor();
            majorList = res.data;
            MajorOptions.DataSource = majorList;
            MajorOptions.DisplayMember = "MajorName";
            MajorOptions.ValueMember = "MajorID";
            foreach (var item in MajorOptions.Items)
            {
                DataRowView row = item as DataRowView;
                if (row["MajorID"].ToString() == currentMajorID)
                {
                    MajorOptions.SelectedItem = item;
                    break;
                }
            }
        }
        // Lấy thông tin lớp học
        private void loadClassData()
        {
            ClassAccess access = new ClassAccess();
            Response res = access.getClassData(currentClassID);
            if (res.code == "success")
            {
                DataTable classData = res.data;
                classIDBox.Text = classData.Rows[0]["ClassID"].ToString();
                classNameBox.Text = classData.Rows[0]["ClassName"].ToString();
                currentMajorID = classData.Rows[0]["MajorID"].ToString();
            }
        }

        // Sự kiện khi form được load
        private void AddClass_Load(object sender, EventArgs e)
        {
            clearForm();
            loadClassData();
            loadMajorOptions();
            ActiveControl = this.classIDBox;
        }
        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate(); // Xóa bỏ các thông báo lỗi hiển thị trên form
            DataRowView selectedMajor = MajorOptions.SelectedItem as DataRowView;
            if (selectedMajor != null && MajorOptions.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                currentMajorID = MajorOptions.SelectedValue.ToString();
                currentMajorName = selectedMajor["MajorName"].ToString();
            }
        }

        private void classIDBox_TextChanged(object sender, EventArgs e)
        {
            // Sao chép nội dung của classIDBox sang classNameBox và chuyển thành chữ hoa
            classNameBox.Text = classIDBox.Text.Trim().ToUpper(); 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Sự kiện khi nhấn nút chỉnh sửa
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Request editReq = new Request();
            editReq.AddData("CurrentClassID", currentClassID);
            editReq.AddData("NewClassID", classIDBox.Text.Trim().ToUpper());
            editReq.AddData("ClassName", classNameBox.Text.Trim());
            editReq.AddData("MajorID", currentMajorID);
            MiddleWare editClass = new MiddleWare();
            Response res = editClass.validateEditClass(editReq);
            switch (res.code)
            {
                case "success":
                    parentInstance.UpdateClassData(rowIndex, classIDBox.Text.Trim().ToUpper(), classNameBox.Text.Trim(), currentMajorName);
                    this.Close();
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

