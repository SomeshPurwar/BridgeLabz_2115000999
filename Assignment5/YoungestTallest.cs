using System;

public class YoungestTallest
{
    public static void print()
    {
        Console.WriteLine("Enter Amar's age:");
        int amarAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age:");
        int akbarAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age:");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Amar's height (in cm):");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Akbar's height (in cm):");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Anthony's height (in cm):");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        string youngest = "";
        int youngestAge = Math.Min(Math.Min(amarAge, akbarAge), anthonyAge);

        if (youngestAge == amarAge)
        {
            youngest = "Amar";
        }
        else if (youngestAge == akbarAge)
        {
            youngest = "Akbar";
        }
        else
        {
            youngest = "Anthony";
        }

        string tallest = "";
        double tallestHeight = Math.Max(Math.Max(amarHeight, akbarHeight), anthonyHeight);

        if (tallestHeight == amarHeight)
        {
            tallest = "Amar";
        }
        else if (tallestHeight == akbarHeight)
        {
            tallest = "Akbar";
        }
        else
        {
            tallest = "Anthony";
        }

        Console.WriteLine($"\nYoungest friend: {youngest}");
        Console.WriteLine($"Tallest friend: {tallest}");
    }
}