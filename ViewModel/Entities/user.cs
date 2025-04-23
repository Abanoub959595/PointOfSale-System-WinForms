using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime createdAt { get; set; } = DateTime.Now;

    }
}
