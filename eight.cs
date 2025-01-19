// 8. Power Calculation
// Write a program that takes two numbers as input: a base and an exponent,
// and prints the result of base raised to the exponent (without using loops or
// conditionals).

using System;

class PowerCalculation
{
    static void Main()
    {

        Console.WriteLine("Enter the base:");
        double bas = Convert.ToDouble(Console.ReadLine()); 
		
        Console.WriteLine("Enter the exponent:");
        double expo = Convert.ToDouble(Console.ReadLine());

        double res = Math.Pow(bas,expo);

        Console.WriteLine("The result of  " + bas + " to the power " + expo + " is: " + res); 
    }
}
