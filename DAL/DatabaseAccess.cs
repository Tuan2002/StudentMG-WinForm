using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.AccessControl;
using System.Collections.Specialized;
using System.ComponentModel;

// DATA ACCESS LAYER
namespace DAL
{
    public class Response
    {
        public string code;
        public string permissionType;
        public string userFullName;
        public string userImage;
        public DataTable data = new DataTable();

    }
    public class Request
    {
        ListDictionary data = new ListDictionary();
        public void AddData(string key, string value)
        {
            data.Add(key, value);
        }
        public void ClearData()
        {
            data.Clear();
        }
        public void addObjectData(Object obj)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor prop in properties)
            {
                data.Add(prop.Name, prop.GetValue(obj));
            }

        }
        public Object getObjectData(Object obj)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor prop in properties)
            {
                prop.SetValue(obj, data[prop.Name]);
            }
            return obj;
        }
        public string GetData(string key)
        {
            string value = (string)data[key];
            return value;
        }

    }
    // Handle data access
    public class DatabaseAccess
    {
        // Create connection string
        public static SqlConnection Connection() {
            string connectString = @"Data Source=188.166.205.125;Database=StudentMG;Integrated Security=false;User ID=sa;Password=Tuandev2002@;TrustServerCertificate=true;Connection Timeout=10";
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }

        public Response hanndleLogin(Request loginReq)
        {
        // Connect to database
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("handleLoginProduce", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", loginReq.GetData("userName"));
                command.Parameters.AddWithValue("@password", loginReq.GetData("password"));
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read())
                    {
                        res.code = "success";
                        res.userFullName = reader.GetString(0);
                        res.permissionType = reader.GetString(1);
                        res.userImage = reader.GetString(2);
                    }
                    reader.Close();
                    section.Close();
                }
                else
                {
                    res.code = "user_not_exsist";
                }
            }    
            catch(Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
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
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res; 
        }
        public Response getPermissionList ()
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
                {
                    res.code = "user_exist";
                }
                else
                {
                    res.code = "success";
                }
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
            catch (Exception ex)
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
                {
                    res.code = "user_already_exist";
                }
                else
                {
                    res.code = "update_successfully";
                }
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
                {
                    res.code = "user_not_exist";
                }
                else
                {
                    res.code = "delele_successfully";
                }
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
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
        // Major MG
        public Response getListMajor()
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getListMajor", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
            }
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
        public Response addMajorToDB(Request req) {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("addMajorToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                command.Parameters.AddWithValue("@majorname", req.GetData("MajorName"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                {
                    res.code = "major_exist";
                }
                else
                {
                    res.code = "success";
                }
            }

            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        public Response UpdateMajorData(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("UpdateMajorData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@currentmajorid", req.GetData("CurrentMajorID"));
                command.Parameters.AddWithValue("@newmajorid", req.GetData("NewMajorID"));
                command.Parameters.AddWithValue("@majorname", req.GetData("MajorName"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                {
                    res.code = "major_already_exist";
                }
                else
                {
                    res.code = "update_successfully";
                }
            }

            catch
            {
                res.code = "server_error";
            }
            return res;
        }

        public Response DeleteMajor(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("DeleteMajor", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                {
                    res.code = "major_not_exist";
                }
                else
                {
                    res.code = "delele_successfully";
                }
            }
            catch
            {
                res.code = "server_error";
            }
            return res; 
        }
        public Response getSearchMajorData(string keyword)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("LoadSearchMajorData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", keyword);
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
            }
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
        // Class MG Logic

        public Response getListClass(string majorID)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getListClass", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@majorid", majorID);
                command.Connection = section;
                SqlDataReader reader = command.ExecuteReader();
                res.code = "success";
                res.data.Load(reader);
                reader.Close();
                section.Close();
            }
            catch (Exception ex)
            {
                res.code = "server_error";
            }
            return res;
        }
    }
}
