using System;

public class LeapYearWithSigleIf
{
    public static void print()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
        {
            Console.WriteLine("Leap Year.");
        }
        else if (year < 1582)
        {
            Console.WriteLine("Invalid year. Leap Year calculations are valid only for years >= 1582.");
        }
        else
        {
            Console.WriteLine("Not a Leap Year.");
        }

    }
}