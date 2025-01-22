using System;

class SquarePerimeter
{
    public static void calculate()
    {
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
}
