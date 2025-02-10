using System;
namespace RideHailingApplication 
{

    // Abstract class Vehicle
    abstract class Vehicle
    {
        private string vehicleId;
        private string driverName;
        protected double ratePerKm;

        public Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public string VehicleId { get { return vehicleId; } }
        public string DriverName { get { return driverName; } }

        public abstract double CalculateFare(double distance);

        public virtual void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per km: Rs.{ratePerKm}");
        }
    }

    // Interface IGPS
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    // Car class
    class Car : Vehicle, IGPS
    {
        public Car(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Car...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Car location updated to: {location}");
        }
    }

    // Bike class
    class Bike : Vehicle, IGPS
    {
        public Bike(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance * 0.9; // Discount for bikes
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Bike...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Bike location updated to: {location}");
        }
    }

    // Auto class
    class Auto : Vehicle, IGPS
    {
        public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance * 1.1; // Additional charges for Auto
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Fetching current location for Auto...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Auto location updated to: {location}");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("V001", "Shubham Das", 10),
            new Bike("V002", "Shubham Singh", 5),
            new Auto("V003", "Somesh Purwar", 7)
        };

            double distance = 15.0; // Example distance

            foreach (var vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: Rs.{vehicle.CalculateFare(distance)}");
                if (vehicle is IGPS gpsEnabled)
                {
                    gpsEnabled.GetCurrentLocation();
                    gpsEnabled.UpdateLocation("Downtown");
                }
                Console.WriteLine();
            }
        }
    }

}