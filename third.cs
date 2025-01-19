// 3. Celsius to Fahrenheit Conversion
// Write a program that takes the temperature in Celsius as input and converts
// it to Fahrenheit using the formula:
// Fahrenheit = (Celsius * 9/5) + 32.

using System;

class TemperatureConversion
{
    static void Main()
    {

        Console.WriteLine("Enter the temperature in celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine()); 
		
        double fahrenheit= (celsius * 9/5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is " + fahrenheit); 
    }
}
