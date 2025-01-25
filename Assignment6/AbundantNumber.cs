using System;

public class AbundantNumber
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant number.");
        }
    }
}