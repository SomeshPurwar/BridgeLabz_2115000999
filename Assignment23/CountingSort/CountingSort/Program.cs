using System;

class CountingSort
{
    static void Main()
    {
        int[] studentAges = { 12, 15, 14, 11, 18, 10, 16, 13, 17, 12, 14, 11 };
        Console.WriteLine("Original Student Ages:");
        PrintArray(studentAges);

        studentAges = CountingSortAges(studentAges, 10, 18);

        Console.WriteLine("\nSorted Student Ages:");
        PrintArray(studentAges);
    }

    static int[] CountingSortAges(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
            count[arr[i] - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        return output;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int age in arr)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }
}
