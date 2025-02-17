using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 };
        Console.WriteLine($"First missing positive integer: {FindFirstMissingPositive(nums)}");

        Console.Write("Enter the target value for Binary Search: ");
        int target = int.Parse(Console.ReadLine());

        Array.Sort(nums); 
        int targetIndex = BinarySearch(nums, target);

        if (targetIndex != -1)
            Console.WriteLine($"Target {target} found at index: {targetIndex}");
        else
            Console.WriteLine($"Target {target} not found in the array.");
    }

    // Function to find the first missing positive integer
    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                Swap(nums, i, nums[i] - 1);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return n + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Function to perform binary search
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; 
    }
}
