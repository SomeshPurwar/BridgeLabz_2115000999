using System;

class DoubleOperation
{
    public static void calculate()
    {
        Console.Write("Enter the value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3} and {result4}");
    }
}
