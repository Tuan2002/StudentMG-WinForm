namespace GUI
{
    partial class AddUser
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userFullNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userEmailBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userPasswordConfirm = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.permissionSelect = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.avatarPreview = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.selectImageBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 10;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.siticoneButton1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(283, 13);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(141, 45);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Huỷ bỏ";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton2.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.ForestGreen;
            this.siticoneButton2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(455, 13);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(141, 45);
            this.siticoneButton2.TabIndex = 1;
            this.siticoneButton2.Text = "Thêm";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneButton2);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 493);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(654, 70);
            this.siticonePanel1.TabIndex = 2;
            // 
            // userNameBox
            // 
            this.userNameBox.BorderColor = System.Drawing.Color.Plum;
            this.userNameBox.BorderRadius = 10;
            this.userNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameBox.DefaultText = "";
            this.userNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameBox.FillColor = System.Drawing.Color.MintCream;
            this.userNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.userNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameBox.Location = new System.Drawing.Point(40, 84);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.PasswordChar = '\0';
            this.userNameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userNameBox.PlaceholderText = "Nhập tên người dùng";
            this.userNameBox.SelectedText = "";
            this.userNameBox.Size = new System.Drawing.Size(250, 36);
            this.userNameBox.TabIndex = 3;
            // 
            // userFullNameBox
            // 
            this.userFullNameBox.BorderColor = System.Drawing.Color.Plum;
            this.userFullNameBox.BorderRadius = 10;
            this.userFullNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userFullNameBox.DefaultText = "";
            this.userFullNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userFullNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userFullNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userFullNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userFullNameBox.FillColor = System.Drawing.Color.MintCream;
            this.userFullNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userFullNameBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.userFullNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userFullNameBox.Location = new System.Drawing.Point(40, 156);
            this.userFullNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userFullNameBox.Name = "userFullNameBox";
            this.userFullNameBox.PasswordChar = '\0';
            this.userFullNameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userFullNameBox.PlaceholderText = "Nhập tên đầy đủ";
            this.userFullNameBox.SelectedText = "";
            this.userFullNameBox.Size = new System.Drawing.Size(250, 36);
            this.userFullNameBox.TabIndex = 4;
            // 
            // userEmailBox
            // 
            this.userEmailBox.BorderColor = System.Drawing.Color.Plum;
            this.userEmailBox.BorderRadius = 10;
            this.userEmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userEmailBox.DefaultText = "";
            this.userEmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userEmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userEmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userEmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userEmailBox.FillColor = System.Drawing.Color.MintCream;
            this.userEmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userEmailBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.userEmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userEmailBox.Location = new System.Drawing.Point(40, 228);
            this.userEmailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userEmailBox.Name = "userEmailBox";
            this.userEmailBox.PasswordChar = '\0';
            this.userEmailBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userEmailBox.PlaceholderText = "Nhập Email";
            this.userEmailBox.SelectedText = "";
            this.userEmailBox.Size = new System.Drawing.Size(250, 36);
            this.userEmailBox.TabIndex = 5;
            // 
            // userPassword
            // 
            this.userPassword.BorderColor = System.Drawing.Color.Plum;
            this.userPassword.BorderRadius = 10;
            this.userPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPassword.DefaultText = "";
            this.userPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPassword.FillColor = System.Drawing.Color.MintCream;
            this.userPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.userPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPassword.Location = new System.Drawing.Point(40, 300);
            this.userPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '●';
            this.userPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userPassword.PlaceholderText = "Nhập mật khẩu";
            this.userPassword.SelectedText = "";
            this.userPassword.Size = new System.Drawing.Size(250, 36);
            this.userPassword.TabIndex = 6;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // userPasswordConfirm
            // 
            this.userPasswordConfirm.BorderColor = System.Drawing.Color.Plum;
            this.userPasswordConfirm.BorderRadius = 10;
            this.userPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPasswordConfirm.DefaultText = "";
            this.userPasswordConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userPasswordConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userPasswordConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPasswordConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPasswordConfirm.FillColor = System.Drawing.Color.MintCream;
            this.userPasswordConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPasswordConfirm.Font = new System.Drawing.Font("Roboto", 10F);
            this.userPasswordConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPasswordConfirm.Location = new System.Drawing.Point(40, 374);
            this.userPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPasswordConfirm.Name = "userPasswordConfirm";
            this.userPasswordConfirm.PasswordChar = '●';
            this.userPasswordConfirm.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userPasswordConfirm.PlaceholderText = "Nhập lại mật khẩu";
            this.userPasswordConfirm.SelectedText = "";
            this.userPasswordConfirm.Size = new System.Drawing.Size(250, 36);
            this.userPasswordConfirm.TabIndex = 7;
            this.userPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // permissionSelect
            // 
            this.permissionSelect.BackColor = System.Drawing.Color.Transparent;
            this.permissionSelect.BorderColor = System.Drawing.Color.Plum;
            this.permissionSelect.BorderRadius = 10;
            this.permissionSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.permissionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.permissionSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.permissionSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.permissionSelect.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.permissionSelect.ItemHeight = 30;
            this.permissionSelect.Items.AddRange(new object[] {
            "-- Chọn quyền người dùng --"});
            this.permissionSelect.Location = new System.Drawing.Point(364, 84);
            this.permissionSelect.Name = "permissionSelect";
            this.permissionSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.permissionSelect.Size = new System.Drawing.Size(230, 36);
            this.permissionSelect.TabIndex = 8;
            this.permissionSelect.SelectedIndexChanged += new System.EventHandler(this.permissionSelect_SelectedIndexChanged);
            // 
            // avatarPreview
            // 
            this.avatarPreview.Image = global::GUI.Properties.Resources._default;
            this.avatarPreview.ImageRotate = 0F;
            this.avatarPreview.Location = new System.Drawing.Point(380, 136);
            this.avatarPreview.Name = "avatarPreview";
            this.avatarPreview.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.avatarPreview.Size = new System.Drawing.Size(200, 200);
            this.avatarPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPreview.TabIndex = 9;
            this.avatarPreview.TabStop = false;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.BorderRadius = 10;
            this.selectImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectImageBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectImageBtn.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.selectImageBtn.ForeColor = System.Drawing.Color.White;
            this.selectImageBtn.Location = new System.Drawing.Point(407, 355);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(141, 37);
            this.selectImageBtn.TabIndex = 10;
            this.selectImageBtn.Text = "Chọn ảnh";
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 563);
            this.Controls.Add(this.selectImageBtn);
            this.Controls.Add(this.avatarPreview);
            this.Controls.Add(this.permissionSelect);
            this.Controls.Add(this.userPasswordConfirm);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userEmailBox);
            this.Controls.Add(this.userFullNameBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userPasswordConfirm;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userEmailBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userFullNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox permissionSelect;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox avatarPreview;
        private Siticone.Desktop.UI.WinForms.SiticoneButton selectImageBtn;
    }
}