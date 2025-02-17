using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 5 };

        Console.Write("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());

        var firstIndex = FindOccurrence(arr, target, true);
        var lastIndex = FindOccurrence(arr, target, false);

        if (firstIndex == -1)
            Console.WriteLine($"Target {target} not found in the array.");
        else
            Console.WriteLine($"First occurrence of {target} is at index: {firstIndex}\nLast occurrence of {target} is at index: {lastIndex}");
    }

    static int FindOccurrence(int[] arr, int target, bool findFirst)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; 
                if (findFirst)
                    right = mid - 1; 
                else
                    left = mid + 1; 
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
