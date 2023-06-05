using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ClassAccess : DatabaseAccess
    {
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
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        public Response addClassToDB(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("addClassToDB", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@classid", req.GetData("ClassID"));
                command.Parameters.AddWithValue("@classname", req.GetData("ClassName"));
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
                    res.code = "class_exist";
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
        public Response getClassData(string classID)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("getClassData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@classid", classID);
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
        public Response UpdateClassData(Request req)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("UpdateClassData", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@currentclassid", req.GetData("CurrentClassID"));
                command.Parameters.AddWithValue("@newclassid", req.GetData("NewClassID"));
                command.Parameters.AddWithValue("@classname", req.GetData("ClassName"));
                command.Parameters.AddWithValue("@majorid", req.GetData("MajorID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "class_exist";
                else
                    res.code = "success";
            }
            catch (SqlException e)
            {
                res.code = e.Message;
            }
            return res;
        }
        public Response DeleteClass(Request request)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                SqlCommand command = new SqlCommand("DeleteClass", section);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@classid", request.GetData("ClassID"));
                var returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Connection = section;
                section.Open();
                command.ExecuteNonQuery();
                section.Close();
                int result = (int)returnValue.Value;
                if (result == 0)
                    res.code = "class_not_exist";
                else
                    res.code = "delete_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }

        public Response getSearchClassData(string keyword)
        {
            Response res = new Response();
            try
            {
                SqlConnection section = Connection();
                section.Open();
                SqlCommand command = new SqlCommand("LoadSearchClassData", section);
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
