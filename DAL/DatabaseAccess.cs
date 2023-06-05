using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;

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
        public string GetData(string key)
        {
            string value = (string)data[key];
            return value;
        }

    }
    public class DatabaseAccess
    {
        private string connectString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }
        public Response hanndleLogin(Request loginReq)
        {
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
                if (reader.HasRows)
                {
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
                    res.code = "user_not_exsist";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }

    }
}
