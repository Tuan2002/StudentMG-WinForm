﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserAccess:DatabaseAccess
    {
        public Response getLoginInfo(UserAccount account)
        {
            Response res = hanndleLogin(account);
            return res;
        }
    }
}