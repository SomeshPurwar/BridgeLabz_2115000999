using System;

class WeightConversion
{
    public static void calculate()
    {
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        double weightInKg = weightInPounds * 2.2;

        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}");
    }
}
