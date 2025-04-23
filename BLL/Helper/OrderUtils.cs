using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class OrderUtils
    {
        public static OrdersList FromDataTableToOrderList (DataTable dt)
        {

            OrdersList orders = new OrdersList ();  
            foreach(DataRow item in  dt.Rows)
            {
                Order order = FromDataRowToOrder (item);
                orders.Add (order);
            }
            return orders;

        }

        public static Order FromDataRowToOrder(DataRow row)
        {

            Order order = new Order()
            {
                OrderId = row["Id"].ToString(),
                UserId = row["UserId"].ToString(),
                Status = row["Status"].ToString(),
                OrderDate = DateTime.TryParse(row["OrderDate"]?.ToString(), out DateTime created) ? created : DateTime.MinValue
            };
            return order;
        }



    }
}
