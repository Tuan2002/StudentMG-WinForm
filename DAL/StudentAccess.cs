using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentAccess : DatabaseAccess
    {
        // Kế thừa từ class DatabaseAccess
        // Student MG Logic
        // Lấy danh sách Sinh viên theo ngành
        public Response getStudentList(string majorID)
        {
            Response res = new Response();
            try
            {
                var students = db.getStudentList(majorID);
                res.data = Helper.ConvertSingleResultToDataTable(students);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc lấy danh sách sinh viên
        // Thêm sinh viên mới vào CSDL
        public Response addStudentToDB (Request req) {
            Response res = new Response();
            try
            {
                var result = db.addStudentToDB(req.GetData("PersonID"), req.GetData("StudentName"), req.GetData("Birthday"), req.GetData("Gender"), req.GetData("Address"), req.GetData("MajorID"), req.GetData("ClassID"));
                DataTable data = Helper.ConvertSingleResultToDataTable(result);
                if (data.Rows.Count > 0)
                {
                    res.data = data;
                    res.code = "success";
                }
                else
                    res.code = "student_exist";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc thêm sinh viên
        // Lấy thông tin sinh viên theo ID
        public Response getStudentData(string studentID)
        {
            Response res = new Response();
            try
            {
                var studentData = db.getStudentData(Int32.Parse(studentID));
                res.data = Helper.ConvertSingleResultToDataTable(studentData);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc lấy thông tin sinh viên
        // Cập nhật thông tin sinh viên
        public Response UpdateStudentData(Request req)
        {
            Response res = new Response();
            try
            {
                var result = db.UpdateStudentData(Int32.Parse(req.GetData("StudentID")), req.GetData("PersonID"), req.GetData("StudentName"), req.GetData("Birthday"), req.GetData("Gender"), req.GetData("Address"), req.GetData("MajorID"), req.GetData("ClassID"));
                if (result == 0)
                    res.code = "student_exist";
                else
                    res.code = "update_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc cập nhật thông tin sinh viên
        // Xoá sinh viên khỏi CSDL
        public Response DeleteStudent(Request req)
        {
            Response res = new Response();
            try
            {
                var result = db.DeleteStudent(Int32.Parse(req.GetData("StudentID")));
                if (result == 0)
                    res.code = "student_not_exist";
                else
                    res.code = "delete_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc xoá sinh viên
        public Response getSearchStudentData(string keyword)
        {
            Response res = new Response();
            try
            {
                var result = db.LoadSearchStudentData(keyword);
                res.data = Helper.ConvertSingleResultToDataTable(result);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }

    }
}
