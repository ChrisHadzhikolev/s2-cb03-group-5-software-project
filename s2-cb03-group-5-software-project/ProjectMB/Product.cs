using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class Product
    {
        public int id;
        public string Name{ get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, ProductCategory category, double price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
        public Product(string name, ProductCategory category, double price, int quantity, int id)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            this.id = id;
        }
        public override string ToString()
        {
            return $"Name: {Name} Category: {Category} Quantity: {Quantity} Price: {Price}";
        }
    }
}
