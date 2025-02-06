using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryBookAggregation
{
    //Aggregation: Contains a list of books, but books exist independently
    public class Library
    {
        public string name;
        List<Book> books;

        public Library(string name)
        {
            this.name = name;
            books = new List<Book>();
        }

        public void addBook(Book book)
        {
            books.Add(book);
        }

        public void displayBooks()
        {
            Console.WriteLine($"Library: {name} \nBooks Available:");
            foreach (var book in books)
            {
                book.display();
            }
        }
    }
}
