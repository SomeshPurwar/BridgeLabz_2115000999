using System;

public class EuclideanDistance
{
    public static void print()
    {
        Console.WriteLine("Enter x1, y1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter x2, y2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance}");

        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation of the line: y = {lineEquation[0]}x + {lineEquation[1]}");
    }

    static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double[] GetLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return new double[] { slope, yIntercept };
    }
}
