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
    // Create response object
    public class Response
    {
        public string code;
        public string permissionType;
        public string userFullName;
        public string userImage;
        public DataTable data = new DataTable();

    }
    // Create request object
    public class Request
    {
        // Tạo một dictionary để lưu trữ dữ liệu
        ListDictionary data = new ListDictionary();
        // Tạo các phương thức để thêm, xóa, lấy dữ liệu
        // Thêm dữ liệu vào dictionary với key và value
        public void AddData(string key, string value)
        {
            data.Add(key, value);
        }
        // Xóa dữ liệu trong dictionary
        public void ClearData()
        {
            data.Clear();
        }
        // Lấy dữ liệu từ dictionary qua key
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
        // Xử lý đăng nhập vào hệ thống
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
