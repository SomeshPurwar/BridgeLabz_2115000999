using System;
class Test9{
    public static void Print(){
        Console.WriteLine("Enter owner name:");
        string OwnerName = Console.ReadLine();
        Console.WriteLine("Enter vehicle type:");
        string VehicleType = Console.ReadLine();
        Vehicle vehicle = new Vehicle(OwnerName, VehicleType);
        vehicle.DisplayVehicleDetails();
        Console.WriteLine("Enter New registration fee:");
        double newFee = Convert.ToDouble(Console.ReadLine());
        Vehicle.UpdateRegistrationFee(newFee);
        vehicle.DisplayVehicleDetails();
    }
}

public class Vehicle{
    private string OwnerName;
    private string VehicleType;
    private static double RegistrationFee = 500;

    public Vehicle(string OwnerName, string VehicleType){
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
    }

    public void DisplayVehicleDetails() {
        Console.WriteLine("\nOwner Name: "+OwnerName);
        Console.WriteLine("Vehicle Type: "+VehicleType);
        Console.WriteLine("Registration Fee: ₹ "+RegistrationFee+"\n");
    }

    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }
}
