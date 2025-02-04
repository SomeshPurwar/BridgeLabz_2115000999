// Book Class
// Create a Book class with attributes title, author, and price.
// Provide both default and parameterized constructors.

class test1{
    public static void Print(){
        Console.WriteLine("Enter Title :");
        string title=Console.ReadLine();
        Console.WriteLine("Enter Author :");
        string author=Console.ReadLine();
        Console.WriteLine("Enter Price :");
        int price=Convert.ToInt32(Console.ReadLine());
        Book book1=new Book();
        Book book2=new Book(title,author,price);
        book1.info();
        book2.info();
        
    }
}
class Book{
    private string title;
    private string author;
    private int price;
    public Book(){
        this.title="Great Day";
        this.author="ABCD";
        this.price=5000;
    }
    public Book(string title,string author,int price){
        this.title=title;
        this.author=author;
        this.price=price;
    }


    public void info(){
        Console.WriteLine("_____________----------");
        Console.WriteLine("Title :" + this.title);
        Console.WriteLine("Author :"+this.author);
        Console.WriteLine("Price :"+this.price);
    }

    
}