using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserAccount
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
        public int permissionId { get; set; }
    }
    public class UserPermission
    {
        public int permisstionId
        {
            get; set;
        }
        public string permissionType
        {
            get; set;
        }
    }

}
