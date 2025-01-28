using System;

public class Collinear
{
    public static void print()
    {
        Console.WriteLine("Enter coordinates of point A (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point B (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point C (x3, y3):");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        bool collinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool collinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine($"Collinear by Slope Method: {collinearBySlope}");
        Console.WriteLine($"Collinear by Area Method: {collinearByArea}");
    }

    static bool ArePointsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return Math.Abs(slopeAB - slopeBC) < 1e-9 && Math.Abs(slopeAB - slopeAC) < 1e-9;
    }

    static bool ArePointsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9;
    }
}
