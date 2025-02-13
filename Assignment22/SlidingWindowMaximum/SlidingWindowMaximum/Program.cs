using System;

class Node
{
    public int Data;
    public Node Next;
    public Node Prev;

    public Node(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

// Custom Deque Implementation
class CustomDeque
{
    private Node front, rear;

    public CustomDeque()
    {
        front = rear = null;
    }

    // Add element to the front
    public void AddFirst(int item)
    {
        Node newNode = new Node(item);
        if (front == null)
        {
            front = rear = newNode;
        }
        else
        {
            newNode.Next = front;
            front.Prev = newNode;
            front = newNode;
        }
    }

    // Add element to the back
    public void AddLast(int item)
    {
        Node newNode = new Node(item);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            newNode.Prev = rear;
            rear = newNode;
        }
    }

    // Remove element from the front
    public void RemoveFirst()
    {
        if (front == null) return;

        front = front.Next;
        if (front != null)
            front.Prev = null;
        else
            rear = null;
    }

    // Remove element from the back
    public void RemoveLast()
    {
        if (rear == null) return;

        rear = rear.Prev;
        if (rear != null)
            rear.Next = null;
        else
            front = null;
    }

    // Peek front element
    public int PeekFirst()
    {
        return front != null ? front.Data : -1;
    }

    // Peek rear element
    public int PeekLast()
    {
        return rear != null ? rear.Data : -1;
    }

    // Check if deque is empty
    public bool IsEmpty()
    {
        return front == null;
    }
}

// Function to find sliding window maximum
class SlidingWindowMax
{
    public static int[] FindMaxInWindows(int[] arr, int k)
    {
        if (arr.Length == 0 || k == 0) return new int[0];

        int n = arr.Length;
        int[] result = new int[n - k + 1];
        CustomDeque deque = new CustomDeque();

        for (int i = 0; i < n; i++)
        {
            // Remove elements out of window
            if (!deque.IsEmpty() && deque.PeekFirst() < i - k + 1)
            {
                deque.RemoveFirst();
            }

            while (!deque.IsEmpty() && arr[deque.PeekLast()] <= arr[i])
            {
                deque.RemoveLast();
            }

           
            deque.AddLast(i);

            
            if (i >= k - 1)
            {
                result[i - k + 1] = arr[deque.PeekFirst()];
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = SlidingWindowMax.FindMaxInWindows(arr, k);

        Console.WriteLine("Sliding Window Maximum: " + string.Join(", ", result));
    }
}
