using System;

public class NumberChecker3
{
    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsNeon(int num)
    {
        int square = num * num;
        int sumOfDigits = 0;
        while (square != 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == num;
    }

    public static bool IsSpy(int num)
    {
        int sum = 0, product = 1;
        while (num != 0)
        {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int num)
    {
        int square = num * num;
        while (square >= 10)
        {
            if (square % 10 != num % 10)
            {
                return false;
            }
            square /= 10;
            num /= 10;
        }
        return true;
    }

    public static bool IsBuzz(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }

    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is {number} a prime number? {IsPrime(number)}");
        Console.WriteLine($"Is {number} a neon number? {IsNeon(number)}");
        Console.WriteLine($"Is {number} a spy number? {IsSpy(number)}");
        Console.WriteLine($"Is {number} an automorphic number? {IsAutomorphic(number)}");
        Console.WriteLine($"Is {number} a buzz number? {IsBuzz(number)}");
    }
}
