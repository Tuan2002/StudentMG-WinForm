using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace DAL
{
    public class UserAccess : DatabaseAccess
    {
        // Kế thừa từ class DatabaseAccess
        // User MG Logic
        // Lấy danh sách người dùng
        public Response getListUser()
        {
            Response res = new Response();
            try
            {
                var users = db.getListUser();
                res.data = Helper.ConvertSingleResultToDataTable(users);
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc lấy danh sách người dùng
        // Lấy danh sách quyền
        public Response getPermissionList()
        {
            Response res = new Response();
            try
            {
                var permissions = db.userPermissions.Select(permission => permission);
                res.data = permissions.ToDataTable();
                res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc lấy danh sách quyền
        // Thêm người dùng mới vào CSDL
        public Response addUserToDB(Request req)
        {
            Response res = new Response();
            try
            {
                var result = db.addUserToDB(req.GetData("userName"), req.GetData("password"), req.GetData("fullName"), req.GetData("email"), Int32.Parse(req.GetData("permissionType")), req.GetData("avatar"));
                if (result == 0)
                    res.code = "user_exist";
                else
                    res.code = "success";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc thêm người dùng mới vào CSDL
        // Lấy thông tin người dùng
        public Response getUserData(string userName)
        {
            Response res = new Response();
            try
            {
                var userInfo = db.userAccounts.Where(user => user.userName == userName);
                res.data = userInfo.ToDataTable();
                res.code = "success";
            }
            catch 
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc lấy thông tin người dùng
        // Cập nhật thông tin người dùng
        public Response UpdateUserData(Request req)
        {
            Response res = new Response();
            try
            {
                var result = db.UpdateUserData(req.GetData("currentUserName"), req.GetData("newUserName"), req.GetData("password"), req.GetData("fullName"), req.GetData("email"), Int32.Parse(req.GetData("permissionType")), req.GetData("avatar"));
                if (result == 0)
                    res.code = "user_already_exist";
                else
                    res.code = "update_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc cập nhật thông tin người dùng
        // Xóa người dùng
        public Response DeleteUser(Request req)
        {
            Response res = new Response();
            try
            {
                var result = db.DeleteUser(req.GetData("userName"));
                if (result == 0)
                    res.code = "user_not_exist";
                else
                    res.code = "delele_successfully";
            }
            catch
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc xóa người dùng
        // Tìm kiếm người dùng
        public Response getSearchUserData(string keyword)
        {
            Response res = new Response();
            try
            {
                var result = db.LoadSearchUserData(keyword);
                res.data = Helper.ConvertSingleResultToDataTable(result);
                res.code = "success";
            }
            catch 
            {
                res.code = "server_error";
            }
            return res;
        }
        // Kết thúc tìm kiếm người dùng
    }
}
