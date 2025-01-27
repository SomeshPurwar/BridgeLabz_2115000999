// 6. Calculate Simple Interest
// Write a program to calculate simple interest using the formula:
// Simple Interest = (Principal * Rate * Time) / 100.
// Take Principal, Rate, and Time as inputs from the user.

using System;

class SimpleInterest
{
    static void Main()
    {

        Console.WriteLine("Enter the Principal:");
        double p = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the Rate:");
        double r = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the Time:");
        double t = Convert.ToDouble(Console.ReadLine());

		
		
        double si= (p*r*t)/100;

        Console.WriteLine("The simple interest is " + si ); 
    }
}
