using System;

public class LeapYear
{
    public static void print()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 1582)
        {
            Console.WriteLine("Invalid year. Leap Year calculations are valid only for years >= 1582.");
        }else if (year % 4 != 0)
        {
            Console.WriteLine("Not a Leap Year.");
        }else if (year % 100 == 0 && year % 400 != 0)
        {
            Console.WriteLine("Not a Leap Year.");
        }else
        {
            Console.WriteLine("Leap Year.");
        }
    }
}