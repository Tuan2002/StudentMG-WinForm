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
                var classes = db.getListClass(majorID);
                res.data = Helper.ConvertSingleResultToDataTable(classes);
                res.code = "success";
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
                var result = db.addClassToDB(req.GetData("ClassID"), req.GetData("ClassName"), req.GetData("MajorID"));
                if (result == 0)
                    res.code = "class_exist";
                else
                    res.code = "success";
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
                var classData = db.getClassData(classID);
                res.data = Helper.ConvertSingleResultToDataTable(classData);
                res.code = "success";
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
                var result = db.UpdateClassData(req.GetData("CurrentClassID"), req.GetData("NewClassID"), req.GetData("ClassName"), req.GetData("MajorID"));
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
                var result = db.DeleteClass(request.GetData("ClassID"));
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
                var result = db.LoadSearchClassData(keyword);
                res.data = Helper.ConvertSingleResultToDataTable(result);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
    }
}
