using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UserManager
    {
        static DBManager itiDb = new DBManager();

        public static UsersList SelectAll ()
        {
            DataTable dt = itiDb.ExecuteDataTable("select * from users");
            // maping data table to 
            return UserUtils.FromDataTableToUserList(dt);

        }
        public static int Register (User user)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"pId", user.id},
                { "pName", user.name },
                { "pEmail", user.email },
                { "pPassword", user.password },
                { "pActive", user.isActive }
            };

            return itiDb.ExecuteNonQuery("RegisterUser @pId, @pName, @pEmail, @pPassword, @pActive", dict);
        }

        public static User GetUserById (string userId)
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from users where id = '{userId}'");

            return UserUtils.FromDataTableToUserList(dt)[0];
        }

        public static int UpdateUserData (string userId, bool isActive, bool isAdmin, bool isCustomer)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"id", userId},
                {"active", isActive == true ? 1 : 0},
                {"customer", isCustomer  == true ? 1 : 0},
                {"admin", isAdmin == true ? 1 : 0 }
            };

            return itiDb.ExecuteNonQuery("updateUserData @id, @active, @customer, @admin", dict);

        }

        public static User GetUserByEmail (string email)
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from users where email = '{email}'");

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return UserUtils.FromDataTableToUserList(dt)[0];
        }

        



    }
}
