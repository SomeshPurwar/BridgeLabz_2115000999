using System;
class Test6{
    public static void Print(){
        Console.WriteLine("Enter customer name :");
        string Name = Console.ReadLine();
        Console.WriteLine("Enter car model :");
        string Model = Console.ReadLine();
        Console.WriteLine("Enter rental days:");
        int Days = Convert.ToInt32(Console.ReadLine());

        CarRental rental = new CarRental(Name,Model,Days);
        rental.info();
        rental.TotalCost();
    }
}

public class CarRental{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double rentalRate = 99.01;

    public CarRental(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    public void info(){
        Console.WriteLine("\nCustomer Name: "+customerName);
        Console.WriteLine("Car Model: "+carModel);
        Console.WriteLine("Rental Days: "+rentalDays);
    }

    public void TotalCost(){
        double totalCost = rentalDays * rentalRate;
        Console.WriteLine("Total Cost: INR "+totalCost);
    }
}
