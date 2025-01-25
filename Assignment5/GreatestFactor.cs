using System;

public class GreatestFactor
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break; 
            }
        }

        Console.WriteLine($"The greatest factor of {number} is: {greatestFactor}");
    }
}