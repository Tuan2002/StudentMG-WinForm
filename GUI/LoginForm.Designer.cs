using System;
using System.Management;

namespace GUI
{
    partial class LoginForm
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
            Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
            Siticone.Desktop.UI.WinForms.SiticoneControlBox closeFormBtn;
            this.txtUserName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.loginBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.forgetBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.useNameError = new System.Windows.Forms.Label();
            this.loginError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            closeFormBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.BorderRadius = 20;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // closeFormBtn
            // 
            closeFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            closeFormBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            closeFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            closeFormBtn.CustomIconSize = 14F;
            closeFormBtn.FillColor = System.Drawing.Color.Transparent;
            closeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            closeFormBtn.ForeColor = System.Drawing.Color.Transparent;
            closeFormBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            closeFormBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            closeFormBtn.HoverState.IconColor = System.Drawing.Color.DimGray;
            closeFormBtn.IconColor = System.Drawing.Color.DimGray;
            closeFormBtn.Location = new System.Drawing.Point(386, 5);
            closeFormBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeFormBtn.Name = "closeFormBtn";
            closeFormBtn.Size = new System.Drawing.Size(33, 31);
            closeFormBtn.TabIndex = 0;
            closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(37, 260);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Tên người dùng";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(349, 53);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(37, 348);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(349, 53);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 16;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.Green;
            this.loginBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(216, 441);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(170, 53);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.Enter += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgetBtn
            // 
            this.forgetBtn.BorderRadius = 16;
            this.forgetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forgetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forgetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forgetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forgetBtn.FillColor = System.Drawing.Color.Firebrick;
            this.forgetBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetBtn.ForeColor = System.Drawing.Color.White;
            this.forgetBtn.Location = new System.Drawing.Point(37, 441);
            this.forgetBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.forgetBtn.Name = "forgetBtn";
            this.forgetBtn.Size = new System.Drawing.Size(158, 53);
            this.forgetBtn.TabIndex = 4;
            this.forgetBtn.Text = "Quên mật khẩu?";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::GUI.Properties.Resources._115_1150152_default_profile_picture_avatar_png_green;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(155, 100);
            this.siticonePictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(103, 122);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 6;
            this.siticonePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16F);
            this.label1.Location = new System.Drawing.Point(1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chào mừng bạn quay trở lại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(37, 413);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(135, 15);
            this.passwordError.TabIndex = 10;
            this.passwordError.Text = "Mật khẩu không hợp lệ";
            // 
            // useNameError
            // 
            this.useNameError.AutoSize = true;
            this.useNameError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.useNameError.ForeColor = System.Drawing.Color.Red;
            this.useNameError.Location = new System.Drawing.Point(37, 322);
            this.useNameError.Name = "useNameError";
            this.useNameError.Size = new System.Drawing.Size(169, 15);
            this.useNameError.TabIndex = 9;
            this.useNameError.Text = "Tên người dùng không hợp lệ";
            // 
            // loginError
            // 
            this.loginError.AutoSize = false;
            this.loginError.BackColor = System.Drawing.Color.Transparent;
            this.loginError.Font = new System.Drawing.Font("Roboto", 10F);
            this.loginError.ForeColor = System.Drawing.Color.Red;
            this.loginError.Location = new System.Drawing.Point(1, 232);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(425, 17);
            this.loginError.TabIndex = 11;
            this.loginError.Text = "Tài khoản hoặc mật khẩu không chính xác!";
            this.loginError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(427, 523);
            this.Controls.Add(this.loginError);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.useNameError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.forgetBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(closeFormBtn);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.txtUserName.GotFocus += TxtUserName_GotFocus;
            this.txtPassword.GotFocus += TxtPassword_GotFocus;
        }

        private void TxtUserName_GotFocus(object sender, EventArgs e)
        {
            this.txtUserName.BorderColor = System.Drawing.Color.DeepSkyBlue;
            clearValidate();
        }

        private void TxtPassword_GotFocus(object sender, System.EventArgs e)
        {
            this.txtPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            clearValidate();
        }


        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneButton forgetBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label useNameError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel loginError;
    }
}

