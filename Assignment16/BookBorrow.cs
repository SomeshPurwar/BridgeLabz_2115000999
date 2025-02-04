using System;
class Test5{
    public static void Print(){
        Console.WriteLine("Enter Book Title :");
        string title=Console.ReadLine();
        Console.WriteLine("Enter Book Athour :");
        string author=Console.ReadLine();
        Console.WriteLine("Enter Book Price :");
        int price=Convert.ToInt32(Console.ReadLine());
        BookBorrow book1 = new BookBorrow(title,author,price,true);

        // details of the book
        book1.info();


        // Borrowing the book
        Console.WriteLine("\nBorrow the book...");
        book1.BorrowBook();

    
        Console.WriteLine("\n book detail:");
        book1.info();

        // borrow the same book again
        Console.WriteLine("\nAttempt to borrow again...");
        book1.BorrowBook();

    }
}
public class BookBorrow{
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    // Constructor 
    public BookBorrow(string title, string author, double price, bool isAvailable){
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    // to borrow the book
    public void BorrowBook(){
        if (isAvailable){
            Console.WriteLine("You have borrowed "+title +" by " +author);
            isAvailable = false; 
        }else{
            Console.WriteLine(title+" is currently unavailable.");
        }
    }

    //display detail
    public void info(){
        Console.WriteLine("Title: "+this.title);
        Console.WriteLine($"Author: "+this.author);
        Console.WriteLine($"Price: "+this.price);
        Console.WriteLine($"Availability: "+(isAvailable ? "Available" : "Not Available"));
    }
}

