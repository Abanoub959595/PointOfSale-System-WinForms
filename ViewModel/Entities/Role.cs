﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Role : EntityBase
    {
        public int Id { get; set; }
        public string RoleName { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }
    }
}
