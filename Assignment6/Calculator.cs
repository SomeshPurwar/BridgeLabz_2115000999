using System;

public class Calculator
{
    public static void print()
    {
        Console.WriteLine("Enter the first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        string op = Console.ReadLine();

        double result = 0;

        switch (op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}