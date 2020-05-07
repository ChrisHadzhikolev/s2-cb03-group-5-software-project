using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public static class Products
    {
        public static List<Product> products = new List<Product>();

       public static Product FindProduct(string name)
       {
            foreach (var item in products)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
       }

        public static Product FindProduct(int id)
        {
            foreach (var item in products)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Product[] FindProducts(ProductCategory category)
        {
            List<Product> products = new List<Product>();
            foreach (var item in products)
            {
                if (item.Category == category)
                {
                    products.Add(item);
                }
            }
            return products.ToArray();
        }
    }
}
