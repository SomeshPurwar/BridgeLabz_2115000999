using System;

public class DateComparision
{
    public static void print()
    {
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date (yyyy-MM-dd): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        int comparisonResult = DateTime.Compare(firstDate, secondDate);

        if (comparisonResult < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("The two dates are the same.");
        }
    }
}