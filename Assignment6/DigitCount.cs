using System;

public class DigitCount
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());
		int originalNumber=number;

        int count = 0; 

        while (number != 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine($"The number of digits in {originalNumber} is: {count}");
    }
}