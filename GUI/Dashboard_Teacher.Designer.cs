using System.Windows.Media.Media3D;

namespace GUI
{
    partial class Dashboard_Teacher
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
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.sidebarMenu = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.studentListBtn = new FontAwesome.Sharp.IconButton();
            this.classManagerBtn = new FontAwesome.Sharp.IconButton();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPermisstionLabel = new System.Windows.Forms.Label();
            this.avatarBox = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.panelDesktop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.sidebarMenu.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
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
            this.siticonePanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.siticonePanel1.Controls.Add(this.logoutBtn);
            this.siticonePanel1.Controls.Add(this.sidebarMenu);
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(253, 788);
            this.siticonePanel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.logoutBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 20;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 730);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(253, 58);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // sidebarMenu
            // 
            this.sidebarMenu.Controls.Add(this.studentListBtn);
            this.sidebarMenu.Controls.Add(this.classManagerBtn);
            this.sidebarMenu.Location = new System.Drawing.Point(0, 197);
            this.sidebarMenu.Name = "sidebarMenu";
            this.sidebarMenu.Size = new System.Drawing.Size(253, 453);
            this.sidebarMenu.TabIndex = 4;
            // 
            // studentListBtn
            // 
            this.studentListBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.studentListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentListBtn.FlatAppearance.BorderSize = 0;
            this.studentListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentListBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentListBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.studentListBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.studentListBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.studentListBtn.IconSize = 23;
            this.studentListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentListBtn.Location = new System.Drawing.Point(0, 60);
            this.studentListBtn.Name = "studentListBtn";
            this.studentListBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.studentListBtn.Size = new System.Drawing.Size(253, 60);
            this.studentListBtn.TabIndex = 3;
            this.studentListBtn.Text = "Quản lý DS Sinh viên";
            this.studentListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentListBtn.UseVisualStyleBackColor = false;
            this.studentListBtn.Click += new System.EventHandler(this.studentListBtn_Click);
            // 
            // classManagerBtn
            // 
            this.classManagerBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.classManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.classManagerBtn.FlatAppearance.BorderSize = 0;
            this.classManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classManagerBtn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classManagerBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.classManagerBtn.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.classManagerBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.classManagerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.classManagerBtn.IconSize = 23;
            this.classManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classManagerBtn.Location = new System.Drawing.Point(0, 0);
            this.classManagerBtn.Name = "classManagerBtn";
            this.classManagerBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.classManagerBtn.Size = new System.Drawing.Size(253, 60);
            this.classManagerBtn.TabIndex = 1;
            this.classManagerBtn.Text = "Quản lý lớp học";
            this.classManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classManagerBtn.UseVisualStyleBackColor = false;
            this.classManagerBtn.Click += new System.EventHandler(this.classManagerBtn_Click);
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.userNameLabel);
            this.siticonePanel3.Controls.Add(this.userPermisstionLabel);
            this.siticonePanel3.Controls.Add(this.avatarBox);
            this.siticonePanel3.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(253, 191);
            this.siticonePanel3.TabIndex = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameLabel.Location = new System.Drawing.Point(0, 126);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(253, 20);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Nguyễn Anh Tuấn";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPermisstionLabel
            // 
            this.userPermisstionLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPermisstionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userPermisstionLabel.Location = new System.Drawing.Point(4, 152);
            this.userPermisstionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPermisstionLabel.Name = "userPermisstionLabel";
            this.userPermisstionLabel.Size = new System.Drawing.Size(249, 20);
            this.userPermisstionLabel.TabIndex = 5;
            this.userPermisstionLabel.Text = "Teacher";
            this.userPermisstionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarBox
            // 
            this.avatarBox.Image = global::GUI.Properties.Resources.Meo;
            this.avatarBox.ImageRotate = 0F;
            this.avatarBox.Location = new System.Drawing.Point(84, 31);
            this.avatarBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.avatarBox.Size = new System.Drawing.Size(82, 81);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 3;
            this.avatarBox.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TopPanel.Controls.Add(this.siticoneControlBox3);
            this.TopPanel.Controls.Add(this.siticoneControlBox2);
            this.TopPanel.Controls.Add(this.siticoneControlBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(253, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(899, 48);
            this.TopPanel.TabIndex = 1;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(744, 3);
            this.siticoneControlBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.Size = new System.Drawing.Size(44, 33);
            this.siticoneControlBox3.TabIndex = 4;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(796, 3);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(44, 33);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(844, 3);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(52, 33);
            this.siticoneControlBox1.TabIndex = 2;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.siticoneCirclePictureBox1);
            this.panelDesktop.Controls.Add(this.siticoneHtmlLabel2);
            this.panelDesktop.Controls.Add(this.siticoneHtmlLabel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(253, 48);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(899, 740);
            this.panelDesktop.TabIndex = 2;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::GUI.Properties.Resources.worker;
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(414, 134);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(101, 93);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 2;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.AutoSize = false;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(1, 300);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(896, 40);
            this.siticoneHtmlLabel2.TabIndex = 1;
            this.siticoneHtmlLabel2.Text = "QUẢN LÝ SINH VIÊN";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(3, 248);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(896, 40);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI HỆ THỐNG";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.TopPanel;
            this.siticoneDragControl1.TransparentWhileDrag = false;
            // 
            // Dashboard_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1152, 788);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.siticonePanel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard_Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_Admin_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Admin_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.sidebarMenu.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel sidebarMenu;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox avatarBox;
        private FontAwesome.Sharp.IconButton studentListBtn;
        private FontAwesome.Sharp.IconButton classManagerBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userPermisstionLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panelDesktop;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
    }
}