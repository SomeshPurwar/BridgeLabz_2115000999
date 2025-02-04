using System;
class Test11{
    public static void Print(){
        Console.WriteLine("Enter ISBN:");
        string isbn = Console.ReadLine();
        Console.WriteLine("Enter Title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Author:");
        string author = Console.ReadLine();
        Book2 book = new Book2(isbn, title, author);
        Console.WriteLine("\nBook Details:");
        book.DisplayBookDetails();
        Console.ReadKey();
        Console.WriteLine("Enter Format: for EBook");
        string format = Console.ReadLine();

        EBook eBook = new EBook(isbn, title, author, format);
        Console.WriteLine("\nEBook Details:");
        eBook.DisplayEBookDetails();

        Console.ReadKey();
        Console.WriteLine("\nUpdate Author");
        Console.WriteLine("Enter new Author:");
        string newAuthor = Console.ReadLine();
        book.SetAuthorName(newAuthor);

        Console.WriteLine("\nUpdated Book Details:");
        book.DisplayBookDetails();
    }
}

public class Book2{
    public string ISBN;
    protected string title;
    private string author;
    public Book2(string ISBN, string title, string author){
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }
    public string GetAuthorName(){
        return author;
    }
    public void SetAuthorName(string newAuthor){
        author = newAuthor;
    }
    public void DisplayBookDetails(){
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
    }
}

public class EBook : Book2{
    private string format;
    public EBook(string ISBN, string title, string author, string format) 
        : base(ISBN, title, author){
        this.format = format;
    }

    public void DisplayEBookDetails(){
        Console.WriteLine("ISBN: "+ISBN);
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Format: "+format);
        Console.WriteLine("Author: "+GetAuthorName());
    }
}
