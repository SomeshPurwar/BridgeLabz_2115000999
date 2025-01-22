using System;

class EarthVolume
{
    public static void volume()
    {
        double radiusKm = 6378;
        double conv = 1.6;

        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double radiusMiles = radiusKm / conv;
        double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        Console.WriteLine($"The volume of Earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
    }
}
