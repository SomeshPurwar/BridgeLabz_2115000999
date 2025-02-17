using System;
using System.Diagnostics;

class SearchComparison
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    
    static int BinarySearch(int[] arr, int target)
    {
        return Array.BinarySearch(arr, target);
    }

    
    static double MeasureExecutionTime(Func<int[], int, int> searchMethod, int[] arr, int target)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        searchMethod(arr, target);
        stopwatch.Stop();

       
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000;
    }

    static void Main()
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        Console.WriteLine("Dataset Size | Linear Search (ms) | Binary Search (ms)");
        Console.WriteLine("------------------------------------------------------");

        foreach (int size in datasetSizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = i; 

            int target = random.Next(0, size); 

            double linearTime = MeasureExecutionTime(LinearSearch, data, target);
            double binaryTime = MeasureExecutionTime(BinarySearch, data, target);

            Console.WriteLine($"{size,11} | {linearTime,19:F6} | {binaryTime,18:F6}");
        }
    }
}
