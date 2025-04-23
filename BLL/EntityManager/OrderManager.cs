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
    public static class OrderManager
    {
        static DBManager itiDB = new DBManager();
        public static OrdersList SelectAllOrders ()
        {
            DataTable dt = itiDB.ExecuteDataTable($"select * from orders");

            return OrderUtils.FromDataTableToOrderList( dt );
        }

        public static OrdersList GetOrdersForUser(string userId)
        {
            DataTable dt = itiDB.ExecuteDataTable($"select * from orders where userId = '{userId}'");

            return OrderUtils.FromDataTableToOrderList(dt);
        }

        public static int CreateOrder (string userId)
        {
            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("userId", userId);

            return itiDB.ExecuteNonQuery("PlaceOrder @userId", dict);
        }

        public static int UpdateOrderStatus(string orderId,string status)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("orderId", orderId);
            dict.Add("status", status);

            return itiDB.ExecuteNonQuery("UpdateOrderStatusAndReturnStock @orderId, @status", dict);

        }


        public static Order GetOrderById (string orderId)
        {
            DataTable dt = itiDB.ExecuteDataTable($"select * from orders where Id = '{orderId}'");

            return OrderUtils.FromDataTableToOrderList(dt)[0];
        }



    }
}
