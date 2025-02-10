using System;
namespace VehicleRentalSystem
{
    using System;
    using System.Collections.Generic;

    // Abstract class Vehicle
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public Vehicle(string number, string type, double rate)
        {
            this.vehicleNumber = number;
            this.type = type;
            this.rentalRate = rate;
        }

        public string VehicleNumber { get { return vehicleNumber; } }
        public string Type { get { return type; } }
        public double RentalRate { get { return rentalRate; } }

        public abstract double CalculateRentalCost(int days);

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}, Type: {type}, Rental Rate: Rs.{rentalRate}");
        }
    }

    // Interface IInsurable
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Car class
    class Car : Vehicle, IInsurable
    {
        public Car(string number, double rate) : base(number, "Car", rate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.1; // 10% insurance
        }

        public string GetInsuranceDetails()
        {
            return "Insurance: 10% of rental rate";
        }
    }

    // Bike class
    class Bike : Vehicle
    {
        public Bike(string number, double rate) : base(number, "Bike", rate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 0.9; // 10% discount
        }
    }

    // Truck class
    class Truck : Vehicle, IInsurable
    {
        public Truck(string number, double rate) : base(number, "Truck", rate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 1.2; // 20% surcharge
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.2; // 20% insurance
        }

        public string GetInsuranceDetails()
        {
            return "Insurance: 20% of rental rate";
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C123", 100),
            new Bike("B456", 50),
            new Truck("T789", 200)
        };

            int rentalDays = 5;
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                double rentalCost = vehicle.CalculateRentalCost(rentalDays);
                double insurance = (vehicle is IInsurable insurable) ? insurable.CalculateInsurance() : 0;
                double finalCost = rentalCost + insurance;
                Console.WriteLine($"Rental Cost for {rentalDays} days: Rs.{rentalCost}");
                Console.WriteLine($"Final Cost (including insurance): Rs.{finalCost}");
                if (vehicle is IInsurable insDetails)
                {
                    Console.WriteLine(insDetails.GetInsuranceDetails());
                }
                Console.WriteLine();
            }
        }
    }

}