using System;

public class AthleteRounds
{
    public static void print()
    {
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = CalculatePerimeter(side1, side2, side3);
        double totalDistance = 5000; 
        int rounds = CalculateRounds(perimeter, totalDistance);

        Console.WriteLine($"The athlete needs to complete {rounds} rounds to run 5 km in the park.");
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static int CalculateRounds(double perimeter, double totalDistance)
    {
        return (int)Math.Ceiling(totalDistance / perimeter);
    }
}
