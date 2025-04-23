using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal discountPrice { get; set; }
        public int stockQuantity { get; set; } = 0;
        public string imgUrl { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime createdAt { get; set; }= DateTime.Now;

    }
}
