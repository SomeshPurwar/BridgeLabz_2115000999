using System;

class Program
{
    static void Main()
    {
        int[] arr = { 15, 18, 2, 3, 6, 12 };

        int rotationIndex = FindRotationPoint(arr);

        Console.WriteLine($"The smallest element is at index: {rotationIndex}");
        Console.WriteLine($"Smallest element: {arr[rotationIndex]}");
    }

    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right])
            {
                
                left = mid + 1;
            }
            else
            {
                
                right = mid;
            }
        }

        return left; 
    }
}
