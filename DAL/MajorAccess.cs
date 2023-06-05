using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MajorAccess : DatabaseAccess
    {
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
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        public Response addMajorToDB(Request req)
        {
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
                    res.code = "major_exist";
                else
                    res.code = "success";
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
                    res.code = "major_already_exist";
                else
                    res.code = "update_successfully";
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
                    res.code = "major_not_exist";
                else
                    res.code = "delele_successfully";
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
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
    }
}
