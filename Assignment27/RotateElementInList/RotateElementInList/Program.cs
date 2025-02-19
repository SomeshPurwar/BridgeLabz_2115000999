using System;
using System.Collections.Generic;

class RotateListExample
{
    static void Reverse(List<int> list, int start, int end)
    {
        while (start < end)
        {
            int temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }
    }

    static void RotateList(List<int> list, int positions)
    {
        int n = list.Count;
        positions = positions % n;

        if (positions == 0) return; 

        
        Reverse(list, 0, positions - 1);   // Reverse first part
        Reverse(list, positions, n - 1);   // Reverse second part
        Reverse(list, 0, n - 1);           // Reverse entire list
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        Console.WriteLine("Original List: " + string.Join(", ", numbers));
        RotateList(numbers, rotateBy);
        Console.WriteLine("Rotated List: " + string.Join(", ", numbers));
    }
}
