using System;

public class ArmstrongNumber
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10; 
            sum += remainder * remainder * remainder; 
            originalNumber /= 10; 
        }

        if (number == sum)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }

    }
}