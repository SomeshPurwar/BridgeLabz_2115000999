// 9. Calculate Average of Three Numbers
// Write a program that takes three numbers as input from the user and prints
// their average.

using System;

class Average3Numbers
{
    static void Main()
    {

        Console.WriteLine("Enter the first number:");
        double a = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the second number:");
        double b = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the third number:");
        double c = Convert.ToDouble(Console.ReadLine());

		
		
        double res= (a+b+c)/3;

        Console.WriteLine("The average is " + res ); 
    }
}
