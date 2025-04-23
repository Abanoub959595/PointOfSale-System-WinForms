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
    public class OrderItemsManager
    {
        static DBManager itiDB = new DBManager();
        
        public static OrderItemList GetItemPassedOnOrderId (string orderId)
        {
            DataTable dt = itiDB.ExecuteDataTable($"select * from OrderItems where OrderId = '{orderId}'");


            return OrderItemsUtils.FromDataTableToOrderItemList(dt);
        }

        public static OrderItemList SelectAll ()
        {
            DataTable dt = itiDB.ExecuteDataTable($"select * from OrderItems ");


            return OrderItemsUtils.FromDataTableToOrderItemList(dt);
        }


    }
}
