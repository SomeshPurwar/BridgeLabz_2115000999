using System;

public class MaximumOfThree
{
    public static void print()
    {
        int num1 = GetIntegerInput("Enter the first number: ");
        int num2 = GetIntegerInput("Enter the second number: ");
        int num3 = GetIntegerInput("Enter the third number: ");

        int max = FindMaximum(num1, num2, num3);

        Console.WriteLine($"The maximum of the three numbers is: {max}");
    }

    static int GetIntegerInput(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }

        return max;
    }
}
