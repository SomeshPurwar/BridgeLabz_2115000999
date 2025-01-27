// 4. Area of a Circle
// Write a program to calculate the area of a circle. Take the radius as input
// and use the formula:
// Area = π * radius^2.

using System;

class CircleArea
{
    static void Main()
    {

        Console.WriteLine("Enter the radius of circle:");
        double r = Convert.ToDouble(Console.ReadLine()); 
		
        double area= Math.PI * Math.Pow(r,2);

        Console.WriteLine("The area of circle with radius " + r + " is " + area); 
    }
}
