using System;

// Node class for key-value pair in linked list
class Node
{
    public int Key;
    public int Value;
    public Node Next;

    public Node(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

// Custom HashMap Implementation (Separate Chaining)
class CustomHashMap
{
    private const int SIZE = 100; // Hash table size
    private Node[] table;

    public CustomHashMap()
    {
        table = new Node[SIZE];
    }

    // Hash function
    private int GetHash(int key)
    {
        return Math.Abs(key) % SIZE;
    }

    // Insert or update key-value pair
    public void Put(int key, int value)
    {
        int index = GetHash(key);
        Node head = table[index];

        // If bucket is empty, insert new node
        if (head == null)
        {
            table[index] = new Node(key, value);
            return;
        }

        // Traverse linked list to find key or last node
        Node current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value; 
                return;
            }
            if (current.Next == null) break;
            current = current.Next;
        }

        
        current.Next = new Node(key, value);
    }

    // Get value associated with a key
    public int Get(int key)
    {
        int index = GetHash(key);
        Node current = table[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }

        return -1; // Return -1 if key not found
    }

    // Check if key exists in hash map
    public bool ContainsKey(int key)
    {
        return Get(key) != -1;
    }
}

class ZeroSumSubarrays
{
    static void FindZeroSumSubarrays(int[] arr)
    {
        CustomHashMap sumMap = new CustomHashMap(); 
        int cumSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            cumSum += arr[i]; 

            
            if (cumSum == 0)
            {
                Console.WriteLine($"Subarray with zero sum found: (0, {i})");
            }

         
            if (sumMap.ContainsKey(cumSum))
            {
                int start = sumMap.Get(cumSum) + 1;
                Console.WriteLine($"Subarray with zero sum found: ({start}, {i})");
            }

           
            sumMap.Put(cumSum, i);
        }
    }

    static void Main()
    {
        int[] arr = { 4, 2, -3, 1, 6, -4, -3, 3 };
        FindZeroSumSubarrays(arr);
    }
}
