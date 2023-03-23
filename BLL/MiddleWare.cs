using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using COM;
namespace BLL
{

    public class MiddleWare
    {
        UserAccess currentUser = new UserAccess();
        public Response validateForm(Request account)
        {
            Response res = new Response();
            if (account.GetData("userName") == string.Empty)
                res.code = "username_null";
            else if (account.GetData("password") == string.Empty)
                res.code = "password_null";
            else
                res = currentUser.getLoginInfo(account);
  /*          res.code = "null";*/
            return res;

        }
   
    }
}
