using System;
class DistanceConversion
{
	public static void distance(){
		double km = 10.8;
        double conv = 1.6;
        double miles = km / conv;
        Console.WriteLine($"The distance {km} km in miles is {miles:F2}");
		
	
	}
}