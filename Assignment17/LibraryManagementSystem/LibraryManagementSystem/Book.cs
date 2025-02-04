using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        public static string LibraryName = "GLAU Central Library";

        // Readonly variable for ISBN to ensure the unique identifier cannot be changed
        public readonly string ISBN;

        private string title;
        private string author;

        // Constructor to initialize Title, Author, and ISBN using 'this'
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.ISBN = isbn;
        }

        // Static method to display the library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
        }

        // Method to display book details
        public string GetBookDetails()
        {
            return $"Title: {title}\nAuthor: {author}\nISBN: {ISBN}";
        }

        // Method to check if the object is of type Book using 'is'
        public static void DisplayBookDetails(object obj)
        {
            if (obj is Book book)
            {
                Console.WriteLine(book.GetBookDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Book.");
            }
        }
    }
}
