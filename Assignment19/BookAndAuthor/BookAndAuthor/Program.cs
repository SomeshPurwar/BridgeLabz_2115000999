using System;
using System.Xml.Linq;
namespace BookAndAuthor
{
    class Book
    {
        public string title;
        public int publicationYear;

        public Book(string title, int publicationYear)
        {
            this.title = title;
            this.publicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}, Publication Year: {publicationYear}");

        } 
    }

    class Author : Book
    {
        public string name;
        public string bio;

        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            this.name = name;
            this.bio = bio;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Author..");
            base.DisplayInfo();
            Console.WriteLine($"Author: {name}, Bio: {bio}");

        }
    }

    class Program
    {
        static void Main()
        {
            Book author = new Author("Godaan",1936 , "Munshi Premchand", "Themed around the socio-economic deprivation as well as the exploitation of the village poor, the novel was the last complete novel of Premchand.");
            author.DisplayInfo();
        }
    }
} 