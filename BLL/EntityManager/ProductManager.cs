using BLL.Helper;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public class ProductManager
    {
        static DBManager itiDb = new DBManager();
        public static ProductList SelectAllAvilable()
        {
            DataTable dt = itiDb.ExecuteDataTable("select * from products where StockQuantity > 0");
            return ProductUtils.FromDataTableToProductList(dt);
        }

        public static ProductList SelectAll()
        {
            DataTable dt = itiDb.ExecuteDataTable("select * from products ");
            return ProductUtils.FromDataTableToProductList(dt);
        }
        public static int insertProduct (Product product)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pId", product.id },
                {"pName", product.name },
                {"pDesc", product.description == null ? DBNull.Value: product.description},
                {"pPrice", product.price },
                {"pDiscount", product.discountPrice == null ? DBNull.Value : product.discountPrice },
                {"pStock", product.stockQuantity },
                {"pImage", product.imgUrl },
            };
            return itiDb.ExecuteNonQuery("InsertProduct @pId, @pName, @pDesc, @pPrice, @pDiscount, @pStock, @pImage", dict);
        }


        public static Product GetProductById (string id)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict["id"] = id;
            var res = itiDb.ExecuteDataTable($"select * from Products where ProductID ='{id}'");
            if (res.Rows.Count == 0)
                return null;
            return ProductUtils.FromDataTableToProductList(res)[0];
        }

        public static int updateProduct(Product product)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pId", product.id },
                {"pName", product.name },
                {"pDesc", product.description == null ? DBNull.Value: product.description},
                {"pPrice", product.price },
                {"pDiscount", product.discountPrice == null ? DBNull.Value : product.discountPrice },
                {"pStock", product.stockQuantity },
                {"pImage", product.imgUrl },
            };
            return itiDb.ExecuteNonQuery("UpdateProduct @pId, @pName, @pDesc, @pPrice, @pDiscount, @pStock, @pImage", dict);
        }


        public static int DeleteProduct (string id)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"id", id},
            };


            return itiDb.ExecuteNonQuery("delete from products where ProductID = '{@id}'", dict);
        }



        public static bool ValidToDelete (string id)
        {
            var res = CartItmeManager.SelectAll();
            foreach(var item in res)
            {
                if (item.ProductId == id)
                    return false;
            }
            var res02 = OrderItemsManager.SelectAll();
            foreach(var item in res02)
            {
                if (item.ProductId == id)
                    return false;
            }
            return true;
        }


    }
}
