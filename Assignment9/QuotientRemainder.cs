using System;

public class QuotientRemainder
{
    public static void print()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be zero.");
        }
        else
        {
            int[] result = FindRemainderAndQuotient(number, divisor);

            Console.WriteLine($"The quotient is {result[0]}");
            Console.WriteLine($"The remainder is {result[1]}");
        }
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}