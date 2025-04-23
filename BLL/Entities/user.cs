using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User : EntityBase
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; } = true;
        public bool isCustomer { get; set; }
        public bool isAdmin { get; set; } 
        public DateTime createdAt { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"User Email : {email} - Active {isActive} iscutomer {isCustomer} isadmin {isAdmin}";
        }

    }
}
