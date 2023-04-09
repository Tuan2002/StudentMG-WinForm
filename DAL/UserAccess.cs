using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess : DatabaseAccess
    {
        // Kế thừa từ class DatabaseAccess
        // User MG Logic
        // Lấy danh sách người dùng
        public Response getListUser()
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getListUser", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
        // Kết thúc lấy danh sách người dùng
        // Lấy danh sách quyền
        public Response getPermissionList()
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getPermissionList", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
        // Kết thúc lấy danh sách quyền
        // Thêm người dùng mới vào CSDL
        public Response addUserToDB(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("addUserToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", req.GetData("userName"));
                command.Parameters.AddWithValue("@password", req.GetData("password"));
                command.Parameters.AddWithValue("@fullname", req.GetData("fullName"));
                command.Parameters.AddWithValue("@email", req.GetData("email"));
                command.Parameters.AddWithValue("@permissiontype", Int32.Parse(req.GetData("permissionType")));
                command.Parameters.AddWithValue("@avatar", req.GetData("avatar"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)

                    res.code = "user_exist";
                else
                    res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc thêm người dùng mới vào CSDL
        // Lấy thông tin người dùng
        public Response getUserData(string userName)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getUserData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", userName);
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
        // Kết thúc lấy thông tin người dùng
        // Cập nhật thông tin người dùng
        public Response UpdateUserData(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("UpdateUserData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@currentusername", req.GetData("currentUserName"));
                command.Parameters.AddWithValue("@newusername", req.GetData("newUserName"));
                command.Parameters.AddWithValue("@password", req.GetData("password"));
                command.Parameters.AddWithValue("@fullname", req.GetData("fullName"));
                command.Parameters.AddWithValue("@email", req.GetData("email"));
                command.Parameters.AddWithValue("@permissiontype", Int32.Parse(req.GetData("permissionType")));
                command.Parameters.AddWithValue("@avatar", req.GetData("avatar"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "user_already_exist";
                else
                    res.code = "update_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc cập nhật thông tin người dùng
        // Xóa người dùng
        public Response DeleteUser(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("DeleteUser", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", req.GetData("userName"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "user_not_exist";
                else
                    res.code = "delele_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc xóa người dùng
        // Tìm kiếm người dùng
        public Response getSearchUserData(string keyword)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("LoadSearchUserData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", keyword);
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
        // Kết thúc tìm kiếm người dùng
    }
}
