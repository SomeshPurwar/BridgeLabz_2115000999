using System;

public class UnitConverter
{
	public static void print()
    {

        Console.Write("Enter kilometers to convert to miles: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Miles: " + ConvertKmToMiles(km));

        Console.Write("Enter miles to convert to kilometers: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kilometers: " + ConvertMilesToKm(miles));

        Console.Write("Enter meters to convert to feet: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Feet: " + ConvertMetersToFeet(meters));

        Console.Write("Enter feet to convert to meters: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Meters: " + ConvertFeetToMeters(feet));
    }
	
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

    
}
