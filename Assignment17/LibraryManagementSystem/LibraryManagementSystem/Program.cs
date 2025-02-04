using LibraryManagementSystem;

class Program
{
    static void Main()
    {
        // Creating an array to store books
        Book[] books = new Book[10];
        int bookCount = 0;
        // Display library name using the static method
        Book.DisplayLibraryName();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a New Book");
            Console.WriteLine("2. Display Book Details");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Add a new book
                    if (bookCount >= books.Length)
                    {
                        // Double the size of the array if it's full
                        Console.WriteLine("Limit Exceed!!");
                    }

                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Book Author: ");
                    string author = Console.ReadLine();

                    Console.Write("Enter Book ISBN: ");
                    string isbn = Console.ReadLine();

                    // Creating a new book object
                    books[bookCount] = new Book(title, author, isbn);
                    bookCount++;
                    Console.WriteLine("Book added successfully!");
                    break;

                case 2:
                    // Display book details
                    Console.Write("Enter ISBN of the book to display details: ");
                    string searchIsbn = Console.ReadLine();

                    bool found = false;
                    foreach (var book in books)
                    {
                        if (book != null && book.ISBN == searchIsbn)
                        {
                            Book.DisplayBookDetails(book);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Book with the given ISBN not found.");
                    }
                    break;

                case 3:
                    // Exit the program
                    Console.WriteLine("Exiting... Thank you for using the Library Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}