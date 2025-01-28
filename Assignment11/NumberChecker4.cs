using System;

public class NumberChecker4
{
    public static int[] FindFactors(int num)
    {
        int count = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public static int FindGreatestFactor(int num)
    {
        int[] factors = FindFactors(num);
        return factors[factors.Length - 1];
    }

    public static int SumOfFactors(int num)
    {
        int[] factors = FindFactors(num);
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static int ProductOfFactors(int num)
    {
        int[] factors = FindFactors(num);
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double ProductOfCubeOfFactors(int num)
    {
        int[] factors = FindFactors(num);
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    public static bool IsPerfect(int num)
    {
        int sum = SumOfFactors(num) - num;
        return sum == num;
    }

    public static bool IsAbundant(int num)
    {
        int sum = SumOfFactors(num) - num;
        return sum > num;
    }

    public static bool IsDeficient(int num)
    {
        int sum = SumOfFactors(num) - num;
        return sum < num;
    }

    public static bool IsStrong(int num)
    {
        int sum = 0;
        int temp = num;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == num;
    }

    public static int Factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        int fact = 1;
        for (int i = 2; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }

    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Factors of {number}: {string.Join(", ", FindFactors(number))}");
        Console.WriteLine($"Greatest factor of {number}: {FindGreatestFactor(number)}");
        Console.WriteLine($"Sum of factors of {number}: {SumOfFactors(number)}");
        Console.WriteLine($"Product of factors of {number}: {ProductOfFactors(number)}");
        Console.WriteLine($"Product of cubes of factors of {number}: {ProductOfCubeOfFactors(number)}");
        Console.WriteLine($"Is {number} a perfect number? {IsPerfect(number)}");
        Console.WriteLine($"Is {number} an abundant number? {IsAbundant(number)}");
        Console.WriteLine($"Is {number} a deficient number? {IsDeficient(number)}");
        Console.WriteLine($"Is {number} a strong number? {IsStrong(number)}");
    }
}
