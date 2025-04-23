using BLL.Entities;
using BLL.EntityList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class OrderItemsUtils
    {
        public static OrderItemList FromDataTableToOrderItemList(DataTable dt)
        {
            OrderItemList orders = new OrderItemList();
            foreach(DataRow dr in dt.Rows)
            {
                OrderItem item = FromDataRowToOrderItem(dr);

                orders.Add(item);

            }
            return orders;
        }
        public static OrderItem FromDataRowToOrderItem (DataRow dr)
        {
            return new OrderItem()
            {
                Id = dr["Id"].ToString(),
                OrderId = dr["OrderId"].ToString(),
                ProductId = dr["ProductId"].ToString(),
                Quantity = int.Parse(dr["Quantity"].ToString())
            };
            
        }


    }
}
