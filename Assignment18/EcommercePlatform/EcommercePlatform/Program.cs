using System;
using EcommercePlatform;

class Program
{
    static void Main()
    {
        // Create Products
        Product product1 = new Product("Laptop", 129999.00);
        Product product2 = new Product("Smartphone", 18999.00);
        Product product3 = new Product("Headphones", 999.00);

        // Create a Customer
        Customer customer = new Customer("Somesh Purwar");

        // Create Orders for the Customer
        Order order1 = new Order("ORD1", customer);
        order1.addProduct(product1);
        order1.addProduct(product2);

        Order order2 = new Order("ORD2", customer);
        order2.addProduct(product3);

        // Customer places orders
        customer.placeOrder(order1);
        customer.placeOrder(order2);

        // Show customer orders and details
        customer.showOrders();
    }
}