using BLL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentaionLayer
{
    internal class UserSession
    {
        public static string? UserId { get; private set; }  // Nullable means no user is logged in if null
        public static string Username { get; private set; }
        public static bool IsAdmin { get; private set; }
        public static bool IsCustomer { get; private set; }
        public static bool IsLoggedIn => !UserId.IsNullOrEmpty(); // User is logged in if UserId is not null

        public static void Login(User user)
        {
            UserId = user.id;
            Username = user.name;
            IsAdmin = user.isAdmin;
            IsCustomer = user.isCustomer;
        }

        public static void Logout()
        {
            UserId = null;
            Username = null;
            IsAdmin = false;
            IsCustomer = false;
        }

    }
}
