using System.Runtime.CompilerServices;

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
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addUserBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userFullNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userEmailBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userPasswordConfirm = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.permissionSelect = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.selectImageBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userNameEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.fullNameEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.emailEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.passwordEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.passwordNotSame = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.permisstionEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.useDefaultImage = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.imageRequied = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.formLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.formError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.avatarPreview = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.BorderThickness = 1;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.CancelBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(340, 12);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(140, 39);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Huỷ bỏ";
            this.CancelBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addUserBtn.BorderRadius = 10;
            this.addUserBtn.BorderThickness = 1;
            this.addUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUserBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.addUserBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(490, 12);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(140, 39);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Thêm";
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.addUserBtn);
            this.siticonePanel1.Controls.Add(this.CancelBtn);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 537);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(680, 63);
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
            this.userNameBox.Size = new System.Drawing.Size(250, 38);
            this.userNameBox.TabIndex = 3;
            this.userNameBox.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.userFullNameBox.Size = new System.Drawing.Size(250, 38);
            this.userFullNameBox.TabIndex = 4;
            this.userFullNameBox.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.userEmailBox.Size = new System.Drawing.Size(250, 38);
            this.userEmailBox.TabIndex = 5;
            this.userEmailBox.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.userPassword.Size = new System.Drawing.Size(250, 38);
            this.userPassword.TabIndex = 6;
            this.userPassword.UseSystemPasswordChar = true;
            this.userPassword.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.userPasswordConfirm.Size = new System.Drawing.Size(250, 38);
            this.userPasswordConfirm.TabIndex = 7;
            this.userPasswordConfirm.UseSystemPasswordChar = true;
            this.userPasswordConfirm.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.permissionSelect.Size = new System.Drawing.Size(266, 36);
            this.permissionSelect.TabIndex = 8;
            this.permissionSelect.SelectedIndexChanged += new System.EventHandler(this.permissionSelect_SelectedIndexChanged);
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
            this.selectImageBtn.Location = new System.Drawing.Point(424, 375);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(141, 37);
            this.selectImageBtn.TabIndex = 10;
            this.selectImageBtn.Text = "Chọn ảnh";
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // userNameEmpty
            // 
            this.userNameEmpty.BackColor = System.Drawing.Color.Transparent;
            this.userNameEmpty.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.userNameEmpty.Location = new System.Drawing.Point(42, 127);
            this.userNameEmpty.Name = "userNameEmpty";
            this.userNameEmpty.Size = new System.Drawing.Size(203, 16);
            this.userNameEmpty.TabIndex = 11;
            this.userNameEmpty.Text = "Tên người dùng không được để trống";
            // 
            // fullNameEmpty
            // 
            this.fullNameEmpty.BackColor = System.Drawing.Color.Transparent;
            this.fullNameEmpty.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.fullNameEmpty.Location = new System.Drawing.Point(42, 198);
            this.fullNameEmpty.Name = "fullNameEmpty";
            this.fullNameEmpty.Size = new System.Drawing.Size(138, 16);
            this.fullNameEmpty.TabIndex = 12;
            this.fullNameEmpty.Text = "Tên không được để trống";
            // 
            // emailEmpty
            // 
            this.emailEmpty.BackColor = System.Drawing.Color.Transparent;
            this.emailEmpty.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEmpty.ForeColor = System.Drawing.Color.Red;
            this.emailEmpty.Location = new System.Drawing.Point(40, 270);
            this.emailEmpty.Name = "emailEmpty";
            this.emailEmpty.Size = new System.Drawing.Size(149, 16);
            this.emailEmpty.TabIndex = 13;
            this.emailEmpty.Text = "Email không được để trống";
            // 
            // passwordEmpty
            // 
            this.passwordEmpty.BackColor = System.Drawing.Color.Transparent;
            this.passwordEmpty.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEmpty.ForeColor = System.Drawing.Color.Red;
            this.passwordEmpty.Location = new System.Drawing.Point(42, 342);
            this.passwordEmpty.Name = "passwordEmpty";
            this.passwordEmpty.Size = new System.Drawing.Size(169, 16);
            this.passwordEmpty.TabIndex = 14;
            this.passwordEmpty.Text = "Mật khẩu không được để trống";
            // 
            // passwordNotSame
            // 
            this.passwordNotSame.BackColor = System.Drawing.Color.Transparent;
            this.passwordNotSame.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNotSame.ForeColor = System.Drawing.Color.Red;
            this.passwordNotSame.Location = new System.Drawing.Point(42, 416);
            this.passwordNotSame.Name = "passwordNotSame";
            this.passwordNotSame.Size = new System.Drawing.Size(168, 16);
            this.passwordNotSame.TabIndex = 15;
            this.passwordNotSame.Text = "Mật khẩu nhập lại không khớp";
            // 
            // permisstionEmpty
            // 
            this.permisstionEmpty.BackColor = System.Drawing.Color.Transparent;
            this.permisstionEmpty.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permisstionEmpty.ForeColor = System.Drawing.Color.Red;
            this.permisstionEmpty.Location = new System.Drawing.Point(369, 126);
            this.permisstionEmpty.Name = "permisstionEmpty";
            this.permisstionEmpty.Size = new System.Drawing.Size(138, 16);
            this.permisstionEmpty.TabIndex = 16;
            this.permisstionEmpty.Text = "Vui lòng chọn quyền hạn";
            // 
            // useDefaultImage
            // 
            this.useDefaultImage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.useDefaultImage.CheckedState.BorderRadius = 2;
            this.useDefaultImage.CheckedState.BorderThickness = 0;
            this.useDefaultImage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.useDefaultImage.Location = new System.Drawing.Point(402, 418);
            this.useDefaultImage.Name = "useDefaultImage";
            this.useDefaultImage.Size = new System.Drawing.Size(20, 20);
            this.useDefaultImage.TabIndex = 17;
            this.useDefaultImage.Text = "Dùng ảnh mặc định";
            this.useDefaultImage.UncheckedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.useDefaultImage.UncheckedState.BorderRadius = 4;
            this.useDefaultImage.UncheckedState.BorderThickness = 1;
            this.useDefaultImage.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(432, 422);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(126, 16);
            this.siticoneHtmlLabel1.TabIndex = 18;
            this.siticoneHtmlLabel1.Text = "Sử dụng ảnh mặc định";
            // 
            // imageRequied
            // 
            this.imageRequied.BackColor = System.Drawing.Color.Transparent;
            this.imageRequied.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageRequied.ForeColor = System.Drawing.Color.Red;
            this.imageRequied.Location = new System.Drawing.Point(443, 444);
            this.imageRequied.Name = "imageRequied";
            this.imageRequied.Size = new System.Drawing.Size(102, 16);
            this.imageRequied.TabIndex = 19;
            this.imageRequied.Text = "Vui lòng chọn ảnh";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.formLabel);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(680, 50);
            this.siticonePanel2.TabIndex = 20;
            // 
            // formLabel
            // 
            this.formLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formLabel.AutoSize = false;
            this.formLabel.BackColor = System.Drawing.Color.Transparent;
            this.formLabel.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.formLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.formLabel.Location = new System.Drawing.Point(3, 15);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(674, 22);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Thêm người dùng";
            this.formLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formError
            // 
            this.formError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formError.AutoSize = false;
            this.formError.BackColor = System.Drawing.Color.Transparent;
            this.formError.Font = new System.Drawing.Font("Roboto", 11F);
            this.formError.ForeColor = System.Drawing.Color.Red;
            this.formError.Location = new System.Drawing.Point(0, 515);
            this.formError.Name = "formError";
            this.formError.Size = new System.Drawing.Size(680, 20);
            this.formError.TabIndex = 21;
            this.formError.Text = "Người dùng đã có trong hệ thống ";
            this.formError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarPreview
            // 
            this.avatarPreview.Image = global::GUI.Properties.Resources._default;
            this.avatarPreview.ImageRotate = 0F;
            this.avatarPreview.Location = new System.Drawing.Point(397, 156);
            this.avatarPreview.Name = "avatarPreview";
            this.avatarPreview.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.avatarPreview.Size = new System.Drawing.Size(200, 200);
            this.avatarPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPreview.TabIndex = 9;
            this.avatarPreview.TabStop = false;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.formLabel;
            this.siticoneDragControl1.TransparentWhileDrag = false;
            // 
            // AddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(680, 600);
            this.Controls.Add(this.formError);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.imageRequied);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.useDefaultImage);
            this.Controls.Add(this.permisstionEmpty);
            this.Controls.Add(this.passwordNotSame);
            this.Controls.Add(this.passwordEmpty);
            this.Controls.Add(this.emailEmpty);
            this.Controls.Add(this.fullNameEmpty);
            this.Controls.Add(this.userNameEmpty);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox_GotFocus(object sender, System.EventArgs e)
        {
            clearValidateForm();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addUserBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userPasswordConfirm;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userEmailBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userFullNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox permissionSelect;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox avatarPreview;
        private Siticone.Desktop.UI.WinForms.SiticoneButton selectImageBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel userNameEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel passwordNotSame;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel passwordEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel emailEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel fullNameEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox useDefaultImage;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel permisstionEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel imageRequied;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel formLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel formError;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}