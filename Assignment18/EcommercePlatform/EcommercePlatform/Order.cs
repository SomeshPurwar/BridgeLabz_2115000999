using System;
using System.Collections.Generic;

namespace EcommercePlatform
{
    class Order
    {
        public string ordId;
        public Customer customer;
        private List<Product> products;

        public Order(string ordId, Customer customer) 
        {
            this.ordId = ordId;
            this.customer = customer;
            products = new List<Product>();        
        }

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public double getPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.price;
            }
            return totalPrice;
        }

        public void showOrderDetails()
        {
            Console.WriteLine($"Order ID: {ordId}");
            Console.WriteLine($"Customer: {customer.name}");
            Console.WriteLine("Products in Order:");
            foreach (var product in products)
            {
                Console.WriteLine($"  Product: {product.name}, Price: {product.price} Rs.");
            }
            Console.WriteLine($"Total Price: {getPrice()} Rs.");
        }
    }
}
