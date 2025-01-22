using System;

class Calculator
{
    public static void calculate ()
    {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {division}");
    }
}
