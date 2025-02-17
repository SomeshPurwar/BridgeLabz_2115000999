using System;
using System.Diagnostics;

class SortingComparison
{
    
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                   
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    
    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
            arr[k++] = left[i] < right[j] ? left[i++] : right[j++];

        while (i < left.Length) arr[k++] = left[i++];
        while (j < right.Length) arr[k++] = right[j++];
    }

    
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]); 
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    
    static double MeasureExecutionTime(Action<int[]> sortingMethod, int[] arr)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        sortingMethod(arr);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000; 
    }

    static void Main()
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        Console.WriteLine("Dataset Size | Bubble Sort (ms) | Merge Sort (ms) | Quick Sort (ms)");
        Console.WriteLine("------------------------------------------------------------------");

        foreach (int size in datasetSizes)
        {
            int[] dataBubble, dataMerge, dataQuick;

            
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = random.Next(0, size);

            
            dataBubble = (int[])data.Clone();
            dataMerge = (int[])data.Clone();
            dataQuick = (int[])data.Clone();

            double bubbleTime = (size > 10000) ? double.PositiveInfinity : MeasureExecutionTime(BubbleSort, dataBubble);
            double mergeTime = MeasureExecutionTime(MergeSort, dataMerge);
            double quickTime = MeasureExecutionTime(arr => QuickSort(arr, 0, arr.Length - 1), dataQuick);

            Console.WriteLine($"{size,11} | {bubbleTime,16:F4} | {mergeTime,15:F4} | {quickTime,14:F4}");
        }
    }
}
