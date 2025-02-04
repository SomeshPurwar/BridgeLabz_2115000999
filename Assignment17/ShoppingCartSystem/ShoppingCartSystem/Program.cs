using ShoppingCartSystem;

class Program
{
    static void Main()
    {
        Product[] cart = new Product[2];
        int productCount = 0;

        while (true)
        {
            Console.WriteLine("\nShopping Cart System");
            Console.WriteLine("1. Add Product to Cart");
            Console.WriteLine("2. Display Product Details");
            Console.WriteLine("3. Update Discount");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Adding a new product
                    if (productCount >= cart.Length)
                    {
                        // Double the array size when it's full
                        Array.Resize(ref cart, cart.Length * 2);
                    }

                    Console.Write("Enter Product ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Enter Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    // Creating a new product object
                    cart[productCount] = new Product(id, name, price, quantity);
                    productCount++;
                    Console.WriteLine("Product added to cart successfully!");
                    break;

                case 2:
                    // Display product details
                    Console.Write("Enter Product ID to display details: ");
                    int searchId = int.Parse(Console.ReadLine());

                    bool found = false;
                    foreach (var product in cart)
                    {
                        if (product != null && product.ProductID == searchId)
                        {
                            Product.DisplayProductDetails(product);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Product with the given ID not found.");
                    }
                    break;

                case 3:
                    // Update discount
                    Console.Write("Enter new discount percentage: ");
                    double newDiscount = double.Parse(Console.ReadLine());
                    Product.UpdateDiscount(newDiscount);
                    break;

                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting... Thank you for shopping!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}