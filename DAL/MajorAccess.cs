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
                var majors = db.getListMajor();
                res.data = Helper.ConvertSingleResultToDataTable(majors);
                res.code = "success";
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
                var result = db.addMajorToDB(req.GetData("MajorID"), req.GetData("MajorName"));
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
                var result = db.UpdateMajorData(req.GetData("CurrentMajorID"), req.GetData("NewMajorID"), req.GetData("MajorName"));
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
                var result = db.DeleteMajor(req.GetData("MajorID"));
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
                var result = db.LoadSearchMajorData(keyword);
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
