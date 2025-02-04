using System;

namespace VehicleRegistrationSystem
{
    public class Vehicle
    {
        
            // Static variable for registration fee common for all vehicles
            public static double RegistrationFee = 500.00;

            // Static variable to count total registered vehicles
            private static int totalVehicles = 0;

            // Readonly variable for unique Registration Number
            public readonly string RegistrationNumber;

            // Instance variables
            private string ownerName;
            private string vehicleType;

            // Constructor using 'this' to initialize OwnerName, VehicleType, and RegistrationNumber
            public Vehicle(string ownerName, string vehicleType, string registrationNumber)
            {
                this.ownerName = ownerName;
                this.vehicleType = vehicleType;
                this.RegistrationNumber = registrationNumber;
                totalVehicles++;
            }

            // Static method to update registration fee
            public static void UpdateRegistrationFee(double newFee)
            {
                if (newFee > 0)
                {
                    RegistrationFee = newFee;
                    Console.WriteLine($"Registration fee updated to: {RegistrationFee}");
                }
                else
                {
                    Console.WriteLine("Invalid registration fee. It must be greater than 0.");
                }
            }

            // Static method to display total vehicles registered
            public static void DisplayTotalVehicles()
            {
                Console.WriteLine($"Total Registered Vehicles: {totalVehicles}");
            }

            // Method to get vehicle details
            public string GetVehicleDetails()
            {
                return $"Owner Name: {ownerName}\nVehicle Type: {vehicleType}\nRegistration Number: {RegistrationNumber}\nRegistration Fee: {RegistrationFee}";
            }

            // Method to check if an object is an instance of Vehicle before displaying details
            public static void DisplayVehicleDetails(object obj)
            {
                if (obj is Vehicle vehicle)
                {
                    Console.WriteLine(vehicle.GetVehicleDetails());
                }
                else
                {
                    Console.WriteLine("Invalid object. Not a Vehicle instance.");
                }
            }
        }
}
