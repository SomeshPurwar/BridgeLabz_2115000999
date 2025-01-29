using System;

public class Calculator
{
    public static void print()
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Choose an operation (1-4): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result = Subtract(num1, num2);
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = Multiply(num1, num2);
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice! Please select a valid operation.");
                break;
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}