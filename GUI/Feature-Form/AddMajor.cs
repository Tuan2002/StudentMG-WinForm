﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class AddMajor : Form
    {
        public delegate void UpdateMajorListView(string majorID, string majorName);
        public event UpdateMajorListView UpdateNajorListEvent;
        public AddMajor()
        {
            InitializeComponent();
        }

        public void clearValidate()
        {
            MajorNameBox.BorderColor = System.Drawing.Color.Plum;
            MajorNameEmpty.Text = string.Empty;
            MajorIDBox.BorderColor = System.Drawing.Color.Plum;
            MajorIDEmpty.Text = string.Empty;
            formError.Text = string.Empty;
        }
        public void clearForm()
        {
            MajorIDBox.Text= string.Empty;  
            MajorNameBox.Text = string.Empty;
            clearValidate();
        }

        private void AddMajor_Load(object sender, EventArgs e)
        {
            clearValidate();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Request addMajorReq = new Request();
            Response res = new Response();
            MiddleWare handleAddMajor = new MiddleWare();
            addMajorReq.AddData("MajorID", MajorIDBox.Text.Trim().ToUpper());
            addMajorReq.AddData("MajorName", MajorNameBox.Text.Trim());
            res = handleAddMajor.validateAddMajor(addMajorReq);
            switch(res.code)
            {
                case "success":
                    UpdateNajorListEvent(MajorIDBox.Text.Trim().ToUpper(), MajorNameBox.Text.Trim());
                    this.clearForm();
                    break;
                case "majorid_null":
                    MajorIDBox.BorderColor = System.Drawing.Color.Red;
                    MajorIDEmpty.Text = "Mã ngành học không được để trống";
                    break;
                case "majorname_null":
                    MajorNameBox.BorderColor = System.Drawing.Color.Red;
                    MajorNameEmpty.Text = "Tên ngành học không được để trống";
                    break;
                case "major_exist":
                    formError.Text = "Ngành học này đã tồn tại trong hệ thống";
                    break;
                default:
                    formError.Text = "Có lõi xảy ra, Mã lỗi: " + res.code;
                    break;
            }
        }
    }
}