using System;

class Program
{
    static int PerformDivision(int numerator, int denominator)
    {
        return numerator / denominator;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = PerformDivision(numerator, denominator);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
