using System;
class Test4{
    public static void Print(){
        //  By the default constructor
        Hotel booking1 = new Hotel();

        // Creating an object using the parameterized constructor
        Console.WriteLine("Enter guestName By Parameter Constructor");
        string guestName=Console.ReadLine();
        Console.WriteLine("Enter roomType By Parameter Constructor");
        string roomType=Console.ReadLine();
        Console.WriteLine("Enter nights By Parameter Constructor");
        int nights=Convert.ToInt32(Console.ReadLine());
        Hotel booking2 = new Hotel(guestName,roomType,nights);

        // Creating an object using the copy constructor
        Hotel booking3 = new Hotel(booking2);

        // Displaying booking details
        Console.WriteLine("Booking 1  (Default):");
        booking1.info();

        Console.WriteLine("\nBooking 2  (Parameterized):");
        booking2.info();

        Console.WriteLine("\nBooking 3  (Copy):");
        booking3.info();
    }
}

public class Hotel{
    private string guestName;
    private string roomType;
    private int nights;
    // Default constructor
    public Hotel(){
        guestName = "ABCD";
        roomType = "XYZ";
        nights = 5;
    }

    // Parameterized constructor
    public Hotel(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public Hotel(Hotel other){
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

   //to display detail
    public void info(){
        Console.WriteLine("Guest Name: "+this.guestName);
        Console.WriteLine($"Room Type: "+this.roomType);
        Console.WriteLine($"Nights: "+this.nights);
    }
}

