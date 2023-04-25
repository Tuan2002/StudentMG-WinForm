using System;
using System.Data;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
    public partial class AddStudent : Form
    {
        // Khai báo các thuộc tính
        private string provideCode;
        private string districtCode;
        private string wardCode;
        private string provideName;
        private string districtName;
        private string wardName;
        private string gender;
        private string currentMajorID;
        private string currentMajorName;
        private string currentClassID;
        private DataTable majorList;
        public StudentMG parentInstance;
        public AddStudent()
        {
            InitializeComponent();
        }
        private void clearValidate()
        {
            formMessage.Text = string.Empty;
            studentNameError.Text = string.Empty;
            majorError.Text = string.Empty; 
            genderError.Text = string.Empty;
            addressError.Text = string.Empty;
            birthdayError.Text = string.Empty;
            PersonIDError.Text = string.Empty;
            PersonID.BorderColor = Color.Plum;
            studentNameBox.BorderColor = Color.Plum;
            formMessage.ForeColor = Color.ForestGreen;
            
        }
        // Phương thức lấy danh sách các ngành
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
        // Phương thức lấy danh sách các lớp theo mã ngành
        public void LoadClassOptions(string majorID)
        {
            ClassAccess access = new ClassAccess();
            Response res = access.getListClass(majorID);
            ClassOptions.DataSource = res.data;
            ClassOptions.DisplayMember = "ClassName";
            ClassOptions.ValueMember = "ClassID";
        }
        // Phương thức lấy danh sách tỉnh thành qua API
        private async void loadProvideList()
        {
            // Gọi API để lấy danh sách tỉnh thành
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://provinces.open-api.vn/api/p/");
            string json = await response.Content.ReadAsStringAsync();
            // Chuyển đổi json thành DataTable
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(json);
            ProvideList.DataSource = null;
            ProvideList.DisplayMember = "name";
            ProvideList.ValueMember = "code";
            ProvideList.DataSource = dataTable;
        }
        // Phương thức lấy danh sách quận huyện theo mã tỉnh thành
        private async void loadDistrictList(string provideCode)
        {
            // Gọi API để lấy danh sách quận huyện
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://provinces.open-api.vn/api/p/" + provideCode + "?depth=2");
            string json = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject(json);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Code", typeof(int));
            // Lấy danh sách quận huyện
            foreach (var district in jsonObject.districts)
            {
                string name = district.name;
                int code = district.code;

                DataRow row = dataTable.NewRow();
                row["Name"] = name;
                row["Code"] = code;
                dataTable.Rows.Add(row);
            }
            DistrictList.DataSource = null;
            DistrictList.DisplayMember = "Name";
            DistrictList.ValueMember = "Code";
            DistrictList.DataSource = dataTable;
        }
        // Phương thức lấy danh sách phường xã theo mã quận huyện
        private async void loadWardList(string districtCode)
        {
            // Gọi API để lấy danh sách phường xã
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://provinces.open-api.vn/api/d/" + districtCode + "?depth=2");
            string json = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject(json);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Code", typeof(int));
            // Lấy danh sách phường xã
            foreach (var ward in jsonObject.wards)
            {
                string name = ward.name;
                int code = ward.code;
                DataRow row = dataTable.NewRow();
                row["Name"] = name;
                row["Code"] = code;
                dataTable.Rows.Add(row);
            }
            WardList.DataSource = null;
            WardList.DisplayMember = "Name";
            WardList.ValueMember = "Code";
            WardList.DataSource = dataTable;
        }
        // Xử lý sự kiện thay đổi tỉnh thành
        private void ProvideList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            DataRowView selectedRow = ProvideList.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                provideCode = selectedRow["code"].ToString();
                provideName = selectedRow["name"].ToString();
                loadDistrictList(provideCode);
                DistrictList.Enabled = true;
            }
        }
        // Xử lý sự kiện thay đổi quận huyện
        private void DistrictList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            DataRowView selectedRow = DistrictList.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                districtCode = selectedRow["code"].ToString();
                districtName = selectedRow["name"].ToString();
                loadWardList(districtCode);
                WardList.Enabled = true;
            }
        }
        // Xử lý sự kiện thay đổi phường xã
        private void WardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            DataRowView selectedRow = WardList.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                wardCode = selectedRow["code"].ToString();
                wardName = selectedRow["name"].ToString();
            }

        }
        // Xử lý sự kiện khi click vào drop down của tỉnh thành
        private void ProvideList_DropDown(object sender, EventArgs e)
        {
            loadProvideList();
        }
        // Phương thức lấy ngày tháng năm
        private void LoadDateTime()
        {
            // Thêm tháng
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                    SelectMonth.Items.Add("0" + i.ToString());
                else
                    SelectMonth.Items.Add(i.ToString());
            }
            // Thêm năm
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 100; i <= currentYear; i++)
            {
                SelectYear.Items.Add(i.ToString());
            }

            // Chọn ngày tháng năm mặc định                   
            SelectMonth.SelectedIndex = 0;
            SelectYear.SelectedIndex = 0;
        }
        // Sự kiện form load
        private void AddStudent_Load(object sender, EventArgs e)
        {
            clearValidate();
            loadMajorOptions();
            this.ProvideList.Items.Add("- Chọn Tinh Thành -");
            this.ProvideList.SelectedIndex = 0;
            this.DistrictList.Items.Add("- Chọn Quận Huyện -");
            this.DistrictList.SelectedIndex = 0;
            this.WardList.Items.Add("- Chọn Phường Xã -");
            this.WardList.SelectedIndex = 0;
            this.provideName = string.Empty;
            this.districtName = string.Empty;
            this.wardName = string.Empty;
            this.gender = string.Empty;
            this.currentClassID = string.Empty;
            LoadDateTime();
        }
        // Phương thức xử lý sự kiện thay đổi tháng
        private void SelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int daysInMonth;
            // Kiểm tra năm nhuận để lấy số ngày của tháng
            if (SelectYear.SelectedItem != null)
                daysInMonth = DateTime.DaysInMonth(Int32.Parse(SelectYear.SelectedItem.ToString()), SelectMonth.SelectedIndex + 1);
            else    
                daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, SelectMonth.SelectedIndex + 1);
            SelectDate.Items.Clear();
            for (int i = 1; i <= daysInMonth; i++)
            {
                if (i < 10)
                    SelectDate.Items.Add("0" + i.ToString());
                else
                    SelectDate.Items.Add(i.ToString());
            }
            SelectDate.SelectedIndex = 0;
        }

        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            int optionIndex = MajorOptions.SelectedIndex;
            if (optionIndex <= 0)
            {
                currentMajorID = string.Empty; // Nếu không chọn ngành học thì không có mã ngành học
                ClassOptions.DataSource = null;
                ClassOptions.Enabled = false;
            }
            else
            {
                DataRow row = majorList.Rows[optionIndex - 1]; // Lấy thông tin ngành học tại vị trí được chọn
                currentMajorID = row["MajorID"].ToString(); // Lưu lại mã ngành học được chọn
                currentMajorName = row["MajorName"].ToString(); // Lưu lại tên ngành học được chọn
                LoadClassOptions(currentMajorID);
                if (ClassOptions.SelectedIndex == -1)
                {
                    currentClassID = string.Empty;
                    ClassOptions.Enabled = false;
                }    
                else
                    ClassOptions.Enabled = true;

            }
        }
        // Sự kiện chọn lớp học
        private void ClassOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = ClassOptions.SelectedItem as DataRowView;
            if (selectedRow != null)
                currentClassID = selectedRow["ClassID"].ToString();
        }
        // Phương thức ghép ngày sinh thành chuỗi
        private string getBirthday()
        {
            string selectedDate = SelectDate.SelectedItem.ToString();
            string selectedMonth = SelectMonth.SelectedItem.ToString();
            string selectedYear = SelectYear.SelectedItem.ToString();
            if (selectedDate.Length > 0 && selectedMonth.Length > 0 && selectedYear.Length > 0)
            {
                string birthday = $"{selectedDate}/{selectedMonth}/{selectedYear}";
                return birthday;
            }
            else 
                return string.Empty;
        }
        // Phương thức ghép địa chỉ
        private string getAddress()
        {
            if (provideName == string.Empty  || districtName == string.Empty  || wardName == string.Empty)
                return string.Empty;
            else
            {
                string adress = $"{wardName}, {districtName}, {provideName}";
                return adress;
            }
        }
        // Phương thức chuẩn hoá chuỗi họ tên
        private string ToProper(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            char[] charArr = str.Trim().ToLower().ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            for (int i = 1; i < charArr.Length; i++)
            {
                if (char.IsWhiteSpace(charArr[i - 1]))
                    charArr[i] = char.ToUpper(charArr[i]);
            }
            return new string(charArr);
        }
        // Xử lý các radio button chọn giới tính
        private void femaleGender_CheckedChanged(object sender, EventArgs e)
        {
            clearValidate();
            gender = femaleGender.Text;
        }

        private void maleGender_CheckedChanged(object sender, EventArgs e)
        {
            clearValidate();
            gender = maleGender.Text;
        }
        private void otherGender_CheckedChanged(object sender, EventArgs e)
        {
            clearValidate();
            gender = otherGender.Text;
        }
        // 
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Request addStudent = new Request();
            Response res = new Response();
            MiddleWare handleAddStudent = new MiddleWare();
            string studentName = ToProper(studentNameBox.Text.Trim());
            string birhday = getBirthday();
            string address = getAddress();
            string personID = PersonID.Text;
            // Thêm các dữ liệu vào request
            addStudent.AddData("StudentName", studentName);
            addStudent.AddData("Birthday", birhday);
            addStudent.AddData("PersonID", personID);
            addStudent.AddData("Address", address);
            addStudent.AddData("Gender", gender);
            addStudent.AddData("ClassID", currentClassID);
            addStudent.AddData("MajorID", currentMajorID);
            res = handleAddStudent.validateAddStudent(addStudent);
            if (res.code == "success")
            {
                string studentID = res.data.Rows[0]["StudentID"].ToString();
                parentInstance.UpdateStudentList(studentID, studentName, birhday, gender, currentClassID, currentMajorName);
                formMessage.Text = "Thêm sinh viên thành công!";
            }    
            else
                switch (res.code)
                {
                    case "studentname_null":
                        studentNameBox.BorderColor = Color.Red;
                        studentNameError.Text = "Họ tên sinh viên không được để trống";
                        break;
                    case "gender_null":
                        genderError.Text = "Chưa chọn giới tính";
                        break;
                    case "majorid_null":
                        majorError.Text = "Chưa chọn ngành học hoặc lớp học";
                        break;
                    case "classid_null":
                        majorError.Text = "Chưa chọn lớp hoặc Ngành học không có lớp học nào";
                        break;
                    case "birthday_null":
                        birthdayError.Text = "Chưa chọn ngày sinh";
                        break;
                    case "personid_null":
                        PersonIDError.Text = "Số CCCD bắt buộc phải có 6 số";
                        break;
                    case "address_null":
                        addressError.Text = "Chưa chọn địa chỉ";
                        break;
                    case "student_exist":
                        formMessage.ForeColor = Color.Red;
                        formMessage.Text = $"Sinh viên có số CCCD '{personID}' đã có trên hệ thống";
                        break;
                    default:
                        formMessage.ForeColor = Color.Red;
                        formMessage.Text = "Có lỗi xảy ra! Mã lỗi: " + res.code;
                        break;

                }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra ký tự nhập vào có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Đánh dấu sự kiện đã xử lý để không cho phép nhập ký tự đó
                PersonIDError.Text = "Vui lòng chỉ nhập số";
            }
            else
                PersonIDError.Text = string.Empty;
        }

        private void studentNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra ký tự nhập vào có phải là chữ không
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Đánh dấu sự kiện đã xử lý để không cho phép nhập ký tự đó
                studentNameError.Text = "Tên không được chứa số và kí tự đặt biệt";
            }
            else
                studentNameError.Text = string.Empty;
        }
    }
}
