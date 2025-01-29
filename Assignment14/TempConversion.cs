using System;

public class TempConversion
{
    public static void print()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.Write("Choose an option (1 or 2): ");
        
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)
        {
            double celsius = FahrenheitToCelsius(temperature);
            Console.WriteLine($"{temperature}°F is equal to {celsius:F2}°C");
        }
        else if (choice == 2)
        {
            double fahrenheit = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C is equal to {fahrenheit:F2}°F");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please select 1 or 2.");
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}