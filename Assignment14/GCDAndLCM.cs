using System;

public class GCDAndLCM
{
    public static void print()
    {
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        DisplayResult(num1, num2, gcd, lcm);
    }

    static int GetInput(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }

    static void DisplayResult(int num1, int num2, int gcd, int lcm)
    {
        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }
}
