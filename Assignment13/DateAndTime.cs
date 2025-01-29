using System;

public class DateAndTime
{
    public static void print()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        DateTime result = inputDate
            .AddDays(7)        
            .AddMonths(1)       
            .AddYears(2)       
            .AddDays(-21);
			

        Console.WriteLine($"Resulting Date: {result:yyyy-MM-dd}");
    }
}
