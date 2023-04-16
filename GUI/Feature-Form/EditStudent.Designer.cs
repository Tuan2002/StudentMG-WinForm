using System;
using System.Windows.Forms;

namespace GUI
{
    partial class EditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.FormCaption = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.Formlabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.studentNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MajorOptions = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.femaleGender = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.maleGender = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ClassOptions = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SelectDate = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.SelectMonth = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.SelectYear = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ProvideList = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.DistrictList = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.WardList = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.EditBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.otherGender = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.formMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.studentNameError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.genderError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.majorError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.birthdayError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.addressError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.PersonID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel9 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.PersonIDError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.useDefaultAddress = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.siticoneHtmlLabel10 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = false;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormCaption.IsSelectionEnabled = false;
            this.FormCaption.Location = new System.Drawing.Point(0, 70);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(766, 23);
            this.FormCaption.TabIndex = 11;
            this.FormCaption.Text = "Thông tin sinh viên";
            this.FormCaption.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.Formlabel);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(766, 55);
            this.siticonePanel1.TabIndex = 10;
            // 
            // Formlabel
            // 
            this.Formlabel.AutoSize = false;
            this.Formlabel.BackColor = System.Drawing.Color.Transparent;
            this.Formlabel.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.Formlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Formlabel.IsSelectionEnabled = false;
            this.Formlabel.Location = new System.Drawing.Point(0, 18);
            this.Formlabel.Name = "Formlabel";
            this.Formlabel.Size = new System.Drawing.Size(766, 21);
            this.Formlabel.TabIndex = 0;
            this.Formlabel.Text = "Chỉnh sửa thông tin sinh viên";
            this.Formlabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Formlabel.UseSystemCursors = true;
            // 
            // studentNameBox
            // 
            this.studentNameBox.BorderColor = System.Drawing.Color.Plum;
            this.studentNameBox.BorderRadius = 4;
            this.studentNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentNameBox.DefaultText = "";
            this.studentNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentNameBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentNameBox.Location = new System.Drawing.Point(37, 137);
            this.studentNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.PasswordChar = '\0';
            this.studentNameBox.PlaceholderText = "Nhập họ và tên";
            this.studentNameBox.SelectedText = "";
            this.studentNameBox.Size = new System.Drawing.Size(334, 46);
            this.studentNameBox.TabIndex = 12;
            this.studentNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNameBox_KeyPress);
            // 
            // MajorOptions
            // 
            this.MajorOptions.BackColor = System.Drawing.Color.Transparent;
            this.MajorOptions.BorderColor = System.Drawing.Color.Plum;
            this.MajorOptions.BorderRadius = 4;
            this.MajorOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MajorOptions.DropDownHeight = 200;
            this.MajorOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorOptions.FocusedColor = System.Drawing.Color.Empty;
            this.MajorOptions.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MajorOptions.IntegralHeight = false;
            this.MajorOptions.ItemHeight = 40;
            this.MajorOptions.Items.AddRange(new object[] {
            "- Chọn ngành học -"});
            this.MajorOptions.Location = new System.Drawing.Point(37, 245);
            this.MajorOptions.MaxDropDownItems = 4;
            this.MajorOptions.MinimumSize = new System.Drawing.Size(200, 0);
            this.MajorOptions.Name = "MajorOptions";
            this.MajorOptions.Size = new System.Drawing.Size(334, 46);
            this.MajorOptions.TabIndex = 13;
            this.MajorOptions.SelectedIndexChanged += new System.EventHandler(this.MajorOptions_SelectedIndexChanged);
            // 
            // femaleGender
            // 
            this.femaleGender.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleGender.CheckedState.BorderThickness = 0;
            this.femaleGender.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleGender.CheckedState.InnerColor = System.Drawing.Color.White;
            this.femaleGender.Location = new System.Drawing.Point(420, 150);
            this.femaleGender.Name = "femaleGender";
            this.femaleGender.Size = new System.Drawing.Size(20, 20);
            this.femaleGender.TabIndex = 14;
            this.femaleGender.Text = "Nữ";
            this.femaleGender.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.femaleGender.UncheckedState.BorderThickness = 2;
            this.femaleGender.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.femaleGender.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.femaleGender.CheckedChanged += new System.EventHandler(this.femaleGender_CheckedChanged);
            // 
            // maleGender
            // 
            this.maleGender.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleGender.CheckedState.BorderThickness = 0;
            this.maleGender.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleGender.CheckedState.InnerColor = System.Drawing.Color.White;
            this.maleGender.Location = new System.Drawing.Point(507, 150);
            this.maleGender.Name = "maleGender";
            this.maleGender.Size = new System.Drawing.Size(20, 20);
            this.maleGender.TabIndex = 15;
            this.maleGender.Text = "Nam";
            this.maleGender.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.maleGender.UncheckedState.BorderThickness = 2;
            this.maleGender.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.maleGender.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.maleGender.CheckedChanged += new System.EventHandler(this.maleGender_CheckedChanged);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(451, 151);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(23, 20);
            this.siticoneHtmlLabel1.TabIndex = 16;
            this.siticoneHtmlLabel1.Text = "Nữ";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(539, 151);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(35, 20);
            this.siticoneHtmlLabel2.TabIndex = 17;
            this.siticoneHtmlLabel2.Text = "Nam";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.AutoSize = false;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(420, 120);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(93, 23);
            this.siticoneHtmlLabel4.TabIndex = 19;
            this.siticoneHtmlLabel4.Text = "Giới tính";
            this.siticoneHtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassOptions
            // 
            this.ClassOptions.BackColor = System.Drawing.Color.Transparent;
            this.ClassOptions.BorderColor = System.Drawing.Color.Plum;
            this.ClassOptions.BorderRadius = 4;
            this.ClassOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClassOptions.DropDownHeight = 200;
            this.ClassOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassOptions.FocusedColor = System.Drawing.Color.Empty;
            this.ClassOptions.Font = new System.Drawing.Font("Roboto", 10F);
            this.ClassOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ClassOptions.IntegralHeight = false;
            this.ClassOptions.ItemHeight = 40;
            this.ClassOptions.Items.AddRange(new object[] {
            "- Chọn ngành học -"});
            this.ClassOptions.Location = new System.Drawing.Point(399, 245);
            this.ClassOptions.MaxDropDownItems = 4;
            this.ClassOptions.MinimumSize = new System.Drawing.Size(200, 0);
            this.ClassOptions.Name = "ClassOptions";
            this.ClassOptions.Size = new System.Drawing.Size(213, 46);
            this.ClassOptions.TabIndex = 20;
            this.ClassOptions.SelectedIndexChanged += new System.EventHandler(this.ClassOptions_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.AutoSize = false;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(40, 109);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(106, 23);
            this.siticoneHtmlLabel3.TabIndex = 18;
            this.siticoneHtmlLabel3.Text = "Họ và tên";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectDate
            // 
            this.SelectDate.BackColor = System.Drawing.Color.Transparent;
            this.SelectDate.BorderColor = System.Drawing.Color.Plum;
            this.SelectDate.BorderRadius = 4;
            this.SelectDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectDate.DropDownHeight = 200;
            this.SelectDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDate.FocusedColor = System.Drawing.Color.Empty;
            this.SelectDate.Font = new System.Drawing.Font("Roboto", 10F);
            this.SelectDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectDate.IntegralHeight = false;
            this.SelectDate.ItemHeight = 40;
            this.SelectDate.Location = new System.Drawing.Point(37, 354);
            this.SelectDate.MaxDropDownItems = 4;
            this.SelectDate.MinimumSize = new System.Drawing.Size(50, 0);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(90, 46);
            this.SelectDate.TabIndex = 21;
            // 
            // SelectMonth
            // 
            this.SelectMonth.BackColor = System.Drawing.Color.Transparent;
            this.SelectMonth.BorderColor = System.Drawing.Color.Plum;
            this.SelectMonth.BorderRadius = 4;
            this.SelectMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectMonth.DropDownHeight = 200;
            this.SelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectMonth.FocusedColor = System.Drawing.Color.Empty;
            this.SelectMonth.Font = new System.Drawing.Font("Roboto", 10F);
            this.SelectMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectMonth.IntegralHeight = false;
            this.SelectMonth.ItemHeight = 40;
            this.SelectMonth.Location = new System.Drawing.Point(161, 354);
            this.SelectMonth.MaxDropDownItems = 4;
            this.SelectMonth.MinimumSize = new System.Drawing.Size(50, 0);
            this.SelectMonth.Name = "SelectMonth";
            this.SelectMonth.Size = new System.Drawing.Size(90, 46);
            this.SelectMonth.TabIndex = 22;
            this.SelectMonth.DropDown += new System.EventHandler(this.SelectMonth_DropDown);
            this.SelectMonth.SelectedIndexChanged += new System.EventHandler(this.SelectMonth_SelectedIndexChanged);
            // 
            // SelectYear
            // 
            this.SelectYear.BackColor = System.Drawing.Color.Transparent;
            this.SelectYear.BorderColor = System.Drawing.Color.Plum;
            this.SelectYear.BorderRadius = 4;
            this.SelectYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectYear.DropDownHeight = 200;
            this.SelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectYear.FocusedColor = System.Drawing.Color.Empty;
            this.SelectYear.Font = new System.Drawing.Font("Roboto", 10F);
            this.SelectYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectYear.IntegralHeight = false;
            this.SelectYear.ItemHeight = 40;
            this.SelectYear.Location = new System.Drawing.Point(281, 354);
            this.SelectYear.MaxDropDownItems = 4;
            this.SelectYear.MinimumSize = new System.Drawing.Size(50, 0);
            this.SelectYear.Name = "SelectYear";
            this.SelectYear.Size = new System.Drawing.Size(130, 46);
            this.SelectYear.TabIndex = 23;
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.AutoSize = false;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(40, 324);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(106, 23);
            this.siticoneHtmlLabel5.TabIndex = 24;
            this.siticoneHtmlLabel5.Text = "Ngày sinh";
            this.siticoneHtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProvideList
            // 
            this.ProvideList.BackColor = System.Drawing.Color.Transparent;
            this.ProvideList.BorderColor = System.Drawing.Color.Plum;
            this.ProvideList.BorderRadius = 4;
            this.ProvideList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProvideList.DropDownHeight = 200;
            this.ProvideList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvideList.FocusedColor = System.Drawing.Color.Empty;
            this.ProvideList.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProvideList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ProvideList.IntegralHeight = false;
            this.ProvideList.ItemHeight = 40;
            this.ProvideList.Location = new System.Drawing.Point(37, 461);
            this.ProvideList.MaxDropDownItems = 4;
            this.ProvideList.MinimumSize = new System.Drawing.Size(200, 0);
            this.ProvideList.Name = "ProvideList";
            this.ProvideList.Size = new System.Drawing.Size(214, 46);
            this.ProvideList.TabIndex = 25;
            this.ProvideList.DropDown += new System.EventHandler(this.ProvideList_DropDown);
            this.ProvideList.SelectedIndexChanged += new System.EventHandler(this.ProvideList_SelectedIndexChanged);
            // 
            // DistrictList
            // 
            this.DistrictList.BackColor = System.Drawing.Color.Transparent;
            this.DistrictList.BorderColor = System.Drawing.Color.Plum;
            this.DistrictList.BorderRadius = 4;
            this.DistrictList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DistrictList.DropDownHeight = 200;
            this.DistrictList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DistrictList.Enabled = false;
            this.DistrictList.FocusedColor = System.Drawing.Color.Empty;
            this.DistrictList.Font = new System.Drawing.Font("Roboto", 10F);
            this.DistrictList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DistrictList.IntegralHeight = false;
            this.DistrictList.ItemHeight = 40;
            this.DistrictList.Location = new System.Drawing.Point(272, 461);
            this.DistrictList.MaxDropDownItems = 4;
            this.DistrictList.MinimumSize = new System.Drawing.Size(200, 0);
            this.DistrictList.Name = "DistrictList";
            this.DistrictList.Size = new System.Drawing.Size(214, 46);
            this.DistrictList.TabIndex = 26;
            this.DistrictList.SelectedIndexChanged += new System.EventHandler(this.DistrictList_SelectedIndexChanged);
            // 
            // WardList
            // 
            this.WardList.BackColor = System.Drawing.Color.Transparent;
            this.WardList.BorderColor = System.Drawing.Color.Plum;
            this.WardList.BorderRadius = 4;
            this.WardList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.WardList.DropDownHeight = 200;
            this.WardList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WardList.Enabled = false;
            this.WardList.FocusedColor = System.Drawing.Color.Empty;
            this.WardList.Font = new System.Drawing.Font("Roboto", 10F);
            this.WardList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.WardList.IntegralHeight = false;
            this.WardList.ItemHeight = 40;
            this.WardList.Location = new System.Drawing.Point(505, 461);
            this.WardList.MaxDropDownItems = 4;
            this.WardList.MinimumSize = new System.Drawing.Size(200, 0);
            this.WardList.Name = "WardList";
            this.WardList.Size = new System.Drawing.Size(214, 46);
            this.WardList.TabIndex = 27;
            this.WardList.SelectedIndexChanged += new System.EventHandler(this.WardList_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.AutoSize = false;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(40, 431);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(71, 23);
            this.siticoneHtmlLabel6.TabIndex = 28;
            this.siticoneHtmlLabel6.Text = "Địa chỉ";
            this.siticoneHtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.AutoSize = false;
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(40, 216);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(211, 23);
            this.siticoneHtmlLabel7.TabIndex = 29;
            this.siticoneHtmlLabel7.Text = "Thông tin ngành học";
            this.siticoneHtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditBtn
            // 
            this.EditBtn.BorderRadius = 4;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(571, 607);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(130, 45);
            this.EditBtn.TabIndex = 30;
            this.EditBtn.Text = "Chỉnh sửa";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderRadius = 4;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(406, 607);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(130, 45);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Huỷ bỏ";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // siticoneHtmlLabel8
            // 
            this.siticoneHtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.siticoneHtmlLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneHtmlLabel8.Location = new System.Drawing.Point(638, 151);
            this.siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            this.siticoneHtmlLabel8.Size = new System.Drawing.Size(36, 20);
            this.siticoneHtmlLabel8.TabIndex = 33;
            this.siticoneHtmlLabel8.Text = "Khác";
            // 
            // otherGender
            // 
            this.otherGender.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otherGender.CheckedState.BorderThickness = 0;
            this.otherGender.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otherGender.CheckedState.InnerColor = System.Drawing.Color.White;
            this.otherGender.Location = new System.Drawing.Point(606, 150);
            this.otherGender.Name = "otherGender";
            this.otherGender.Size = new System.Drawing.Size(20, 20);
            this.otherGender.TabIndex = 32;
            this.otherGender.Text = "Khác";
            this.otherGender.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.otherGender.UncheckedState.BorderThickness = 2;
            this.otherGender.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.otherGender.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.otherGender.CheckedChanged += new System.EventHandler(this.otherGender_CheckedChanged);
            // 
            // formMessage
            // 
            this.formMessage.AutoSize = false;
            this.formMessage.BackColor = System.Drawing.Color.Transparent;
            this.formMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.formMessage.ForeColor = System.Drawing.Color.Red;
            this.formMessage.Location = new System.Drawing.Point(0, 566);
            this.formMessage.Name = "formMessage";
            this.formMessage.Size = new System.Drawing.Size(766, 22);
            this.formMessage.TabIndex = 34;
            this.formMessage.Text = "Sinh viên này đã có trên hệ thống";
            this.formMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameError
            // 
            this.studentNameError.AutoSize = false;
            this.studentNameError.BackColor = System.Drawing.Color.Transparent;
            this.studentNameError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.studentNameError.ForeColor = System.Drawing.Color.Red;
            this.studentNameError.Location = new System.Drawing.Point(40, 188);
            this.studentNameError.Name = "studentNameError";
            this.studentNameError.Size = new System.Drawing.Size(289, 22);
            this.studentNameError.TabIndex = 35;
            this.studentNameError.Text = "Vui lòng nhập họ tên sinh viên";
            this.studentNameError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderError
            // 
            this.genderError.AutoSize = false;
            this.genderError.BackColor = System.Drawing.Color.Transparent;
            this.genderError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.genderError.ForeColor = System.Drawing.Color.Red;
            this.genderError.Location = new System.Drawing.Point(420, 188);
            this.genderError.Name = "genderError";
            this.genderError.Size = new System.Drawing.Size(289, 22);
            this.genderError.TabIndex = 36;
            this.genderError.Text = "Chưa chọn giới tính";
            this.genderError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // majorError
            // 
            this.majorError.AutoSize = false;
            this.majorError.BackColor = System.Drawing.Color.Transparent;
            this.majorError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.majorError.ForeColor = System.Drawing.Color.Red;
            this.majorError.Location = new System.Drawing.Point(40, 296);
            this.majorError.Name = "majorError";
            this.majorError.Size = new System.Drawing.Size(572, 22);
            this.majorError.TabIndex = 37;
            this.majorError.Text = "Chưa chọn ngành học và lớp học";
            this.majorError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birthdayError
            // 
            this.birthdayError.AutoSize = false;
            this.birthdayError.BackColor = System.Drawing.Color.Transparent;
            this.birthdayError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.birthdayError.ForeColor = System.Drawing.Color.Red;
            this.birthdayError.Location = new System.Drawing.Point(40, 406);
            this.birthdayError.Name = "birthdayError";
            this.birthdayError.Size = new System.Drawing.Size(289, 22);
            this.birthdayError.TabIndex = 38;
            this.birthdayError.Text = "Chưa chọn ngày sinh";
            this.birthdayError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressError
            // 
            this.addressError.AutoSize = false;
            this.addressError.BackColor = System.Drawing.Color.Transparent;
            this.addressError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addressError.ForeColor = System.Drawing.Color.Red;
            this.addressError.Location = new System.Drawing.Point(40, 513);
            this.addressError.Name = "addressError";
            this.addressError.Size = new System.Drawing.Size(289, 22);
            this.addressError.TabIndex = 39;
            this.addressError.Text = "Chưa chọn địa chỉ";
            this.addressError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonID
            // 
            this.PersonID.BorderColor = System.Drawing.Color.Plum;
            this.PersonID.BorderRadius = 4;
            this.PersonID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PersonID.DefaultText = "";
            this.PersonID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PersonID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PersonID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PersonID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PersonID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PersonID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonID.Location = new System.Drawing.Point(451, 354);
            this.PersonID.Margin = new System.Windows.Forms.Padding(5);
            this.PersonID.Name = "PersonID";
            this.PersonID.PasswordChar = '\0';
            this.PersonID.PlaceholderText = "Nhập số CCCD";
            this.PersonID.SelectedText = "";
            this.PersonID.Size = new System.Drawing.Size(268, 46);
            this.PersonID.TabIndex = 40;
            this.PersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonID_KeyPress);
            // 
            // siticoneHtmlLabel9
            // 
            this.siticoneHtmlLabel9.AutoSize = false;
            this.siticoneHtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel9.Location = new System.Drawing.Point(455, 324);
            this.siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
            this.siticoneHtmlLabel9.Size = new System.Drawing.Size(171, 23);
            this.siticoneHtmlLabel9.TabIndex = 41;
            this.siticoneHtmlLabel9.Text = "Số CCCD/CMND";
            this.siticoneHtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonIDError
            // 
            this.PersonIDError.AutoSize = false;
            this.PersonIDError.BackColor = System.Drawing.Color.Transparent;
            this.PersonIDError.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PersonIDError.ForeColor = System.Drawing.Color.Red;
            this.PersonIDError.Location = new System.Drawing.Point(455, 406);
            this.PersonIDError.Name = "PersonIDError";
            this.PersonIDError.Size = new System.Drawing.Size(289, 22);
            this.PersonIDError.TabIndex = 42;
            this.PersonIDError.Text = "Số CCCD không được để trống";
            this.PersonIDError.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.Formlabel;
            this.siticoneDragControl1.TransparentWhileDrag = false;
            // 
            // useDefaultAddress
            // 
            this.useDefaultAddress.Checked = true;
            this.useDefaultAddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.useDefaultAddress.CheckedState.BorderRadius = 2;
            this.useDefaultAddress.CheckedState.BorderThickness = 0;
            this.useDefaultAddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.useDefaultAddress.Location = new System.Drawing.Point(40, 541);
            this.useDefaultAddress.Name = "useDefaultAddress";
            this.useDefaultAddress.Size = new System.Drawing.Size(19, 20);
            this.useDefaultAddress.TabIndex = 43;
            this.useDefaultAddress.Text = "Dùng ảnh mặc định";
            this.useDefaultAddress.UncheckedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.useDefaultAddress.UncheckedState.BorderRadius = 4;
            this.useDefaultAddress.UncheckedState.BorderThickness = 1;
            this.useDefaultAddress.UncheckedState.FillColor = System.Drawing.Color.White;
            this.useDefaultAddress.Click += new System.EventHandler(this.useDefaultAddress_Click);
            // 
            // siticoneHtmlLabel10
            // 
            this.siticoneHtmlLabel10.AutoSize = false;
            this.siticoneHtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel10.Location = new System.Drawing.Point(69, 540);
            this.siticoneHtmlLabel10.Name = "siticoneHtmlLabel10";
            this.siticoneHtmlLabel10.Size = new System.Drawing.Size(154, 23);
            this.siticoneHtmlLabel10.TabIndex = 44;
            this.siticoneHtmlLabel10.Text = "Sử dụng địa chỉ cũ";
            this.siticoneHtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 678);
            this.Controls.Add(this.siticoneHtmlLabel10);
            this.Controls.Add(this.useDefaultAddress);
            this.Controls.Add(this.PersonIDError);
            this.Controls.Add(this.siticoneHtmlLabel9);
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.addressError);
            this.Controls.Add(this.birthdayError);
            this.Controls.Add(this.majorError);
            this.Controls.Add(this.genderError);
            this.Controls.Add(this.studentNameError);
            this.Controls.Add(this.formMessage);
            this.Controls.Add(this.siticoneHtmlLabel8);
            this.Controls.Add(this.otherGender);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.siticoneHtmlLabel7);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.WardList);
            this.Controls.Add(this.DistrictList);
            this.Controls.Add(this.ProvideList);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.SelectYear);
            this.Controls.Add(this.SelectMonth);
            this.Controls.Add(this.SelectDate);
            this.Controls.Add(this.ClassOptions);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.maleGender);
            this.Controls.Add(this.femaleGender);
            this.Controls.Add(this.MajorOptions);
            this.Controls.Add(this.studentNameBox);
            this.Controls.Add(this.FormCaption);
            this.Controls.Add(this.siticonePanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectMonth_DropDown(object sender, EventArgs e)
        {
            isMonthChanged = true;
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

        private void useDefaultAddress_Click(object sender, EventArgs e)
        {
            if (useDefaultAddress.Checked)
            {
                setAddressDefault(defaultAdrress);
                ProvideList.Enabled = false;
                DistrictList.Enabled = false;
                WardList.Enabled = false;
            }
            else
                ProvideList.Enabled = true;
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
        private void StudentNameBox_GotFocus(object sender, System.EventArgs e)
        {
            clearValidate();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel FormCaption;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Formlabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox studentNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton maleGender;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton femaleGender;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox MajorOptions;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ProvideList;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SelectYear;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SelectMonth;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SelectDate;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ClassOptions;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox WardList;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox DistrictList;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton EditBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton otherGender;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel addressError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel birthdayError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel majorError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel genderError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel studentNameError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel formMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel9;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PersonID;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel PersonIDError;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel10;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox useDefaultAddress;
    }
}