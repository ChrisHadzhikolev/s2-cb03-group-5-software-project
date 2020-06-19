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
        public string Receipt 
        {
            get 
            {
                string receipt = "";
                const string LINE = "------------------------------";
                receipt += "         Media Bazaar\n" + LINE + "\n" + _timestamp.ToString() + "\n";
                foreach (var item in PurchasedItems.Keys)
                {
                    receipt += PurchasedItems[item] + " x " + Products.FindProduct(item).Name + "\n";
                }
                receipt += LINE;
                receipt += $"\nOverall:       {Costs.ToString("C2", CultureInfo.CurrentCulture)}";
                receipt += "\n" + LINE +  "\n Thank you for choosing Media Bazaar!";
                return receipt;

            }
        }
        public Dictionary<string, int> PurchasedItems { get; }
        public DateTime _timestamp { get; private set; }
        public double Costs 
        {
            get 
            {
                double overall = 0;
                foreach (var item in PurchasedItems.Keys)
                {
                   // MessageBox.Show("duh");
                    overall += PurchasedItems[item] * Products.FindProduct(item).Price;
                }
                return overall;                   
            } 
        }

        public Order(Dictionary<string, int> purchasedItems)
        {
            Id = _idSeeder;
            _idSeeder++;
            PurchasedItems = purchasedItems;
            _timestamp = DateTime.Now;
        }
    }
}
