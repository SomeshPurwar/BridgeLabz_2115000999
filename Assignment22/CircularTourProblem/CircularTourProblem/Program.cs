using System;

// Node class for custom queue
class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// Custom Queue Implementation
class CustomQueue
{
    private Node front, rear;
    private int size;

    public CustomQueue()
    {
        front = rear = null;
        size = 0;
    }

    // Add element to the queue (enqueue)
    public void Enqueue(int item)
    {
        Node newNode = new Node(item);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
        size++;
    }

    // Remove element from the queue (dequeue)
    public int Dequeue()
    {
        if (IsEmpty()) return -1;

        int item = front.Data;
        front = front.Next;
        if (front == null)
            rear = null;

        size--;
        return item;
    }

    // Get front element without removing it
    public int Peek()
    {
        return IsEmpty() ? -1 : front.Data;
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return front == null;
    }

    // Get size of queue
    public int Size()
    {
        return size;
    }
}

// Circular Tour Implementation Using Custom Queue
class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        CustomQueue queue = new CustomQueue();

        int start = 0, surplus = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            int netGain = petrol[i] - distance[i];
            surplus += netGain;
            queue.Enqueue(i);

            
            while (surplus < 0 && !queue.IsEmpty())
            {
                int removedPump = queue.Dequeue();
                deficit += petrol[removedPump] - distance[removedPump];
                start = removedPump + 1;
                surplus = 0;
            }
        }

        return (surplus + deficit >= 0) ? start : -1;
    }
}

class Program
{
    static void Main()
    {
        int[] petrol = { 4, 8, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startPump = CircularTour.FindStartingPump(petrol, distance);

        Console.WriteLine(startPump == -1 ? "No possible tour" : $"Start at pump index: {startPump}");
    }
}
