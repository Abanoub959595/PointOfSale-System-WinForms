using BLL.Entities;
using BLL.EntityList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public static class cartItemUtils
    {
        public static CartItemList FromDataTableToCartItemList (DataTable dt)
        {
            CartItemList cartItems = new CartItemList ();
            foreach(DataRow item in dt.Rows)
            {
                cartItems.Add(FromDataRowToCartItem(item));
            }
            return cartItems;   
        }

        public static CartItem FromDataRowToCartItem (DataRow dr)
        {
            CartItem cart = new CartItem ();
            cart.Id = dr["Id"].ToString() ?? "NA";
            cart.UserId = dr["UserId"].ToString() ?? "NA";
            cart.ProductId = dr["ProductId"].ToString() ?? "NA";

            if (int.TryParse(dr["Quantity"].ToString() ?? "0", out int reqQuantity))
            {
                cart.Quantity = reqQuantity;
            }

            return cart;
        }

    }
}
