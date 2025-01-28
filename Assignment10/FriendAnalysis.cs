using System;

public class FriendAnalysis
{
	public static void print()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {friends[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the height (in cm) of {friends[i]}: ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }

        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        Console.WriteLine($"\nThe youngest friend is {friends[youngestIndex]} with an age of {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {friends[tallestIndex]} with a height of {heights[tallestIndex]} cm.");
    }
	
    public static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    public static int FindTallest(int[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return tallestIndex;
    }

    
}
