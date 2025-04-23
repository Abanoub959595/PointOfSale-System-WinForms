using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product : EntityBase
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }
        public decimal? discountPrice { get; set; }
        public int stockQuantity { get; set; } = 0;
        public string imgUrl { get; set; }
        public DateTime? createdAt { get; set; }= DateTime.Now;

        public override string ToString()
        {
            return $"{id} - {name} - {description} - {price} - {discountPrice} - {stockQuantity} - {imgUrl} ";
        }

    }
}
