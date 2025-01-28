using System;

public class UnitConverter1
{
	public static void print()
    {
        Console.Write("Enter yards to convert to feet: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Feet: " + ConvertYardsToFeet(yards));

        Console.Write("Enter feet to convert to yards: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yards: " + ConvertFeetToYards(feet));

        Console.Write("Enter meters to convert to inches: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inches: " + ConvertMetersToInches(meters));

        Console.Write("Enter inches to convert to meters: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Meters: " + ConvertInchesToMeters(inches));

        Console.Write("Enter inches to convert to centimeters: ");
        inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Centimeters: " + ConvertInchesToCentimeters(inches));
    }
  
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    
}
