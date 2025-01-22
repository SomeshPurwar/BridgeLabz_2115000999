using System;

class TriangleArea
{
    public static void calculate()
    {
        Console.Write("Enter the base of the triangle in inches: ");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle in inches: ");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        double areaInches = 0.5 * baseInches * heightInches;
        double areaCm = areaInches * 6.4516; 

        Console.WriteLine($"The area of the triangle in square inches is {areaInches:F2} and in square centimeters is {areaCm:F2}");
    }
}
