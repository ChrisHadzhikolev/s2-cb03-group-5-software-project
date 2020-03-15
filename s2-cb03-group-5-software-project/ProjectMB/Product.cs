using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    class Product
    {
        public string Name{ get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }



        public Product()
        { 
        }
    }
}
