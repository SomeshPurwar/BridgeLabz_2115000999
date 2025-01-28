using System;

public class NaturalNumberSum
{
    public static void print()
    {
        Console.Write("Enter a positive integer (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            int sum = CalculateSum(n);
            Console.WriteLine($"The sum of the first {n} natural numbers is {sum}.");
        }
    }

    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
