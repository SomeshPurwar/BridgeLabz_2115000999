using LibraryBookAggregation;
using System;

class Program
{
    static void Main()
    {
        //Creating Books
        Book b1 = new Book("Ramayan", "Valmiki");
        Book b2 = new Book("Book2", "xyz");
        Book b3 = new Book("Book3", "abc");

        // Creating libraries
        Library l1 = new Library("GLA Central Library");
        Library l2 = new Library("GLA AB2 Library");

        // Adding Books to library
        l1.addBook(b1);
        l1.addBook(b2);
        l2.addBook(b3);
        l2.addBook(b1);

        // Display books in library
        l1.displayBooks();
        Console.WriteLine();
        l2.displayBooks();


    }
}