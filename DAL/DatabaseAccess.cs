using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
namespace DAL
{
    public class Response
    {
        public string code;
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
        protected StudentMGDataContext db = new StudentMGDataContext();
        public Response hanndleLogin(Request loginReq)
        {
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
