﻿using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main()
    {
        
        PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

     
        triageQueue.Enqueue("John", 3);
        triageQueue.Enqueue("Alice", 5);
        triageQueue.Enqueue("Bob", 2);

        Console.WriteLine("Treatment Order:");
        while (triageQueue.Count > 0)
        {
            Console.WriteLine(triageQueue.Dequeue());
        }
    }
}
