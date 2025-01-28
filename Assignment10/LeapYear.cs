using System;

public class LeapYear
{
	public static void print()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("The program only works for years >= 1582.");
            return;
        }

        if (IsLeapYear(year))
        {
            Console.WriteLine("The year " + year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not a Leap Year.");
        }
    }
	
    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            return false;
        }
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    
}
