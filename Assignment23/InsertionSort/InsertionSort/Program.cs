using System;

class InsertionSort
{
    static void Main()
    {
        int[] employeeIDs = { 105, 102, 110, 101, 108, 103, 107 };
        Console.WriteLine("Original Employee IDs:");
        PrintArray(employeeIDs);

        InsertionSortIDs(employeeIDs);

        Console.WriteLine("\nSorted Employee IDs:");
        PrintArray(employeeIDs);
    }

    static void InsertionSortIDs(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }
}
