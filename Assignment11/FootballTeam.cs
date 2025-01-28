using System;

public class FootballTeam
{
    public static void print()
    {
        int[] heights = GenerateRandomHeights(11, 150, 250);

        Console.Write("Heights of players (in cms): ");
		foreach(int i in heights){
			Console.Write($"{i}  ");
		}
		Console.WriteLine();

        Console.WriteLine("Shortest Height: " + FindShortestHeight(heights) + " cm");
        Console.WriteLine("Tallest Height: " + FindTallestHeight(heights) + " cm");
        Console.WriteLine("Mean Height: " + CalculateMeanHeight(heights).ToString("F2") + " cm");
    }
	
    static int[] GenerateRandomHeights(int size, int min, int max)	
    {
        Random random = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(min, max + 1);
        }
        return heights;
    }

    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int height in array)
        {
            sum += height;
        }
        return sum;
    }

    static double CalculateMeanHeight(int[] array)
    {
        int sum = CalculateSum(array);
        return (double)sum / array.Length;
    }

    static int FindShortestHeight(int[] array)
    {
        int shortest = array[0];
        foreach (int height in array)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    static int FindTallestHeight(int[] array)
    {
        int tallest = array[0];
        foreach (int height in array)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
