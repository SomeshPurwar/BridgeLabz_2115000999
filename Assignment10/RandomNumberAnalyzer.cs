using System;
public class RandomNumberAnalyzer
{
	public static void print(){
		int[] randomNumbers = RandomNumberAnalyzer.Generate4DigitRandomArray(5);
        double[] analysis = RandomNumberAnalyzer.FindAverageMinMax(randomNumbers);
        
        Console.WriteLine("\nGenerated 4-digit numbers: " + string.Join(", ", randomNumbers));
        Console.WriteLine($"Average: {analysis[0]:F2}, Min: {analysis[1]}, Max: {analysis[2]}");
	}

    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1000, 10000); // 4-digit numbers
        }
        return numbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0], max = numbers[0];
        
        foreach (int num in numbers)
        {
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        return new double[] { sum / numbers.Length, min, max };
    }
}