using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB.BusinessLogic
{
    public static class Orders
    {
        private static List<Order> _orders = new List<Order>();
        public static Order[] CompletedOrders{get{return _orders.ToArray();} }

        public static void NewOrder(Dictionary<string, int> purchased) 
        {
            Order o = new Order(purchased);
            _orders.Add(o);
        }
    }
}
