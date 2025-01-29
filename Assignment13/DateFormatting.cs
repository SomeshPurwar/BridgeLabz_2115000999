using System;

public class DateFormatting
{
    public static void print()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Current Date in Different Formats:");
        Console.WriteLine($"dd/MM/yyyy: {currentDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"yyyy-MM-dd: {currentDate.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"EEE, MMM dd, yyyy: {currentDate.ToString("EEE, MMM dd, yyyy")}");
    }
}