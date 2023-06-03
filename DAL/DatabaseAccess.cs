using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
// DATA ACCESS LAYER
namespace DAL
{
    // Create response object
    public class Response
    {
        public string code;
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
        protected StudentMGDataContext db = new StudentMGDataContext();
        // Xử lý đăng nhập vào hệ thống
        public Response hanndleLogin(Request loginReq)
        {
        // Connect to database
            Response res = new Response();
            try
            {
                var author = db.handleLoginProduce(loginReq.GetData("userName"), loginReq.GetData("password"));
                res.data = Helper.ConvertSingleResultToDataTable(author);
                if (res.data.Rows.Count > 0)
                    res.code = "success";
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
