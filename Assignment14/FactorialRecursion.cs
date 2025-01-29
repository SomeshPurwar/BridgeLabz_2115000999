using System;

public class FactorialRecursion
{
    public static void print()
    {
        int number = GetInput();
        long result = CalculateFactorial(number);
        DisplayResult(number, result);
    }

    static int GetInput()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * CalculateFactorial(n - 1);
    }

    static void DisplayResult(int number, long result)
    {
        Console.WriteLine($"Factorial of {number} is: {result}");
    }
}
