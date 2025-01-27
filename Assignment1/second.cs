// 2. Add Two Numbers
// Write a program that takes two numbers as input from the user and prints
// their sum.

using System;

class Sum
{
    static void Main()
    {

        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine()); 
		
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        int res = a + b;

        Console.WriteLine("The sum of " + a + " and " + b + " is: " + res); 
    }
}
