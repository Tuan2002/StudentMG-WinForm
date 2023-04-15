using System.Windows.Forms;

namespace GUI
{
    partial class UserMG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dataLoading = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.waitProgess = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.searchBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.searchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.refeshBtn = new FontAwesome.Sharp.IconButton();
            this.removeUserBtn = new FontAwesome.Sharp.IconButton();
            this.addUserBtn = new FontAwesome.Sharp.IconButton();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SearchInputEvent = new System.Windows.Forms.Timer(this.components);
            this.userList = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
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
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.refeshBtn);
            this.siticonePanel1.Controls.Add(this.removeUserBtn);
            this.siticonePanel1.Controls.Add(this.addUserBtn);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(746, 62);
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
            this.dataLoading.Location = new System.Drawing.Point(374, 15);
            this.dataLoading.Minimum = 0;
            this.dataLoading.Name = "dataLoading";
            this.dataLoading.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.dataLoading.ProgressColor2 = System.Drawing.Color.WhiteSmoke;
            this.dataLoading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.dataLoading.ProgressThickness = 3;
            this.dataLoading.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.dataLoading.Size = new System.Drawing.Size(31, 31);
            this.dataLoading.TabIndex = 14;
            this.dataLoading.Text = "siticoneCircleProgressBar1";
            this.dataLoading.UseTransparentBackground = true;
            this.dataLoading.Value = 60;
            this.dataLoading.Visible = false;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.waitProgess);
            this.siticonePanel2.Controls.Add(this.searchBox);
            this.siticonePanel2.Controls.Add(this.searchBtn);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(436, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(310, 62);
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
            this.waitProgess.Location = new System.Drawing.Point(242, 19);
            this.waitProgess.Minimum = 0;
            this.waitProgess.Name = "waitProgess";
            this.waitProgess.ProgressColor = System.Drawing.Color.White;
            this.waitProgess.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.waitProgess.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.waitProgess.ProgressThickness = 4;
            this.waitProgess.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.waitProgess.Size = new System.Drawing.Size(25, 25);
            this.waitProgess.TabIndex = 13;
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
            this.searchBox.Location = new System.Drawing.Point(13, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.PlaceholderText = "Tìm người dùng";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(190, 39);
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
            this.searchBtn.Location = new System.Drawing.Point(208, 10);
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
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.removeUserBtn.FlatAppearance.BorderSize = 0;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeUserBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removeUserBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.removeUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeUserBtn.IconSize = 20;
            this.removeUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUserBtn.Location = new System.Drawing.Point(138, 10);
            this.removeUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removeUserBtn.Size = new System.Drawing.Size(102, 40);
            this.removeUserBtn.TabIndex = 1;
            this.removeUserBtn.Text = "Xoá bỏ";
            this.removeUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeUserBtn.UseVisualStyleBackColor = false;
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addUserBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addUserBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addUserBtn.IconSize = 20;
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.Location = new System.Drawing.Point(11, 10);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Padding = new System.Windows.Forms.Padding(4, 0, 6, 0);
            this.addUserBtn.Size = new System.Drawing.Size(114, 40);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Thêm mới";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.userList);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 62);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(746, 412);
            this.siticonePanel3.TabIndex = 2;
            // 
            // SearchInputEvent
            // 
            this.SearchInputEvent.Interval = 1000;
            this.SearchInputEvent.Tick += new System.EventHandler(this.SearchInputEventEnd);
            // 
            // userList
            // 
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.userList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userList.ColumnHeadersHeight = 40;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.passWord,
            this.userEmail,
            this.Actions});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userList.DefaultCellStyle = dataGridViewCellStyle3;
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userList.RowHeadersVisible = false;
            this.userList.RowHeadersWidth = 40;
            this.userList.RowTemplate.Height = 40;
            this.userList.RowTemplate.ReadOnly = true;
            this.userList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userList.Size = new System.Drawing.Size(746, 412);
            this.userList.TabIndex = 2;
            this.userList.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.userList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.userList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.userList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.userList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userList.ThemeStyle.HeaderStyle.Height = 40;
            this.userList.ThemeStyle.ReadOnly = true;
            this.userList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.userList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.userList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userList.ThemeStyle.RowsStyle.Height = 40;
            this.userList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.userList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellClick);
            this.userList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userList_CellFormatting);
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userName.Frozen = true;
            this.userName.HeaderText = "Tên người dùng";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 200;
            // 
            // passWord
            // 
            this.passWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.passWord.HeaderText = "Mật khẩu";
            this.passWord.Name = "passWord";
            this.passWord.ReadOnly = true;
            this.passWord.Width = 200;
            // 
            // userEmail
            // 
            this.userEmail.HeaderText = "Email";
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
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
            // UserMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(746, 474);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserMG";
            this.Load += new System.EventHandler(this.UserMG_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private FontAwesome.Sharp.IconButton addUserBtn;
        private FontAwesome.Sharp.IconButton removeUserBtn;
        private FontAwesome.Sharp.IconButton refeshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton searchBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchBox;
        private Timer SearchInputEvent;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar waitProgess;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar dataLoading;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView userList;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn passWord;
        private DataGridViewTextBoxColumn userEmail;
        private DataGridViewButtonColumn Actions;
    }
}