using System;

class UserInputDistConv
{
    public static void convert()
    {
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double conv = 1.6;
        double miles = km / conv;
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km");
    }
}