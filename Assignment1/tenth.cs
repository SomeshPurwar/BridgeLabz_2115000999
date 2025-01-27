// 10. Convert Kilometers to Miles
// Write a program that takes the distance in kilometers as input from the user
// and converts it into miles using the formula:
// Miles = Kilometers * 0.621371.

using System;

class DistanceConversion
{
    static void Main()
    {

        Console.WriteLine("Enter the distance in kilometers:");
        double km = Convert.ToDouble(Console.ReadLine()); 
		
        double miles= km*0.621371		;

        Console.WriteLine("The distance in miles of " + km + " kilometers is " + miles); 
    }
}
