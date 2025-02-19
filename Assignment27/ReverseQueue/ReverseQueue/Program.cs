using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Reverse(Queue<int> queue)
    {
        if (queue.Count == 0) return;

        // Step 1: Dequeue front element
        int front = queue.Dequeue();

        // Step 2: Recursively reverse remaining queue
        Reverse(queue);

        // Step 3: Enqueue the front element at the back
        queue.Enqueue(front);
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });

        Console.WriteLine("Original Queue: " + string.Join(", ", queue));

        Reverse(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}
