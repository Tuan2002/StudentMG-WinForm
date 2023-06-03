using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MajorAccess : DatabaseAccess
    {
        // Kế thừa từ class DatabaseAccess
        // Major MG Logic
        // Lấy danh sách ngành học
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
        // Kết thúc lấy danh sách ngành học
        // Thêm ngành học vào CSDL
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
        // Kết thúc thêm ngành học vào CSDL
        // Cập nhật thông tin ngành học
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
        // Kết thúc cập nhật thông tin ngành học
        // Xóa ngành học
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
        // Kết thúc xóa ngành học
        // Tìm kiếm ngành học
        public Response getSearchMajorData(string keyword)
        {
            Response res = new Response();
            try
            {
                var result = db.LoadSearchMajorData(keyword);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc tìm kiếm ngành học
    }
}
