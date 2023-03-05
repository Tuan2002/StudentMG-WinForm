using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{

    public class MiddleWare
    {
        UserAccess currentUser = new UserAccess();
        public Response validateForm(UserAccount account)
        {
            Response res = new Response();
            if (account.userName == string.Empty)
                res.code = "username_null";
            else if (account.userPassword == string.Empty)
                res.code = "password_null";
            else
            res = currentUser.getLoginInfo(account);
            return res;

        }
    }
}
