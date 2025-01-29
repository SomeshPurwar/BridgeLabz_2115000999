using System;

public class TimeZones
{
    public static void print()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        Console.WriteLine("Current Time in Different Time Zones:");
        
        Console.WriteLine($"GMT (Greenwich Mean Time): {utcNow:yyyy-MM-dd HH:mm:ss} GMT");

        Console.WriteLine($"IST (Indian Standard Time): {utcNow.ToOffset(TimeZoneInfo.FindSystemTimeZoneById("India Standard Time").GetUtcOffset(utcNow)):yyyy-MM-dd HH:mm:ss} IST");

        Console.WriteLine($"PST (Pacific Standard Time): {utcNow.ToOffset(TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time").GetUtcOffset(utcNow)):yyyy-MM-dd HH:mm:ss} PST");
    }
}
