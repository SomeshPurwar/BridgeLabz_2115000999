using System;
using System.Collections.Generic;

// Abstract class representing a warehouse item
public abstract class WarehouseItem
{
    public string Name;
    public double Price;

    protected WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// Electronics category
public class Electronics : WarehouseItem
{
    public string Brand;

    public Electronics(string name, double price, string brand) : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Price: Rs.{Price}");
    }
}

// Groceries category
public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate;

    public Groceries(string name, double price, DateTime expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Groceries: {Name}, Expiry Date: {ExpiryDate.ToShortDateString()}, Price: Rs.{Price}");
    }
}

// Furniture category
public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Furniture: {Name}, Material: {Material}, Price: Rs.{Price}");
    }
}

// Generic storage class with constraints
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}

// Main execution
class Program
{
    static void Main()
    {
       
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 120000.50, "Dell"));
        electronicsStorage.AddItem(new Electronics("Smartphone", 8999.99, "Samsung"));

        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries("Milk", 30.50, DateTime.Now.AddDays(10)));
        groceriesStorage.AddItem(new Groceries("Bread", 20.00, DateTime.Now.AddDays(5)));

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 1500.75, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 3000.40, "Metal"));

        Console.WriteLine("Electronics Storage:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\nGroceries Storage:");
        groceriesStorage.DisplayItems();

        Console.WriteLine("\nFurniture Storage:");
        furnitureStorage.DisplayItems();
    }
}
