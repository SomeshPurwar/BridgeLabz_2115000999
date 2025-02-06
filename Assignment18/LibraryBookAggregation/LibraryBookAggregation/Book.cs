using System;
using System.Collections.Generic;

namespace LibraryBookAggregation
{
    public class Book
    {
        public string title;
        public string author;
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void display()
        {
            Console.WriteLine($"Book: {title}, Author: {author}");
        }




    }
}
