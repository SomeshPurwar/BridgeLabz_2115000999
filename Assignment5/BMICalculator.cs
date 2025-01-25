using System;

public class BMICalculator
{
    public static void print()
    {
        Console.WriteLine("Enter your weight in kilograms:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height in centimeters:");
        double height = Convert.ToDouble(Console.ReadLine());

        height = height / 100;
        double BMI = weight / (height * height);

        string status;

        if (BMI <= 18.4)
        {
            status = "Underweight";
        }
        else if (BMI >= 18.5 && BMI <= 24.9)
        {
            status = "Normal";
        }
        else if (BMI >= 25.0 && BMI <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        Console.WriteLine($"\nYour BMI is: {BMI:F2}");
        Console.WriteLine($"Your weight status is: {status}");
    }
}