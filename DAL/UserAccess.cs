using System;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class UserAccess : DatabaseAccess
    {
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
    }
}
