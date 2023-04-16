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
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getStudentList", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@majorid", majorID);
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
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
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("addStudentToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@personid", req.GetData("PersonID"));
                command.Parameters.AddWithValue("@studentname", req.GetData("StudentName"));
                command.Parameters.AddWithValue("@birthday", req.GetData("Birthday"));
                command.Parameters.AddWithValue("@gender", req.GetData("Gender"));
                command.Parameters.AddWithValue("@address", req.GetData("Address"));
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                command.Parameters.AddWithValue("@classid", req.GetData("ClassID"));
                command.Connection = section;
                //command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    res.data.Load(reader);
                    res.code = "success";
                }
                else
                    res.code = "student_exist";
                reader.Close();
                section.Close();
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
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getStudentData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@studentid",Int32.Parse(studentID));
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    res.code = "success";
                    res.data.Load(reader);
                }
                reader.Close();
                section.Close();
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
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("UpdateStudentData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@studentid", Int32.Parse(req.GetData("StudentID")));
                command.Parameters.AddWithValue("@personid", req.GetData("PersonID"));
                command.Parameters.AddWithValue("@studentname", req.GetData("StudentName"));
                command.Parameters.AddWithValue("@birthday", req.GetData("Birthday"));
                command.Parameters.AddWithValue("@gender", req.GetData("Gender"));
                command.Parameters.AddWithValue("@address", req.GetData("Address"));
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                command.Parameters.AddWithValue("@classid", req.GetData("ClassID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "student_exist";
                else
                    res.code = "update_successfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
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
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("DeleteStudent", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@studentid", Int32.Parse(req.GetData("StudentID")));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
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
        
    }
}
