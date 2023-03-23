using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using COM;
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
        public Response validateAddUserForm(Request form)
        {
            Response res = new Response();
            DatabaseAccess HandleAddUser = new DatabaseAccess();
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
        public Response handleGetUserData(Request currentUser) {
            Response res = new Response();
            DatabaseAccess HandleGetUserData = new DatabaseAccess();
            res = HandleGetUserData.getUserData(currentUser.GetData("userName"));
            return res;
        }


    }
}
