using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectMB.BusinessLogic
{
    public class Order
    {
        private static int _idSeeder = 0;
        public int Id{get;}
       
        private double totalPrice;
        private Dictionary<string, int> _purchasedItems;
        public Dictionary<string, int> PurchasedItems { get; }
        public DateTime _timestamp { get; private set; }
        public double Costs
        {
            get
            {
                double overall = 0;

                foreach (var item in _purchasedItems.Keys)
                {
                    overall += _purchasedItems[item] * Products.FindProduct(item).Price;
                }

                MessageBox.Show(overall.ToString());
                return overall;

            }
        }
        public Order(Dictionary<string, int> purchasedItems)
        {
            Id = _idSeeder;
            _idSeeder++;
            _purchasedItems = purchasedItems;           
            _timestamp = DateTime.Now;
        }

      

        public Order(int id, string timestamp, double price)
        {
            Id = id;
            _timestamp = DateTime.Parse(timestamp);
            totalPrice = price;
        }

        public double GetTotalPrice()
        {
            return totalPrice;
        }
    }
}
