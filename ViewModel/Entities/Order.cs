using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Order : EntityBase
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; } = "Pending";
        public string ShippingAddress { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User Customer { get; set; }
    }
}
