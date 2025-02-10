using System;
namespace LibraryManagementSystem
{
    // Abstract class LibraryItem
    abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private string author;

        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public string ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        public abstract int GetLoanDuration();

        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}, Title: {title}, Author: {author}");
        }
    }

    // Interface IReservable
    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    // Book class
    class Book : LibraryItem, IReservable
    {
        public Book(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 14; // 14 days loan period
        }

        public void ReserveItem()
        {
            Console.WriteLine($"Book '{Title}' has been reserved.");
        }

        public bool CheckAvailability()
        {
            return true; // Assume always available for simplicity
        }
    }

    // Magazine class
    class Magazine : LibraryItem
    {
        public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 7; // 7 days loan period
        }
    }

    // DVD class
    class DVD : LibraryItem, IReservable
    {
        public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 5; // 5 days loan period
        }

        public void ReserveItem()
        {
            Console.WriteLine($"DVD '{Title}' has been reserved.");
        }

        public bool CheckAvailability()
        {
            return false; // Assume not available for simplicity
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book("B001", "C# Programming", "XYX"),
            new Magazine("M002", "Technologies", "ABC"),
            new DVD("D003", "C# Tutorial", "C# Corner")
        };

            foreach (var item in libraryItems)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");
                if (item is IReservable reservable)
                {
                    reservable.ReserveItem();
                    Console.WriteLine($"Availability: {(reservable.CheckAvailability() ? "Available" : "Not Available")}");
                }
                Console.WriteLine();
            }
        }
    }

}
