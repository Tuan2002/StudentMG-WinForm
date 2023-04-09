using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Runtime.Remoting.Messaging;

namespace BLL
{
    public class MiddleWare
    { 
        public Response validateForm(Request account)
        {
            DatabaseAccess loginAccess = new DatabaseAccess();
            Response res = new Response();
            if (account.GetData("userName") == string.Empty)
                res.code = "username_null";
            else if (account.GetData("password") == string.Empty)
                res.code = "password_null";
            else
                res = loginAccess.hanndleLogin(account);
  /*          res.code = "null";*/
            return res;

        }
        // Add new user
        public Response validateAddUserForm(Request form)
        {
            Response res = new Response();
            UserAccess HandleAddUser = new UserAccess();
            if (form.GetData("userName") == string.Empty)
                res.code = "userName_null";
            else if (form.GetData("fullName") == string.Empty)
                res.code = "fullName_null";
            else if (form.GetData("email") == string.Empty)
                res.code = "email_null";
            else if (form.GetData("password") == string.Empty)
                res.code = "password_null";
            else if (form.GetData("confirmPassword") != form.GetData("password"))
                res.code = "confirmPassword_notMatch"; 
            else if (form.GetData("permissionType") == "0")
                res.code = "permissionType_null";
            else
                res = HandleAddUser.addUserToDB(form);
             return res;     
        }
        // Get user data
        public Response handleGetUserData(Request currentUser) {
            Response res = new Response();
            UserAccess HandleGetUserData = new UserAccess();
            res = HandleGetUserData.getUserData(currentUser.GetData("userName"));
            return res;
        }
        // Update user data
        public Response validateEditUserForm(Request form)
        {
            Response res = new Response();
            UserAccess HandleUpdate = new UserAccess();
            if (form.GetData("newUserName") == string.Empty)
                res.code = "userName_null";
            else if (form.GetData("fullName") == string.Empty)
                res.code = "fullName_null";
            else if (form.GetData("email") == string.Empty)
                res.code = "email_null";
            else if (form.GetData("password") == string.Empty)
                res.code = "password_null";
            else if (form.GetData("confirmPassword") != form.GetData("password"))
                res.code = "confirmPassword_notMatch";
            else if (form.GetData("permissionType") == "0")
                res.code = "permissionType_null";
            else
                res = HandleUpdate.UpdateUserData(form);
            return res;
        }
        // Add new major
        public Response validateAddMajor (Request form)
        {
            Response res = new Response();
            MajorAccess HandleAddMajor = new MajorAccess();
            if (form.GetData("MajorID") == string.Empty)
                res.code = "majorid_null";
            else if (form.GetData("MajorName") == string.Empty)
                res.code = "majorname_null";
            else
                res = HandleAddMajor.addMajorToDB(form);
            return res;
        }
        // Edit major data
        public Response validateEditMajor (Request form)
        {
            Response res = new Response();
            MajorAccess HandleEditMajor = new MajorAccess();
            if (form.GetData("NewMajorID") == string.Empty)
                res.code = "majorid_null";
            else if (form.GetData("MajorName") == string.Empty)
                res.code = "majorname_null";
            else
                res = HandleEditMajor.UpdateMajorData(form);
            return res;
        }
        // Add new class
        public Response validateAddClass(Request form)
        {
            Response res = new Response();
            ClassAccess HandleAddClass = new ClassAccess();
            if (form.GetData("ClassID") == string.Empty)
                res.code = "classid_null";
            else if (form.GetData("ClassName") == string.Empty)
                res.code = "classname_null";
            else if (form.GetData("MajorID") == string.Empty)
                res.code = "majorid_null";
            else
                res = HandleAddClass.addClassToDB(form);
            return res;
        }

    }
}
