using System;

public class Factors
{
	public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        int sum = FindSum(factors);
        Console.WriteLine("Sum of Factors: " + sum);

        int product = FindProduct(factors);
        Console.WriteLine("Product of Factors: " + product);

        double sumOfSquares = FindSumOfSquares(factors);
        Console.WriteLine("Sum of Squares of Factors: " + sumOfSquares);
    }
	
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static int FindProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double FindSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    
}
