using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, -5, 40, -10, 50 };

        int result = FindFirstNegative(numbers);

        if (result != int.MaxValue)
            Console.WriteLine($"First negative number found: {result}");
        else
            Console.WriteLine("No negative number found in the array.");
    }

    static int FindFirstNegative(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
                return num;
        }

        return int.MaxValue; // Return a special value if no negative number is found
    }
}
