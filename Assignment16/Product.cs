using System;
class Test7{
    public static void Print(){
        Console.Write("Product Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Product product1 = new Product(productName, price);
        Console.Write("Product Name: ");
        string productName2 = Console.ReadLine();
        Console.Write("Price: ");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Product product2 = new Product(productName2, price2);
    
        product1.DisplayProductDetails();
        Console.ReadKey();
        product2.DisplayProductDetails();        
        Console.ReadKey();
        Product.DisplayTotalProducts();
    }
}

public class Product{
    private string productName;
    private double price;
    private static int totalProducts = 0;

    public Product(string productName, double price){
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails(){
        Console.WriteLine("\nProduct Name: "+productName);
        Console.WriteLine("Price: INR "+price+"\n");
    }

    public static void DisplayTotalProducts(){
        Console.WriteLine("\nTotal Products: "+totalProducts);
    }
}
