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

        //public static ProductCategory productCategory;

       public static Product FindProductByName(string name)
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
    }
}
