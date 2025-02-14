using System;

class QuickSort
{
    static void Main()
    {
        double[] productPrices = { 59.99, 20.50, 99.75, 5.99, 45.00, 30.99, 75.50 };
        Console.WriteLine("Original Product Prices:");
        PrintArray(productPrices);

        QuickSortPrices(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("\nSorted Product Prices:");
        PrintArray(productPrices);
    }

    static void QuickSortPrices(double[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSortPrices(arr, low, pi - 1);
            QuickSortPrices(arr, pi + 1, high);
        }
    }

    static int Partition(double[] arr, int low, int high)
    {
        double pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }

    static void Swap(double[] arr, int a, int b)
    {
        double temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    static void PrintArray(double[] arr)
    {
        foreach (double price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
}
