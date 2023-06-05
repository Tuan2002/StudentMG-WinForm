using System.Windows.Forms;

namespace GUI
{
    partial class StudentMG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dataLoading = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.MajorOptions = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.waitProgess = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.searchBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.searchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.refeshBtn = new FontAwesome.Sharp.IconButton();
            this.removeStudentBtn = new FontAwesome.Sharp.IconButton();
            this.addStudentBtn = new FontAwesome.Sharp.IconButton();
            this.StudentList = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SearchInputEvent = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.DragForm = false;
            this.siticoneBorderlessForm1.HasFormShadow = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.dataLoading);
            this.siticonePanel1.Controls.Add(this.MajorOptions);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.refeshBtn);
            this.siticonePanel1.Controls.Add(this.removeStudentBtn);
            this.siticonePanel1.Controls.Add(this.addStudentBtn);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(975, 62);
            this.siticonePanel1.TabIndex = 0;
            // 
            // dataLoading
            // 
            this.dataLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLoading.Animated = true;
            this.dataLoading.AnimationSpeed = 1.5F;
            this.dataLoading.BackColor = System.Drawing.Color.Transparent;
            this.dataLoading.FillColor = System.Drawing.Color.Transparent;
            this.dataLoading.FillThickness = 3;
            this.dataLoading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataLoading.ForeColor = System.Drawing.Color.Transparent;
            this.dataLoading.Location = new System.Drawing.Point(588, 15);
            this.dataLoading.Minimum = 0;
            this.dataLoading.Name = "dataLoading";
            this.dataLoading.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.dataLoading.ProgressColor2 = System.Drawing.Color.WhiteSmoke;
            this.dataLoading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.dataLoading.ProgressThickness = 3;
            this.dataLoading.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.dataLoading.Size = new System.Drawing.Size(31, 31);
            this.dataLoading.TabIndex = 16;
            this.dataLoading.Text = "siticoneCircleProgressBar1";
            this.dataLoading.UseTransparentBackground = true;
            this.dataLoading.Value = 60;
            this.dataLoading.Visible = false;
            // 
            // MajorOptions
            // 
            this.MajorOptions.BackColor = System.Drawing.Color.Transparent;
            this.MajorOptions.BorderRadius = 4;
            this.MajorOptions.DisabledState.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MajorOptions.DropDownHeight = 300;
            this.MajorOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorOptions.FocusedColor = System.Drawing.Color.Transparent;
            this.MajorOptions.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.MajorOptions.FocusedState.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.ForeColor = System.Drawing.Color.DimGray;
            this.MajorOptions.HoverState.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.IntegralHeight = false;
            this.MajorOptions.ItemHeight = 40;
            this.MajorOptions.Items.AddRange(new object[] {
            "Tất cả các ngành"});
            this.MajorOptions.ItemsAppearance.Font = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.ItemsAppearance.SelectedFont = new System.Drawing.Font("Roboto", 10F);
            this.MajorOptions.Location = new System.Drawing.Point(370, 10);
            this.MajorOptions.MaxDropDownItems = 5;
            this.MajorOptions.MinimumSize = new System.Drawing.Size(150, 0);
            this.MajorOptions.Name = "MajorOptions";
            this.MajorOptions.Size = new System.Drawing.Size(200, 46);
            this.MajorOptions.TabIndex = 0;
            this.MajorOptions.SelectedIndexChanged += new System.EventHandler(this.MajorOptions_SelectedIndexChanged);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.waitProgess);
            this.siticonePanel2.Controls.Add(this.searchBox);
            this.siticonePanel2.Controls.Add(this.searchBtn);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(695, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(280, 62);
            this.siticonePanel2.TabIndex = 3;
            // 
            // waitProgess
            // 
            this.waitProgess.Animated = true;
            this.waitProgess.AnimationSpeed = 1F;
            this.waitProgess.BackColor = System.Drawing.Color.Transparent;
            this.waitProgess.FillColor = System.Drawing.Color.Transparent;
            this.waitProgess.FillThickness = 4;
            this.waitProgess.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.waitProgess.ForeColor = System.Drawing.Color.Transparent;
            this.waitProgess.Location = new System.Drawing.Point(212, 17);
            this.waitProgess.Minimum = 0;
            this.waitProgess.Name = "waitProgess";
            this.waitProgess.ProgressColor = System.Drawing.Color.White;
            this.waitProgess.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.waitProgess.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.waitProgess.ProgressThickness = 4;
            this.waitProgess.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.waitProgess.Size = new System.Drawing.Size(25, 25);
            this.waitProgess.TabIndex = 15;
            this.waitProgess.Text = "siticoneCircleProgressBar1";
            this.waitProgess.UseTransparentBackground = true;
            this.waitProgess.Value = 30;
            this.waitProgess.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.BorderColor = System.Drawing.Color.MediumOrchid;
            this.searchBox.BorderRadius = 10;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(19, 10);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.PlaceholderText = "Tìm sinh viên";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(150, 39);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BorderRadius = 8;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.Font = new System.Drawing.Font("Roboto", 9F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(178, 10);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(91, 40);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Tìm kiếm";
            // 
            // refeshBtn
            // 
            this.refeshBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.refeshBtn.FlatAppearance.BorderSize = 0;
            this.refeshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refeshBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refeshBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refeshBtn.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.refeshBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.refeshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refeshBtn.IconSize = 20;
            this.refeshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refeshBtn.Location = new System.Drawing.Point(252, 10);
            this.refeshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Padding = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.refeshBtn.Size = new System.Drawing.Size(102, 40);
            this.refeshBtn.TabIndex = 2;
            this.refeshBtn.Text = "Làm mới";
            this.refeshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refeshBtn.UseVisualStyleBackColor = false;
            this.refeshBtn.Click += new System.EventHandler(this.refeshBtn_Click);
            // 
            // removeStudentBtn
            // 
            this.removeStudentBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.removeStudentBtn.FlatAppearance.BorderSize = 0;
            this.removeStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStudentBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudentBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeStudentBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removeStudentBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.removeStudentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeStudentBtn.IconSize = 20;
            this.removeStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeStudentBtn.Location = new System.Drawing.Point(138, 10);
            this.removeStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeStudentBtn.Name = "removeStudentBtn";
            this.removeStudentBtn.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removeStudentBtn.Size = new System.Drawing.Size(102, 40);
            this.removeStudentBtn.TabIndex = 1;
            this.removeStudentBtn.Text = "Xoá bỏ";
            this.removeStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeStudentBtn.UseVisualStyleBackColor = false;
            this.removeStudentBtn.Click += new System.EventHandler(this.removeClassBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addStudentBtn.FlatAppearance.BorderSize = 0;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addStudentBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addStudentBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.addStudentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addStudentBtn.IconSize = 20;
            this.addStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentBtn.Location = new System.Drawing.Point(11, 10);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Padding = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.addStudentBtn.Size = new System.Drawing.Size(114, 40);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Thêm mới";
            this.addStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // StudentList
            // 
            this.StudentList.AllowUserToAddRows = false;
            this.StudentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentList.ColumnHeadersHeight = 40;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Birthday,
            this.Gender,
            this.ClassID,
            this.MajorName,
            this.Actions});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentList.DefaultCellStyle = dataGridViewCellStyle7;
            this.StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.StudentList.Location = new System.Drawing.Point(0, 0);
            this.StudentList.Name = "StudentList";
            this.StudentList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StudentList.RowHeadersVisible = false;
            this.StudentList.RowHeadersWidth = 40;
            this.StudentList.RowTemplate.Height = 40;
            this.StudentList.RowTemplate.ReadOnly = true;
            this.StudentList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentList.Size = new System.Drawing.Size(975, 474);
            this.StudentList.TabIndex = 1;
            this.StudentList.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.StudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.StudentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.StudentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentList.ThemeStyle.HeaderStyle.Height = 40;
            this.StudentList.ThemeStyle.ReadOnly = true;
            this.StudentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.StudentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.StudentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StudentList.ThemeStyle.RowsStyle.Height = 40;
            this.StudentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.StudentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellClick);
            this.StudentList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userList_CellFormatting);
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentID.Frozen = true;
            this.StudentID.HeaderText = "Mã sinh viên";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Họ và tên";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 120;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 102;
            // 
            // ClassID
            // 
            this.ClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassID.HeaderText = "Lớp học";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 112;
            // 
            // MajorName
            // 
            this.MajorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MajorName.HeaderText = "Ngành học";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            this.MajorName.Width = 220;
            // 
            // Actions
            // 
            this.Actions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Actions.FillWeight = 50F;
            this.Actions.HeaderText = "Thao tác";
            this.Actions.MinimumWidth = 50;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.StudentList);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 62);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(975, 474);
            this.siticonePanel3.TabIndex = 2;
            // 
            // SearchInputEvent
            // 
            this.SearchInputEvent.Interval = 1000;
            this.SearchInputEvent.Tick += new System.EventHandler(this.SearchInputEventEnd);
            // 
            // StudentMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentMG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserMG";
            this.Load += new System.EventHandler(this.StudentMG_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            this.siticonePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private FontAwesome.Sharp.IconButton addStudentBtn;
        private FontAwesome.Sharp.IconButton removeStudentBtn;
        private FontAwesome.Sharp.IconButton refeshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton searchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView StudentList;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox MajorOptions;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar dataLoading;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar waitProgess;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn ClassID;
        private DataGridViewTextBoxColumn MajorName;
        private DataGridViewButtonColumn Actions;
        private Timer SearchInputEvent;
    }
}