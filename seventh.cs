// 7. Perimeter of a Rectangle
// Write a program to calculate the perimeter of a rectangle. Take the length
// and width as inputs and use the formula:
// Perimeter = 2 * (length + width).

using System;

class RectanglePerimeter
{
    static void Main()
    {

        Console.WriteLine("Enter the length:");
        double length = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the width:");
        double width = Convert.ToDouble(Console.ReadLine());
		
		

		
		
        double perimeter= 2 * (length+width);

        Console.WriteLine("The Perimeter of rectangle is " + perimeter ); 
    }
}
