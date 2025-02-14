using System;

class HeapSort
{
    static void Main()
    {
        double[] salaryDemands = { 50000, 60000, 45000, 70000, 55000, 65000, 48000 };
        Console.WriteLine("Original Salary Demands:");
        PrintArray(salaryDemands);

        HeapSortSalaries(salaryDemands);

        Console.WriteLine("\nSorted Salary Demands:");
        PrintArray(salaryDemands);
    }

    static void HeapSortSalaries(double[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);
            Heapify(arr, i, 0);
        }
    }

    static void Heapify(double[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            Swap(arr, i, largest);
            Heapify(arr, n, largest);
        }
    }

    static void Swap(double[] arr, int a, int b)
    {
        double temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    static void PrintArray(double[] arr)
    {
        foreach (double salary in arr)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }
}
