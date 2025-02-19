using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Stores product prices
    private LinkedList<KeyValuePair<string, double>> cartOrder = new LinkedList<KeyValuePair<string, double>>(); // Maintains order of addition
    private SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>(); // Sorts by product name

    // Add a product to the cart
    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            sortedCart[product] = price;
        }
        cartOrder.AddLast(new KeyValuePair<string, double>(product, price));
    }

    // Display products in the order they were added
    public List<KeyValuePair<string, double>> GetCartOrder()
    {
        return cartOrder.ToList();
    }

    // Display products sorted by name
    public SortedDictionary<string, double> GetSortedCart()
    {
        return new SortedDictionary<string, double>(sortedCart);
    }

    // Display products sorted by price
    public List<KeyValuePair<string, double>> GetCartSortedByPrice()
    {
        return productPrices.OrderBy(p => p.Value).ToList();
    }

    // Calculate total cost
    public double GetTotalCost()
    {
        return productPrices.Values.Sum();
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Add products to the cart
        cart.AddProduct("Laptop", 800);
        cart.AddProduct("Headphones", 50);
        cart.AddProduct("Mouse", 20);
        cart.AddProduct("Keyboard", 30);

        // Display order of added items
        Console.WriteLine("Cart in Order of Addition:");
        foreach (var item in cart.GetCartOrder())
        {
            Console.WriteLine($"{item.Key}: Rs.{item.Value}");
        }

        // Display sorted products by name
        Console.WriteLine("\nCart Sorted by Name:");
        foreach (var item in cart.GetSortedCart())
        {
            Console.WriteLine($"{item.Key}: Rs.{item.Value}");
        }

        // Display sorted products by price
        Console.WriteLine("\nCart Sorted by Price:");
        foreach (var item in cart.GetCartSortedByPrice())
        {
            Console.WriteLine($"{item.Key}: Rs.{item.Value}");
        }

        // Display total cost
        Console.WriteLine($"\nTotal Cost: Rs.{cart.GetTotalCost()}");
    }
}
