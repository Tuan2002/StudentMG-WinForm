using System.Windows.Forms;

namespace GUI
{
    partial class ClassMG
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
            this.removeClassBtn = new FontAwesome.Sharp.IconButton();
            this.addClassBtn = new FontAwesome.Sharp.IconButton();
            this.ClassList = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SearchInputEvent = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).BeginInit();
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
            this.siticonePanel1.Controls.Add(this.removeClassBtn);
            this.siticonePanel1.Controls.Add(this.addClassBtn);
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
            this.waitProgess.Location = new System.Drawing.Point(213, 17);
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
            this.searchBox.PlaceholderText = "Tìm lớp học";
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
            // removeClassBtn
            // 
            this.removeClassBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.removeClassBtn.FlatAppearance.BorderSize = 0;
            this.removeClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeClassBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeClassBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeClassBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removeClassBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.removeClassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeClassBtn.IconSize = 20;
            this.removeClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeClassBtn.Location = new System.Drawing.Point(138, 10);
            this.removeClassBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeClassBtn.Name = "removeClassBtn";
            this.removeClassBtn.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removeClassBtn.Size = new System.Drawing.Size(102, 40);
            this.removeClassBtn.TabIndex = 1;
            this.removeClassBtn.Text = "Xoá bỏ";
            this.removeClassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeClassBtn.UseVisualStyleBackColor = false;
            this.removeClassBtn.Click += new System.EventHandler(this.removeClassBtn_Click);
            // 
            // addClassBtn
            // 
            this.addClassBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addClassBtn.FlatAppearance.BorderSize = 0;
            this.addClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClassBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addClassBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addClassBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.addClassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addClassBtn.IconSize = 20;
            this.addClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClassBtn.Location = new System.Drawing.Point(11, 10);
            this.addClassBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Padding = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.addClassBtn.Size = new System.Drawing.Size(114, 40);
            this.addClassBtn.TabIndex = 0;
            this.addClassBtn.Text = "Thêm mới";
            this.addClassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addClassBtn.UseVisualStyleBackColor = false;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // ClassList
            // 
            this.ClassList.AllowUserToAddRows = false;
            this.ClassList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ClassList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClassList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClassList.ColumnHeadersHeight = 40;
            this.ClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.MajorName,
            this.Actions});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassList.DefaultCellStyle = dataGridViewCellStyle7;
            this.ClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.ClassList.Location = new System.Drawing.Point(0, 0);
            this.ClassList.Name = "ClassList";
            this.ClassList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ClassList.RowHeadersVisible = false;
            this.ClassList.RowHeadersWidth = 40;
            this.ClassList.RowTemplate.Height = 40;
            this.ClassList.RowTemplate.ReadOnly = true;
            this.ClassList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassList.Size = new System.Drawing.Size(975, 474);
            this.ClassList.TabIndex = 1;
            this.ClassList.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.ClassList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ClassList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClassList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClassList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClassList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClassList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClassList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.ClassList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ClassList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClassList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClassList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClassList.ThemeStyle.HeaderStyle.Height = 40;
            this.ClassList.ThemeStyle.ReadOnly = true;
            this.ClassList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.ClassList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClassList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ClassList.ThemeStyle.RowsStyle.Height = 40;
            this.ClassList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.ClassList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClassList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellClick);
            this.ClassList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userList_CellFormatting);
            // 
            // ClassID
            // 
            this.ClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassID.Frozen = true;
            this.ClassID.HeaderText = "Mã lớp học";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 150;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Tên lớp học";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // MajorName
            // 
            this.MajorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MajorName.HeaderText = "Tên ngành học";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            this.MajorName.Width = 350;
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
            this.Actions.Width = 150;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.ClassList);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 62);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(975, 474);
            this.siticonePanel3.TabIndex = 2;
            // 
            // SearchInputEvent
            // 
            this.SearchInputEvent.Interval = 1500;
            this.SearchInputEvent.Tick += new System.EventHandler(this.SearchInputEventEnd);
            // 
            // ClassMG
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
            this.Name = "ClassMG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserMG";
            this.Load += new System.EventHandler(this.ClassMG_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).EndInit();
            this.siticonePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private FontAwesome.Sharp.IconButton addClassBtn;
        private FontAwesome.Sharp.IconButton removeClassBtn;
        private FontAwesome.Sharp.IconButton refeshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton searchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView ClassList;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox MajorOptions;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar dataLoading;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar waitProgess;
        private DataGridViewTextBoxColumn ClassID;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn MajorName;
        private DataGridViewButtonColumn Actions;
        private Timer SearchInputEvent;
    }
}