using System;

class BubbleSort
{
    static void Main()
    {
        int[] marks = { 85, 72, 90, 60, 78, 88, 95, 68 };
        Console.WriteLine("Original Marks:");
        PrintArray(marks);

        BubbleSortMarks(marks);

        Console.WriteLine("\nSorted Marks:");
        PrintArray(marks);
    }

    static void BubbleSortMarks(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
           
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
