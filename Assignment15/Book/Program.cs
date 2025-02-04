using System;
class Test
{
	// Main method to test the class
    static void Main()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Console.Write("Enter book price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // Creating an object of Book
        Book book = new Book(title, author, price);
        Console.WriteLine("\nBook Details:");
        book.display();
    }
	
}
class Book
{
    // Attributes
    public string Title;
    public string Author;
    public double Price;

    // Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display book details
    public void display()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: Inr " + Price);
    }

    
}
