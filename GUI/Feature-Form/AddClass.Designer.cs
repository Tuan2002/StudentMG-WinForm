using System.Windows.Forms;

namespace GUI
{
    partial class AddClass
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.Formlabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.MajorOptions = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.classIDBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.classNameBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.majorOptionError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.classIDError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.classNameError = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.FormCaption = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.formMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.Formlabel);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(549, 55);
            this.siticonePanel1.TabIndex = 0;
            // 
            // Formlabel
            // 
            this.Formlabel.AutoSize = false;
            this.Formlabel.BackColor = System.Drawing.Color.Transparent;
            this.Formlabel.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.Formlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Formlabel.Location = new System.Drawing.Point(0, 18);
            this.Formlabel.Name = "Formlabel";
            this.Formlabel.Size = new System.Drawing.Size(549, 21);
            this.Formlabel.TabIndex = 0;
            this.Formlabel.Text = "Thêm lớp học mới";
            this.Formlabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MajorOptions.Location = new System.Drawing.Point(56, 140);
            this.MajorOptions.MaxDropDownItems = 4;
            this.MajorOptions.MinimumSize = new System.Drawing.Size(200, 0);
            this.MajorOptions.Name = "MajorOptions";
            this.MajorOptions.Size = new System.Drawing.Size(432, 46);
            this.MajorOptions.TabIndex = 1;
            this.MajorOptions.SelectedIndexChanged += new System.EventHandler(this.MajorOptions_SelectedIndexChanged);
            // 
            // classIDBox
            // 
            this.classIDBox.BorderColor = System.Drawing.Color.Plum;
            this.classIDBox.BorderRadius = 4;
            this.classIDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.classIDBox.DefaultText = "";
            this.classIDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.classIDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.classIDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classIDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classIDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classIDBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classIDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classIDBox.Location = new System.Drawing.Point(56, 228);
            this.classIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.classIDBox.Name = "classIDBox";
            this.classIDBox.PasswordChar = '\0';
            this.classIDBox.PlaceholderText = "Nhập mã lớp học";
            this.classIDBox.SelectedText = "";
            this.classIDBox.Size = new System.Drawing.Size(166, 49);
            this.classIDBox.TabIndex = 2;
            this.classIDBox.TextChanged += new System.EventHandler(this.classIDBox_TextChanged);
            this.classIDBox.Click += new System.EventHandler(this.TextBox_GotFocus);
            // 
            // classNameBox
            // 
            this.classNameBox.BorderColor = System.Drawing.Color.Plum;
            this.classNameBox.BorderRadius = 4;
            this.classNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.classNameBox.DefaultText = "";
            this.classNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.classNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.classNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classNameBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classNameBox.Location = new System.Drawing.Point(243, 228);
            this.classNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.classNameBox.Name = "classNameBox";
            this.classNameBox.PasswordChar = '\0';
            this.classNameBox.PlaceholderText = "Nhập tên lớp học";
            this.classNameBox.SelectedText = "";
            this.classNameBox.Size = new System.Drawing.Size(245, 49);
            this.classNameBox.TabIndex = 3;
            this.classNameBox.Click += new System.EventHandler(this.TextBox_GotFocus);
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
            this.CancelBtn.Location = new System.Drawing.Point(108, 386);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(130, 45);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Huỷ bỏ";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 4;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.ForestGreen;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(301, 386);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 45);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // majorOptionError
            // 
            this.majorOptionError.BackColor = System.Drawing.Color.Transparent;
            this.majorOptionError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.majorOptionError.ForeColor = System.Drawing.Color.Red;
            this.majorOptionError.Location = new System.Drawing.Point(62, 192);
            this.majorOptionError.Name = "majorOptionError";
            this.majorOptionError.Size = new System.Drawing.Size(148, 19);
            this.majorOptionError.TabIndex = 6;
            this.majorOptionError.Text = "Vui lòng chọn ngành học";
            // 
            // classIDError
            // 
            this.classIDError.BackColor = System.Drawing.Color.Transparent;
            this.classIDError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classIDError.ForeColor = System.Drawing.Color.Red;
            this.classIDError.Location = new System.Drawing.Point(62, 283);
            this.classIDError.Name = "classIDError";
            this.classIDError.Size = new System.Drawing.Size(111, 19);
            this.classIDError.TabIndex = 7;
            this.classIDError.Text = "Chưa nhập mã lớp";
            // 
            // classNameError
            // 
            this.classNameError.BackColor = System.Drawing.Color.Transparent;
            this.classNameError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classNameError.ForeColor = System.Drawing.Color.Red;
            this.classNameError.Location = new System.Drawing.Point(252, 283);
            this.classNameError.Name = "classNameError";
            this.classNameError.Size = new System.Drawing.Size(111, 19);
            this.classNameError.TabIndex = 8;
            this.classNameError.Text = "Chưa nhập tên lớp";
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = false;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormCaption.Location = new System.Drawing.Point(0, 84);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(549, 23);
            this.FormCaption.TabIndex = 9;
            this.FormCaption.Text = "Thông tin lớp học";
            this.FormCaption.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMessage
            // 
            this.formMessage.AutoSize = false;
            this.formMessage.BackColor = System.Drawing.Color.Transparent;
            this.formMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.formMessage.ForeColor = System.Drawing.Color.Red;
            this.formMessage.Location = new System.Drawing.Point(0, 335);
            this.formMessage.Name = "formMessage";
            this.formMessage.Size = new System.Drawing.Size(549, 22);
            this.formMessage.TabIndex = 10;
            this.formMessage.Text = "Vui lòng chọn ngành học";
            this.formMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.Formlabel;
            this.siticoneDragControl1.TransparentWhileDrag = false;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 468);
            this.Controls.Add(this.formMessage);
            this.Controls.Add(this.FormCaption);
            this.Controls.Add(this.classNameError);
            this.Controls.Add(this.classIDError);
            this.Controls.Add(this.majorOptionError);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.classNameBox);
            this.Controls.Add(this.classIDBox);
            this.Controls.Add(this.MajorOptions);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void TextBox_GotFocus(object sender, System.EventArgs e)
        {
            clearValidate();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Formlabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox classIDBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox classNameBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel formMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel FormCaption;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel classNameError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel classIDError;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel majorOptionError;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox MajorOptions;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}