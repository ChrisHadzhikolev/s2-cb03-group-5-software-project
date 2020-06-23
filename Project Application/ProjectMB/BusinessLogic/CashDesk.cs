using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectMB.BusinessLogic
{
    public class CashDesk
    {
        public Dictionary<string, int> Items { get; set; }
        public Dictionary<string, int> Cart { get; set; }
        public double Revenue { get; set; }


        public CashDesk()
        {
            Items = new Dictionary<string, int>();
            LoadProducts();
            Cart = new Dictionary<string, int>();
        }
        private void LoadProducts() 
        {
            DatabaseFunctions.GetAllProducts();
            foreach (var item in Products.products)
            {                
                Items.Add(item.Name, item.Quantity);
            }
        }       

        public bool AddItemToCart(Product product, int quantity)
        {
            if (quantity < 1) throw new ArgumentException("Quantity should be at least 1");           
            if (Items.ContainsKey(product.Name))
            {
                if (Items[product.Name] >= quantity)
                {
                    if (Cart.ContainsKey(product.Name))
                    {
                        Cart[product.Name] += quantity;
                        return true;
                    }
                    else
                    {
                        Cart.Add(product.Name, quantity);
                        return true;
                    }
                }
                else
                {
                    throw new ArgumentException("Not enough items in stock");
                }
            }
            else
            {
                throw new ArgumentException("No Such Item");
            }
        }
        public bool RemoveItemFromCart(Product product, int quantity)
        {
            if (Cart.ContainsKey(product.Name))
            {
                if (Cart[product.Name] >= quantity)
                {
                    if (Cart[product.Name] == quantity)
                    {
                        Cart.Remove(product.Name);
                    }
                    else
                    {
                        Cart[product.Name] -= quantity;
                    }
                    return true;
                }
                else
                {
                    throw new ArgumentException("requested quantity is bigger than quantity in card");
                }
            }
            else
            {
                throw new ArgumentException("no such item in cart");
            }
        }
        public double Purchase()
        {
            if (Cart.Count > 0)
            {
                double price = 0;
                foreach (var item in Cart.Keys)
                {                    
                    price += Cart[item] * Products.FindProduct(item).Price;
                    Items[item] -= Cart[item];
                    Products.FindProduct(item).Quantity = Items[item] - Cart[item];
                    DatabaseFunctions.UpdateProduct(Products.FindProduct(item));
                }
                DatabaseFunctions.GetAllProducts();
                //Orders.NewOrder(Cart);

                
                Cart.Clear();
                Revenue += price;
                return price;
            }
            else
            {
                throw new ArgumentException("Empty Cart");
            }
        }


    }
}
