using VehicleRegistrationSystem;

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[2];
        int vehicleCount = 0;

        Console.WriteLine("Welcome to the Vehicle Registration System!");

        while (true)
        {
            Console.WriteLine("\n1. Register Vehicle");
            Console.WriteLine("2. Display Vehicle Details");
            Console.WriteLine("3. Update Registration Fee");
            Console.WriteLine("4. Display Total Registered Vehicles");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Register a new vehicle
                    if (vehicleCount >= vehicles.Length)
                    {
                        // Double the array size when full
                        Array.Resize(ref vehicles, vehicles.Length * 2);
                    }

                    Console.Write("Enter Owner Name: ");
                    string ownerName = Console.ReadLine();

                    Console.Write("Enter Vehicle Type (Car, Bike, Truck, etc.): ");
                    string vehicleType = Console.ReadLine();

                    Console.Write("Enter Registration Number: ");
                    string regNumber = Console.ReadLine();

                    // Creating new vehicle object
                    vehicles[vehicleCount] = new Vehicle(ownerName, vehicleType, regNumber);
                    vehicleCount++;
                    Console.WriteLine("Vehicle registered successfully!");
                    break;

                case 2:
                    // Display vehicle details
                    Console.Write("Enter Registration Number: ");
                    string searchRegNumber = Console.ReadLine();

                    bool found = false;
                    foreach (var vehicle in vehicles)
                    {
                        if (vehicle != null && vehicle.RegistrationNumber == searchRegNumber)
                        {
                            Vehicle.DisplayVehicleDetails(vehicle);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Vehicle not found.");
                    }
                    break;

                case 3:
                    // Update registration fee
                    Console.Write("Enter new Registration Fee: ");
                    double newFee = double.Parse(Console.ReadLine());
                    Vehicle.UpdateRegistrationFee(newFee);
                    break;

                case 4:
                    // Display total registered vehicles
                    Vehicle.DisplayTotalVehicles();
                    break;

                case 5:
                    // Exit program
                    Console.WriteLine("Exiting... Thank you!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}