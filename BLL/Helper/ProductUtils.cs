using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class ProductUtils
    {
        public static ProductList FromDataTableToProductList (DataTable dt)
        {
            ProductList productList = new ProductList();
            foreach(DataRow dr in dt.Rows)
            {
                productList.Add(FromDataRowToProduct(dr));
            }
            return productList;
        }

        public static Product FromDataRowToProduct (DataRow dr)
        {
            Product product = new Product();
            product.id = dr[0]?.ToString() ?? "NA";
            product.name = dr[1]?.ToString() ?? "NA";
            product.description = dr[2]?.ToString() ;

            if (decimal.TryParse(dr[3]?.ToString() ?? "-1", out decimal prodPrice))
                product.price = prodPrice;

            if (decimal.TryParse(dr[4]?.ToString() ?? "-1", out decimal DisCountPrice))
                product.discountPrice = DisCountPrice;

            if (int.TryParse(dr[5]?.ToString() ?? "-1", out int prodStock))
                product.stockQuantity = prodStock;

            product.imgUrl = dr[6]?.ToString() ?? "NA";


            if (DateTime.TryParse(dr[7]?.ToString(), out DateTime created))
                product.createdAt = created;
            else
                product.createdAt = null;


            return product;
        }


    }
}
