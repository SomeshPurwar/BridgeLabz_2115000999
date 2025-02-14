using System;

class MergeSort
{
    static void Main()
    {
        double[] bookPrices = { 29.99, 15.50, 42.75, 10.99, 25.00, 19.99, 35.50 };
        Console.WriteLine("Original Book Prices:");
        PrintArray(bookPrices);

        MergeSortPrices(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("\nSorted Book Prices:");
        PrintArray(bookPrices);
    }

    static void MergeSortPrices(double[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSortPrices(arr, left, mid);
            MergeSortPrices(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Merge(double[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        double[] leftArr = new double[n1];
        double[] rightArr = new double[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArr[j] = arr[mid + 1 + j];

        int x = 0, y = 0, k = left;
        while (x < n1 && y < n2)
        {
            if (leftArr[x] <= rightArr[y])
                arr[k++] = leftArr[x++];
            else
                arr[k++] = rightArr[y++];
        }

        while (x < n1)
            arr[k++] = leftArr[x++];

        while (y < n2)
            arr[k++] = rightArr[y++];
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