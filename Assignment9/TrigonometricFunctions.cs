using System;

public class TrigonometricFunctions
{
    public static void print()
    {
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());

        double[] trigResults = CalculateTrigonometricFunctions(angleInDegrees);

        Console.WriteLine($"Sine: {trigResults[0]}");
        Console.WriteLine($"Cosine: {trigResults[1]}");
        Console.WriteLine($"Tangent: {trigResults[2]}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double angleInRadians = angle * (Math.PI / 180);

        double sine = Math.Round(Math.Sin(angleInRadians),2);
        double cosine = Math.Round(Math.Cos(angleInRadians),2);
        double tangent = Math.Round(Math.Tan(angleInRadians),2);        
        return new double[] { sine, cosine, tangent };
    }
}
using System;

public class TrigonometricFunctions
{
    public static void print()
    {
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());

        double[] trigResults = CalculateTrigonometricFunctions(angleInDegrees);

        Console.WriteLine($"Sine: {trigResults[0]}");
        Console.WriteLine($"Cosine: {trigResults[1]}");
        Console.WriteLine($"Tangent: {trigResults[2]}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double angleInRadians = angle * (Math.PI / 180);

        double sine = Math.Round(Math.Sin(angleInRadians),2);
        double cosine = Math.Round(Math.Cos(angleInRadians),2);
        double tangent = Math.Round(Math.Tan(angleInRadians),2);        
        return new double[] { sine, cosine, tangent };
    }
}
