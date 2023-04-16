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
    public partial class EditStudent : Form
    {
        // Khai báo các thuộc tính
        private string provideCode;
        private string districtCode;
        private string wardCode;
        private string provideName;
        private string districtName;
        private string wardName;
        private string gender;
        private string currentStudentID;
        private string currentMajorID;
        private string currentMajorName;
        private string currentClassID;
        private string defaultAdrress;
        private string defaultBirthday;

        private int rowIndex;
        private bool isMonthChanged;
        private DataTable majorList;
        public StudentMG parentInstance;
        public EditStudent()
        {
            InitializeComponent();
        }
        public EditStudent(int rowIndex,string studentID)
        {
            InitializeComponent();
            this.currentStudentID = studentID;
            this.rowIndex = rowIndex;
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
        // Phương thức lấy danh sách các lớp theo mã ngành
        public void LoadClassOptions(string majorID)
        {
            ClassAccess access = new ClassAccess();
            Response res = access.getListClass(majorID);
            ClassOptions.DataSource = res.data;
            ClassOptions.DisplayMember = "ClassName";
            ClassOptions.ValueMember = "ClassID";
            foreach (var item in ClassOptions.Items)
            {
                DataRowView row = item as DataRowView;
                if (row["ClassID"].ToString() == currentClassID)
                {
                    ClassOptions.SelectedItem = item;
                    break;
                }
            }
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
        private void LoadDateTime(string currentTime)
        {
            // Thêm ngày
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                    SelectDate.Items.Add("0" + i.ToString());
                else
                    SelectDate.Items.Add(i.ToString());
            }
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
            for (int i = currentYear - 50; i <= currentYear; i++)
            {
                SelectYear.Items.Add(i.ToString());
            }
            // Trỏ đến ngày sinh
            string[] parts = currentTime.Split('/');
            string day = parts[0];
            string month = parts[1];
            string year = parts[2];
            SelectDate.SelectedItem = day;
            SelectMonth.SelectedItem = month;
            SelectYear.SelectedItem = year;
        }
        private void setAddressDefault(string oldAddress)
        {
            // Ex: "Phường Bến Thuỷ, Thành phố Vinh, Tỉnh Nghệ An"
            string[] parts = oldAddress.Split(',');
            wardName = parts[0].Trim(); // Phường Bến Thuỷ
            districtName = parts[1].Trim(); // Thành phố Vinh
            provideName = parts[2].Trim(); // Tỉnh Nghệ An
            this.ProvideList.DataSource = null;
            this.DistrictList.DataSource = null;
            this.WardList.DataSource = null;
            this.ProvideList.Items.Add(provideName);
            this.DistrictList.Items.Add(districtName);
            this.WardList.Items.Add(wardName);
            this.ProvideList.SelectedIndex = 0;
            this.DistrictList.SelectedIndex = 0;
            this.WardList.SelectedIndex = 0;
        }
        private void loadStudentData(string studentID)
        {
            Response res = new Response();
            StudentAccess getdata = new StudentAccess();
            res = getdata.getStudentData(studentID);
            if (res.code == "success")
            {
                PersonID.Text = res.data.Rows[0]["PersonID"].ToString();
                studentNameBox.Text = res.data.Rows[0]["Fullname"].ToString();
                defaultBirthday = res.data.Rows[0]["Birthday"].ToString();
                gender = res.data.Rows[0]["Gender"].ToString();
                defaultAdrress = res.data.Rows[0]["Address"].ToString();
                currentMajorID = res.data.Rows[0]["MajorID"].ToString();
                currentClassID = res.data.Rows[0]["ClassID"].ToString();
                LoadDateTime(defaultBirthday);
                loadMajorOptions();
                LoadClassOptions(currentMajorID);
                loadGender(gender);
                setAddressDefault(defaultAdrress);
            }

        }
        private void loadGender(string gender)
        {
            switch (gender)
            {
                case "Nam":
                    maleGender.Checked = true; 
                    break;
                case "Nữ":
                    femaleGender.Checked = true; 
                    break;
                case "Khác":
                    otherGender.Checked = true;
                    break;
            }
        }
        // Sự kiện form load
        private void AddStudent_Load(object sender, EventArgs e)
        {
            isMonthChanged = false;
            clearValidate();
            loadStudentData(currentStudentID);
            if (useDefaultAddress.Checked)
            {
                ProvideList.Enabled = false;
                DistrictList.Enabled = false;
                WardList.Enabled = false;
            }
            else
                ProvideList.Enabled = true;
        }
        // Phương thức xử lý sự kiện thay đổi tháng
        private void SelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMonthChanged)
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
        }

        private void MajorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidate();
            DataRowView selectedMajor = MajorOptions.SelectedItem as DataRowView;
            if (selectedMajor != null && MajorOptions.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                currentMajorID = MajorOptions.SelectedValue.ToString();
                currentMajorName = selectedMajor["MajorName"].ToString();
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
    
        // 
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Request editStudent = new Request();
            Response res = new Response();
            MiddleWare handleEditStudent = new MiddleWare();
            string studentName = ToProper(studentNameBox.Text.Trim());
            string birhday = getBirthday();
            string address = getAddress();
            string personID = PersonID.Text;
            // Thêm các dữ liệu vào request
            editStudent.AddData("StudentID", currentStudentID);
            editStudent.AddData("StudentName", studentName);
            editStudent.AddData("Birthday", birhday);
            editStudent.AddData("PersonID", personID);
            editStudent.AddData("Gender", gender);
            editStudent.AddData("ClassID", currentClassID);
            editStudent.AddData("MajorID", currentMajorID);
            if (useDefaultAddress.Checked)
                editStudent.AddData("Address", defaultAdrress);
            else
                editStudent.AddData("Address", address);
            res = handleEditStudent.validateEditStudent(editStudent);
            if (res.code == "update_successfully")
            {
                parentInstance.UpdateStudentData(rowIndex, currentStudentID, studentName, birhday, gender, currentClassID, currentMajorName);
                this.Close();
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
    }
}
