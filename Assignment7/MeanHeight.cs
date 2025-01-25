using System;

public class MeanHeight
{
    public static void print()
    {
        double[] heights = new double[11];
        double sum = 0.0;

        Console.WriteLine("Enter the heights of 11 players (in cm):");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        double mean = sum / heights.Length; 
        Console.WriteLine($"\nThe mean height of the football team is: {mean:F2} cm");
    }
}
