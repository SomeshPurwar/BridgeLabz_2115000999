using System;

class FriendsComparison
{
    public static void print()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height (in cm) of {friends[i]}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngest = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngest])
            {
                youngest = i;
            }
        }

        int tallest = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[tallest])
            {
                tallest = i;
            }
        }

        Console.WriteLine($"\nThe youngest friend is {friends[youngest]} with age {ages[youngest]} years.");
        Console.WriteLine($"The tallest friend is {friends[tallest]} with height {heights[tallest]} cm.");
    }
}
