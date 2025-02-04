using System;

namespace ShoppingCartSystem
{
    public class Product
    {
        // Static variable shared by all products (Discount in percentage)
        public static double Discount = 10.0;

        // Readonly variable for unique product ID
        public readonly int ProductID;

        // Instance variables
        private string productName;
        private double price;
        private int quantity;

        // Constructor using 'this' to initialize ProductName, Price, and Quantity
        public Product(int productId, string productName, double price, int quantity)
        {
            this.ProductID = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        // Static method to update discount percentage
        public static void UpdateDiscount(double newDiscount)
        {
            if (newDiscount >= 0 && newDiscount <= 100)
            {
                Discount = newDiscount;
                Console.WriteLine($"Discount updated to {Discount}%.");
            }
            else
            {
                Console.WriteLine("Invalid discount value. Please enter a percentage between 0 and 100.");
            }
        }

        // Method to calculate final price after discount
        public double GetFinalPrice()
        {
            return price *  (1 - Discount / 100);
        }

        // Method to display product details
        public string GetProductDetails()
        {
            return $"Product ID: {ProductID}\nProduct Name: {productName}\nPrice: ${price}\nQuantity: {quantity}\nFinal Price after {Discount}% Discount: ${GetFinalPrice()}";
        }

        // Method to validate if an object is an instance of Product class
        public static void DisplayProductDetails(object obj)
        {
            if (obj is Product product)
            {
                Console.WriteLine(product.GetProductDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Product.");
            }
        }
    }
}
