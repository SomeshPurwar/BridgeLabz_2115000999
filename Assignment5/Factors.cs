using System;

public class Factors
{
    public static void print()
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors of " + number + ":");

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine(number);
    }
}