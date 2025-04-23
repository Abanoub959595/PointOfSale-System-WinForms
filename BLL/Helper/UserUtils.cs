using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UserUtils
    {
        public static UsersList FromDataTableToUserList(DataTable dt)
        {
            UsersList users = new UsersList();
            foreach (DataRow dr in dt.Rows)
            {
                User user = FromDataRowToUser(dr);
                users.Add(user);
            }
            return users;
        }
        public static User FromDataRowToUser(DataRow dr)
        {
            User user = new User();

            user.id = dr["Id"]?.ToString() ?? "NA";


            user.name = dr["FullName"]?.ToString() ?? "NA";
            user.email = dr["Email"]?.ToString() ?? "NA";
            user.password = dr["PasswordHash"]?.ToString() ?? "NA";

            


            if (bool.TryParse(dr["Active"]?.ToString(), out bool IsActive))
                user.isActive = IsActive;

            if (DateTime.TryParse(dr["CreatedAt"].ToString(), out DateTime createdAt))
                user.createdAt = createdAt;

            if (bool.TryParse(dr["IsCustomer"]?.ToString(), out bool IsCustomer))
                user.isCustomer = IsCustomer;


            if (bool.TryParse(dr["IsAdmin"]?.ToString(), out bool IsAdmin))
                user.isAdmin = IsAdmin;



            return user;
        }
    }
}
