using System;

class TempConversion
{
    public static void calculate()
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheitResult = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius} Celsius is {fahrenheitResult} Fahrenheit");
    }
}
