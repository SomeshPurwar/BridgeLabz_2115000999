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

// Custom HashMap Implementation
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
        return key % SIZE;
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

        // Insert new node at end of list (separate chaining)
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

        return -1;
    }

    // Remove a key from the hash map
    public void Remove(int key)
    {
        int index = GetHash(key);
        Node current = table[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    table[index] = current.Next;
                else
                    prev.Next = current.Next;

                return;
            }
            prev = current;
            current = current.Next;
        }
    }

    // Check if key exists in hash map
    public bool ContainsKey(int key)
    {
        return Get(key) != -1;
    }
}
class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        CustomHashMap map = new CustomHashMap();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return new int[] { map.Get(complement), i };

            map.Put(nums[i], i);
        }

        return new int[] { -1, -1 }; 
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSumSolution.TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]"); 
    }
}
