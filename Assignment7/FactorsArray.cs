using System;

public class FactorsArray
{
    public static void print()
    {
        Console.WriteLine("Enter a number to find its factors:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive number.");
            return;
        }

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }

                factors[index] = i;
                index++;
            }
        }

        Console.WriteLine($"\nFactors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
