using System;

namespace GUI
{
    partial class AddMajor
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
            this.MajorIDBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MajorNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.formtitle = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.FormLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.MajorIDEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.MajorNameEmpty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.MajorInfo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.formMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.formtitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // MajorIDBox
            // 
            this.MajorIDBox.Animated = true;
            this.MajorIDBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            this.MajorIDBox.BorderRadius = 8;
            this.MajorIDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MajorIDBox.DefaultText = "";
            this.MajorIDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MajorIDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MajorIDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MajorIDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MajorIDBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.MajorIDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MajorIDBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MajorIDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MajorIDBox.Location = new System.Drawing.Point(48, 127);
            this.MajorIDBox.Name = "MajorIDBox";
            this.MajorIDBox.PasswordChar = '\0';
            this.MajorIDBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MajorIDBox.PlaceholderText = "Nhập mã ngành học";
            this.MajorIDBox.SelectedText = "";
            this.MajorIDBox.Size = new System.Drawing.Size(356, 50);
            this.MajorIDBox.TabIndex = 0;
            this.MajorIDBox.Click += new System.EventHandler(this.MajorTextBox_Click);
            // 
            // MajorNameBox
            // 
            this.MajorNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            this.MajorNameBox.BorderRadius = 8;
            this.MajorNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MajorNameBox.DefaultText = "";
            this.MajorNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MajorNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MajorNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MajorNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MajorNameBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.MajorNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MajorNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MajorNameBox.Location = new System.Drawing.Point(48, 221);
            this.MajorNameBox.Name = "MajorNameBox";
            this.MajorNameBox.PasswordChar = '\0';
            this.MajorNameBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MajorNameBox.PlaceholderText = "Nhập tên ngành học";
            this.MajorNameBox.SelectedText = "";
            this.MajorNameBox.Size = new System.Drawing.Size(356, 50);
            this.MajorNameBox.TabIndex = 1;
            this.MajorNameBox.Click += new System.EventHandler(this.MajorTextBox_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderRadius = 8;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.CancelBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(48, 368);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(154, 48);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Huỷ bỏ";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 8;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.AddBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(250, 368);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(154, 48);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // formtitle
            // 
            this.formtitle.Controls.Add(this.FormLabel);
            this.formtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.formtitle.Location = new System.Drawing.Point(0, 0);
            this.formtitle.Name = "formtitle";
            this.formtitle.Size = new System.Drawing.Size(450, 46);
            this.formtitle.TabIndex = 4;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = false;
            this.FormLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.FormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormLabel.Location = new System.Drawing.Point(0, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(450, 46);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Thêm ngành học";
            this.FormLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.FormLabel;
            this.siticoneDragControl1.TransparentWhileDrag = false;
            // 
            // MajorIDEmpty
            // 
            this.MajorIDEmpty.BackColor = System.Drawing.Color.Transparent;
            this.MajorIDEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MajorIDEmpty.ForeColor = System.Drawing.Color.Red;
            this.MajorIDEmpty.Location = new System.Drawing.Point(51, 183);
            this.MajorIDEmpty.Name = "MajorIDEmpty";
            this.MajorIDEmpty.Size = new System.Drawing.Size(212, 18);
            this.MajorIDEmpty.TabIndex = 5;
            this.MajorIDEmpty.Text = "Mã ngành học không được để trống";
            // 
            // MajorNameEmpty
            // 
            this.MajorNameEmpty.BackColor = System.Drawing.Color.Transparent;
            this.MajorNameEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MajorNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.MajorNameEmpty.Location = new System.Drawing.Point(51, 277);
            this.MajorNameEmpty.Name = "MajorNameEmpty";
            this.MajorNameEmpty.Size = new System.Drawing.Size(217, 18);
            this.MajorNameEmpty.TabIndex = 6;
            this.MajorNameEmpty.Text = "Tên ngành học không dược để trống";
            // 
            // MajorInfo
            // 
            this.MajorInfo.AutoSize = false;
            this.MajorInfo.BackColor = System.Drawing.Color.Transparent;
            this.MajorInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.MajorInfo.Location = new System.Drawing.Point(0, 69);
            this.MajorInfo.Name = "MajorInfo";
            this.MajorInfo.Size = new System.Drawing.Size(450, 20);
            this.MajorInfo.TabIndex = 7;
            this.MajorInfo.Text = "Nhập thông tin ngành học";
            this.MajorInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMessage
            // 
            this.formMessage.AutoSize = false;
            this.formMessage.BackColor = System.Drawing.Color.Transparent;
            this.formMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formMessage.ForeColor = System.Drawing.Color.Red;
            this.formMessage.Location = new System.Drawing.Point(0, 330);
            this.formMessage.Name = "formMessage";
            this.formMessage.Size = new System.Drawing.Size(450, 20);
            this.formMessage.TabIndex = 8;
            this.formMessage.Text = "Ngành học này đã tồn tại trên hệ thống";
            this.formMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMajor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.formMessage);
            this.Controls.Add(this.MajorInfo);
            this.Controls.Add(this.MajorNameEmpty);
            this.Controls.Add(this.MajorIDEmpty);
            this.Controls.Add(this.formtitle);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.MajorNameBox);
            this.Controls.Add(this.MajorIDBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddMajor";
            this.Load += new System.EventHandler(this.AddMajor_Load);
            this.formtitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void MajorTextBox_Click(object sender, EventArgs e)
        {
                clearValidate();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MajorIDBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MajorNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel MajorNameEmpty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel MajorIDEmpty;
        private Siticone.Desktop.UI.WinForms.SiticonePanel formtitle;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel FormLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel MajorInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel formMessage;
    }
}