using System;

class TravelComputation
{
    public static void calculate()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();
        
        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();
        
        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from {0} to {1} in miles: ", fromCity, viaCity);
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the distance from {0} to {1} in miles: ", viaCity, toCity);
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken from {0} to {1} (hours and minutes) as hours: ", fromCity, viaCity);
        int timeFromToVia = Convert.ToInt32(Console.ReadLine());
        
        
        Console.Write("Enter the time taken from {0} to {1} (hours and minutes) as hours: ", viaCity, toCity);
        int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());

        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;


        Console.WriteLine($"The results of the trip are: \nTotal Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} miles \nTotal Time taken for the journey is {totalTime} hours");
    }
}
