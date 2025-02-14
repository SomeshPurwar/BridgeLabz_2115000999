using System;

class SelectionSort
{
    static void Main()
    {
        int[] examScores = { 85, 72, 90, 60, 78, 88, 95, 68 };
        Console.WriteLine("Original Exam Scores:");
        PrintArray(examScores);

        SelectionSortScores(examScores);

        Console.WriteLine("\nSorted Exam Scores:");
        PrintArray(examScores);
    }

    static void SelectionSortScores(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            Swap(arr, i, minIndex);
        }
    }

    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}
