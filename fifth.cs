// 5. Volume of a Cylinder
// Write a program to calculate the volume of a cylinder. Take the radius and
// height as inputs and use the formula:
// Volume = π * radius^2 * height.

using System;

class CylinderVolume
{
    static void Main()
    {

        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine()); 
		
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());

        double res = Math.PI * Math.Pow(radius,2) * height;

        Console.WriteLine("The volume of cylinder is " + res); 
    }
}

