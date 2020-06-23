using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectMB.BusinessLogic
{
    public static class Orders
    {
        public static List<Order> _orders = new List<Order>();
        public static Order[] CompletedOrders{get{return _orders.ToArray();} }

        public static void NewOrder(Order o) 
        {
            //Order o = new Order(purchased);
           // MessageBox.Show(o.ToString());
           _orders.Add(o);
        }
    }
}
