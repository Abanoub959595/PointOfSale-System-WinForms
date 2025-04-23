using BLL.Entities;
using BLL.EntityList;
using BLL.Helper;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public static class CartItmeManager
    {
        static DBManager itiDb = new DBManager();

        public static int AddToCart (CartItem cartItem)
        {

            if (UserManager.GetUserById(cartItem.UserId) == null || ProductManager.GetProductById(cartItem.ProductId) == null)
            {
                return 0;
            }

            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"id", cartItem.Id},
                {"userId", cartItem.UserId},
                {"prodId ",cartItem.ProductId },
                {"itemQuantity", cartItem.Quantity},
            };


            return itiDb.ExecuteNonQuery("AddItemToCart @id, @userId, @prodId, @itemQuantity", dict);

        }

        public static CartItem CHKCartExistance (string userId,  string productId)
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from cartItem where UserId = '{userId}' and ProductId = '{productId}'");
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return cartItemUtils.FromDataTableToCartItemList(dt)[0];
        }

        public static int UpdateCartQuantity (string cartId, int reqQuantity)
        {
            CartItem cart = GetCartById(cartId);

            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"id", cartId},
                {"quantity", reqQuantity},
            };

            return itiDb.ExecuteNonQuery($"update cartItem set Quantity = @quantity where id = @id", dict);
        }

        public static CartItem GetCartById(string cartId)
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from cartItem where Id = '{cartId}'");
            return cartItemUtils.FromDataTableToCartItemList(dt)[0];
        }

        public static CartItemList GetCartForUser (string UserId)
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from cartItem where UserId = '{UserId}'");
            return cartItemUtils.FromDataTableToCartItemList(dt);
        }

        public static int RemoveFromCart (string cartId)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"cartId", cartId},

            };

            return itiDb.ExecuteNonQuery($"delete from cartItem where Id = @cartId", dict);
            
        }

        public static CartItemList SelectAll ()
        {
            DataTable dt = itiDb.ExecuteDataTable($"select * from cartItem");
            return cartItemUtils.FromDataTableToCartItemList(dt);
        }

    }
}
