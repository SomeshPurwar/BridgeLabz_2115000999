using System;

public class HarshadNumber
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sumOfDigits = 0;

        while (originalNumber > 0)
        {
            int digit = originalNumber % 10;
            sumOfDigits += digit;
            originalNumber /= 10;
        }

        if (number % sumOfDigits == 0)
        {
            Console.WriteLine($"{number} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad number.");
        }
    }
}