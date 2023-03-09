using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using COM;

namespace DAL
{
    public class UserAccess:DatabaseAccess
    {
        public Response getLoginInfo(Request loginReq)
        {
            Response res = hanndleLogin(loginReq);
            return res;
        }
    }
}
