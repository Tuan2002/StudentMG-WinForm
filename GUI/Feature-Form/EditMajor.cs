using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class EditMajor : Form
    {
        public MajorMG parentInstance { get; set; }
        private int rowIndex;
        private string currentMajorID;
        public EditMajor()
        {
            InitializeComponent();
        }
        public EditMajor(int rowIndex, string majorID, string majorName)
        {
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.currentMajorID = majorID;
            MajorIDBox.Text = majorID;
            MajorNameBox.Text = majorName;
        }

        public void clearValidate()
        {
            MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            MajorNameEmpty.Text = string.Empty;
            MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            MajorIDEmpty.Text = string.Empty;
            formError.Text = string.Empty;
        }
        public void clearForm()
        {
            MajorIDBox.Text = string.Empty;
            MajorNameBox.Text = string.Empty;
            clearValidate();
        }

        private void EditMajor_Load(object sender, EventArgs e)
        {
            clearValidate();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Request editMajorReq = new Request();
            editMajorReq.AddData("CurrentMajorID", currentMajorID);
            editMajorReq.AddData("NewMajorID", MajorIDBox.Text.Trim().ToUpper());
            editMajorReq.AddData("MajorName", MajorNameBox.Text.Trim());

            MiddleWare handleEditMajor = new MiddleWare();

            Response res = handleEditMajor.validateEditMajor(editMajorReq);

            switch (res.code)
            {
                case "update_successfully":
                    parentInstance.UpdateMajorData(rowIndex, MajorIDBox.Text.Trim().ToUpper(), MajorNameBox.Text.Trim());
                    this.Close();
                    break;
                case "majorid_null":
                    MajorIDBox.BorderColor = System.Drawing.Color.Red;
                    MajorIDEmpty.Text = "Mã ngành không được để trống";
                    break;
                case "majorname_null":
                    MajorNameBox.BorderColor = System.Drawing.Color.Red;
                    MajorNameEmpty.Text = "Tên ngành không được để trống";
                    break;
                case "major_already_exist":
                    formError.Text = "Mã ngành học đã tồn tại trên hệ thống";
                    break;
                default:
                    formError.Text = "Có lỗi xảy ra! Mã lỗi: " + res.code;
                    break;
            }
        }
    }
}
