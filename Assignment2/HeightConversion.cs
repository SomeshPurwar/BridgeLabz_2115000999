using System;

class HeightConversion
{
    public static void convert()
    {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightInches = heightCm / 2.54;
        double feet = heightInches / 12;
        double inches = heightInches % 12;

        Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet:F2} and inches is {inches:F2}");
    }
}
