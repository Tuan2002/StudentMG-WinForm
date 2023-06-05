using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class AddMajor : Form
    {
        public MajorMG parentInstance { get; set; }
        public AddMajor()
        {
            InitializeComponent();
        }
        public void clearValidate()
        {
            MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            MajorNameEmpty.Text = string.Empty;
            MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            MajorIDEmpty.Text = string.Empty;
            formMessage.Text = string.Empty;
            formMessage.ForeColor = System.Drawing.Color.Red;
        }

        public void clearForm()
        {
            MajorIDBox.Text = string.Empty;
            MajorNameBox.Text = string.Empty;
            clearValidate();
        }

        private void AddMajor_Load(object sender, EventArgs e)
        {
            clearValidate();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Request addMajorReq = new Request();
            Response res = new Response();
            MiddleWare handleAddMajor = new MiddleWare();

            addMajorReq.AddData("MajorID", MajorIDBox.Text.Trim().ToUpper());
            addMajorReq.AddData("MajorName", MajorNameBox.Text.Trim());

            res = handleAddMajor.validateAddMajor(addMajorReq);

            switch (res.code)
            {
                case "success":
                    parentInstance.UpdateMajorList(MajorIDBox.Text.Trim().ToUpper(), MajorNameBox.Text.Trim());
                    this.clearForm();
                    formMessage.ForeColor = Color.ForestGreen;
                    formMessage.Text = "Thêm ngành học thành công!";
                    break;
                case "majorid_null":
                    MajorIDBox.BorderColor = System.Drawing.Color.Red;
                    MajorIDEmpty.Text = "Mã ngành học không được để trống";
                    break;
                case "majorname_null":
                    MajorNameBox.BorderColor = System.Drawing.Color.Red;
                    MajorNameEmpty.Text = "Tên ngành học không được để trống";
                    break;
                case "major_exist":
                    formMessage.Text = "Ngành học này đã tồn tại trong hệ thống";
                    break;
                default:
                    formMessage.Text = "Có lõi xảy ra, Mã lỗi: " + res.code;
                    break;
            }
        }
    }
}
