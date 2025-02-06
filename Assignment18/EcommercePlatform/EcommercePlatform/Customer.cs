using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace EcommercePlatform
{
    class Customer
    {
        public string name;
        private List<Order> orders; 

        public Customer(string name)
        {
            this.name = name;
            orders = new List<Order>();
        }

        public void placeOrder(Order order)
        {
            orders.Add(order);
        }
        public void showOrders()
        {
            Console.WriteLine($"Customer: {name} has placed the following orders:");
            foreach (var order in orders)
            {
                order.showOrderDetails();
            }
        }
    }
}
