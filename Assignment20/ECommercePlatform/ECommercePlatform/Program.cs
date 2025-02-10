using System;
namespace ECommercePlatform
{

    // Abstract class Product
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public Product(int id, string name, double price)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
        }

        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price { get { return price; } set { price = value; } }

        public abstract double CalculateDiscount();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {productId}, Name: {name}, Price: Rs. {price}");
        }
    }

    // Interface ITaxable
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // Electronics class
    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.1; // 10% discount
        }

        public double CalculateTax()
        {
            return Price * 0.15; // 15% tax
        }

        public string GetTaxDetails()
        {
            return "Tax: 15%";
        }
    }

    // Clothing class
    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.2; // 20% discount
        }

        public double CalculateTax()
        {
            return Price * 0.05; // 5% tax
        }

        public string GetTaxDetails()
        {
            return "Tax: 5%";
        }
    }

    // Groceries class
    class Groceries : Product
    {
        public Groceries(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 100000),
            new Clothing(2, "T-Shirt", 500),
            new Groceries(3, "Apple", 200)
        };

            foreach (var product in products)
            {
                product.DisplayDetails();
                double discount = product.CalculateDiscount();
                double tax = (product is ITaxable taxable) ? taxable.CalculateTax() : 0;
                double finalPrice = product.Price + tax - discount;
                Console.WriteLine($"Final Price: Rs. {finalPrice}");
                if (product is ITaxable taxDetails)
                {
                    Console.WriteLine(taxDetails.GetTaxDetails());
                }
                Console.WriteLine();
            }
        }
    }

}